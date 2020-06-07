using System;
using System.Xml.Linq;
using UltrasonicTesting.Models;
using System.Linq;
using System.Collections.Generic;

namespace UltrasonicTestingForms.Controllers
{
    public class XMLMaterialsController
    {
        private const string Path = "MaterialsBD.xml";
        private XDocument XMLDocument;
        private XElement Root;
        public XMLMaterialsController()
        {
            XMLDocument = XDocument.Load(Path);
            Root = XMLDocument.Root;
        }
        /// <summary>
        /// Записывает акустические характеристики материала в XML базу данных.
        /// </summary>
        /// <param name="material">Материал</param>
        /// <param name="name">Название материала</param>
        public void SetMaterial(Material material, string name)
        {
            if (material is null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Не может быть пустым", nameof(name));
            }

            XAttribute nameAttribute = new XAttribute("Name", name);
            XElement speedElement = new XElement("SpeedOfSound", material.SpeedOfSound);
            XElement densityElement = new XElement("Density", material.Density);
            XElement FSPLElement = new XElement("FSPL", material.FSPL);
            XElement materialElement = new XElement("Material", nameAttribute, speedElement, densityElement, FSPLElement);
            Root.Add(materialElement);
            XMLDocument.Save(Path);
        }
        /// <summary>
        /// Достает из XML базы данных акустические характеристики материала.
        /// </summary>
        /// <param name="name">Название материала</param>
        /// <returns></returns>
        public Material GetMaterial(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Не может быть пустым", nameof(name));
            }
            var element = Root.Elements().Where(e => e.Attribute("Name").Value == name).First();
            if(element is null)
            {
                throw new ArgumentException($"Материала под именем [{name}] нет.");
            }
            var strSpeedOfSound = element.Element("SpeedOfSound").Value;
            var strDensity = element.Element("Density").Value;
            var strFSPL = element.Element("FSPL").Value;

            double.TryParse(strSpeedOfSound, out double speedOfSound);
            double.TryParse(strDensity, out double density);
            double.TryParse(strFSPL, out double fspl);
            return new Material(speedOfSound, density, fspl);
        }
        public object[] GetNameMaterials()
        {
            return Root.Elements().Select(e => e.Attribute("Name").Value).ToArray<object>();
        }
    }
}
