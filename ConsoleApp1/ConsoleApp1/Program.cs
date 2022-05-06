using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] tablia = new User[] {
            new User ("Basia", "STUDENT", 10, new int[5]{1, 2, 3, 4, 5}),
            new User ("Adam", "STUDENT", 10, new int[5]{1, 6, 7, 4, 5}),
            new User ("Wojciech", "ADMIN", 10, new int[0]),
            new User ("Damian", "ADMIN", 10, new int[0]),
            new User ("Dramat", "MODERATOR", 10, new int[0]),
            new User ("M0D3R4T0R", "MODERATOR", 10, new int[0]),
            new User ("Roman", "MODERATOR", 10, new int[0]),
            new User ("Stefan Batory", "TEACHER", 10, new int[0]),
            new User ("Artur Zandberg", "TEACHER", 10, new int[0]),
            new User ("Janusz Janusz", "TEACHER", 10, new int[0]),
            new User ("Jozek", "STUDENT", 10, new int[5]{3, 2, 3, 4, 5}),
            new User ("Lucjusz", "STUDENT", 10, new int[8]{1, 2, 3, 4, 5, 6, 6, 2}),
            new User ("Karyna", "STUDENT", 10, new int[3]{ 3, 4, 5}),
            new User ("Brajan", "STUDENT", 10, new int[2]{1, 2}),
            new User ("Stefan", "STUDENT", 10, new int[6]{1,5, 2, 3, 4, 5}),
            new User ("Szczepan", "STUDENT", 10, new int[5]{4, 5, 3, 4, 5}),
            new User ("Kornik Drukarz", "STUDENT", 10, new int[5]{2, 2, 3, 2, 3}),
            new User ("Donatello", "STUDENT", 10, new int[9]{1, 2, 3, 4, 5, 4, 1, 2, 3}),
            new User ("Michaelangelo", "STUDENT", 10, new int[5]{6, 1, 1, 4, 5}),
            new User ("Piotr", "STUDENT", 10, new int[12]{1, 2, 3, 4, 5, 5, 4, 3, 3, 2, 5, 2 }),
            new User ("Adrian", "STUDENT", 10, new int[7]{1, 2, 3, 4, 5, 1 ,2})
            };
                
            
            















        }






    }


    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
        public int Age { get; set; }
        public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
        public DateTime? CreatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }

        public User(string name, string role, int age, int[] marks)
        {
            Name = name;
            Role = role;
            Age = age;
            if (Role == "STUDENT")
            Marks = marks;

            CreatedAt = DateTime.Now;
            
        }
    }







}
