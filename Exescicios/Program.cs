using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exescicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Valor, parcelas, valorFinal;
            Console.WriteLine("Digite um valor de entrada: ");
            Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de parcelas");
            parcelas = float.Parse(Console.ReadLine());
            valorFinal = Valor / parcelas;
            Console.WriteLine("O valor da aparcela é: " + valorFinal);
            // FUNCIONOU NO VISUALSTUDIO  ↑↑↑↑↑

            //Ex 1
            int numeroInteiro, quadrado;
            Console.WriteLine("Digite um valor para verificar seu quadrado");
            numeroInteiro = Convert.ToInt32(Console.ReadLine());
            quadrado = numeroInteiro * numeroInteiro;
            Console.WriteLine("O quadrade de" + numeroInteiro + "é: " + quadrado);

            //Ex2
            int valorProduto, valorPago, troco;
            Console.WriteLine("Digite o valor do produto:");
            valorProduto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor pago: ");
            valorPago = Convert.ToInt32(Console.ReadLine());
            troco = valorProduto - valorPago;
            Console.WriteLine("seu troco é: " + troco);

            //Ex3
            int a, b, sub, mult, div, ad;
            Console.WriteLine("Operações númericas !!! ");
            Console.WriteLine("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            sub = a - b;
            mult = a * b;
            div = a / b;
            ad = a + b;
            Console.WriteLine("a subtração de" + a + " e " + b + "é: " + sub + 
            "\n a Multiplicação é: " + mult + " \n a divizão é: " + div + "\n a adção é: " + ad);

            // Ex 4
            double valorBase, valorAltura, retangulo;
            Console.WriteLine("Digite o valor da base ");
            valorBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Disgite o valor da Altura: ");
            valorAltura = Convert.ToDouble(Console.ReadLine());
            retangulo = valorBase * valorAltura;
            Console.WriteLine("O retângulo mede: " + retangulo);


            // Ex 5
            int idade, dia;
            double anos = 365.25, horas, minutos;
            Console.WriteLine("Digite sua idade");
            idade = Convert.ToInt32(Console.ReadLine());
            dia = Convert.ToInt32(idade * anos);
            Console.WriteLine("Você tem " + dia + " de vida!");
            horas = Convert.ToInt32(dia * 24);
            Console.WriteLine("Você tem " + horas + " horas de vida!");
            minutos = Convert.ToInt32(horas * 60);
            Console.WriteLine("Você tem " + minutos + " minutos de vida!");

            // Ex 6
            int valor, dias, prestacao;
            double taxa;
            Console.WriteLine("Digite o valor da prestação: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a taxa de atraso: ");
            taxa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantos dias de atraso: ");
            dias = Convert.ToInt32(Console.ReadLine());
            prestacao = Convert.ToInt32(valor + (valor / 100 * taxa / 30 * dias));
            Console.WriteLine("O valor da prestação é:" + prestacao);


            //ex 7
            int nA, nB;
            Console.WriteLine("Digite o valor de A: ");
            nA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            nB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O valor de A é: " + nB + "O valor de B é: " + nA);

            // 8
            double litros, quilometros, media;
            Console.WriteLine("Você tem quantos litros no tanque");
            litros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos quilometros percorreu hoje? ");
            quilometros = Convert.ToDouble(Console.ReadLine());
            media = quilometros / litros;
            Console.WriteLine("Em média vc faz " + media + "Km por litro!");

           // 9 

            double pao = 0.12, broa = 1.50, valorPao, valorBroa, valorT, polpanca;
            int quantPao, quantBroa;
            Console.WriteLine("Quantos pães foram vendidos hoje? ");
            quantPao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantas broas foram vendidas hoje? ");
            quantBroa = Convert.ToInt32(Console.ReadLine());
            valorPao = quantPao * pao;
            valorBroa = quantBroa * broa;
            valorT = valorPao + valorBroa;
            polpanca = valorT * 0.10;
            Console.WriteLine("O valor total da quantidade vendida de pães é: " + valorPao + " e de broas é: " + valorBroa);
            Console.WriteLine("O valor total de todas as vendas de hoje é: " + valorT);
            Console.WriteLine("O valor que deve ser guardado na polpança à 10% é de: " + polpanca);

         //   10

            int valorP, precoP = 10, valorM, precoM = 12, valorG, precoG = 15, quantP, quantM, quantG, valorTotal;
            Console.WriteLine("Quantas camisetas Pequenas foram vendidas? ");
            quantP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantas camisetas Médias foram vendidas ");
            quantM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantas camisetas Grandes foram vendidas? ");
            quantG = Convert.ToInt32(Console.ReadLine());
            valorP = precoP * quantP;
            valorM = precoM * quantM;
            valorG = precoG * quantG;
            valorTotal = valorP + valorM + valorG;
            Console.WriteLine("O valor total da compra é: " + valorTotal);
        }
    }
}
