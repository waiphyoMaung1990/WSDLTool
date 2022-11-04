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
    public partial class AddElement : Form
    {
        public MainForm mainForm;
        public List<string> types = new List<string>
        {
            "string",
            "int",
            "double",
            "float",
        };
        public AddElement()
        {
            InitializeComponent();
        }
        public AddElement(MainForm _Main)
        {
            InitializeComponent();
            mainForm= _Main;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Point loc = new Point();
            string typeName = String.Empty;
            if (rComplexType.Checked)
            {
                typeName = "ComplexType";
            }
            uc_Element ele = new uc_Element(mainForm, loc, txtElementName.Text, 0, typeName);
            this.Close();
        }
    }
}
