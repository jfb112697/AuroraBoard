using Newtonsoft.Json.Linq;
using OBSWebsocketDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if (!Globals.settings.tintEnabled)
            {
                ColorTextBox.Enabled = false;

            }
            else
            {

                TintingEnableCheckbox.Checked = true;

            }
            ServerPortbox.Value = Globals.settings.serverPort;
            ColorTextBox.Text = Globals.settings.tintColor;
        }

        private void TintingEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (TintingEnableCheckbox.Checked)
            {
                ColorTextBox.Enabled = true;
            }
            else
            {
                ColorTextBox.Enabled = false;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Globals.settings.serverPort = Convert.ToInt32(ServerPortbox.Value);
            Globals.settings.tintColor = ColorTextBox.Text;
            Globals.settings.tintEnabled = TintingEnableCheckbox.Checked;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
        private static Dictionary<string, int> getStreams(string smashgg)
        {
            Dictionary<string, int> streams = new Dictionary<string, int>();
            string url = "https://api.smash.gg/tournament/" + smashgg + "?expand[0]=stream";
            var json = new WebClient().DownloadString(url);
            dynamic RootObject = JObject.Parse(json);
            foreach (var stream in RootObject.entities.stream)
            {
                int id = stream.id;
                string name = stream.streamName;
                streams.Add(name, id);
            }
            return streams;
        }
        
        private void StreamButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> streams = getStreams(Globals.settings.smashgg);
            StreamBox.DataSource = new BindingSource(streams, null);
            StreamBox.DisplayMember = "Key";
            StreamBox.ValueMember = "Value";
        }

        private void smashgg_TextChanged(object sender, EventArgs e)
        {
            Globals.settings.smashgg = smashgg.Text;
        }

        private void StreamBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, int> selected = (KeyValuePair<string, int>)StreamBox.SelectedItem;
            int streamid = selected.Value;
            Globals.settings.streamId = streamid;
        }
    }
}
