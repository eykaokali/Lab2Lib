using Lab2Lib;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кількість телевізорів:");
        int cntTv = int.Parse(Console.ReadLine());
        TV[]arrTV = new TV[cntTv];
        for (int i = 0; i < cntTv; i++)
        {
            Console.WriteLine("Введіть модель телевізора: ");
            string model = Console.ReadLine();
            Console.WriteLine("Введіть бренд телевізора: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Введіть розмір телевізора: ");
            int screenSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть розширення телевізора: ");
            string resolution = Console.ReadLine();
            Console.WriteLine("Введіть телевізор смарт так/ні: ");
            string isSmart = Console.ReadLine();
            Console.WriteLine("Введіть колір телевізора: ");
            string color = Console.ReadLine();
            Console.WriteLine("Введіть ціну телевізора: ");
            float price = float.Parse(Console.ReadLine());
            TV tv = new TV();
            tv.model = model;
            tv.brand = brand;
            tv.screenSize = screenSize;
            tv.resolution = resolution;
            tv.isSmart = isSmart;
            tv.color = color;
            tv.price = price;

            arrTV[i] = tv;
        }
        foreach (TV tv in arrTV) 
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Дані про телевізор моделі{0}", tv.model);
            Console.WriteLine("Бренд{0}", tv.brand);
            Console.WriteLine("Розмір екрану{0}", tv.screenSize);
            Console.WriteLine("Розширення екрану{0}: ", tv.resolution);
            Console.WriteLine(tv.isSmart == "так" ? "є смарт": "не має смарту" );
            Console.WriteLine("Колір{0}", tv.color);
            Console.WriteLine("Ціна{0}", tv.price);
            Console.WriteLine("Площа екрану{0}", tv.area);

        }
    }
}