using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCms_Model
{
    /// <summary>
    /// mycms_power:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class mycms_power
	{
		public mycms_power()
		{}
		#region Model
		private int _powerid;
		private string _powername;
		/// <summary>
		/// 
		/// </summary>
		public int PowerId
		{
			set{ _powerid=value;}
			get{return _powerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PowerName
		{
			set{ _powername=value;}
			get{return _powername;}
		}
		#endregion Model

	}
}

