namespace Save_Game_Saver
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Games = new System.Windows.Forms.ListBox();
            this.lb_Save_Game_Path = new System.Windows.Forms.ListBox();
            this.tb_game_name = new System.Windows.Forms.TextBox();
            this.b_add_game = new System.Windows.Forms.Button();
            this.b_add_save_game_path = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_save_game_path = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.tb_save_directory = new System.Windows.Forms.TextBox();
            this.b_save_config = new System.Windows.Forms.Button();
            this.b_load_config = new System.Windows.Forms.Button();
            this.b_browse_Save_Game_Path = new System.Windows.Forms.Button();
            this.b_browse_save_directory = new System.Windows.Forms.Button();
            this.b_delete_save_game_path = new System.Windows.Forms.Button();
            this.b_delete_game = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Games
            // 
            this.lb_Games.FormattingEnabled = true;
            this.lb_Games.Location = new System.Drawing.Point(12, 12);
            this.lb_Games.Name = "lb_Games";
            this.lb_Games.Size = new System.Drawing.Size(258, 251);
            this.lb_Games.TabIndex = 0;
            this.lb_Games.SelectedIndexChanged += new System.EventHandler(this.lb_Games_SelectedIndexChanged);
            // 
            // lb_Save_Game_Path
            // 
            this.lb_Save_Game_Path.FormattingEnabled = true;
            this.lb_Save_Game_Path.Location = new System.Drawing.Point(276, 12);
            this.lb_Save_Game_Path.Name = "lb_Save_Game_Path";
            this.lb_Save_Game_Path.Size = new System.Drawing.Size(258, 251);
            this.lb_Save_Game_Path.TabIndex = 1;
            // 
            // tb_game_name
            // 
            this.tb_game_name.Location = new System.Drawing.Point(88, 269);
            this.tb_game_name.Name = "tb_game_name";
            this.tb_game_name.Size = new System.Drawing.Size(182, 20);
            this.tb_game_name.TabIndex = 2;
            this.tb_game_name.Text = "Game Name";
            // 
            // b_add_game
            // 
            this.b_add_game.Location = new System.Drawing.Point(110, 295);
            this.b_add_game.Name = "b_add_game";
            this.b_add_game.Size = new System.Drawing.Size(70, 23);
            this.b_add_game.TabIndex = 3;
            this.b_add_game.Text = "Add Game";
            this.b_add_game.UseVisualStyleBackColor = true;
            this.b_add_game.Click += new System.EventHandler(this.b_add_game_Click);
            // 
            // b_add_save_game_path
            // 
            this.b_add_save_game_path.Location = new System.Drawing.Point(380, 295);
            this.b_add_save_game_path.Name = "b_add_save_game_path";
            this.b_add_save_game_path.Size = new System.Drawing.Size(69, 23);
            this.b_add_save_game_path.TabIndex = 4;
            this.b_add_save_game_path.Text = "Add Path";
            this.b_add_save_game_path.UseVisualStyleBackColor = true;
            this.b_add_save_game_path.Click += new System.EventHandler(this.b_add_save_game_path_Click);
            // 
            // tb_save_game_path
            // 
            this.tb_save_game_path.Location = new System.Drawing.Point(367, 269);
            this.tb_save_game_path.Name = "tb_save_game_path";
            this.tb_save_game_path.Size = new System.Drawing.Size(131, 20);
            this.tb_save_game_path.TabIndex = 5;
            this.tb_save_game_path.Text = "Save-Game-Pfad";
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(459, 352);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 7;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // tb_save_directory
            // 
            this.tb_save_directory.Location = new System.Drawing.Point(88, 326);
            this.tb_save_directory.Name = "tb_save_directory";
            this.tb_save_directory.Size = new System.Drawing.Size(410, 20);
            this.tb_save_directory.TabIndex = 8;
            this.tb_save_directory.Text = "SaveGames";
            // 
            // b_save_config
            // 
            this.b_save_config.Location = new System.Drawing.Point(297, 352);
            this.b_save_config.Name = "b_save_config";
            this.b_save_config.Size = new System.Drawing.Size(75, 23);
            this.b_save_config.TabIndex = 9;
            this.b_save_config.Text = "Save Config";
            this.b_save_config.UseVisualStyleBackColor = true;
            this.b_save_config.Click += new System.EventHandler(this.b_save_config_Click);
            // 
            // b_load_config
            // 
            this.b_load_config.Location = new System.Drawing.Point(216, 352);
            this.b_load_config.Name = "b_load_config";
            this.b_load_config.Size = new System.Drawing.Size(75, 23);
            this.b_load_config.TabIndex = 10;
            this.b_load_config.Text = "Load Config";
            this.b_load_config.UseVisualStyleBackColor = true;
            this.b_load_config.Click += new System.EventHandler(this.b_load_config_Click);
            // 
            // b_browse_Save_Game_Path
            // 
            this.b_browse_Save_Game_Path.Location = new System.Drawing.Point(504, 269);
            this.b_browse_Save_Game_Path.Name = "b_browse_Save_Game_Path";
            this.b_browse_Save_Game_Path.Size = new System.Drawing.Size(30, 20);
            this.b_browse_Save_Game_Path.TabIndex = 12;
            this.b_browse_Save_Game_Path.Text = "...";
            this.b_browse_Save_Game_Path.UseVisualStyleBackColor = true;
            this.b_browse_Save_Game_Path.Click += new System.EventHandler(this.b_browse_Save_Game_Path_Click);
            // 
            // b_browse_save_directory
            // 
            this.b_browse_save_directory.Location = new System.Drawing.Point(504, 326);
            this.b_browse_save_directory.Name = "b_browse_save_directory";
            this.b_browse_save_directory.Size = new System.Drawing.Size(30, 20);
            this.b_browse_save_directory.TabIndex = 13;
            this.b_browse_save_directory.Text = "...";
            this.b_browse_save_directory.UseVisualStyleBackColor = true;
            this.b_browse_save_directory.Click += new System.EventHandler(this.b_browse_save_directory_Click);
            // 
            // b_delete_save_game_path
            // 
            this.b_delete_save_game_path.Location = new System.Drawing.Point(455, 295);
            this.b_delete_save_game_path.Name = "b_delete_save_game_path";
            this.b_delete_save_game_path.Size = new System.Drawing.Size(79, 23);
            this.b_delete_save_game_path.TabIndex = 14;
            this.b_delete_save_game_path.Text = "Delete Path";
            this.b_delete_save_game_path.UseVisualStyleBackColor = true;
            this.b_delete_save_game_path.Click += new System.EventHandler(this.b_delete_save_game_path_Click);
            // 
            // b_delete_game
            // 
            this.b_delete_game.Location = new System.Drawing.Point(186, 295);
            this.b_delete_game.Name = "b_delete_game";
            this.b_delete_game.Size = new System.Drawing.Size(84, 23);
            this.b_delete_game.TabIndex = 15;
            this.b_delete_game.Text = "Delete Game";
            this.b_delete_game.UseVisualStyleBackColor = true;
            this.b_delete_game.Click += new System.EventHandler(this.b_delete_game_Click);
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(378, 352);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(75, 23);
            this.b_load.TabIndex = 17;
            this.b_load.Text = "Load";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.B_load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Save/Load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Game Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Save Game Path";
            // 
            // tb_status
            // 
            this.tb_status.Enabled = false;
            this.tb_status.Location = new System.Drawing.Point(91, 381);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(446, 20);
            this.tb_status.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.b_delete_game);
            this.Controls.Add(this.b_delete_save_game_path);
            this.Controls.Add(this.b_browse_save_directory);
            this.Controls.Add(this.b_browse_Save_Game_Path);
            this.Controls.Add(this.b_load_config);
            this.Controls.Add(this.b_save_config);
            this.Controls.Add(this.tb_save_directory);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.tb_save_game_path);
            this.Controls.Add(this.b_add_save_game_path);
            this.Controls.Add(this.b_add_game);
            this.Controls.Add(this.tb_game_name);
            this.Controls.Add(this.lb_Save_Game_Path);
            this.Controls.Add(this.lb_Games);
            this.Name = "Form1";
            this.Text = "Save-Game-Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Games;
        private System.Windows.Forms.ListBox lb_Save_Game_Path;
        private System.Windows.Forms.TextBox tb_game_name;
        private System.Windows.Forms.Button b_add_game;
        private System.Windows.Forms.Button b_add_save_game_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tb_save_game_path;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TextBox tb_save_directory;
        private System.Windows.Forms.Button b_save_config;
        private System.Windows.Forms.Button b_load_config;
        private System.Windows.Forms.Button b_browse_Save_Game_Path;
        private System.Windows.Forms.Button b_browse_save_directory;
        private System.Windows.Forms.Button b_delete_save_game_path;
        private System.Windows.Forms.Button b_delete_game;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label5;
    }
}

