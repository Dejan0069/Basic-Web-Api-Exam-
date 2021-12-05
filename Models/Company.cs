using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiCRUD.Models
{
    public class Company
    {
        //[Key]

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string CompanyName { get; set;}

        //public ICollection<Contact> ContactId { get; set; }

        public Contact Contact { get; set; }

    }
}
