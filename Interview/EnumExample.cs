using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice.Interview
{
    public enum EnumExample
    {
       Pending = 1,
       Approved = 2,
       Rejected = 3

    }

    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum StatusCode
    {
        Ok = 200,
        NotFound = 404,
        InternalServerError = 500
    }

    //static void Main(string[] args)
    //{
    //    foreach (StatusCode status in Enum.GetValues(typeof(StatusCode)))
    //    {
    //        Console.WriteLine(status);
    //    }
    //}
}
