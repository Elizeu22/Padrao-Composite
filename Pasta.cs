using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastasArquivos
{
    public class Pasta:IComponente
    {
        private List<IComponente> componentes = new();

        public void Contagem(IComponente componente)
        {
            componentes.Add(componente);
        }

        public long CalcularTamanhoPasta(string caminho)
        {
            DirectoryInfo df = new DirectoryInfo(caminho);

            return df.EnumerateFiles("*",SearchOption.AllDirectories)
                .Sum(f => f.Length);

        }



    }
}
