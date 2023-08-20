using System.ComponentModel.DataAnnotations;

namespace APIBodega.Models
{
    public class Permisos
    {
        [Key]
       public int up_rowid { get; set; }
       public  int up_adcnar { get; set; }
       public int up_mdfcar { get; set; }
       public int up_brrar { get; set; }
       public int up_lstar { get; set; }
    }
}
