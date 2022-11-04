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
using WSDLTool.Helpers;
using WSDLTool.Popups;

namespace WSDLTool.Froms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelMessage.Visible = false;
            tblPanelMessage.Visible = false;
            panelPortType.Visible = false;
            tblPanelPortType.Visible = false;
            panelType.Visible = true;
            tblPanelType.Visible = true;
        }

        private void btnModel_MouseHover(object sender, EventArgs e)
        {
            do
            {
                panelDropdown.Height += 41;
            }
            while (panelDropdown.Height < panelDropdown.MaximumSize.Height);
        }

        #region Types
        private void btnType_Click(object sender, EventArgs e)
        {
            panelMessage.Visible = false;
            tblPanelMessage.Visible = false;
            panelPortType.Visible = false;
            tblPanelPortType.Visible = false;
            panelType.Visible = true;
            tblPanelType.Visible = true;
            AddElement addElement = new AddElement(this);
            addElement.ShowDialog();
        }
        public void addElementItem_Click(object sender, EventArgs e)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            AddParameter addParameter = new AddParameter(this, control);
            addParameter.ShowDialog();
        }

        public void AddElementProperty_Click(object sender, EventArgs e)
        {
            Control control = ((Label)sender).Parent;
            var ucEle = (uc_Element)control;
            cls_Common.temp_element_id = ucEle.ID;
            if (ucEle != null)
            {
                dataGridView1.Rows.Clear();  //to change list view
                dataGridView1.Rows.Add(5);

                dataGridView1.Rows[0].Cells[0].Value = "MethodName ";
                dataGridView1.Rows[0].Cells[1].Value = ((Label)sender).Text;
                dataGridView1.Rows[1].Cells[0].Value = "MinOccours ";
                dataGridView1.Rows[1].Cells[1].Value = ucEle.MinOcc;
                dataGridView1.Rows[2].Cells[0].Value = "MaxOccurs ";
                dataGridView1.Rows[2].Cells[1].Value = ucEle.MaxOcc;
                dataGridView1.Rows[3].Cells[0].Value = "Type ";
                dataGridView1.Rows[3].Cells[1].Value = ucEle.DataType;
                dataGridView1.Rows[4].Cells[0].Value = "ResponseType ";
                //dataGridView1.Rows[5].Cells[1]
                dataGridView1.Rows[4].Cells[1].Value = ucEle.ResponseDataType;
                //btnBindDataToElement.Visible = true;
            }
        }
        private void btnOnlyType_Click(object sender, EventArgs e)
        {

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.ShowDialog();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Messages
        private void btnMessage_Click(object sender, EventArgs e)
        {
            panelType.Visible = false;
            tblPanelType.Visible = false;
            panelPortType.Visible = false;
            tblPanelPortType.Visible = false;
            panelMessage.Visible = true;
            tblPanelMessage.Visible = true;
            tblPanelMessage.Location = new Point(0, 0);
            AddMessage addMessage = new AddMessage(this);
            addMessage.ShowDialog();
        }

        public void addParameterItem_Click(object sender, EventArgs e)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            AddPart addParameter = new AddPart(this, control);
            addParameter.ShowDialog();
        }
        private void btnOnlyMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnMessageShow_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm(true);
            propertiesForm.ShowDialog();
        }
        private void btnMessageExport_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region PortType

        private void btnPortType_Click(object sender, EventArgs e)
        {
            panelMessage.Visible = false;
            tblPanelMessage.Visible = false;
            panelPortType.Visible = true;
            tblPanelPortType.Visible = true;
            panelType.Visible = false;
            tblPanelType.Visible = false;
            AddPortType addPortType = new AddPortType(this);
            addPortType.ShowDialog();
        }

        public void addOperationItem_Click(object sender, EventArgs e)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            AddPortTypeOperation addPortTypeOperation = new AddPortTypeOperation(this, control);
            addPortTypeOperation.ShowDialog();
        }
        private void btnPortTypeShow_Click(object sender, EventArgs e)
        {

        }

        private void btnPortTypeExport_Click(object sender, EventArgs e)
        {

        }

        private void btnOnlyPortTypeShow_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Bindings
        private void btnBinding_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Services
        private void btnService_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Privates
        private Point GetPoint(object sender)
        {
            Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            var wsdlType = (uc_Element)control;
            return new Point(wsdlType.Width, wsdlType.Height);
        }
        private Point GetPoint(object sender, bool child)
        {
            if (child)
            {
                ToolStripMenuItem mi = sender as ToolStripMenuItem;
                var wsdlElement = new uc_Element();
                if (mi != null)
                {
                    ToolStripDropDownMenu owner = mi.Owner as ToolStripDropDownMenu;
                    if (owner != null)
                    {
                        ToolStripItem toolStrip = owner.OwnerItem;
                        ContextMenuStrip contextMenuStrip = toolStrip.Owner as ContextMenuStrip;
                        var control = contextMenuStrip.SourceControl;
                        wsdlElement = (uc_Element)control;
                    }
                }
                return new Point(wsdlElement.Width, wsdlElement.Height);
            }
            else
            {
                Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
                var wsdlElement = (uc_Element)control;
                return new Point(wsdlElement.Width, wsdlElement.Height);
            }

        }
        #endregion

       
    }
}
