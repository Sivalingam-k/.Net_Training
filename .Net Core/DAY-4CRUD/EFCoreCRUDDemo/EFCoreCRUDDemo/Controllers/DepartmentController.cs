using EFCoreCRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUDDemo.Controllers
{
    public class DepartmentController : Controller
    {
        private CompanyContext context;

        public DepartmentController(CompanyContext cc)
        {
            context = cc;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Create()
        {
            //var dept = new Department()
            //{
            //    name = "Developing"

            //};
            //var dept1 = new Department()
            //{
            //    name = "TEsting"

            //};
            //var dept2 = new Department()
            //{
            //    name = "BA"

            //};
            //var dept3 = new Department()
            //{
            //    name = "Devops"

            //};

            //context.AddRange(dept,dept1,dept2,dept3);
            // context.SaveChanges();
            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> Create(Department dept)
        {
            context.Add(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            Department dept = await context.Departments.Where(e => e.id == id).FirstOrDefaultAsync();
            return View(dept);
        }
        [HttpPost]
       public async Task<IActionResult>Edit(Department dept)
        {
            context.Update(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var dept = new Department()
            {
                id = id
            };
            context.Remove(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(context.Departments.AsNoTracking());
        }
    }
}
