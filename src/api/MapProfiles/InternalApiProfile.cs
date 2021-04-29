using AutoMapper;
using InternalApi.Models;
using InternalAPI.BL.Contracts.Commands;

namespace InternalApi.MapProfiles
{
    /// <summary>
    /// Профиль для UserService
    /// </summary>
    public class InternalApiProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public InternalApiProfile()
        {
            CreateMap<SendMessageModel, SendMessageCommand>();
        }
    }
}
