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
    public partial class AddPortType : Form
    {
        public MainForm mainForm;
        public AddPortType()
        {
            InitializeComponent();
        }

        public AddPortType(MainForm _Main)
        {
            InitializeComponent();
            mainForm = _Main;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Point point = new Point(40,30);
            uc_PortType uc_Port = new uc_PortType(mainForm, point, txtPortType.Text);
            this.Close();
        }
    }
}
