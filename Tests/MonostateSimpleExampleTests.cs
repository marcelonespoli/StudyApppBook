using DesignPatterns.SingletonAndMonostate.Monostate.SimpleExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class MonostateSimpleExampleTests
    {
        [Fact] 
        public void TestInstance()
        {
            var m = new Monostate();
            for (var x = 0; x < 10; x++)
            {
                m.X = x;
                Assert.Equal(x, m.X);
            }
        }

        [Fact]
        public void TestAreNotSameInstance()
        {
            var m1 = new Monostate();
            var m2 = new Monostate();
            Assert.NotSame(m1, m2);
        }

        [Fact]
        public void TestInstanceBehaveAsOne()
        {
            var m1 = new Monostate();
            var m2 = new Monostate();
            for (var x = 0; x < 10; x++)
            {
                m1.X = x;
                Assert.Equal(x, m2.X);
            }
            Assert.NotSame(m1, m2);
        }        
    }
}
