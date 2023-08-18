namespace StudentAttendanceList
{
    public class Student
    {
        public string studentName;
        public bool inClass;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             //Student sınıfından nesnelerin listesini temsil eden student adında bir liste oluşturulur.
            List<Student> students = new();
            students.Add(new Student() { studentName = "Gaye", inClass = false });
            students.Add(new Student() { studentName = "Cemre", inClass = true });
            students.Add(new Student() { studentName = "Emir", inClass = false });
            students.Add(new Student() { studentName = "Osman", inClass = false });
            students.Add(new Student() { studentName = "Halid", inClass = true });
        }
    }
}