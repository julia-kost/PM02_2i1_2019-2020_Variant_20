using System; 

namespace ConsoleApplication1
{
    // Создать перечисление
    enum car : long 
    { 
        Brand, Model, Year, Engine 
    }
    class Program
    {
        static void Main()
        {             
            car a;
            for (a = car.Brand; a <= car.Engine; a++)               
            Console.WriteLine("Ключ: \"{0}\", значение {1}", a, (int)a);
            Console.ReadLine();
        }
    }
}