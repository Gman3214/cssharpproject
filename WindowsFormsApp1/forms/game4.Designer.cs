
namespace exam
{
    partial class gamefour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamefour));
            this.pic_right = new System.Windows.Forms.PictureBox();
            this.pic_left = new System.Windows.Forms.PictureBox();
            this.btn_sound = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_enco = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_points = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_right
            // 
            this.pic_right.Location = new System.Drawing.Point(927, 272);
            this.pic_right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_right.Name = "pic_right";
            this.pic_right.Size = new System.Drawing.Size(313, 263);
            this.pic_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_right.TabIndex = 0;
            this.pic_right.TabStop = false;
            this.pic_right.Click += new System.EventHandler(this.pic_right_Click);
            // 
            // pic_left
            // 
            this.pic_left.Location = new System.Drawing.Point(235, 272);
            this.pic_left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_left.Name = "pic_left";
            this.pic_left.Size = new System.Drawing.Size(313, 263);
            this.pic_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_left.TabIndex = 1;
            this.pic_left.TabStop = false;
            this.pic_left.Click += new System.EventHandler(this.pic_left_Click);
            // 
            // btn_sound
            // 
            this.btn_sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_sound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sound.Image = ((System.Drawing.Image)(resources.GetObject("btn_sound.Image")));
            this.btn_sound.Location = new System.Drawing.Point(612, 151);
            this.btn_sound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(252, 207);
            this.btn_sound.TabIndex = 2;
            this.btn_sound.Text = "PLAY!";
            this.btn_sound.UseVisualStyleBackColor = true;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_title.Location = new System.Drawing.Point(127, 42);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(917, 59);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "press on the pic corresponding to the sound";
            // 
            // lbl_enco
            // 
            this.lbl_enco.AutoSize = true;
            this.lbl_enco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_enco.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_enco.Location = new System.Drawing.Point(443, 564);
            this.lbl_enco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_enco.Name = "lbl_enco";
            this.lbl_enco.Size = new System.Drawing.Size(79, 29);
            this.lbl_enco.TabIndex = 4;
            this.lbl_enco.Text = "label1";
            this.lbl_enco.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(612, 379);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(252, 156);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_points.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_points.Location = new System.Drawing.Point(927, 151);
            this.lbl_points.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(0, 44);
            this.lbl_points.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_time.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_time.Location = new System.Drawing.Point(235, 151);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(59, 29);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "time";
            // 
            // gamefour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1517, 747);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_enco);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_sound);
            this.Controls.Add(this.pic_left);
            this.Controls.Add(this.pic_right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gamefour";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pic_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_right;
        private System.Windows.Forms.PictureBox pic_left;
        private System.Windows.Forms.Button btn_sound;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_enco;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
    }
}