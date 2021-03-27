using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter a name for a new student: ");
                var name = Console.ReadLine();

                var student = new Student { StudentName = name };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.StudentName
                            select b;
                    
                            foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public virtual List<Post> Posts { get; set; }
        }

        public class Post
        {
            public int PostId { get; set; }
           
            public int StudentId { get; set; }
            public virtual Student Student { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Post> Posts { get; set; }
        }
    }
}
