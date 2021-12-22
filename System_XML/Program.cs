using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace System_XML
{
    class Program
    {
        static void Main(string[] args)
        {


            #region

            XmlReader reader = XmlReader.Create(@"C:\XML\personellerim.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.MoveToFirstAttribute())
                    {
                        Console.WriteLine("ID : " + reader.Value.ToString());
                    }
                    //return only when you have START 
                    switch (reader.Name.ToString())
                    {
                        case "isim":
                            Console.WriteLine("İsim : " + reader.ReadString());
                            break;
                        case "soyisim":
                            Console.WriteLine("Soyisim : " + reader.ReadString());
                            break;
                        case "EmailAdres":
                            Console.WriteLine("EmailAdres : " + reader.ReadString());
                            Console.WriteLine("");
                            break;
                    }
                }
            }

            Console.ReadKey();

            #endregion


           // XmlTextWriter xmlText = new XmlTextWriter(@"C:\XML\personellerim.xml",System.Text.UTF8Encoding.UTF8);
           ////<!---yorumlar--->
           // xmlText.WriteComment("Yorumlar burayayazılır");
           // //root olusturma
           // xmlText.WriteStartElement("personellerim");
           // //child olusturma
           // xmlText.WriteStartElement("personeller");
           // //subchild
           // xmlText.WriteAttributeString("ID", "1");
           // xmlText.WriteElementString("isim", "Ahmet");
           // xmlText.WriteElementString("soyisim", "Ahmet");
           // xmlText.WriteElementString("EmailAdres", "Ahmetkoc@gmail.com");
           // //Kapatma komutu
           // xmlText.WriteEndElement();

           // //---
           // xmlText.WriteStartElement("personeller");
           // //subchild
           // xmlText.WriteAttributeString("ID", "2");
           // xmlText.WriteElementString("isim", "Ahmet");
           // xmlText.WriteElementString("soyisim", "dede");
           // xmlText.WriteElementString("EmailAdres", "ahmetdede@gmail.com");
           // //Kapatma komutu
           // xmlText.WriteEndElement();

           // xmlText.WriteEndElement();
           // xmlText.Close();



        }
    }
}
