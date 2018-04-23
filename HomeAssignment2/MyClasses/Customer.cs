using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAssignment2.MyClasses
{
    public class Customer
    {
        private String _fullAddress;
        private String _fullName;
        public Customer(string name, string address)
        {
            _fullAddress = address;
            _fullName = name;

        }
        public String FullAddress
        {
            get
            {
                return _fullAddress;

            }
        }
        public String FullName
        {
            get
            {
                return _fullName;

            }
        }
    }
}