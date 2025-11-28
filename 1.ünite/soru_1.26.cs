using System;

class Carbonfootprints
{
    static void Main()
    {
        Console.Write("Yıllık benzin tüketimi (Litre): ");
        double benzin = Convert.ToDouble(Console.ReadLine());

        Console.Write("Aylık elektrik tüketimi (kWh): ");
        double elektrik = Convert.ToDouble(Console.ReadLine());

        double toplamSonuc = (benzin * 2.3) + (elektrik * 12 * 0.5);

        Console.WriteLine("Yıllık Karbon Ayak İzi: " + toplamSonuc + " kg");
        Console.ReadKey();
    }
}