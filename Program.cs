using System;

namespace Learncs5
{
    public interface printText
    {
        void print();
    }
    class formatted : printText
    {
        public void print()
        {
            Console.WriteLine("Hiii!");
        }
    }

    public class constructorinjection
    {
        private printText _printText;
        public constructorinjection(printText p1)
        {
            this._printText = p1;
        }
        public void print()
        {
            _printText.print();
        }
    }

    class content
    {
        static void Main(string[] args)
        {
            constructorinjection cs = new constructorinjection(new formatted());
            cs.print();
            Console.ReadKey();
        }
    }
}
