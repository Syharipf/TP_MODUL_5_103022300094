class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("\nMasukkan nama: ");
        String praktikan = Console.ReadLine();
        halo.SapaUser(praktikan);

        Console.Write("\nMasukan NIM: ");
        String nim = Console.ReadLine();
        DataGeneric<string> dataNIM = new DataGeneric<string>(nim);

            dataNIM.PrintData();
    }
}