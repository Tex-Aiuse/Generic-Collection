class BaiTap15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");

        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict.Add("hello", "xin chao");
        dict.Add("cat", "con meo");
        dict.Add("dog", "con cho");
        dict.Add("book", "quyen sach");
        dict.Add("student", "sinh vien");

        string tu;

        do
        {
            Console.Write("\nNhap tu tieng Anh: ");
            tu = Console.ReadLine().ToLower();

            if (dict.ContainsKey(tu))
            {
                Console.WriteLine("Nghia tieng Viet là: {0}", dict[tu]);
            }

        }
        while (dict.ContainsKey(tu));
        Console.WriteLine("Khong tim thay tu nay.");
        Console.WriteLine("\nDanh sach tu trong tu dien:");
        foreach (var i in dict)
        {
            Console.WriteLine(i.Key + " - " + i.Value);
        }
    }
}