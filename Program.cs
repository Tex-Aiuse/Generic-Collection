class BaiTap9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");
        List<int> a = new List<int>();
        int n;

        Console.Write("Nhap so phan tu: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap gia tri tung phan tu:");
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            a.Add(x);
        }

        List<int> tam = new List<int>();
        foreach (int j in a)
        {
            if (tam.Contains(j) == false)
                tam.Add(j);
        }


        Console.WriteLine("Danh sach moi khong chua phan tu trung: ");
        foreach (int j in tam)
        {
            Console.Write("{0} ", j);
        }
    }
}