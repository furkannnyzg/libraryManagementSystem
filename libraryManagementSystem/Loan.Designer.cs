namespace libraryManagementSystem
{
    partial class Loan
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
            this.loanGridView = new System.Windows.Forms.DataGridView();
            this.cmboxÜyeİsmi = new System.Windows.Forms.ComboBox();
            this.cmBoxKitapİsmi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loanshowBtn = new System.Windows.Forms.Button();
            this.loanaddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loanGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(161, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ödünç Sistemi";
            // 
            // loanGridView
            // 
            this.loanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanGridView.Location = new System.Drawing.Point(514, 23);
            this.loanGridView.Name = "loanGridView";
            this.loanGridView.Size = new System.Drawing.Size(532, 402);
            this.loanGridView.TabIndex = 39;
            // 
            // cmboxÜyeİsmi
            // 
            this.cmboxÜyeİsmi.DropDownHeight = 300;
            this.cmboxÜyeİsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxÜyeİsmi.FormattingEnabled = true;
            this.cmboxÜyeİsmi.IntegralHeight = false;
            this.cmboxÜyeİsmi.Location = new System.Drawing.Point(219, 143);
            this.cmboxÜyeİsmi.Name = "cmboxÜyeİsmi";
            this.cmboxÜyeİsmi.Size = new System.Drawing.Size(274, 37);
            this.cmboxÜyeİsmi.TabIndex = 40;
            this.cmboxÜyeİsmi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmBoxKitapİsmi
            // 
            this.cmBoxKitapİsmi.DropDownHeight = 300;
            this.cmBoxKitapİsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBoxKitapİsmi.FormattingEnabled = true;
            this.cmBoxKitapİsmi.IntegralHeight = false;
            this.cmBoxKitapİsmi.Location = new System.Drawing.Point(219, 216);
            this.cmBoxKitapİsmi.Name = "cmBoxKitapİsmi";
            this.cmBoxKitapİsmi.Size = new System.Drawing.Size(274, 37);
            this.cmBoxKitapİsmi.TabIndex = 41;
            this.cmBoxKitapİsmi.SelectedIndexChanged += new System.EventHandler(this.cmBoxKitapİsmi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Üye İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kitap İsmi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::libraryManagementSystem.Properties.Resources._3114883;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loanshowBtn
            // 
            this.loanshowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loanshowBtn.Location = new System.Drawing.Point(335, 322);
            this.loanshowBtn.Name = "loanshowBtn";
            this.loanshowBtn.Size = new System.Drawing.Size(117, 61);
            this.loanshowBtn.TabIndex = 46;
            this.loanshowBtn.Text = "Ödünç Göster";
            this.loanshowBtn.UseVisualStyleBackColor = true;
            this.loanshowBtn.Click += new System.EventHandler(this.loanshowBtn_Click);
            // 
            // loanaddBtn
            // 
            this.loanaddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loanaddBtn.Location = new System.Drawing.Point(122, 322);
            this.loanaddBtn.Name = "loanaddBtn";
            this.loanaddBtn.Size = new System.Drawing.Size(117, 61);
            this.loanaddBtn.TabIndex = 45;
            this.loanaddBtn.Text = "Ödünç Ver";
            this.loanaddBtn.UseVisualStyleBackColor = true;
            this.loanaddBtn.Click += new System.EventHandler(this.loanaddBtn_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.loanshowBtn);
            this.Controls.Add(this.loanaddBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmBoxKitapİsmi);
            this.Controls.Add(this.cmboxÜyeİsmi);
            this.Controls.Add(this.loanGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loan";
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.loanGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loanGridView;
        private System.Windows.Forms.ComboBox cmboxÜyeİsmi;
        private System.Windows.Forms.ComboBox cmBoxKitapİsmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loanshowBtn;
        private System.Windows.Forms.Button loanaddBtn;
    }
}