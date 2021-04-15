using System;
using System.Collections.Generic;
using System.Text;

namespace BSTreeADT
{
    public class Customer
    {
        public string lastName { get; private set; }

        public string firstName { get; private set; }

        public long phoneNum { get; private set; }

        public Customer(string firstName, string lastName, long phoneNum)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.phoneNum = phoneNum;
        }

        public int CompareTo(Customer other)
        {


            if (this.lastName.CompareTo(other.lastName) < 0)
            {
                return -1;
            }
            else if (this.lastName.CompareTo(other.lastName) == 0 &&
                        this.firstName.CompareTo(other.firstName) == 0)
            {
                return 0;
            }
            else if (this.lastName.CompareTo(other.lastName) == 0 &&
                        this.firstName.CompareTo(other.firstName) < 0)
            {

                return -1;
            }
            else
            {

                return 1;
            }

        }


    }
}
