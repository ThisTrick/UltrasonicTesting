using System.Configuration;

namespace UltrasonicTesting.Controllers
{
    public class AppConfigController
    {
        private Configuration Configuration;
        public AppConfigController()
        {
            Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        /// <summary>
        /// Метод возвращающий double по ключу из файла конфигурации. 
        /// </summary>
        /// <param name="key">Ключ к значению в файле конфигурации.</param>
        /// <returns></returns>
        public double GetDoubleValue(string key)
        {
            double.TryParse(Configuration.AppSettings.Settings[key].Value, out double value);
            return value;
        }
        /// <summary>
        ///  Метод возвращающий string по ключу из файла конфигурации. 
        /// </summary>
        /// <param name="key">Ключ к значению в файле конфигурации.</param>
        /// <returns></returns>
        public string GetStrValue(string key)
        {
            return Configuration.AppSettings.Settings[key].Value;
        }
        /// <summary>
        /// Запись value для ключа в файле конфигурации.
        /// </summary>
        /// <param name="key">Ключ к значению в файле конфигурации.</param>
        /// <param name="value">Записываемое значение.</param>
        public void SetValue(string key, string value)
        {
            Configuration.AppSettings.Settings[key].Value = value;
            Configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
