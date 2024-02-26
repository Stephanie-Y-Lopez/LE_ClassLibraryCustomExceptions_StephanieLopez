using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class Player
    {
        //Fields
        string _name;
        string _number;

        //Constructor
        public Player(string name, string number)
        {
            _name = name;
            _number = number;
        }

        //Properties
        public string Name { get => _name; set => _name = value; }
        public string Number { get => _number; set => _number = value; }

        public override string ToString()
        {
            return $"{_name} - {_number}";
        }

        public string name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new PlayerException("Enter a valid name please.");

                _name = value;
            }
        }

        public string number
        {
            get { return _number; }
            set
            {
                if (!int.TryParse(value, out int num) || num < 1 || num > 999)
                    throw new PlayerException("Enter a valid number please.");

                _number = value;
            }
        }
    }
}
