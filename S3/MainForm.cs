using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;
using Nancy.Hosting.Self;
using Newtonsoft.Json;
using System.Net;
using static S3.smashgg;
using OBSWebsocketDotNet;
using System.Threading;

namespace S3
{
    public partial class MainForm : Form
    {
        protected OBSWebsocket _obs;
        private NancyHost hostg;
        public MainForm()
        {
            InitializeComponent();

            _obs = new OBSWebsocket();
            Globals.CurrentInformationUpdate = new InformationUpdate();
            Globals.CurrentInformationUpdate.Player1 = new Player();
            Globals.CurrentInformationUpdate.Player2 = new Player();
            Globals.CurrentInformationUpdate.Player1.name = "EIREXE";
            Globals.CurrentInformationUpdate.Player2.name = "BoastingToast";
            Globals.CurrentInformationUpdate.isEmpty = true;
            parseComboBoxItems();
            _obs.OnRecordingStateChange += onRecordingStateChange;
            try
            {
                _obs.Connect("ws://127.0.0.1:4444", "password");
            }
            catch (AuthFailureException)
            {
                MessageBox.Show("Authentication failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            catch (ErrorResponseException ex)
            {
                MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void onRecordingStateChange(OBSWebsocket sender, OutputState newState)
        {
            string state = "";
            switch (newState)
            {
                case OutputState.Starting:
                    state = "Recording starting...";
                    btnToggleRecording.Text = state;
                    break;

                case OutputState.Started:
                    state = "Stop recording";
                    btnToggleRecording.Text = state;
                    break;

                case OutputState.Stopping:
                    state = "Recording stopping...";
                    btnToggleRecording.Text = state;
                    break;

                case OutputState.Stopped:
                    state = "Start recording";
                    btnToggleRecording.Text = state;
                    break;

                default:
                    state = "State unknown";
                    btnToggleRecording.Text = state;
                    break;
            }
            

            BeginInvoke((MethodInvoker)delegate
            {
                btnToggleRecording.Text = state;
            });
        }

        private void SendUpdateButton_Click(object sender, EventArgs e)
        {
            SendUpdate();

        }
        private void updateName(string name)
        {
            using (StreamReader sr = File.OpenText("names.txt"))
            {
                string[] lines = File.ReadAllLines("names.txt");
                bool isMatch = false;
                for (int x = 0; x < lines.Length - 1; x++)
                {
                    if (Player1Name.Text == lines[x] || Player2Name.Text == lines[x])
                    {
                        sr.Close();
                        isMatch = true;
                    }
                }
                if (!isMatch && Player1Name.Text != "" && Player2Name.Text != "")
                {
                    sr.Close();
                    File.AppendAllText("names.txt", Player1Name.Text + Environment.NewLine);
                    File.AppendAllText("names.txt", Player2Name.Text + Environment.NewLine);
                }
            }
        }
        private void SendUpdate()
        {
            if (Globals.CurrentInformationUpdate.isEmpty == true)
            {
                _obs.ToggleRecording();
            }

            updateName(Player1Name.Text);
            updateName(Player2Name.Text);
            string[] names = File.ReadAllLines("names.txt");

            Player1Name.AutoCompleteCustomSource.AddRange(names);
            Player2Name.AutoCompleteCustomSource.AddRange(names);

            Globals.CurrentInformationUpdate.Player1.name = Player1Name.Text;
            Globals.CurrentInformationUpdate.Player2.name = Player2Name.Text;
            Globals.CurrentInformationUpdate.Player1.sponsor = (Sponsor)((ComboboxItem)Player1Sponsor.SelectedItem).Value;
            Globals.CurrentInformationUpdate.Player2.sponsor = (Sponsor)((ComboboxItem)Player2Sponsor.SelectedItem).Value;
            Globals.CurrentInformationUpdate.Player1.character = (Character)((ComboboxItem)Player1Character.SelectedItem).Value;
            Globals.CurrentInformationUpdate.Player2.character = (Character)((ComboboxItem)Player2Character.SelectedItem).Value;
            Globals.CurrentInformationUpdate.Player1.score = Decimal.ToInt32(Player1Score.Value);
            Globals.CurrentInformationUpdate.Player2.score = Decimal.ToInt32(Player2Score.Value);
            Globals.CurrentInformationUpdate.tournamentName = tournamentNameTextbox.Text;
            Globals.CurrentInformationUpdate.round = RoundNameTextbox.Text;
            Globals.CurrentInformationUpdate.caster = CasterTextbox.Text;
            Globals.CurrentInformationUpdate.streamer = StreamerTextbox.Text;
            Globals.CurrentInformationUpdate.Player1.flag = ((Flag) ((ComboboxItem) FlagsCombo.SelectedItem).Value);
            Globals.CurrentInformationUpdate.Player2.flag = ((Flag)((ComboboxItem)FlagsComboP2.SelectedItem).Value);
            if (Player1Name.Text != null || Player2Name.Text != null)
            {
                Globals.CurrentInformationUpdate.isEmpty = false;
            }
        }
        private void switchPorts()
        {
            string p1name = Player1Name.Text;
            string p2name = Player2Name.Text;
            Player1Name.Text = p2name;
            Player2Name.Text = p1name;

            string p1char = Player1Character.Text;
            string p2char = Player2Character.Text;
            Player1Character.Text = p2char;
            Player2Character.Text = p1char;

            int p1score = Decimal.ToInt32(Player1Score.Value);
            int p2score = Decimal.ToInt32(Player2Score.Value);
            Player1Score.Value = p2score;
            Player2Score.Value = p1score;


            Globals.CurrentInformationUpdate.Player1.name = Player1Name.Text;
            Globals.CurrentInformationUpdate.Player2.name = Player2Name.Text;

            Globals.CurrentInformationUpdate.Player1.character = (Character)((ComboboxItem)Player1Character.SelectedItem).Value;
            Globals.CurrentInformationUpdate.Player2.character = (Character)((ComboboxItem)Player2Character.SelectedItem).Value;

            Globals.CurrentInformationUpdate.Player1.score = Decimal.ToInt32(Player1Score.Value);
            Globals.CurrentInformationUpdate.Player2.score = Decimal.ToInt32(Player2Score.Value);
        }
        private void parseComboBoxItems()
        {
            string file = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "characters.json");
            string contents = File.ReadAllText(file);
            CharacterList list = JsonConvert.DeserializeObject<CharacterList>(contents);
            
            foreach(Character c in list.characters)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = c.name;
                item.Value = c;
                Player1Character.Items.Add(item);
                Player2Character.Items.Add(item);
                
            }
            Player1Character.SelectedIndex = 0;
            Player2Character.SelectedIndex = 0;


            string sponsors = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "sponsors.json");
            string sponsorsContents = File.ReadAllText(sponsors);
            SponsorList sponsorslist = JsonConvert.DeserializeObject<SponsorList>(sponsorsContents);

            foreach (Sponsor s in sponsorslist.sponsors)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = s.name;
                item.Value = s;
                Player1Sponsor.Items.Add(item);
                Player2Sponsor.Items.Add(item);

            }
            Player1Character.SelectedIndex = 0;
            Player2Character.SelectedIndex = 0;
            Player1Sponsor.SelectedIndex = 0;
            Player2Sponsor.SelectedIndex = 0;
            string flags = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "flags.json");
            string flagsContents = File.ReadAllText(flags);
            FlagList flagsList = JsonConvert.DeserializeObject<FlagList>(flagsContents);
            foreach (Flag flag in flagsList.flags)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = flag.name;
                item.Value = flag;
                FlagsCombo.Items.Add(item);
                FlagsComboP2.Items.Add(item);
            }
            FlagsCombo.SelectedIndex = 0;
            FlagsComboP2.SelectedIndex = 0;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Scoreboard Settings Data(.auboard)|*.auboard|All Files(*.*) | *.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                string contents = File.ReadAllText(dialog.FileName);
                Settings settings = JsonConvert.DeserializeObject<Settings>(contents);
                Globals.settings = settings;
                updateData();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Scoreboard Settings Data(.auboard)|*.auboard|All Files(*.*) | *.*";
            Globals.settings.streamData = Globals.CurrentInformationUpdate;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                File.WriteAllText(dialog.FileName,JsonConvert.SerializeObject(Globals.settings, Formatting.Indented));
            }
            
        }

        private void updateData()
        {
            Player1Name.Text = Globals.settings.streamData.Player1.name;
            Player2Name.Text = Globals.settings.streamData.Player2.name;
            Player1Sponsor.Text = Globals.settings.streamData.Player1.sponsor.name;
            Player2Sponsor.Text = Globals.settings.streamData.Player2.sponsor.name;
            Player1Character.Text = Globals.settings.streamData.Player1.character.name;
            Player2Character.Text = Globals.settings.streamData.Player2.character.name;
            Player1Score.Text = Globals.settings.streamData.Player1.score.ToString();
            Player2Score.Text = Globals.settings.streamData.Player2.score.ToString();
            FlagsCombo.Text = Globals.settings.streamData.Player1.flag.name;
            FlagsComboP2.Text = Globals.settings.streamData.Player2.flag.name;
            RoundNameTextbox.Text = Globals.settings.streamData.round;
            tournamentNameTextbox.Text = Globals.settings.streamData.tournamentName;
            StreamerTextbox.Text = Globals.settings.streamData.streamer;
            CasterTextbox.Text = Globals.settings.streamData.caster;
            SendUpdate();
        }
        private void getParticipants()
        {
            string smashgg = Globals.settings.smashgg;
            if(smashgg == null)
            {
                return;
            }
            else
            {
                string url = "https://api.smash.gg/tournament/" + smashgg + "?expand[0]=participants";
                var json = new WebClient().DownloadString(url);
                RootObject data = JsonConvert.DeserializeObject<RootObject>(json);
                var participants = data.entities.participants;
                foreach (var participant in participants) {
                    string tag = (participant.gamerTag);
                    File.AppendAllText("names.txt", tag + Environment.NewLine);
                    Console.WriteLine(tag);
                }


            }
        }
        private bool isServerUp = false;
        private void StartServer_Click(object sender, EventArgs e)
        {            
            if (isServerUp)
            {
                hostg.Stop();
                StartServer.Text = "Start Server";
                isServerUp = false;
            }
            else
            {
                getParticipants();
                if (Globals.settings.tintEnabled)
                {
                    foreach (string file in Directory.GetFiles(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Content/html/img")))
                    {
                        using (MagickImage image = new MagickImage(file))
                        {
                            image.Colorize(new MagickColor(Globals.settings.tintColor), new Percentage(100));
                            image.Write(file);
                        }
                    }
                }
                isServerUp = true;
                try
                {
                    UrlLinkLabel.Text = "http://127.0.0.1:" + Globals.settings.serverPort + "/Content/html/scoreboard.html";
                    HostConfiguration config = new HostConfiguration();
                    config.UrlReservations.CreateAutomatically = true;
                    NancyHost host = new NancyHost(config, new Uri("http://127.0.0.1:" + Globals.settings.serverPort));

                    host.Start();
                    hostg = host;
                    StartServer.Text = "Stop Server";
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                    throw;
                }
            }
        }

        private void UrlLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start(UrlLinkLabel.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switchPorts();
        }
        private void reset()
        {
            var delay = Task.Delay(1000).ContinueWith(_ =>
            {            
            var directory = new DirectoryInfo("recordings");
            string myFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First().Name;
            string newname = Globals.CurrentInformationUpdate.tournamentName + " " + Globals.CurrentInformationUpdate.Player1.name + " vs. " + Globals.CurrentInformationUpdate.Player2.name + " " + Globals.CurrentInformationUpdate.round + ".mp4";
            System.IO.File.Move("recordings/" + myFile, "recordings/" + newname);
            MessageBox.Show(myFile + Environment.NewLine + newname);
                string description = "Super Smash Bros. Melee tournament " + Globals.CurrentInformationUpdate.round + " " + Globals.CurrentInformationUpdate.Player1.name + " vs. " + Globals.CurrentInformationUpdate.Player2.name;
                string videoName = Globals.CurrentInformationUpdate.round + " " + Globals.CurrentInformationUpdate.Player1.name + " vs. " + Globals.CurrentInformationUpdate.Player2.name + " " + Globals.CurrentInformationUpdate.tournamentName;
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Player1Score.Value = 0;
            Player2Score.Value = 0;
            Player1Name.Text = "";
            Player2Name.Text = "";
            RoundNameTextbox.Text = "";
            if (btnToggleRecording.Text == "Stop recording")
            {
                _obs.ToggleRecording();
            }
            Globals.CurrentInformationUpdate.isEmpty = true;
            Thread resetThread = new Thread(reset);
            resetThread.Start();
        }

        private void Player1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player1Score.Value = Decimal.ToInt32(Player1Score.Value) + 1;
            SendUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player2Score.Value = Decimal.ToInt32(Player2Score.Value) + 1;
            SendUpdate();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainWindow obswindow = new MainWindow();
            obswindow.ShowDialog();
        }

        private void btnToggleRecording_Click(object sender, EventArgs e)
        {
            _obs.ToggleRecording();
            btnToggleRecording.Text = "Stop recording";
            btnToggleRecording.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
