
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_hanged)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_hanged
            // 
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
            this.txt_nextl.Location = new System.Drawing.Point(522, 117);
            this.txt_nextl.Name = "txt_nextl";
            this.txt_nextl.Size = new System.Drawing.Size(20, 20);
            this.txt_nextl.TabIndex = 1;
            this.txt_nextl.UseWaitCursor = true;
            this.txt_nextl.TextChanged += new System.EventHandler(this.txt_nextl_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(397, 89);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(276, 25);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "enter the next letter in the word";
            this.lbl_title.UseWaitCursor = true;
            // 
            // lbl_gusses
            // 
            this.lbl_gusses.AutoSize = true;
            this.lbl_gusses.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gusses.ForeColor = System.Drawing.Color.White;
            this.lbl_gusses.Location = new System.Drawing.Point(318, 192);
            this.lbl_gusses.Name = "lbl_gusses";
            this.lbl_gusses.Size = new System.Drawing.Size(88, 106);
            this.lbl_gusses.TabIndex = 3;
            this.lbl_gusses.Text = "0";
            this.lbl_gusses.UseWaitCursor = true;
            this.lbl_gusses.Visible = false;
            // 
            // btn_submit
            // 
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
            // gameone
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1138, 607);
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
    }
}