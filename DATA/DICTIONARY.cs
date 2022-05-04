using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace DATA
{
    public class DICTIONARY
    {
        public void display()
        {
            Dictionary<string, string> name = new Dictionary<string, string>();
            name.Add("1", "karthick");
            name.Add("2", "prakash");
            name.Add("3", "krishna");
            name.Add("4", "rahul");
            name.Add("5", "ibbu");
            foreach (KeyValuePair<string, string> x in name)
            {
                Console.WriteLine(x.Key + x.Value);
            }

        }
    }
}
