namespace Customers
{
    using Customers.Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string address;
        private string phone;
        private string email;

        public Customer(string firstName, string middleName, string lastName, long id, string address, string phone, string email,
            CustomerTypes type,List<Payment> payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.CustomerType = type;
            this.Payments = payments;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Middle name cannot be null or empty");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public long ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value.ToString().Length != 10)
                {
                    throw new ArgumentOutOfRangeException("ID must be 10 digits long");
                }

                this.id = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address cannot be null or empty");
                }

                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or empty");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Email cannot be null or empty");
                }

                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Email must contain @");
                }

                this.email = value;
            }
        }

        public CustomerTypes CustomerType { get; set; }

        public List<Payment> Payments { get; set; }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (Object.Equals(this.FirstName, customer.FirstName))
            {
                return true;
            }

            if (Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return true;
            }

            if (Object.Equals(this.LastName, customer.LastName))
            {
                return true;
            }

            if (Object.Equals(this.Payments, customer.Payments))
            {
                return true;
            }

            if (Object.Equals(this.ID,customer.ID))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("First Name: {0}\nLast Name: {1}\nID: {2}\nCustomer Type: {3}\n", this.FirstName, this.LastName, this.ID, this.CustomerType);
            result.AppendLine("Payments:");
            foreach (var payment in this.Payments)
            {
                result.AppendLine(payment.ToString());
            }
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.ID.GetHashCode() ^
                this.Address.GetHashCode() ^
                this.Phone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Payments.GetHashCode() ^
                this.CustomerType.GetHashCode();
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !Customer.Equals(customer1, customer2);
        }

        public object Clone()
        {
            List<Payment> newPayments = new List<Payment>();
            foreach (var payment in this.Payments)
            {
                newPayments.Add(payment);
            }

            return new Customer(string.Copy(this.FirstName), string.Copy(this.MiddleName), string.Copy(this.LastName),
                this.ID, string.Copy(this.Address), string.Copy(this.Phone), string.Copy(this.Email), this.CustomerType, newPayments);
        }

        public int CompareTo(Customer other)
        {
            string fullName1 = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string fullName2 = other.FirstName + " " + other.MiddleName + " " + other.LastName;

            if (fullName1!=fullName2)
            {
                return fullName1.CompareTo(fullName2);
            }

            return this.ID.CompareTo(other.ID);
        }
    }
}
