class BaiTap1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342\n");
        int i;
        List<int> list = new List<int>();
        list.Add(23);
        list.Add(10);
        list.Add(2006);
        list.Add(3);
        list.Add(12);
        Console.Write("Danh sach cac phan tu: ");
        for (i = 0; i < list.Count; i++)
            Console.Write("{0}, ", list[i]);
        Console.ReadKey();

    }
}