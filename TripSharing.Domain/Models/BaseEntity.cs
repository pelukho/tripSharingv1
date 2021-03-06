using System;

namespace TripSharing.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}