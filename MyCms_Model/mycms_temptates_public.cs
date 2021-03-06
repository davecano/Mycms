﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_temptates:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>

    [Table(TableName = "mycms_temptate_public", PrimaryKeys = "Id")]
    [Serializable]

    public partial class mycms_temptate_public
    {
     
        public mycms_temptate_public()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _tptype;
        private string _source;
     
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(PrimaryKey = true)]
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TpType
        {
            set { _tptype = value; }
            get { return _tptype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _Source
        {
            set { _source = value; }
            get { return _source; }
        }
   
      
        #endregion Model

    }
}

