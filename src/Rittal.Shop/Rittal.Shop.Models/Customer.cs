using System;

namespace Rittal.Shop.Models
{

    public class Customer : BaseEntity
    {
        private string firstName;
        private string lastName;
        private string color;
        private decimal? creditAmount;

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
        public decimal? CreditAmount
        {
            get => creditAmount; set
            {
                creditAmount = value;
                OnPropertyChanged();
            }
        }
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
