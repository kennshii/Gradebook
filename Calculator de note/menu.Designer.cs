namespace Calculator_de_note
{
    partial class StartForm
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
            this.clasaInput = new System.Windows.Forms.TextBox();
            this.numeStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseCheck = new System.Windows.Forms.CheckBox();
            this.logButton = new System.Windows.Forms.Button();
            this.realButton = new System.Windows.Forms.RadioButton();
            this.umanButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clasaInput
            // 
            this.clasaInput.Location = new System.Drawing.Point(144, 81);
            this.clasaInput.Name = "clasaInput";
            this.clasaInput.Size = new System.Drawing.Size(160, 27);
            this.clasaInput.TabIndex = 13;
            // 
            // numeStudent
            // 
            this.numeStudent.Location = new System.Drawing.Point(144, 47);
            this.numeStudent.Name = "numeStudent";
            this.numeStudent.Size = new System.Drawing.Size(160, 27);
            this.numeStudent.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clasa:";
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(58, 50);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(56, 20);
            this.nume.TabIndex = 9;
            this.nume.Text = "Nume: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date student";
            // 
            // licenseCheck
            // 
            this.licenseCheck.AutoSize = true;
            this.licenseCheck.Location = new System.Drawing.Point(58, 149);
            this.licenseCheck.Name = "licenseCheck";
            this.licenseCheck.Size = new System.Drawing.Size(253, 44);
            this.licenseCheck.TabIndex = 15;
            this.licenseCheck.Text = "Sunt de acord cu termenii licenței\r\nși cu politica de confidențialitate";
            this.licenseCheck.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(58, 199);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(118, 51);
            this.logButton.TabIndex = 16;
            this.logButton.Text = "Accesează";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // realButton
            // 
            this.realButton.AutoSize = true;
            this.realButton.Location = new System.Drawing.Point(144, 119);
            this.realButton.Name = "realButton";
            this.realButton.Size = new System.Drawing.Size(64, 24);
            this.realButton.TabIndex = 17;
            this.realButton.TabStop = true;
            this.realButton.Text = "REAL";
            this.realButton.UseVisualStyleBackColor = true;
            // 
            // umanButton
            // 
            this.umanButton.AutoSize = true;
            this.umanButton.Location = new System.Drawing.Point(214, 119);
            this.umanButton.Name = "umanButton";
            this.umanButton.Size = new System.Drawing.Size(74, 24);
            this.umanButton.TabIndex = 18;
            this.umanButton.TabStop = true;
            this.umanButton.Text = "UMAN";
            this.umanButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "PROFIL:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator_de_note.Properties.Resources.back_png_background_Transparent_Images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 71;
            this.button1.Text = "Modifica baza de date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(378, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.umanButton);
            this.Controls.Add(this.realButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.licenseCheck);
            this.Controls.Add(this.clasaInput);
            this.Controls.Add(this.numeStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Carnet de note";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox clasaInput;
        private TextBox numeStudent;
        private Label label2;
        private Label nume;
        private Label label1;
        private CheckBox licenseCheck;
        private Button logButton;
        private RadioButton realButton;
        private RadioButton umanButton;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}