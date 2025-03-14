using System.Formats.Asn1;

namespace Lab2Lib
{
     public class TV
    {
        public string model;
        public string brand;
        public int screenSize;
        public string resolution;
        public string isSmart;
        public string color;
        public float price;
        public float area
        {
            get
            {
                double x = Math.Sqrt(screenSize*screenSize/337);
                return Convert.ToSingle( 16 * 9 * x * x);
            }
        }

        public void ChangePrice(float newPrice)
        {
            if (newPrice >= 0)
                price = newPrice;
        }
    }
}
