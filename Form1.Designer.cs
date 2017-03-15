namespace WallHavenDesktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hideButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.minutesRadioButton = new System.Windows.Forms.RadioButton();
            this.secondsRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spanRadioButton = new System.Windows.Forms.RadioButton();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.fitRadioButton = new System.Windows.Forms.RadioButton();
            this.stretchedRadioButton = new System.Windows.Forms.RadioButton();
            this.centeredRadioButton = new System.Windows.Forms.RadioButton();
            this.tiledRadioButton = new System.Windows.Forms.RadioButton();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(197, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 0;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // minutesRadioButton
            // 
            this.minutesRadioButton.AutoSize = true;
            this.minutesRadioButton.Location = new System.Drawing.Point(166, 98);
            this.minutesRadioButton.Name = "minutesRadioButton";
            this.minutesRadioButton.Size = new System.Drawing.Size(62, 17);
            this.minutesRadioButton.TabIndex = 6;
            this.minutesRadioButton.TabStop = true;
            this.minutesRadioButton.Text = "Minutes";
            this.minutesRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondsRadioButton
            // 
            this.secondsRadioButton.AutoSize = true;
            this.secondsRadioButton.Location = new System.Drawing.Point(93, 98);
            this.secondsRadioButton.Name = "secondsRadioButton";
            this.secondsRadioButton.Size = new System.Drawing.Size(67, 17);
            this.secondsRadioButton.TabIndex = 7;
            this.secondsRadioButton.TabStop = true;
            this.secondsRadioButton.Text = "Seconds";
            this.secondsRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spanRadioButton);
            this.groupBox1.Controls.Add(this.fillRadioButton);
            this.groupBox1.Controls.Add(this.fitRadioButton);
            this.groupBox1.Controls.Add(this.stretchedRadioButton);
            this.groupBox1.Controls.Add(this.centeredRadioButton);
            this.groupBox1.Controls.Add(this.tiledRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Style";
            // 
            // spanRadioButton
            // 
            this.spanRadioButton.AutoSize = true;
            this.spanRadioButton.Location = new System.Drawing.Point(6, 66);
            this.spanRadioButton.Name = "spanRadioButton";
            this.spanRadioButton.Size = new System.Drawing.Size(131, 17);
            this.spanRadioButton.TabIndex = 5;
            this.spanRadioButton.TabStop = true;
            this.spanRadioButton.Text = "Span (Win 8 or newer)";
            this.spanRadioButton.UseVisualStyleBackColor = true;
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Location = new System.Drawing.Point(85, 43);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(37, 17);
            this.fillRadioButton.TabIndex = 4;
            this.fillRadioButton.TabStop = true;
            this.fillRadioButton.Text = "Fill";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            // 
            // fitRadioButton
            // 
            this.fitRadioButton.AutoSize = true;
            this.fitRadioButton.Location = new System.Drawing.Point(6, 43);
            this.fitRadioButton.Name = "fitRadioButton";
            this.fitRadioButton.Size = new System.Drawing.Size(36, 17);
            this.fitRadioButton.TabIndex = 3;
            this.fitRadioButton.TabStop = true;
            this.fitRadioButton.Text = "Fit";
            this.fitRadioButton.UseVisualStyleBackColor = true;
            this.fitRadioButton.CheckedChanged += new System.EventHandler(this.fitRadioButton_CheckedChanged);
            // 
            // stretchedRadioButton
            // 
            this.stretchedRadioButton.AutoSize = true;
            this.stretchedRadioButton.Location = new System.Drawing.Point(183, 20);
            this.stretchedRadioButton.Name = "stretchedRadioButton";
            this.stretchedRadioButton.Size = new System.Drawing.Size(71, 17);
            this.stretchedRadioButton.TabIndex = 2;
            this.stretchedRadioButton.TabStop = true;
            this.stretchedRadioButton.Text = "Stretched";
            this.stretchedRadioButton.UseVisualStyleBackColor = true;
            // 
            // centeredRadioButton
            // 
            this.centeredRadioButton.AutoSize = true;
            this.centeredRadioButton.Location = new System.Drawing.Point(85, 20);
            this.centeredRadioButton.Name = "centeredRadioButton";
            this.centeredRadioButton.Size = new System.Drawing.Size(68, 17);
            this.centeredRadioButton.TabIndex = 1;
            this.centeredRadioButton.TabStop = true;
            this.centeredRadioButton.Text = "Centered";
            this.centeredRadioButton.UseVisualStyleBackColor = true;
            // 
            // tiledRadioButton
            // 
            this.tiledRadioButton.AutoSize = true;
            this.tiledRadioButton.Location = new System.Drawing.Point(7, 20);
            this.tiledRadioButton.Name = "tiledRadioButton";
            this.tiledRadioButton.Size = new System.Drawing.Size(48, 17);
            this.tiledRadioButton.TabIndex = 0;
            this.tiledRadioButton.TabStop = true;
            this.tiledRadioButton.Text = "Tiled";
            this.tiledRadioButton.UseVisualStyleBackColor = true;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(12, 55);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 9;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(97, 55);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.secondsRadioButton);
            this.Controls.Add(this.minutesRadioButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hideButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WallHaven";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton minutesRadioButton;
        private System.Windows.Forms.RadioButton secondsRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton stretchedRadioButton;
        private System.Windows.Forms.RadioButton centeredRadioButton;
        private System.Windows.Forms.RadioButton tiledRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.RadioButton fitRadioButton;
        private System.Windows.Forms.RadioButton spanRadioButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
    }
}

