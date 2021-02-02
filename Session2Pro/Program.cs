using ExtensionMethods;
using System;
using System.Globalization;
using System.Linq;

namespace Session2Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void UseExtentionMethod()
        {
            DateTime d = new DateTime(2014, 05, 21);
            string s = d.GetPersianDate(); //1393/02/31
            Console.WriteLine(s);
        }

        private static void AddEmployee(MyDbContext ctx)
        {
            Employee emp = new Employee()
            {
                Name = "narges",
                SurName = "molaheidar",
                BirthDate = "Jan 1, 2009"
            };

            ctx.Employees.Add(emp);
            ctx.SaveChanges();
            Console.WriteLine("Done!");
        }
    }
}
namespace ExtensionMethods
{
    
   public static class PersianDate
    {
        public static string GetPersianDate(this DateTime date)
        {
            PersianCalendar jc = new PersianCalendar();
            return string.Format("{0:0000}/{1:00}/{2:00}", jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date));
        }
    }
    //How to use it:
  
}
