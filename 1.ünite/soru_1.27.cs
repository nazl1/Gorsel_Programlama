using System;

class Program
{
    static void Main()
    {
        Console.Write("Kilonuz (kg): ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Boyunuz (metre, örn: 1,75): ");
        double boy = Convert.ToDouble(Console.ReadLine());

        double bki = kilo / (boy * boy);

        Console.WriteLine("Vücut Kitle İndeksiniz: " + bki);
        Console.ReadKey();
    }
}