using System.ComponentModel.DataAnnotations;

namespace Wsei.Exchanges.Things.Web.Models
{
    public class ExchangesModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsVisible { get; set; }
    }
}
