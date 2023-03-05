using DesignPatterns.SingletonAndMonostate.Monostate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class MonostateTests
    {
        public MonostateTests()
        {
            var turnstile = new Turnstile();
            turnstile.Reset();
        }

        [Fact]
        public void TestInit()
        {
            var t = new Turnstile();
            Assert.True(t.IsLocked());
            Assert.False(t.Alarm());
        }

        [Fact]
        public void TestCoin()
        {
            var t = new Turnstile();
            t.Coin();
            var t1 = new Turnstile();
            Assert.False(t1.IsLocked());
            Assert.False(t1.Alarm());
            Assert.Equal(1, t1.Coins);
        }

        [Fact]
        public void TestCoinAndPass()
        {
            var t = new Turnstile();
            t.Coin();
            t.Pass();
            var t1 = new Turnstile();
            Assert.True(t1.IsLocked());
            Assert.False(t1.Alarm());
            Assert.Equal(1, t1.Coins);
        }

        [Fact]
        public void TestTwoCoins()
        {
            var t = new Turnstile();
            t.Coin();
            t.Coin();
            var t1 = new Turnstile();
            Assert.False(t1.IsLocked());
            Assert.False(t1.Alarm());
            Assert.Equal(1, t1.Coins);
            Assert.Equal(1, t1.Refounds);
            Assert.False(t1.Alarm());
        }

        [Fact]
        public void TestPass()
        {
            var t = new Turnstile();
            t.Pass();
            var t1 = new Turnstile();
            Assert.True(t1.IsLocked());
            Assert.True(t1.Alarm());
        }

        [Fact]
        public void TestCancelAlarm()
        {
            var t = new Turnstile();
            t.Pass();
            t.Coin();
            var t1 = new Turnstile();
            Assert.False(t1.IsLocked());
            Assert.False(t1.Alarm());
            Assert.Equal(1, t1.Coins);
            Assert.Equal(0, t1.Refounds);
        }

        [Fact]
        public void TestTwoOperations()
        {
            var t = new Turnstile();
            t.Coin();
            t.Pass();
            t.Coin();
            Assert.False(t.IsLocked());
            Assert.Equal(2, t.Coins);
            t.Pass();
            Assert.True(t.IsLocked());
        }
    }
}
