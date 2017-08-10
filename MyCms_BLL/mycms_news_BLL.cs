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
