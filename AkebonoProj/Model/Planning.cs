using AkebonoProj.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkebonoProj.Model
{
    public class Planning
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Item")]
        public string KodeItem { get; set; }
        public int QtyTarget { get; set; }
        public decimal WaktuTarget { get; set; }
        public virtual Items? Item { get; set; }
    }
}
