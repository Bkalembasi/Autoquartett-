using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoquartett
{
    class Car
    {
        int kmPerH;
        int ps;
        int cm;
        int ccm;
        int zylinder;
        float acceleration;

        public void SetKmPerH(int ParamKmPerH)
        {
            this.kmPerH = ParamKmPerH;
        }
        public int GetKmPerH()
        {
            return (kmPerH);
        }
        public void SetPs(int ParamPs)
        {
            this.ps = ParamPs;
        }
        public int GetPs()
        {
            return (ps);
        }
        public void SetCm(int ParamCm)
        {
            this.cm = ParamCm;
        }
        public int GetCm()
        {
            return (cm);
        }
        public void SetCcm(int ParamCcm)
        {
            this.ccm = ParamCcm;
        }
        public int GetCcm()
        {
            return (ccm);
        }
        public void SetZylinder(int ParamZyliner)
        {
            this.zylinder = ParamZyliner;
        }
        public int GetZylinder()
        {
            return (zylinder);
        }
        public void SetAcceleration(float ParamAcceleration)
        {
            this.acceleration = ParamAcceleration;
        }
        public float GetAcceleration()
        {
            return (acceleration);
        }
        public void GetCardInformation()
        {
            //TODO
            Console.WriteLine(this.GetAcceleration());
            Console.WriteLine(this.GetCcm());
            Console.WriteLine(this.GetCm());
            Console.WriteLine(this.GetKmPerH());
            Console.WriteLine(this.GetPs());
            Console.WriteLine(this.GetZylinder());
        }
        public double Comparison(double[] values, bool higherNumber) 
        {
            double tempHighest = 0;
            double tempLowest = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > tempHighest)
                {
                    tempHighest = values[i];
                }
                else if (values[i] < tempLowest)
                {
                    tempLowest = values[i];
                }
            }

            if (higherNumber)
            {
                return tempHighest;
            }
            else
            {
                return tempLowest;
            }
 
        }
    }

}
