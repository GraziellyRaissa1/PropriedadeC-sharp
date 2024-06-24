using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agora podemos usar a Namepropriedade para acessar e atualizar o private campo da Pessoan classe:

namespace PropriedadeCsharp
{
     class Exemplo01
    {
            public static void Main(string[] args)
            {
                Pessoa pessoa1 = new Pessoa();
                pessoa1.Nome = "Gabriella";
                Console.WriteLine(pessoa1.Nome);
            }
    }
}
