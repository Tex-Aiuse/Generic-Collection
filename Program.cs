class BaiTap17
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

        int dem = 0;
        List<int> demsl = new List<int>();

        foreach (int j in tam)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == j)
                    dem++;
            }

            demsl.Add(dem);
            dem = 0;
        }

        int max = demsl[0];
        for (int i = 1; i < demsl.Count; i++)
        {
            if (demsl[i] > max)
                max = demsl[i];
        }

        Console.WriteLine("\nCac so xuat hien nhieu nhat:");
        for (int i = 0; i < demsl.Count; i++)
        {
            if (demsl[i] == max)
            {
                Console.WriteLine(tam[i] + " : " + max + " lan");
            }
        }
    }
}