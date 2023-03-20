using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_5
{
    public class Concatenation
    {
        public static async Task ConcatenationMethod()
        {
            string hello = null;

            string world = null;

            await Task.Run(async () => 
            {
                var HelloTask = Task.Run(async () =>
                {
                    hello = (await Hello.ReadHelloAsync());
                });

                var WorldTask = Task.Run(async () =>
                {
                    world = (await World.ReadWorldAsync());
                });

                await Task.WhenAll(HelloTask, WorldTask);

                string result = $"{hello}  {world}";

                Console.WriteLine(result);
            });
        }
    }
}
