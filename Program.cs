// class work namber 1 
// 13.09.2026

// public class Person
// {
//      public string? FirstName;
//     public string? LastName;

//     public int Age;
//     public void GetInfo()
//     {
//      Console.WriteLine($"\nEnter your FirstName : {FirstName} \n Enter your LastName :{LastName} \n Enter your Age : {Age}\n");   
//     }
// }


// class work namber 2


// public class Post
// {
//     public string? Text; // Its C#
//     public int Likes = 0;
//     public List<string> Comments = new List<string>(); // { "Good" , "Amazing" , "Great" }

//     public void SetPost(string text) // Its C#
//     {
//         Text = text; // 0-> Its C#
//     }

//     public void AddLike()
//     {
//         Likes++;
//     }
   
//      public void AddComment(string comment)
//     {
//         Comments.Add(comment);
//     }

//     public string GetInfo()
//     {
//         return $"{Text} have {Likes} likes.";        
//     }

//     public List<string> GetComments()
//     {
//         return Comments;
//     }
// }


// class work namber 3


// public class Player
// {
//     public string? Name;
//     public int? Number;
//     public string? Position;
// public string? Team;
// public void ScoreGoal()
//     {
//        Console.WriteLine($"Enter player's name:{Name}");
//     }

//    public void AssistGoal(string player_name)
// {
//     Console.WriteLine($"{Name} assists a goal for {player_name}.");
// }

//      public string GetInfo()
//     {
//         return $"Name:{Name}\nNumber:{Number}\nPosition:{Position}\nTeam:{Team}\n";
//     }
// }


// // class work namber 4


//   public class Employee
// {
//     public string? FirstName;
//     public string? LastName;
//     public int Age;
//     public string? Position;
//     public float Salary;
//     public void SetSalary(float salary)
//     {
//         Salary = salary;
//     }
//     public float GetSalary()
//     {
//         return Salary;
//     }
//     public string GetInfo()
//     {
//         return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nPosition: {Position}\nSalary: {Salary}.0";
//     }
// }






// Home Work namber 1 
// // 14.09.2026
// public class Person
// {
//     public string? FirstName;
//     public string? LastName;
//     public string? BirthYear; 

//     public void GetFullName()
//     {
//         Console.WriteLine($"My name is {FirstName} {LastName}");
//     }

//     public void GetBirthYear()
//     {
//         Console.WriteLine($"My birth year is {BirthYear}.");
//     }
// }


// Home Work namber 2


// public class Rectangle
// {
//     public double Width;  
//     public double Height; 

//     public double Area()
//     {
//         return Width * Height; 
//     }
// }


// Home Work namber 3


// using System.Linq; 

// public class Student
// {
//     public string? Name;
//     public int GradeLevel;
//     public int[] TestScores;

//     public double GetAverage()
//     {
//         double sum = TestScores.Sum();
        
//         return sum / TestScores.Length;
//     }
// }