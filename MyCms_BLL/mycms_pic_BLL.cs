using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_DAL;
using MyCms_Model;
using Z;

namespace MyCms_BLL
{
  
    public class mycms_pic_Manage
    {
        mycms_pic_DAL mpd = new mycms_pic_DAL();

        #region"增删改"
        public int Insert(mycms_pic m)
        {
            return mpd.Insert(m);
        }
        public int Update(mycms_pic m)
        {
            return mpd.Update(m);
        }
        public int Delete(mycms_pic m)
        {

            return mpd.Delete(m);
        }
        #endregion


        /// <summary>
        /// 根据条件查询所有菜单
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public IList<mycms_pic> GetNewsList(Query q)
        {
            return mpd.GetNewsList(q);
        }

        public mycms_pic GetPicByID(int picid)
        {
            return mpd.GetPicById()ById(picid);
        }


    }
}
