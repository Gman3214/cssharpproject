
namespace exam
{
    partial class gametwo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gametwo));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.btn_str = new System.Windows.Forms.Button();
            this.pic_slc = new System.Windows.Forms.PictureBox();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.tim_ans = new System.Windows.Forms.Timer(this.components);
            this.tim_count = new System.Windows.Forms.Timer(this.components);
            this.lbl_showtime = new System.Windows.Forms.Label();
            this.lbl_timtitle = new System.Windows.Forms.Label();
            this.btn_chkans = new System.Windows.Forms.Button();
            this.lbl_rightans = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.pic_score = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_rtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_score)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_title.Location = new System.Drawing.Point(333, 56);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(304, 46);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "WRITE THE WORD";
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_exp.Location = new System.Drawing.Point(76, 113);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(65, 28);
            this.lbl_exp.TabIndex = 1;
            this.lbl_exp.Text = "label1";
            // 
            // btn_str
            // 
            this.btn_str.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_str.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_str.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_str.Location = new System.Drawing.Point(760, 144);
            this.btn_str.Name = "btn_str";
            this.btn_str.Size = new System.Drawing.Size(99, 23);
            this.btn_str.TabIndex = 2;
            this.btn_str.Text = "OK, GOT IT!";
            this.btn_str.UseVisualStyleBackColor = true;
            this.btn_str.Click += new System.EventHandler(this.btn_str_Click);
            // 
            // pic_slc
            // 
            this.pic_slc.Location = new System.Drawing.Point(305, 126);
            this.pic_slc.Name = "pic_slc";
            this.pic_slc.Size = new System.Drawing.Size(291, 269);
            this.pic_slc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_slc.TabIndex = 3;
            this.pic_slc.TabStop = false;
            this.pic_slc.Visible = false;
            // 
            // txt_ans
            // 
            this.txt_ans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txt_ans.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ans.Location = new System.Drawing.Point(349, 421);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(179, 30);
            this.txt_ans.TabIndex = 4;
            this.txt_ans.Visible = false;
            this.txt_ans.TextChanged += new System.EventHandler(this.txt_ans_TextChanged);
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_dir.Location = new System.Drawing.Point(180, 421);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(169, 25);
            this.lbl_dir.TabIndex = 5;
            this.lbl_dir.Text = "pls enter the word:";
            this.lbl_dir.Visible = false;
            // 
            // tim_ans
            // 
            this.tim_ans.Interval = 5000;
            this.tim_ans.Tick += new System.EventHandler(this.tim_ans_Tick);
            // 
            // tim_count
            // 
            this.tim_count.Interval = 1000;
            this.tim_count.Tick += new System.EventHandler(this.tim_count_Tick);
            // 
            // lbl_showtime
            // 
            this.lbl_showtime.AutoSize = true;
            this.lbl_showtime.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showtime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_showtime.Location = new System.Drawing.Point(130, 256);
            this.lbl_showtime.Name = "lbl_showtime";
            this.lbl_showtime.Size = new System.Drawing.Size(0, 32);
            this.lbl_showtime.TabIndex = 6;
            this.lbl_showtime.Visible = false;
            // 
            // lbl_timtitle
            // 
            this.lbl_timtitle.AutoSize = true;
            this.lbl_timtitle.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timtitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_timtitle.Location = new System.Drawing.Point(90, 231);
            this.lbl_timtitle.Name = "lbl_timtitle";
            this.lbl_timtitle.Size = new System.Drawing.Size(125, 32);
            this.lbl_timtitle.TabIndex = 7;
            this.lbl_timtitle.Text = "TIME LEFT:";
            this.lbl_timtitle.Visible = false;
            // 
            // btn_chkans
            // 
            this.btn_chkans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chkans.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chkans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_chkans.Location = new System.Drawing.Point(562, 421);
            this.btn_chkans.Name = "btn_chkans";
            this.btn_chkans.Size = new System.Drawing.Size(89, 23);
            this.btn_chkans.TabIndex = 8;
            this.btn_chkans.Text = "check me";
            this.btn_chkans.UseVisualStyleBackColor = true;
            this.btn_chkans.Visible = false;
            this.btn_chkans.Click += new System.EventHandler(this.btn_chkans_Click);
            // 
            // lbl_rightans
            // 
            this.lbl_rightans.AutoSize = true;
            this.lbl_rightans.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_rightans.Location = new System.Drawing.Point(419, 474);
            this.lbl_rightans.Name = "lbl_rightans";
            this.lbl_rightans.Size = new System.Drawing.Size(0, 32);
            this.lbl_rightans.TabIndex = 9;
            this.lbl_rightans.Visible = false;
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_right.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_right.Location = new System.Drawing.Point(391, 474);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(127, 32);
            this.lbl_right.TabIndex = 10;
            this.lbl_right.Text = "rightanslbl";
            this.lbl_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_right.Visible = false;
            // 
            // pic_score
            // 
            this.pic_score.Image = ((System.Drawing.Image)(resources.GetObject("pic_score.Image")));
            this.pic_score.Location = new System.Drawing.Point(760, 241);
            this.pic_score.Name = "pic_score";
            this.pic_score.Size = new System.Drawing.Size(99, 63);
            this.pic_score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_score.TabIndex = 11;
            this.pic_score.TabStop = false;
            this.pic_score.Visible = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_score.Location = new System.Drawing.Point(782, 307);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(76, 32);
            this.lbl_score.TabIndex = 12;
            this.lbl_score.Text = "score:";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_score.Visible = false;
            // 
            // btn_rtn
            // 
            this.btn_rtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rtn.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rtn.Location = new System.Drawing.Point(318, 421);
            this.btn_rtn.Name = "btn_rtn";
            this.btn_rtn.Size = new System.Drawing.Size(266, 80);
            this.btn_rtn.TabIndex = 13;
            this.btn_rtn.Text = "RETURN TO HOME SCREEN";
            this.btn_rtn.UseVisualStyleBackColor = true;
            this.btn_rtn.Visible = false;
            this.btn_rtn.Click += new System.EventHandler(this.btn_rtn_Click);
            // 
            // gametwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1138, 607);
            this.Controls.Add(this.btn_rtn);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pic_score);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_rightans);
            this.Controls.Add(this.btn_chkans);
            this.Controls.Add(this.lbl_timtitle);
            this.Controls.Add(this.lbl_showtime);
            this.Controls.Add(this.lbl_dir);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.pic_slc);
            this.Controls.Add(this.btn_str);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gametwo";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.gametwo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_slc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label lbl_exp;
		private System.Windows.Forms.Button btn_str;
		private System.Windows.Forms.PictureBox pic_slc;
		private System.Windows.Forms.TextBox txt_ans;
		private System.Windows.Forms.Label lbl_dir;
		private System.Windows.Forms.Timer tim_ans;
		private System.Windows.Forms.Timer tim_count;
		private System.Windows.Forms.Label lbl_showtime;
		private System.Windows.Forms.Label lbl_timtitle;
		private System.Windows.Forms.Button btn_chkans;
		private System.Windows.Forms.Label lbl_rightans;
		private System.Windows.Forms.Label lbl_right;
		private System.Windows.Forms.PictureBox pic_score;
		private System.Windows.Forms.Label lbl_score;
		private System.Windows.Forms.Button btn_rtn;
	}
}