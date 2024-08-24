using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01C_Fábrica
{
    public  class Media2
    {
        public void calculomedia()
        {
            Console.WriteLine("informe a nota 1");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a nota2");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine(media); //debugar

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
