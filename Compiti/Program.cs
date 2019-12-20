using System;

namespace Compiti
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //2^31 perchè il valore massimo di un int è 2^31 (un bit è per il segno)
            try
            {
                Console.WriteLine(a + 1); //-2^31 perchè aggiungendo 1 il numero con trentuno 1 diventa negativo
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int b = -128;
            int c = -b; //si trasforma in numero positivo
            Console.WriteLine(Convert.ToString(b, 2)); //si converte in binario il valore b
            Console.WriteLine(Convert.ToString(c, 2)); //si converte in binario il valore c
            int value = 31;
            int somma = value;
            value = ~value + 1; // NOT
            // value = value +1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
            Console.ReadLine();
        }
    }
}
