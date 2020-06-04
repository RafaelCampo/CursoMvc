using DomainValidation.Interfaces.Specification;
using EP.CursoMvc.Domain.Models;
using EP.CursoMvc.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Specifications.Clientes
{
    public class ClienteDeveTerEmailValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return Email.Validar(cliente.Email);
        }
    }
}
