using System;
using System.Diagnostics;

namespace Nik
{
    public enum DegRadGrad
    {
        Deg,
        Rad,
        Grad
    }

    // done
    public class DegreeConverter
    {
        public static double DegToRad(double x)
        {
            return x * Math.PI / 180d;
        }
        public static double RadToDeg(double x)
        {
            return x * 180d / Math.PI;
        }

        public static double GradToRad(double x)
        {
            return x * Math.PI / 200d;
        }
        public static double RadToGrad(double x)
        {
            return x * 200d / Math.PI;
        }

        public static double DegToGrad(double x)
        {
            return x * 10d / 9d;
        }
        public static double GradToDeg(double x)
        {
            return x * 9d / 10d;
        }
    }


    public class MathFunctions
    {
        private static double FromRadians(double x, DegRadGrad drg)
        {
            double result = 0;

            switch (drg)
            {
                case DegRadGrad.Deg:
                    result = DegreeConverter.RadToDeg(x);
                    break;
                case DegRadGrad.Rad:
                    result = x;
                    break;
                case DegRadGrad.Grad:
                    result = DegreeConverter.RadToGrad(x);
                    break;
                default:
                    Debug.Assert(false, "Parametar should be Deg, Rad or Grad");
                    break;
            }

            return result;
        }

        private static double ToRadians(double x, DegRadGrad drg)
        {
            double result = 0;

            switch (drg)
            {
                case DegRadGrad.Deg:
                    result = DegreeConverter.DegToRad(x);
                    break;
                case DegRadGrad.Rad:
                    result = x;
                    break;
                case DegRadGrad.Grad:
                    result = DegreeConverter.GradToRad(x);
                    break;
                default:
                    Debug.Assert(false, "Parametar should be Deg, Rad or Grad");
                    break;
            }

            return result;
        }

        #region Trigonometric

        public static double Sin(double x, DegRadGrad drg)
        {
            return Math.Sin(ToRadians(x, drg));
        }

        public static double Cos(double x, DegRadGrad drg)
        {
            return Math.Cos(ToRadians(x, drg));
        }

        public static double Tan(double x, DegRadGrad drg)
        {
            return Math.Tan(ToRadians(x, drg));
        }

        public static double Cot(double x, DegRadGrad drg)
        {
            return 1.0 / Math.Tan(ToRadians(x, drg));
        }

        public static double Sec(double x, DegRadGrad drg)
        {
            return 1.0 / Math.Cos(ToRadians(x, drg));
        }

        public static double Csc(double x, DegRadGrad drg)
        {
            return 1.0 / Math.Sin(ToRadians(x, drg));
        }

        #endregion

        #region Inverse trigonometric

        public static double Asin(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Asin(x), drg);
        }

        public static double Acos(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Acos(x), drg);
        }

        public static double Atan(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Atan(x), drg);
        }

        public static double Atan2(double y, double x, DegRadGrad drg)
        {
            return FromRadians(Math.Atan2(y, x), drg);
        }

        public static double Acot(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Atan(1.0 / x), drg);
        }

        public static double Asec(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Acos(1.0 / x), drg);
        }

        public static double Acsc(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Asin(1.0 / x), drg);
        }

        #endregion

        #region Hyperbolic

        public static double Sinh(double x, DegRadGrad drg)
        {
            return Math.Sinh(ToRadians(x, drg));
        }

        public static double Cosh(double x, DegRadGrad drg)
        {
            return Math.Cosh(ToRadians(x, drg));
        }

        public static double Tanh(double x, DegRadGrad drg)
        {
            return Math.Tanh(ToRadians(x, drg));
        }

        public static double Coth(double x, DegRadGrad drg)
        {
            return Cosh(ToRadians(x, drg), drg) / Sinh(ToRadians(x, drg), drg);
        }

        public static double Sech(double x, DegRadGrad drg)
        {
            return 2.0 / (Math.Pow(Math.E, ToRadians(x, drg)) + Math.Pow(Math.E, -ToRadians(x, drg)));
        }

        public static double Csch(double x, DegRadGrad drg)
        {
            return 2.0 / (Math.Pow(Math.E, ToRadians(x, drg)) - Math.Pow(Math.E, -ToRadians(x, drg)));
        }

        #endregion

        #region Inverse hyperbolic

        public static double Asinh(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Log(x + Math.Sqrt(x * x + 1)), drg);
        }

        public static double Acosh(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Log(x + Math.Sqrt(x * x - 1)), drg);
        }

        public static double Atanh(double x, DegRadGrad drg)
        {
            return FromRadians(Math.Log((1 + x) / (1 - x)) / 2, drg);
        }

        public static double Acoth(double x, DegRadGrad drg)
        {
            return FromRadians(Atanh(1 / x, drg), drg);
        }

        public static double Asech(double x, DegRadGrad drg)
        {
            return FromRadians(Acosh(1 / x, drg), drg);
        }

        public static double Acsch(double x, DegRadGrad drg)
        {
            return FromRadians(Asinh(1 / x, drg), drg);
        }

        #endregion

        #region Exponential

        public static double Log10(double x)
        {
            return Math.Log10(x);
        }

        public static double Log2(double x)
        {
            return Math.Log(x) / Math.Log(2);
        }

        public static double Log(double x)
        {
            return Math.Log(x);
        }

        public static double Exp10(double x)
        {
            return Math.Pow(10, x);
        }

        public static double Exp2(double x)
        {
            return Math.Pow(2, x);
        }

        public static double Exp(double x)
        {
            return Math.Exp(x);
        }

        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Cur(double x)
        {
            return Math.Pow(x, 1.0 / 3.0);
        }

        #endregion

        #region Statistical

        public static double Sum(params double[] d)
        {
            double sum = 0;

            for (int i = 0; i < d.Length; i++)
                sum += d[i];

            return sum;
        }

        public static double Avg(params double[] d)
        {
            return Sum(d) / d.Length;
        }

        public static double Min(params double[] d)
        {
            double min = double.MaxValue;

            for (int i = 0; i < d.Length; i++)
                if (d[i] < min)
                    min = d[i];

            return min;
        }

        public static double Max(params double[] d)
        {
            double max = double.MinValue;

            for (int i = 0; i < d.Length; i++)
                if (d[i] > max)
                    max = d[i];

            return max;
        }

        public static double Stddev(params double[] d)
        {
            double sum = 0;
            double sum2 = 0;
            int i = 0;
            double x;

            for (i = 0; i < d.Length; i++)
            {
                x = d[i];
                sum += x;
                sum2 += x * x;
            }

            return Math.Sqrt((i * sum2 - sum * sum) / (i * (i - 1)));
        }

        public static double Count(params double[] d)
        {
            return d.Length;
        }

        #endregion

        #region Other

        public static double Abs(double x)
        {
            return Math.Abs(x);
        }

        public static double Ceiling(double x)
        {
            return Math.Ceiling(x);
        }

        public static double Fact(uint n)
        {
            double result = 1;
            uint i;

            for (i = 2; i <= n; i++)
            {
                result *= i;
                if (double.IsInfinity(result))
                    break;
            }

            return result;
        }

        public static double Floor(double x)
        {
            return Math.Floor(x);
        }

        public static double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static double Random(double x)
        {
            Random r = new Random();
            return r.NextDouble() * x;
        }

        public static double Round(double x, double y)
        {
            if (y < 0d || 15d < y)
                return double.NaN;
            else
                return Math.Round(x, (int)y);
        }

        public static double Sign(double x)
        {
            return Math.Sign(x);
        }

        public static double Frac(double x)
        {
            if (x >= 0)
                return x - Math.Floor(x);
            else
                return x - Math.Ceiling(x);
        }

        public static double Hypot(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        public static double Deg(double x)
        {
            return DegreeConverter.RadToDeg(x);
        }

        public static double Rad(double x)
        {
            return DegreeConverter.DegToRad(x);
        }

        #endregion
    }
}