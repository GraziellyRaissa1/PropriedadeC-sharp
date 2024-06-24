using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadeCsharp
{
    public class ExemploGetSet
    {
        public static void Main(string[] args)
        {
            Person pessoa1 = new Person();
            pessoa1.Nome = "Gabriel Henrique";
            Console.WriteLine(pessoa1.Nome);
        }
    }
}
