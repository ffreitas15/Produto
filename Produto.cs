using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double valorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void adicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }


        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome + "$" + Preco
            + ","
            + Quantidade
            + " unidades , total : $ "
            + valorTotalEmEstoque();
        }
}
