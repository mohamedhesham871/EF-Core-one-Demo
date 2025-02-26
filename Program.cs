using EF_Core_one__Demo.Data;

namespace EF_Core_one__Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo
            #region Video one
            //[EXtra Information]
            /*Object Relational Mapping (ORM) is a technique used in creating a "bridge" between 
              object-oriented programs and, in most cases, relational databases.*/

            /* When interacting with a database using OOP languages, you'll have to perform different operations 
             like creating, reading, updating, and deleting (CRUD) data from a database. 
              By design, you use SQL for performing these operations in relational databases.*/

            /*
             An ORM tool is software designed to help OOP developers interact with relational databases.
             So instead of creating your own ORM software from scratch, you can make use of these tools.
             */
            #endregion
            #region Video Two
            /*compare Dapper, Entity Framework Core, and ADO.NET*/

            //ADO.NET
            /*
             ADO.NET is a database access technology that is part of the.NET Framework
             It provides a set of classes and interfaces that allow .NET applications to interact with databases.

            ADO.NET is a low-level tool,
             */
            //EFcore
            /*
            ( EF Core) is a high-level ORM (Object-Relational Mapping) tool that allows 
            .NET applications to interact with databases
             */
            //Dapper
            /*
              Dapper is built on top of ADO.NET and provides a simple API for database operations. Dapper is designed to be fast and efficient, 
              which means that it doesn't have some of the features provided by EF Core.
             */
            // Ease of Use
            /*
          
            Regarding ease of use, EF Core is the clear winner. EF Core provides a high-level API that abstracts the database operations,
            making it easier for developers to work with databases. EF Core also supports LINQ, 
            which allows developers to write queries in C# instead of SQL.
            Dapper is also easy to use but requires developers to write SQL queries.
             */
            //Dapper more Fast 
            #endregion
            #region Video Three
            //Video Three
            /*
             1- DBContext => it's session between Your Application and the database
             track changes and save data ,...
             2-DbSet => represents collection of entities of specific type
             ex=> DbSet<Employees> Class
             3-Migration
             4-change tracking 
            */
            try
            {

            }
            finally
            {

            }
            //USing is Sugar syntax unManageResource
            using( CompanyDBContext myCompany =new CompanyDBContext())
            {

               var emp= myCompany.MyDbSet.Where(e=>e.Id==1).FirstOrDefault();

            }
            //Mapping Way
            //1 - By convention
            //2-Data Annotation
            //3- fluent Api
            //4- configuration class
            #endregion
        }
    }
}
