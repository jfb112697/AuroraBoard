using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3
{
    public partial class CrewBattle : Form
    {
        public CrewBattle()
        {
            InitializeComponent();
        }

        private void CrewBattle_Load(object sender, EventArgs e)
        {
            updateForm();
        }
        private void sendUpdate()
        {
            Globals.CurrentInformationUpdate.Crew1Name = Crew1Name.Text;
            Globals.CurrentInformationUpdate.Crew1P1Name = Crew1P1Name.Text;
            Globals.CurrentInformationUpdate.Crew1P2Name = Crew1P2Name.Text;
            Globals.CurrentInformationUpdate.Crew1P3Name = Crew1P3Name.Text;
            Globals.CurrentInformationUpdate.Crew1P4Name = Crew1P4Name.Text;
            Globals.CurrentInformationUpdate.Crew1P1Stock = Crew1P1Stock.Value;
            Globals.CurrentInformationUpdate.Crew1P2Stock = Crew1P2Stock.Value;
            Globals.CurrentInformationUpdate.Crew1P3Stock = Crew1P3Stock.Value;
            Globals.CurrentInformationUpdate.Crew1P4Stock = Crew1P4Stock.Value;

            Globals.CurrentInformationUpdate.Crew2Name = Crew2Name.Text;
            Globals.CurrentInformationUpdate.Crew2P1Name = Crew2P1Name.Text;
            Globals.CurrentInformationUpdate.Crew2P2Name = Crew2P2Name.Text;
            Globals.CurrentInformationUpdate.Crew2P3Name = Crew2P3Name.Text;
            Globals.CurrentInformationUpdate.Crew2P4Name = Crew2P4Name.Text;
            Globals.CurrentInformationUpdate.Crew2P1Stock = Crew2P1Stock.Value;
            Globals.CurrentInformationUpdate.Crew2P2Stock = Crew2P2Stock.Value;
            Globals.CurrentInformationUpdate.Crew2P3Stock = Crew2P3Stock.Value;
            Globals.CurrentInformationUpdate.Crew2P4Stock = Crew2P4Stock.Value;
        }
        private void updateForm()
        {
            Crew1Name.Text = Globals.CurrentInformationUpdate.Crew1Name;
            Crew1P1Name.Text = Globals.CurrentInformationUpdate.Crew1P1Name;
            Crew1P2Name.Text = Globals.CurrentInformationUpdate.Crew1P2Name;
            Crew1P3Name.Text = Globals.CurrentInformationUpdate.Crew1P3Name;
            Crew1P4Name.Text = Globals.CurrentInformationUpdate.Crew1P4Name;
            Crew1P1Stock.Value = Globals.CurrentInformationUpdate.Crew1P1Stock;
            Crew1P2Stock.Value = Globals.CurrentInformationUpdate.Crew1P2Stock;
            Crew1P3Stock.Value = Globals.CurrentInformationUpdate.Crew1P3Stock;
            Crew1P4Stock.Value = Globals.CurrentInformationUpdate.Crew1P4Stock;

            Crew2Name.Text = Globals.CurrentInformationUpdate.Crew2Name;
            Crew2P1Name.Text = Globals.CurrentInformationUpdate.Crew2P1Name;
            Crew2P2Name.Text = Globals.CurrentInformationUpdate.Crew2P2Name;
            Crew2P3Name.Text = Globals.CurrentInformationUpdate.Crew2P3Name;
            Crew2P4Name.Text = Globals.CurrentInformationUpdate.Crew2P4Name;
            Crew2P1Stock.Value = Globals.CurrentInformationUpdate.Crew2P1Stock;
            Crew2P2Stock.Value = Globals.CurrentInformationUpdate.Crew2P2Stock;
            Crew2P3Stock.Value = Globals.CurrentInformationUpdate.Crew2P3Stock;
            Crew2P4Stock.Value = Globals.CurrentInformationUpdate.Crew2P4Stock;
        }

        private void cbSendUpdate_Click(object sender, EventArgs e)
        {
            sendUpdate();
        }
    }
}
