using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocketDemo
{
    public interface IFood
    {
        void Test();
    }

    public class Food : IFood
    {
        public void Test()
        {
            Console.WriteLine("调用了");
        }
    }
}
