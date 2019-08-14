using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

/*
 * STUDENT NAME:WeiYang Chen
 * STUDENT ID:300728876
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        Random random = new Random();
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private string GetRamdomFLName(string _fileName)
        {

            List<string> _listFromFile = File.ReadAllLines(_fileName).ToList();


            int _listLength = _listFromFile.Count;


            string _result = _listFromFile[random.Next(_listLength)];

            return _result;
        }
        private string GetRamdomSkill(string _fileName)
        {

            List<string> _listFromFile = File.ReadAllLines(_fileName).ToList();


            int _listLength = _listFromFile.Count;


            string _result = _listFromFile[random.Next(_listLength)];

            return _result;
        }
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            string firstName = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\firstNames.txt"));
            string lastName = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\lastNames.txt"));
            Program.characterPortfolio.Identity.FirstName = GetRamdomFLName(firstName);
            FirstNameDataLabel.Text = Program.characterPortfolio.Identity.FirstName;
            Program.characterPortfolio.Identity.LastName = GetRamdomFLName(lastName);
            LastNameDataLabel.Text = Program.characterPortfolio.Identity.LastName;
            infoFNamelable.Text = FirstNameDataLabel.Text;
            infoLNamelable.Text = LastNameDataLabel.Text;
        }
        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "ext files (*.txt)|*.txt|All files(*.*)|*>**";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult dr = saveFileDialog1.ShowDialog();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "c:\\";
            op.Filter = "ext files (*.txt)|*.txt|All files(*.*)|*>**";
            op.FilterIndex = 2;

            if (op.ShowDialog() == DialogResult.OK)
            {
                string filePath = op.FileName;
                string fileName = op.SafeFileName;
            }

        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int str = random.Next(1, 51);
            int dex = random.Next(1, 51);
            int end = random.Next(1, 51);
            int intel = random.Next(1, 51);
            int edu = random.Next(1, 51);
            int soc = random.Next(1, 51);
            StrengthDataLabel.Text = str.ToString();
            DexterityDataLabel.Text = dex.ToString();
            EnduranceDataLabel.Text = end.ToString();
            IntellectDataLabel.Text = intel.ToString();
            EducationDataLabel.Text = edu.ToString();
            SocialStandingDataLabel.Text = soc.ToString();
            infoAbilitiesLable1.Text = StrengthDataLabel.Text;
            infoAbilitiesLable2.Text = DexterityDataLabel.Text;
            infoAbilitiesLable3.Text = EnduranceDataLabel.Text;
            infoAbilitiesLable4.Text = IntellectDataLabel.Text;
            infoAbilitiesLable5.Text = EducationDataLabel.Text;
            infoAbilitiesLable6.Text = SocialStandingDataLabel.Text;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "c:\\";
            op.Filter = "ext files (*.txt)|*.txt|All files(*.*)|*>**";
            op.FilterIndex = 2;

            if (op.ShowDialog() == DialogResult.OK)
            {
                string filePath = op.FileName;
                string fileName = op.SafeFileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "ext files (*.txt)|*.txt|All files(*.*)|*>**";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult dr = saveFileDialog1.ShowDialog();
        }

        private void GenerateSkillButten_Click(object sender, EventArgs e)
        {
            string skill1 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\skills.txt"));
            Program.characterPortfolio.Identity.Skill1 = GetRamdomSkill(skill1);
            skillLabel1.Text = Program.characterPortfolio.Identity.Skill1;
            infoSkillLable1.Text = skillLabel1.Text;
            string skill2 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\skills.txt"));
            Program.characterPortfolio.Identity.Skill2 = GetRamdomSkill(skill2);
            skillLabel2.Text = Program.characterPortfolio.Identity.Skill2;
            infoSkillLable2.Text = skillLabel2.Text;
            string skill3 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\skills.txt"));
            Program.characterPortfolio.Identity.Skill3 = GetRamdomSkill(skill3);
            skillLabel3.Text = Program.characterPortfolio.Identity.Skill3;
            infoSkillLable3.Text = skillLabel3.Text;
            string skill4 = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\skills.txt"));
            Program.characterPortfolio.Identity.Skill4 = GetRamdomSkill(skill4);
            skillLabel4.Text = Program.characterPortfolio.Identity.Skill4;
            infoSkillLable4.Text = skillLabel4.Text;

        }
    }
}