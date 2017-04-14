using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using Q42.HueApi.ColorConverters.OriginalWithModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q42.HueApi.ColorConverters;

namespace Rca.HueSandbox
{
    public class HueWrapper
    {
        #region Constants
        const string APP_NAME = "HueSandboxApp";
        const string DEVICE_NAME = "TestDevice";

        #endregion

        #region Member
        AppKeyManager m_AppKeyManager;
        ILocalHueClient m_Client;

        #endregion Member

        #region Properties
        /// <summary>
        /// Located bridges
        /// </summary>
        public List<LocatedBridge> LocatedBridges { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for BridgeLocator
        /// </summary>
        public HueWrapper()
        {
            LocatedBridges = new List<LocatedBridge>();
            m_AppKeyManager = new AppKeyManager();


        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Scan for Bridges
        /// </summary>
        public async Task<string[]> ScanBridges()
        {
            IBridgeLocator locator = new HttpBridgeLocator();
            var bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            
            foreach (LocatedBridge bridge in bridgeIPs)
                LocatedBridges.Add(bridge);

            return LocatedBridges.Select(x => x.IpAddress).ToArray();
        }

        /// <summary>
        /// Initialize the first bridge of the located-bridges-list
        /// </summary>
        public void Initialize()
        {
            if (LocatedBridges.Count > 0)
                Initialize(LocatedBridges[0].IpAddress);
            else
                throw new InvalidOperationException("No bridges found");
        }

        /// <summary>
        /// Initialize a specific bridge
        /// </summary>
        /// <param name="bridgeIp">Ip of the bridge</param>
        public async Task<Bridge> Initialize(string bridgeIp)
        {
            m_Client = new LocalHueClient(bridgeIp);

            var appKey = m_AppKeyManager.AppKey;
            if (String.IsNullOrEmpty(appKey))
            {
                appKey = await m_Client.RegisterAsync(APP_NAME, DEVICE_NAME);
                m_AppKeyManager.AppKey = appKey;
            }
            m_Client.Initialize(appKey);

            return await m_Client.GetBridgeAsync();
        }

        /// <summary>
        /// Ruft die Namen aller aktiven Hue Geräte ab
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> GetDevices()
        {
            var lights = await m_Client.GetLightsAsync();

            var devices = new Dictionary<string, string>();

            foreach (var light in lights)
            {
                devices.Add(light.Id, light.Name);
            }

            return devices;
        }

        /// <summary>
        /// Verbindet ein Gerät
        /// </summary>
        /// <param name="id">Geräte Id</param>
        /// <returns>Geräte Parameter</returns>
        public async Task<Light> ConnectDevice(string id)
        {
            return await m_Client.GetLightAsync(id);
        }

        public void SwitchLight(string id, bool state)
        {
            var command = new LightCommand();
            command.On = state;

            m_Client.SendCommandAsync(command, new List<string>() { id });
        }

        public void SetColor(string id, int red, int green, int blue, string modell = "LCT001")
        {
            var color = new RGBColor(red, green, blue);
            var command = new LightCommand();
            command.SetColor(color, modell);

            m_Client.SendCommandAsync(command, new List<string>() { id });
        }

        public void SetBrigthness(string id, int brightness)
        {
            byte value = Convert.ToByte(brightness);
            var command = new LightCommand();
            command.Brightness = value;

            m_Client.SendCommandAsync(command, new List<string>() { id });
        }

        public async void TestLight()
        {
            var command = new LightCommand();
            command.On = false;

            var lights = await m_Client.GetLightsAsync();

            m_Client.SendCommandAsync(command);
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
