using EP.CursoMvc.Domain.Models;
using EP.CursoMvc.Domain.Specifications.Clientes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Tests.Specifications
{
    [TestClass]
   public class CpfSpecificationTests
    {
        //AAA
        [TestMethod]
        public void CPFSpecification_IsSatisFied_True()
        {
            //Arrange
            var cliente = new Cliente
            {
                CPF = "30390600822"
            };

            //Act
            var specReturn = new ClienteDeveTerCpfValidoSpecification().IsSatisfiedBy(cliente);

            //Assert
            Assert.IsTrue(specReturn);
        }

        [TestMethod]
        public void CPFSpecification_IsSatisFied_False()
        {
            //Arrange
            var cliente = new Cliente
            {
                CPF = "30390600821"
            };

            //Act
            var specReturn = new ClienteDeveTerCpfValidoSpecification().IsSatisfiedBy(cliente);

            //Assert
            Assert.IsFalse(specReturn);
        }
    }
}
