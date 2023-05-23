namespace ComisVoiajorGenetic
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CityMap = new System.Windows.Forms.PictureBox();
            this.buttonClearMap = new System.Windows.Forms.Button();
            this.buttonDrawAllCities = new System.Windows.Forms.Button();
            this.buttonDrawAllRelations = new System.Windows.Forms.Button();
            this.buttonDrawAllChromosomes = new System.Windows.Forms.Button();
            this.buttonNextGeneration = new System.Windows.Forms.Button();
            this.buttonFilterChromosomes = new System.Windows.Forms.Button();
            this.timerGeneration = new System.Windows.Forms.Timer(this.components);
            this.checkBoxEditMode = new System.Windows.Forms.CheckBox();
            this.buttonInitGenetic = new System.Windows.Forms.Button();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.trackBarTimer = new System.Windows.Forms.TrackBar();
            this.labelTimer = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonRandomRelations = new System.Windows.Forms.Button();
            this.trackBarChanceRelation = new System.Windows.Forms.TrackBar();
            this.labelRandomRelation = new System.Windows.Forms.Label();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.buttonResetRelations = new System.Windows.Forms.Button();
            this.buttonDrawAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CityMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChanceRelation)).BeginInit();
            this.SuspendLayout();
            // 
            // CityMap
            // 
            this.CityMap.BackColor = System.Drawing.SystemColors.Control;
            this.CityMap.Image = ((System.Drawing.Image)(resources.GetObject("CityMap.Image")));
            this.CityMap.Location = new System.Drawing.Point(12, 12);
            this.CityMap.Name = "CityMap";
            this.CityMap.Size = new System.Drawing.Size(1000, 989);
            this.CityMap.TabIndex = 0;
            this.CityMap.TabStop = false;
            this.CityMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CityMap_MouseDown);
            // 
            // buttonClearMap
            // 
            this.buttonClearMap.Location = new System.Drawing.Point(1018, 12);
            this.buttonClearMap.Name = "buttonClearMap";
            this.buttonClearMap.Size = new System.Drawing.Size(129, 23);
            this.buttonClearMap.TabIndex = 1;
            this.buttonClearMap.Text = "Clear Map";
            this.buttonClearMap.UseVisualStyleBackColor = true;
            this.buttonClearMap.Click += new System.EventHandler(this.buttonClearMap_Click);
            // 
            // buttonDrawAllCities
            // 
            this.buttonDrawAllCities.Location = new System.Drawing.Point(1018, 41);
            this.buttonDrawAllCities.Name = "buttonDrawAllCities";
            this.buttonDrawAllCities.Size = new System.Drawing.Size(129, 23);
            this.buttonDrawAllCities.TabIndex = 2;
            this.buttonDrawAllCities.Text = "Draw All Cities";
            this.buttonDrawAllCities.UseVisualStyleBackColor = true;
            this.buttonDrawAllCities.Click += new System.EventHandler(this.buttonDrawAllCities_Click);
            // 
            // buttonDrawAllRelations
            // 
            this.buttonDrawAllRelations.Location = new System.Drawing.Point(1019, 71);
            this.buttonDrawAllRelations.Name = "buttonDrawAllRelations";
            this.buttonDrawAllRelations.Size = new System.Drawing.Size(128, 23);
            this.buttonDrawAllRelations.TabIndex = 3;
            this.buttonDrawAllRelations.Text = "Draw All Relations";
            this.buttonDrawAllRelations.UseVisualStyleBackColor = true;
            this.buttonDrawAllRelations.Click += new System.EventHandler(this.buttonDrawAllRelations_Click);
            // 
            // buttonDrawAllChromosomes
            // 
            this.buttonDrawAllChromosomes.Enabled = false;
            this.buttonDrawAllChromosomes.Location = new System.Drawing.Point(1018, 199);
            this.buttonDrawAllChromosomes.Name = "buttonDrawAllChromosomes";
            this.buttonDrawAllChromosomes.Size = new System.Drawing.Size(129, 23);
            this.buttonDrawAllChromosomes.TabIndex = 4;
            this.buttonDrawAllChromosomes.Text = "Draw All Chromosomes";
            this.buttonDrawAllChromosomes.UseVisualStyleBackColor = true;
            this.buttonDrawAllChromosomes.Click += new System.EventHandler(this.buttonDrawAllChromosomes_Click);
            // 
            // buttonNextGeneration
            // 
            this.buttonNextGeneration.Enabled = false;
            this.buttonNextGeneration.Location = new System.Drawing.Point(1018, 239);
            this.buttonNextGeneration.Name = "buttonNextGeneration";
            this.buttonNextGeneration.Size = new System.Drawing.Size(129, 23);
            this.buttonNextGeneration.TabIndex = 5;
            this.buttonNextGeneration.Text = "Next Generation";
            this.buttonNextGeneration.UseVisualStyleBackColor = true;
            this.buttonNextGeneration.Click += new System.EventHandler(this.buttonNextGeneration_Click);
            // 
            // buttonFilterChromosomes
            // 
            this.buttonFilterChromosomes.Enabled = false;
            this.buttonFilterChromosomes.Location = new System.Drawing.Point(1019, 268);
            this.buttonFilterChromosomes.Name = "buttonFilterChromosomes";
            this.buttonFilterChromosomes.Size = new System.Drawing.Size(127, 23);
            this.buttonFilterChromosomes.TabIndex = 6;
            this.buttonFilterChromosomes.Text = "Filter Chromosomes";
            this.buttonFilterChromosomes.UseVisualStyleBackColor = true;
            this.buttonFilterChromosomes.Click += new System.EventHandler(this.buttonFilterChromosomes_Click);
            // 
            // timerGeneration
            // 
            this.timerGeneration.Interval = 500;
            this.timerGeneration.Tick += new System.EventHandler(this.timerGeneration_Tick);
            // 
            // checkBoxEditMode
            // 
            this.checkBoxEditMode.AutoSize = true;
            this.checkBoxEditMode.Checked = true;
            this.checkBoxEditMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEditMode.Location = new System.Drawing.Point(1030, 136);
            this.checkBoxEditMode.Name = "checkBoxEditMode";
            this.checkBoxEditMode.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEditMode.TabIndex = 7;
            this.checkBoxEditMode.Text = "Edit Mode";
            this.checkBoxEditMode.UseVisualStyleBackColor = true;
            this.checkBoxEditMode.CheckedChanged += new System.EventHandler(this.checkBoxEditMode_CheckedChanged);
            // 
            // buttonInitGenetic
            // 
            this.buttonInitGenetic.Enabled = false;
            this.buttonInitGenetic.Location = new System.Drawing.Point(1018, 170);
            this.buttonInitGenetic.Name = "buttonInitGenetic";
            this.buttonInitGenetic.Size = new System.Drawing.Size(128, 23);
            this.buttonInitGenetic.TabIndex = 8;
            this.buttonInitGenetic.Text = "Init Genetic";
            this.buttonInitGenetic.UseVisualStyleBackColor = true;
            this.buttonInitGenetic.Click += new System.EventHandler(this.buttonInitGenetic_Click);
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(1030, 298);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(100, 17);
            this.checkBoxTimer.TabIndex = 9;
            this.checkBoxTimer.Text = "AutoGeneration";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
            // 
            // trackBarTimer
            // 
            this.trackBarTimer.Location = new System.Drawing.Point(1019, 362);
            this.trackBarTimer.Maximum = 1000;
            this.trackBarTimer.Minimum = 1;
            this.trackBarTimer.Name = "trackBarTimer";
            this.trackBarTimer.Size = new System.Drawing.Size(127, 45);
            this.trackBarTimer.TabIndex = 10;
            this.trackBarTimer.TickFrequency = 10;
            this.trackBarTimer.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarTimer.Value = 500;
            this.trackBarTimer.Scroll += new System.EventHandler(this.trackBarTimer_Scroll);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(1032, 333);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(79, 26);
            this.labelTimer.TabIndex = 12;
            this.labelTimer.Text = "Delay Between\r\nGenerations\r\n";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(1152, 28);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(736, 436);
            this.textBoxStatus.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(1153, 12);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Status:";
            // 
            // buttonRandomRelations
            // 
            this.buttonRandomRelations.Location = new System.Drawing.Point(1018, 481);
            this.buttonRandomRelations.Name = "buttonRandomRelations";
            this.buttonRandomRelations.Size = new System.Drawing.Size(127, 23);
            this.buttonRandomRelations.TabIndex = 16;
            this.buttonRandomRelations.Text = "Add Random Relations";
            this.buttonRandomRelations.UseVisualStyleBackColor = true;
            this.buttonRandomRelations.Click += new System.EventHandler(this.buttonRandomRelations_Click);
            // 
            // trackBarChanceRelation
            // 
            this.trackBarChanceRelation.Location = new System.Drawing.Point(1018, 528);
            this.trackBarChanceRelation.Maximum = 100;
            this.trackBarChanceRelation.Name = "trackBarChanceRelation";
            this.trackBarChanceRelation.Size = new System.Drawing.Size(127, 45);
            this.trackBarChanceRelation.TabIndex = 17;
            this.trackBarChanceRelation.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarChanceRelation.Scroll += new System.EventHandler(this.trackBarChanceRelation_Scroll);
            // 
            // labelRandomRelation
            // 
            this.labelRandomRelation.AutoSize = true;
            this.labelRandomRelation.Location = new System.Drawing.Point(1015, 512);
            this.labelRandomRelation.Name = "labelRandomRelation";
            this.labelRandomRelation.Size = new System.Drawing.Size(132, 13);
            this.labelRandomRelation.TabIndex = 18;
            this.labelRandomRelation.Text = "0 Add relation chance 100";
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Location = new System.Drawing.Point(1019, 579);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(126, 23);
            this.buttonResetAll.TabIndex = 19;
            this.buttonResetAll.Text = "Reset ALL";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // buttonResetRelations
            // 
            this.buttonResetRelations.Location = new System.Drawing.Point(1019, 608);
            this.buttonResetRelations.Name = "buttonResetRelations";
            this.buttonResetRelations.Size = new System.Drawing.Size(126, 23);
            this.buttonResetRelations.TabIndex = 20;
            this.buttonResetRelations.Text = "Reset Relations";
            this.buttonResetRelations.UseVisualStyleBackColor = true;
            this.buttonResetRelations.Click += new System.EventHandler(this.buttonResetRelations_Click);
            // 
            // buttonDrawAll
            // 
            this.buttonDrawAll.Location = new System.Drawing.Point(1019, 100);
            this.buttonDrawAll.Name = "buttonDrawAll";
            this.buttonDrawAll.Size = new System.Drawing.Size(126, 23);
            this.buttonDrawAll.TabIndex = 21;
            this.buttonDrawAll.Text = "Draw ALL";
            this.buttonDrawAll.UseVisualStyleBackColor = true;
            this.buttonDrawAll.Click += new System.EventHandler(this.buttonDrawAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1916, 1013);
            this.Controls.Add(this.buttonDrawAll);
            this.Controls.Add(this.buttonResetRelations);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.labelRandomRelation);
            this.Controls.Add(this.trackBarChanceRelation);
            this.Controls.Add(this.buttonRandomRelations);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.trackBarTimer);
            this.Controls.Add(this.checkBoxTimer);
            this.Controls.Add(this.buttonInitGenetic);
            this.Controls.Add(this.checkBoxEditMode);
            this.Controls.Add(this.buttonFilterChromosomes);
            this.Controls.Add(this.buttonNextGeneration);
            this.Controls.Add(this.buttonDrawAllChromosomes);
            this.Controls.Add(this.buttonDrawAllRelations);
            this.Controls.Add(this.buttonDrawAllCities);
            this.Controls.Add(this.buttonClearMap);
            this.Controls.Add(this.CityMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CityMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChanceRelation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CityMap;
        private System.Windows.Forms.Button buttonClearMap;
        private System.Windows.Forms.Button buttonDrawAllCities;
        private System.Windows.Forms.Button buttonDrawAllRelations;
        private System.Windows.Forms.Button buttonDrawAllChromosomes;
        private System.Windows.Forms.Button buttonNextGeneration;
        private System.Windows.Forms.Button buttonFilterChromosomes;
        private System.Windows.Forms.CheckBox checkBoxEditMode;
        private System.Windows.Forms.Button buttonInitGenetic;
        public System.Windows.Forms.Timer timerGeneration;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.TrackBar trackBarTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonRandomRelations;
        private System.Windows.Forms.TrackBar trackBarChanceRelation;
        private System.Windows.Forms.Label labelRandomRelation;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.Button buttonResetRelations;
        private System.Windows.Forms.Button buttonDrawAll;
    }
}

