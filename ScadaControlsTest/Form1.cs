using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //silinebilir sadece deneme amaçlı 2 satır
            digitalSensorControl1.SensorName = "LS-101";
            digitalSensorControl1.Value = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            digitalSensorControl1.Value = !digitalSensorControl1.Value;
        }

        private void digitalSensorControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
