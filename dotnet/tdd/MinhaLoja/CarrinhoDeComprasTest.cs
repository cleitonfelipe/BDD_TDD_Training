using System;
using NUnit.Framework;

namespace MinhaLoja
{
    [TestFixture]
    public class CarrinhoDeComprasTest
    {        
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0001);
        }
        #region Implementação ideal
        // private CarrinhoDeCompras carrinho;
        // [SetUp]
        // public void inicializa() 
        // {
        //     this.carrinho = new CarrinhoDeCompras();
        // }
        // [Test]
        // public void Deve_Retornar_Zero_Se_Carrinho_Estiver_Vazio()
        // {
        //     Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.0001);
        // }

        // [Test]
        // public void Deve_Retornar_Valor_Do_Item_Se_Carrinho_Estiver_Com_1_Elemento()
        // {
        //     carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

        //     Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        // }

        // [Test]
        // public void Deve_Retornar_Maior_Valor_Se_Carrinho_Contem_Muitos_Elementos()
        // {
        //     carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
        //     carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
        //     carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

        //     Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0001);
        // }
        #endregion
    }
}