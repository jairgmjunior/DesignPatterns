using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class CarrinhoComprasComposite : ProdutoBase, IProduto
    {
        private List<ProdutoBase> _produto;

        public CarrinhoComprasComposite(string nome, decimal preco) : base(nome, preco)
        {
            _produto = new List<ProdutoBase>();
        }

        public void Add(ProdutoBase produto)
        {
            _produto.Add(produto);
        }

        public override decimal CalcularPreco()
        {
            var total = new decimal(0);

            Console.WriteLine($"{Nome} contém os seguintes produtos: ");

            foreach(var presente in _produto)
            {
                total += presente.CalcularPreco();
            }

            return total;
        }

        public void Remove(ProdutoBase produto)
        {
            _produto.Remove(produto);
        }
    }
}
