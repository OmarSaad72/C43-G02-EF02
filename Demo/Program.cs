using Demo.Data;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Revision

            #endregion
            #region Data Anotation

            #endregion
            #region Fluent APIs

            #endregion
            #region CRUD Operations
            //CompanyDBContext dBContext = new CompanyDBContext();
            //try
            //{

            //}
            //finally 
            //{

            //    dBContext.Dispose(); // disconncetion DB
            //}
            //using (CompanyDBContext dbContext = new CompanyDBContext()) 
            //{

            //};
            using CompanyDBContext dbContext = new CompanyDBContext();
            //dbContext .SaveChanges();
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll; //Track All ==> Default Behavior
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
            #region Create
            Employee Emp1 = new Employee() //Poco Class
            {
                Name = "Omar",
                Age = 21,
                Salary = 20000,
                Phone = "01147007132",
                EmailAddress = "osaad7060@gmail.com",
                Password = "22323",
            };
            Employee Emp2 = new Employee()
            {
                Name = "Mai",
                Age = 21,
                Salary = 20000,
                Phone = "01122131",
                EmailAddress = "Mai212@gmail.com",
                Password = "32444",
            };
            //Console.WriteLine(dbContext.Entry(Emp1).State);
            //Console.WriteLine(dbContext.Entry(Emp2).State);

            //dbContext.Employees.Add(Emp1); //Way01 ==> It's Better Way
            //dbContext.Add(Emp1); //Way02 ==> Not Readable
            //dbContext.Set<Employee>().Add(Emp1); //Way03 ==> If havn't DbSet<Employee>
            //dbContext.Entry(Emp1).State = EntityState.Added; //Way04
            //dbContext.Employees.Add(Emp1); // Add locally not DB
            //dbContext.Employees.Add(Emp2); // Add locally not DB
            //Console.WriteLine(dbContext.Entry(Emp1).State);
            //Console.WriteLine(dbContext.Entry(Emp2).State);
            //dbContext.SaveChanges(); //Add To DB
            //Console.WriteLine(dbContext.Entry(Emp1).State);
            //Console.WriteLine(dbContext.Entry(Emp2).State); 
            #endregion
            #region Read
            //var Employee = (from e in dbContext.Employees
            //             where e.Code == 1
            //             select e).AsNoTracking().FirstOrDefault();
            //Console.WriteLine($"EmpName: {Employee?.Name} & EmpSalary: {Employee?.Salary}");
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion
            #region Update
            //var Employee = (from e in dbContext.Employees
            //                where e.Code == 1
            //                select e).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //if (Employee != null)
            //{
            //    Employee.Name = "Omar Saad";
            //}
            //Console.WriteLine("After Ubdated:");
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("After SaveChanges:");
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion
            #region Delete
            var Employee = (from e in dbContext.Employees
                            where e.Code == 2
                            select e).FirstOrDefault();
            dbContext.Employees.Remove(Employee);
            Console.WriteLine("After Deletion");
            Console.WriteLine(dbContext.Entry(Employee).State);
            dbContext.SaveChanges();
            Console.WriteLine("After SaveChanges");  
            Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.Employees.Remove(Employee); //Way01 ==> It's Better Way
            //dbContext.Remove(Employee); //Way02 ==> Not Readable
            //dbContext.Set<Employee>().Remove(Employee); //Way03 ==> If havn't DbSet<Employee>
            //dbContext.Entry(Employee).State = EntityState.Deleted; //Way04
            #endregion
            #endregion
        }
    }
}
