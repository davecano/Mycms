using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_temptates:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class mycms_temptates
	{
		public mycms_temptates()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _tptype;
		private string __source;
		private int? _isinclude;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TpType
		{
			set{ _tptype=value;}
			get{return _tptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string _Source
		{
			set{ __source=value;}
			get{return __source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsInclude
		{
			set{ _isinclude=value;}
			get{return _isinclude;}
		}
		#endregion Model

	}
}

