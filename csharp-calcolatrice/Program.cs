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
            Console.WriteLine("\nInserisci due numeri con la virgola: ");
            Console.Write("1. numero: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Inserisci dei numeri");

            Console.Write("2. numero: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Inserisci dei numeri");

            //SOMMA
            Console.WriteLine($"\nSomma numeri interi ({x} + {y}): {CalcoliHelper.Somma(x, y)}");
            Console.WriteLine($"Somma numeri double ({a} + {b}): {CalcoliHelper.Somma(a, b)}\n");

            //DIFFERENZA
            Console.WriteLine($"Differenza numeri interi ({x} - {y}): {CalcoliHelper.Diff(x, y)}");
            Console.WriteLine($"Differenza numeri double ({a} - {b}): {CalcoliHelper.Diff(a, b)}\n");

            //MOLTIPLICAZIONE
            Console.WriteLine($"Moltiplicazione numeri interi ({x} * {y}): {CalcoliHelper.Molt(x, y)}");
            Console.WriteLine($"Moltiplicazione numeri double ({a} * {b}): {CalcoliHelper.Molt(a, b)}\n");

            //VALORE ASSOLUTO
            Console.WriteLine($"Valore assoluto numero intero ({x}): {CalcoliHelper.ValAss(x)}");
            Console.WriteLine($"Valore assoluto numeri double ({a}): {CalcoliHelper.ValAss(a)}\n");

            //MINIMO
            Console.WriteLine($"Minimo tra due numeri interi ({x} e {y}): {CalcoliHelper.Min(x, y)}");
            Console.WriteLine($"Minimo tra due numeri double ({a} e {b}): {CalcoliHelper.Min(a, b)}\n");

            //MASSIMO
            Console.WriteLine($"Massimo tra due numeri interi ({x} e {y}): {CalcoliHelper.Max(x, y)}");
            Console.WriteLine($"Massimo tra due numeri double ({a} e {b}): {CalcoliHelper.Max(a, b)}\n");

            //POTENZA
            Console.WriteLine($"Potenza di un numero intero ({x}^{y}): {CalcoliHelper.Power(x, y)}\n");

            Console.WriteLine("Calcoli completati");
        }
    }
}