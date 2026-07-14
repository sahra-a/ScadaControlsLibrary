using ScadaControlsLibrary.Communication;
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
    public partial class CounterControl : UserControl
    {
        #region Fields

        private int _count = 0;
        private string _counterName = "Counter";
        private bool _counterEnabled = true;

        // PLC
        private string _countTag = "";

        // Auto Refresh
        private Timer refreshTimer = new Timer();
        private bool _autoRefresh = false;
        private int _refreshInterval = 500;

        #endregion

        #region Properties

        [Category("Data")]
        [Description("Sayacın mevcut değerini gösterir.")]
        [DefaultValue(0)]
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                RefreshCounter();
            }
        }

        [Category("Data")]
        [Description("Sayacın adını belirtir.")]
        [DefaultValue("Counter")]
        public string CounterName
        {
            get
            {
                return _counterName;
            }
            set
            {
                _counterName = value;
                RefreshCounter();
            }
        }

        [Category("Behavior")]
        [Description("Sayacın aktif olup olmadığını belirler.")]
        [DefaultValue(true)]
        public bool CounterEnabled
        {
            get
            {
                return _counterEnabled;
            }
            set
            {
                _counterEnabled = value;
            }
        }


        [Category("PLC")]
        [Description("PLC Counter değişken adresi.")]
        [DefaultValue("")]
        public string CountTag
        {
            get
            {
                return _countTag;
            }
            set
            {
                _countTag = value;
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

        public CounterControl()
        {
            InitializeComponent();

            // Timer ayarları
            refreshTimer.Interval = RefreshInterval;
            refreshTimer.Tick += RefreshTimer_Tick;

            RefreshCounter();
        }

        /// <summary>
        /// Sayaç ekranını günceller.
        /// </summary>
        private void RefreshCounter()
        {
            lblCounterName.Text = CounterName;
            lblCounterValue.Text = Count.ToString("D6");
        }


        /// <summary>
        /// PLC'den CounterControl'e ait değeri okur.
        /// </summary>
        private void ReadPlcValues()
        {
            if (!PlcClient.IsConnected)
                return;

            if (string.IsNullOrWhiteSpace(CountTag))
                return;

            Count = PlcClient.ReadInt(CountTag);
        }









        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReadPlcValues();
        }

        private void lblCounterValue_Click(object sender, EventArgs e)
        {

        }

        private void lblCounterName_Click(object sender, EventArgs e)
        {

        }

        private void lblCounterValue_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureCounter_Click(object sender, EventArgs e)
        {

        }

       
    }
}