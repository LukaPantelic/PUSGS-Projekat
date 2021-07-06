﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.NClasses;

namespace WebApp.Models
{
    public class WorkPlan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public virtual WorkOrder WorkOrder { get; set; } //ulicu izvlacimo odavde
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string UserID { get; set; } // fullname i br telefona izvlacimo odavde
        public string Purpose { get; set; }
        public string Notes { get; set; }
        public string Company { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<WorkPlanDevice> Devices { get; set; }
        public virtual ICollection<SafetyDoc> SafetyDocs { get; set; }
        public virtual Crew Crew { get; set; }
        public virtual ICollection<Instruction> Instructions { get; set; }
        public virtual ICollection<HistoricChange> History { get; set; }
    }
}
