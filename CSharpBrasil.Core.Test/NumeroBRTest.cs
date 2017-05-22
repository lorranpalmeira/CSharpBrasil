﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBrasil.Core.Test
{
    [TestClass]
    public class NumeroBRTest
    {
        NumeroBR numeroBR;

        [TestInitialize]
        public void Initialize()
        {
            numeroBR = new NumeroBR();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativoDeveGerarErro()
        {
            string extenso = numeroBR.Extenso(-1);
        }

        [TestMethod]
        public void shouldTransform0InWords()
        {
            string extenso = numeroBR.Extenso(0);
            Assert.AreEqual("zero", extenso);
        }

        [TestMethod]
        public void shouldTransform1InWords()
        {
            string extenso = numeroBR.Extenso(1);
            Assert.AreEqual("um", extenso);
        }

        [TestMethod]
        public void shouldTransform2InWords()
        {
            string extenso = numeroBR.Extenso(2);
            Assert.AreEqual("dois", extenso);
        }

        [TestMethod]
        public void shouldTransform14InWords()
        {
            string extenso = numeroBR.Extenso(14);
            Assert.AreEqual("quatorze", extenso);
        }

        [TestMethod]
        public void shouldTransform53InWordsUsingAnd()
        {
            string extenso = numeroBR.Extenso(53);
            Assert.AreEqual("cinquenta e três", extenso);
        }

        [TestMethod]
        public void shouldTransform99InWordsUsingAnd()
        {
            string extenso = numeroBR.Extenso(99);
            Assert.AreEqual("noventa e nove", extenso);
        }

        [TestMethod]
        public void shouldTransformOneHundredInWords()
        {
            string extenso = numeroBR.Extenso(100);
            Assert.AreEqual("cem", extenso);
        }

        [TestMethod]
        public void shouldTransform101InWordsUsingAnd()
        {
            string extenso = numeroBR.Extenso(101);
            Assert.AreEqual("cento e um", extenso);
        }
    }
}
