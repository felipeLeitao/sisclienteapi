using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.SisAmigos.RestFul.Models
{
    public class ClienteEntity
    {
        public Int32 Codigo { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }
    }
}