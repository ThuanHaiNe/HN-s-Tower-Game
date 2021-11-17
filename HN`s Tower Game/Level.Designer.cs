
namespace HN_s_Tower_Game
{
    
    partial class Level
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._Easy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._Normal = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this._Hard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._Easy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 56);
            this.panel1.TabIndex = 0;
            // 
            // _Easy
            // 
            this._Easy.Location = new System.Drawing.Point(0, 0);
            this._Easy.Name = "_Easy";
            this._Easy.Size = new System.Drawing.Size(349, 56);
            this._Easy.TabIndex = 0;
            this._Easy.Text = "Dễ";
            this._Easy.UseVisualStyleBackColor = true;
            this._Easy.Click += new System.EventHandler(this._Easy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._Normal);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 69);
            this.panel2.TabIndex = 0;
            // 
            // _Normal
            // 
            this._Normal.Location = new System.Drawing.Point(0, 0);
            this._Normal.Name = "_Normal";
            this._Normal.Size = new System.Drawing.Size(349, 66);
            this._Normal.TabIndex = 0;
            this._Normal.Text = "Trung Bình";
            this._Normal.UseVisualStyleBackColor = true;
            this._Normal.Click += new System.EventHandler(this._Normal_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._Hard);
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 72);
            this.panel3.TabIndex = 1;
            // 
            // _Hard
            // 
            this._Hard.Location = new System.Drawing.Point(0, 3);
            this._Hard.Name = "_Hard";
            this._Hard.Size = new System.Drawing.Size(349, 69);
            this._Hard.TabIndex = 0;
            this._Hard.Text = "Khó";
            this._Hard.UseVisualStyleBackColor = true;
            this._Hard.Click += new System.EventHandler(this._Hard_Click);
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 195);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Level";
            this.Text = "Level";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _Easy;
        private System.Windows.Forms.Button _Normal;
        private System.Windows.Forms.Button _Hard;
    }
}