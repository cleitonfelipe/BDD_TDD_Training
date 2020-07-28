using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinhaLoja
{
    public class CarrinhoDeCompras
    {
        public IList<Item> Itens { get; private set; }
        public CarrinhoDeCompras()
        {
            this.Itens = new List<Item>();
        }

        public void Adiciona(Item item)
        {
            this.Itens.Add(item);
        }

        public double MaiorValor()
        {
            if (Itens.Count == 0) return 0;
            double maior = Itens[0].ValorTotal;
            foreach (var item in Itens)
            {
                if (maior < item.ValorTotal)
                {
                    maior = item.ValorTotal;
                }
            }
            return maior;
        }
    }

    public class Item
    {
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorUnitario { get; private set; }
        public Item(String descricao, int quantidade, double valorUnitario)
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }
        public double ValorTotal
        {
            get
            {
                return this.ValorUnitario * this.Quantidade;
            }
        }
    }
}