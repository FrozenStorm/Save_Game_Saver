using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml;


namespace Save_Game_Saver
{
    public partial class Form1 : Form
    {
        public List<Game> GameList = new List<Game>();
        public string ErrorMessage;
        public string Data = System.DateTime.Now.Day.ToString() + "_" + System.DateTime.Now.Month.ToString() + "_" + System.DateTime.Now.Year.ToString();
        public string savedirectory = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void b_add_game_Click(object sender, EventArgs e)
        {
            GameList.Add(new Game());
            GameList.Last<Game>().Name = tb_game_name.Text;
            lb_Games.Items.Add(tb_game_name.Text);
        }
        private void b_delete_game_Click(object sender, EventArgs e)
        {
            if (lb_Games.SelectedIndex >= 0)
            {
                GameList.RemoveAt(lb_Games.SelectedIndex);
                lb_Games.Items.RemoveAt(lb_Games.SelectedIndex);
            }
        }

        private void b_add_save_game_path_Click(object sender, EventArgs e)
        {
            if (lb_Games.SelectedIndex >= 0)
            {
                GameList[lb_Games.SelectedIndex].Path.Add(tb_save_game_path.Text);
                Update_lb_Save_Game_Path();
            }
        }
        private void b_delete_save_game_path_Click(object sender, EventArgs e)
        {
            if (lb_Games.SelectedIndex >= 0)
            {
                if (lb_Save_Game_Path.SelectedIndex >= 0)
                {
                    GameList[lb_Games.SelectedIndex].Path.RemoveAt(lb_Save_Game_Path.SelectedIndex);
                    Update_lb_Save_Game_Path();
                }
            }
        }


        private void lb_Games_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_lb_Save_Game_Path();
        }

        private void Update_lb_Save_Game_Path()
        {
            lb_Save_Game_Path.Items.Clear();
            if (lb_Games.SelectedIndex >= 0)
            {
                foreach (string di in GameList[lb_Games.SelectedIndex].Path)
                {
                    lb_Save_Game_Path.Items.Add(di);
                }
            }
        }
        private void Update_lb_Games()
        {
            lb_Games.Items.Clear();
            foreach(Game g in GameList)
            {
                lb_Games.Items.Add(g.Name);
            }
        }

        private void b_browse_Save_Game_Path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_save_game_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void b_browse_save_directory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_save_directory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            b_save_config_Click(new object(), new EventArgs());
            savedirectory = tb_save_directory.Text + "\\SaveGames_" + Data;
            if (Directory.Exists(savedirectory))
            {
                if (MessageBox.Show("Pfad bereits vorhanden. Daten werden überschriben. Möchten sie trotzdem vortfahren?", "Achtung", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Directory.Delete(savedirectory, true);
                    Save_GameList();
                }
                else
                {
                    tb_status.Text = "Spielstände wurden nicht gespeichert";
                }
            }
            else
            {
                Save_GameList();
            }
        }
        private void Save_GameList()
        {
            Directory.CreateDirectory(savedirectory);
            ErrorMessage = "Folgende Daten konnten nicht gespeichert werden:\n";
            foreach (Game g in GameList)
            {
                Directory.CreateDirectory(savedirectory + "\\" + g.Name);
                foreach (string s in g.Path)
                {
                    Directory.CreateDirectory(savedirectory + "\\" + g.Name + "\\" + new FileInfo(s).Name);
                    try
                    {
                        CopyDirectory(s, savedirectory + "\\" + g.Name + "\\" + new FileInfo(s).Name);
                    }
                    catch
                    {
                        ErrorMessage = ErrorMessage + g.Name + " : " + s + "\n";
                    }
                }
            }
            if (ErrorMessage == "Folgende Daten konnten nicht gespeichert werden:\n")
            {
                tb_status.Text = "Spielstände gespeichert";
            }
            else
            {
                tb_status.Text = "Spielstände nur teilweise gespeichert";
                MessageBox.Show(ErrorMessage);
            }
        }
        private void CopyDirectory(string source, string destination)
        {
            DirectoryInfo diSource = new DirectoryInfo(source);
            foreach (DirectoryInfo di in diSource.GetDirectories("*",SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(di.FullName.Replace(source, destination));
            }
            foreach (FileInfo fi in diSource.GetFiles("*", SearchOption.AllDirectories))
            {
                File.Copy(fi.FullName, fi.FullName.Replace(source, destination));
            }
        }
        private void B_load_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Möchten sie wirklich alle Spielstände wiederherstellen\nAlle alten Spielstände gehen verloren","Warnung Datenverlust",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tb_status.Text = "Spielstände wurde wiederhergestellt";
            }
            else
            {
                tb_status.Text = "Spielstände nicht wiederhergestellt";
            }
        }
        private void Load_GameList()
        {

        }

        private void b_save_config_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream str = new FileStream(tb_save_directory.Text + "\\Config.xml", FileMode.Create);

                XmlSerializer serGame = new XmlSerializer(typeof(List<Game>));
                serGame.Serialize(str, GameList);

                str.Close();
                tb_status.Text = "Config gespeichert";
            }
            catch
            {
                tb_status.Text = "Fehler";
            }
        }       
        private void b_load_config_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(tb_save_directory.Text + "\\Config.xml");

                XmlSerializer serGame = new XmlSerializer(typeof(List<Game>));
                GameList = (List<Game>)serGame.Deserialize(sr);

                sr.Close();
                Update_lb_Games();
                Update_lb_Save_Game_Path();
                tb_status.Text = "Config geladen";
            }
            catch
            {
                tb_status.Text = "Fehler";
            }
        }
    }
}
