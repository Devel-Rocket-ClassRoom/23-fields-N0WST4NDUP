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