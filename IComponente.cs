using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastasArquivos
{
    public interface IComponente
    {
        long CalcularTamanhoPasta(string caminho);
    }
}
