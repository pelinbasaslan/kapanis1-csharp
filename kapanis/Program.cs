using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Konsola Merhaba Dünya yazdıran bir program yazın.");
        Console.WriteLine("Merhaba Dünya");

        Console.WriteLine("---------------");

        Console.WriteLine("2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.");
        Console.Write("Bir tam sayı yazın:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bir tam sayı yazın:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine($"{num1} sayısı ile {num2} sayısı toplamı = {sum}");

        Console.WriteLine("---------------");

        Console.WriteLine("3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse Yetişkinsiniz yazdırın, aksi takdirde Çocuksunuz yazdırın.");
        Console.Write("Yaş:");
        int yas = Convert.ToInt32(Console.ReadLine());
        if (yas >= 18)
        {
            Console.WriteLine("Yetişkinsiniz.");
        }
        else
        {
            Console.WriteLine("Çocuksunuz.");
        }

        Console.WriteLine("---------------");

        Console.WriteLine("4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise Çift sayıdır yazdırın, tek ise Tek sayıdır yazdırın.");
        Console.Write("Bir tam sayı yazın.");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num3 % 2 == 0)
        {
            Console.WriteLine($"{num3} sayısı bir çift sayıdır.");
        }
        else
        {
            Console.WriteLine($"{num3} sayısı bir tek sayıdır.");
        }

        Console.WriteLine("---------------");

        Console.WriteLine("5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse Donuyor, 0 ile 30 arasında ise Normal, 30'dan büyükse Sıcak yazdırın.");
        Console.Write("Sıcaklık değeri yazın (Celsius cinsinden):");
        double temperature = Convert.ToDouble(Console.ReadLine());
        if (temperature <= 0)
        {
            Console.WriteLine("Donuyor.");
        }
        else if (temperature > 0 && temperature <= 30)
        {
            Console.WriteLine("Normal");
        }
        else
        {
            Console.WriteLine("Sıcak");
        }

        Console.WriteLine("---------------");

        Console.WriteLine("6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre Pazartesi, Salı, vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde Geçersiz gün yazdırın.");
        Console.Write("1 ile 7 arasında bir sayı yazın:");
        int num4 = Convert.ToInt32(Console.ReadLine());
        switch (num4)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün.");
                break;
        }

        Console.WriteLine("---------------");

        Console.WriteLine("7. Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre Başarılı, Orta, Başarısız yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)");

        Console.Write("0-100 arasındaki notunuzu yazın:");
        int score = Convert.ToInt32(Console.ReadLine());
        if (score > 80)
        {
            Console.WriteLine("Başarılı.");
        }
        else if (score <= 80 && score > 60)
        {
            Console.WriteLine("Orta.");
        }
        else
        {
            Console.WriteLine("Başarısız.");
        }

        Console.WriteLine("---------------");

        Console.WriteLine("8. Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.");

        Console.Write("Bir ay numarası yazınız(1-12):");
        int monthNum = Convert.ToInt32(Console.ReadLine());
        string monthName = "";
        int daysInMonth = 31;

        switch (monthNum)
        {
            case 1:
                monthName = "Ocak";
                break;
            case 2:
                monthName = "Şubat";
                daysInMonth = 28;
                break;
            case 3:
                monthName = "Mart";
                break;
            case 4:
                monthName = "Nisan";
                daysInMonth = 30;
                break;
            case 5:
                monthName = "Mayıs";
                break;
            case 6:
                monthName = "Haziran";
                daysInMonth = 30;
                break;
            case 7:
                monthName = "Temmuz";
                break;
            case 8:
                monthName = "Ağustos";
                break;
            case 9:
                monthName = "Eylül";
                daysInMonth = 30;
                break;
            case 10:
                monthName = "Ekim";
                break;
            case 11:
                monthName = "Kasım";
                daysInMonth = 30;
                break;
            case 12:
                monthName = "Aralık";
                break;
            default:
                Console.WriteLine("Böyle bir ay yok.");
                break;
        }

        Console.WriteLine($"Girdiğiniz {monthNum} sayısına {monthName} denk geliyor. {monthName} ayı {daysInMonth} çekiyor. ");

        Console.WriteLine("---------------");
        Console.WriteLine("9. Kullanıcıdan bir şifre isteyin. Eğer şifre 12345 ise Giriş Başarılı yazdırın, değilse Giriş Başarısız yazdırın.");
        Console.Write("Şifre giriniz:");
        string password = Console.ReadLine();
        if (password == "12345")
        {
            Console.WriteLine("Giriş Başarılı");
        }
        else
        {
            Console.WriteLine("Giriş Başarısız.");
        }

        Console.WriteLine("---------------");

        Console.WriteLine("10. Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse Geçersiz işlem yazdırın.");
        Console.Write("Bir sayı girin:");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci bir sayı girin:");
        int num6 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bir işlem seçin(+,-,*,/):");
        string islem = Console.ReadLine();
        int sonuc;
        string islemName = "";

        switch (islem)
        {
            case "+":
                sonuc = num5 + num6;
                islemName = "Toplama";
                Console.WriteLine($"{islemName} işlemi sonucu: {sonuc}");
                break;
            case "-":
                sonuc = num5 - num6;
                islemName = "Çıkarma";
                Console.WriteLine($"{islemName} işlemi sonucu: {sonuc}");
                break;
            case "*":
                sonuc = num5 * num6;
                islemName = "Çarpma";
                Console.WriteLine($"{islemName} işlemi sonucu: {sonuc}");
                break;
            case "/":
                sonuc = num5 / num6;
                islemName = "Bölme";
                Console.WriteLine($"{islemName} işlemi sonucu: {sonuc}");
                break;
            default:
                Console.WriteLine("Geçersiz işlem");
                break;
        }
        Console.WriteLine("1.hafta son");
    }

}
