using System;

namespace Rittal.Shop.Models
{

    public class Customer : BaseEntity
    {
        private string firstName;
        private string lastName;
        private string color;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                lastName = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public CustomerType CustomerType { get; set; }
        public decimal? CreditAmount { get; set; }
        public bool IsOverLimit => CreditAmount > 500;
        public bool IsRemoved { get; set; }
        public string Avatar { get; set; }

        public string Color
        {
            get => color; set
            {
                color = value;

                OnPropertyChanged(nameof(Color));
            }
        }

    }


}
