using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azimut
{
    public class Point
    {
        double latitude;
        double longitude;
        public Point(double latitude_, double longitude_)
        {
            this.Latitude = latitude_;
            this.Longitude = longitude_;
        }

        public double Latitude
        {
            get => latitude;
            set
            {
                if (value < -90 || value > 90)
                    throw new ArgumentOutOfRangeException();
                latitude = value;
            }
        }
        public double Longitude
        {
            get => longitude;
            set
            {
                if (value < -180 || value > 180)
                    throw new ArgumentOutOfRangeException();
                longitude = value;
            }
        }
    }
}
