using System.ComponentModel.DataAnnotations;

namespace MDD.Dtos
{
    public class MyDailyDataCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        public string CreationDate { get; set; }
    }
}