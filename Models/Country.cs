using System.Collections.Generic;

namespace WebApiCRUD.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        //public ICollection<Contact> CountactId { get; set; }

        public Contact Contact { get; set; }
    }
}
