using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSDLTool.Helpers
{
    public class xsd
    {
        public static string OpenType
        {
            get { return "<wsdl:types"; }
            set { }
        }
        public static string EndType
        {
            get { return "</wsdl:types"; }
            set { }
        }
        public static string OpenMessage
        {
            get { return "<wsdl:message"; }
            set { }
        }

        public static string OpenPart
        {
            get { return "<wsdl:part"; }
            set { }
        }
        public static string EndMessage
        {
            get { return "</wsdl:message"; }
            set { }
        }
        public static string OpenElement
        {
            get { return "<s:element"; }
            set { }
        }
        public static string EndElement
        {
            get { return "</s:element>"; }
            set { }
        }
        public static string OpenChildType
        {
            get { return "<s:complexType"; }
            set { }
        }
        public static string EndChildType
        {
            get { return "</s:complexType"; }
            set { }
        }

        public static string OpenSequence
        {
            get { return "<s:sequence"; }
            set { }
        }
        public static string EndSequence
        {
            get { return "</s:sequence"; }
            set { }
        }
        public static string Open
        {
            get { return "<s:"; }
            set { }
        }
        public static string Close
        {
            get { return ">\n"; }
            set { }
        }
        public static string End
        {
            get { return " />\n"; }
            set { }
        }
        public static string name
        {
            get { return " name"; }
            set { }
        }
        public static string element
        {
            get { return "element"; }
            set { }
        }
        public static string minOccurs
        {
            get { return " minOccurs"; }
            set { }
        }

        public static string maxOccurs
        {
            get { return " maxOccurs"; }
            set { }
        }
    }
}
