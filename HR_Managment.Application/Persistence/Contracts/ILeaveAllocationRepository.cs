﻿using HR_Managment.Domain.Persistence.Contracts;
using HR_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);



    }
}
