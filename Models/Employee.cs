namespace CRUD_Depatment_and_Employee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int DepartmentId { get; set; }
        public Department department { get; set; } = null!;

    }
}
