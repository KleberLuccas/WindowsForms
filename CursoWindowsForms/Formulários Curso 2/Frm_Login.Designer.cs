
namespace CursoWindowsForms
{
    partial class Frm_Login
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
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_PassWord = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Txt_PassWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Login
            // 
            this.Pic_Login.Image = global::CursoWindowsForms.Properties.Resources.key;
            this.Pic_Login.Location = new System.Drawing.Point(12, 8);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(100, 93);
            this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Login.TabIndex = 0;
            this.Pic_Login.TabStop = false;
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(119, 17);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Login.TabIndex = 1;
            this.Lbl_Login.Text = "label1";
            // 
            // Lbl_PassWord
            // 
            this.Lbl_PassWord.AutoSize = true;
            this.Lbl_PassWord.Location = new System.Drawing.Point(119, 65);
            this.Lbl_PassWord.Name = "Lbl_PassWord";
            this.Lbl_PassWord.Size = new System.Drawing.Size(35, 13);
            this.Lbl_PassWord.TabIndex = 2;
            this.Lbl_PassWord.Text = "label2";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(122, 33);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(151, 20);
            this.Txt_Login.TabIndex = 3;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(12, 144);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 5;
            this.Btn_Ok.Text = "button1";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(198, 144);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "button2";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Txt_PassWord
            // 
            this.Txt_PassWord.Location = new System.Drawing.Point(122, 81);
            this.Txt_PassWord.Name = "Txt_PassWord";
            this.Txt_PassWord.PasswordChar = '*';
            this.Txt_PassWord.Size = new System.Drawing.Size(151, 20);
            this.Txt_PassWord.TabIndex = 7;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 188);
            this.Controls.Add(this.Txt_PassWord);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_PassWord);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.Pic_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Logincs";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Login;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_PassWord;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox Txt_PassWord;
    }
}