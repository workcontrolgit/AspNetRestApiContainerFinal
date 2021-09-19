using AspNetRestApiContainer.Application.Features.Employees.Queries.GetEmployees;
using AspNetRestApiContainer.Application.Features.Positions.Commands.CreatePosition;
using AspNetRestApiContainer.Application.Features.Positions.Queries.GetPositions;
using AspNetRestApiContainer.Domain.Entities;
using AutoMapper;

namespace AspNetRestApiContainer.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}