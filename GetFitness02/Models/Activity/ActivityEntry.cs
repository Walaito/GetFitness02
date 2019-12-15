using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GetFitness02.Models.Activity
{
    public class ActivityEntry
    {
        public int ActivityEntryId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Now;

        public int Duration { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int ActivityItemId { get; set; }
        public ActivityItem ActivityItem { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        //public decimal TotalCal { get { return ((ActivityItem.Calorie * Weight) * (Duration / 60)); } }

        //public decimal totalCal() { return ((ActivityItem.Calorie * Weight)*(Duration/60)); }
    }
}
