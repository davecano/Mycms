using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCms_Model
{
    public class mycms_menu
    {

        /// <summary>
        /// Menuid
        /// </summary>		
        private int _menuid;
        public int Menuid
        {
            get { return _menuid; }
            set { _menuid = value; }
        }
        /// <summary>
        /// MenuName
        /// </summary>		
        private string _menuname;
        public string MenuName
        {
            get { return _menuname; }
            set { _menuname = value; }
        }
        /// <summary>
        /// ParentMenu
        /// </summary>		
        private int _parentmenu;
        public int ParentMenu
        {
            get { return _parentmenu; }
            set { _parentmenu = value; }
        }
        /// <summary>
        /// MenuIcon
        /// </summary>		
        private string _menuicon;
        public string MenuIcon
        {
            get { return _menuicon; }
            set { _menuicon = value; }
        }
        /// <summary>
        /// PageUrl
        /// </summary>		
        private string _pageurl;
        public string PageUrl
        {
            get { return _pageurl; }
            set { _pageurl = value; }
        }
        /// <summary>
        /// MenuSort
        /// </summary>		
        private int _menusort;
        public int MenuSort
        {
            get { return _menusort; }
            set { _menusort = value; }
        }

    }
}



