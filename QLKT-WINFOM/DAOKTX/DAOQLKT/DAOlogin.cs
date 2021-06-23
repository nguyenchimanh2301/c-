using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
   public class DAOlogin
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public Login GetLogin(string us,string pass)
        {
            return ql.Logins.Where(u => u.users == us && u.pass == pass).First<Login>();
        }
    }
}
