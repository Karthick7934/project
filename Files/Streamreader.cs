using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Files
{
    public class StreamReader
    {
        public void Method()
        {
            using FileStream f = new FileStream("D:\\output.xls", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("karthick\nmuglian\nkavitha\nRaja");
            s.WriteLine("grl\tbanglore\t empolyeee");
            s.Close();
            f.Close();


        }


    }
}
