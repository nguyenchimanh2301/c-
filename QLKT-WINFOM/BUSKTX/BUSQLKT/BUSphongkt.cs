using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX.DAOQLKT;
using DAOKTX;

namespace BUSKTX.BUSQLKT
{
    public class BUSphongkt
    {
        DAOphongkt daop = new DAOphongkt();
        public List<Phongkt> GetPhongkts()
        {
            return daop.GetPhongkt();
        }
        public List<Phongkt> GetmaPhongkts(string ma)
        {
            return daop.GetmaPhongkts(ma);
        }
        public void add(Phongkt p)
        {
            daop.add(p);
        }
        public void delete(string ma)
        {
            daop.delete(ma);
        }
        public void edit(Phongkt p)
        {
            daop.edit(p);
        }
        public void save()
        {
            daop.savechange();
        }

    }
}
