using Magazin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.BLL
{
    class LoginBLL
    {
        public string client_id { get; set; }

        public static implicit operator LoginBLL(LoginDAL v)
        {
            throw new NotImplementedException();
        }
    }
}
