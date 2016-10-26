using NetCoders.SisAmigos.RestFul.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage Post(ClienteEntity cliente)
        {
            if (ModelState.IsValid)
            {
                ClienteREP.Create(cliente);

                return Request.CreateResponse(HttpStatusCode.OK, string.Format("{0} cadastrado com sucesso!", cliente.Nome));
            }

            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
