﻿using UNISD.Entities;

namespace UNISD.IServices
{
    public interface IEmployeeService
    {
       Task<object> GetAllEmployee();
        Task<object> GetEmpById(Guid id);
        Task<object> NewEmp(Employee employee);
        Task<object> UpdateEmp(Guid id, Employee updated);
        Task<object> DeleteEmp(Guid id);
    }
}
