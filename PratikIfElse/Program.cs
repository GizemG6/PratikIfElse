Console.Write("Lütfen bir sayı giriniz:");
long sayi = int.Parse(Console.ReadLine());

if (sayi > 10)
{
    Console.WriteLine("Girilen sayi 10'dan büyüktür.");
}
else if (sayi == 10)
{
    Console.WriteLine("Girilen sayi 10'dur.");
}
else
{
    Console.WriteLine("Girilen sayi 10'dan kücüktür.");
}
if (sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayi cifttir.");
}
else
{
    Console.WriteLine("Girilen sayi tektir");
}