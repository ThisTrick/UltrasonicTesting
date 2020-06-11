using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UltrasonicTesting;
using UltrasonicTesting.Attenuation;
using UltrasonicTesting.Controllers;
using UltrasonicTesting.Models;
using UltrasonicTestingForms.Controllers;
using UltrasonicTestingForms.Properties;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormResult : Form
    {
        private UltrasonicThicknessGauge thicknessGauge;
        private Series series;
        private int index;
        private WaweController waweController;
        private string  templatePath;
        private MSWordController wordController;
        private Bitmap img;
        public FormResult()
        {
            InitializeComponent();
            Chart.Series.Clear();
            var path = "MaterialsBD.xml";
            try
            {
                ThicknessGaugeInit(new AppConfigController(), new XMLMaterialsController(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            index = 0;
            ChartSetting();
            waweController = new WaweController(pictureWave, TestObjeckPanel, thicknessGauge.Chart.Length);
            timerAction.Start();
        }
        private void ChartSetting()
        {
            Chart.Series.Clear();
            Chart.ChartAreas[0].AxisX.Interval = 5;
            this.series = this.Chart.Series.Add("Result");
            series.IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Spline;
        }
        private void ThicknessGaugeInit(AppConfigController configController, XMLMaterialsController materialsController)
        {
            var nameMaterialPEC = configController.GetStrValue("materialPEC");
            Material materialPEC = materialsController.GetMaterial(nameMaterialPEC);

            double radiusPEC = configController.GetDoubleValue("radiusPEC");
            double amplitude = configController.GetDoubleValue("amplitude");
            double frequency = configController.GetDoubleValue("frequency");
            AcousticWave acousticWave = new AcousticWave(amplitude, frequency);
            RoundPEC roundPEC = new RoundPEC(radiusPEC, materialPEC, acousticWave);

            var nameMaterialTO = configController.GetStrValue("materialTO");
            Material materialTO = materialsController.GetMaterial(nameMaterialTO);

            double thicknessTO = configController.GetDoubleValue("thicknessTO");
            TestObject testObject = new TestObject(materialTO, thicknessTO);
            this.thicknessGauge = new UltrasonicThicknessGauge(roundPEC, testObject);

            if (this.thicknessGauge.IsFresnelZone)
            {
                templatePath = @"Templates\ThicknessGaugeFresnel.docx";
            }
            else
            {
                templatePath = @"Templates\ThicknessGaugeFraunhofer.docx";
            }

            this.thicknessGauge.StartTesting();
        }
        private void timerAction_Tick(object sender, EventArgs e)
        {
            if (thicknessGauge.Chart.Length > index)
            {
                series.Points.Add(thicknessGauge.Chart[index]);
            }
            else
            {
                series.Points.Add(0, 0, 0, 0, 0, 0, 0);
                pictureWave.Visible = false;
                timerAction.Stop();
                return;
            }
            index++;
            waweController.Move();
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (thicknessGauge is null)
            {
                MessageBox.Show("Запустите моделирование");
                return;
            }
            if (timerAction.Enabled)
            {
                MessageBox.Show("Дождитесь окончания моделирования");
                return;
            }
            try
            {
                using (wordController = new MSWordController(templatePath))
                {
                    var _converter = thicknessGauge.Converter as RoundPEC;
                    var _acousticWave = _converter.AcousticWave;
                    var _testObject = thicknessGauge.TestObject;
                    var _wavelength = _acousticWave.CalcWavelength(_testObject.Material).ToString();
                    var _attenuation = thicknessGauge.Attenuation;

                    WriteValuesToDocx(_converter, _acousticWave, _testObject, _wavelength, _attenuation);

                    WriteImgToDocx();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Отчет сохранен");
        }

        private void WriteImgToDocx()
        {
            ScreenshotController screenshotController = new ScreenshotController();
            img = screenshotController.GetControlScreenshot(this.ContentPanel);
            wordController.AddImage(img);
            wordController.DocxSave();
        }

        private void WriteValuesToDocx(RoundPEC _converter, AcousticWave _acousticWave, TestObject _testObject, string _wavelength, AcousticAttenuation _attenuation)
        {
            wordController.Replace(Resources.RadiusPEC, _converter.Radius.ToString());
            wordController.Replace(Resources.WaveAmplitude, _acousticWave.Amplitude.ToString());
            wordController.Replace(Resources.Frequency, _acousticWave.Frequency.ToString());
            wordController.Replace(Resources.ThicknessTO, _testObject.Thickness.ToString());
            wordController.Replace(Resources.MaterialPEC, _converter.Material.Name);
            wordController.Replace(Resources.SpeedOfSoundPEC, _converter.Material.SpeedOfSound.ToString());
            wordController.Replace(Resources.DensityPEC, _converter.Material.Density.ToString());
            wordController.Replace(Resources.AcousticImpedancePEC, _converter.Material.AcousticImpedance.ToString());
            wordController.Replace(Resources.MaterialTO, _testObject.Material.Name);
            wordController.Replace(Resources.SpeedOfSoundTO, _testObject.Material.SpeedOfSound.ToString());
            wordController.Replace(Resources.DensityTO, _testObject.Material.Density.ToString());
            wordController.Replace(Resources.FsplTO, _testObject.Material.FSPL.ToString());
            wordController.Replace(Resources.AcousticImpedanceTO, _testObject.Material.AcousticImpedance.ToString());
            wordController.Replace(Resources.Wavelength, _wavelength);
            wordController.Replace(Resources.FresnelDistance, _converter.FresnelDistance.ToString());
            wordController.Replace(Resources.FraunhoferDistance, _converter.FraunhoferDistance.ToString());
            wordController.Replace(Resources.AreaPEC, _converter.Area.ToString());
            wordController.Replace(Resources.IntensityTransmittance, _attenuation.IntensityTransmittance.ToString());
            wordController.Replace(Resources.AcousticAttenuation, _attenuation.Сalculate().ToString());
            wordController.Replace(Resources.InAmplitude, thicknessGauge.ResponseAmplitude.ToString());
        }
    }
}
