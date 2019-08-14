using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndObject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            HappyBirthday birthdayMessage = new HappyBirthday();
            MessageBox.Show(birthdayMessage.getMessage("bro"));
        }

        private void Button2_Click(object sender, EventArgs e) {
            HappyBirthday birthdayMessage = new HappyBirthday();
            birthdayMessage.MyProperty = "dude";
            birthdayMessage.PresentCount = 3;

            string returnedMessage = birthdayMessage.getMessage("dude");

            MessageBox.Show(returnedMessage);
        }

        private void Button3_Click(object sender, EventArgs e) {
            MessageBox.Show(Stats.addUp(5, 6).ToString());
        }
    }
}
