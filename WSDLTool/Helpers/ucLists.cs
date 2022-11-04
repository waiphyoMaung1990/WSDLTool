using System.Collections.Generic;
using WSDLTool.Controls;

namespace WSDLTool.Helpers
{
    public class ucLists
    {
        public static List<uc_Element> ElementReqs { get; set; } = new List<uc_Element>();
        public static List<uc_Element> ElementResps { get; set; } = new List<uc_Element>();
        public static List<uc_Message> Mesages { get; set; } = new List<uc_Message>();
        public static List<uc_PortType> PortTypes { get; set; } = new List<uc_PortType>();
    }
}
