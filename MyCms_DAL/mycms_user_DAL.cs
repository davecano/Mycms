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
   public class mycms_user_DAL
    {
        DbHelper db = new DbHelper();
        public int Insertmycms_user(mycms_user m)
        {
            return db.Insert<mycms_user>(m);
        }
        public int Updatemycms_user(mycms_user m)
        {
            return db.Update<mycms_user>(m);
        }
        public int Deletemycms_user(mycms_user m)
        {
            // db.ExecuteNonQuery("delete from RegInfo where UserID='" + m.UserID + "'");
            return db.Delete<mycms_user>(m);
        }
        public mycms_user Getmycms_userByUserId(string UserID)
        {
            return db.GetEntityById<mycms_user>(UserID);
        }

        public IList<mycms_user> Getmycms_userList(Query q, int pageindex, int pagesize, out int totalcount)
        {
            return db.Query<mycms_user>(q, pageindex, pagesize, out totalcount);
        }

        public IList<mycms_user> Getmycms_userList(Query q)
        {
            return db.Query<mycms_user>(q);
        }

        /// <summary>
        /// 根据条件查询单个用户实体对象
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public mycms_user Getmycms_userByUserName(string UserName)
        {
            var qm = new Query();
            qm.Append("UserName='" + UserName + "'");
            return db.GetEntityWithQuery<mycms_user>(qm);
        }
        public IList<mycms_user> Getmycms_userListByUserName(string UserName)
        {
            var qm = Query.Build(new { SortFields = "UserID" });
            qm.Append("UserName='" + UserName + "'");
            return db.Query<mycms_user>(qm);

        }
    }
}

