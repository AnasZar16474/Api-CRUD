﻿namespace CRUD_Depatment_and_Employee.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Department> Departments { get; set; } = null!;

    }
}
