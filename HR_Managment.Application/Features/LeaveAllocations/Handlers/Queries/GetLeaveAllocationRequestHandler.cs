﻿using AutoMapper;
using HR_Managment.Application.Features.LeaveAllocations.Requests.Queries;
using HR_Managment.Application.Features.LeaveTypes.Requests.Queries;
using HR_Managment.Application.Persistence.Contracts;
using HR_Managment.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.LeaveAllocation;

namespace HR_Managment.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveRequestRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDTO>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,
            IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDTO>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocationList= await _leaveAllocationRepository.GetAll();

            return _mapper.Map<List<LeaveAllocationDTO>>(leaveAllocationList);
        }
    }
}
