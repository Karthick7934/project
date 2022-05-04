using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class StackExample
    { 
       //Stack that arranges elements in LIFO (Last In First Out) order.
         public void add()
           {
            Stack <string> name = new Stack<string>();
            name.Push("karthick");
            name.Push("muglian");
            name.Push("raja");
          foreach(var item in name)
            {
                Console.WriteLine(item);    
            }
          Console.WriteLine("------After-----");
            Console.WriteLine("peek element:" +name.Peek());
            Console.WriteLine("pop element:" + name.Pop());

        }
    }
}
