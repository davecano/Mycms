using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_news:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
     [Table(TableName = "mycms_news", PrimaryKeys = "Id")]
    [Serializable]
	public partial class mycms_news
	{
		public mycms_news()
		{}
        #region Model
        private int _id;
        private int? _index;
        private int _istop;
        private int _classid;
        private string _classname;
		private string _title;
		private string _author;
		private DateTime? _addtime;
		private string _summary;
		private int _isimg;
		private string _content;
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(PrimaryKey = true)]
      
        public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
        [Ignore]
        public int? NewsIndex
        {
            set { _index = value; }
            get { return _index; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ClassId
		{
			set{ _classid=value;}
			get{return _classid;}
		}
        public int IsTop
        {
            set { _istop = value; }
            get { return _istop; }
        }
        /// <summary>
        /// 
        /// </summary>
       public string Classname
		{
			set{ _classname=value;}
             get{return _classname;}
		}
        public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsImg
		{
			set{ _isimg=value;}
			get{return _isimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		#endregion Model

	}
}

