using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WSDLTool.Froms;
using WSDLTool.Helpers;

namespace WSDLTool.Controls
{
    public partial class uc_Element : UserControl
    {
        private int id;
        private int reqid;
        private int resid;
        private int parentid;
        private string name;
        private string minOcc;
        private string maxOcc;
        private string dataType;
        private string responseDataType;
        private ucParamLists param;
        private string paramName;
        public int ID { get => id; set => id = value; }
        public int Reqid { get => reqid; set => reqid = value; }
        public int Resid { get => resid; set => resid = value; }
        public string Name1 { get => name; set => name = value; }
        public string MinOcc { get => minOcc; set => minOcc = value; }
        public string MaxOcc { get => maxOcc; set => maxOcc = value; }
        public string DataType { get => dataType; set => dataType = value; }
        public string ResponseDataType { get => responseDataType; set => responseDataType = value; }
        public int Parentid { get => parentid; set => parentid = value; }
        public string ParamName { get => paramName; set => paramName = value; }
        public Label lblTest { get; set; }
        public ucParamLists Param
        {
            get => param;
            set
            {
                if (value == null)
                {
                    param = new ucParamLists();
                }
                else
                {
                    param = value;
                }
            }
        }

        public uc_Element()
        {
            InitializeComponent();
        }

        public uc_Element(MainForm _Main, Point _Loc, string _Name, int _ElementTypeId,string _TypeName)
        {
            InitializeComponent();
            this.addElementItem.Click += _Main.addElementItem_Click;
            var point = new Point();
            point.X = _Loc.X + 20;
            point.Y = _Loc.Y + 20;
            this.Location = point;
            int cCount = 1;
            
            if(_ElementTypeId == 0)
            {
                var reqEle = new uc_Element
                {
                    Name1 = _Name + "Request",
                    Parentid = cls_Common.parentCount,
                    ID = 1,
                };
                var resEle = new uc_Element
                {
                    Name1 = _Name + "Response",
                    Parentid = cls_Common.parentCount,
                    ID = 2,
                };
                
                ucLists.ElementReqs.Add(reqEle);
                ucLists.ElementResps.Add(resEle);
                cls_Common.parentCount++;
                
                Point point1 = new Point(30, 30);
                reqEle.Location = point1;
                reqEle.lblElement.Text = reqEle.Name1;
                reqEle.lblTypeName.Text = _TypeName;
                reqEle.addElementItem.Click += _Main.addElementItem_Click;
                ControlExtension.Draggable(reqEle, true);
                _Main.panelType.Controls.Add(reqEle);

                point1 = new Point(70, 70);
                resEle.Location = point1;
                resEle.lblElement.Text = resEle.Name1;
                resEle.lblTypeName.Text = _TypeName;
                resEle.addElementItem.Click += _Main.addElementItem_Click;
                ControlExtension.Draggable(resEle, true);
                _Main.panelType.Controls.Add(resEle);
            }
            else
            {

            }
           
        }

        public uc_Element(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            var uc_Ele = (uc_Element)_Control;
            int parentId = uc_Ele.parentid;
            if (uc_Ele.ID == 1)
            {
                var tempEle = ucLists.ElementReqs.Where(i => i.parentid == parentId).FirstOrDefault();
                if (tempEle != null)
                {
                    if (tempEle.Param != null && tempEle.Param.ParamLists.Count > 0)
                    {
                        int count = tempEle.Param.ParamLists.Count;
                        string Name = uc_Ele.ParamName;
                        //Update location of new Element parameter
                        cls_Common.txtElementHeight = (count * 20) + 70;
                        //Update param Count
                        cls_Common.paramCount++;
                    }
                    else
                    {
                        //Inilization location of new Element parameter
                        cls_Common.txtElementHeight = 70;
                        //Inilization param Count
                        cls_Common.paramCount = 1;
                    }
                    var lblElement = new Label
                    {
                        Text = "+  " + uc_Ele.ParamName +" : " + uc_Ele.dataType,
                        Width = 182,
                        Height = 20,
                    };
                    lblElement.Click += _Main.AddElementProperty_Click;
                    uc_Ele.Controls.Add(lblElement);
                    //Add location of new Element
                    lblElement.Location = new Point(0, cls_Common.txtElementHeight);
                    //Update Complex Element in Main.panel_load
                    _Main.panelType.Controls.Add(uc_Ele);
                    //Add new Element parameter in Element
                    if (tempEle.Param == null ||tempEle.Param.ParamLists == null)
                    {
                        tempEle.Param = new ucParamLists();
                        tempEle.Param.ParamLists = new List<uc_Element>();
                    }
                    uc_Ele.Parentid = parentId;
                    var itmen = new uc_Element
                    {
                        ID = 1,
                        ParamName = uc_Ele.paramName,
                        dataType = uc_Ele.dataType,
                    };
                    tempEle.Param.ParamLists.Add(itmen);
                }
            }
            else if (uc_Ele.ID == 2)
            {
                var tempEle = ucLists.ElementResps.Where(i => i.parentid == parentId).FirstOrDefault();
                if (tempEle != null)
                {
                    //tempEle.ucSubLists.TypeId = (int)TypeEnum.Commplex;
                    if (tempEle.Param != null && tempEle.Param.ParamLists.Count > 0)
                    {
                        int count = tempEle.Param.ParamLists.Count;
                        //Update location of new Element parameter
                        cls_Common.txtElementHeight = (count * 20) + 70;
                        //Update param Count
                        cls_Common.paramCount++;
                    }
                    else
                    {
                        //Inilization location of new Element parameter
                        cls_Common.txtElementHeight = 70;
                        //Inilization param Count
                        cls_Common.paramCount = 1;
                    }
                    var lblElement = new Label
                    {
                        Text = "+  " +  cls_Common.paramCount + " : " + uc_Ele.ResponseDataType,
                        Width = 182,
                        Height = 20,
                    };
                    lblElement.Click += _Main.AddElementProperty_Click;
                    uc_Ele.Controls.Add(lblElement);
                    //Add location of new Element
                    lblElement.Location = new Point(0, cls_Common.txtElementHeight);
                    //Update Complex Element in Main.panel_load
                    _Main.panelType.Controls.Add(uc_Ele);
                    //Add new Element parameter in Element
                    if (tempEle.Param == null || tempEle.Param.ParamLists == null)
                    {
                        tempEle.Param = new ucParamLists();
                        tempEle.Param.ParamLists = new List<uc_Element>();
                    }
                    uc_Ele.Parentid = parentId;
                    var itmen = new uc_Element
                    {
                        ID = 2,
                        ParamName = uc_Ele.paramName,
                        dataType = uc_Ele.dataType,
                    };
                    tempEle.Param.ParamLists.Add(itmen);
                }
            }
        }

        private void lblElement_Click(object sender, System.EventArgs e)
        {

        }
    }
}
