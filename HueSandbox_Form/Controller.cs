using Q42.HueApi;
using Rca.HueSandbox;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueSandbox_Form
{
    public class Controller
    {
        #region Member
        HueWrapper m_Hue;

        #endregion Member

        #region Properties
        //public Dictionary<string, string> HueDevices { get; set; }

        public Bridge BridgeDetails { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Controller
        /// </summary>
        public Controller()
        {
            m_Hue = new HueWrapper();
        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Sucht nach Hue Bridges im lokalen Netzwerk
        /// </summary>
        /// <returns>IP Adressen der gefunden Hue Bridges</returns>
        public async Task<string[]> SearchBridges()
        {
            return await m_Hue.ScanBridges();
        }

        /// <summary>
        /// Baut eine Verbindung zur angegebenen Hue Bridge auf
        /// </summary>
        /// <returns>Hue Bridge</returns>
        public async Task<Bridge> ConnectBridge(string ip)
        {
            BridgeDetails = await m_Hue.Initialize(ip);

            return BridgeDetails;
        }

        public Light GetDeviceDetails(string id)
        {
            return BridgeDetails.Lights.First(x => x.Id == id);
        }

        public void SetColor(string id, int red, int green, int blue)
        {
            var modell = BridgeDetails.Lights.First(x => x.Id == id).ModelId;

            m_Hue.SetColor(id, red, green, blue, modell);
        }

        public void SetBrigthness(string id, int brigthness)
        {
            m_Hue.SetBrigthness(id, brigthness);
        }


        public void SwitchLight(string id, bool state)
        {
            m_Hue.SwitchLight(id, state);

        }

        public State GetSettings(string id)
        {
            var light = BridgeDetails.Lights.First(x => x.Id == id);

            return light.State;
        }

        #endregion Services

        #region Internal services
        #endregion Internal services

        #region Events
        #endregion Events
    }
}
