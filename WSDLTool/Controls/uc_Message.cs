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
    public partial class uc_Message : UserControl
    {
        private int id;
        private int parentid;
        private string name;
        private parts _part;
        private int elementtype;
        public int ID { get => id; set => id = value; }
        public int Parentid { get => parentid; set => parentid = value; }
        public string Name1 { get => name; set => name = value; }
        public parts Part { 
            get => _part;

            set 
            { 
                if(value == null)
                {
                    _part = new parts();
                }
                else
                {
                    _part = value;
                }
            }
        }

        public int Elementtype { get => elementtype; set => elementtype = value; }

        public uc_Message()
        {
            InitializeComponent();
        }
        public uc_Message(MainForm _Main, Point _Loc, string _Name)
        {
            InitializeComponent();
            this.addParameterItem.Click += _Main.addParameterItem_Click;
            var point = new Point();
            point.X = _Loc.X + 20;
            point.Y = _Loc.Y + 20;
            this.Location = point;
            int cCount = 1;
            var msg = new uc_Message
            {
                Name1 = _Name ,
                ID = cls_Common.msgCount,
            };
            Point point1 = new Point(_Loc.X+30, _Loc.Y+30);
            msg.Location = point1;
            msg.lblMessage.Text = msg.Name1;
            msg.addParameterItem.Click += _Main.addParameterItem_Click;
            ControlExtension.Draggable(msg, true);
            _Main.panelMessage.Controls.Add(msg);
            ucLists.Mesages.Add(msg);
            cls_Common.msgCount++;
        }

        public uc_Message(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            var msgEle = (uc_Message)_Control;
            int id = msgEle.ID;
            var lblElement = new Label
            {
                Text = "+  " + msgEle.Part.ParameterName + " : " + msgEle.Part.EleType,
                Width = 182,
                Height = 20,
            };
            //Add location of new Element
            cls_Common.txtElementHeight = 70;
            lblElement.Location = new Point(0, cls_Common.txtElementHeight);
            msgEle.Controls.Add(lblElement);
            //Update Complex Element in Main.panel_load
            _Main.panelMessage.Controls.Add(msgEle);
            var oldMsg = ucLists.Mesages.Where(ms => ms.ID == id).FirstOrDefault();
            if (oldMsg.Part == null)
            {
                oldMsg.Part = new Helpers.parts();
            }
            oldMsg.Part.ParameterName = msgEle.Part.ParameterName;
            oldMsg.Part.EleType = msgEle.Part.EleType;
        }

    }
}
