using System;
using System.IO;

class Program
{
    // Tuş takımındaki harfleri tanımlıyoruz.
    // 0 ve 1 boş, 2'den itibaren harfler başlıyor.
    // Kitaptaki matematik (3 üzeri 7) tutsun diye her tuşa 3 harf koyduk.
    static string[] tuslar = {
        "",     // 0
        "",     // 1
        "ABC",  // 2
        "DEF",  // 3
        "GHI",  // 4
        "JKL",  // 5
        "MNO",  // 6
        "PRS",  // 7
        "TUV",  // 8
        "WXY"   // 9
    };

    static StreamWriter yazici; // Dosyaya yazma aracı

    static void Main()
    {
        Console.WriteLine("Lütfen 0 ve 1 içermeyen 7 haneli numara girin (Örn: 2345678):");
        string numara = Console.ReadLine();

        // Basit doğrulama: Uzunluk 7 mi?
        if (numara.Length != 7 || numara.Contains("0") || numara.Contains("1"))
        {
            Console.WriteLine("Hata: Numara 7 haneli olmalı ve 0 veya 1 içermemelidir.");
            return;
        }

        try
        {
            // Dosyayı oluşturuyoruz
            using (yazici = new StreamWriter("nazli_kombinasyonlar.txt"))
            {
                // Kombinasyonları başlatan fonksiyonu çağırıyoruz
                Console.WriteLine("Kombinasyonlar hesaplanıyor...");
                KelimeUret(numara, 0, ""); 
                Console.WriteLine("İşlem tamamlandı! 'nazli_kombinasyonlar.txt' dosyasına bakabilirsin.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }

        Console.ReadLine();
    }

    // --- REKÜRSİF (KENDİNİ ÇAĞIRAN) FONKSİYON ---
    // Bu fonksiyon her basamak için döngü kurar.
    // index: Şu an kaçıncı rakamdayız?
    // mevcutKelime: Şu ana kadar oluşturduğumuz kelime.
    static void KelimeUret(string numara, int index, string mevcutKelime)
    {
        // 1. DURMA NOKTASI: Eğer 7 harfe ulaştıysak, dosyaya yaz ve bitir.
        if (index == 7)
        {
            yazici.WriteLine(mevcutKelime);
            return;
        }

        // 2. İŞLEM: Sıradaki rakamı al (Örn: '2')
        // '0' karakterinin ASCII değerini çıkararak int'e çeviriyoruz.
        int rakam = numara[index] - '0'; 

        // Bu rakama karşılık gelen harfleri al (Örn: "ABC")
        string harfler = tuslar[rakam];

        // 3. DÖNGÜ: Her harf için fonksiyonu tekrar çağır
        // Örneğin önce 'A' ekle ve devam et, sonra 'B' ekle ve devam et...
        foreach (char harf in harfler)
        {
            KelimeUret(numara, index + 1, mevcutKelime + harf);
        }
    }
}