﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UltrasonicTesting.Models;

namespace UltrasonicTesting_Tests
{
    [TestClass]
    public class TestObjectTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionThicknessConstructor()
        {
            new TestObject(new Material(string.Empty, 23, 12, 23), 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionMaterialConstructor()
        {
            new TestObject(null, 12);
        }
    }
}
