
namespace exam
{
    partial class frm_add
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add));
			this.lbl_entery = new System.Windows.Forms.Label();
			this.pbx_plusign = new System.Windows.Forms.PictureBox();
			this.cbx_spelling = new System.Windows.Forms.CheckBox();
			this.cbx_games = new System.Windows.Forms.CheckBox();
			this.lbl_filldir = new System.Windows.Forms.Label();
			this.lbl_word = new System.Windows.Forms.Label();
			this.txt_addword = new System.Windows.Forms.TextBox();
			this.txt_addsound = new System.Windows.Forms.TextBox();
			this.lbl_addsound = new System.Windows.Forms.Label();
			this.txt_addpic = new System.Windows.Forms.TextBox();
			this.lbl_addpic = new System.Windows.Forms.Label();
			this.txt_wrong1 = new System.Windows.Forms.TextBox();
			this.lbl_addwrong1 = new System.Windows.Forms.Label();
			this.txt_wrong2 = new System.Windows.Forms.TextBox();
			this.lbl_addwrong2 = new System.Windows.Forms.Label();
			this.txt_wrong3 = new System.Windows.Forms.TextBox();
			this.lbl_addwrong3 = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_selectsound = new System.Windows.Forms.Button();
			this.btn_slctpic = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbx_plusign)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_entery
			// 
			this.lbl_entery.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_entery.AutoSize = true;
			this.lbl_entery.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_entery.ForeColor = System.Drawing.Color.White;
			this.lbl_entery.Location = new System.Drawing.Point(9, 89);
			this.lbl_entery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_entery.Name = "lbl_entery";
			this.lbl_entery.Size = new System.Drawing.Size(526, 25);
			this.lbl_entery.TabIndex = 0;
			this.lbl_entery.Text = "Please choose which domain you would like to add a word to";
			// 
			// pbx_plusign
			// 
			this.pbx_plusign.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pbx_plusign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pbx_plusign.Image = ((System.Drawing.Image)(resources.GetObject("pbx_plusign.Image")));
			this.pbx_plusign.Location = new System.Drawing.Point(622, 24);
			this.pbx_plusign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pbx_plusign.Name = "pbx_plusign";
			this.pbx_plusign.Size = new System.Drawing.Size(161, 152);
			this.pbx_plusign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbx_plusign.TabIndex = 1;
			this.pbx_plusign.TabStop = false;
			// 
			// cbx_spelling
			// 
			this.cbx_spelling.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbx_spelling.AutoSize = true;
			this.cbx_spelling.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_spelling.ForeColor = System.Drawing.Color.White;
			this.cbx_spelling.Location = new System.Drawing.Point(66, 154);
			this.cbx_spelling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbx_spelling.Name = "cbx_spelling";
			this.cbx_spelling.Size = new System.Drawing.Size(165, 23);
			this.cbx_spelling.TabIndex = 2;
			this.cbx_spelling.Text = "Add to the spelling file";
			this.cbx_spelling.UseVisualStyleBackColor = true;
			this.cbx_spelling.CheckedChanged += new System.EventHandler(this.cbx_spelling_CheckedChanged);
			// 
			// cbx_games
			// 
			this.cbx_games.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbx_games.AutoSize = true;
			this.cbx_games.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_games.ForeColor = System.Drawing.Color.White;
			this.cbx_games.Location = new System.Drawing.Point(296, 154);
			this.cbx_games.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbx_games.Name = "cbx_games";
			this.cbx_games.Size = new System.Drawing.Size(159, 23);
			this.cbx_games.TabIndex = 3;
			this.cbx_games.Text = "Add to the games file";
			this.cbx_games.UseVisualStyleBackColor = true;
			this.cbx_games.CheckedChanged += new System.EventHandler(this.cbx_games_CheckedChanged);
			// 
			// lbl_filldir
			// 
			this.lbl_filldir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_filldir.AutoSize = true;
			this.lbl_filldir.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_filldir.ForeColor = System.Drawing.Color.White;
			this.lbl_filldir.Location = new System.Drawing.Point(10, 207);
			this.lbl_filldir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_filldir.Name = "lbl_filldir";
			this.lbl_filldir.Size = new System.Drawing.Size(212, 25);
			this.lbl_filldir.TabIndex = 4;
			this.lbl_filldir.Text = "Please fill the following:";
			// 
			// lbl_word
			// 
			this.lbl_word.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_word.AutoSize = true;
			this.lbl_word.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_word.ForeColor = System.Drawing.Color.White;
			this.lbl_word.Location = new System.Drawing.Point(216, 214);
			this.lbl_word.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_word.Name = "lbl_word";
			this.lbl_word.Size = new System.Drawing.Size(46, 19);
			this.lbl_word.TabIndex = 5;
			this.lbl_word.Text = "Word:";
			this.lbl_word.Visible = false;
			// 
			// txt_addword
			// 
			this.txt_addword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_addword.Location = new System.Drawing.Point(330, 216);
			this.txt_addword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_addword.Name = "txt_addword";
			this.txt_addword.Size = new System.Drawing.Size(192, 20);
			this.txt_addword.TabIndex = 6;
			this.txt_addword.Visible = false;
			// 
			// txt_addsound
			// 
			this.txt_addsound.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_addsound.Location = new System.Drawing.Point(330, 249);
			this.txt_addsound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_addsound.Name = "txt_addsound";
			this.txt_addsound.Size = new System.Drawing.Size(192, 20);
			this.txt_addsound.TabIndex = 14;
			this.txt_addsound.Visible = false;
			// 
			// lbl_addsound
			// 
			this.lbl_addsound.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_addsound.AutoSize = true;
			this.lbl_addsound.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addsound.ForeColor = System.Drawing.Color.White;
			this.lbl_addsound.Location = new System.Drawing.Point(216, 246);
			this.lbl_addsound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_addsound.Name = "lbl_addsound";
			this.lbl_addsound.Size = new System.Drawing.Size(72, 19);
			this.lbl_addsound.TabIndex = 13;
			this.lbl_addsound.Text = "Sound file:";
			this.lbl_addsound.Visible = false;
			// 
			// txt_addpic
			// 
			this.txt_addpic.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_addpic.Location = new System.Drawing.Point(330, 280);
			this.txt_addpic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_addpic.Name = "txt_addpic";
			this.txt_addpic.Size = new System.Drawing.Size(192, 20);
			this.txt_addpic.TabIndex = 16;
			this.txt_addpic.Visible = false;
			// 
			// lbl_addpic
			// 
			this.lbl_addpic.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_addpic.AutoSize = true;
			this.lbl_addpic.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addpic.ForeColor = System.Drawing.Color.White;
			this.lbl_addpic.Location = new System.Drawing.Point(216, 279);
			this.lbl_addpic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_addpic.Name = "lbl_addpic";
			this.lbl_addpic.Size = new System.Drawing.Size(75, 19);
			this.lbl_addpic.TabIndex = 15;
			this.lbl_addpic.Text = "Picture file:";
			this.lbl_addpic.Visible = false;
			// 
			// txt_wrong1
			// 
			this.txt_wrong1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_wrong1.Location = new System.Drawing.Point(330, 310);
			this.txt_wrong1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_wrong1.Name = "txt_wrong1";
			this.txt_wrong1.Size = new System.Drawing.Size(192, 20);
			this.txt_wrong1.TabIndex = 18;
			this.txt_wrong1.Visible = false;
			// 
			// lbl_addwrong1
			// 
			this.lbl_addwrong1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_addwrong1.AutoSize = true;
			this.lbl_addwrong1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addwrong1.ForeColor = System.Drawing.Color.White;
			this.lbl_addwrong1.Location = new System.Drawing.Point(219, 308);
			this.lbl_addwrong1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_addwrong1.Name = "lbl_addwrong1";
			this.lbl_addwrong1.Size = new System.Drawing.Size(112, 19);
			this.lbl_addwrong1.TabIndex = 17;
			this.lbl_addwrong1.Text = "Wrong spelling1:";
			this.lbl_addwrong1.Visible = false;
			// 
			// txt_wrong2
			// 
			this.txt_wrong2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_wrong2.Location = new System.Drawing.Point(330, 342);
			this.txt_wrong2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_wrong2.Name = "txt_wrong2";
			this.txt_wrong2.Size = new System.Drawing.Size(192, 20);
			this.txt_wrong2.TabIndex = 20;
			this.txt_wrong2.Visible = false;
			// 
			// lbl_addwrong2
			// 
			this.lbl_addwrong2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_addwrong2.AutoSize = true;
			this.lbl_addwrong2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addwrong2.ForeColor = System.Drawing.Color.White;
			this.lbl_addwrong2.Location = new System.Drawing.Point(219, 341);
			this.lbl_addwrong2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_addwrong2.Name = "lbl_addwrong2";
			this.lbl_addwrong2.Size = new System.Drawing.Size(112, 19);
			this.lbl_addwrong2.TabIndex = 19;
			this.lbl_addwrong2.Text = "Wrong spelling2:";
			this.lbl_addwrong2.Visible = false;
			// 
			// txt_wrong3
			// 
			this.txt_wrong3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_wrong3.Location = new System.Drawing.Point(330, 375);
			this.txt_wrong3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_wrong3.Name = "txt_wrong3";
			this.txt_wrong3.Size = new System.Drawing.Size(192, 20);
			this.txt_wrong3.TabIndex = 22;
			this.txt_wrong3.Visible = false;
			// 
			// lbl_addwrong3
			// 
			this.lbl_addwrong3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_addwrong3.AutoSize = true;
			this.lbl_addwrong3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addwrong3.ForeColor = System.Drawing.Color.White;
			this.lbl_addwrong3.Location = new System.Drawing.Point(219, 372);
			this.lbl_addwrong3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_addwrong3.Name = "lbl_addwrong3";
			this.lbl_addwrong3.Size = new System.Drawing.Size(112, 19);
			this.lbl_addwrong3.TabIndex = 21;
			this.lbl_addwrong3.Text = "Wrong spelling3:";
			this.lbl_addwrong3.Visible = false;
			// 
			// btn_add
			// 
			this.btn_add.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Location = new System.Drawing.Point(329, 404);
			this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(193, 43);
			this.btn_add.TabIndex = 23;
			this.btn_add.Text = "Add the word";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_selectsound
			// 
			this.btn_selectsound.Location = new System.Drawing.Point(525, 249);
			this.btn_selectsound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_selectsound.Name = "btn_selectsound";
			this.btn_selectsound.Size = new System.Drawing.Size(24, 19);
			this.btn_selectsound.TabIndex = 24;
			this.btn_selectsound.Text = "...";
			this.btn_selectsound.UseVisualStyleBackColor = true;
			this.btn_selectsound.Visible = false;
			this.btn_selectsound.Click += new System.EventHandler(this.btn_selectsound_Click);
			// 
			// btn_slctpic
			// 
			this.btn_slctpic.Location = new System.Drawing.Point(525, 280);
			this.btn_slctpic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_slctpic.Name = "btn_slctpic";
			this.btn_slctpic.Size = new System.Drawing.Size(24, 19);
			this.btn_slctpic.TabIndex = 25;
			this.btn_slctpic.Text = "...";
			this.btn_slctpic.UseVisualStyleBackColor = true;
			this.btn_slctpic.Visible = false;
			this.btn_slctpic.Click += new System.EventHandler(this.btn_slctpic_Click);
			// 
			// frm_add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(802, 494);
			this.Controls.Add(this.btn_slctpic);
			this.Controls.Add(this.btn_selectsound);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.txt_wrong3);
			this.Controls.Add(this.lbl_addwrong3);
			this.Controls.Add(this.txt_wrong2);
			this.Controls.Add(this.lbl_addwrong2);
			this.Controls.Add(this.txt_wrong1);
			this.Controls.Add(this.lbl_addwrong1);
			this.Controls.Add(this.txt_addpic);
			this.Controls.Add(this.lbl_addpic);
			this.Controls.Add(this.txt_addsound);
			this.Controls.Add(this.lbl_addsound);
			this.Controls.Add(this.txt_addword);
			this.Controls.Add(this.lbl_word);
			this.Controls.Add(this.lbl_filldir);
			this.Controls.Add(this.cbx_games);
			this.Controls.Add(this.cbx_spelling);
			this.Controls.Add(this.pbx_plusign);
			this.Controls.Add(this.lbl_entery);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frm_add";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pbx_plusign)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_entery;
        private System.Windows.Forms.PictureBox pbx_plusign;
        private System.Windows.Forms.CheckBox cbx_spelling;
        private System.Windows.Forms.CheckBox cbx_games;
        private System.Windows.Forms.Label lbl_filldir;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.TextBox txt_addword;
        private System.Windows.Forms.TextBox txt_addsound;
        private System.Windows.Forms.Label lbl_addsound;
        private System.Windows.Forms.TextBox txt_addpic;
        private System.Windows.Forms.Label lbl_addpic;
        private System.Windows.Forms.TextBox txt_wrong1;
        private System.Windows.Forms.Label lbl_addwrong1;
        private System.Windows.Forms.TextBox txt_wrong2;
        private System.Windows.Forms.Label lbl_addwrong2;
        private System.Windows.Forms.TextBox txt_wrong3;
        private System.Windows.Forms.Label lbl_addwrong3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_selectsound;
        private System.Windows.Forms.Button btn_slctpic;
    }
}