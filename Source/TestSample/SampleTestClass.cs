using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSample
{
    /// <summary>
    /// Bir test s�n�f� 
    /// Test s�n�f� ile ilgili a��klamalar
    /// </summary>
    [TestClass]
    public class SampleTestClass
    {
        /// <summary>
        /// �rnek bir test methodu
        /// </summary>
        [TestMethod]
        public void SampleTestOne()
        {
        }

        /// <summary>
        /// Parametreli bir test methodu
        /// </summary>
        /// <param name="a">say�sal bir parametre</param>
        /// <param name="b">say�sal bir parametre</param>
        [TestMethod]
        public void SampleTestTwo(int a,int b)
        {
        }

    }
}
