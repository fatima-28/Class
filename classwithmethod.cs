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

            Console.WriteLine(group1.Information());
            Console.WriteLine(group2.Information());
        }
    }

    class Group
    {
        public string name;
        public int count;
        public int course;

        public string Information()
        {
            return $"{name} {count} {course}";
        }
    }
}
