using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSDLTool.Froms;

namespace WSDLTool.Popups
{
    public partial class AddExistingElement : Form
    {
        public Control controls;
        public MainForm mainForm;
        public List<string> types = new List<string>
        {
            "string",
            "int",
            "double",
            "float",
        };
        public AddExistingElement()
        {
            InitializeComponent();
        }
        public AddExistingElement(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            mainForm = _Main;
            controls = _Control;
            foreach (string type in types)
            {
                cboMessageType.Items.Add(type);
            }
        }
        private void btn_already_Click(object sender, EventArgs e)
        {

        }
    }
}
