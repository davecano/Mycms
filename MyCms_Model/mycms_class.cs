using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z;


namespace MyCms_Model
{
    /// <summary>
    /// mycms_class:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
 
    [Table(TableName = "mycms_class", PrimaryKeys = "Id")]
  
    public class mycms_class
	{
       
        public mycms_class()
		{}
		#region Model
		private int _id;
		private string _classname;
		private int? _parentid;
		private int? _sortrank;
		private bool? _isonnav;
		private bool? _isonindex;
		private bool? _isforbidden;
        /// <summary>
        /// 
        /// </summary>  
         [ColumnAttribute(PrimaryKey = true)]
        public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SortRank
		{
			set{ _sortrank=value;}
			get{return _sortrank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsOnNav
		{
			set{ _isonnav=value;}
			get{return _isonnav;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsOnIndex
		{
			set{ _isonindex=value;}
			get{return _isonindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsForbidden
		{
			set{ _isforbidden=value;}
			get{return _isforbidden;}
		}
		#endregion Model

	}
}

