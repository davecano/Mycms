using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_BLL;

namespace MyCms_TEngine
{
    public class HtmlPager
    {
        /// <summary> 
        /// 获取分页导航 
        /// </summary> 
        /// <param name="intPageIndex">页码</param> 
        /// <param name="intPageCount">页数</param> 
        /// <param name="strUrl">链接</param> 
        /// <returns>HTML代码</returns>    ((pageNum + 1), pageCount, "_list.shtml")
        public string GePageNavgation(int intPageIndex, int intPageCount, string strUrl)
        {
            StringBuilder sb = new StringBuilder("<div class=\"div_pagenavgation\">");
            if (intPageCount > 1)
            {
                //页码显示 
                if (intPageIndex == 1)
                {
                    sb.Append("<span class=\"disabled\"> < 上一页</span>");
                }
                else if (intPageIndex > 1)
                {
                    sb.Append("<a href=\"" + (intPageIndex - 1).ToString()+ strUrl  + "\">< 上一页</a>");
                }
                bool Dot1 = false, Dot2 = false;
                for (int i = 1; i <= intPageCount; i++)
                {
                    if (i == intPageIndex)
                    {
                        sb.Append("<span class=\"current\">" + intPageIndex.ToString() + "</span>");
                        continue;
                    }
                    if (i <= 3)
                    {
                        sb.Append("<a href=\""  +i.ToString()+strUrl  + "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if (intPageIndex > 7)
                    {
                        if (!Dot1)
                        {
                            sb.Append("<span class=\"dotted\">...</span>");
                            Dot1 = true;
                        }
                    }
                    if (i == intPageIndex - 3)
                    {
                        sb.Append("<a href=\""+ i.ToString()+ strUrl  + "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if (i == intPageIndex - 2)
                    {
                        sb.Append("<a href=\"" + i.ToString() + strUrl + "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if (i == intPageIndex - 1)
                    {
                        sb.Append("<a href=\"" + i.ToString() + strUrl +  "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if (i == intPageIndex + 1)
                    {
                        sb.Append("<a href=\"" + i.ToString() + strUrl +  "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if (i == intPageIndex + 2)
                    {
                        sb.Append("<a href=\"" + i.ToString()+ strUrl   + "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if (i == intPageIndex + 3)
                    {
                        sb.Append("<a href=\"" + i.ToString() + strUrl +  "\">" + i.ToString() + "</a>");
                        continue;
                    }
                    if ((intPageCount - intPageIndex) > 6 && i > intPageIndex + 3)
                    {
                        if (!Dot2)
                        {
                            sb.Append("<span class=\"dotted\">...</span>");
                            Dot2 = true;
                        }
                    }
                    if (i > intPageCount - 3)
                    {
                        sb.Append("<a href=\"" + i.ToString() +strUrl  + "\">" + i.ToString() + "</a>");
                        continue;
                    }
                }
                if (intPageIndex == intPageCount)
                {
                    sb.Append("<span class=\"disabled\">下一页 ></span>");
                }
                else if (intPageIndex + 1 <= intPageCount)
                {
                    sb.Append("<a href=\"" + (intPageIndex + 1).ToString() + strUrl +  "\">下一页 ></a>");
                }
            }
            sb.Append("</div>");
            return sb.ToString();
        }
        //根据newsid获取索引的位置，可以先根据newsid找到相关栏目下所在的第几条，然后除以pagesize，不是整除就+1

    }
}
