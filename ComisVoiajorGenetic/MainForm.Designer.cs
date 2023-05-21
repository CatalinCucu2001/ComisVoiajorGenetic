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
            this.trackBarDelay = new System.Windows.Forms.TrackBar();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelBeforeFilter = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).BeginInit();
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
            this.buttonDrawAllChromosomes.Location = new System.Drawing.Point(1018, 179);
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
            this.buttonNextGeneration.Location = new System.Drawing.Point(1018, 219);
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
            this.buttonFilterChromosomes.Location = new System.Drawing.Point(1019, 248);
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
            this.checkBoxEditMode.Location = new System.Drawing.Point(1030, 116);
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
            this.buttonInitGenetic.Location = new System.Drawing.Point(1018, 150);
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
            this.checkBoxTimer.Location = new System.Drawing.Point(1030, 278);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(100, 17);
            this.checkBoxTimer.TabIndex = 9;
            this.checkBoxTimer.Text = "AutoGeneration";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
            // 
            // trackBarTimer
            // 
            this.trackBarTimer.Location = new System.Drawing.Point(1019, 342);
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
            // trackBarDelay
            // 
            this.trackBarDelay.Location = new System.Drawing.Point(1018, 419);
            this.trackBarDelay.Maximum = 500;
            this.trackBarDelay.Name = "trackBarDelay";
            this.trackBarDelay.Size = new System.Drawing.Size(127, 45);
            this.trackBarDelay.TabIndex = 11;
            this.trackBarDelay.TickFrequency = 10;
            this.trackBarDelay.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDelay.Value = 250;
            this.trackBarDelay.Scroll += new System.EventHandler(this.trackBarDelay_Scroll);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(1032, 313);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(79, 26);
            this.labelTimer.TabIndex = 12;
            this.labelTimer.Text = "Delay Between\r\nGenerations\r\n";
            // 
            // labelBeforeFilter
            // 
            this.labelBeforeFilter.AutoSize = true;
            this.labelBeforeFilter.Location = new System.Drawing.Point(1032, 390);
            this.labelBeforeFilter.Name = "labelBeforeFilter";
            this.labelBeforeFilter.Size = new System.Drawing.Size(93, 26);
            this.labelBeforeFilter.TabIndex = 13;
            this.labelBeforeFilter.Text = "Delay Before Filter\r\n(App will freeze)\r\n";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(1212, 28);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(272, 359);
            this.textBoxStatus.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(1209, 12);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Status:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1916, 1013);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelBeforeFilter);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.trackBarDelay);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CityMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarDelay;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelBeforeFilter;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
    }
}

