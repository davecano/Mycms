using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCms_DAL;
using MyCms_Model;
using Z;

namespace MyCms_BLL
{
    public class mycms_class_Manage
    {
      mycms_class_DAL mcd=new mycms_class_DAL();

        public int Insert(mycms_class m)
        {
            return mcd.Insert(m);
        }

        public int Delete(mycms_class m)
        {
            return mcd.Delete(m);
        }

        public int Update(mycms_class m)
        {
            return mcd.Update(m);
        }

        public IList<mycms_class> GetClassList(Query q)
        {
            return mcd.GetClassList(q);
        }

        public mycms_class GetClassById(int classID)
        {
            return mcd.GetClassById(classID);
        }
        public int GetMaxID()
        {
            return mcd.GetMaxID();
        }
    }
   
}
