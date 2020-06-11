using System;
using System.Linq;
using System.Xml.Linq;
using UltrasonicTesting.Models;

namespace UltrasonicTesting.Controllers
{
    /// <summary>
    /// Класс для управления XML базой данных характеристик материалов.
    /// </summary>
    public class XMLMaterialsController
    {
        private readonly string Path;
        private XDocument XMLDocument;
        private XElement RootElement;
        public XMLMaterialsController(string path)
        {
            Path = path;
            XMLDocument = XDocument.Load(Path);
            RootElement = XMLDocument.Root;
        }
        /// <summary>
        /// Записывает акустические характеристики материала в XML базу данных.
        /// </summary>
        /// <param name="material">Материал</param>
        /// <param name="name">Название материала</param>
        public void SetMaterial(Material material)
        {
            if (material is null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            XAttribute nameAttribute = new XAttribute("Name", material.Name);
            XElement speedElement = new XElement("SpeedOfSound", material.SpeedOfSound);
            XElement densityElement = new XElement("Density", material.Density);
            XElement FSPLElement = new XElement("FSPL", material.FSPL);
            XElement materialElement = new XElement("Material", nameAttribute, speedElement, densityElement, FSPLElement);
            RootElement.Add(materialElement);
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
            var element = RootElement.Elements().Where(e => e.Attribute("Name").Value == name).First();
            if (element is null)
            {
                throw new ArgumentException($"Материала под именем [{name}] нет.");
            }
            var strSpeedOfSound = element.Element("SpeedOfSound").Value;
            var strDensity = element.Element("Density").Value;
            var strFSPL = element.Element("FSPL").Value;

            double.TryParse(strSpeedOfSound, out double speedOfSound);
            double.TryParse(strDensity, out double density);
            double.TryParse(strFSPL, out double fspl);
            return new Material(name, speedOfSound, density, fspl);
        }
        /// <summary>
        /// Извлекает все названия материалов из XML файла.
        /// </summary>
        /// <returns>Названия материалов.</returns>
        public object[] GetNameMaterials()
        {
            return RootElement.Elements().Select(e => e.Attribute("Name").Value).ToArray<object>();
        }
    }
}
