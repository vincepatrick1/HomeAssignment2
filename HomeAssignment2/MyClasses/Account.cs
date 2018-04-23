using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAssignment2.MyClasses
{
    public class Account
    {
        private String _type;
        public double _balance;
        private String _nickname;

        public String Type
        {
            get
            {
                return _type;

            }
            set
            {
                _type = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;

            }
            set
            {
                _balance = value;
            }
        }
        public string Nickname
        {
            get
            {
                return _nickname;

            }
            set
            {
                _nickname = value;
            }
        }
        public bool hasLoanOffer()
        {
            if (Balance > 1500)
                return true;
            else
                return false;

        }
    }
}