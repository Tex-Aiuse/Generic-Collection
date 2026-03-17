class BaiTap5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");
        List<string> sv = new List<string>() {"Tin","Tung","Tu","Hai"};

        Console.WriteLine("Cac sinh vien co trong danh sach: ");
        foreach (string s in sv)
            Console.WriteLine(s);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Nhap ten can xoa: ");
        string name = Console.ReadLine();

        sv.Remove(name);

        Console.WriteLine("\nCac sinh vien co trong danh sach sau khi xoa: ");
        foreach (string s in sv)
            Console.WriteLine(s);
    }
}