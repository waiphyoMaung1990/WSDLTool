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

namespace WSDLTool.Controls
{
    public partial class uc_PortType : UserControl
    {
        private int id;
        private string name;
        private OperationType operationType;
        public int Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public OperationType OperationType
        {
            get => operationType;
            set
            {
                if (value == null)
                {
                    operationType = new OperationType();
                }
                else
                {
                    operationType = value;
                }
            }
        }

        public uc_PortType()
        {
            InitializeComponent();
        }

        public uc_PortType(MainForm _Main, Point _Loc, string _Name)
        {
            InitializeComponent();
            this.addOperationItem.Click += _Main.addOperationItem_Click;
            var point = new Point();
            point.X = _Loc.X + 20;
            point.Y = _Loc.Y + 20;
            this.Location = point;
            Point point1 = new Point(_Loc.X + 30, _Loc.Y + 30);
            this.Location = point1;
            this.Id = cls_Common.parentCount;
            this.Name1 = _Name;
            lblPortType.Text = _Name;   
            ControlExtension.Draggable(this, true);
            _Main.panelPortType.Controls.Add(this);
            ucLists.PortTypes.Add(this);
            cls_Common.parentCount++;
        }

        public uc_PortType(MainForm _Main, Control _Control)
        {
            InitializeComponent();
        }
    }
}
