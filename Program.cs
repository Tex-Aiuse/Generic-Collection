public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}

class Bai13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Le Trong Tin - 2415053122342 - 24T3\n");

        List<Student> sv = new List<Student>();

        sv.Add(new Student(1, "Tin"));
        sv.Add(new Student(2, "Hai"));
        sv.Add(new Student(3, "Mlo"));
        sv.Add(new Student(4, "Hien"));
        sv.Add(new Student(5, "Tuong"));
        Console.WriteLine("Danh sach sinh vien:");

        foreach (Student j in sv)
        {
            Console.WriteLine("ID: {0} || Name: {1}", j.Id, j.Name);
        }
        Console.WriteLine("\nTong so sinh vien co trong danh sach: {0}", sv.Count);
    }
}