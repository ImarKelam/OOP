namespace Customer
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string address;
        private string phone;
        private string email;
        private IList<Payment> payments;
        private CustomerType custType;

        public Customer(string firstName, string middleName, string lastName, string id, string address, string phone,
            string email, IList<Payment> payments, CustomerType custType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Payments = payments;
            this.CustType = custType;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name can't be empty! ");
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name can't be empty! ");
                this.middleName = value;
                
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name can't be empty! ");
                this.lastName = value;
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                if(value.Length != 10)
                    throw new ArgumentOutOfRangeException("Invalid ID! ");
                this.id = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The address can't be empty! ");
                this.address = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The phone can't be empty! ");
                this.phone = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrEmpty(value) || !value.Contains("@"))
                    throw new ArgumentNullException("Invalid or empty email! ");
                this.email = value;
            }
        }

        public IList<Payment> Payments
        {
            get { return new List<Payment>(payments); }
            set
            {
                this.payments = value;
            }
        }

        public CustomerType CustType
        {
            get { return custType; }
            set { this.custType = value; }
        }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (customer == null)
                return false;

            if (!Object.Equals(this.Id, customer.Id))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode();
        }

        public static bool operator == (Customer cust1, Customer cust2)
        {
            return Customer.Equals(cust1, cust2);
        }

        public static bool operator != (Customer cust1, Customer cust2)
        {
            return !(Customer.Equals(cust1, cust2));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("Name: " + this.FirstName + " " + this.MiddleName + " " + this.LastName + " ID: " + this.Id);

            return output.ToString();
        }

        public object Clone()
        {
            Customer c = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.Address,
                this.Phone,
                this.Email,
                new List<Payment>(),
                this.CustType
                );

            foreach (var payment in this.Payments)
            {
                c.Payments.Add(new Payment(payment.ProductName, payment.Price));
            }

            return c;
        }

        public int CompareTo(Customer other)
        {
            string thisName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string otherName = other.FirstName + " " + other.MiddleName + " " + other.LastName;

            if (thisName.CompareTo(otherName) == 0)
            {
                return this.Id.CompareTo(other.Id);
            }

            return thisName.CompareTo(otherName);
        }
    }
}
