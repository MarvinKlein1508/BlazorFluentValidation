using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Models
{
    public class Customer : INotifyPropertyChanged
    {

        private string _firstName = String.Empty;

        public string FirstName
        {
            get => _firstName;
            set 
            {
                _firstName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }



        private string _lastName = String.Empty;

        public string LastName
        {
            get => _lastName;
            set 
            {
                _lastName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(LastName)));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
