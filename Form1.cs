using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WallHavenDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NotifyIcon trayIcon = new NotifyIcon();
        private void button1_Click(object sender, EventArgs e)
        {
            TrayHandler();
        }

        private void TrayHandler()
        {
            this.trayIcon = new NotifyIcon();
            trayIcon.Text = "WallHaven";
            trayIcon.Icon = Icon.ExtractAssociatedIcon("../../favicon.ico");

            // Add menu to tray icon and show it.

            trayIcon.Visible = true;

            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            MenuItem menuItem = new System.Windows.Forms.MenuItem();
            contextMenu.MenuItems.AddRange(
                new System.Windows.Forms.MenuItem[] {menuItem});

            menuItem.Index = 0;
            menuItem.Text = "Open";
            menuItem.Click += new System.EventHandler(menuItem_Click);
            trayIcon.Click += new System.EventHandler(menuItem_Click);

            trayIcon.ContextMenu = contextMenu;
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            Visible = true; 
            ShowInTaskbar = true;
            this.trayIcon.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (refreshTimer.Enabled)
            {
                label1.Text = "Running";
            }
            else
            {
                label1.Text = "Stopped";
            }
            
           
            minutesRadioButton.Checked = true;
            centeredRadioButton.Checked = true;
        }

        private void timeTrackBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (refreshTimer.Enabled)
            {
                refreshTimer.Stop();
                label1.Text = "Stopped";
            }
            else
            {
                refreshTimer.Start();
                label1.Text = "Running";
            }
            
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            var link = GenerateLink();

            if (tiledRadioButton.Checked)
            {
                Set(link, Style.Tile);
            }
            else if(centeredRadioButton.Checked)
            {
                Set(link, Style.Center);
            }
            else if (stretchedRadioButton.Checked)
            {
                Set(link, Style.Stretch);
            }
            else if (fitRadioButton.Checked)
            {
                Set(link, Style.Fit);
            }
            else if (fillRadioButton.Checked)
            {
                Set(link, Style.Fill);
            }
            else if (spanRadioButton.Checked)
            {
                Set(link, Style.Span);
            }
            else
            {
                Set(link, Style.Center);
            }
        }

        private static Uri GenerateLink()
        {
            Random r = new Random();
            Uri link = new Uri("https://alpha.wallhaven.cc/wallpaper/" + r.Next(0, 435265));
            return link;
        }

        public enum Style : int
        {
            
            
            
            Fit, Fill, Span, Stretch, Tile, Center
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        public static void Set(Uri uri, Style style)
        {

            try
            {
                Uri imageUri;
                string result;
                using (var client = new WebClient())
                {
                     result = client.DownloadString(uri);
                }
                Regex regex = new Regex("(wallpapers.wallhaven.cc\\/wallpapers\\/full\\/wallhaven+-\\d*.jpg)");

                MatchCollection mc = regex.Matches(result);
                string a = "https://"+ mc[0].Value.Replace('}', ' ').Replace('{', ' ').Trim();
                imageUri = new Uri(a);
               

                System.IO.Stream s = new System.Net.WebClient().OpenRead(imageUri.ToString());
                
                System.Drawing.Image img = System.Drawing.Image.FromStream(s);
                string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
                img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                if (style == Style.Fill)
                {
                    key.SetValue(@"WallpaperStyle", 10.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }
                if (style == Style.Fit)
                {
                    key.SetValue(@"WallpaperStyle", 6.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }
                if (style == Style.Span) // Windows 8 or newer only!
                {
                    key.SetValue(@"WallpaperStyle", 22.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }
                if (style == Style.Stretch)
                {
                    key.SetValue(@"WallpaperStyle", 2.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }
                if (style == Style.Tile)
                {
                    key.SetValue(@"WallpaperStyle", 0.ToString());
                    key.SetValue(@"TileWallpaper", 1.ToString());
                }
                if (style == Style.Center)
                {
                    key.SetValue(@"WallpaperStyle", 0.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0,
                    tempPath,
                    SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch (Exception e)
            {
                var link = GenerateLink();
                Set(uri = link, Style.Fit);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (minutesRadioButton.Checked)
            {
                refreshTimer.Interval = int.Parse(textBox1.Text) * 60000;
            }
            else
            {
                refreshTimer.Interval = int.Parse(textBox1.Text) * 1000;
            }
           
        }

        private void fitRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var link = GenerateLink();
            if (tiledRadioButton.Checked)
            {
                Set(link, Style.Tile);
            }
            else if (centeredRadioButton.Checked)
            {
                Set(link, Style.Center);
            }
            else if (stretchedRadioButton.Checked)
            {
                Set(link, Style.Stretch);
            }
            else if (fitRadioButton.Checked)
            {
                Set(link, Style.Fit);
            }
            else if (fillRadioButton.Checked)
            {
                Set(link, Style.Fill);
            }
            else if (spanRadioButton.Checked)
            {
                Set(link, Style.Span);
            }
            else
            {
                Set(link, Style.Center);
            }
        }
    }
}
