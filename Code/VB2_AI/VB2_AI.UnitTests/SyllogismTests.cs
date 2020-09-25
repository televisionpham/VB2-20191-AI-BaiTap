using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VB2_AI.Lib;

namespace VB2_AI.UnitTests
{
    [TestClass]
    public class SyllogismTests
    {
        [TestMethod]
        public void Can_init_correct_syllogism()
        {
            var s = new Syllogism("PPE".ToCharArray(), 1);
            var str = s.ToString();
            Console.WriteLine(str);
        }
    }
}
