using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class mycms_user
	{
		public mycms_user()
		{}
		#region Model
		private int _id;
		private string _userid;
		private string _username;
		private string _truename;
		private string _userpsw;
		private int? _sex;
		private string _email;
		private string _phone;
		private int? __power;
		private string _loginip;
		private int? _isforbidden;
		private DateTime? _regtime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TrueName
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPsw
		{
			set{ _userpsw=value;}
			get{return _userpsw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? _Power
		{
			set{ __power=value;}
			get{return __power;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginIp
		{
			set{ _loginip=value;}
			get{return _loginip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsForbidden
		{
			set{ _isforbidden=value;}
			get{return _isforbidden;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RegTime
		{
			set{ _regtime=value;}
			get{return _regtime;}
		}
		#endregion Model

	}
}

