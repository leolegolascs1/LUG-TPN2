using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Abstraccion;
using MPP;
using BE;

namespace Negocio_BLL
{
    public class BLL_ListaPrecioProveedores : IGestor<BE_Arandela>
    {
        BE_Arandela oBEArandela = new BE_Arandela();
        public bool Baja(BE_Arandela Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Guardar(BE_Arandela Objeto)
        {
            try
            {
                bool estado = true;
                XDocument xmlDoc = XDocument.Load("ListaPrecios.xml");

                xmlDoc.Element("Arandelas").Add(new XElement("Arandela",
                                               new XElement("medidas", Objeto.Medidas.ToString().Trim()),
                                               new XElement("natural", "$" + Objeto.Natural.ToString().Trim()),
                                               new XElement("zincado", "$" + Objeto.Zincado.ToString().Trim()),
                                               new XElement("CantxKilo", Objeto.CantxKilo.ToString().Trim()),
                                               new XElement("PrecioxKilo", "$" + Objeto.PrecioxKilo.ToString().Trim())));

                xmlDoc.Save("ListaPrecios.xml");
                return estado;
            }
            catch (Exception)  
            {
                return false; 
            }

        }
        public List<BE_Arandela> Buscar(string pBuscar)
        {
            var consulta =
                from Arandela in XElement.Load("ListaPrecios.xml").Elements("Arandela")
                where (string)Arandela.Element("medidas") == pBuscar.ToString().Trim()
                select new BE_Arandela
                {
                    Medidas = Arandela.Element("medidas").Value,
                    Natural = Arandela.Element("natural").Value,
                    Zincado = Arandela.Element("zincado").Value,
                    CantxKilo = int.Parse(Arandela.Element("CantxKilo").Value),
                    PrecioxKilo = Arandela.Element("PrecioxKilo").Value,
                };

            List<BE_Arandela> LstArandelas = consulta.ToList<BE_Arandela>();
            return LstArandelas;
        }
        public List<BE_Arandela> ListarTodo()
        {
                List<BE_Arandela> lstArandelas = new List<BE_Arandela>();
                XDocument xmlDoc = XDocument.Load("ListaPrecios.xml");

                var Consulta = from Arandela in xmlDoc.Descendants("Arandela")
                               select new
                               {
                                   medidas = Arandela.Element("medidas").Value,
                                   natural = Arandela.Element("natural").Value,
                                   zincado = Arandela.Element("zincado").Value,
                                   cantxkilo = Arandela.Element("CantxKilo").Value,
                                   precioxKilo = Arandela.Element("PrecioxKilo").Value,
                               };
                foreach (var a in Consulta)
                {
                    oBEArandela = new BE_Arandela();
                    oBEArandela.Medidas = a.medidas.ToString();
                    oBEArandela.Natural = a.natural.ToString();
                    oBEArandela.Zincado = a.zincado.ToString();
                    oBEArandela.CantxKilo = int.Parse(a.cantxkilo);
                    oBEArandela.PrecioxKilo = a.precioxKilo.ToString();
                    lstArandelas.Add(oBEArandela);
                }

            return lstArandelas;
        }
    }
}
