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
using WSDLTool.Enums;
using WSDLTool.Froms;
using WSDLTool.Helpers;

namespace WSDLTool.Popups
{
    public partial class AddPortTypeOperation : Form
    {
        public MainForm mainForm;
        public Control controls;
        public AddPortTypeOperation()
        {
            InitializeComponent();
        }

        public AddPortTypeOperation(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            mainForm = _Main;
            controls = _Control;
            cboOperationType.Items.Clear();
            foreach(var i in Enum.GetValues(typeof(PortType)))
            {
                cboOperationType.Items.Add(i.ToString());
            }
            if(ucLists.Mesages != null && ucLists.Mesages.Count > 0)
            {
                foreach (uc_Message msg in ucLists.Mesages)
                {
                    if(msg != null && msg.Part != null)
                    {
                        var item = msg.Part;
                        cboInputMessage.Items.Add(item.EleType);
                    }
                    
                }
            }

            if (ucLists.Mesages != null && ucLists.Mesages.Count > 0)
            {
                foreach (uc_Message msg in ucLists.Mesages)
                {
                    if (msg != null && msg.Part != null)
                    {
                        var item = msg.Part;
                        cboOutputMessage.Items.Add(item.EleType);
                    }

                }
            }

            //gpboxInput.Visible = false;
            //gpboxOutput.Visible = false;
            //gpboxFaults.Visible = false;
        }

        private void cboOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
