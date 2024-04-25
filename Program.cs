using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal sayi = 0;
        decimal gecici_sonuc = 0;
        string islem = "";
        string[] rakamlar = new string[10] {"0","1","2","3","4","5","6","7","8","9"};
        string[] islemler = { "+", "-", "*", "/" };
        string basilanTus;
        ConsoleKeyInfo bastiginTusunBilgisi;

        const string msjHosgeldin = $"Hesap makineme hoş geldin. " +
            $"İşlem yapacağın sayıyı yaz ardından işlem operatörünü yazarak ilerle..." +
            $"Programı bitirmek için ESC tuşuna basınız...";
        const string msjHatada = "Girdiğiniz ya sayı kabul edilemez ya da yanlış operatör girdiniz";
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(msjHosgeldin);
        Console.ForegroundColor= ConsoleColor.Blue;
        do
        {
            bastiginTusunBilgisi = Console.ReadKey(true);
            basilanTus=bastiginTusunBilgisi.KeyChar.ToString();
            Console.WriteLine(basilanTus);
            if (DizideAra(rakamlar,basilanTus))
            {
                sayi=Convert.ToInt32(Console.ReadLine());
            }else if(DizideAra(islemler, basilanTus))
            {
                bastiginTusunBilgisi = Console.ReadKey(true);
                islem = bastiginTusunBilgisi.KeyChar.ToString();
            }
            switch (islem)
            {
                case "+" :
                    sayi = sayi + sayi;
                case "-" :
                    sayi = sayi - sayi;
                case "*" :
                    sayi = sayi * sayi;
                case "/" :
                    sayi = sayi / sayi;
                default:
                    break;
            }
        } while (bastiginTusunBilgisi.Key!=ConsoleKey.Escape);

        
    }
    public static bool DizideAra(string[] rakamlar,string aranan)
    {
        bool buldum=false;
        foreach (string s in rakamlar)
        {
            if(aranan==s)
            {
                buldum = true;
            }
            else
            {
                buldum = false;
            }
        }
        return buldum;
    }
}