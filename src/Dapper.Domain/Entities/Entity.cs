﻿using Flunt.Notifications;
using System;

namespace Dapper.Domain.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
