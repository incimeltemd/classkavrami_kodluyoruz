static void Main(string[] args)
{

    Calisan calisan1=new Calisan();

    calisan1.Ad="Meltem";
    calisan1.Soyad="Dağlaroğlu";
    calisan1.No=949997;
    calisan1.Departman="Halkla ilişkiler";

    calisan1.CalisanBilgileri();

    Calisan calisan2= new Calisan();

    calisan2.Ad="Murat";
    calisan2.Soyad="Can";
    calisan2.No=979994;
    calisan2.Departman="Bilgisayar teknolojileri";

    calisan2.CalisanBilgileri();

}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Ad={0}",Ad);
        Console.WriteLine("Soyad={0}",Soyad);
        Console.WriteLine("Çalışan No={0}",No);
        Console.WriteLine("Departman=",Departman);

    }
}