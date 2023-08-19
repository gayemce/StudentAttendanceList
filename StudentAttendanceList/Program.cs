using System.Reflection;

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

                    tekrar1:;
                    Console.WriteLine("Yoklama alacağınız öğrencinin numarasını yazın:");
                    string selectedStudentString = Console.ReadLine();
                    int selectedStudent = 0;
                    if (!int.TryParse(selectedStudentString, out selectedStudent))
                    {
                        Console.WriteLine("* Uyarı: Lütfen sayı değeri giriniz:");
                        goto tekrar1;
                    }
                    
                    if(selectedStudent > students.Count)
                    {
                        Console.WriteLine("* Uyarı: Böyle bir öğrenci bulunmamaktadır.");
                        goto tekrar1;
                    }


                    Console.WriteLine($"Seçilen öğrenci: {students[selectedStudent - 1].studentName} \nÖğrenci sınıfta mı? \nTrue or False");
                    string teacherResult = Console.ReadLine();
                    if(teacherResult.ToLower() == "True".ToLower())
                    {
                        Console.WriteLine();
                        Student student = new();
                        students[selectedStudent - 1].inClass = true;
                        foreach (Student item in students)
                        {
                            Console.WriteLine($"{item.studentName} - {item.inClass}");
                        }
                    }
                    else if (teacherResult.ToLower() == "False".ToLower())
                    {
                        Console.WriteLine();
                        Student student = new();
                        students[selectedStudent - 1].inClass = false;
                        foreach (Student item in students)
                        {
                            Console.WriteLine($"{item.studentName} - {item.inClass}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("* Uyarı: Lütfen geçerli bir işlem yapınız.");
                        goto tekrar1;
                    }
                }

                else if(result.ToLower() == "Gelmeyen Öğrenci Listesi" || result == "3")
                {
                    Console.WriteLine("* Gelmeyen Öğrenci Listesi *\n");
                    List<Student> notInClass = students.Where(student => student.inClass == false).ToList();
                    foreach (Student item in notInClass)
                    {
                        Console.WriteLine($"Gelmeyen Öğrenci: {item.studentName}");   
                    }
                }

                else if(result.ToLower() == "Çıkış".ToLower() || result == "4")
                {
                    Console.WriteLine("Ziyaretiniz için teşekkürler. Tekrar görüşmek üzere.");
                    break;
                }

                else
                {
                    Console.WriteLine("Lütfen listedeki işlemlerden birini seçin!");
                }
            }    
        }
    }
}