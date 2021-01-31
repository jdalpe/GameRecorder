namespace GameRecorder
{
    partial class Style4Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.informationTB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chercherBtn = new System.Windows.Forms.Button();
            this.mediaPB = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Information";
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(32, 50);
            this.nomTB.Margin = new System.Windows.Forms.Padding(4);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(323, 22);
            this.nomTB.TabIndex = 4;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(435, 50);
            this.dateTB.Margin = new System.Windows.Forms.Padding(4);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(95, 22);
            this.dateTB.TabIndex = 5;
            // 
            // informationTB
            // 
            this.informationTB.Location = new System.Drawing.Point(32, 122);
            this.informationTB.Margin = new System.Windows.Forms.Padding(4);
            this.informationTB.Multiline = true;
            this.informationTB.Name = "informationTB";
            this.informationTB.Size = new System.Drawing.Size(513, 201);
            this.informationTB.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(221, 590);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(104, 28);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Media";
            // 
            // chercherBtn
            // 
            this.chercherBtn.Location = new System.Drawing.Point(31, 361);
            this.chercherBtn.Name = "chercherBtn";
            this.chercherBtn.Size = new System.Drawing.Size(105, 36);
            this.chercherBtn.TabIndex = 10;
            this.chercherBtn.Text = "Chercher";
            this.chercherBtn.UseVisualStyleBackColor = true;
            this.chercherBtn.Click += new System.EventHandler(this.chercherBtn_Click);
            // 
            // mediaPB
            // 
            this.mediaPB.Location = new System.Drawing.Point(142, 342);
            this.mediaPB.Name = "mediaPB";
            this.mediaPB.Size = new System.Drawing.Size(388, 241);
            this.mediaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediaPB.TabIndex = 11;
            this.mediaPB.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Style4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 645);
            this.Controls.Add(this.mediaPB);
            this.Controls.Add(this.chercherBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.informationTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Style4Form";
            this.Text = "Exemple";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.TextBox informationTB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chercherBtn;
        private System.Windows.Forms.PictureBox mediaPB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}