using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Val
    {
        public string _vacancy;
        public string _companyName;
        public string _info;
        public string _emploer;

        public string Vacancy
        {
            get
            {
                return _vacancy;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Emply vacancy field");
                }
                _vacancy = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Emply company field");
                }
                _companyName = value;
            }
        }
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Emply info field");
                }
                _info = value;
            }
        }
        public string Emploer
        {
            get
            {
                return _emploer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Emply emploer field");
                }
                _emploer = value;
            }
        }
    }
}
