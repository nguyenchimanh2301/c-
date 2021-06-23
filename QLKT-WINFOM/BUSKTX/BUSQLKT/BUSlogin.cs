using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX.DAOQLKT;
using DAOKTX;

namespace BUSKTX.BUSQLKT
{
    public class BUSlogin
    {
        DAOlogin lg = new DAOlogin();
        public Login GetLogin(string us,string pass)
        {
            return lg.GetLogin(us, pass);
        }
    }
}
