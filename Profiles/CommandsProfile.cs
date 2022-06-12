using AutoMapper;
using MinApiNetSix.Dtos;
using MinApiNetSix.Models;

namespace MinApiNetSix.Profiles;

public class CommandsProfile : Profile
{
    public CommandsProfile()
    {
        //Source->Traget
        CreateMap<Command, CommandReadDto>();
        CreateMap<CommandCreateDto, Command>();
        CreateMap<CommandUpdateDto, Command>();
    }
}