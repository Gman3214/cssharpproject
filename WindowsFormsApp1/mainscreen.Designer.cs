
namespace exam
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_spelling = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_games = new System.Windows.Forms.Button();
            this.pnl_childfrm = new System.Windows.Forms.Panel();
            this.pix_start = new System.Windows.Forms.PictureBox();
            this.btn_submitmail = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_childfrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix_start)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnl_sidebar.Controls.Add(this.panel2);
            this.pnl_sidebar.Controls.Add(this.btn_spelling);
            this.pnl_sidebar.Controls.Add(this.btn_add);
            this.pnl_sidebar.Controls.Add(this.btn_games);
            this.pnl_sidebar.Location = new System.Drawing.Point(1, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(281, 611);
            this.pnl_sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(286, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 608);
            this.panel2.TabIndex = 1;
            // 
            // btn_spelling
            // 
            this.btn_spelling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_spelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_spelling.Enabled = false;
            this.btn_spelling.FlatAppearance.BorderSize = 0;
            this.btn_spelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_spelling.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spelling.ForeColor = System.Drawing.Color.White;
            this.btn_spelling.Image = ((System.Drawing.Image)(resources.GetObject("btn_spelling.Image")));
            this.btn_spelling.Location = new System.Drawing.Point(3, 260);
            this.btn_spelling.Name = "btn_spelling";
            this.btn_spelling.Size = new System.Drawing.Size(274, 74);
            this.btn_spelling.TabIndex = 2;
            this.btn_spelling.Text = "Spelling";
            this.btn_spelling.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_spelling.UseVisualStyleBackColor = false;
            this.btn_spelling.Click += new System.EventHandler(this.btn_spelling_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(0, 334);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(274, 74);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add a word";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_games
            // 
            this.btn_games.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_games.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_games.Enabled = false;
            this.btn_games.FlatAppearance.BorderSize = 0;
            this.btn_games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_games.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_games.ForeColor = System.Drawing.Color.White;
            this.btn_games.Image = ((System.Drawing.Image)(resources.GetObject("btn_games.Image")));
            this.btn_games.Location = new System.Drawing.Point(0, 187);
            this.btn_games.Name = "btn_games";
            this.btn_games.Size = new System.Drawing.Size(274, 74);
            this.btn_games.TabIndex = 1;
            this.btn_games.Text = "Games";
            this.btn_games.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_games.UseVisualStyleBackColor = false;
            this.btn_games.Click += new System.EventHandler(this.btn_games_Click);
            // 
            // pnl_childfrm
            // 
            this.pnl_childfrm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_childfrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnl_childfrm.Controls.Add(this.lbl_hello);
            this.pnl_childfrm.Controls.Add(this.pix_start);
            this.pnl_childfrm.Controls.Add(this.btn_submitmail);
            this.pnl_childfrm.Controls.Add(this.lbl_mail);
            this.pnl_childfrm.Controls.Add(this.txt_email);
            this.pnl_childfrm.Cursor = System.Windows.Forms.Cursors.No;
            this.pnl_childfrm.Location = new System.Drawing.Point(276, 0);
            this.pnl_childfrm.Name = "pnl_childfrm";
            this.pnl_childfrm.Size = new System.Drawing.Size(1070, 608);
            this.pnl_childfrm.TabIndex = 1;
            // 
            // pix_start
            // 
            this.pix_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pix_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pix_start.Image = ((System.Drawing.Image)(resources.GetObject("pix_start.Image")));
            this.pix_start.Location = new System.Drawing.Point(386, 93);
            this.pix_start.Name = "pix_start";
            this.pix_start.Size = new System.Drawing.Size(128, 128);
            this.pix_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pix_start.TabIndex = 3;
            this.pix_start.TabStop = false;
            // 
            // btn_submitmail
            // 
            this.btn_submitmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submitmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitmail.Location = new System.Drawing.Point(386, 317);
            this.btn_submitmail.Name = "btn_submitmail";
            this.btn_submitmail.Size = new System.Drawing.Size(138, 49);
            this.btn_submitmail.TabIndex = 2;
            this.btn_submitmail.Text = "LOG IN ";
            this.btn_submitmail.UseVisualStyleBackColor = true;
            this.btn_submitmail.Click += new System.EventHandler(this.btn_submitmail_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.ForeColor = System.Drawing.Color.White;
            this.lbl_mail.Location = new System.Drawing.Point(220, 266);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(216, 21);
            this.lbl_mail.TabIndex = 1;
            this.lbl_mail.Text = "pls enter your email here:";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(483, 265);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 22);
            this.txt_email.TabIndex = 0;
            // 
            // lbl_hello
            // 
            this.lbl_hello.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.ForeColor = System.Drawing.Color.White;
            this.lbl_hello.Location = new System.Drawing.Point(380, 405);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(76, 31);
            this.lbl_hello.TabIndex = 4;
            this.lbl_hello.Text = "label1";
            this.lbl_hello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_hello.Visible = false;
            // 
            // MainScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 604);
            this.Controls.Add(this.pnl_childfrm);
            this.Controls.Add(this.pnl_sidebar);
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.Text = "LEARN TO SPELL WITH GAMES AND FUN <3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_childfrm.ResumeLayout(false);
            this.pnl_childfrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Button btn_spelling;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_games;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_childfrm;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pix_start;
        private System.Windows.Forms.Button btn_submitmail;
        private System.Windows.Forms.Label lbl_hello;
    }
}

