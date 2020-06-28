using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MDIproject
{
    class OpenFromXML
    {
        public static void XmlToTreeView(String path, TreeView treeView, XmlDocument xmlDocument)
        {
            xmlDocument.Load(path);
            treeView.Nodes.Clear();
            XmlRekursivImport(treeView.Nodes, xmlDocument.DocumentElement.ChildNodes);

        }

        public static void XmlRekursivImport(TreeNodeCollection elem, XmlNodeList xmlNodeList)
        {
           
            TreeNode treeNode; //Объявление ветки дерева
            foreach (XmlNode myXmlNode in xmlNodeList) //Для каждой записи XmlNode в списке XML элементов:
            {
                XmlNode parent = myXmlNode; //Объявление элемента-родителя
                if ( parent.Attributes["value"] != null) //Если атрибут существует
                {
                    treeNode = new TreeNode(myXmlNode.Attributes["value"].Value); //В созданную ветку дерева записывается значение атрибута

                    if (myXmlNode.ChildNodes.Count > 0) //Если есть дочерние элементы для текущего элемента
                    {
                        XmlRekursivImport(treeNode.Nodes, myXmlNode.ChildNodes); //Производится рекурсия
                    }
                    elem.Add(treeNode); //Добавление элемента
                }
                else 
                {
                MessageBox.Show("Данный файл является некорректным.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
            }
            
        }


    }
}

