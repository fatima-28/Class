using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class practise

            Group group1 = new Group();
            group1.name = "Tk77";
            group1.count = 28;
            group1.course = 3;

            Group group2 = new Group();
            group2.name = "Tk80";
            group2.count = 19;
            group2.course = 3;

            Console.WriteLine($"AD: {group1.name} SAY: {group1.count} KURS: {group1.course}");
            Console.WriteLine($"AD: {group2.name} SAY: {group2.count} KURS: {group2.course}");
        }
    }

    class Group
    {
        public string name;
        public int count;
        public int course;
    }
}
