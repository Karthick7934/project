using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
  public  class QUEUEExample//Queue that arranges elements in FIFO (First In First Out) order
    {
        public void display()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("AR roadways");
            queue.Enqueue("Ks logistics");
            queue.Enqueue("RVR");
            Console.WriteLine("-------------queue-----");
            foreach (string x in queue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("peek element:" + queue.Peek());
            Console.WriteLine("pop element:" + queue.Dequeue());
        } 
        }
    }