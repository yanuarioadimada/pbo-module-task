using System;

class Processor
{
    public string Merk { get; set; }
    public string Tipe { get; set; }

    public Processor(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe){}
}

class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe){}
}

class VGA
{
    public string Merk { get; set; }

    public VGA(string merk)
    {
        Merk = merk;
    }
}

class Nvidia : VGA
{
    public Nvidia() : base("Nvidia"){}
}

class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public VGA Vga { get; set; }
    public Processor Processor { get; set; }

    public Laptop(string merk, string tipe, VGA vga, Processor processor)
    {
        Merk = merk;
        Tipe = tipe;
        Vga = vga;
        Processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public virtual void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ASUS : Laptop
{
    public ASUS(string tipe) : base("ASUS", tipe, new Nvidia(), new Intel("Core i7")){}
}

class ROG : ASUS
{
    public ROG() : base("ROG"){}
}

class Vivobook : ASUS
{
    public Vivobook() : base("Vivobook")
    {
    }

    public override void Ngoding()
    {
        Console.WriteLine($"Vivobook {Tipe} sedang ngoding...");
    }
}

class ACER : Laptop
{
    public ACER() : base("ACER", "Predator", new Nvidia(), new AMD("Ryzen")){}
}

class Lenovo : Laptop
{
    public Lenovo(string tipe) : base("Lenovo", tipe, new Nvidia(), new Intel("Core i5")){}
}

class IdeaPad : Lenovo
{
    public IdeaPad() : base("IdeaPad"){}
}

class Login : Lenovo
{
    public Login() : base("Login"){}
}

class MainClass
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();

        // Mengakses properti dari objek laptop1
        string merkVGA = laptop1.Vga.Merk;
        string merkProcessor = laptop1.Processor.Merk;
        string tipeProcessor = laptop1.Processor.Tipe;

        // Mencetak spesifikasi ke konsol
        Console.WriteLine($"Spesifikasi laptop1:");
        Console.WriteLine($"Merk VGA: {merkVGA}");
        Console.WriteLine($"Merk Processor: {merkProcessor}");
        Console.WriteLine($"Tipe Processor: {tipeProcessor}");
        Console.WriteLine("\n");
        Laptop laptop2 = new IdeaPad();
        Laptop predator = new ACER();

        laptop1.LaptopDinyalakan();
        laptop1.BermainGame();
        laptop1.LaptopDimatikan();
        laptop1.Ngoding();
        Console.WriteLine("\n");

        laptop2.LaptopDinyalakan();
        laptop2.BermainGame();
        laptop2.LaptopDimatikan();
        laptop2.Ngoding();
        Console.WriteLine("\n");

        predator.LaptopDinyalakan();
        predator.BermainGame();
        predator.LaptopDimatikan();
        predator.Ngoding();
        Console.WriteLine("\n");
    }
}



