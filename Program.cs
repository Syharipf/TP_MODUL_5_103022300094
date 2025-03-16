class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Masukkan nama: ");
        String praktikan = Console.ReadLine();
        halo.SapaUser(praktikan); 
    }
}