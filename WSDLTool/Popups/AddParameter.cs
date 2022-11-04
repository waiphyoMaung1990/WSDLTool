using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class AddParameter : Form
    {
        public MainForm mainForm;
        public Control controls;
        public List<string> types = new List<string>
        {
            "string",
            "int",
            "double",
            "float",
        };
        string selectedType = "string";
        public AddParameter()
        {
            InitializeComponent();
        }

        public AddParameter(MainForm _Main,Control _Control)
        {
            InitializeComponent();
            mainForm = _Main;
            controls = _Control;
            txtMaxOccur.Text = "1";
            txtMinOccur.Text = "1";
            foreach(string type in types)
            {
                cboType.Items.Add(type);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           // var _oldE = (uc_Element)controls;
            var _ele = (uc_Element)controls;
            _ele.ParamName = txtParamName.Text;
            _ele.MinOcc = txtMinOccur.Text;
            _ele.MaxOcc = txtMaxOccur.Text;
            if(_ele.ID == 1)
            {
                _ele.DataType = selectedType;
            }
            else
            {
                _ele.ResponseDataType = selectedType;
            }
            var contr = (Control)_ele;
            uc_Element ele = new uc_Element(mainForm, contr);
            this.Close();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = (string)cboType.SelectedItem;
        }
    }
}
