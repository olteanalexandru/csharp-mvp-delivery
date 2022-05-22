using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Curierat.Model.Persistenta
{
    public class ColetPersistent
    {
        public bool AdaugareColet(Colet med)
        {
            try
            {
                XElement xElement = XElement.Load(@"colete.xml");
                xElement.Add(new XElement("colet",
                    new XElement("cod_colet", med.AccesCodColet().ToString()),
                    new XElement("locatie", med.AccesLocatie()),
                    new XElement("livrator", med.AccesLivrator()),
                    new XElement("traseuoptim", med.AccesTraseuoptim())
                    ));
                xElement.Save(@"colete.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare colet! " + ex.ToString());
                return false;
            }
        }
        public bool StergereColet(int cod_colet)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"colete.xml");
                xDoc.Root.Elements("colet").Where(e => e.Element("cod_colet").Value == cod_colet.ToString()).Remove();
                xDoc.Save(@"colete.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere colet! " + ex.ToString());
                return false;
            }
        }
        public bool ActualizareColet(int cod_colet, Colet med)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"colete.xml");
                var element = xDoc.Root.Elements("colet").Where(e => e.Element("cod_colet").Value == cod_colet.ToString()).Single();
                element.Element("cod_colet").Value = med.AccesCodColet().ToString();
                if (med.AccesLocatie() != "") element.Element("locatie").Value = med.AccesLocatie();
                if (med.AccesLivrator() != "") element.Element("livrator").Value = med.AccesLivrator();
                xDoc.Save(@"colete.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizare colet! " + ex.ToString());
                return false;
            }
        }
        public Colet CautareColet(int cod_colet)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"colete.xml");
                List<XElement> lista = xDoc.Root.Elements("colet").ToList();
                foreach (XElement xElem in lista)
                {
                    int cm = (int)Convert.ToUInt32(xElem.Element("cod_colet").Value);
                    if (cm == cod_colet)
                    {
                        string locatie = xElem.Element("locatie").Value;
                        string livrator = xElem.Element("livrator").Value;
                        string traseuoptim = xElem.Element("traseuoptim").Value;
                        Colet p = new Colet(cod_colet, locatie, livrator,traseuoptim);
                        return p;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la cautare colet! " + ex.ToString());
                return null;
            }
        }
        public List<Colet> ListaColete()
        {
            try
            {
                List<Colet> listaColete = new List<Colet>();
                XDocument xDoc = XDocument.Load(@"colete.xml");
                List<XElement> listaXML = xDoc.Root.Elements("colet").ToList();
                foreach (XElement xElem in listaXML)
                {
                    string locatie = xElem.Element("locatie").Value;
                    int cod_colet = Convert.ToInt32(xElem.Element("cod_colet").Value);
                    string livrator = xElem.Element("livrator").Value;
                    string traseuoptim = xElem.Element("traseuoptim").Value;
                    Colet m = new Colet(cod_colet, locatie, livrator,traseuoptim);
                    listaColete.Add(m);
                }
                return listaColete;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire colete! " + ex.ToString());
                return null;
            }
        }

       


        public List<Colet> CautareColeteLocatie(string txtCautare)
        {
            try
            {
                List<Colet> listaColete = new List<Colet>();
                XDocument xDoc = XDocument.Load(@"colete.xml");
                List<XElement> listaXML = xDoc.Root.Elements("colet").ToList();
                foreach (XElement xElem in listaXML)
                {

                    string denum = xElem.Element("cod_colet").Value;
                    if (denum == txtCautare)
                    {
                        string locatie = xElem.Element("locatie").Value;
                        int cod_colet = Convert.ToInt32(xElem.Element("cod_colet").Value);
                        string livrator = xElem.Element("livrator").Value;
                        string traseuoptim = xElem.Element("traseuoptim").Value;
                        Colet m = new Colet(cod_colet, locatie, livrator,traseuoptim);
                        listaColete.Add(m);
                    }
                }
                return listaColete;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la filtrare colete! " + ex.ToString());
                return null;
            }
        }
    }
}
