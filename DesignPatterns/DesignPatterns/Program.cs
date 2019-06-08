using DesignPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrinho = new CarrinhoComprasComposite("Primeira Compra", 0);
            var notebook = new Produto("Notebook", new decimal(1535.25));
            var celular = new Produto("Celular", new decimal(825.99));
            var tv = new Produto("TV", new decimal(1825.99));

            carrinho.Add(notebook);
            carrinho.Add(celular);
            carrinho.Add(tv);
            
            Console.WriteLine($"O valor total da sua compra é {carrinho.CalcularPreco()}");

            Console.ReadKey();
        }
    }
}
