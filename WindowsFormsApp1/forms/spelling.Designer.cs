
namespace exam
{
    partial class frm_spelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_spelling));
            this.lbl_spellingtitle = new System.Windows.Forms.Label();
            this.cbx_ans1 = new System.Windows.Forms.CheckBox();
            this.cbx_ans3 = new System.Windows.Forms.CheckBox();
            this.cbx_ans2 = new System.Windows.Forms.CheckBox();
            this.cbx_ans4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playermedia = new System.Windows.Forms.PictureBox();
            this.btn_chkres = new System.Windows.Forms.Button();
            this.pic_great = new System.Windows.Forms.PictureBox();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.pic_failed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playermedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_great)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_failed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_spellingtitle
            // 
            this.lbl_spellingtitle.AutoSize = true;
            this.lbl_spellingtitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spellingtitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_spellingtitle.Location = new System.Drawing.Point(39, 42);
            this.lbl_spellingtitle.Name = "lbl_spellingtitle";
            this.lbl_spellingtitle.Size = new System.Drawing.Size(139, 46);
            this.lbl_spellingtitle.TabIndex = 0;
            this.lbl_spellingtitle.Text = "Spelling";
            // 
            // cbx_ans1
            // 
            this.cbx_ans1.AutoSize = true;
            this.cbx_ans1.Enabled = false;
            this.cbx_ans1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans1.Location = new System.Drawing.Point(141, 306);
            this.cbx_ans1.Name = "cbx_ans1";
            this.cbx_ans1.Size = new System.Drawing.Size(18, 17);
            this.cbx_ans1.TabIndex = 1;
            this.cbx_ans1.UseVisualStyleBackColor = true;
            this.cbx_ans1.CheckedChanged += new System.EventHandler(this.cbx_ans1_CheckedChanged);
            // 
            // cbx_ans3
            // 
            this.cbx_ans3.AutoSize = true;
            this.cbx_ans3.Enabled = false;
            this.cbx_ans3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans3.Location = new System.Drawing.Point(141, 350);
            this.cbx_ans3.Name = "cbx_ans3";
            this.cbx_ans3.Size = new System.Drawing.Size(18, 17);
            this.cbx_ans3.TabIndex = 2;
            this.cbx_ans3.UseVisualStyleBackColor = true;
            this.cbx_ans3.CheckedChanged += new System.EventHandler(this.cbx_ans3_CheckedChanged);
            // 
            // cbx_ans2
            // 
            this.cbx_ans2.AutoSize = true;
            this.cbx_ans2.Enabled = false;
            this.cbx_ans2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans2.Location = new System.Drawing.Point(326, 306);
            this.cbx_ans2.Name = "cbx_ans2";
            this.cbx_ans2.Size = new System.Drawing.Size(18, 17);
            this.cbx_ans2.TabIndex = 3;
            this.cbx_ans2.UseVisualStyleBackColor = true;
            this.cbx_ans2.CheckedChanged += new System.EventHandler(this.cbx_ans2_CheckedChanged);
            // 
            // cbx_ans4
            // 
            this.cbx_ans4.AutoSize = true;
            this.cbx_ans4.Enabled = false;
            this.cbx_ans4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans4.Location = new System.Drawing.Point(326, 350);
            this.cbx_ans4.Name = "cbx_ans4";
            this.cbx_ans4.Size = new System.Drawing.Size(18, 17);
            this.cbx_ans4.TabIndex = 4;
            this.cbx_ans4.UseVisualStyleBackColor = true;
            this.cbx_ans4.CheckedChanged += new System.EventHandler(this.cbx_ans4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please click on the audio to hear the word. Then choose the word that is spelled " +
    "correctly from the four:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playermedia
            // 
            this.playermedia.Enabled = false;
            this.playermedia.Image = ((System.Drawing.Image)(resources.GetObject("playermedia.Image")));
            this.playermedia.Location = new System.Drawing.Point(98, 171);
            this.playermedia.Name = "playermedia";
            this.playermedia.Size = new System.Drawing.Size(91, 42);
            this.playermedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playermedia.TabIndex = 6;
            this.playermedia.TabStop = false;
            this.playermedia.Click += new System.EventHandler(this.playermedia_Click);
            // 
            // btn_chkres
            // 
            this.btn_chkres.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_chkres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_chkres.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chkres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_chkres.Location = new System.Drawing.Point(141, 416);
            this.btn_chkres.Name = "btn_chkres";
            this.btn_chkres.Size = new System.Drawing.Size(210, 41);
            this.btn_chkres.TabIndex = 7;
            this.btn_chkres.Text = "Check my Resulte";
            this.btn_chkres.UseVisualStyleBackColor = false;
            this.btn_chkres.Click += new System.EventHandler(this.btn_chkres_Click);
            // 
            // pic_great
            // 
            this.pic_great.Image = ((System.Drawing.Image)(resources.GetObject("pic_great.Image")));
            this.pic_great.Location = new System.Drawing.Point(414, 171);
            this.pic_great.Name = "pic_great";
            this.pic_great.Size = new System.Drawing.Size(353, 156);
            this.pic_great.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_great.TabIndex = 8;
            this.pic_great.TabStop = false;
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_feedback.Location = new System.Drawing.Point(551, 367);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(79, 31);
            this.lbl_feedback.TabIndex = 9;
            this.lbl_feedback.Text = "label2";
            // 
            // pic_failed
            // 
            this.pic_failed.Image = ((System.Drawing.Image)(resources.GetObject("pic_failed.Image")));
            this.pic_failed.Location = new System.Drawing.Point(459, 171);
            this.pic_failed.Name = "pic_failed";
            this.pic_failed.Size = new System.Drawing.Size(239, 161);
            this.pic_failed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_failed.TabIndex = 10;
            this.pic_failed.TabStop = false;
            // 
            // frm_spelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1138, 607);
            this.Controls.Add(this.pic_failed);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.pic_great);
            this.Controls.Add(this.btn_chkres);
            this.Controls.Add(this.playermedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_ans4);
            this.Controls.Add(this.cbx_ans2);
            this.Controls.Add(this.cbx_ans3);
            this.Controls.Add(this.cbx_ans1);
            this.Controls.Add(this.lbl_spellingtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_spelling";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_spelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playermedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_great)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_failed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lbl_spellingtitle;
		private System.Windows.Forms.CheckBox cbx_ans1;
		private System.Windows.Forms.CheckBox cbx_ans3;
		private System.Windows.Forms.CheckBox cbx_ans2;
		private System.Windows.Forms.CheckBox cbx_ans4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox playermedia;
		private System.Windows.Forms.Button btn_chkres;
		private System.Windows.Forms.PictureBox pic_great;
		private System.Windows.Forms.Label lbl_feedback;
		private System.Windows.Forms.PictureBox pic_failed;
	}
}