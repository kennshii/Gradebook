namespace Calculator_de_note
{
    partial class Elev
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbReal = new System.Windows.Forms.RadioButton();
            this.rbUman = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(232, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(556, 426);
            this.dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cautare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(101, 19);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(125, 27);
            this.textNume.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume elev:";
            // 
            // rbReal
            // 
            this.rbReal.AutoSize = true;
            this.rbReal.Location = new System.Drawing.Point(158, 60);
            this.rbReal.Name = "rbReal";
            this.rbReal.Size = new System.Drawing.Size(59, 24);
            this.rbReal.TabIndex = 4;
            this.rbReal.TabStop = true;
            this.rbReal.Text = "Real";
            this.rbReal.UseVisualStyleBackColor = true;
            // 
            // rbUman
            // 
            this.rbUman.AutoSize = true;
            this.rbUman.Location = new System.Drawing.Point(83, 60);
            this.rbUman.Name = "rbUman";
            this.rbUman.Size = new System.Drawing.Size(69, 24);
            this.rbUman.TabIndex = 5;
            this.rbUman.TabStop = true;
            this.rbUman.Text = "Uman";
            this.rbUman.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profil:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator_de_note.Properties.Resources.back_png_background_Transparent_Images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbUman);
            this.Controls.Add(this.rbReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Elev";
            this.Text = "Elev";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private Button button1;
        private TextBox textNume;
        private Label label1;
        private RadioButton rbReal;
        private RadioButton rbUman;
        private Label label2;
        private PictureBox pictureBox1;
    }
}