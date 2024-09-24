using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_App.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){
            new Course() {
                Id = 1 , 
                Title = "ASP .Net Kursu" , 
                Description = "Güzel bir kurs" , 
                Image="dotnet.jpeg",
                Tags = new string[] {"aspnet", "web geliştirme"},
                isActive = true,
                isHome = true
                },
            new Course() {
                Id = 2 , 
                Title = "PHP Kursu" , 
                Description = "Güzel bir kurs",
                Image="php.png",
                Tags = new string[] {"php" , "web geliştirme"} ,
                isActive = false,
                isHome = true
                },
            new Course() {
                Id = 3 , 
                Title = "Django Kursu" , 
                Description = "Güzel bir kurs",
                Image="django.png",
                Tags = new string[] {"django" , "yapay zeka"},
                isActive = true,
                isHome = true
                },
            new Course() {
                Id = 4 , 
                Title = "Spring Boot Kursu" , 
                Description = "Güzel bir kurs",
                Image="spring_boot.jpg",
                Tags = new string[] {"spring boot" , "backend geliştirme"},
                isActive = true,
                isHome = false
                },
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c=> c.Id == id);
        }
    }
}