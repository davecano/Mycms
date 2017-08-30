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
   public  class mycms_site_DAL
    {
       
            DbHelper db = new DbHelper();
            #region 查看所有栏目

            public IList<mycms_site> GetSiteList(Query q)
            {
                return db.Query<mycms_site>(q, 1, 1000);
            }

            #endregion
            #region 根据栏目id查看子栏目

            #endregion


            public int Insert(mycms_site m)
            {
                return db.Insert<mycms_site>(m);
            }
            public int Delete(mycms_site m)
            {
                return db.Delete<mycms_site>(m);
            }
            public int Update(mycms_site m)
            {
                return db.Update<mycms_site>(m);
            }

            public mycms_site GetSiteById(int menuID)
            {
                return db.GetEntityById<mycms_site>(menuID);
            }

        }
    }
