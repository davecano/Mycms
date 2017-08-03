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
   public  class mycms_news_DAL
    {
       
            DbHelper db = new DbHelper();
            #region 查看所有栏目

            public IList<mycms_news> GetNewsList(Query q)
            {
                return db.Query<mycms_news>(q, 1, 1000);
            }

            #endregion
            #region 根据栏目id查看子栏目

            #endregion


            public int Insert(mycms_news m)
            {
                return db.Insert<mycms_news>(m);
            }
            public int Delete(mycms_news m)
            {
                return db.Delete<mycms_news>(m);
            }
            public int Update(mycms_news m)
            {
                return db.Update<mycms_news>(m);
            }

            public mycms_news GetNewsById(int newsID)
            {
                return db.GetEntityById<mycms_news>(newsID);
            }

        }
    }
