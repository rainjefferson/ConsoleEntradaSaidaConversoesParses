using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntradaSaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Entrada e saida de dados do teclado
            // Metodo que lê um caracter digitado no console em codigo ascii
            //int tecla = Console.Read();
            //Console.WriteLine(tecla);

            // Metodo que lê uma linha digitada e retorna em uma string
            //string frase = Console.ReadLine();
            //Console.WriteLine(frase);
            #endregion

            #region Conversão explicita de variaveis
            ushort numero = 33000;
            byte numero2 = (byte)numero;
            Console.WriteLine(numero2);

            char letra = (char)97;

            Console.WriteLine(letra);
            #endregion

            #region Metodo parse
            // Metodo parse converte a cadeia de represantação de caracteres string em um  numero equivalente

            string txtNumero = "2022";
            int ano = int.Parse(txtNumero);
            Console.WriteLine(ano);
            #endregion

            #region Classe Converte

            string textoconvertido = Convert.ToString(344.908f);
            Console.WriteLine("textoconvertido: " + textoconvertido);
            #endregion

            Console.ReadKey();
        }
    }
}
