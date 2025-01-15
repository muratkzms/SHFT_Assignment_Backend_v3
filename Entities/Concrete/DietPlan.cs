using Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DietPlan : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public float StartingWeight { get; set; }
        public int? ClientId { get; set; }
        public Client? Client { get; set; }
        public List<Meal>? Meals { get; set; } = new();
    }
}
