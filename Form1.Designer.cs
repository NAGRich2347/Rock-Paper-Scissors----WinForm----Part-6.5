namespace Rock__Paper__Scissors____WinForm____Part_6._5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msg1 = new System.Windows.Forms.TextBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // msg1
            // 
            this.msg1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msg1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msg1.Location = new System.Drawing.Point(12, 12);
            this.msg1.Multiline = true;
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(318, 63);
            this.msg1.TabIndex = 0;
            this.msg1.Text = "Welcome to Rock, Paper, Scissors! Please choose an option!";
            this.msg1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picBox1
            // 
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.Location = new System.Drawing.Point(12, 92);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(152, 145);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // picBox2
            // 
            this.picBox2.Image = ((System.Drawing.Image)(resources.GetObject("picBox2.Image")));
            this.picBox2.Location = new System.Drawing.Point(170, 92);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(160, 145);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 2;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.Image = global::Rock__Paper__Scissors____WinForm____Part_6._5.Properties.Resources.Scissors;
            this.picBox3.Location = new System.Drawing.Point(336, 92);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(148, 145);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 4;
            this.picBox3.TabStop = false;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radRock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radRock.Location = new System.Drawing.Point(6, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 5;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = false;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radPaper.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radPaper.Location = new System.Drawing.Point(6, 42);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 6;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = false;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radScissors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radScissors.Location = new System.Drawing.Point(6, 65);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 7;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = false;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Controls.Add(this.radScissors);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpPlayerChoice.Location = new System.Drawing.Point(42, 255);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(86, 100);
            this.grpPlayerChoice.TabIndex = 8;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            this.grpPlayerChoice.Enter += new System.EventHandler(this.grpPlayerChoice_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(350, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 63);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(197, 254);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(107, 100);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 10;
            this.imgPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(350, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.msg1);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msg1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label label1;
    }
}

