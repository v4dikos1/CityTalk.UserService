﻿using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
    public class Friendship : BaseEntity<Guid>, IHaveDateTrack, IHaveDeleteTrack
    {
        /// <summary>
        /// Идентификатор пользователя, отправившего заявку
        /// </summary>
        public required Guid SourceUserId { get; set; }
        public Account SourceUser { get; set; } = null!;

        /// <summary>
        /// Идентификатор пользователя, получившего заявку
        /// </summary>
        public required Guid TargetUserId { get; set; }
        public Account TargetUser { get; set; } = null!;

        /// <summary>
        /// Состояние заявки
        /// </summary>
        public required FriendshipStatusEnum Status { get; set; }

        /// <summary>
        /// Дата отправления заявки
        /// </summary>
        public required DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Дата изменения заявки
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        public required bool IsDeleted { get; set; }
    }
}
