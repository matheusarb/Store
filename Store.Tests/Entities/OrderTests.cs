using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Enums;

namespace Store.Tests.Domain
{
    [TestClass]
    public class OrderTests
    {
        private readonly Customer _customer = new("Bruce Wayne", "gotham@email.com");
        private readonly Discount _discount = new(10, DateTime.Now.AddDays(5));
        private readonly Product _product = new("Produto1", 10, true);
        private readonly Order _order = new Order(null, 10, null);

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracteres()
        {
            var order = new Order(_customer, 10, _discount);
            Assert.AreEqual(8, order.Number.Length);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_seu_status_deve_ser_aguardando_pagamento()
        {
            // var order = new Order(_customer, 10, _discount);
            Assert.AreEqual(EOrderStatus.WaitingPayment, _order.Status);
        }
    }
}