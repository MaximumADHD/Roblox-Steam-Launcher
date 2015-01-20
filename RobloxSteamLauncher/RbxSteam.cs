using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace RobloxSteamLauncher
{
    public partial class RbxSteam : Form
    {
        public RbxSteam()
        {
            InitializeComponent();
        }

        WebClient http = new System.Net.WebClient();

        private void RbxSteam_Load(object sender, EventArgs e)
        {
            // Lets see if we can find RobloxPlayerBeta.exe before-hand to save the user time.
            // If we can't, we'll at least move as close as we can to it.

            string myDir = Environment.GetEnvironmentVariable("LocalAppData");
            string version = http.DownloadString("http://setup.roblox.com/version");
            int count = 0;
            if (version != null)
            {
                List<string> paths = new List<string>() { "Roblox", "Versions", version, "RobloxPlayerBeta.exe" }
                foreach (string path in paths)
                {   string nextDir = Path.Combine(myDir, path);
                    bool isExe = path.Contains("exe");
                    if (isExe && File.Exists(nextDir) || Directory.Exists(nextDir))
                    {
                        myDir = nextDir;
                        Console.WriteLine("Found: " + nextDir);
                        count = count + 1;
                    }
                }
            }
            if (count == 4)
            {
                this.directoryInput.Text = myDir;
            }
            this.searchDialog.InitialDirectory = myDir;
        }
        
        private void ShowError(string errorMsg)
        {
            MessageBox.Show(errorMsg, "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (this.directoryInput.Text != ""){
                string text = this.placeInput.Text;
                int placeId = 0;
                bool isValid = int.TryParse(text, out placeId);
                if (isValid == true)
                {
                    // Check with roblox to see if this is an actual launchable game.
                    string requestGame = http.DownloadString("http://www.roblox.com/Game/PlaceLauncher.ashx?request=RequestGame&placeId=" + text);
                    if (requestGame.Contains("JoinPlace=") || requestGame.Contains("Game/Join.ashx")) // If its joinable, it should contain one of these.
                    {
                        this.Hide();
                        Process Roblox = Process.Start(this.directoryInput.Text, " --id " + text);
                        Roblox.WaitForExit();
                        this.Show();
                    }
                    else
                    {
                        ShowError("Unable to join game! Request was ignored by Roblox. \n(Are you sure this is an actual PlaceId?)");
                    }
                }
                else
                {
                    ShowError("Invalid PlaceId Input!");
                    this.placeInput.Text = "";
                }
            }
            else
            {
                ShowError("Roblox's client exe location hasn't been set!");
            }
        }
        bool searchingFor = false;
        private void searchFor_Click(object sender, EventArgs e)
        {
            if (searchingFor == false)
            {
                searchingFor = true;
                this.searchDialog.ShowDialog();
                searchingFor = false;
            }
        }

        private void searchDialog_FileOk(object sender, CancelEventArgs e)
        {
            string directory = this.searchDialog.FileName;
            if (directory.Contains("Roblox"))
            {
                if (directory.Contains("RobloxPlayerBeta"))
                {
                    this.directoryInput.Text = directory;
                }
                else
                {
                    ShowError("The exe should be named 'RobloxPlayerBeta' (Try again!)");
                }
            }
            else
            {
                ShowError("This directory contains no reference to Roblox. Assuming its invalid. (Try again!)");
            };
        }
    }
}
