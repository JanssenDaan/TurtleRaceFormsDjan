namespace TurtleRaceFormsDjan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentSpeedDjan = new System.Windows.Forms.Label();
            this.lblRaceTimeDjan = new System.Windows.Forms.Label();
            this.lblLapsFinishedDjan = new System.Windows.Forms.Label();
            this.lblCurrentSpeedValueDjan = new System.Windows.Forms.Label();
            this.lblLapsFinishedValueDjan = new System.Windows.Forms.Label();
            this.lblRaceTimeValueDjan = new System.Windows.Forms.Label();
            this.gbxValues = new System.Windows.Forms.GroupBox();
            this.btnStartDjan = new System.Windows.Forms.Button();
            this.btnResetDjan = new System.Windows.Forms.Button();
            this.btnPictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbxValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentSpeedDjan
            // 
            this.lblCurrentSpeedDjan.AutoSize = true;
            this.lblCurrentSpeedDjan.Location = new System.Drawing.Point(7, 19);
            this.lblCurrentSpeedDjan.Name = "lblCurrentSpeedDjan";
            this.lblCurrentSpeedDjan.Size = new System.Drawing.Size(85, 15);
            this.lblCurrentSpeedDjan.TabIndex = 0;
            this.lblCurrentSpeedDjan.Text = "Current Speed:";
            // 
            // lblRaceTimeDjan
            // 
            this.lblRaceTimeDjan.AutoSize = true;
            this.lblRaceTimeDjan.Location = new System.Drawing.Point(7, 93);
            this.lblRaceTimeDjan.Name = "lblRaceTimeDjan";
            this.lblRaceTimeDjan.Size = new System.Drawing.Size(64, 15);
            this.lblRaceTimeDjan.TabIndex = 1;
            this.lblRaceTimeDjan.Text = "Race Time:";
            // 
            // lblLapsFinishedDjan
            // 
            this.lblLapsFinishedDjan.AutoSize = true;
            this.lblLapsFinishedDjan.Location = new System.Drawing.Point(7, 55);
            this.lblLapsFinishedDjan.Name = "lblLapsFinishedDjan";
            this.lblLapsFinishedDjan.Size = new System.Drawing.Size(84, 15);
            this.lblLapsFinishedDjan.TabIndex = 2;
            this.lblLapsFinishedDjan.Text = "Laps Finished: ";
            // 
            // lblCurrentSpeedValueDjan
            // 
            this.lblCurrentSpeedValueDjan.AutoSize = true;
            this.lblCurrentSpeedValueDjan.Location = new System.Drawing.Point(132, 19);
            this.lblCurrentSpeedValueDjan.Name = "lblCurrentSpeedValueDjan";
            this.lblCurrentSpeedValueDjan.Size = new System.Drawing.Size(13, 15);
            this.lblCurrentSpeedValueDjan.TabIndex = 3;
            this.lblCurrentSpeedValueDjan.Text = "0";
            // 
            // lblLapsFinishedValueDjan
            // 
            this.lblLapsFinishedValueDjan.AutoSize = true;
            this.lblLapsFinishedValueDjan.Location = new System.Drawing.Point(132, 55);
            this.lblLapsFinishedValueDjan.Name = "lblLapsFinishedValueDjan";
            this.lblLapsFinishedValueDjan.Size = new System.Drawing.Size(13, 15);
            this.lblLapsFinishedValueDjan.TabIndex = 4;
            this.lblLapsFinishedValueDjan.Text = "0";
            // 
            // lblRaceTimeValueDjan
            // 
            this.lblRaceTimeValueDjan.AutoSize = true;
            this.lblRaceTimeValueDjan.Location = new System.Drawing.Point(132, 93);
            this.lblRaceTimeValueDjan.Name = "lblRaceTimeValueDjan";
            this.lblRaceTimeValueDjan.Size = new System.Drawing.Size(13, 15);
            this.lblRaceTimeValueDjan.TabIndex = 5;
            this.lblRaceTimeValueDjan.Text = "0";
            // 
            // gbxValues
            // 
            this.gbxValues.Controls.Add(this.lblCurrentSpeedDjan);
            this.gbxValues.Controls.Add(this.lblRaceTimeValueDjan);
            this.gbxValues.Controls.Add(this.lblRaceTimeDjan);
            this.gbxValues.Controls.Add(this.lblLapsFinishedValueDjan);
            this.gbxValues.Controls.Add(this.lblLapsFinishedDjan);
            this.gbxValues.Controls.Add(this.lblCurrentSpeedValueDjan);
            this.gbxValues.Location = new System.Drawing.Point(596, 12);
            this.gbxValues.Name = "gbxValues";
            this.gbxValues.Size = new System.Drawing.Size(192, 130);
            this.gbxValues.TabIndex = 6;
            this.gbxValues.TabStop = false;
            this.gbxValues.Text = "Values";
            // 
            // btnStartDjan
            // 
            this.btnStartDjan.Location = new System.Drawing.Point(11, 14);
            this.btnStartDjan.Name = "btnStartDjan";
            this.btnStartDjan.Size = new System.Drawing.Size(150, 150);
            this.btnStartDjan.TabIndex = 7;
            this.btnStartDjan.Text = "Start";
            this.btnStartDjan.UseVisualStyleBackColor = true;
            this.btnStartDjan.Click += new System.EventHandler(this.btnStartDjan_Click);
            // 
            // btnResetDjan
            // 
            this.btnResetDjan.Location = new System.Drawing.Point(167, 14);
            this.btnResetDjan.Name = "btnResetDjan";
            this.btnResetDjan.Size = new System.Drawing.Size(150, 150);
            this.btnResetDjan.TabIndex = 8;
            this.btnResetDjan.Text = "Reset";
            this.btnResetDjan.UseVisualStyleBackColor = true;
            // 
            // btnPictureBox
            // 
            this.btnPictureBox.BackgroundImage = global::TurtleRaceFormsDjan.Properties.Resources.turtle;
            this.btnPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPictureBox.Image = global::TurtleRaceFormsDjan.Properties.Resources.turtle;
            this.btnPictureBox.Location = new System.Drawing.Point(12, 170);
            this.btnPictureBox.Name = "btnPictureBox";
            this.btnPictureBox.Size = new System.Drawing.Size(135, 127);
            this.btnPictureBox.TabIndex = 9;
            this.btnPictureBox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(777, 126);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPictureBox);
            this.Controls.Add(this.btnResetDjan);
            this.Controls.Add(this.btnStartDjan);
            this.Controls.Add(this.gbxValues);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxValues.ResumeLayout(false);
            this.gbxValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblCurrentSpeedDjan;
        private Label lblRaceTimeDjan;
        private Label lblLapsFinishedDjan;
        private Label lblCurrentSpeedValueDjan;
        private Label lblLapsFinishedValueDjan;
        private Label lblRaceTimeValueDjan;
        private GroupBox gbxValues;
        private Button btnStartDjan;
        private Button btnResetDjan;
        private PictureBox btnPictureBox;
        private RichTextBox richTextBox1;
    }
}