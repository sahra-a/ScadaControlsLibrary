using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScadaControlsLibrary.Communication;

namespace ValveControlsLibrary
{
    public partial class AnalogSensorControl : UserControl
    {

        #region Fields

        private float _value = 0;
        private string _sensorName = "Analog Sensor";
        private bool _sensorEnabled = true;
        private string _valueTag = string.Empty;
        private Timer refreshTimer = new Timer();
        private bool _autoRefresh = false;
        private int _refreshInterval = 500;

        #endregion

        [Category("Data")]
        [Description("Sensörün analog değerini gösterir.")]
        [DefaultValue(0f)]
        public float Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                RefreshSensor();
            }
        }

        [Category("Data")]
        [Description("Sensör adını belirtir.")]
        [DefaultValue("Analog Sensor")]
        public string SensorName
        {
            get
            {
                return _sensorName;
            }
            set
            {
                _sensorName = value;
                RefreshSensor();
            }
        }

        [Category("Behavior")]
        [Description("Sensörün aktif olup olmadığını belirler.")]
        [DefaultValue(true)]
        public bool SensorEnabled
        {
            get
            {
                return _sensorEnabled;
            }
            set
            {
                _sensorEnabled = value;
            }
        }

        [Category("PLC")]
        [Description("PLC REAL değişken adresi.")]   //Not: Analog sensör PLC'den REAL veri okuyacağı için açıklamada REAL yazıyoruz.
        [DefaultValue("")]
        public string ValueTag
        {
            get
            {
                return _valueTag;
            }
            set
            {
                _valueTag = value;
            }
        }

        [Category("PLC")]
        [Description("PLC'den otomatik veri okunmasını sağlar.")]
        [DefaultValue(false)]
        public bool AutoRefresh
        {
            get
            {
                return _autoRefresh;
            }
            set
            {
                _autoRefresh = value;

                if (_autoRefresh)
                    refreshTimer.Start();
                else
                    refreshTimer.Stop();
            }
        }

        [Category("PLC")]
        [Description("PLC veri okuma aralığı (ms).")]
        [DefaultValue(500)]
        public int RefreshInterval
        {
            get
            {
                return _refreshInterval;
            }
            set
            {
                _refreshInterval = value;
                refreshTimer.Interval = value;
            }
        }

        public AnalogSensorControl()
        {
            InitializeComponent();

            // Timer ayarları
            refreshTimer.Interval = RefreshInterval;
            refreshTimer.Tick += RefreshTimer_Tick;

            RefreshSensor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSensorName_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Analog sensörün mevcut değerine göre arayüzü günceller.
        /// </summary>
        private void RefreshSensor()
        {
            lblSensorName.Text = SensorName;
            lblValue.Text = Value.ToString("0.0");
        }

        /// <summary>
        /// PLC'den AnalogSensorControl'e ait değeri okur.
        /// </summary>
        private void ReadPlcValues()
        {
            if (!PlcClient.IsConnected)
                return;

            if (string.IsNullOrWhiteSpace(ValueTag))
                return;

            Value = PlcClient.ReadFloat(ValueTag);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReadPlcValues();
        }

    }
}
