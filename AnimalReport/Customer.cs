using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalReport
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string Description;

        private DateTime _Birthday;
        private string Age;

        //Creator
        public Customer(string firstName, string lastName, string address, string description, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Description = description;
            this._Birthday = birthday;
            this.Age = (DateTime.Now.Year - birthday.Year).ToString();
        }

        public string Agee
        {
            get { return Age; }
            set { Age = value; }
        }
        
        public string FullName
        {
            get { return this.FirstName + this.LastName; }
        }
    }
}
