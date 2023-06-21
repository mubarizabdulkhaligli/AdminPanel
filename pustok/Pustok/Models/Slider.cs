using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [MaxLength(50)]

        public int Order { get; set; }
        public string Title1 { get; set; }
        [MaxLength(50)]
        public string Title2 { get; set; }
        [MaxLength (150)]
        public string Desc { get; set; }
        [MaxLength(30)]
        public string BtnText { get; set; }
        [MaxLength(150)]
        public string BtnUrl { get; set; }
        [MaxLength(150)]
        [Required]
        public string ImageName { get; set; }







    }
}
