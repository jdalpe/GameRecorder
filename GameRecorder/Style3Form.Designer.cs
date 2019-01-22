namespace GameRecorder
{
    partial class Style3Form
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
            this.statTB = new System.Windows.Forms.TextBox();
            this.naissanceTB = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.descTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stat de base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lieu de naissance et lieu actuel";
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
            // statTB
            // 
            this.statTB.Location = new System.Drawing.Point(24, 99);
            this.statTB.Multiline = true;
            this.statTB.Name = "statTB";
            this.statTB.Size = new System.Drawing.Size(386, 96);
            this.statTB.TabIndex = 6;
            // 
            // naissanceTB
            // 
            this.naissanceTB.Location = new System.Drawing.Point(24, 228);
            this.naissanceTB.Multiline = true;
            this.naissanceTB.Name = "naissanceTB";
            this.naissanceTB.Size = new System.Drawing.Size(386, 75);
            this.naissanceTB.TabIndex = 7;
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
            // descTB
            // 
            this.descTB.Location = new System.Drawing.Point(24, 331);
            this.descTB.Multiline = true;
            this.descTB.Name = "descTB";
            this.descTB.Size = new System.Drawing.Size(386, 142);
            this.descTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // Style3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 524);
            this.Controls.Add(this.descTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.naissanceTB);
            this.Controls.Add(this.statTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Style3Form";
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
        private System.Windows.Forms.TextBox statTB;
        private System.Windows.Forms.TextBox naissanceTB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox descTB;
        private System.Windows.Forms.Label label5;
    }
}