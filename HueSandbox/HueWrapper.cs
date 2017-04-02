using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async void ScanBridges()
        {
            IBridgeLocator locator = new HttpBridgeLocator();
            var bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));

            foreach (LocatedBridge bridge in bridgeIPs)
                LocatedBridges.Add(bridge);
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
        public async void Initialize(string bridgeIp)
        {
            ILocalHueClient client = new LocalHueClient(bridgeIp);

            var appKey = m_AppKeyManager.AppKey;
            if (String.IsNullOrEmpty(appKey))
            {
                appKey = await client.RegisterAsync(APP_NAME, DEVICE_NAME);
                m_AppKeyManager.AppKey = appKey;
            }
            client.Initialize(appKey);
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
