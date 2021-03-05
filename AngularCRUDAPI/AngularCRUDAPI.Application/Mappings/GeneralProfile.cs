using AngularCrudApi.Application.Features.Employees.Queries.GetEmployees;
using AngularCrudApi.Application.Features.Positions.Commands.CreatePosition;
using AngularCrudApi.Application.Features.Positions.Queries.GetPositions;
using AngularCrudApi.Domain.Entities;
using AutoMapper;

namespace AngularCrudApi.Application.Mappings
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