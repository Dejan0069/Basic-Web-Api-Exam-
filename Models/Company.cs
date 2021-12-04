using System.ComponentModel.DataAnnotations;

namespace WebApiCRUD.Models
{
    public class Company
    {
        //[Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set;}

    }
}
