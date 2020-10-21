using System.ComponentModel.DataAnnotations;

namespace Wsei.Exchanges.Things.Web.Models
{
    public class ExchangesModel
    {
        [Required]
        public string Name { get; set; }
    }
}
