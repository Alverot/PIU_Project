namespace WindowsFormsInterface
{
    partial class LoadGame
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
            this.save1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoSave1 = new System.Windows.Forms.Label();
            this.InfoSave2 = new System.Windows.Forms.Label();
            this.InfoSave3 = new System.Windows.Forms.Label();
            this.ErorLable = new System.Windows.Forms.Label();
            this.SelectedSave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(157, 68);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(97, 39);
            this.save1.TabIndex = 0;
            this.save1.Text = "Save 1";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(157, 140);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(97, 39);
            this.save2.TabIndex = 1;
            this.save2.Text = "Save 2";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // save3
            // 
            this.save3.Location = new System.Drawing.Point(157, 213);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(97, 39);
            this.save3.TabIndex = 2;
            this.save3.Text = "Save 3";
            this.save3.UseVisualStyleBackColor = true;
            this.save3.Click += new System.EventHandler(this.save3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(752, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.LoadGame_Load);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BackButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the save file that you whant to load\r\n";
            // 
            // InfoSave1
            // 
            this.InfoSave1.AutoSize = true;
            this.InfoSave1.Location = new System.Drawing.Point(304, 79);
            this.InfoSave1.Name = "InfoSave1";
            this.InfoSave1.Size = new System.Drawing.Size(7, 16);
            this.InfoSave1.TabIndex = 6;
            this.InfoSave1.Text = "\r\n";
            // 
            // InfoSave2
            // 
            this.InfoSave2.AutoSize = true;
            this.InfoSave2.Location = new System.Drawing.Point(304, 151);
            this.InfoSave2.Name = "InfoSave2";
            this.InfoSave2.Size = new System.Drawing.Size(0, 16);
            this.InfoSave2.TabIndex = 7;
            // 
            // InfoSave3
            // 
            this.InfoSave3.AutoSize = true;
            this.InfoSave3.Location = new System.Drawing.Point(304, 224);
            this.InfoSave3.Name = "InfoSave3";
            this.InfoSave3.Size = new System.Drawing.Size(0, 16);
            this.InfoSave3.TabIndex = 8;
            // 
            // ErorLable
            // 
            this.ErorLable.AutoSize = true;
            this.ErorLable.Location = new System.Drawing.Point(749, 296);
            this.ErorLable.Name = "ErorLable";
            this.ErorLable.Size = new System.Drawing.Size(0, 16);
            this.ErorLable.TabIndex = 9;
            // 
            // SelectedSave
            // 
            this.SelectedSave.AutoSize = true;
            this.SelectedSave.Location = new System.Drawing.Point(749, 236);
            this.SelectedSave.Name = "SelectedSave";
            this.SelectedSave.Size = new System.Drawing.Size(7, 16);
            this.SelectedSave.TabIndex = 10;
            this.SelectedSave.Text = "\r\n";
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.SelectedSave);
            this.Controls.Add(this.ErorLable);
            this.Controls.Add(this.InfoSave3);
            this.Controls.Add(this.InfoSave2);
            this.Controls.Add(this.InfoSave1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.save3);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.save1);
            this.Name = "LoadGame";
            this.Text = "LoadGame";
            this.Load += new System.EventHandler(this.LoadGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoSave1;
        private System.Windows.Forms.Label InfoSave2;
        private System.Windows.Forms.Label InfoSave3;
        private System.Windows.Forms.Label ErorLable;
        private System.Windows.Forms.Label SelectedSave;
    }
}