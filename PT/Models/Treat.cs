using System.Collections.Generic;
using System.ComponentModel;

namespace PT.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinEntries = new HashSet<TreatFlavor>();
        }
        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<TreatFlavor> JoinEntries { get; set; }

    }
}