using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_DAL;
using MyCms_Model;
using SysBase.Model;
using Z;


namespace MyCms_BLL
{
    public class MyCmsManage
    {
        mycms_user_DAL mud = new mycms_user_DAL();
        #region"用户操作"
        /// <summary>
        /// 分页查询用户列表
        /// </summary>
        /// <param name="q"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="totalcount"></param>
        /// <returns></returns>
        public IList<mycms_user> Getmycms_userList(Query q, int pageindex, int pagesize, out int totalcount)
        {          
            return  mud.Getmycms_userList(q, pageindex, pagesize, out totalcount);
        }

        public IList<mycms_user> Getmycms_userList(Query q)
        {
            return mud.Getmycms_userList(q);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="UserName">登录名</param>
        /// <returns></returns>
        public mycms_user GetUserByUserName(string UserName)
        {
            return mud.Getmycms_userByUserName(UserName);
        }
        /// <summary>
        /// 根据用户编号获取用户详细信息
        /// </summary>
        /// <param name="UserID">用户编号</param>
        /// <param name="UserID">是否获取菜单和权限信息</param>
        /// <returns></returns>
        
        public mycms_user GetUserByUserID(string UserID)
        {
            return mud.Getmycms_userByUserId(UserID);
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="su"></param>
        /// <returns>-1:不成功;1：成功;2:登录名重复;3:用户编号重复</returns>
        public int AddUser(mycms_user su)
        {
            if (mud.Getmycms_userByUserId(su.UserID) != null)
            {
                return 3;
            }
            if (mud.Getmycms_userByUserName(su.UserName) != null)
            {
                return 2;
            }
            return mud.Insertmycms_user(su);
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="su"></param>
        /// <returns>-1:不成功;1:成功;2:登录名重复</returns>
        public int UpdateUser(mycms_user su)
        {
            if (su.UserName != null)
            {
                IList<mycms_user> ss = mud.Getmycms_userListByUserName(su.UserName);
                if (ss.Count >= 2)
                {
                    return 2;
                }
            }
            return mud.Updatemycms_user(su);
        }
        
  
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns>-1:不成功;1：成功</returns>
        public int DeleteUser(string UserID)
        {

            return mud.Deletemycms_user(new mycms_user() { UserID = UserID });
        }
        #endregion
    }


}
