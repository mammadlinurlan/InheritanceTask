using System;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DesktopComputer DesktopComputer1 = new DesktopComputer("HP", "GTX1660", 32);
            Console.WriteLine(DesktopComputer1);

            NoteBook Notebook1 = new NoteBook("ASUS NITRO 5", "GTX1050ti", 16);
            Console.WriteLine(Notebook1);
        }
    }
}
