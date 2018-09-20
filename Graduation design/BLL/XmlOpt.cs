using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace BLL
{
    public class XmlOpt//皮肤
    {       
        XmlDocument xmlDoc = null;
        XmlNode resultNode = null;
        private string SystemSetXmlFile ;

        public XmlOpt()
        {
            xmlDoc = new XmlDocument();
            SystemSetXmlFile = Application.StartupPath + @"\data.xml";
            xmlDoc.Load(SystemSetXmlFile);
        }     

        public string GetNodeValue(string key)
        {
            XmlNode node = selectXmlElement(xmlDoc.SelectSingleNode("Data"), key);
            if (node == null) return string.Empty;
            return node.InnerText;
        }

        public void UpdateXMLValue(string key, string value)
        {
            //获取Employees节点的所有子节点
            //XmlNodeList nodeList = xmlDoc.SelectSingleNode("Data").ChildNodes;
            XmlNode node = selectXmlElement(xmlDoc.SelectSingleNode("Data"), key);
            if (node == null) return;
            node.InnerText = value;
            xmlDoc.Save(SystemSetXmlFile);//保存。
        }

        private XmlNode selectXmlElement(XmlNode xmlNode, string nodeName)
        {
            foreach (XmlNode node in xmlNode.ChildNodes)//遍历 
            {
                if (node.Name == nodeName)//如果找到 
                {
                    resultNode = node;
                }
                if (node.ChildNodes.Count > 0)
                {
                    resultNode = selectXmlElement(node, nodeName);
                }
            }
            return resultNode;
        }

    }
}
