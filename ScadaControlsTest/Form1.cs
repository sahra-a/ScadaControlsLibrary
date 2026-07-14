using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValveControlsLibrary;

namespace ScadaControlsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //silinebilir sadece deneme amaçlı 4 satır
            digitalSensorControl1.SensorName = "LS-101";
            digitalSensorControl1.Value = true;
            analogSensorControl1.SensorName = "PT-101";
            analogSensorControl1.Value = 12.5f;
            counterControl1.CounterName = "Water Meter";
            counterControl1.Count = 123;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            digitalSensorControl1.Value = !digitalSensorControl1.Value;
        }

        private void digitalSensorControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            analogSensorControl1.Value = 78.4f;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counterControl1.Count = 987654;
        }
    }
}
