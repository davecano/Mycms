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
    public class mycms_menu_Manage
    {
        mycms_menu_DAL mnd = new mycms_menu_DAL();

        #region"增删改"
        public int Insert(mycms_menu m)
        {
            return mnd.Insert(m);
        }
        public int Update(mycms_menu m)
        {
            return mnd.Update(m);
        }
        public int Delete(mycms_menu m)
        {

            return mnd.Delete(m);
        }
        #endregion


        /// <summary>
        /// 根据条件查询所有菜单
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public IList<mycms_menu> GetMenuList(Query q)
        {
            return mnd.GetMenuList(q);
        }

        public mycms_menu GetMenuByID(int menuid)
        {
            return mnd.GetMenuById(menuid);
        }


    }


}
