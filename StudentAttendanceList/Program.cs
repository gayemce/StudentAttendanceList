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

            Console.WriteLine("Sınıf Yoklama Projesine Hoşgeldniz!\n Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("*** İşlemler ***");
            Console.WriteLine("1 - Öğrenci Listesi");
            Console.WriteLine("2 - Yoklama Al");
            Console.WriteLine("3 - Gelmeyen Öğrenci Listesi");
            Console.WriteLine("4 - Çıkış\n");

            while (true)
            {
                string result = Console.ReadLine();

                if(result.ToLower() == "Öğrenci Listesi".ToLower() || result == "1")
                {
                    Console.WriteLine("* Öğrenci Listesi *\n");
                    foreach (Student item in students)
                    {
                        Console.WriteLine($"{item.studentName} - {item.inClass}");
                    }
                }

                else if (result.ToLower() == "Yoklama Al".ToLower() || result == "2")
                {
                    Console.WriteLine("* Yoklama Al *\n");
                    for (int i = 0; i < students.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {students[i].studentName}");
                    }
                }
            }    
        }
    }
}