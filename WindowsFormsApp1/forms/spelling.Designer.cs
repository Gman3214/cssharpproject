
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
            this.label1 = new System.Windows.Forms.Label();
            this.playermedia = new System.Windows.Forms.PictureBox();
            this.btn_chkres = new System.Windows.Forms.Button();
            this.pic_great = new System.Windows.Forms.PictureBox();
            this.pic_failed = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.cbx_ans1 = new System.Windows.Forms.CheckBox();
            this.cbx_ans3 = new System.Windows.Forms.CheckBox();
            this.cbx_ans2 = new System.Windows.Forms.CheckBox();
            this.cbx_ans4 = new System.Windows.Forms.CheckBox();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.lbl_updatescore = new System.Windows.Forms.Label();
            this.pic_score = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playermedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_great)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_failed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_score)).BeginInit();
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
            this.pic_great.Location = new System.Drawing.Point(441, 171);
            this.pic_great.Name = "pic_great";
            this.pic_great.Size = new System.Drawing.Size(318, 255);
            this.pic_great.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_great.TabIndex = 8;
            this.pic_great.TabStop = false;
            // 
            // pic_failed
            // 
            this.pic_failed.Image = ((System.Drawing.Image)(resources.GetObject("pic_failed.Image")));
            this.pic_failed.Location = new System.Drawing.Point(459, 171);
            this.pic_failed.Name = "pic_failed";
            this.pic_failed.Size = new System.Drawing.Size(286, 255);
            this.pic_failed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_failed.TabIndex = 10;
            this.pic_failed.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_start.Location = new System.Drawing.Point(202, 142);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(149, 23);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "LETS GET STARTED";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cbx_ans1
            // 
            this.cbx_ans1.AutoSize = true;
            this.cbx_ans1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans1.Location = new System.Drawing.Point(98, 268);
            this.cbx_ans1.Name = "cbx_ans1";
            this.cbx_ans1.Size = new System.Drawing.Size(117, 26);
            this.cbx_ans1.TabIndex = 12;
            this.cbx_ans1.Text = "checkBox1";
            this.cbx_ans1.UseVisualStyleBackColor = true;
            this.cbx_ans1.CheckedChanged += new System.EventHandler(this.cbx_ans1_CheckedChanged_1);
            // 
            // cbx_ans3
            // 
            this.cbx_ans3.AutoSize = true;
            this.cbx_ans3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans3.Location = new System.Drawing.Point(98, 325);
            this.cbx_ans3.Name = "cbx_ans3";
            this.cbx_ans3.Size = new System.Drawing.Size(117, 26);
            this.cbx_ans3.TabIndex = 13;
            this.cbx_ans3.Text = "checkBox1";
            this.cbx_ans3.UseVisualStyleBackColor = true;
            this.cbx_ans3.CheckedChanged += new System.EventHandler(this.cbx_ans3_CheckedChanged_1);
            // 
            // cbx_ans2
            // 
            this.cbx_ans2.AutoSize = true;
            this.cbx_ans2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans2.Location = new System.Drawing.Point(255, 268);
            this.cbx_ans2.Name = "cbx_ans2";
            this.cbx_ans2.Size = new System.Drawing.Size(117, 26);
            this.cbx_ans2.TabIndex = 14;
            this.cbx_ans2.Text = "checkBox1";
            this.cbx_ans2.UseVisualStyleBackColor = true;
            this.cbx_ans2.CheckedChanged += new System.EventHandler(this.cbx_ans2_CheckedChanged_1);
            // 
            // cbx_ans4
            // 
            this.cbx_ans4.AutoSize = true;
            this.cbx_ans4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ans4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_ans4.Location = new System.Drawing.Point(255, 325);
            this.cbx_ans4.Name = "cbx_ans4";
            this.cbx_ans4.Size = new System.Drawing.Size(117, 26);
            this.cbx_ans4.TabIndex = 15;
            this.cbx_ans4.Text = "checkBox1";
            this.cbx_ans4.UseVisualStyleBackColor = true;
            this.cbx_ans4.CheckedChanged += new System.EventHandler(this.cbx_ans4_CheckedChanged_1);
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedback.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_feedback.Location = new System.Drawing.Point(57, 495);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(90, 35);
            this.lbl_feedback.TabIndex = 16;
            this.lbl_feedback.Text = "label2";
            this.lbl_feedback.Visible = false;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Teal;
            this.btn_next.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next.Location = new System.Drawing.Point(403, 416);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(58, 41);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_return
            // 
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_return.Location = new System.Drawing.Point(374, 142);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(127, 23);
            this.btn_return.TabIndex = 18;
            this.btn_return.Text = "Return to menu";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lbl_updatescore
            // 
            this.lbl_updatescore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_updatescore.AutoSize = true;
            this.lbl_updatescore.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updatescore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_updatescore.Location = new System.Drawing.Point(644, 455);
            this.lbl_updatescore.Name = "lbl_updatescore";
            this.lbl_updatescore.Size = new System.Drawing.Size(80, 32);
            this.lbl_updatescore.TabIndex = 20;
            this.lbl_updatescore.Text = "label2";
            this.lbl_updatescore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_updatescore.Visible = false;
            // 
            // pic_score
            // 
            this.pic_score.Image = ((System.Drawing.Image)(resources.GetObject("pic_score.Image")));
            this.pic_score.Location = new System.Drawing.Point(550, 474);
            this.pic_score.Name = "pic_score";
            this.pic_score.Size = new System.Drawing.Size(42, 34);
            this.pic_score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_score.TabIndex = 21;
            this.pic_score.TabStop = false;
            this.pic_score.Visible = false;
            // 
            // frm_spelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1138, 607);
            this.Controls.Add(this.pic_score);
            this.Controls.Add(this.lbl_updatescore);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_feedback);
            this.Controls.Add(this.cbx_ans4);
            this.Controls.Add(this.cbx_ans2);
            this.Controls.Add(this.cbx_ans3);
            this.Controls.Add(this.cbx_ans1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pic_failed);
            this.Controls.Add(this.pic_great);
            this.Controls.Add(this.btn_chkres);
            this.Controls.Add(this.playermedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_spellingtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_spelling";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_spelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playermedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_great)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_failed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lbl_spellingtitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox playermedia;
		private System.Windows.Forms.Button btn_chkres;
		private System.Windows.Forms.PictureBox pic_great;
		private System.Windows.Forms.PictureBox pic_failed;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.CheckBox cbx_ans1;
		private System.Windows.Forms.CheckBox cbx_ans3;
		private System.Windows.Forms.CheckBox cbx_ans2;
		private System.Windows.Forms.CheckBox cbx_ans4;
		private System.Windows.Forms.Label lbl_feedback;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.Button btn_return;
		private System.Windows.Forms.Label lbl_updatescore;
		private System.Windows.Forms.PictureBox pic_score;
	}
}