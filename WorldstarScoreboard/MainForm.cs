using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;
using Nancy.Hosting.Self;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using OBSWebsocketDotNet;
using System.Threading;
using System.Text.RegularExpressions;
using S22.Xmpp;
using S22.Xmpp.Client;
using S22.Xmpp.Core;
using S22.Xmpp.Im;

namespace S3
{
    public partial class MainForm : Form
    {
        protected OBSWebsocket _obs;
        private NancyHost hostg;
        private XmppClient client = new XmppClient("im.koderoot.net", "worldstarhitbot", "testxmpp", 5222, true, null);

        public MainForm()
        {
            InitializeComponent();
            _obs = new OBSWebsocket();
            Globals.CurrentInformationUpdate = new InformationUpdate();
            Globals.CurrentInformationUpdate.Player1 = new Player();
            Globals.CurrentInformationUpdate.Player2 = new Player();
            Globals.CurrentInformationUpdate.Player1.name = "Red Squirrel";
            Globals.CurrentInformationUpdate.Player2.name = "BoastingToast";
            _obs.OnRecordingStateChange += onRecordingStateChange;
            btnToggleRecording.Hide();
            client = new XmppClient("im.koderoot.net", "worldstarhitbot", "testxmpp", 5222, true, null);
            MessageBox.Show(client.Connected + "");
            if (client.Connected == true)
            {
                client.Close();
            }
           
            
            client.Message += OnNewMessage;
            client.Connect();
            client.SendMessage("worldstarhitbox@im.konderoot.net", "testttt", null, null, MessageType.Normal, null);

            
            client.SetStatus(new Status(Availability.Online, null, 0));
            MessageBox.Show(client.Connected + "");
        }

        void OnNewMessage(object sender, S22.Xmpp.Im.MessageEventArgs e)
        {
            string resID = e.Jid.Resource;
            string domain = e.Jid.Domain;
            string jid = e.Jid.ToString().Replace(resID, "");
            jid = jid.Replace(domain, "");
            jid = jid.Replace("@/", "");
            string mes = e.Message.Body;
            //MessageBox.Show(mes + " : " + jid);
            if(mes == "sendupdate")
            {
                SendUpdateButton.Invoke((MethodInvoker)(() => SendUpdateButton.PerformClick()));
            }
            if (mes.Contains(":"))
            {
                string[] elem = mes.Split(':');
                foreach (Control control in Controls)
                {
                    Console.WriteLine(control.Name);
                    if(control.Name == elem[0])
                    {
                        if(control.GetType().ToString() == "System.Windows.Forms.NumericUpDown")
                        {
                            NumericUpDown upDown = (NumericUpDown)control;
                            upDown.Invoke((MethodInvoker)(() => upDown.Value = int.Parse(elem[1])));
                        }
                        else
                        {
                            control.Invoke((MethodInvoker)(() => control.Text = elem[1]));
                        }
                      
                    }
                    else if (control.GetType().ToString() == "System.Windows.Forms.GroupBox")
                    {
                        foreach(Control gboxC in control.Controls)
                        {
                            if (gboxC.Name == elem[0])
                            {
                                Console.WriteLine(gboxC.Name);
                                if (gboxC.GetType().ToString() == "System.Windows.Forms.NumericUpDown")
                                {
                                    NumericUpDown upDown = (NumericUpDown)gboxC;
                                    upDown.Invoke((MethodInvoker)(() => upDown.Value = int.Parse(elem[1])));
                                }
                                else
                                {
                                    gboxC.Invoke((MethodInvoker)(() => gboxC.Text = elem[1]));
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show(mes);
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
            if(System.IO.File.Exists("names.txt") == false)
            {
                System.IO.File.Create("names.txt");
            }
            using (StreamReader sr = File.OpenText("names.txt"))
            {
                string[] lines = File.ReadAllLines("names.txt");
                for (int x = 0; x < lines.Length - 1; x++)
                {
                    if (Player1Name.Text == lines[x] || Player2Name.Text == lines[x])
                    {
                        sr.Close();
                        return;
                    }
                }
                sr.Close();
                if (Player1Name.Text != "" && Player2Name.Text != "")
                {
                    File.AppendAllText("names.txt", Player1Name.Text + Environment.NewLine);
                    File.AppendAllText("names.txt", Player2Name.Text + Environment.NewLine);
                    sr.Close();
                }
            }
        }
        private void SendUpdate()
        {
            if (isEmpty == true && obs == true && getRecordingStatus() == false)
            {
               _obs.ToggleRecording();
            }
            string p1name = Player1Name.Text;
            string p2name = Player2Name.Text;
            if(P1Sponsor.Text != "")
            {
                p1name = P1Sponsor.Text + " | " + Player1Name.Text;
                MessageBox.Show(p1name);
                try
                {
                    sponsors.Add(Player1Name.Text, P1Sponsor.Text);
                }
                catch (System.ArgumentException) { }
            }
            if (P2Sponsor.Text != "")
            {
                p2name = P2Sponsor.Text + " | " + Player2Name.Text;
                try
                {
                    sponsors.Add(Player2Name.Text, P2Sponsor.Text);
                }
                catch (System.ArgumentException) { }
            }

            updateName(Player1Name.Text);
            updateName(Player2Name.Text);
            string[] names = File.ReadAllLines("names.txt");

            Player1Name.AutoCompleteCustomSource.AddRange(names);
            Player2Name.AutoCompleteCustomSource.AddRange(names);

            Globals.CurrentInformationUpdate.Player1.name = p1name;
            Globals.CurrentInformationUpdate.Player2.name = p2name;
            Globals.CurrentInformationUpdate.Player1.score = Decimal.ToInt32(Player1Score.Value);
            Globals.CurrentInformationUpdate.Player2.score = Decimal.ToInt32(Player2Score.Value);
            Globals.CurrentInformationUpdate.Player1.character = P1Char.Text;
            Globals.CurrentInformationUpdate.Player2.character = P2Char.Text;
            Globals.CurrentInformationUpdate.Player1.sponsor = P1Sponsor.Text;
            Globals.CurrentInformationUpdate.Player2.sponsor = P2Sponsor.Text;
            Globals.CurrentInformationUpdate.tournamentName = tournamentNameTextbox.Text;
            Globals.CurrentInformationUpdate.round = Round.Text;
            Globals.CurrentInformationUpdate.caster = Comm2Name.Text;
            Globals.CurrentInformationUpdate.streamer = Comm1Name.Text;
            Globals.CurrentInformationUpdate.Comm1Name = Comm1Name.Text;
            Globals.CurrentInformationUpdate.Comm1Twitter = Comm1Twitter.Text;
            Globals.CurrentInformationUpdate.Comm2Name = Comm2Name.Text;
            Globals.CurrentInformationUpdate.Comm2Twitter = Comm2Twitter.Text;
            isEmpty = false;
        }
        private void switchPorts()
        {
            string p1name = Player1Name.Text;
            string p2name = Player2Name.Text;
            Player1Name.Text = p2name;
            Player2Name.Text = p1name;

            int p1score = Decimal.ToInt32(Player1Score.Value);
            int p2score = Decimal.ToInt32(Player2Score.Value);
            Player1Score.Value = p2score;
            Player2Score.Value = p1score;


            Globals.CurrentInformationUpdate.Player1.name = Player1Name.Text;
            Globals.CurrentInformationUpdate.Player2.name = Player2Name.Text;
            

            Globals.CurrentInformationUpdate.Player1.score = Decimal.ToInt32(Player1Score.Value);
            Globals.CurrentInformationUpdate.Player2.score = Decimal.ToInt32(Player2Score.Value);
        }
        public void getReplay(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
                string pattern = "https://clips-media-assets.twitch.tv/.*?.mp4";
                var match = Regex.Match(data, pattern);
                string videourl = match.Value;
                using (var client = new WebClient())
                {
                    client.DownloadFile(videourl, "replays/replay.mp4");
                }
            }

        }
        

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        public bool getRecordingStatus()
        {
            var streamStatus = _obs.GetStreamingStatus();
            if (streamStatus.IsRecording)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            Player1Score.Text = Globals.settings.streamData.Player1.score.ToString();
            Player2Score.Text = Globals.settings.streamData.Player2.score.ToString();
            FlagsCombo.Text = Globals.settings.streamData.Player1.flag.name;
            FlagsComboP2.Text = Globals.settings.streamData.Player2.flag.name;
            Round.Text = Globals.settings.streamData.round;
            tournamentNameTextbox.Text = Globals.settings.streamData.tournamentName;
            SendUpdate();
        }
        public static Dictionary<int?, string> entranthash = new Dictionary<int?, string>();
        public static Dictionary<string, string> sponsors = new Dictionary<string, string>();

        private void getParticipants()
        {
            string smashgg = Globals.settings.smashgg;
            if(smashgg == null)
            {
                return;
            }
            else
            {
                string url = "https://api.smash.gg/tournament/" + smashgg + "/event/melee-singles?expand[0]=entrants";
                var json = new WebClient().DownloadString(url);
                dynamic d = JObject.Parse(json);
                var entrants = d.entities.entrants;
                foreach(var entrant in entrants)
                {
                    int? key = (int?) entrant.id;
                    string name = entrant.name;
                    if (name.Contains("|"))
                    {
                        string[] sponsorlist = name.Split('|');
                        string sponsor = sponsorlist[0];
                        sponsor = sponsor.Replace(" ", "");
                        name = sponsorlist[1];
                        name = name.Remove(0, 1);
                        sponsors.Add(name, sponsor);
                    }
                    entranthash.Add(key, name);
                    File.AppendAllText("names.txt", name + Environment.NewLine);
                }
            }
        }
        private bool isServerUp = false;
        private bool isEmpty = false;
        private bool obs;
        private bool started = false;

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
                var delay = Task.Delay(1500).ContinueWith(_ =>
                {
                    string player1 = Globals.CurrentInformationUpdate.Player1.name;
                    string player2 = Globals.CurrentInformationUpdate.Player2.name;
                    if (Player1Name.Text.Contains("|"))
                    {
                        player1 = player1.Replace("|", " ");
                    }
                    if (Player2Name.Text.Contains("|"))
                    {
                        player2 = player2.Replace("|", " ");
                    }
                    var directory = new DirectoryInfo("recordings");
                    string myFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First().Name;
                    string newname = Globals.CurrentInformationUpdate.tournamentName + " " +player1 + " vs. " + player2 + " " + Globals.CurrentInformationUpdate.round + ".mp4";
                    System.IO.File.Move("recordings/" + myFile, "recordings/" + newname);
                    MessageBox.Show(myFile + Environment.NewLine + newname);
                    string description = "Super Smash Bros. Melee tournament " + Globals.CurrentInformationUpdate.round + " " + Globals.CurrentInformationUpdate.Player1.name + " vs. " + Globals.CurrentInformationUpdate.Player2.name;
                    string videoName = Globals.CurrentInformationUpdate.round + " " + player1 + " vs. " + player2 + " " + Globals.CurrentInformationUpdate.tournamentName;
                });
        }
        public void fullReset()
        {
            Player1Score.Value = 0;
            P1Sponsor.Text = "";
            P2Sponsor.Text = "";
            Player2Score.Value = 0;
            Player1Name.Text = "";
            Player2Name.Text = "";
            Round.Text = "";
            if (obs == true && getRecordingStatus() == true)
            {
                _obs.ToggleRecording();
                Thread resetThread = new Thread(reset);
                resetThread.Start();
            }
        }

        public void changePlayer1Name(string name)
        {
            Player1Name.Text = name;
        }

        public void changePlayer2Name(string name)
        {
            Player2Name.Text = name;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            fullReset();            
        }

        private void Player1Name_TextChanged(object sender, EventArgs e)
        {
            if (sponsors.ContainsKey(Player2Name.Text))
            {
                P2Sponsor.Text = sponsors[Player2Name.Text];
            }
            else
            {
                P2Sponsor.Text = "";
            }
        }

        private void Player1Name_Enter(object sender, EventArgs e)
        {
            Player2Name.SelectAll();
        }
        private void Player2Name_Enter(object sender, EventArgs e)
        {
            Round.SelectAll();
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
            btnToggleRecording.Show();
            try
            {
                _obs.Connect("ws://127.0.0.1:4444", "password");
                obs = true;
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
            var streamStatus = _obs.GetStreamingStatus();
            if (streamStatus.IsRecording)
            {
                onRecordingStateChange(_obs, OutputState.Started);
            }
            else
            {
                onRecordingStateChange(_obs, OutputState.Stopped);
            }
        }
        private void btnToggleRecording_Click(object sender, EventArgs e)
        {
            try
            {
                _obs.ToggleRecording();
                started = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Couldn't toggle recording");
            }
            //btnToggleRecording.Text = "Stop recording";
            //btnToggleRecording.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getCharNames();
            getSponsorNames();
        }
        private void getCharNames()
        {
            File.WriteAllText("characters.txt", String.Empty);
            try
            {
                var files = Directory.EnumerateFiles("content\\character");

                foreach (string currentFile in files)
                {
                    char[] delimiterChars = { '\\', '.' };
                    string[] words = currentFile.Split(delimiterChars);
                    string fileName = words[2];
                    File.AppendAllText("characters.txt", fileName + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string[] chars = File.ReadAllLines("characters.txt");

            P1Char.AutoCompleteCustomSource.AddRange(chars);
            P2Char.AutoCompleteCustomSource.AddRange(chars);
            return;
        }
        private void getSponsorNames()
        {
            File.WriteAllText("sponsors.txt", String.Empty);
            try
            {
                var files = Directory.EnumerateFiles("content\\sponsors");

                foreach (string currentFile in files)
                {
                    char[] delimiterChars = { '\\', '.' };
                    string[] words = currentFile.Split(delimiterChars);
                    string fileName = words[2];
                    File.AppendAllText("characters.txt", fileName + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string[] chars = File.ReadAllLines("characters.txt");

            P1Sponsor.AutoCompleteCustomSource.AddRange(chars);
            P2Sponsor.AutoCompleteCustomSource.AddRange(chars);
            return;
        }

        private void showSets_Click(object sender, EventArgs e)
        {
            List<Ticker.Set> matches = Ticker.Ticker.getSets(Globals.settings.smashgg);
            Random rng = new Random();
            Globals.CurrentInformationUpdate.ticker1 = matches[matches.Count - 1].toString();
            Globals.CurrentInformationUpdate.ticker2 = matches[matches.Count - 2].toString();
            Globals.CurrentInformationUpdate.ticker3 = matches[matches.Count - 3].toString();
            Globals.CurrentInformationUpdate.ticker4 = matches[matches.Count - 4].toString();
            Globals.CurrentInformationUpdate.ticker5 = matches[matches.Count - 5].toString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (twitchClip.Text != "")
            {
                string url = "https://clips.twitch.tv/embed?clip=" + twitchClip.Text;
                getReplay(url);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Comm1Twitter_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            getParticipants();
        }

        private void P1Char_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CrewBattle cbform = new CrewBattle();
            cbform.ShowDialog();
        }

        private void P1Sponsor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Player2Name_TextChanged(object sender, EventArgs e)
        {
            if (sponsors.ContainsKey(Player2Name.Text))
            {
                P2Sponsor.Text = sponsors[Player2Name.Text];
            }
            else
            {
                P2Sponsor.Text = "";
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            updateSmashgg();
        }
        private void updateSmashgg()
        {
            if (smashggCheck.Checked)
            {
                Ticker.Set set = Ticker.Ticker.getStreamStatus(Globals.settings.smashgg);
                string[] tags = set.getTags();
                Player1Name.Text = tags[0];
                Player2Name.Text = tags[1];
                Player1Score.Value = (int)set.score1;
                Player2Score.Value = (int)set.score2;
                Round.Text = set.round;

                Globals.CurrentInformationUpdate.round = set.round;
                Globals.CurrentInformationUpdate.Player1.name = tags[0];
                Globals.CurrentInformationUpdate.Player2.name = tags[1];
                Globals.CurrentInformationUpdate.Player1.score = (int)set.score1;
                Globals.CurrentInformationUpdate.Player2.score = (int)set.score2;
            }
        }
        private void smashggCheck_CheckedChanged(object sender, EventArgs e)
        {
            /*TimerCallback tmCallback = updateSmashgg();
            System.Threading.Timer timer = new System.Threading.Timer(tmCallback, "test", 1000, 1000);
            Console.WriteLine("Press any key to exit the sample");
            Console.ReadLine();*/
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
