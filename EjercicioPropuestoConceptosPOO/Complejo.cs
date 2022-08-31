using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPropuestoConceptosPOO
{
    class Complejo
    {
        double realNum, imaginaryNum;

        public double RealNum { get => realNum; set => realNum = value; }
        public double ImaginaryNum { get => imaginaryNum; set => imaginaryNum = value; }

        public Complejo()
        {
            realNum = 0;
            imaginaryNum = 0;
        }

        public Complejo( double realNum, double imaginaryNum )
        {
            this.realNum = realNum;
            this.imaginaryNum = imaginaryNum;
        }

        public override string ToString()
        {
            return $"Imaginary: { imaginaryNum }, Int: { realNum }";
        }

        public static Complejo operator +( Complejo PI, Complejo SI )
        {
            double e = PI.RealNum + SI.RealNum;
            double i = PI.ImaginaryNum + SI.ImaginaryNum;

            return new Complejo( e, i );
        }

        public static Complejo operator -( Complejo PI, Complejo SI )
        {
            double e = PI.RealNum - SI.RealNum;
            double i = PI.ImaginaryNum - SI.ImaginaryNum;

            return new Complejo( e, i );
        }

        public static Complejo operator *( Complejo PI, Complejo SI )
        {
            double e = ( PI.RealNum * SI.RealNum ) - ( PI.ImaginaryNum * SI.ImaginaryNum);
            double i = ( PI.RealNum * SI.ImaginaryNum) - ( PI.ImaginaryNum * SI.RealNum );

            return new Complejo(e, i);
        }

        public static Complejo operator *( Complejo PI, double n )
        {
            double e = PI.RealNum * n;
            double i = PI.ImaginaryNum * n;

            return new Complejo(e, i);
        }

        public static Complejo operator /( Complejo PI, Complejo SI )
        {
            double e = ((PI.RealNum * SI.RealNum) / (Math.Pow(SI.RealNum, 2) + Math.Pow(SI.ImaginaryNum, 2)));
            double i = (PI.ImaginaryNum * SI.RealNum - PI.RealNum * SI.ImaginaryNum) / ((Math.Pow(SI.RealNum, 2) + Math.Pow(SI.ImaginaryNum, 2)));

            return new Complejo(e, i);
        }

    }
}
