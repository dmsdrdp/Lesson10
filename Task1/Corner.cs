using System;

namespace Task1
{
    class Corner
    {
        public double gradus;
        public double min;
        public double sec;
        public double decimalDegree;

        public double Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                {
                    gradus = 0;
                    Console.WriteLine("0");
                }

                else
                {
                    gradus = value;
                }
            }
        }

        public double Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    min = 0;
                    Console.WriteLine("0");
                }
                else if (value > 60)
                {
                    min = 60;
                    Console.WriteLine("60");
                }
                else
                {
                    min = value;
                }
            }

        }

        public double Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                {
                    sec = 0;
                    Console.WriteLine("0");
                }
                else if (value > 60)
                {
                    sec = 60;
                    Console.WriteLine("60");
                }
                else
                {
                    sec = value;
                }
            }

        }
        public double ToRadians()
        {
            decimalDegree += (sec / 3600) + (min / 60) + gradus;
            return decimalDegree * Math.PI / 180;
        }
    }
}
