using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor

            Group group1 = new Group("Tk 75", 25, 3);
            Group group2 = new Group("Tk90", 28, 1);
            group1.Information();
            group2.Information();

        }
    }

    class Group
    {
        public string name;
        public int count;
        public int course;

        public Group(string name, int count, int course)
        {
            this.name = name;
            this.count = count;
            this.course = course;
        }
        public void Information()
        {
            Console.WriteLine($"{name} {count} {course}");
        }
    }
}
