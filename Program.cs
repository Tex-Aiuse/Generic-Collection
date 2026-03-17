class BaiTap16
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");

        Dictionary<char, int> dict = new Dictionary<char, int>();

        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        foreach (char c in chuoi)
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);

        Console.WriteLine("\nSo lan xuat hien cua cac ky tu:");

        foreach (var i in dict)
            Console.Write(i.Key + " : " + i.Value + "  ");
    }
}