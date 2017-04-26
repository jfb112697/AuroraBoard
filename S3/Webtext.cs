using System.Xml;
using System.IO;
using System.Net;
using System.Text;

namespace S3
{
    public class Webtext
    {
        public Webtext()
        {
            XmlDocument FromHtml(TextReader reader)
            {
                // ' setup SgmlReader   
                Sgml.SgmlReader sgmlReader = new Sgml.SgmlReader();
                sgmlReader.DocType = "HTML";
                sgmlReader.WhitespaceHandling = WhitespaceHandling.None;
                sgmlReader.CaseFolding = Sgml.CaseFolding.ToLower;
                sgmlReader.InputStream = reader;
                // ' create document 
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.XmlResolver = null;
                doc.Load(sgmlReader);
                return doc;
            }

            string LoadWebText(string URL)
            {
                WebClient objWebClient = new WebClient();
                UTF8Encoding objUTF8 = new UTF8Encoding();
                XmlDocument xml = new XmlDocument();
                xml = FromHtml(new StringReader(objUTF8.GetString(objWebClient.DownloadData(URL))));
                return xml.InnerText();
            }
        }
    }
}