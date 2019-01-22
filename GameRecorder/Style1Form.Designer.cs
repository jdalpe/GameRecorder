namespace GameRecorder
{
    partial class Style1Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.descJoueurTB = new System.Windows.Forms.TextBox();
            this.descDMTB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description Joueur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description DM:";
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(24, 41);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(243, 20);
            this.nomTB.TabIndex = 4;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(326, 41);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(72, 20);
            this.dateTB.TabIndex = 5;
            // 
            // descJoueurTB
            // 
            this.descJoueurTB.Location = new System.Drawing.Point(24, 99);
            this.descJoueurTB.Multiline = true;
            this.descJoueurTB.Name = "descJoueurTB";
            this.descJoueurTB.Size = new System.Drawing.Size(386, 162);
            this.descJoueurTB.TabIndex = 6;
            // 
            // descDMTB
            // 
            this.descDMTB.Location = new System.Drawing.Point(24, 291);
            this.descDMTB.Multiline = true;
            this.descDMTB.Name = "descDMTB";
            this.descDMTB.Size = new System.Drawing.Size(386, 162);
            this.descDMTB.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(166, 479);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(78, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Style1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 524);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.descDMTB);
            this.Controls.Add(this.descJoueurTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Style1Form";
            this.Text = "Exemple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.TextBox descJoueurTB;
        private System.Windows.Forms.TextBox descDMTB;
        private System.Windows.Forms.Button saveBtn;
    }
}