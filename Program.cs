using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Learncs4
{

    class Program
    {
        internal class Cat
        {

        }

        internal class Dog
        {

        }
        static async Task Main(string[] args)
        {
            var catMeowTask = catMeowAsync(1);
            var dogBarkTask =  dogBarkAsync(1);
            var alltask = new List<Task> { catMeowTask, dogBarkTask };
            Console.WriteLine("tasks");
            //while (alltask.any())
            //{
            //    task finished = await task.whenany(alltask);
            //    if (finished == catmeowtask)
            //    {
            //        console.writeline("cat has meowed");
            //    }
            //    if (finished == dogbarktask)
            //    {
            //        console.writeline("dog has barked");
            //    }
            //    alltask.remove(finished);
            //}

        }

        private static async Task<Cat> catMeowAsync(int num)
        {
            Console.WriteLine("Cat starts to meow");
            await Task.Delay(300);
            for (int i=0; i < num; i++)
                Console.WriteLine("Meow");
            return new Cat();
        }

        private static async Task<Dog> dogBarkAsync(int num)
        {
            Console.WriteLine("Dog starts to bark");
            await Task.Delay(10);
            for (int i = 0; i < num; i++)
                Console.WriteLine("Bark");
            return new Dog();
        }

    }
}
