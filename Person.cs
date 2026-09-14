// class work namber 1 
// 13.09.2026
// Person person = new Person()
// {
//    FirstName = "Мухаммад",
//    LastName = "Мирзоев" ,
//   Age = 45,
// };

// Person person2 = new Person()
// {
//    FirstName = "Далер",
//    LastName = "Мухаммадиев" ,
//   Age = 16,
// };
//  person.GetInfo();
// person2.GetInfo();


// Post post1 = new Post();

// post1.SetPost("Its C#");


// for(int i =1 ; i<=10 ; i++)
// {
//     post1.AddLike();
// }

// post1.AddComment("Good");
// post1.AddComment("good course for c#");

// Console.WriteLine(post1.GetInfo());


// List<string> comments =  post1.GetComments(); // comments =  { "Good" - 0 , "good course for c#" - 1 }

// Console.WriteLine("Comments: ");

// foreach (var item in comments) // item="Good" , item = "good course for c#"
// {
//     Console.WriteLine(item); // "Good" , "good course for c#"
// }

// for(int i=0 ; i<comments.Count ; i++)
// {
//     Console.WriteLine(comments[i]); // item = comments[i]
// }


// class work namber 3


// Player player = new Player()
// {
//     Name = "Lionel Messi",
//     Number = 10,
//     Position = "Forward",
//     Team = "Barcelona",
// };
// Console.WriteLine(player.GetInfo());
// player.ScoreGoal();
// player.AssistGoal("Neymar");


// class work namber 4


// Employee employee = new Employee()
// {
//     FirstName = "John",
//     LastName = "Doe",
//     Age = 30,
//     Position = "Manager",
//     Salary = 50000
// };

// Console.WriteLine("Output");
// Console.WriteLine(employee.GetInfo());
// Console.WriteLine(); 

// employee.SetSalary(55000);

// Console.WriteLine("Final Output");
// Console.WriteLine($"Salary: {employee.GetSalary()}.0");






// Home Work namber 1
// 14.09.2026

// Person person = new Person()
// {
//     FirstName = "Shahrom",
//     LastName = "Sharipov",
//     BirthYear = "2000" 
// };


// person.GetFullName();
// person.GetBirthYear();


// Home Work namber 2


// Rectangle rect = new Rectangle()
// {
//     Width = 7,
//     Height = 5
// };
// Console.WriteLine($"Area = {rect.Area()}"); 


// Home Work namber 3


// Student[] students = new Student[]
// {
//     new Student() { Name = "Shahrom Sharipov", GradeLevel = 9, TestScores = new int[] { 80, 80, 80 } },
//     new Student() { Name = "Abdulloh Abdulloev", GradeLevel = 10, TestScores = new int[] { 75, 75, 75 } },
//     new Student() { Name = "Nurullo Sulaymonov", GradeLevel = 11, TestScores = new int[] { 95, 95, 95 } },
//     new Student() { Name = "Alijoni Zabiri", GradeLevel = 12, TestScores = new int[] { 90, 90, 90 } },
//     new Student() { Name = "Olimjon Tojiev", GradeLevel = 9, TestScores = new int[] { 85, 85, 85 } }
// };

// foreach (Student s in students)
// {
//     double avg = s.GetAverage(); 

//     if (avg > 85)
//     {
//         Console.WriteLine($"Congratulations {s.Name} on achieving above average scores ({avg}.0) in grade {s.GradeLevel}!");
//         Console.WriteLine("Keep up the good work!");
//     }
//     else if (avg < 70)
//     {
//         Console.WriteLine($"{s.Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {avg}.0 in grade {s.GradeLevel}.");
//     }
//     else 
//     {
//         Console.WriteLine($"Congratulations {s.Name} on achieving an average score of {avg}.0 in grade {s.GradeLevel}!");
//         Console.WriteLine("Keep working hard for even better results!");
//     }

//     Console.WriteLine("------------------------------------------------");
// }