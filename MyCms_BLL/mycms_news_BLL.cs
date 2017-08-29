using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_DAL;
using MyCms_Model;
using SysBase.DAL;
using SysBase.Model;
using Z;

namespace MyCms_BLL
{
    //public struct News
    //{
    //    public int newsId;
    //    public int classId;
    //    public int index;
    //};
    //public static class SaveNewsId
    //{

    //    public static IList<int> newsid;
    //}
    public class mycms_news_Manage
    {
        mycms_news_DAL mnd = new mycms_news_DAL();

        #region"增删改"
        public int Insert(mycms_news m)
        {
            return mnd.Insert(m);
        }
        public int Update(mycms_news m)
        {
            return mnd.Update(m);
        }
        public int Delete(mycms_news m)
        {

            return mnd.Delete(m);
        }
        #endregion


        /// <summary>
        /// 根据条件查询所有菜单
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public IList<mycms_news> GetNewsList(Query q, int pageindex, int pagesize, out int totalcount)
        {
            return mnd.GetNewsList(q, pageindex, pagesize, out totalcount);
        }
        public IList<mycms_news> GetNewsList(Query q)
        {
            return mnd.GetNewsList(q);
        }
        public IList<mycms_news> GetNewsList(Query q1,Query q2)
        {
            return mnd.GetNewsList(q1,q2);
        }
        public IList<mycms_news> GetNewsList(string sql,Query q)
        {
            return mnd.GetNewsList(sql,q);
        }
        public IList<mycms_news> GetNewsList(string sql, Query q1,Query q2)
        {
            return mnd.GetNewsList(sql, q1,q2);
        }
        public int getcount(string sql, Query q)
        {
            return mnd.getcount(sql, q);
        }

        public mycms_news GetNewsByID(int newsid)
        {
            return mnd.GetNewsById(newsid);
        }
        public int GetMaxID()
        {
            return mnd.GetMaxID();
        }

    }


}
