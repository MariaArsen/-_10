using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_10
{
    class Ugol
    {
        double gradus;
        double min;
        double sec;

        public double Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                while (value > 360)
                {
                   gradus = (value - 360)%360;
                    
                }  
                if (value < 360)
                {
                  gradus = value % 360;
                }    
                else if (value == 360)
                {
                   gradus = 0;
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
                Gradus += value / 60;
                min = value % 60;
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
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Ugol(double gradus, double min, double sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public double ToRadians()
        {
            return ((Math.Abs(gradus) + ((Math.Abs(min) + Math.Abs(sec) / 60) / 60)) * (Math.PI/180));
        }
    }
}
