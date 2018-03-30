using System;

namespace LibrarySample
{
    /// <summary>
    /// Basit bir örnek sınıf
    /// Bu sınıf ile ilgili açıklamalar yer alabilir.
    /// </summary>
    public class SampleClass
    {
        public int SampleInt { get; set; }
        public string  SampleString{ get; set; }
        public bool SampleBool{ get; set; }
        public object SampleObject { get; set; }


        /// <summary>
        /// /constructor ile ilgi açıklama
        /// </summary>
        public SampleClass()
        {

        }

        /// <summary>
        /// Sınıf içerisindeki örnek bir fonksiyon
        /// </summary>
        /// <param name="a">Sayısal türde bir paremetre </param>
        /// <param name="b">karakter türünde bir başka parametre </param>
        /// <returns>Geri değer olarak a ve b değerleri ile işlem yapılarak object türünde bir geri dönüş değeri veriyor</returns>
        public object SampleMethod(int a, string b)
        {
            return a.ToString() + b;
        }

        /// <summary>
        /// Başka bir method
        /// </summary>
        public void SampleOtherMethod()
        {
            
        }
    }
}
