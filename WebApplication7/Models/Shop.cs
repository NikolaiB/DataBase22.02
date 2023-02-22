using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApplication7.Models
{
    public class Shop
    {
        [Key]
        public int ShopID { get; set; }

        [DataMember]
        public string ShopName { get; set; }
    }
}
