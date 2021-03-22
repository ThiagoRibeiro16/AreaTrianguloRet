using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            string medida1;
            string medida2;
            double basetri;
            double altura;
            double area;
            

            Console.Clear();
            
            Console.Write("Informe a base do triângulo:");
            medida1 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Informe a altura do triângulo :");
            medida2 = Console.ReadLine();
            
            Console.WriteLine();
            basetri = Convert.ToDouble(medida1);
            altura = Convert.ToDouble(medida2);

            area = (basetri * altura) / 2;

            Console.WriteLine($"base do triângulo: {basetri}");
            Console.WriteLine($"altura do Triângulo: {altura}");
            Console.WriteLine($"área do Triângulo: {area}");


            

        }
    }
}
