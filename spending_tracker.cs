using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class SpendingTracker
{


    static void CreateXmlFile()
    {

        XmlDocument xmlDoc = new XmlDocument();

        XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

        xmlDoc.AppendChild(xmlDeclaration);

        XmlElement rootElement = xmlDoc.CreateElement("Root");

        xmlDoc.AppendChild(rootElement);

       
        XmlElement dataElement1 = xmlDoc.CreateElement("Data");
        dataElement1.SetAttribute("ID", "1");
        dataElement1.InnerText = "Sample Data 1";

        XmlElement dataElement2 = xmlDoc.CreateElement("Data");
        dataElement2.SetAttribute("ID", "2");
        dataElement2.InnerText = "Sample Data 2";

        rootElement.AppendChild(dataElement1);
        rootElement.AppendChild(dataElement2);

     
        xmlDoc.Save("output.xml");

        Console.WriteLine("XML file created successfully.");
    }



    static void Main(string[] args)
    {
        CreateXmlFile();
    }
}

