using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        //metodi per la somma
        public static int Somma(int x, int y) => x + y; 
        public static double Somma(double x, double y) => x + y;

        //metodi per la sottrazione
        public static int Diff(int x, int y) => x - y;
        public static double Diff(double x, double y) => x - y;

        //metodi per la moltiplicazione 
        public static int Molt(int x, int y) => x * y;
        public static double Molt( double x, double y) => x * y;

        //metodi per la divisione 
        public static int ValAss(int x) => Math.Abs(x);
        public static double ValAss( double x ) => Math.Abs(x);

        //metodo per il numero minore
        public static int Min(int x, int y) => x < y ? x : y;
        public static double Min(double x, double y) => x < y ? x : y;

        //metodo per il massimo
        public static int Max(int x, int y) => x > y ? x : y;
        public static double Max(double x, double y) => x > y ? x : y;

    }
}
