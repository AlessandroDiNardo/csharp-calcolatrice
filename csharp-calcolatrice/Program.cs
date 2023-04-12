namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chiedo all'utente di inserire due numeri interi
            Console.WriteLine("Inserisci due numeri interi: ");
            Console.Write("1. numero: ");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Inserisci dei numeri");

            Console.Write("2. numero: ");
            int y;
            while (!int.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Inserisci dei numeri");

            //chiedo all'utente di inserire due numeri con la virgola
            Console.WriteLine("Inserisci due numeri con la virgola: ");
            Console.Write("1. numero: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Inserisci dei numeri");

            Console.Write("2. numero: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Inserisci dei numeri");

            //SOMMA
            Console.WriteLine($"Somma numeri interi: {CalcoliHelper.Somma(x, y)}");
            Console.WriteLine($"Somma numeri double: {CalcoliHelper.Somma(a, b)}");

            //DIFFERENZA
            Console.WriteLine($"Differenza numeri interi: {CalcoliHelper.Diff(x, y)}");
            Console.WriteLine($"Differenza numeri double: {CalcoliHelper.Diff(a, b)}");

            //MOLTIPLICAZIONE
            Console.WriteLine($"Moltiplicazione numeri interi: {CalcoliHelper.Molt(x, y)}");
            Console.WriteLine($"Moltiplicazione numeri double: {CalcoliHelper.Molt(a, b)}");

            //VALORE ASSOLUTO
            Console.WriteLine($"Divisione numeri interi: {CalcoliHelper.Divisione(x, y)}");
            Console.WriteLine($"Divisione numeri double: {CalcoliHelper.Divisione(a, b)}");

            //MINIMO
            Console.WriteLine($"Minimo tra due numeri interi: {CalcoliHelper.Min(x, y)}");
            Console.WriteLine($"Minimo tra due numeri double: {CalcoliHelper.Min(a, b)}");

            //MASSIMO
            Console.WriteLine($"Massimo tra due numeri interi: {CalcoliHelper.Max(x, y)}");
            Console.WriteLine($"Massimo tra due numeri double: {CalcoliHelper.Max(a, b)}");

        }
    }
}