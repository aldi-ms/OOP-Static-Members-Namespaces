using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispatcher
{
    class HTMLDispatcherMain
    {
        public static void Main()
        {
            ElementBuilder htmlElement = new ElementBuilder("a");
            htmlElement.AddAttribute("href", "www.softuni.bg");
            htmlElement.AddAttribute("class", "links");

            Console.WriteLine("Element with two attributes:");
            Console.WriteLine(htmlElement.ToString());

            htmlElement.AddContent("Software University");

            Console.WriteLine("\nAdded content:");
            Console.WriteLine(htmlElement.ToString());

            ElementBuilder htmlElement2 = htmlElement * 4;
            Console.WriteLine("\nElement multiplied 4 times, and accessed through .Element:");
            Console.WriteLine(htmlElement2.Element.ToString());

            Console.ReadKey();
        }
    }
}
