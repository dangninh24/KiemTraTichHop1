using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai_3
{
    class DataUtil
    {
        string path = "C:\\LapTrinh\\TichHopHeThong\\Bai-3\\Bai-3\\Test.xml";
        XmlDocument xmlDocument;
        XmlElement xmlElement;

        public DataUtil()
        {
            xmlDocument = new XmlDocument();
            XmlElement thuvien = xmlDocument.CreateElement("thuvien");
            xmlDocument.AppendChild(thuvien);
            xmlDocument.Save(path);
            
            xmlElement = xmlDocument.DocumentElement;

        }

        public bool AddXml(CuonSach cuonSach)
        {

            XmlNode xmlNode = xmlElement.SelectSingleNode("cuonsach[@masach ='" + cuonSach.ID + "']");
            if(xmlNode != null)
            {
                return false;
            }

            // Tạo các thẻ            
            XmlElement cuonsach = xmlDocument.CreateElement("cuonsach");
            XmlElement tensach = xmlDocument.CreateElement("tensach");
            XmlElement sotrang = xmlDocument.CreateElement("sotrang");
            XmlElement tacgia = xmlDocument.CreateElement("tacgia");
            XmlElement giatien = xmlDocument.CreateElement("giatien");

            // Tạo nội dung trong thẻ
            XmlText texttensach = xmlDocument.CreateTextNode(cuonSach.TenSach);
            XmlText textsotrang = xmlDocument.CreateTextNode(cuonSach.SoTrang.ToString());
            XmlText texthoten = xmlDocument.CreateTextNode(cuonSach.TacGia);            
            XmlText textgiatien = xmlDocument.CreateTextNode(cuonSach.GiaTien.ToString());

            // thêm thuộc tính trong thẻ
            cuonsach.SetAttribute("masach", cuonSach.ID.ToString());            

            // tạo các thẻ lồng vào nhau           

            xmlElement.AppendChild(cuonsach);
            cuonsach.AppendChild(tensach);
            cuonsach.AppendChild(sotrang);
            cuonsach.AppendChild(tacgia);
            cuonsach.AppendChild(giatien);

            tensach.AppendChild(texttensach);
            sotrang.AppendChild(textsotrang);
            tacgia.AppendChild(texthoten);
            giatien.AppendChild(textgiatien); 

            xmlDocument.Save(path);

            return true;
        }

        public List<CuonSach> getListCuonSach()
        {
            XmlNodeList nodes = xmlElement.SelectNodes("cuonsach");
            List<CuonSach> list = new List<CuonSach>();
            foreach (XmlNode item in nodes)
            {
                // Lấy thuộc tính thứ nhất của thẻ
                //item.Attributes[0].InnerText;
                int id = int.Parse(item.Attributes[0].InnerText);
                string tensach = item.SelectSingleNode("tensach").InnerText;
                string tacgia = item.SelectSingleNode("tacgia").InnerText;
                int sotrang = int.Parse(item.SelectSingleNode("sotrang").InnerText);
                float giatien = float.Parse(item.SelectSingleNode("giatien").InnerText);
                CuonSach cuonsach = new CuonSach(id, tensach, sotrang, tacgia, giatien);
                list.Add(cuonsach);
            }

            return list;
        }

        public bool EditXml(CuonSach sach)
        {
            XmlNode xmlNode = xmlElement.SelectSingleNode("cuonsach[@masach ='" + sach.ID + "']");

            if(xmlNode != null)
            {
                // Tạo các thẻ            
                XmlElement cuonsach = xmlDocument.CreateElement("cuonsach");
                XmlElement tensach = xmlDocument.CreateElement("tensach");
                XmlElement sotrang = xmlDocument.CreateElement("sotrang");
                XmlElement tacgia = xmlDocument.CreateElement("tacgia");
                XmlElement giatien = xmlDocument.CreateElement("giatien");

                // Tạo nội dung trong thẻ
                XmlText texttensach = xmlDocument.CreateTextNode(sach.TenSach);
                XmlText textsotrang = xmlDocument.CreateTextNode(sach.SoTrang.ToString());
                XmlText texthoten = xmlDocument.CreateTextNode(sach.TacGia);
                XmlText textgiatien = xmlDocument.CreateTextNode(sach.GiaTien.ToString());

                // thêm thuộc tính trong thẻ
                cuonsach.SetAttribute("masach", sach.ID.ToString());

                // tạo các thẻ lồng vào nhau           

                xmlElement.ReplaceChild(cuonsach, xmlNode);
                cuonsach.AppendChild(tensach);
                cuonsach.AppendChild(sotrang);
                cuonsach.AppendChild(tacgia);
                cuonsach.AppendChild(giatien);

                tensach.AppendChild(texttensach);
                sotrang.AppendChild(textsotrang);
                tacgia.AppendChild(texthoten);
                giatien.AppendChild(textgiatien);
                
                xmlDocument.Save(path);

                return true;
            }

            return false;
        }

        public bool DeleteXml(string id)
        {
            XmlNode xmlNode = xmlElement.SelectSingleNode("cuonsach[@masach ='" + id + "']");

            if (xmlNode != null)
            {
                xmlElement.RemoveChild(xmlNode);
                xmlDocument.Save(path);

                return true;
            }

            return false;
        }

        public CuonSach SearchXml(string _id)
        {
            XmlNode xmlNode = xmlElement.SelectSingleNode("cuonsach[@masach ='" + _id + "']");
            CuonSach cuonSach = null;

            if(xmlNode != null)
            {
                int id = int.Parse(xmlNode.Attributes[0].InnerText);
                string tensach = xmlNode.SelectSingleNode("tensach").InnerText;
                string tacgia = xmlNode.SelectSingleNode("tacgia").InnerText;
                int sotrang = int.Parse(xmlNode.SelectSingleNode("sotrang").InnerText);
                float giatien = float.Parse(xmlNode.SelectSingleNode("giatien").InnerText);
                cuonSach = new CuonSach(id, tensach, sotrang, tacgia, giatien);                
            }

            return cuonSach;
        }
    }
}
