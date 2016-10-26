using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetCoders.SisAmigos.RestFul.Models
{
    public class ClienteEntity
    {

        public Int32 Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public String Nome { get; set; }

        public String Email { get; set; }

        public String CEP { get; set; }

        public String Logradouro { get; set; }

        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public String UF { get; set; }

        public String Numero { get; set; }
    }
}