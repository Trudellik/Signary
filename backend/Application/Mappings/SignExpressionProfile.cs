namespace Signary.Application.Mappings
{
    using AutoMapper;
    using Signary.Domain.Entities;
    using Signary.Application.DTOs;

    public class SignExpressionProfile : Profile
    {
        public SignExpressionProfile()
        {
            CreateMap<SignExpression, SignExpressionDto>();
            CreateMap<SignDefinition, SignDefinitionDto>();
            CreateMap<MouthingOption, MouthingOptionDto>();
            CreateMap<Tag, TagDto>();
        }
    }
}
