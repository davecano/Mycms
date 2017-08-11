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

        public IList<mycms_temptates> GetTemptatesList(Query q)
        {
            return db.Query<mycms_temptates>(q, 1, 1000);
        }

    
        #endregion
        public IList<mycms_temptates> GetTemptatesList(Query q, int pageindex, int pagesize, out int totalcount)
        {
            
            return db.Query<mycms_temptates>(q, pageindex, pagesize, out totalcount);
        }


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
        public int GetMaxID()
        {
            string ret = db.ExecuteScalar("select max(Id) from mycms_temptates").ToString();
            if (ret == "")
                return 0;
            else
                return int.Parse(ret);
        }

    }
    public class mycms_temptate_public_DAL
    {

        DbHelper db = new DbHelper();
        #region 查看所有模板

        public IList<mycms_temptate_public> GetTemptatesPublicList(Query q)
        {
            return db.Query<mycms_temptate_public>(q, 1, 1000);
        }

        public IList<mycms_temptate_public> GetTemptatesPublicList(Query q, int pageindex, int pagesize, out int totalcount)
        {
            return db.Query<mycms_temptate_public>(q, pageindex, pagesize, out totalcount);
        }
        #endregion



        public int Insert(mycms_temptate_public m)
        {
            return db.Insert<mycms_temptate_public>(m);
        }
        public int Delete(mycms_temptate_public m)
        {
            return db.Delete<mycms_temptate_public>(m);
        }
        public int Update(mycms_temptate_public m)
        {
            return db.Update<mycms_temptate_public>(m);
        }

        public mycms_temptate_public GetTemptatesById(int temptatesID)
        {
            return db.GetEntityById<mycms_temptate_public>(temptatesID);
        }
        public int GetMaxID()
        {
            string ret = db.ExecuteScalar("select max(Id) from mycms_temptate_public").ToString();
            if (ret == "")
                return 0;
            else
                return int.Parse(ret);
        }

    }
}

