using System;
using API.Views;

namespace Crowe
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicView = new BasicView();

            basicView.OnRequest();

            Console.Read();
        }
    }
}
