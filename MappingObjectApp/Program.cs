// See https://aka.ms/new-console-template for more information
using AutoMapper;
using MappingObjectApp.Models;

Console.WriteLine("Hello, World!");

//Initialize the mapper
var config = new MapperConfiguration(cfg =>
        cfg.CreateMap<Employee, EmployeeDTO>()
    );


Employee emp = new Employee();
emp.Name = "James";
emp.Salary = 20000;
emp.Address = "London";
emp.Department = "IT";


//Using automapper
var mapper = new Mapper(config);
var empDTO = mapper.Map<EmployeeDTO>(emp);
//OR
//var empDTO2 = mapper.Map<Employee, EmployeeDTO>(emp);


//EmployeeDTO empDTO = new EmployeeDTO();
//empDTO.Name = emp.Name;
//empDTO.Salary = emp.Salary;
//empDTO.Address = emp.Address;
//empDTO.Department = emp.Department;


Console.WriteLine("Name:" + empDTO.Name + ", Salary:" + empDTO.Salary + ", Address:" + empDTO.Address + ", Department:" + empDTO.Department);
Console.ReadLine();