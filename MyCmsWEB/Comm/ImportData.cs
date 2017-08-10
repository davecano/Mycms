using System.Collections.Generic;
using System.Data;
using Z.Data;

namespace MyCmsWEB.Comm
{
    public class ImportData
    {
        public Dictionary<string, string> Cols;
        private readonly DbHelper db = new DbHelper();

        public ImportData()
        {
            Cols = new Dictionary<string, string>();
            Cols.Add("品种分类", "sortname");
            Cols.Add("产品名", "bidproductname");
            Cols.Add("目录名称", "goodscatalog");
            Cols.Add("注册证号", "registno");
            Cols.Add("注册产品名", "registnames");
            Cols.Add("注册证日期", "registdate");
            Cols.Add("规格", "bidoutlookc");
            Cols.Add("型号", "bidmodel");
            Cols.Add("包装规格", "bzoutlookc");
            Cols.Add("包装材料", "bzcl");
            Cols.Add("单位", "small");
            Cols.Add("材质", "material");
            Cols.Add("质量层次", "qualitylevels");
            Cols.Add("备注", "beizhu");
            Cols.Add("品牌", "varietal");
            Cols.Add("性能与组成", "compose");
            Cols.Add("应用范围", "confine");
            Cols.Add("转换比", "hsb");
            Cols.Add("生产企业", "sccompany");
            Cols.Add("投标企业", "bidcompanyname");
            Cols.Add("中标价", "bidprice");
            Cols.Add("开标价格", "openprice");
            Cols.Add("基准价", "normprice");
            Cols.Add("专家建议价", "okprice");
            Cols.Add("一次竞价价格", "oneprice");
            Cols.Add("二次竞价价格", "twoprice");
            Cols.Add("三次竞价价格", "threeprice");
            Cols.Add("交易价", "jyj");
            Cols.Add("竞价价格", "quotedprice");
        }

        /// <summary>
        ///     导入数据库后，进行重复数据的删除操作
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="projectid"></param>
        public void ReGetherMyImport(string tableName, string projectid)
        {
            var sql = " delete " + tableName + " where tempid not in (select max(t1.tempid) "
                      + " from " + tableName + " t1 group by t1.sortname,t1.goodscatalog, "
                      + " t1.bidproductname,t1.varietal,t1.bidoutlookc,t1.bidmodel,t1.compose, "
                      + " t1.bzoutlookc,t1.bidcompanyname,t1.sccompany,t1.registnames,t1.bzcl, "
                      + " t1.small,t1.confine,t1.registno,t1.registdate,t1.beizhu,t1.normprice, "
                      + " t1.okprice,t1.openprice,t1.oneprice,t1.twoprice,t1.hsb,t1.jyj, "
                      + " t1.projectid having projectid = '" + projectid + "') "
                      + " and projectid = '" + projectid + "'";

            db.ExecuteNonQuery(sql);
        }

        public DataTable GetTableDesc()
        {
            return db.ExecuteTable("select * from BidResultDetail where 1<>1");
        }

        public int DeleteBidResultByMiaosuID(string miaosuid)
        {
            return db.ExecuteNonQuery("delete from BidResultDetail where ResultID=" + miaosuid);
        }
    }

    public class ImportData_Agent
    {
        public Dictionary<string, string> Cols;
        private readonly DbHelper db = new DbHelper();

        public ImportData_Agent()
        {
            Cols = new Dictionary<string, string>();
            Cols.Add("代理商名称", "AgentName");
            Cols.Add("许可证号", "AgentLicense");
            Cols.Add("开始时间", "BeginTime");
            Cols.Add("结束时间", "EndTime");
            Cols.Add("负责人", "Responsible");
            Cols.Add("联系人", "AgentContacts");
            Cols.Add("电话", "AgentTel");
            Cols.Add("手机", "AgentPhone");
            Cols.Add("邮箱", "AgentEmail");
            Cols.Add("传真", "AgentFax");
            Cols.Add("地址", "AgentAddr");
            Cols.Add("配送区域", "DArea");
            Cols.Add("经营范围", "Scope");
            Cols.Add("备注", "AgentRemark");
        }

        public int DeleteAgencyByID(string ids)
        {
            return db.ExecuteNonQuery("delete from Agency where AgentID in (" + ids + ")");
        }

        public DataTable GetTableDesc()
        {
            return db.ExecuteTable("select * from Agency where 1<>1");
        }
    }

    public class ImportData_Prices
    {
        public Dictionary<string, string> Cols;
        private readonly DbHelper db = new DbHelper();

        public ImportData_Prices()
        {
            Cols = new Dictionary<string, string>();
            Cols.Add("编码", "PriceCode");
            Cols.Add("项目名称", "ChargeName");
            Cols.Add("收费价格", "ChargePrice");
            Cols.Add("医院", "HospitalName");
            Cols.Add("计价单位", "ChargeUnit");
            Cols.Add("一级分类", "ProType");
            Cols.Add("项目内涵", "ProConnatation");
            Cols.Add("除外内容", "OutContent");
            Cols.Add("说明", "ShuoMing");
            Cols.Add("备注", "Remark");
        }

        public int DeletePricesByID(string ids)
        {
            return db.ExecuteNonQuery("delete from Prices where PriceID in (" + ids + ")");
        }

        public DataTable GetTableDesc()
        {
            return db.ExecuteTable("select * from Prices where 1<>1");
        }
    }
}