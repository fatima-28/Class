using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous object practice
            var group1 = new
            {
                name = "Tk75",
                count= 25,
                course=3,
            };

            var group2 = new
            {
                name = "Tk76",
                count = 20,
                course=3,
            };


            var group3 = new
            {
                name="Tk51",
                count=15,
                course=4,
            };
            Console.WriteLine($"Qrup ad:{group1.name}, Say: {group1.count}, Kurs:{group1.course}");
            Console.WriteLine($"Qrup ad:{group2.name}, Say: {group2.count}, Kurs:{group2.course}");
            Console.WriteLine($"Qrup ad:{group3.name}, Say: {group3.count}, Kurs:{group3.course}");
        


    }
    }
}
