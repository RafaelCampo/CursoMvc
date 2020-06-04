using EP.CursoMvc.Domain.Interfaces;
using EP.CursoMvc.Domain.Interfaces.Services;
using EP.CursoMvc.Domain.Models;
using EP.CursoMvc.Domain.Validations.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
       

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
           
        }
        public Cliente Adicionar(Cliente cliente)
        {
            if (!cliente.EhValido())
                return cliente;

            cliente.ValidationResult = new ClienteAptoParaCadastroValidation(_clienteRepository).Validate(cliente);

            return !cliente.ValidationResult.IsValid ? cliente : _clienteRepository.Adicionar(cliente);
        }

        public Cliente Atualizar(Cliente cliente)
        {
            if (!cliente.EhValido())
                return cliente;
            cliente.ValidationResult = new ClienteEstaConsistenteValidation().Validate(cliente);

            return !cliente.ValidationResult.IsValid ? cliente : _clienteRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}
