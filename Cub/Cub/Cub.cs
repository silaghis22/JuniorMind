using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cub
{
    [TestClass]
    public class Cub
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(192,Cubes(1));
            Assert.AreEqual(5942, Cubes(24));
        }
        long Cubes (int k)
        {
            int count = 0;
            long number =191;
            while (count !=k)
            {
                number++;
                if (Pow(number, 3) % 1000 == 888)
                    count++;
            }
            return number;
        }

        private long Pow(long number, int v)
        {
            long pow = 1;
            while(v>0)
            {
                pow *= number;
                v--;
            }
            return pow;
        }
    }
}
