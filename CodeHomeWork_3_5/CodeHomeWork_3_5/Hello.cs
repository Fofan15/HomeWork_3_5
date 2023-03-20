using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_5
{
    public class Hello
    {
        public static async Task<string> ReadHelloAsync() 
        {
            string path = "Hello.txt";

            string text = await File.ReadAllTextAsync(path);

            return text;
        }
    }
}
