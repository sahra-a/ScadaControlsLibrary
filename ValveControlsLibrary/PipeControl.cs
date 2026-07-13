using ScadaControlsLibrary.Communication;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ValveControlsLibrary;

namespace ScadaControlsLibrary
{
    public partial class PipeControl : UserControl
    {
        private bool _isOpen = false;
        private bool _pipeEnabled = true;
        private string _pipeName = "Pipe";
        private double _temperature = 0;
        private double _pressure = 0;
        private ToolTip pipeToolTip = new ToolTip();
        private bool _alarm = false;
        private Timer refreshTimer = new Timer();
        private bool _autoRefresh = false;
        private int _refreshInterval = 500;

        // PLC Tag bilgileri
        private string _isOpenTag = "";
        private string _pipeEnabledTag = "";
        private string _temperatureTag = "";
        private string _pressureTag = "";


        public PipeControl()
        {
            InitializeComponent();

            // Timer ayarları
            refreshTimer.Interval = RefreshInterval;
            refreshTimer.Tick += RefreshTimer_Tick;

            RefreshPipe();

            // PictureBox'a tıklanınca bu metot çalışacak
            picturePipe.Click += PicturePipe_Click;
        }



        // Özellik kategorisi düzenli görünecek
        [Category("Appearance")]
        [Description("Borunun açık mı kapalı mı olduğunu belirler.")]
        [DefaultValue(false)]
        public bool IsOpen
        {
            get
            {
                return _isOpen;
            }
            set
            {
                _isOpen = value;
                RefreshPipe();
            }
        }

        [Category("Behavior")]
        [Description("Borunun kullanıcı tarafından değiştirilip değiştirilemeyeceğini belirler.")]
        [DefaultValue(true)]
        public bool PipeEnabled
        {
            get
            {
                return _pipeEnabled;
            }
            set
            {
                _pipeEnabled = value;
            }
        }


        [Category("Data")]
        [Description("Borunun adını belirtir.")]
        [DefaultValue("Pipe")]
        public string PipeName
        {
            get
            {
                return _pipeName;
            }
            set
            {
                _pipeName = value;
            }
        }

        [Category("Data")]
        [Description("Borudan geçen akışkanın sıcaklığını gösterir.")]
        [DefaultValue(0.0)]
        public double Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                RefreshPipe();
            }
        }


        [Category("Data")]
        [Description("Borudan geçen akışkanın basıncını gösterir.")]
        [DefaultValue(0.0)]
        public double Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = value;
                RefreshPipe();
            }
        }



        //sonradan plc için ekledim
        [Category("PLC")]
        [Description("PLC BOOL değişken adresi.")]
        [DefaultValue("")]
        public string IsOpenTag                        //PLC değişkenleri isimle okunduğu için string
        {
            get
            {
                return _isOpenTag;
            }
            set
            {
                _isOpenTag = value;
            }
        }


        [Category("PLC")]
        [Description("PLC BOOL değişken adresi.")]
        [DefaultValue("")]
        public string PipeEnabledTag
        {
            get
            {
                return _pipeEnabledTag;
            }
            set
            {
                _pipeEnabledTag = value;
            }
        }


        [Category("PLC")]
        [Description("PLC REAL değişken adresi.")]
        [DefaultValue("")]
        public string TemperatureTag
        {
            get
            {
                return _temperatureTag;
            }
            set
            {
                _temperatureTag = value;
            }
        }

        [Category("PLC")]
        [Description("PLC REAL değişken adresi.")]
        [DefaultValue("")]
        public string PressureTag
        {
            get
            {
                return _pressureTag;
            }
            set
            {
                _pressureTag = value;
            }
        }
        //buraya kadar



        //kullanıcı karar verecek.
        [Category("PLC")]
        [Description("PLC'den otomatik veri okunmasını sağlar.")]
        [DefaultValue(false)]
        public bool AutoRefresh { get; set; } = false;



        [Category("Status")]
        [Description("Borunun alarm durumu.")]
        public bool Alarm
        {
            get
            {
                return _alarm;
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


        //    [Category("Data")]
        //  [Description("Boruda alarm durumu.")]
        // [DefaultValue(false)]
        //  public bool Alarm
        //  {
        //    get
        //  {
        //    return _alarm;
        //  }
        //set
        //{
        //_alarm = value;
        //UpdateToolTip();
        //}
        //}


        private void RefreshPipe()
        {
            // Borunun durumuna göre uygun resmi göster
            if (_isOpen)
            {
                picturePipe.Image = Resources.Pipe_Open;
            }
            else
            {
                picturePipe.Image = Resources.Pipe_Close;
            }

            // Alarm kontrolünü sonradan ekledim.
            // Sıcaklık 200 °C'den büyükse veya basınç 8 bardan büyükse alarm aktif olur.
            _alarm = Temperature > 200 || Pressure > 8;

            // ToolTip'i güncellemek için sonradan ekledim.
            // Böylece güncel bilgiler kullanıcıya gösterilir.
            UpdateToolTip();
        }


        private void UpdateToolTip()
        {
            string status = IsOpen ? "Open" : "Closed";

            string text =
                $"Pipe Name : {PipeName}\n" +          //
                $"Status : {status}\n" +
                $"Temperature : {Temperature} °C\n" +
                $"Pressure : {Pressure} bar";

            if (Alarm)
            {
                text += "\n\n⚠ ALARM!";
            }

            pipeToolTip.SetToolTip(picturePipe, text);
        }



        /// <summary>
        /// PLC'den PipeControl'e ait değerleri okur.
        /// </summary>
        private void ReadPlcValues()
        {
            if (!PlcClient.IsConnected)
                return;

            // Açık/Kapalı bilgisini oku
             IsOpen = PlcClient.ReadBool(IsOpenTag);

            // Sıcaklık bilgisini oku
             Temperature = PlcClient.ReadFloat(TemperatureTag);

            // Basınç bilgisini oku
             Pressure = PlcClient.ReadFloat(PressureTag);

            // Görseli güncelle
            // RefreshPipe();
        }




        // PictureBox'a tıklanınca çalışacak metot
        //  private void PicturePipe_Click(object sender, EventArgs e)
        //{
        //    IsOpen = !IsOpen;             // Bu aslında şu demekmiş =    IsOpen = false  → !false = true   ,     IsOpen = true   → !true = false
        //}

        private void PicturePipe_Click(object sender, EventArgs e)
        {
            if (!PipeEnabled)
                return;

            IsOpen = !IsOpen;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReadPlcValues();
        }
    }
}