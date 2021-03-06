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
   public  class mycms_news_DAL
    {
       
            DbHelper db = new DbHelper();
        private string Vsql = "select p.*,q.ClassName from mycms_news p left join mycms_class q on p.ClassId=q.Id where 1=1{0}";
        private string Sql= "select * from(select  top 100 percent row_number()over(order by AddTime Desc, IsTop Desc) as NewsIndex ,p.*,q.ClassName from mycms_news p left join mycms_class q on p.ClassId=q.Id where 1=1{0}) as T where 1=1{1}";
            #region 查看所有栏目
       

        //public IList<mycms_news> GetNewsList(Query q)
        //{
        //    return db.Query<mycms_news>(q, 1, 1000);
        //}
        public IList<mycms_news> GetNewsList(Query q, int pageindex, int pagesize, out int totalcount)
        {
            return db.Query<mycms_news>(string.Format(Vsql, q.GetCondition(true)), pageindex, pagesize, out totalcount);
        }
        public IList<mycms_news> GetNewsList(Query q)
        {
            return db.Query<mycms_news>(string.Format(Vsql, q.GetCondition(true)));
        }
        public IList<mycms_news> GetNewsList(Query q1,Query q2)
        {
            return db.Query<mycms_news>(string.Format(Sql, q1.GetCondition(true), q2.GetCondition(true)));
        }
        public IList<mycms_news> GetNewsList(string sql,Query q)
        {
            return db.Query<mycms_news>(string.Format(sql, q.GetCondition(true)));
        }
        public IList<mycms_news> GetNewsList(string sql, Query q1,Query q2)
        {
            return db.Query<mycms_news>(string.Format(sql, q1.GetCondition(true), q2.GetCondition(true)));
        }
        public int  getcount(string sql, Query q)
        {
            return (int)db.ExecuteScalar(string.Format(sql, q.GetCondition(false)));

        }
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
   
        public int GetMaxID()
        {
            string ret = db.ExecuteScalar("select max(Id) from mycms_news").ToString();
            if (ret == "")
                return 0;
            else
                return int.Parse(ret);
        }
  
    }
}
