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
            _isConnected = true;
            return _isConnected;
        }

        /// <summary>
        /// PLC bağlantısını sonlandırır.
        /// </summary>
        public static void Disconnect()
        {
            _isConnected = false;
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
    }
}