using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using ConsoleApp1.Enums;

    class Program
    {
        static void Main(string[] args)
        {
            SimpleCollection sc = new SimpleCollection()
                .AddRange(2, 5, 7, -6, -8, 200, 201)
                .ApplyFilter(i => i % 2 == 0)
                .ApplyFilter(i => i <= 200)
                .ApplyFilter(i => i > 0);

            foreach (var item in sc.GetCollection())
            {
                Console.WriteLine(item);
            }

            InstanceContainer.Register<ICalculator>(new Calculator());

            ICalculator calculator = InstanceContainer.Resolve<ICalculator>();
            Console.WriteLine(calculator);

            object lol = new ExtendedCalculator();
            ICalculator ec = (ICalculator)lol;

            Console.WriteLine(ec);

            Calculator calculator1 = new Calculator { A = 50 };
            Console.WriteLine(calculator1.A);
            ChangeA(calculator1);
            Console.WriteLine(calculator1.A);

            ExtendedColor exColor = CollorCreator.GetColorEnum(ExtendedColor.Indigo);
            Color color = CollorCreator.GetColorEnum(Color.Blue);
            Console.WriteLine(color);
            Console.WriteLine(exColor);
            Console.ReadKey();
        }

        private static void ChangeA(Calculator calc)
        {
            calc.A = 100;
        }
    }
}
