using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_Model;
using Z;
using Z.Data;

namespace MyCms_DAL
{
   public  class mycms_menu_DAL
    {
       
            DbHelper db = new DbHelper();
            #region 查看所有栏目

            public IList<mycms_menu> GetMenuList(Query q)
            {
                return db.Query<mycms_menu>(q, 1, 1000);
            }

            #endregion
            #region 根据栏目id查看子栏目

            #endregion


            public int Insert(mycms_menu m)
            {
                return db.Insert<mycms_menu>(m);
            }
            public int Delete(mycms_menu m)
            {
                return db.Delete<mycms_menu>(m);
            }
            public int Update(mycms_menu m)
            {
                return db.Update<mycms_menu>(m);
            }

            public mycms_menu GetMenuById(int menuID)
            {
                return db.GetEntityById<mycms_menu>(menuID);
            }

        }
    }
