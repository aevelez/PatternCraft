﻿

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternCraft.State;

namespace PatternCraft.Test
{
    [TestClass]
    public class KataTestStatePattern
    {
        [TestMethod]
        public void _0_TankState()
        {
            IUnit tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            Assert.AreEqual(5, tank.Damage);
        }

        [TestMethod]
        public void _1_SiegeState()
        {
            IUnit tank = new Tank();
            tank.State = new SiegeState();

            Assert.AreEqual(false, tank.CanMove);
            Assert.AreEqual(20, tank.Damage);
        }

        [TestMethod]
        public void _2_MixState()
        {
            IUnit tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            tank.State = new SiegeState();
            Assert.AreEqual(20, tank.Damage);
        }
    }
}
