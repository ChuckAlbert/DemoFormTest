using DemoFormTest.Data;
using DemoFormTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFormTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //可以执行完自动释放资源--context.Dispose()
            using (var context = new DemoContext())
            {
                //新增数据库数据
                //var department = new Department
                //{
                //    DepartmentNo = "D02",
                //    DepartmentName = "办公室2"
                //};

                //var department1 = new Department
                //{
                //    DepartmentNo = "D03",
                //    DepartmentName = "办公室3"
                //};

                //var department2 = new Department
                //{
                //    DepartmentNo = "D04",
                //    DepartmentName = "办公室4"
                //};

                //var department3 = new Department
                //{
                //    DepartmentNo = "D05",
                //    DepartmentName = "办公室5"
                //};
                //context.Departments.Add(department);
                //context.Departments.Add(department1);
                //context.Departments.Add(department2);
                //context.Departments.Add(department3);
                //context.SaveChanges();

                //查询数据库数据
                //var result = context.Departments.ToList();//返回所有数据
                //var resultt = context.Departments.Where(x => x.DepartmentNo == "D03").ToList();
                //var resultr = context.Departments
                //    .Where(x => x.Id > 2)
                //    .OrderByDescending(x => x.DepartmentNo)
                //    .ToList();
                //var resulte = context.Departments
                //    .Where(x => x.Id == 3)
                //    .SingleOrDefault();//单笔数据查询返回
                var results = context.Departments
                   .Where(x => x.Id > 0)
                   .OrderByDescending(x => x.Id)
                   .FirstOrDefault();//查询结果是多笔数据返回第一笔

                //修改数据
                //results.DepartmentName = "宿舍";

                //context.SaveChanges();

                //删除数据
                context.Departments.Remove(results);
                context.SaveChanges();
            }

        }
    }
}
