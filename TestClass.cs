using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizatiuonTest
{
    public class TestClass
    {
        public int SumNumbers(int a, int b)
        {
            var result = a + b;
            return result;
        }

        public int SumFourNumbers(int a, int b,int c, int g)
        {
            var result = a + b + c + g;
            return result;
        }
    }
}