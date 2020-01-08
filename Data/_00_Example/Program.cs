using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _00_ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleDataContext db = new ExampleDataContext();

            //var list = from i in db.member
            //           orderby i.age descending
            //           select i.name;

            //var list = db.member
            //    .Where(member => member.age > 20)
            //    .OrderByDescending(member => member.name)
            //    .Select(member => new { Name = member.name, Age = member.age })
            //    .First(m => m.Age > 20);

            //var list = db.member.SingleOrDefault(m => m.age == 9999);

            //if (list != null)
            //{
            //    db.member.DeleteOnSubmit(list);
            //}
            

            
            //db.SubmitChanges();

            
            DataTable table = new DataTable("id");
            DataRow row = null;

            

            table.Columns.Add(new DataColumn(@"NAME", typeof(string)));
            table.Columns.Add(new DataColumn(@"AGE", typeof(int)));

            row = table.NewRow();
            row["NAME"] = "홍길동";
            row["AGE"] = 100;


            table.Rows.Add(row);

            row = table.NewRow();
            row["NAME"] = "고길동";
            row["AGE"] = 35;

            table.Rows.Add(row);

            row = table.NewRow();
            row.ItemArray = new object[]{"삼삼이", 33};

            table.Rows.Add(row);

            

        }
    }
}
