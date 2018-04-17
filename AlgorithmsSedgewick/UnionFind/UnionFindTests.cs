using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgorithmsSedgewick.UnionFind
{
    [TestFixture]
    public class UnionFindTests
    {
        [Test]
        public void Test1()
        {
            var n = 1000;
            var rnd =new Random();
            var time = 0;
            var s = new UnionFindSolution1(n);

            while (!s.Finded)
            {
                s.Connect(new UnionFindSolution1.LogItem()
                {
                    Time = time++,
                    Value1 = rnd.Next(0, n),
                    Value2 = rnd.Next(0, n)
                });
            }
            Console.Write(s.Value);

        }
    }


    
}
