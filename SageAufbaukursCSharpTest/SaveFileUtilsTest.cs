using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageAufbaukursCSharp.ServiceImplementations;

namespace SageAufbaukursCSharpTest
{
    [TestClass]
    public class SaveFileUtilsTest
    {
        [TestMethod]
        public void TDD()    //Test Driver Development (Test-Treiber)
        {
            var mock = new SaveFileUtils();
            mock.Save(null);
        }
    }
}
