﻿using CRUD_Depatment_and_Employee.Data;
using CRUD_Depatment_and_Employee.DTOs.Employees;
using CRUD_Depatment_and_Employee.Models;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CRUD_Depatment_and_Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EmployeesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var Employees = context.Employees.ToList();
            var DTO = Employees.Adapt<IEnumerable<GetAllEmployeeDTO>>();
            return Ok(DTO);
        }
        [HttpPost("Create")]
        public IActionResult Create(CreateEmployeeDTO DTO)
        {
            var Employee = DTO.Adapt<Employee>();
            context.Employees.Add(Employee);
            context.SaveChanges();
            var DTOA = Employee.Adapt<GetAllEmployeeDTO>();

            return Ok(DTOA);
        }
        [HttpGet("Get")]
        public IActionResult Get(int Id)
        {
            var Employee = context.Employees.Find(Id);
            if(Employee is null)
            {
                return NotFound();
            }
            var DTO= Employee.Adapt<GetAllEmployeeDTO>();
            return Ok(DTO);
        }
        [HttpPut("Update")]
        public IActionResult Update(int Id,CreateEmployeeDTO DTO)
        {
            var Employee = context.Employees.Find(Id);
            if (Employee is null)
            {
                return NotFound();
            }
            DTO.Adapt(Employee);
            context.SaveChanges();
            var DTOA = Employee.Adapt<GetAllEmployeeDTO>();
            return Ok(DTOA);
        }
        [HttpDelete("Remove")]
        public IActionResult Remove(int Id)
        {
            var Employee = context.Employees.Find(Id);
            if (Employee is null)
            {
                return NotFound();
            }
            context.Employees.Remove(Employee);
            context.SaveChanges();
            return Ok("Success");

        }
    }
}
