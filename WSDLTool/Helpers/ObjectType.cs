using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSDLTool.Controls;

namespace WSDLTool.Helpers
{
    public class ObjectType
    {
        public string code;
        public string Create()
        {
            code += "<?xml version=\"1.0\" encoding=\"UTF-8\"?" + xsd.Close;
            code += " " + xsd.OpenType + xsd.Close;
            List<int> PID = ucLists.ElementReqs.Select(r => r.Parentid).ToList();
            foreach (int pid in PID)
            {
                var resEle = ucLists.ElementReqs.Where(res => res.Parentid == pid).FirstOrDefault();
                if(resEle != null)
                {
                    code += "  " + xsd.OpenElement + " name =" + resEle.Name1 + xsd.Close;
                    if (resEle.Param != null && resEle.Param.ParamLists.Count() > 0)
                    {
                        var items = resEle.Param.ParamLists;
                        code += "   " + xsd.OpenChildType + xsd.Close;
                        code += "    " + xsd.OpenSequence + xsd.Close;
                        foreach (var item in items)
                        {
                            code += "     " + xsd.Open + "element minOccurs=" + '"' + item.MinOcc + '"' + " maxOccurs=" + '"' + item.MinOcc + '"' + " name=" + '"' + item.ParamName + '"' + " type=s:" + '"' + item.DataType + '"' + " /" + xsd.Close;
                        }
                        code += "    " + xsd.EndSequence + xsd.Close;
                        code += "   " + xsd.OpenChildType + xsd.Close;
                    }
                    code += "  " + xsd.EndElement + xsd.Close;
                }               

                var repEle = ucLists.ElementResps.Where(res => res.Parentid == pid).FirstOrDefault();
                if (repEle != null)
                {
                    code += "  " + xsd.OpenElement + " name =" + repEle.Name1 + xsd.Close;
                    if (repEle.Param != null && repEle.Param.ParamLists.Count() > 0)
                    {
                        var items = repEle.Param.ParamLists;
                        code += "   " + xsd.OpenChildType + xsd.Close;
                        code += "    " + xsd.OpenSequence + xsd.Close;
                        foreach (var item in items)
                        {
                            code += "     " + xsd.Open + "element minOccurs=" + '"' + item.MinOcc + '"' + " maxOccurs=" + '"' + item.MinOcc + '"' + " name=" + '"' + item.ParamName + '"' + " type=s:" + '"' + item.DataType + '"' + " /" + xsd.Close;
                        }
                        code += "    " + xsd.EndSequence + xsd.Close;
                    }
                    code += "  " + xsd.EndElement + xsd.Close;
                }
            }
            code += " " + xsd.EndType + xsd.Close;
            return code;
        }

        public string CreateMessage()
        {
            string code = string.Empty;
            foreach (uc_Message uc_ in ucLists.Mesages)
            {
                code += xsd.OpenMessage + " name ="+ '"' + uc_.Name1 + '"' + xsd.Close;
                if(uc_.Part != null)
                {
                    code += "  " + xsd.OpenPart + " name =" + '"' + uc_.Part.ParameterName + '"' + " element =tns:" + '"' + uc_.Part.EleType + '"' + xsd.End;
                }
                code += xsd.EndMessage + xsd.Close;
            }
            return code;
        }
    }
}
