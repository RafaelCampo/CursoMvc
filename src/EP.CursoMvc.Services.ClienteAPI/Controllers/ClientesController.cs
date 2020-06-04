using EP.CursoMvc.Application.Interfaces;
using EP.CursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace EP.CursoMvc.Services.ClienteAPI.Controllers
{
    public class ClientesController : ApiBase
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return _clienteAppService.ObterAtivos();
        }

        // GET: api/Clientes/5
        public ClienteViewModel Get(Guid id)
        {
            return _clienteAppService.ObterPorId(id);
        }

        // POST: api/Clientes
        
        public IHttpActionResult Post([FromBody] ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            clienteEnderecoViewModel = _clienteAppService.Adicionar(clienteEnderecoViewModel);
            //return Ok();
            return Response(clienteEnderecoViewModel);
        }

        // PUT: api/Clientes/5
        public IHttpActionResult Put(Guid id, [FromBody]ClienteViewModel clienteViewModel)
        {
            clienteViewModel = _clienteAppService.Atualizar(clienteViewModel);
            return Response(clienteViewModel);
        }

        // DELETE: api/Clientes/5
        public void Delete(Guid id)
        {
            _clienteAppService.Remover(id);
        }
    }
}
