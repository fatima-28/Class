using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor overloading(kod tekrarnin qarshisini alaraq)
            //PROBLEM! OVERLOADING ETMIR

            Group group1 = new Group("Tk 75", 3);
            Group group2 = new Group("Tk90", 28, 1);
            Group group3 = new Group();
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
        public Group():this("Qrup1",15,1)
        {

        }
        public Group(string name)
        {
            this.name = name;
        }
        public Group(string name, int course):this(name)
        {
            
            this.course = course;
        }
        public Group(string name, int count, int course):this(name,course)
        {
            
            this.count = count;
           
        }
       
        public void Information()
        {
            Console.WriteLine($"{name} {count} {course}");
        }
    }
}
