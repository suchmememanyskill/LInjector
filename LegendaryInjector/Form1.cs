using LegendaryForceInstaller.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendaryForceInstaller
{
    public partial class Form1 : Form
    {
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
        }
        private string GetLegendaryPath() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config", "legendary");
        private Dictionary<string, InstalledJson> installedGames;

        public Form1()
        {
            InitializeComponent();
            string path = Path.Combine(GetLegendaryPath(), "installed.json");
            if (!File.Exists(path))
            {
                installedGames = new Dictionary<string, InstalledJson>();
                return;
            }

            installedGames = JsonConvert.DeserializeObject<Dictionary<string, InstalledJson>>(File.ReadAllText(path));
            foreach (var x in installedGames)
                cb_dumpgames.Items.Add(x.Value.AppName);
        }

        private void btn_dumpgame_Click(object sender, EventArgs e)
        {
            string text = cb_dumpgames.Text;
            if (installedGames.TryGetValue(text, out InstalledJson value))
            {
                Directory.CreateDirectory($"./{text}");
                File.Copy(Path.Combine(GetLegendaryPath(), "metadata", $"{value.AppName}.json"), $"./{text}/{value.AppName}.json", true);
                //string manifestPath = Directory.GetFiles(Path.Combine(GetLegendaryPath(), "manifests")).FirstOrDefault(x => Path.GetFileName(x).StartsWith(text));
                //File.Copy(manifestPath, $"./{text}/{Path.GetFileName(manifestPath)}", true);
                Dictionary<string, InstalledJson> temp = new Dictionary<string, InstalledJson>();
                temp.Add(text, value);
                File.WriteAllText($"./{text}/installed.json", JsonConvert.SerializeObject(temp));
                CopyFilesRecursively(value.InstallPath, $"./{text}/{text}");
            }
        }

        private void btn_InstalledJson_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tb_InstalledJson.Text = openFileDialog1.FileName;
        }

        private void btn_MetadataJson_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tb_MetadataJson.Text = openFileDialog1.FileName;
        }

        private void btn_GameFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_GameFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_inject_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tb_InstalledJson.Text) || !File.Exists(tb_MetadataJson.Text) || !Directory.Exists(tb_GameFolder.Text))
                return;

            File.Copy(tb_MetadataJson.Text, Path.Combine(GetLegendaryPath(), "metadata", Path.GetFileName(tb_MetadataJson.Text)), true);
            Dictionary<string, InstalledJson> toAdd = JsonConvert.DeserializeObject<Dictionary<string, InstalledJson>>(File.ReadAllText(tb_InstalledJson.Text));
            toAdd.First().Value.InstallPath = tb_GameFolder.Text;
            if (installedGames.ContainsKey(toAdd.First().Key))
                installedGames[toAdd.First().Key] = toAdd.First().Value;
            else
                installedGames.Add(toAdd.First().Key, toAdd.First().Value);


            File.WriteAllText(Path.Combine(GetLegendaryPath(), "installed.json"), JsonConvert.SerializeObject(installedGames));
            btn_inject.Text = $"Injected {toAdd.First().Value.Title}";
        }
    }
}
