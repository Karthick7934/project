using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public  class SET
    {
        public void display()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (int item in list)
            {
                Console.WriteLine(item);

            }
        }
    }
}
