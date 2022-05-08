using NextLesson;

CPerson [] array = new CPerson [6];

CPerson firstPerson = new();

firstPerson.LastName = "Botvinko";
firstPerson.Name = "Victor";
firstPerson.MiddleName = "Alekseevich";

CPerson secondPerson = new();
secondPerson.LastName = "Botvinko";
secondPerson.Name = "VictorRR";
secondPerson.MiddleName = "AlekseevichCHCH";


CStudent firstStudent = new();
firstStudent.LastName = "Botvinko";
firstStudent.Name = "Nikita";
firstStudent.MiddleName = "Alekseevich";
firstStudent.Average = 7.8;


CStudent secondStudent = new();
secondStudent.LastName = "Botvinko";
secondStudent.Name = "Elizaveta";
secondStudent.MiddleName = "Alekseevich";
secondStudent.Average = 8.9;


CProfessor firstProfessor = new();
firstProfessor.LastName = "Botvinko";
firstProfessor.Name = "Pavel";
firstProfessor.MiddleName = "Alekseevich";
firstProfessor.Publications = 5;
firstProfessor.Position = "Docent";
firstProfessor.Age = 35;


CProfessor secondProfessor = new();
secondProfessor.LastName = "Botvinko";
secondProfessor.Name = "Aleksey";
secondProfessor.MiddleName = "Alekseevich";
secondProfessor.Publications = 3;
secondProfessor.Position = "Prepodovatel";
secondProfessor.Age = 29;

array[0] = firstPerson;
array [1] = secondPerson;
array [2] = firstStudent;
array [3] = secondStudent;
array [4] = firstProfessor;
array [5] = secondProfessor;

for (int i = 0; i < array.Length; i++)
array[i].ShowData();


