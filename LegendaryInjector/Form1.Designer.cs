
namespace LegendaryForceInstaller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_dumpgames = new System.Windows.Forms.ComboBox();
            this.btn_dumpgame = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_GameFolder = new System.Windows.Forms.TextBox();
            this.tb_MetadataJson = new System.Windows.Forms.TextBox();
            this.tb_InstalledJson = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_InstalledJson = new System.Windows.Forms.Button();
            this.btn_MetadataJson = new System.Windows.Forms.Button();
            this.btn_GameFolder = new System.Windows.Forms.Button();
            this.btn_inject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dumpgame);
            this.groupBox1.Controls.Add(this.cb_dumpgames);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dump game";
            // 
            // cb_dumpgames
            // 
            this.cb_dumpgames.FormattingEnabled = true;
            this.cb_dumpgames.Location = new System.Drawing.Point(6, 19);
            this.cb_dumpgames.Name = "cb_dumpgames";
            this.cb_dumpgames.Size = new System.Drawing.Size(352, 21);
            this.cb_dumpgames.TabIndex = 1;
            // 
            // btn_dumpgame
            // 
            this.btn_dumpgame.Location = new System.Drawing.Point(6, 46);
            this.btn_dumpgame.Name = "btn_dumpgame";
            this.btn_dumpgame.Size = new System.Drawing.Size(352, 23);
            this.btn_dumpgame.TabIndex = 2;
            this.btn_dumpgame.Text = "Dump";
            this.btn_dumpgame.UseVisualStyleBackColor = true;
            this.btn_dumpgame.Click += new System.EventHandler(this.btn_dumpgame_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files|*.json";
            // 
            // tb_GameFolder
            // 
            this.tb_GameFolder.Location = new System.Drawing.Point(93, 75);
            this.tb_GameFolder.Name = "tb_GameFolder";
            this.tb_GameFolder.Size = new System.Drawing.Size(184, 20);
            this.tb_GameFolder.TabIndex = 2;
            // 
            // tb_MetadataJson
            // 
            this.tb_MetadataJson.Location = new System.Drawing.Point(93, 49);
            this.tb_MetadataJson.Name = "tb_MetadataJson";
            this.tb_MetadataJson.Size = new System.Drawing.Size(184, 20);
            this.tb_MetadataJson.TabIndex = 3;
            // 
            // tb_InstalledJson
            // 
            this.tb_InstalledJson.Location = new System.Drawing.Point(93, 23);
            this.tb_InstalledJson.Name = "tb_InstalledJson";
            this.tb_InstalledJson.Size = new System.Drawing.Size(184, 20);
            this.tb_InstalledJson.TabIndex = 4;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Installed.json:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "metadata.json:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Game folder:";
            // 
            // btn_InstalledJson
            // 
            this.btn_InstalledJson.Location = new System.Drawing.Point(283, 21);
            this.btn_InstalledJson.Name = "btn_InstalledJson";
            this.btn_InstalledJson.Size = new System.Drawing.Size(75, 23);
            this.btn_InstalledJson.TabIndex = 8;
            this.btn_InstalledJson.Text = "Browse";
            this.btn_InstalledJson.UseVisualStyleBackColor = true;
            this.btn_InstalledJson.Click += new System.EventHandler(this.btn_InstalledJson_Click);
            // 
            // btn_MetadataJson
            // 
            this.btn_MetadataJson.Location = new System.Drawing.Point(283, 47);
            this.btn_MetadataJson.Name = "btn_MetadataJson";
            this.btn_MetadataJson.Size = new System.Drawing.Size(75, 23);
            this.btn_MetadataJson.TabIndex = 9;
            this.btn_MetadataJson.Text = "Browse";
            this.btn_MetadataJson.UseVisualStyleBackColor = true;
            this.btn_MetadataJson.Click += new System.EventHandler(this.btn_MetadataJson_Click);
            // 
            // btn_GameFolder
            // 
            this.btn_GameFolder.Location = new System.Drawing.Point(283, 73);
            this.btn_GameFolder.Name = "btn_GameFolder";
            this.btn_GameFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_GameFolder.TabIndex = 10;
            this.btn_GameFolder.Text = "Browse";
            this.btn_GameFolder.UseVisualStyleBackColor = true;
            this.btn_GameFolder.Click += new System.EventHandler(this.btn_GameFolder_Click);
            // 
            // btn_inject
            // 
            this.btn_inject.Location = new System.Drawing.Point(9, 103);
            this.btn_inject.Name = "btn_inject";
            this.btn_inject.Size = new System.Drawing.Size(349, 23);
            this.btn_inject.TabIndex = 11;
            this.btn_inject.Text = "Inject";
            this.btn_inject.UseVisualStyleBackColor = true;
            this.btn_inject.Click += new System.EventHandler(this.btn_inject_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_inject);
            this.groupBox2.Controls.Add(this.tb_GameFolder);
            this.groupBox2.Controls.Add(this.btn_GameFolder);
            this.groupBox2.Controls.Add(this.tb_MetadataJson);
            this.groupBox2.Controls.Add(this.btn_MetadataJson);
            this.groupBox2.Controls.Add(this.tb_InstalledJson);
            this.groupBox2.Controls.Add(this.btn_InstalledJson);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 137);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inject game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LegendaryInjector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_dumpgames;
        private System.Windows.Forms.Button btn_dumpgame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_GameFolder;
        private System.Windows.Forms.TextBox tb_MetadataJson;
        private System.Windows.Forms.TextBox tb_InstalledJson;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_InstalledJson;
        private System.Windows.Forms.Button btn_MetadataJson;
        private System.Windows.Forms.Button btn_GameFolder;
        private System.Windows.Forms.Button btn_inject;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

