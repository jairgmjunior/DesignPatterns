using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class CarrinhoComprasComposite : ProdutoBase, IProduto
    {
        private List<ProdutoBase> _presentes;

        public CarrinhoComprasComposite(string nome, decimal preco) : base(nome, preco)
        {
            _presentes = new List<ProdutoBase>();
        }

        public void Add(ProdutoBase presente)
        {
            _presentes.Add(presente);
        }

        public override decimal CalcularPreco()
        {
            var total = new decimal(0);

            Console.WriteLine($"{Nome} contém os seguintes produtos: ");

            foreach(var presente in _presentes)
            {
                total += presente.CalcularPreco();
            }

            return total;
        }

        public void Remove(ProdutoBase presente)
        {
            _presentes.Remove(presente);
        }
    }
}
