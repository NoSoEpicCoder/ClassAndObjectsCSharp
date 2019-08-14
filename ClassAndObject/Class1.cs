using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject {
    class HappyBirthday {
        private string birthdayMessage;
        private int numberOfPresents;

        //Default Constructor
        public HappyBirthday() {
            numberOfPresents = 0;
        }

        //Method
        public string getMessage(string givenName) {
            return "Happy Birthday " + givenName + "\n" + "Number of presents " + numberOfPresents.ToString();
        }

        //Read and Write Property
        public string MyProperty {
            get { return birthdayMessage; }
            set { birthdayMessage = value; }
        }

        //Write-Only Property
        public int PresentCount {
            set { numberOfPresents = value; }
        }
    }
}
