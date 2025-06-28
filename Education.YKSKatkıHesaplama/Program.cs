
double grade9,grade10,grade11,grade12;

Console.WriteLine("9. Sınıf Notunuzu Giriniz: ");
grade9 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("10. Sınıf Notunuzu Giriniz: ");
grade10 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("11. Sınıf Notunuzu Giriniz: ");
grade11 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("12. Sınıf Notunuzu Giriniz: ");
grade12 = Convert.ToDouble(Console.ReadLine());

double obp = (grade9 + grade10 + grade11 + grade12) / 4;
Console.WriteLine("Ortaöğretim Başarı Puanınız: " + obp);

Console.WriteLine("Lütfen YKS Puanınızı Giriniz: ");
double ykspuan = Convert.ToDouble(Console.ReadLine());

var katsayi = obp * 0.6;

double sonuc = ykspuan * katsayi;

Console.WriteLine($"YKS Ek Puanlı Hesaplama Sonucu: {sonuc}");


