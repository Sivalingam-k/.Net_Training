namespace EFCoreCRUDDemo.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public int DepartmentId { get; set; }

        //Navigation Property(Employee is navigate to Department)
        public Department Department { get; set; }
    }
}
