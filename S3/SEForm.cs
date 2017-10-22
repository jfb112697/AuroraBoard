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
    public partial class SEForm : Form
    {
        public SEForm()
        {
            InitializeComponent();
        }

        private void SEForm_Load(object sender, EventArgs e)
        {
            P1TitleSE.Text = Globals.CurrentInformationUpdate.P1TitleSE;
            P2TitleSE.Text = Globals.CurrentInformationUpdate.P2TitleSE;
            P3TitleSE.Text = Globals.CurrentInformationUpdate.P3TitleSE;
            P4TitleSE.Text = Globals.CurrentInformationUpdate.P4TitleSE;
            P5TitleSE.Text = Globals.CurrentInformationUpdate.P5TitleSE;
            P6TitleSE.Text = Globals.CurrentInformationUpdate.P6TitleSE;
            P1NameSE.Text = Globals.CurrentInformationUpdate.P1NameSE;
            P2NameSE.Text = Globals.CurrentInformationUpdate.P2NameSE;
            P3NameSE.Text = Globals.CurrentInformationUpdate.P3NameSE;
            P4NameSE.Text = Globals.CurrentInformationUpdate.P4NameSE;
            P5NameSE.Text = Globals.CurrentInformationUpdate.P5NameSE;
            P6NameSE.Text = Globals.CurrentInformationUpdate.P6NameSE;
        }

        private void updateSe_Click(object sender, EventArgs e)
        {
            Globals.CurrentInformationUpdate.P1TitleSE = P1TitleSE.Text;
            Globals.CurrentInformationUpdate.P2TitleSE = P2TitleSE.Text;
            Globals.CurrentInformationUpdate.P3TitleSE = P3TitleSE.Text;
            Globals.CurrentInformationUpdate.P4TitleSE = P4TitleSE.Text;
            Globals.CurrentInformationUpdate.P5TitleSE = P5TitleSE.Text;
            Globals.CurrentInformationUpdate.P6TitleSE = P6TitleSE.Text;
            Globals.CurrentInformationUpdate.P1NameSE = P1NameSE.Text;
            Globals.CurrentInformationUpdate.P2NameSE = P2NameSE.Text;
            Globals.CurrentInformationUpdate.P3NameSE = P3NameSE.Text;
            Globals.CurrentInformationUpdate.P4NameSE = P4NameSE.Text;
            Globals.CurrentInformationUpdate.P5NameSE = P5NameSE.Text;
            Globals.CurrentInformationUpdate.P6NameSE = P6NameSE.Text;
        }
    }
}
