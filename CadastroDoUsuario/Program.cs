using System;
using System.Globalization;

namespace CadastroDoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Entre com seu nome:");
            string Name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int HowManyBedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do seu celular?");
            double CellPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último sobrenome, idade e altura ");
            string[] Data = Console.ReadLine().Split(' ');
            string LastName = Data[0];
            int Age = int.Parse(Data[1]);
            double Height = double.Parse(Data[2]);

            Console.WriteLine("Seu nome é: {0}", Name);
            Console.WriteLine("Sua casa possui: {0}", HowManyBedrooms);
            Console.WriteLine("Seu celular custa: {0}", CellPrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu sobrenome é: {0}", LastName.ToUpper());
            Console.WriteLine("Sua idade é: {0}", Age);
            Console.WriteLine("Sua altura é: {0}", Height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
