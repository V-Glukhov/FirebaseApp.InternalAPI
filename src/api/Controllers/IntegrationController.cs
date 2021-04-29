using AutoMapper;
using InternalApi.Models;
using InternalAPI.BL.Contracts.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace InternalApi.Controllers
{
    /// <summary>
    /// Web API, предназначенный для вызова из внутренних сервисов
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("/api/[controller]/v{version:apiVersion}")]
    public class IntegrationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public IntegrationController(
            IMediator mediator, 
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Метод создания push-уведомления
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateMessage([Required] SendMessageModel model) => 
            await _mediator.Send(_mapper.Map<SendMessageCommand>(model))
                ? Ok()
                : BadRequest();
    }
}
