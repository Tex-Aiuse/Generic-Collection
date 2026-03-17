using System.Collections.Generic;

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
class Bai12
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

        Console.Write("\nNhap ten can tim: ");
        string name = Console.ReadLine();

        int luu = -1;
        for (int i = 0; i < sv.Count; i++)
            if (sv[i].Name == name)
                luu = i;
        if (luu == -1)
            Console.WriteLine("Khong co sinh vien trong danh sach");
        else
            Console.WriteLine("ID: {0} || Name: {1}", sv[luu].Id, sv[luu].Name);

    }
}