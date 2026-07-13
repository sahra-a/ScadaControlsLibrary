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

        private static string _amsNetId = "";
        private static int _port = 851;

        #endregion

        #region Initialization

        public static void InitCommunication(string amsNetId, int port)
        {
            _amsNetId = amsNetId;
            _port = port;
        }

        #endregion
    }
}
