using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject {
    class BirthdayParty : HappyBirthday {

        //Default Constructor
        public BirthdayParty() : base() {

        }

        //Method
        public string getParty(bool haveParty) {

            if (haveParty) {
                return "Have fun!";
            } else {
                return "Lame";
            }
        }
    }
}
