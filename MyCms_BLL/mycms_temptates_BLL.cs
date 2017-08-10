using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_DAL;
using MyCms_Model;
using Z;

namespace MyCms_BLL
{
    public class mycms_temptates_Manage
    {
        mycms_temptates_DAL mtd = new mycms_temptates_DAL();

        #region"增删改"
        public int GetMaxID()
        {
            return mtd.GetMaxID();
        }
        public int Insert(mycms_temptates m)
        {
            return mtd.Insert(m);
        }
        public int Update(mycms_temptates m)
        {
            return mtd.Update(m);
        }
        public int Delete(mycms_temptates m)
        {

            return mtd.Delete(m);
        }
        #endregion


        /// <summary>
        /// 根据条件查询所有菜单
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public IList<mycms_temptates> GetNewsList(Query q)
        {
            return mtd.GetNewsList(q);
        }

        public mycms_temptates GetTemptatesByID(int temptatesid)
        {
            return mtd.GetTemptatesById(temptatesid);
        }


    }
    public class mycms_temptates_public_Manage
    {
        mycms_temptates_public_DAL mtpd = new mycms_temptates_public_DAL();

        #region"增删改"
        public int GetMaxID()
        {
            return mtpd.GetMaxID();
        }
        public int Insert(mycms_temptates_public m)
        {
            return mtpd.Insert(m);
        }
        public int Update(mycms_temptates_public m)
        {
            return mtpd.Update(m);
        }
        public int Delete(mycms_temptates_public m)
        {

            return mtpd.Delete(m);
        }
        #endregion


        /// <summary>
        /// 根据条件查询所有菜单
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public IList<mycms_temptates_public> GetNewsList(Query q)
        {
            return mtpd.GetNewsList(q);
        }

        public mycms_temptates_public GetTemptatesByID(int temptatesid)
        {
            return mtpd.GetTemptatesById(temptatesid);
        }


    }
}
