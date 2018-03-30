using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSample
{
    /// <summary>
    /// Bir test sýnýfý 
    /// Test sýnýfý ile ilgili açýklamalar
    /// </summary>
    [TestClass]
    public class SampleTestClass
    {
        /// <summary>
        /// Örnek bir test methodu
        /// </summary>
        [TestMethod]
        public void SampleTestOne()
        {
        }

        /// <summary>
        /// Parametreli bir test methodu
        /// </summary>
        /// <param name="a">sayýsal bir parametre</param>
        /// <param name="b">sayýsal bir parametre</param>
        [TestMethod]
        public void SampleTestTwo(int a,int b)
        {
        }

    }
}
