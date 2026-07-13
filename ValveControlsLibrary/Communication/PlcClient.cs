using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



namespace ScadaControlsLibrary.Communication
{
    public static class PlcClient
    {
        #region Fields

        private static string _amsNetId = string.Empty;
        private static int _port = 851;
        private static bool _isConnected = false;

        #endregion

        #region Initialization

        /// <summary>
        /// PLC haberleşmesi için gerekli bağlantı bilgilerini ayarlar.
        /// Uygulama başlangıcında bir kez çağrılır.
        /// </summary>
        public static void InitCommunication(string amsNetId, int port)
        {
            if (string.IsNullOrWhiteSpace(amsNetId))
                throw new ArgumentException("AMS Net ID cannot be empty.", nameof(amsNetId));

            if (port <= 0)
                throw new ArgumentOutOfRangeException(nameof(port));

            _amsNetId = amsNetId;
            _port = port;
        }

        #endregion

        #region Connection

        /// <summary>
        /// PLC bağlantısını kurar.
        /// (Şimdilik iskelet yapı)
        /// </summary>
        public static bool Connect()
        {
            // Zaten bağlıysa tekrar bağlanma.
            if (_isConnected)
                return true;

            try
            {
                // PLC bağlantısı ileride burada kurulacak.

                _isConnected = true;
                return true;
            }
            catch
            {
                _isConnected = false;
                return false;
            }
        }

        /// <summary>
        /// PLC bağlantısını sonlandırır.
        /// </summary>
        public static void Disconnect()
        {
            // Zaten bağlantı yoksa işlem yapma.
            if (!_isConnected)
                return;

            try
            {
                // PLC bağlantısı ileride burada kapatılacak.

                _isConnected = false;
            }
            catch
            {
            }
        }





        /// <summary>
        /// PLC bağlantı durumunu döndürür.
        /// </summary>
        public static bool IsConnected
        {
            get
            {
                return _isConnected;
            }
        }

        #endregion

        #region Reading

        /// <summary>
        /// PLC'den bool tipinde veri okur.
        /// Şimdilik test amacıyla sabit değer döndürmektedir.
        /// Gerçek haberleşme kodu daha sonra eklenecektir.
        /// </summary>
        public static bool ReadBool(string tagName)
        {
            return false;
        }



        /// <summary>
        /// PLC'den float tipinde veri okur.
        /// Gerçek haberleşme kodu daha sonra eklenecektir.
        /// </summary>
        public static float ReadFloat(string tagName)
        {
            return 0.0f;
        }



        /// <summary>
        /// PLC'den int tipinde veri okur.
        /// Gerçek haberleşme kodu daha sonra eklenecektir.
        /// Şimdilik test amacıyla sabit değer döndürmektedir.
        /// </summary>
        public static int ReadInt(string tagName)
        {
            return 0;
        }

        #endregion



        #region Writing

        /// <summary>
        /// PLC'ye veri yazar.
        /// Şimdilik test amacıyla başarılı kabul edilmektedir.
        /// Gerçek haberleşme kodu daha sonra eklenecektir.
        /// </summary>
        public static bool Write(string tagName, object value)
        {
            return true;
        }

        #endregion
    }
}