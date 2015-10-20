using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_account_checker
{
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "test";
            string password = "testpw";
            label1.Text = "        {" + "\r\n" + "\"agent\": {" + "\r\n" + "    \"name\": \"Minecraft\"," + "\r\n" + "    \"version\": 1" + "\r\n" + "}," + "\r\n" + "\"username\": \"" + user + "\"," + "\r\n" + "\"password\": \"" + password + "\"" + "\r\n" + "}";
        }
        
    }
}
