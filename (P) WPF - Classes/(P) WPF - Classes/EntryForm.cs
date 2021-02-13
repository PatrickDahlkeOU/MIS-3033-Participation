using System;
using System.Collections.Generic;
using System.Text;

namespace _P__WPF___Classes
{
    public class EntryForm
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Zipcode { get; set; }

        public EntryForm ()
        {
            Name = String.Empty ;

            Address = String.Empty ;

            Zipcode = 0;

        }

        public EntryForm ( string name, string address, int zipCode )
        {
            Name = name;

            Address = address;

            Zipcode = zipCode;
        }

        public override string ToString()
        {
            return $"{Name}: {Address}, {Zipcode}";
        }


    }
}
