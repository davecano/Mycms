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
    public class mycms_class_DAL
    {
        DbHelper db=new DbHelper();
        #region 查看所有栏目

        public IList<mycms_class> GetClassList(Query q)
        {
            return db.Query<mycms_class>(q, 1, 1000);
        }

        #endregion
        #region 根据栏目id查看子栏目

        #endregion
   

        public int Insert(mycms_class m)
        {
            return db.Insert<mycms_class>(m);
        }
        public int Delete(mycms_class m)
        {
            return db.Delete<mycms_class>(m);
        }
        public int Update(mycms_class m)
        {
            return db.Update<mycms_class>(m);
        }

        public mycms_class GetClassById(int classID)
        {
            return db.GetEntityById<mycms_class>(classID);
        }
        public int GetMaxID()
        {
            string ret = db.ExecuteScalar("select max(Id) from mycms_class").ToString();
            if (ret == "")
                return 0;
            else
                return int.Parse(ret);
        }
    }
}
