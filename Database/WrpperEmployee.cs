using AutoMapper;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class WrpperEmployee
    {
        private readonly IMapper mapper;
        public WrpperEmployee()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeClone>();
            });

            mapper = configuration.CreateMapper();
        }


        public List<EmployeeClone> GetAllEmployees()
        {
            var context = new TryDbContext();
            List<Employee> employees = context.Employees.ToList();
            var cloneEmployees = mapper.Map<List<EmployeeClone>>(employees);
            return cloneEmployees;
        }
    }
}
