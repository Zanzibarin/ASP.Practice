using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ASP.FinalProject.Models 
{
    public class StudentDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student { FirstName = "Александр", PaternalName = "Иванович", LastlName = "Потёмкин", CourcelHead  = "Transact-SQL и Разработка Microsoft SQL Server", Grade = "100" });



            base.Seed(context);
        }

    }
}