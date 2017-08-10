using System;
using System.Collections;
using System.Collections.Generic;
using MyCms_BLL;
using MyCms_Model;
using SysBase.BLL;
using SysBase.Model;
using Z;


namespace MyCmsWEB
{
    public partial class Login : System.Web.UI.Page
    {
      //  private readonly MyCmsManage bu = new MyCmsManage();//改用pagebase的systemuser来做用户
        BUser bu = new BUser();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUserName.Text = "admin";
                txtUserPwd.Text = "999999";
            }
        }

        protected void LinkButton1_OnClick(object sender, EventArgs e)
        {
            //var mu = mcm.GetUserByUserName(PubCom.CheckString(txtUserName.Text.ToLower()));
     
           SysUser mu = bu.GetUserByUserLoginName(PubCom.CheckString(txtUserName.Text.ToLower()));
            if (mu == null)
            {
                Message.ShowWrong(this, " 不存在此用户");
                return;
            }

            if (mu.UserPassword == Z.EncryptHelper.EncryptPassword(txtUserPwd.Text.Trim(), Constants.PassWordEncodeType))
                if (PubCom.login(mu, PubCom.CheckString(txtUserName.Text.ToLower()), txtUserPwd.Text.Trim()))
                    Response.Redirect("~/Public/Index.aspx");
                     else
                    Message.ShowWrong(this, "用户名或密码错误");
                    else
                        Message.ShowWrong(this, "用户名或密码错误");

        }
    }
}
