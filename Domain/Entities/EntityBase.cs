﻿using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public DateTime? CreatedAt { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string? DeletedBy { get; set; }

        public int Id { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? UpdatedBy { get; set; }

    }
}
