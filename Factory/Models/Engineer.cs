using System.Collections.Generic;
using System; 
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<EngineerMachine>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "License Date")]
        public DateTime LicenseDate { get; set; }
        [Display(Name = "Actively working on Repairs")]
        public bool Repairs { get; set; }

        public virtual ICollection<EngineerMachine> JoinEntities { get;}
    }
}