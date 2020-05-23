using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UltrasonicTesting;
using UltrasonicTestingForms.Controllers;

namespace UltrasonicTestingForms
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
            ThicknessGaugeInit(new AppConfigController());
            ChartSetting();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            index = 0;
            waweController = new WaweController(pictureWave, ModelPanel, thicknessGauge.Chart.Length);
            timerAction.Start();
            ChartSetting();
        }
        private void ChartSetting()
        {
            Chart.Series.Clear();
            Chart.ChartAreas[0].AxisX.Interval = 2;
            this.series = this.Chart.Series.Add("Result");
            series.IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Spline;
        }
        private void ThicknessGaugeInit(AppConfigController configController)
        {
            double speedOfSoundPEC = configController.GetValue("speedOfSoundPEC");
            double desityPEC = configController.GetValue("desityPEC");
            double fsplPEC = configController.GetValue("fsplPEC");
            Material materialPEC = new Material(speedOfSoundPEC, desityPEC, fsplPEC);
            double radiusPEC = configController.GetValue("radiusPEC");
            double amplitude = configController.GetValue("amplitude");
            double frequency = configController.GetValue("frequency");
            AcousticWave acousticWave = new AcousticWave(amplitude, frequency);
            RoundPEC roundPEC = new RoundPEC(radiusPEC, materialPEC, acousticWave);
            double speedOfSoundTO = configController.GetValue("speedOfSoundTO");
            double desityTO = configController.GetValue("desityTO");
            double fsplTO = configController.GetValue("fsplTO");
            Material materialTO = new Material(speedOfSoundTO, desityTO, fsplTO);
            double thicknessTO = configController.GetValue("thicknessTO");
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
            if (index <= thicknessGauge.Chart.Length + 9)
            {
                series.Points.Add(0);
            }
            else
            {
                timerAction.Stop();
                return;
            }
            index++;
            waweController.Move();
        }
    }
}
