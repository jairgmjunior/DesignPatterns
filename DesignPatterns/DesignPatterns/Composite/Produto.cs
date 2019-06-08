using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Produto : ProdutoBase
    {
        public Produto(string nome, decimal preco) : base(nome, preco)
        {
        }

        public override decimal CalcularPreco()
        {
            Console.WriteLine($"{Nome} valor: {Valor}");

            return Valor;
        }
    }
}
