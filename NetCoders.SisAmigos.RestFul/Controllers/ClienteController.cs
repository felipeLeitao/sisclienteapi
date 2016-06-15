using NetCoders.SisAmigos.RestFul.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace NetCoders.SisAmigos.RestFul.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        public IEnumerable<ClienteEntity> Get()
        {
            return ClienteREP.GetAll();
        }

        [HttpPost]
        public void Post(ClienteEntity cliente)
        {
            ClienteREP.Create(cliente);
        }
    }
}
