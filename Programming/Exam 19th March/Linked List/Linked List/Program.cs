using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
       class child
       {
           private int age;
           private string name;

           public child()
           {
              name = "N/A";
           }
           public child(string name , int age)
           {
               this.name = name;
               this.age = age;
           }

           public void read_name()
           {
               name = Console.ReadLine();
           }
           public void read_age()
           {
               age = int.Parse(Console.ReadLine());
           }

           public void child_info()
           {
               Console.WriteLine("Name:{0}  , Age:{1}", name, age);
           }
       }
        static void Main(string[] args)
        {
            child child1 = new child();
            child child2 = new child();

            child1.read_name();
            child1.read_age();

            child2.read_name();
            child2.read_age();

            child1.child_info();
            child2.child_info();
        }
    }
}
