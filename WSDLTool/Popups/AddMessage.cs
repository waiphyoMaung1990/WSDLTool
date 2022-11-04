using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSDLTool.Controls;
using WSDLTool.Froms;

namespace WSDLTool.Popups
{
    public partial class AddMessage : Form
    {
        public MainForm mainForm;
        public AddMessage()
        {
            InitializeComponent();
        }
        public AddMessage(MainForm _Main)
        {
            InitializeComponent();
            mainForm = _Main;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Point loc = new Point();
            uc_Message ele = new uc_Message(mainForm, loc, txtName.Text);
            this.Close();
        }
    }
}
