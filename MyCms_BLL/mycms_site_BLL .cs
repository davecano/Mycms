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
    public class mycms_site_Manage
    {
        mycms_site_DAL mnd = new mycms_site_DAL();

        #region"增删改"
        public int Insert(mycms_site m)
        {
            return mnd.Insert(m);
        }
        public int Update(mycms_site m)
        {
            return mnd.Update(m);
        }
        public int Delete(mycms_site m)
        {

            return mnd.Delete(m);
        }
        #endregion


        /// <summary>
        /// 根据条件查询所有菜单
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public IList<mycms_site> GetSiteList(Query q)
        {
            return mnd.GetSiteList(q);
        }

        public mycms_site GetSiteByID(int menuid)
        {
            return mnd.GetSiteById(menuid);
        }


    }


}
