using MediatR;
using System;

namespace InternalAPI.BL.Contracts.Commands
{
    /// <summary>
    /// Команда для создания push-уведомления
    /// </summary>
    public class SendMessageCommand : IRequest<bool>
    {
        /// <summary>
        /// заголовок сообщения
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// текст сообщения
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// время отправки сообщения (текущее время или время в будущем),
        /// для немедленной отправки можно указать null или время <= текущему
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// список номеров телефонов (один или несколько) пользователей, для которых отправляется сообщение
        /// </summary>
        public string[] Phones { get; set; }
    }
}
