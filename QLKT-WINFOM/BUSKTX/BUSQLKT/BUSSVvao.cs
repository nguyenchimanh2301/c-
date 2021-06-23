using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX;
using DAOKTX.DAOQLKT;

namespace BUSKTX.BUSQLKT
{
   public class BUSSVvao
    {
        DAOSVvao dsv = new DAOSVvao();
        public List<SINHVIENVAO> GetSINHVIENVAOs()
        {
            return dsv.GetINHVIENVAOs();
        }
        public List<SINHVIENVAO> GetSINHVIENVAOs(string ma)
        {
            return dsv.GetmaSINHVIENVAOs(ma);
        }
        public void add(SINHVIENVAO s)
        {
            dsv.add(s);
        }
        public void delete(string ma)
        {
            dsv.delete(ma);
        }
        public void edit(SINHVIENVAO s)
        {
            dsv.edit(s);
        }
        public void save()
        {
            dsv.savechange();
        }
    }
}
