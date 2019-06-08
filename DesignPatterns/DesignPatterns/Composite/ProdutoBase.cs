using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class ProdutoBase
    {
        protected readonly string Nome;
        protected readonly decimal Valor;

        public ProdutoBase(string nome, decimal valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public abstract decimal CalcularPreco();
    }
}
