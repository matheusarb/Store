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
        private readonly Order _order = new Order(null, 0, null);

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
            Assert.AreEqual(_order.Status, EOrderStatus.WaitingPayment);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pagamento_do_pedido_seu_status_deve_ser_aguardando_entrega()
        {
            _order.AddItem(_product, 1); // Total deve ser 10
            _order.Pay(10);
            Assert.AreEqual(_order.Status, EOrderStatus.WaitingDelivery);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pedido_cancelado_seu_status_deve_ser_cancelado()
        {
            _order.Cancel();
            Assert.AreEqual(_order.Status, EOrderStatus.Canceled);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_item_sem_produto_o_mesmo_nao_deve_ser_adicionado()
        {
            _order.AddItem(null, 1);
            Assert.AreEqual(_order.Items.Count, 0);
        }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_um_novo_item_com_quantidade_zero_ou_menor_o_mesmo_nao_deve_ser_adicionado()
        // {
        //     Assert.Fail();

        // }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_um_novo_pedido_valido_seu_total_deve_ser_50()
        // {
        //     Assert.Fail();

        // }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_um_desconto_expirado_o_valor_do_pedido_deve_ser_60()
        // {
        //     Assert.Fail();

        // }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_um_desconto_invalido_o_valor_do_pedido_deve_ser_60()
        // {
        //     Assert.Fail();

        // }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_um_desconto_de_10_o_valor_do_pedido_deve_ser_50()
        // {
        //     Assert.Fail();
        // }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_uma_taxa_de_entrega_de_10_o_valor_do_pedido_deve_ser_60()
        // {
        //     Assert.Fail();

        // }

        // [TestMethod]
        // [TestCategory("Domain")]
        // public void Dado_um_pedido_sem_cliente_o_mesmo_deve_ser_invalido()
        // {
        //     Assert.Fail();

        // }
    }
}