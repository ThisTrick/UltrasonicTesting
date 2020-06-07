using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UltrasonicTesting;
using UltrasonicTesting.Models;
using UltrasonicTestingForms.Controllers;

namespace UltrasonicTestingForms.Forms
{
    public partial class FormResult : Form
    {
        private UltrasonicThicknessGauge thicknessGauge;
        private Series series;
        private int index;
        private WaweController waweController;

        public FormResult()
        {
            InitializeComponent();
            ChartSetting();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ThicknessGaugeInit(new AppConfigController(), new XMLMaterialsController());
                index = 0;
                waweController = new WaweController(pictureWave, TestObjeckPanel, thicknessGauge.Chart.Length);
                ChartSetting();
                timerAction.Start();
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string nameMaterialPEC = configController.GetStrValue("materialPEC");
            Material materialPEC = materialsController.GetMaterial(nameMaterialPEC);

            double radiusPEC = configController.GetDoubleValue("radiusPEC");
            double amplitude = configController.GetDoubleValue("amplitude");
            double frequency = configController.GetDoubleValue("frequency");
            AcousticWave acousticWave = new AcousticWave(amplitude, frequency);
            RoundPEC roundPEC = new RoundPEC(radiusPEC, materialPEC, acousticWave);

            string namematerialTO = configController.GetStrValue("materialTO");
            Material materialTO = materialsController.GetMaterial(namematerialTO);

            double thicknessTO = configController.GetDoubleValue("thicknessTO");
            TestObject testObject = new TestObject(materialTO, thicknessTO);
            this.thicknessGauge = new UltrasonicThicknessGauge(roundPEC, testObject);
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
    }
}
