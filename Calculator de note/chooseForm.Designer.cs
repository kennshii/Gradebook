namespace Calculator_de_note
{
    partial class chooseForm
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
            this.buttonElev = new System.Windows.Forms.Button();
            this.buttonProfesor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonElev
            // 
            this.buttonElev.Location = new System.Drawing.Point(35, 67);
            this.buttonElev.Name = "buttonElev";
            this.buttonElev.Size = new System.Drawing.Size(118, 42);
            this.buttonElev.TabIndex = 17;
            this.buttonElev.Text = "Elev";
            this.buttonElev.UseVisualStyleBackColor = true;
            this.buttonElev.Click += new System.EventHandler(this.buttonElev_Click);
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.Location = new System.Drawing.Point(207, 67);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(118, 42);
            this.buttonProfesor.TabIndex = 18;
            this.buttonProfesor.Text = "Profesor";
            this.buttonProfesor.UseVisualStyleBackColor = true;
            this.buttonProfesor.Click += new System.EventHandler(this.buttonProfesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cine sunteti?";
            // 
            // passPanel
            // 
            this.passPanel.Controls.Add(this.button1);
            this.passPanel.Controls.Add(this.label2);
            this.passPanel.Controls.Add(this.password);
            this.passPanel.Location = new System.Drawing.Point(68, 115);
            this.passPanel.Name = "passPanel";
            this.passPanel.Size = new System.Drawing.Size(227, 125);
            this.passPanel.TabIndex = 20;
            this.passPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Accesează";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(59, 8);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(125, 27);
            this.password.TabIndex = 0;
            this.password.UseSystemPasswordChar = true;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(6, 291);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(61, 20);
            this.linkGitHub.TabIndex = 27;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GITHUB";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator_de_note.Properties.Resources.ceiti;
            this.pictureBox1.Location = new System.Drawing.Point(235, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Creat de Busuioc Eduard";
            // 
            // chooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 322);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProfesor);
            this.Controls.Add(this.buttonElev);
            this.Name = "chooseForm";
            this.Text = "Gradebook";
            this.passPanel.ResumeLayout(false);
            this.passPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonElev;
        private Button buttonProfesor;
        private Label label1;
        private Panel passPanel;
        private Label label2;
        private TextBox password;
        private Button button1;
        private LinkLabel linkGitHub;
        private PictureBox pictureBox1;
        private Label label4;
    }
}