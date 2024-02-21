using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Enums;

namespace Store.Tests.Domain
{
    [TestClass]
    public class OrderTests
    {       
        private readonly Customer _customer = new Customer("Bruce Wayne", "gotham@email.com");
        

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracteres()
        {
            
        }

        
    }
}