using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltairRealtors
{
    [Serializable]
    public class RealEstateProperty
    {
        public string PropertyNumber { get; set; }
        public string PropertyType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public short  Stories { get; set; }
        public int    YearBuilt { get; set; }
        public short  Bedrooms { get; set; }
        public float  Bathrooms { get; set; }
        public string Condition { get; set; }
        public string Status { get; set; }
        public double MarketValue { get; set; }
        public string PictureFile { get; set; }
    }
}