using System;

class ClassroomManager
{
    private const int k_MaxStudents = 5;
    private readonly string _className;
    private string[] _names;
    private int _totalStudents;
    private static int NumOfClassrooms = 0;

    public ClassroomManager(string className)
    {
        this._className = className;
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
        Console.WriteLine($"=== {_className} 학생 목록 ({_totalStudents}/{_names.Length}) ===");
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