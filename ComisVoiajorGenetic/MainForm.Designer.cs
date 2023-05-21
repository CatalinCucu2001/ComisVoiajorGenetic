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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timerGeneration = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CityMap)).BeginInit();
            this.SuspendLayout();
            // 
            // CityMap
            // 
            this.CityMap.BackColor = System.Drawing.SystemColors.Control;
            this.CityMap.Image = ((System.Drawing.Image)(resources.GetObject("CityMap.Image")));
            this.CityMap.Location = new System.Drawing.Point(12, 12);
            this.CityMap.Name = "CityMap";
            this.CityMap.Size = new System.Drawing.Size(1056, 1056);
            this.CityMap.TabIndex = 0;
            this.CityMap.TabStop = false;
            this.CityMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CityMap_MouseDown);
            // 
            // buttonClearMap
            // 
            this.buttonClearMap.Location = new System.Drawing.Point(1074, 12);
            this.buttonClearMap.Name = "buttonClearMap";
            this.buttonClearMap.Size = new System.Drawing.Size(102, 23);
            this.buttonClearMap.TabIndex = 1;
            this.buttonClearMap.Text = "Clear Map";
            this.buttonClearMap.UseVisualStyleBackColor = true;
            this.buttonClearMap.Click += new System.EventHandler(this.buttonClearMap_Click);
            // 
            // buttonDrawAllCities
            // 
            this.buttonDrawAllCities.Location = new System.Drawing.Point(1074, 41);
            this.buttonDrawAllCities.Name = "buttonDrawAllCities";
            this.buttonDrawAllCities.Size = new System.Drawing.Size(102, 23);
            this.buttonDrawAllCities.TabIndex = 2;
            this.buttonDrawAllCities.Text = "Draw All Cities";
            this.buttonDrawAllCities.UseVisualStyleBackColor = true;
            this.buttonDrawAllCities.Click += new System.EventHandler(this.buttonDrawAllCities_Click);
            // 
            // buttonDrawAllRelations
            // 
            this.buttonDrawAllRelations.Location = new System.Drawing.Point(1075, 71);
            this.buttonDrawAllRelations.Name = "buttonDrawAllRelations";
            this.buttonDrawAllRelations.Size = new System.Drawing.Size(101, 23);
            this.buttonDrawAllRelations.TabIndex = 3;
            this.buttonDrawAllRelations.Text = "Draw All Relations";
            this.buttonDrawAllRelations.UseVisualStyleBackColor = true;
            this.buttonDrawAllRelations.Click += new System.EventHandler(this.buttonDrawAllRelations_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1075, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1075, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1075, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // timerGeneration
            // 
            this.timerGeneration.Interval = 2500;
            this.timerGeneration.Tick += new System.EventHandler(this.timerGeneration_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDrawAllRelations);
            this.Controls.Add(this.buttonDrawAllCities);
            this.Controls.Add(this.buttonClearMap);
            this.Controls.Add(this.CityMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CityMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CityMap;
        private System.Windows.Forms.Button buttonClearMap;
        private System.Windows.Forms.Button buttonDrawAllCities;
        private System.Windows.Forms.Button buttonDrawAllRelations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timerGeneration;
    }
}

