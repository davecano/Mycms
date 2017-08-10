using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_pic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
   [Table(TableName = "mycms_pic", PrimaryKeys = "Id")]
    [Serializable]
	public partial class mycms_pic
	{
		public mycms_pic()
		{}
		#region Model
		private int _id;
		private string _title;
        private string _picurl;
   
		private int? _newsid;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
        /// <summary>
        public string PicUrl
        {
            set { _picurl = value; }
            get { return _picurl; }
        }
        /// </summary>

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

