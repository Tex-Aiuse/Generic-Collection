class BaiTap6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");
        List<string> sv = new List<string>() { "Tin", "Tung", "Tu", "Hai" };

        Console.WriteLine("Cac sinh vien co trong danh sach: ");
        foreach (string s in sv)
            Console.Write("{0}, ", s);
        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine("Nhap ten can kiem tra: ");
        string name = Console.ReadLine();

        if (sv.Contains(name))
            Console.WriteLine("Ton tai");
        else
            Console.WriteLine("Khong ton tai");
        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine("Nhap ten can kiem tra: ");
        name = Console.ReadLine();

        if (sv.Contains(name))
            Console.WriteLine("Ton tai");
        else
            Console.WriteLine("Khong ton tai");
    }
}