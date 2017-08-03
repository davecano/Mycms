using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_pic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class mycms_pic
	{
		public mycms_pic()
		{}
		#region Model
		private int _id;
		private string _title;
		private int? _iwidth;
		private int? _iheight;
		private int? _newsid;
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
		public int? Iwidth
		{
			set{ _iwidth=value;}
			get{return _iwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Iheight
		{
			set{ _iheight=value;}
			get{return _iheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NewsId
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		#endregion Model

	}
}

