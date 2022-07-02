#include <iostream>#include <iostream>
#include <iomanip>

using namespace std;

int main()
{

      double largura, comprimento, metroQuadrado, area, preco;

      cout << "Digite a largura do terreno: ";
      cin >> largura;
      cout << "Digite o comprimento do terreno: ";
      cin >> comprimento;
      cout << "Digite o valor do metro quadrado: ";
      cin >> metroQuadrado;

       area = largura * comprimento;
       preco = area * metroQuadrado;

       cout << fixed << setprecision(2);
       cout << "Area do terreno = " << area << endl;
        cout << fixed << setprecision(2);
       cout << "Preco do terreno = " << preco << endl;


    return 0;
}
