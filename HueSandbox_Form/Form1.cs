using Q42.HueApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HueSandbox_Form
{
    public partial class Form1 : Form
    {
        Controller m_Controller;
        string m_SelectedBridgeIp;
        string m_CurrentDeviceId;

        public Form1()
        {
            InitializeComponent();

            m_Controller = new Controller();
        }

        private async void btn_SearchBridges_Click(object sender, EventArgs e)
        {
            var bridgeIps = await m_Controller.SearchBridges();

            cbx_BridgeSelector.Items.AddRange(bridgeIps);

            if (bridgeIps.Length == 1)
                MessageBox.Show("Es wurde eine Hue Bridge gefunden.", "Suche beendet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (bridgeIps.Length > 1)
                MessageBox.Show("Es wurden " + bridgeIps.Length.ToString() + " Hue Bridges gefunden.", "Suche beendet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Es konnte keine Hue Bridge gefunden werden.", "Suche beendet", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private async void btn_ConnectBridge_Click(object sender, EventArgs e)
        {
            Bridge bridgeDetails = await m_Controller.ConnectBridge(cbx_BridgeSelector.SelectedItem.ToString());
            pgr_BridgeDetails.SelectedObject = bridgeDetails.Config;

            var deviceNames = bridgeDetails.Lights.Select(x => x.Name).ToArray();
            cbx_LightSelector.Items.AddRange(deviceNames);
        }

        private void cbx_BridgeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ConnectBridge.Enabled = !String.IsNullOrEmpty(cbx_BridgeSelector.SelectedItem.ToString());
        }

        private async void btn_GetLights_Click(object sender, EventArgs e)
        {
            //var devices = await m_Controller.GetDevices();

            //var deviceNames = devices.Select(x => x.Value).ToArray();

            //cbx_LightSelector.Items.AddRange(deviceNames);

            //if (deviceNames.Length == 1)
            //    MessageBox.Show("Es wurden ein Hue Device abgerufen.", "Device Abfrage beendet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else if (deviceNames.Length > 1)
            //    MessageBox.Show("Es wurden " + deviceNames.Length.ToString() + " Hue Devices abgerufen.", "Device Abfrage beendet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Keine Hue Devices verfügbar.", "Device Abfrage beendet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbx_LightSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbx_LightSelector.SelectedItem.ToString()))
            {
                int i = cbx_LightSelector.SelectedIndex;
                m_CurrentDeviceId = m_Controller.BridgeDetails.Lights.ElementAt(i).Id;
                pgr_LightDetails.SelectedObject = m_Controller.GetDeviceDetails(m_CurrentDeviceId);
            }
        }

        private async void btn_ConnectLight_Click(object sender, EventArgs e)
        {
            //int i = cbx_LightSelector.SelectedIndex;
            //string id = m_Controller.HueDevices.ElementAt(i).Key;

            //Light light = await m_Controller.ConnectDevice(id);

            //pgr_LightDetails.SelectedObject = light;
        }

        private void btn_On_Click(object sender, EventArgs e)
        {
            m_Controller.SwitchLight(m_CurrentDeviceId, true);
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {
            m_Controller.SwitchLight(m_CurrentDeviceId, false);
        }

        private void btn_SetColor_Click(object sender, EventArgs e)
        {
            m_Controller.SetColor(m_CurrentDeviceId, convertColorFrag(txt_Red.Text), convertColorFrag(txt_Green.Text), convertColorFrag(txt_Blue.Text));
        }

        int convertColorFrag(string str)
        {
            if (string.IsNullOrEmpty(str))
                str = "0";

            int res = 0;

            if (Int32.TryParse(str, out res))
            {
                if (res < 256 && res >= 0)
                    return res;
            }

            throw new ArgumentException("Can not parse input value (" + str + "). Value must be a valide number between 0 and 255.");
        }

        private void btn_SetBrigthness_Click(object sender, EventArgs e)
        {
            m_Controller.SetBrigthness(m_CurrentDeviceId, convertColorFrag(txt_Brigthness.Text));
        }
    }
}
