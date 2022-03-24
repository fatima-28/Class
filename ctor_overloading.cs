using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor overloading
            //PROBLEM! OVERLOADING ETMIR

            Group group1 = new Group("Tk 75", 3);
            Group group2 = new Group("Tk90", 28, 1);
            Group group3 = new Group("Eng 28");
            group1.Information();
            group2.Information();
            group3.Information();

        }
    }

    class Group
    {
        public string name;
        public int count;
        public int course;
        public Group()
        {

        }
        public Group(string name, int count, int course)
        {
            this.name = name;
            this.count = count;
            this.course = course;
        }
        public Group(string name,int course)
        {
            this.name = name;
            this.course = course;
        }

        public Group(string name)
        {
            this.name = name;
        }
        public void Information()
        {
            Console.WriteLine($"{name} {count} {course}");
        }
    }
}
