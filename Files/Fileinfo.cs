using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class Fileinfo1
    {
        public void  method()
        {

            try
            {
                string loc = String.Format("D:\\karthi {0}.txt", DateTime.Now.ToString("yyy/MM/DD"));
                FileInfo file = new FileInfo(loc);
                // Creating an empty file  
                file.Create();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
    }
}
