using System.Configuration;

namespace UltrasonicTestingForms.Controllers
{
    public class AppConfigController
    {
        private Configuration Configuration;
        public AppConfigController()
        {
            Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public double GetValue(string key)
        {
            double.TryParse(Configuration.AppSettings.Settings[key].Value, out double value);
            return value;
        }
        public void SetValue(string key, string value)
        {
            Configuration.AppSettings.Settings[key].Value = value;
            Configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
