using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_5
{
    public class World
    {
        public static async Task<string> ReadWorldAsync()
        {
            string path = "World.txt";

            string text = await File.ReadAllTextAsync(path);

            return text;
        }
    }
}
