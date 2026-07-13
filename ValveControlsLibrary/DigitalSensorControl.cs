using ScadaControlsLibrary;
using ScadaControlsLibrary.Communication;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ValveControlsLibrary
{
    public partial class DigitalSensorControl : UserControl
    {
        #region Fields

        private bool _value = false;
        private string _sensorName = "Digital Sensor";
        private bool _sensorEnabled = true;
        private string _valueTag = string.Empty;
        private Timer refreshTimer = new Timer();
        private bool _autoRefresh = false;
        private int _refreshInterval = 500;


        #endregion

        public DigitalSensorControl()
        {
            InitializeComponent();
            // Timer ayarları
            refreshTimer.Interval = RefreshInterval;
            refreshTimer.Tick += RefreshTimer_Tick;

            RefreshSensor();
        }

        #region Properties

        [Category("Data")]
        [Description("Sensörün dijital değeri.")]
        [DefaultValue(false)]
        public bool Value
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
        [DefaultValue("Digital Sensor")]
        public string SensorName
        {
            get
            {
                return _sensorName;
            }
            set
            {
                _sensorName = value;
            }
        }

        [Category("Behavior")]
        [Description("Sensörün aktif olup olmadığını belirtir.")]
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
        [Description("PLC BOOL değişken adresi.")]
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

        #endregion






        #region Methods

        /// <summary>
        /// Sensörün mevcut değerine göre görselini günceller.
        /// </summary>
        private void RefreshSensor()
        {
            if (_value)
            {
                pictureSensor.Image = Resources.DigitalSensor_On;

                lblStatus.Text = "ON";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                pictureSensor.Image = Resources.DigitalSensor_Off;

                lblStatus.Text = "OFF";
                lblStatus.ForeColor = Color.Red;
            }

            lblSensorName.Text = SensorName;
        }

        /// <summary>
        /// PLC'den DigitalSensorControl'e ait değeri okur.
        /// </summary>
        private void ReadPlcValues()
        {
            if (!PlcClient.IsConnected)
                return;

            if (string.IsNullOrWhiteSpace(ValueTag))
                return;

            Value = PlcClient.ReadBool(ValueTag);
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReadPlcValues();
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSensorName_Click(object sender, EventArgs e)
        {

        }
    }
}