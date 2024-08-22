namespace EFCoreCRUDDemo.Models
{
    public class Department
    {
        public int id { get; set; } 
        public string name { get; set; }

        public ICollection<Employee> Employee { get; set; }    

    }
}
