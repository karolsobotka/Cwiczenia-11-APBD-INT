using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task11.Models;

namespace Task11.Repository
{
    public class StudentsRepository : IStudentsRepository
    { 
        public static List<Student> Students = new List<Student>()
        {
            new Student 
            {
                ID = 1,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2015/11/01/665262_people_512x512.png",
                FirstName = "Abacki",
                LastName = "Aba",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "Art"
            },

            new Student
            {
                ID = 2,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2015/11/01/665262_people_512x512.png",
                FirstName = "Babacki",
                LastName = "Baba",
                BirthDate = DateTime.Now.AddYears(-21),
                Studies = "Computer Sience"
            },

            new Student
            {
                ID = 3,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2015/11/01/665262_people_512x512.png",
                FirstName = "Cabacki",
                LastName = "Caba",
                BirthDate = DateTime.Now.AddYears(-23),
                Studies = "Machine Learning"
            },
            
            new Student
            {
                ID = 4,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2015/11/01/665262_people_512x512.png",
                FirstName = "Dabacki",
                LastName = "Daba",
                BirthDate = DateTime.Now.AddYears(-24),
                Studies = "Computer Sience"
            },

            new Student
            {
                ID = 5,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2015/11/01/665262_people_512x512.png",
                FirstName = "Ebacki",
                LastName = "Eba",
                BirthDate = DateTime.Now.AddYears(-34),
                Studies = "Digital Systems"
            },

            new Student
            {
                ID = 6,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2015/11/01/665262_people_512x512.png",
                FirstName = "Fabacki",
                LastName = "Feba",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "Computer Sience"
            }
        };

        public void DeleteStudent(int ID)
        {
            var student = FindStudent(ID);

            if (student != null)
                Students.Remove(student);
        }

        public Student FindStudent(int ID) => Students.Find(student => student.ID == ID);

    }
}
