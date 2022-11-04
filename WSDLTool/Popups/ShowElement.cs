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
using WSDLTool.Helpers;

namespace WSDLTool.Popups
{
    public partial class ShowElement : Form
    {
        public List<string> eleLists = new List<string>();
        public AddPart mainForm;
        public ShowElement()
        {
            InitializeComponent();
        }
        public ShowElement(AddPart _Part)
        {
            InitializeComponent();
            GetElement();
            var childNode = treeView1.Nodes[0];
            childNode.Nodes.Clear();
            foreach (string ele in eleLists)
            {
                childNode.Nodes.Add(ele);
            }
            mainForm = _Part; 
        }

        private void GetElement()
        {
            List<int> PID = ucLists.ElementReqs.Select(r => r.Parentid).ToList();
            foreach (int pid in PID)
            {
                var resEle = ucLists.ElementReqs.Where(res => res.Parentid == pid).FirstOrDefault();
                if (resEle != null)
                {
                    eleLists.Add(resEle.Name1);
                }

                var repEle = ucLists.ElementResps.Where(res => res.Parentid == pid).FirstOrDefault();
                if (repEle != null)
                {
                    eleLists.Add(repEle.Name1);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string selectEle = treeView1.SelectedNode.Text;
            mainForm.cboMessageType.Text = selectEle;
            this.Close();
        }
    }
}
