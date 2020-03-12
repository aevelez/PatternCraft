using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternCraft.Adapter;

namespace PatternCraft.Test
{
    [TestClass]
    public class KataTestAdapter
    {
        [TestMethod]
        public void _0_MarioAdapter_Can_Attack()
        {
            var marioAdapter = new MarioAdapter(new Mario());
            var target = new Target { Health = 33 };

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }
    }
}
