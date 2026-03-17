public class Student
{
    public string Name { get; set; }
    public double Score { get; set; }

    public Student(string name, double score)
    {
        this.Name = name;
        this.Score = score;
    }
}

class BaiTap18
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");

        List<Student> sv = new List<Student>();

        sv.Add(new Student("Tin", 9));  
        sv.Add(new Student("Hai", 3.2));
        sv.Add(new Student("Mlo",7.8));
        sv.Add(new Student("Hien",10));
        sv.Add(new Student("Tuong",5.9));
        Console.WriteLine("Danh sach sinh vien:");

        foreach (Student j in sv)
        {
            Console.WriteLine("Name: {0} || Score: {1}", j.Name, j.Score);
        }

        double max = sv[0].Score;

        foreach (Student s in sv)
        {
            if (s.Score > max)
                max = s.Score;
        }

        Console.WriteLine("\nSinh vien co diem cao nhat:");

        foreach (Student j in sv)
        {
            if (j.Score == max)
            {
                Console.WriteLine("Name: {0} || Score: {1}", j.Name, j.Score);
            }
        }
    }
}