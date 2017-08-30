using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_BLL;
using MyCms_Model;
using Z;
using System.Web;

namespace MyCms_TEngine
{
    public class myclass
    {
        public int pageSize { get; } = 2;


        public int GetIndexByNewsId(int newsid, int pagesize)
        {
            Query q = Query.Build(new {SortFields = "AddTime Desc,IsTop Desc"});
            Query q2 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            mycms_news_Manage mnm = new mycms_news_Manage();
            int pageindex;
            var NewsEntity = mnm.GetNewsByID(newsid);
            q.Add("ClassId",NewsEntity.ClassId);
            q2.Add("Id", newsid);
            var news = mnm.GetNewsList(q, q2);
            if (news[0].NewsIndex % pagesize == 0)
                pageindex =(int) news[0].NewsIndex / pagesize;
            else
                pageindex = (int)news[0].NewsIndex / pagesize + 1;
            return pageindex;
        }
        public void GenerateHtml(string temptate,int  classId,System.Web.UI.Page objpage)
        {
            HtmlPager hp = new HtmlPager();
            string tempath = HttpContext.Current.Server.MapPath(@"~/TemptatesFile");
            string shtmlpath = HttpContext.Current.Server.MapPath(@"~/");
            mycms_news_Manage mnm = new mycms_news_Manage();
            NVelocityHelper VH = new NVelocityHelper(tempath);
            //int page = 1;
            //try
            //{
            //    page = Convert.ToInt32(Request.QueryString["page"].ToString());
            //}
            //catch
            //{ }

            Query q = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            q.Append("ClassId=" + classId);
            //VH.Put("ClassId",p.Id);
            int pageCount;
          

            var query = mnm.GetNewsList("select Id,Title,AddTime from mycms_news where 1=1{0}", q);

            //PageSplit pager = new PageSplit();
            //pager.SetPage(VH, "ClassId="+p.Id, page);//分页计算
            //VH.Put("query", "ClassId=" + p.Id);

            //VH.Put("infos",new InfoDAL() );

            //每页条数  

            //页码 0也就是第一条 
            if (query.Count % pageSize == 0)
                pageCount = query.Count / pageSize;
            else
                pageCount = query.Count / pageSize + 1;

            int pageNum = 0;
            while (pageNum * pageSize < query.Count)
            {
                mycms_site_Manage msm = new mycms_site_Manage();
                var site = msm.GetSiteByID(1);
                VH.Put("SiteTitle", site.SiteFullName);
                VH.Put("SiteDescription", site.SiteDescription);
                VH.Put("SiteKeywords", site.SiteKeyword);
                //分页   
                var newslist = query.Skip(pageNum * pageSize).Take(pageSize);
                VH.Put("newslist", newslist);
                string fenye = hp.GePageNavgation((pageNum + 1), pageCount, "_list.shtml");
                VH.Put("num", fenye);
                VH.Put("SiteDir", @"/");
                if (
                    !VH.GenerateShtml(temptate, shtmlpath + "CreateHtml\\" + classId,
                      (pageNum + 1).ToString() + "_list.shtml"))

                {

                    Message.ShowWrong(objpage, "create news failed");
                    break;
                }
                pageNum++;
            }
            Message.ShowOK(objpage, "create news success");
        }
        public void GenerateHtml(string temptate, int classId, System.Web.UI.Page objpage,int index)
        {
            HtmlPager hp = new HtmlPager();
            string tempath = HttpContext.Current.Server.MapPath(@"~/TemptatesFile");
            string shtmlpath = HttpContext.Current.Server.MapPath(@"~/");
            mycms_news_Manage mnm = new mycms_news_Manage();
            NVelocityHelper VH = new NVelocityHelper(tempath);
            //int page = 1;
            //try
            //{
            //    page = Convert.ToInt32(Request.QueryString["page"].ToString());
            //}
            //catch
            //{ }
            var newscount = index * pageSize;
            Query qc = Query.Build();
            Query q1 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            Query q2 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            qc.Append("p.ClassId=" + classId);
            q1.Append("p.ClassId=" + classId);
            //VH.Put("ClassId",p.Id);
            q2.Lt("T.NewsIndex", newscount);

            int pageCount;
            var count = mnm.getcount("select count(*) from mycms_news as p where 1=1{0} ", qc);
            var query = mnm.GetNewsList("select * from(select top 100 percent row_number()over(order by AddTime Desc, IsTop Desc) as NewsIndex,p.Id,p.IsTop, p.Title,p.AddTime,q.ClassName from mycms_news p left join mycms_class q on p.ClassId = q.Id where 1 = 1{0}) as T where 1=1{1}", q1,q2);
            //var query = mnm.GetNewsList(q1,q2);

            //PageSplit pager = new PageSplit();
            //pager.SetPage(VH, "ClassId="+p.Id, page);//分页计算
            //VH.Put("query", "ClassId=" + p.Id);

            //VH.Put("infos",new InfoDAL() );

            //每页条数  

            //页码 0也就是第一条 
            if (count % pageSize == 0)
                pageCount = count / pageSize;
            else
                pageCount = count / pageSize + 1;

            int pageNum = 0;
            while (pageNum * pageSize < query.Count)
            {
                mycms_site_Manage msm = new mycms_site_Manage();
                var site = msm.GetSiteByID(1);
                VH.Put("SiteTitle", site.SiteFullName);
                VH.Put("SiteDescription", site.SiteDescription);
                VH.Put("SiteKeywords", site.SiteKeyword);
                //分页   
                var newslist = query.Skip(pageNum * pageSize).Take(pageSize);

                VH.Put("newslist", newslist);
                string fenye = hp.GePageNavgation((pageNum + 1), pageCount, "_list.shtml");
                VH.Put("num", fenye);
                VH.Put("SiteDir", @"/");
                if (
                    !VH.GenerateShtml(temptate, shtmlpath + "CreateHtml\\" + classId,
                      (pageNum + 1).ToString() + "_list.shtml"))

                {

                    Message.ShowWrong(objpage, "create news failed");
                    break;
                }
                pageNum++;
            }
            Message.ShowOK(objpage, "create news success");
        }
        public void GenerateHtml(string temptate, int classId, System.Web.UI.Page objpage, int index,bool isdelete)
        {
            HtmlPager hp = new HtmlPager();
            string tempath = HttpContext.Current.Server.MapPath(@"~/TemptatesFile");
            string shtmlpath = HttpContext.Current.Server.MapPath(@"~/");
            mycms_news_Manage mnm = new mycms_news_Manage();
            NVelocityHelper VH = new NVelocityHelper(tempath);
            //int page = 1;
            //try
            //{
            //    page = Convert.ToInt32(Request.QueryString["page"].ToString());
            //}
            //catch
            //{ }
            var lnewscount = (index-1) * pageSize;
            var rnewscount = index * pageSize;
            Query q1 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            Query q2 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            q1.Append("p.ClassId=" + classId);
            //VH.Put("ClassId",p.Id);
            q2.Lt("T.NewsIndex", rnewscount);
            q2.Gt("T.NewsIndex",lnewscount,true);
            //q2.Between("T.NewsIndex", lnewscount, rnewscount);
            int pageCount;

            var query = mnm.GetNewsList("select * from(select top 100 percent row_number()over(order by AddTime Desc, IsTop Desc) as NewsIndex,p.Id, p.Title,p.AddTime,p.IsTop,q.ClassName from mycms_news p left join mycms_class q on p.ClassId = q.Id where 1 = 1{0}) as T where 1=1{1}", q1, q2);

            //PageSplit pager = new PageSplit();
            //pager.SetPage(VH, "ClassId="+p.Id, page);//分页计算
            //VH.Put("query", "ClassId=" + p.Id);

            //VH.Put("infos",new InfoDAL() );

            //每页条数  

            //页码 0也就是第一条 
            if (query.Count % pageSize == 0)
                pageCount = query.Count / pageSize;
            else
                pageCount = query.Count / pageSize + 1;

            int pageNum = 0;
            while (pageNum * pageSize < query.Count)
            {
                mycms_site_Manage msm = new mycms_site_Manage();
                var site = msm.GetSiteByID(1);
                VH.Put("SiteTitle", site.SiteFullName);
                VH.Put("SiteDescription", site.SiteDescription);
                VH.Put("SiteKeywords", site.SiteKeyword);
                //分页   
                var newslist = query.Skip(pageNum * pageSize).Take(pageSize);

                VH.Put("newslist", newslist);
                string fenye = hp.GePageNavgation((pageNum + 1), pageCount, "_list.shtml");
                VH.Put("num", fenye);
                VH.Put("SiteDir", @"/");
                if (
                    !VH.GenerateShtml(temptate, shtmlpath + "CreateHtml\\" + classId,
                      (pageNum + 1).ToString() + "_list.shtml"))

                {

                    Message.ShowWrong(objpage, "create news failed");
                    break;
                }
                pageNum++;
            }
            Message.ShowOK(objpage, "create news success");
        }
        public void GenerateContentHtml(string temptate, int classId, System.Web.UI.Page objpage)
        {

            mycms_news_Manage mnm = new mycms_news_Manage();
            string tempath = HttpContext.Current.Server.MapPath(@"~/TemptatesFile");
            string shtmlpath = HttpContext.Current.Server.MapPath(@"~/");
          
            Query qm = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            qm.Add("ClassId",classId);
            var list = mnm.GetNewsList(qm);//得到相关栏目下的newlist全部生成了

            mycms_news[] a = new mycms_news[list.Count];
            int i = 0;
            foreach (var p1 in list)
            {
                a[i] = p1;
                i++;
            }

            for (int j = 0; j < list.Count; j++)
            {
                NVelocityHelper VH = new NVelocityHelper(tempath);
                mycms_site_Manage msm = new mycms_site_Manage();
                var site = msm.GetSiteByID(1);
                VH.Put("SiteTitle", site.SiteFullName);
                VH.Put("SiteDescription", site.SiteDescription);
                VH.Put("SiteKeywords", site.SiteKeyword);

                VH.Put("LTitle", j == 0 ? "没有了" : "<a href ='" + a[j - 1].Id + "_news.shtml'>" + a[j - 1].Title + "</a>");
                VH.Put("RTitle", j == list.Count - 1 ? "没有了" : "<a href ='" + a[j + 1].Id + "_news.shtml'>" + a[j + 1].Title + "</a>");


                VH.Put("news", a[j]);
                VH.Put("SiteDir", "/");
                if (
                    !VH.GenerateShtml(temptate, shtmlpath + "CreateHtml\\" + a[j].ClassId,
                        a[j].Id + "_news.shtml"))

                {
                    Message.ShowWrong(objpage, "create news failed");
                    break;
                }
            }

            Message.ShowOK(objpage, "create news success");
        }
        public void GenerateContentHtml(string temptate, int classId, System.Web.UI.Page objpage,int index,bool isdelete)
        {

            mycms_news_Manage mnm = new mycms_news_Manage();
            string tempath = HttpContext.Current.Server.MapPath(@"~/TemptatesFile");
            string shtmlpath = HttpContext.Current.Server.MapPath(@"~/");
           
            var rnewscount = (index+1) * pageSize;
            var lnewscount = (index-2) * pageSize;
            Query q1 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            Query q2 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            q1.Append("p.ClassId=" + classId);
            //VH.Put("ClassId",p.Id);
            q2.Lt("T.NewsIndex", rnewscount);
            q2.Gt("T.NewsIndex", lnewscount,true);
            var list = mnm.GetNewsList(q1, q2);


            mycms_news[] a = new mycms_news[list.Count];
            int i = 0;
            foreach (var p1 in list)
            {
                a[i] = p1;
                i++;
            }

            for (int j = 0; j < list.Count; j++)
            {
                NVelocityHelper VH = new NVelocityHelper(tempath);
                mycms_site_Manage msm = new mycms_site_Manage();
                var site = msm.GetSiteByID(1);
                VH.Put("SiteTitle", site.SiteFullName);
                VH.Put("SiteDescription", site.SiteDescription);
                VH.Put("SiteKeywords", site.SiteKeyword);

                VH.Put("LTitle", j == 0 ? "没有了" : "<a href ='" + a[j - 1].Id + "_news.shtml'>" + a[j - 1].Title + "</a>");
                VH.Put("RTitle", j == list.Count - 1 ? "没有了" : "<a href ='" + a[j + 1].Id + "_news.shtml'>" + a[j + 1].Title + "</a>");


                VH.Put("news", a[j]);
                VH.Put("SiteDir", "/");
                if (
                    !VH.GenerateShtml(temptate, shtmlpath + "CreateHtml\\" + a[j].ClassId,
                        a[j].Id + "_news.shtml"))

                {
                    Message.ShowWrong(objpage, "create news failed");
                    break;
                }
            }

            Message.ShowOK(objpage, "create news success");
        }
        public void GenerateContentHtml(string temptate, int classId, System.Web.UI.Page objpage, int index)
        {

            mycms_news_Manage mnm = new mycms_news_Manage();
            string tempath = HttpContext.Current.Server.MapPath(@"~/TemptatesFile");
            string shtmlpath = HttpContext.Current.Server.MapPath(@"~/");
          
            var newscount = index * pageSize;
            Query q1 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            Query q2 = Query.Build(new { SortFields = "AddTime Desc,IsTop Desc" });
            q1.Append("p.ClassId=" + classId);
            //VH.Put("ClassId",p.Id);
            q2.Lt("T.NewsIndex", newscount);
            var list = mnm.GetNewsList(q1, q2);


            mycms_news[] a = new mycms_news[list.Count];
            int i = 0;
            foreach (var p1 in list)
            {
                a[i] = p1;
                i++;
            }

            for (int j = 0; j < list.Count; j++)
            {
                NVelocityHelper VH = new NVelocityHelper(tempath);
                mycms_site_Manage msm = new mycms_site_Manage();
                var site = msm.GetSiteByID(1);
                VH.Put("SiteTitle", site.SiteFullName);
                VH.Put("SiteDescription", site.SiteDescription);
                VH.Put("SiteKeywords", site.SiteKeyword);
                VH.Put("LTitle", j == 0 ? "没有了" : "<a href ='" + a[j - 1].Id + "_news.shtml'>" + a[j - 1].Title + "</a>");
                VH.Put("RTitle", j == list.Count - 1 ? "没有了" : "<a href ='" + a[j + 1].Id + "_news.shtml'>" + a[j + 1].Title + "</a>");


                VH.Put("news", a[j]);
                VH.Put("SiteDir", "/");
                if (
                    !VH.GenerateShtml(temptate, shtmlpath + "CreateHtml\\" + a[j].ClassId,
                        a[j].Id + "_news.shtml"))

                {
                    Message.ShowWrong(objpage, "create news failed");
                    break;
                }
            }

            Message.ShowOK(objpage, "create news success");
        }
    }
}
