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
 
        public class mycms_temptates_DAL
        {

            DbHelper db = new DbHelper();
            #region 查看所有模板

            public IList<mycms_temptates> GetNewsList(Query q)
            {
                return db.Query<mycms_temptates>(q, 1, 1000);
            }

            #endregion
          


            public int Insert(mycms_temptates m)
            {
                return db.Insert<mycms_temptates>(m);
            }
            public int Delete(mycms_temptates m)
            {
                return db.Delete<mycms_temptates>(m);
            }
            public int Update(mycms_temptates m)
            {
                return db.Update<mycms_temptates>(m);
            }

            public mycms_temptates GetTemptatesById(int temptatesID)
            {
                return db.GetEntityById<mycms_temptates>(temptatesID);
            }

        }
    }

