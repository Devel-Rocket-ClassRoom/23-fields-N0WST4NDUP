using System;

ClassroomManager manager1 = new ClassroomManager("1반");
manager1.AddStudent("홍길동");
manager1.AddStudent("김철수");
manager1.AddStudent("이영희");
manager1.ShowStudents();

ClassroomManager manager2 = new ClassroomManager("2반");
manager2.AddStudent("박민수");
manager2.AddStudent("정수진");
manager2.ShowStudents();

ClassroomManager.ShowTotalClassrooms();

class ClassroomManager
{
    private const int k_MaxStudents = 5;
    private string[] _names;
    private int _totalStudents;
    private static int NumOfClassrooms = 0;

    public string ClassName { get; }

    public ClassroomManager(string className)
    {
        this.ClassName = className;
        _names = new string[k_MaxStudents];
        NumOfClassrooms++;
    }

    public void AddStudent(string name)
    {
        if (_totalStudents >= _names.Length) Console.WriteLine("정원이 모두 찼습니다.");

        _names[_totalStudents++] = name;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {ClassName} 학생 목록 ({_totalStudents}/{_names.Length}) ===");
        for (int i = 0; i < _totalStudents; i++)
        {
            Console.WriteLine($"{i + 1}. {_names[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {NumOfClassrooms}");
    }
}