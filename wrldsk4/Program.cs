using reader;
using student;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];
        students[0] = new("Иванов И.И.", "01", 19);
        students[1] = new("Петров П.П.", "33", 20);
        students[2] = new("Алёшин А.А.", "22", 22);

        Reader[] readers = new Reader[3];
        readers[0] = new("Иванов И.И.", 3425, "Иформационные технологии", new DateTime(2022, 2, 22), "+89285603545");
        readers[1] = new("Петров П.П.", 3426, "Иформационные технологии", new DateTime(2022, 2, 23), "+82756420970");
        readers[2] = new("Алёшин А.А.", 3427, "Иформационные технологии", new DateTime(2022, 2, 22), "+89373562319");

        string[] books = { "Приключения", "Словарь", "Энциклопедия" };

        readers[0].takeBook(books);
        readers[0].takeBook(students[0].name, 1);
        readers[1].returnBook(books);
        readers[1].returnBook(students[1].name, 2);
    }
}