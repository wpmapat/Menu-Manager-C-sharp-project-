using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuManager
{
   public class MenuDate
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MenuItem")]
        public int MenuID { get; set; }
        public virtual MenuItem Item { get; set; }
        public DateTime DateOfMenu { get; set; }

    }
}
