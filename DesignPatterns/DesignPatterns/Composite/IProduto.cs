using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public interface IProduto
    {
        void Add(ProdutoBase presente);
        void Remove(ProdutoBase presente);
    }
}
