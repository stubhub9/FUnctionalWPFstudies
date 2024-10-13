using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExamples
{
    class Employee1 : INotifyPropertyChanged
    {
        public decimal _salary;

        /*  PropertyChangedEventHandler?  is the Implementation of 
         INotifyPropertyChanged  */
        public event PropertyChangedEventHandler? PropertyChanged;

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Title { get; set; }
        public required string HireDate { get; set; }

        public required decimal Salary
        {
            get => _salary;
            set
            {
                _salary = value;

                //  Support TwoWay binding
                PropertyChanged?.Invoke ( this, new PropertyChangedEventArgs ( nameof ( Salary ) ) );
            }
        }


    }
}
