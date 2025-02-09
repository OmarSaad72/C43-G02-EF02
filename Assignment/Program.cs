using Assignment.Models;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student()
            {
                FName = "Omar",
                LName = "Saad",
                Address = "Cairo",
                Age = 21,
            };
            Instructor instructor = new Instructor()
            {
                Name = "Rana",
                Salary = 20000,
                Address = "Cairo",
                HourRate = 72,
                Bonus = 300
            };
            Course course = new Course()
            {
                Name = "ASP.Net",
                Duration = "6 Months",
                Description = "Filed Of Backend",
            };
            Department department = new Department()
            {
                Name = "Developers",
                HiringDate = DateTime.Now
            };
            Topic topic = new Topic()
            {
                Name = "MVC"
            };
            using RouteAcadmyDbContext dbContext = new RouteAcadmyDbContext();
            //dbContext.Student.Add(student);
            //dbContext.Instructor.Add(instructor);
            //dbContext.Course.Add(course);
            //dbContext.Department.Add(department);
            //dbContext.Topic.Add(topic);
            //var result = (from e in dbContext.Course
            //              where e.Id == 20
            //              select e).FirstOrDefault();
            //if (result != null)
            //{
            //    dbContext.Course.Remove(result);
            //}
            //var result = (from e in dbContext.Instructor
            //              where e.Id == 110
            //              select e).FirstOrDefault();
            //if (result != null)
            //{
            //    result.Name = "Mariem";
            //    result.Salary = 30000;
            //    result.HourRate = 300;
            //    result.Bonus = 200;
            //};
            //dbContext.SaveChanges();
        }
    }
}
