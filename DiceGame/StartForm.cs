using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        { 
            SettingsForm settingsWindow = new SettingsForm();
            settingsWindow.Size = new Size(700, 600);
            // Hide Start form
            this.Hide();
            // Show Settings Form
            settingsWindow.Show();
        }

        private void LoadGuide(object sender, EventArgs e)
        {
            GuideForm guideWindow = new GuideForm();
            // Hide Start Form
            guideWindow.Size = new Size(2445, 1377);
            this.Hide();
            // Show Guide Form
            guideWindow.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
