using System;

namespace Rittal.Shop.Models
{

    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public CustomerType CustomerType { get; set; }
        public decimal? CreditAmount { get; set; }
        public bool IsOverLimit => CreditAmount > 500;
        public bool IsRemoved { get; set; }
        public string Avatar { get; set; }

    }

    
}
