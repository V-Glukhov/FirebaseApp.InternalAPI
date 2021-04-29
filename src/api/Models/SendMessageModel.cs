using System;
using System.ComponentModel.DataAnnotations;

namespace InternalApi.Models
{
    /// <summary>
    /// Модель для создания push-уведомления
    /// </summary>
    public class SendMessageModel
    {
        /// <summary>
        /// заголовок сообщения
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// текст сообщения
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// время отправки сообщения (текущее время или время в будущем),
        /// для немедленной отправки можно указать null или время <= текущему
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// список номеров телефонов (один или несколько) пользователей, для которых отправляется сообщение
        /// </summary>
        [Required]
        public string[] Phones { get; set; }
    }
}
