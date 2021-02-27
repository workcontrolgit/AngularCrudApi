using AngularCRUDAPI.Application.Features.Employees.Queries.GetEmployees;
using AngularCRUDAPI.Application.Features.Positions.Commands.CreatePosition;
using AngularCRUDAPI.Application.Features.Positions.Queries.GetPositions;
using AngularCRUDAPI.Domain.Entities;
using AutoMapper;

namespace AngularCRUDAPI.Application.Mappings
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
