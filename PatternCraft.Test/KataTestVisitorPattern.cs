using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternCraft.Visitor;

namespace PatternCraft.Test
{
    [TestClass]
    public class KataTestVisitorPattern
    {
        [TestMethod]
        public void _0_VisitLight()
        {
            IVisitor bullet = new TankBullet();
            ILightUnit light = new Marine();

            light.Accept(bullet);

            Assert.AreEqual(100 - 21, light.Health);
        }

        [TestMethod]
        public void _1_VisitArmored()
        {
            IVisitor bullet = new TankBullet();
            IArmoredUnit armored = new Marauder();

            armored.Accept(bullet);

            Assert.AreEqual(125 - 32, armored.Health);
        }
    }
}
