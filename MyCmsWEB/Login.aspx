<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyCmsWEB.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="robots" content="noindex, nofollow"/>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7"/>
    <title>后台登录</title>

    <link href="mycss/style.css" rel="stylesheet"/>
    <script src="myjs/jquery-3.2.1.js"></script>
    <script src="myjs/layer.js"></script>
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
        <script src="js/html5shiv.js"></script>
        <script src="js/respond.min.js"></script>
    <![endif]-->
    <script type="text/javascript">
        $(document).ready(function() {
            $("#LinkButton1").click(function() {
                var res = true;
                if ($.trim($("#txtUserName").val()) == "") {
                    layer.tips("请输入登录名称", $("#txtUserName"), { guide: 1, time: 3 });
                    $("#txtUserName").focus();
                    res = false;
                }
                if ($.trim($("#txtUserPwd").val()) == "") {
                    layer.tips("请输入登录密码", $("#txtUserPwd"), { guide: 1, time: 3 });
                    $("#txtUserPwd").focus();
                    res = false;
                }
                return res;
            });

        });
    </script>


</head>
<body class="login-body" id="body">
<form id="form1" runat="server">
    <div class="container">

        <div class="form-signin">
            <div class="form-signin-heading text-center">
                <h1 class="sign-title">Made by Davecano</h1>
                <img src="images/login-logo.png" alt=""/>
            </div>
            <div class="login-wrap">
                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="管理员账号"></asp:TextBox>
                <asp:TextBox ID="txtUserPwd" runat="server" CssClass="form-control" placeholder="管理员密码" ></asp:TextBox>

                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-lg btn-login btn-block" OnClick="LinkButton1_OnClick">
                    <i class="fa fa-check"></i>
                </asp:LinkButton>


            </div>


        </div>

    </div>

</form>
</body>
</html>