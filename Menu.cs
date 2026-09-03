using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVisualStudio262
{
    internal class Menu
    {
        private List<Shape> shapes;

        public void Execute()
        {
            shapes = new List<Shape>();
            Circle c = new Circle(10);
            Console.WriteLine($"Circulo: {c.GetArea()}");
            shapes.Add(c);
            for(int i=0; i<shapes.Count; i++)
            {
                Shape s = shapes[i];
                Console.WriteLine($"Figura: {s.GetArea()}");
            }




            return;


            string name;
            int age;

            Console.WriteLine("Hola!");
            name = GetName();
            Console.WriteLine($"Hola {name}");
            age = GetPositiveNumber("Introduce tu edad:");
            Console.WriteLine($"Tienes {age} años");
            Console.WriteLine($"El próximo año tendrás {age+1} años");

        }

        private string GetName()
        {
            string name="";
            while(name.Length==0)
            {
                Console.WriteLine("Introduce tu nombre:");
                name = Console.ReadLine();
                if(name.Length==0)
                {
                    Console.WriteLine("No puedes tener nombre vacío");
                }
            }
            return name;
        }

        private int GetPositiveNumber(string message)
        {
            int n = 0;
            while (n <= 0)
            {
                Console.WriteLine(message);
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Tiene que ser positivo");
                }
            }
            return n;
        }

    }
}
