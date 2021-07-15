
namespace exam
{
    partial class gameone
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameone));
			this.pic_hanged = new System.Windows.Forms.PictureBox();
			this.txt_nextl = new System.Windows.Forms.TextBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.lbl_gusses = new System.Windows.Forms.Label();
			this.btn_submit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_next = new System.Windows.Forms.Button();
			this.lbl_encourage = new System.Windows.Forms.Label();
			this.lbl_score = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_hanged)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_hanged
			// 
			this.pic_hanged.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_hanged.Image = ((System.Drawing.Image)(resources.GetObject("pic_hanged.Image")));
			this.pic_hanged.Location = new System.Drawing.Point(336, 322);
			this.pic_hanged.Name = "pic_hanged";
			this.pic_hanged.Size = new System.Drawing.Size(389, 287);
			this.pic_hanged.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_hanged.TabIndex = 0;
			this.pic_hanged.TabStop = false;
			this.pic_hanged.UseWaitCursor = true;
			// 
			// txt_nextl
			// 
			this.txt_nextl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_nextl.Location = new System.Drawing.Point(522, 117);
			this.txt_nextl.Name = "txt_nextl";
			this.txt_nextl.Size = new System.Drawing.Size(20, 20);
			this.txt_nextl.TabIndex = 1;
			this.txt_nextl.UseWaitCursor = true;
			// 
			// lbl_title
			// 
			this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_title.AutoSize = true;
			this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lbl_title.ForeColor = System.Drawing.Color.White;
			this.lbl_title.Location = new System.Drawing.Point(397, 89);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(228, 20);
			this.lbl_title.TabIndex = 2;
			this.lbl_title.Text = "enter the next letter in the word";
			this.lbl_title.UseWaitCursor = true;
			// 
			// lbl_gusses
			// 
			this.lbl_gusses.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_gusses.AutoSize = true;
			this.lbl_gusses.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_gusses.ForeColor = System.Drawing.Color.White;
			this.lbl_gusses.Location = new System.Drawing.Point(19, 213);
			this.lbl_gusses.Name = "lbl_gusses";
			this.lbl_gusses.Size = new System.Drawing.Size(0, 86);
			this.lbl_gusses.TabIndex = 3;
			this.lbl_gusses.UseWaitCursor = true;
			this.lbl_gusses.Visible = false;
			// 
			// btn_submit
			// 
			this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_submit.Location = new System.Drawing.Point(494, 155);
			this.btn_submit.Name = "btn_submit";
			this.btn_submit.Size = new System.Drawing.Size(75, 23);
			this.btn_submit.TabIndex = 4;
			this.btn_submit.Text = "Enter";
			this.btn_submit.UseVisualStyleBackColor = true;
			this.btn_submit.UseWaitCursor = true;
			this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(494, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 44);
			this.button1.TabIndex = 5;
			this.button1.Text = "replay word";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.UseWaitCursor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_next
			// 
			this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_next.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_next.Location = new System.Drawing.Point(732, 322);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(120, 60);
			this.btn_next.TabIndex = 6;
			this.btn_next.Text = "next round";
			this.btn_next.UseVisualStyleBackColor = true;
			this.btn_next.UseWaitCursor = true;
			this.btn_next.Visible = false;
			this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
			// 
			// lbl_encourage
			// 
			this.lbl_encourage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_encourage.AutoSize = true;
			this.lbl_encourage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lbl_encourage.ForeColor = System.Drawing.Color.White;
			this.lbl_encourage.Location = new System.Drawing.Point(37, 343);
			this.lbl_encourage.Name = "lbl_encourage";
			this.lbl_encourage.Size = new System.Drawing.Size(42, 17);
			this.lbl_encourage.TabIndex = 7;
			this.lbl_encourage.Text = "woow";
			this.lbl_encourage.UseWaitCursor = true;
			this.lbl_encourage.Visible = false;
			// 
			// lbl_score
			// 
			this.lbl_score.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_score.AutoSize = true;
			this.lbl_score.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_score.ForeColor = System.Drawing.Color.White;
			this.lbl_score.Location = new System.Drawing.Point(795, 36);
			this.lbl_score.Name = "lbl_score";
			this.lbl_score.Size = new System.Drawing.Size(70, 30);
			this.lbl_score.TabIndex = 8;
			this.lbl_score.Text = "score:";
			this.lbl_score.UseWaitCursor = true;
			// 
			// gameone
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(1138, 607);
			this.Controls.Add(this.lbl_score);
			this.Controls.Add(this.lbl_encourage);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_submit);
			this.Controls.Add(this.lbl_gusses);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.txt_nextl);
			this.Controls.Add(this.pic_hanged);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "gameone";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "hanged man game ";
			this.UseWaitCursor = true;
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_hanged)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_hanged;
        private System.Windows.Forms.TextBox txt_nextl;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_gusses;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_encourage;
        private System.Windows.Forms.Label lbl_score;
    }
}