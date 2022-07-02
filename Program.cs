using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_TERRENO {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, metroQuadrado, area, preco;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do metro quadrado: ");
            metroQuadrado = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimento;
            preco = area * metroQuadrado;

            Console.WriteLine("Area do terreno = " + area.ToString("F2", CI));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", CI));

        }
    }
}
