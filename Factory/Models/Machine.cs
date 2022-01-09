using System.Collections.Generic;
using System; 
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public string Name{ get; set; }
    public int MachineId { get; set; }    
    [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Inspection Date")]
    public DateTime InspectionDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set ;}
  }
}