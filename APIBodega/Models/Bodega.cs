using System.ComponentModel.DataAnnotations;

namespace APIBodega.Models
{
    public class Bodega
    {
        [Key]
        public string bo_cdgo { get; set; } = string.Empty;
        public string bo_dscrpcion { get; set; } = string.Empty;
        public int bo_prpia { get; set; }
        public string bo_plnta { get; set; } = string.Empty;
        public int bo_actva { get; set; }
    }
}
