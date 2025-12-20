using System;
using System.IO;

class Program
{
    static void Main()
    {
        string dosya = "veri.txt";

        // --- 1. YAZMA İŞLEMİ ---
        using (StreamWriter yazici = new StreamWriter(dosya))
        {
            // İstenilen değişiklik burada yapıldı
            string ad = "Nazlı Karnal"; 
            bool korumaVarMi = true; // Sorudaki bool alanı

            // Dosyaya şu şekilde yazar: Nazlı Karnal,True
            yazici.WriteLine(ad + "," + korumaVarMi);
            Console.WriteLine("Veri dosyaya yazıldı.");
        }

        // --- 2. OKUMA İŞLEMİ ---
        using (StreamReader okuyucu = new StreamReader(dosya))
        {
            string satir = okuyucu.ReadLine(); 
            // Satırı virgülden parçala: ["Nazlı Karnal", "True"]
            string[] parcalar = satir.Split(','); 

            string gelenAd = parcalar[0];
            bool gelenKoruma = bool.Parse(parcalar[1]); 

            Console.WriteLine("\n--- DOSYADAN OKUNAN ---");
            Console.WriteLine("İsim: " + gelenAd);
            Console.WriteLine("Koruma Var mı: " + gelenKoruma);
        }
        
        Console.ReadLine();
    }
}