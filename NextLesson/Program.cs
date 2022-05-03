using NextLesson;

CPerson firstPerson = new();

firstPerson.LastName = "Botvinko";
firstPerson.Name = "Victor";
firstPerson.MiddleName = "Alekseevich";

CPerson secondPerson = new();
secondPerson.LastName = "Botvinko";
secondPerson.Name = "Victoria";
secondPerson.MiddleName = "Yur'evna";


CStudent firstStudent = new();
firstStudent.LastName = "Golubev";
firstStudent.Name = "Nikita";
firstStudent.MiddleName = "Nikolaevich";
firstStudent.Average = 7.8;


CStudent secondStudent = new();
secondStudent.LastName = "Grakovich";
secondStudent.Name = "Elizaveta";
secondStudent.MiddleName = "Dmitrievna";
secondStudent.Average = 8.9;


CProfessor firstProfessor = new();
firstProfessor.LastName = "Gorbach";
firstProfessor.Name = "Pavel";
firstProfessor.MiddleName = "Victorovich";
firstProfessor.Publications = 5;
firstProfessor.Position = "Docent";
firstProfessor.Age = 35;


CProfessor secondProfessor = new();
secondProfessor.LastName = "Osipchik";
secondProfessor.Name = "Aleksey";
secondProfessor.MiddleName = "Dmitrievich";
secondProfessor.Publications = 3;
secondProfessor.Position = "Prepodovatel";
secondProfessor.Age = 29;


firstPerson.ShowData();

secondPerson.ShowData();

firstStudent.ShowData();

secondStudent.ShowData();

firstProfessor.ShowData();

secondProfessor.ShowData();


