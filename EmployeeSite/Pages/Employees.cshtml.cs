using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeSite.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSite.Pages
{
    public class EmployeesModel : PageModel
    {

        private readonly EmployeeDataContext _dataContext;
        public List<Employee> Employees { get; set; }
        public EmployeesModel(EmployeeDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task OnGetAsync()
        {
            Employees = await _dataContext.Employees.ToListAsync();
        }
    }
}