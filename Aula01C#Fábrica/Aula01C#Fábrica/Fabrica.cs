using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01C_Fábrica
{
    public class Fabrica
    {
        public void calcular()
        {
            const int precoPequena = 10;
            const int precoMedia = 12;
            const int precoGrande = 15;

            Console.Write("Digite a quantidade de camisetas pequenas vendidas: ");
            int qtdPequenas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de camisetas médias vendidas: ");
            int qtdMedias = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de camisetas grandes vendidas: ");
            int qtdGrandes = Convert.ToInt32(Console.ReadLine());

            int valorTotal = (qtdPequenas * precoPequena)+
            (qtdMedias * precoMedia)+
            (qtdGrandes * precoGrande);


        }

    }
}
