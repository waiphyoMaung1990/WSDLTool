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
using WSDLTool.Helpers;

namespace WSDLTool.Popups
{
    public partial class AddPart : Form
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
        public int parentId;
        public AddPart()
        {
            InitializeComponent();
        }
        public AddPart(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            mainForm = _Main;
            controls = _Control;
            foreach (string type in types)
            {
                cboMessageType.Items.Add(type);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            var msgEle = (uc_Message)controls;
            int id = msgEle.ID;
            if(msgEle.Part == null)
            {
                msgEle.Part = new Helpers.parts();
            }
            msgEle.Part.ParameterName = txtParamName.Text;
            msgEle.Part.EleType = cboMessageType.Text;
            uc_Message uc_ = new uc_Message(mainForm, msgEle);
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ShowElement showElement = new ShowElement(this);
            showElement.ShowDialog();
        }

        private void cboMessageType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
