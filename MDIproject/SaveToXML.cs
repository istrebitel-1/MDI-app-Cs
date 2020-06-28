using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MDIproject
{
    class SaveToXML
    {
        public static void TreeViewToXml(TreeView treeView, String path,XmlDocument xmlDocument)
        {
            xmlDocument.AppendChild(xmlDocument.CreateElement("Xml"));
            XmlRekursivExport(xmlDocument.DocumentElement, treeView.Nodes, xmlDocument);
            xmlDocument.Save(path);
        }

        public static XmlNode XmlRekursivExport(XmlNode nodeElement, TreeNodeCollection treeNodeCollection, XmlDocument xmlDocument)
        {
            XmlNode xmlNode = null; //Обнуление записи
            foreach (TreeNode treeNode in treeNodeCollection) //Для каждой записи в списке элементов дерева:
            {
                xmlNode = xmlDocument.CreateElement("TreeViewNode"); //Создаётся элемент TreeViewNode в файле
                xmlNode.Attributes.Append(xmlDocument.CreateAttribute("value")); //с атрибутом value
                xmlNode.Attributes["value"].Value = treeNode.Text; //в атрибут записывается

                if (nodeElement != null)  //если элемент не пустой
                    nodeElement.AppendChild(xmlNode); //Добавляет указанный узел в конец списка дочерних узлов данного узла.

                if (treeNode.Nodes.Count > 0) //Если есть дочерние элементы для текущего элемента
                {
                    XmlRekursivExport(xmlNode, treeNode.Nodes, xmlDocument); //Производится рекурсия
                }
            }
            return xmlNode;
        }
    }
}
