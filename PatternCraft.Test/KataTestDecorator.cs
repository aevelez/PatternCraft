﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternCraft.Decorator;

namespace PatternCraft.Test
{
    [TestClass]
    public class KataTestDecorator
    {
        [TestMethod]
        public void _0_SingleUpgrade()
        {
            IMarine marine = new Marine(10, 1);

            Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
            Assert.AreEqual(11, new MarineWeaponUpgrade(marine).Damage);
        }

        [TestMethod]
        public void _1_DoubleUpgrade()
        {
            IMarine marine = new Marine(15, 1);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            Assert.AreEqual(17, marine.Damage);
        }

        [TestMethod]
        public void _2_TripleUpgrade()
        {
            IMarine marine = new Marine(20, 1);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);
            marine = new MarineWeaponUpgrade(marine);

            Assert.AreEqual(23, marine.Damage);
        }
    }
}
