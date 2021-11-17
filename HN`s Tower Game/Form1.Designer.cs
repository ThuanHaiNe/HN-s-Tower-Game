
namespace HN_s_Tower_Game
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._ButtonPlay = new System.Windows.Forms.Button();
            this._btmDoKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HN_s_Tower_Game.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _ButtonPlay
            // 
            this._ButtonPlay.BackColor = System.Drawing.Color.Cornsilk;
            this._ButtonPlay.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._ButtonPlay.Location = new System.Drawing.Point(279, 205);
            this._ButtonPlay.Name = "_ButtonPlay";
            this._ButtonPlay.Size = new System.Drawing.Size(141, 64);
            this._ButtonPlay.TabIndex = 1;
            this._ButtonPlay.Text = "Chơi";
            this._ButtonPlay.UseVisualStyleBackColor = false;
            this._ButtonPlay.Click += new System.EventHandler(this._ButtonPlay_Click);
            // 
            // _btmDoKho
            // 
            this._btmDoKho.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._btmDoKho.Location = new System.Drawing.Point(279, 292);
            this._btmDoKho.Name = "_btmDoKho";
            this._btmDoKho.Size = new System.Drawing.Size(141, 47);
            this._btmDoKho.TabIndex = 2;
            this._btmDoKho.Text = "Độ Khó";
            this._btmDoKho.UseVisualStyleBackColor = true;
            this._btmDoKho.Click += new System.EventHandler(this._btmDoKho_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this._btmDoKho);
            this.Controls.Add(this._ButtonPlay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _ButtonPlay;
        private System.Windows.Forms.Button _btmDoKho;
    }
}

