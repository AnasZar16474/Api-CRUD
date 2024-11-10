namespace CRUD_Depatment_and_Employee.DTOs.Employees
{
    public class CreateEmployeeDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}
