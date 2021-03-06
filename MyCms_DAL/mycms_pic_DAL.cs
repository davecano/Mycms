﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_Model;
using Z;
using Z.Data;

namespace MyCms_DAL
{
   public class mycms_pic_DAL
   {
       private string sql = "select p.*,q.ClassId from mycms_pic p left join mycms_news q on p.NewsId=q.Id  where 1=1 {0}";
        DbHelper db = new DbHelper();
        #region 查看所有模板

        public IList<mycms_pic> GetPicsList(Query q)
        {
            return db.Query<mycms_pic>(string.Format(sql, q.GetCondition(true))); ;
        }

        #endregion



        public int Insert(mycms_pic m)
        {
            return db.Insert<mycms_pic>(m);
        }
        public int Delete(mycms_pic m)
        {
            return db.Delete<mycms_pic>(m);
        }
        public int Update(mycms_pic m)
        {
            return db.Update<mycms_pic>(m);
        }

        public mycms_pic GetPicById(int picID)
        {
            return db.GetEntityById<mycms_pic>(picID);
        }
        public int GetMaxID()
        {
            string ret = db.ExecuteScalar("select max(Id) from mycms_pic").ToString();
            if (ret == "")
                return 0;
            else
                return int.Parse(ret);
        }
    }
}
