class BaiTap2
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

        int Tong = 0;

        foreach (int j in a)
            Tong = Tong + j;

        Console.WriteLine("Tong = {0}", Tong);
    }
}