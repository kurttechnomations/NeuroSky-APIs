namespace Neurosky
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_dis = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radio_att = new System.Windows.Forms.RadioButton();
            this.radio_me = new System.Windows.Forms.RadioButton();
            this.radio_blink = new System.Windows.Forms.RadioButton();
            this.picConnectionStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_connect.ForeColor = System.Drawing.Color.Red;
            this.btn_connect.Location = new System.Drawing.Point(14, 32);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(157, 32);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_dis
            // 
            this.btn_dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dis.ForeColor = System.Drawing.Color.Red;
            this.btn_dis.Location = new System.Drawing.Point(14, 81);
            this.btn_dis.Name = "btn_dis";
            this.btn_dis.Size = new System.Drawing.Size(157, 35);
            this.btn_dis.TabIndex = 0;
            this.btn_dis.Text = "DISCONNECT";
            this.btn_dis.UseVisualStyleBackColor = false;
            this.btn_dis.Click += new System.EventHandler(this.btn_dis_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.Location = new System.Drawing.Point(14, 307);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(339, 43);
            this.progressBar1.TabIndex = 4;
            // 
            // radio_att
            // 
            this.radio_att.AutoSize = true;
            this.radio_att.Checked = true;
            this.radio_att.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_att.ForeColor = System.Drawing.Color.White;
            this.radio_att.Location = new System.Drawing.Point(28, 147);
            this.radio_att.Name = "radio_att";
            this.radio_att.Size = new System.Drawing.Size(188, 35);
            this.radio_att.TabIndex = 5;
            this.radio_att.TabStop = true;
            this.radio_att.Text = "ATTENTION";
            this.radio_att.UseVisualStyleBackColor = true;
            // 
            // radio_me
            // 
            this.radio_me.AutoSize = true;
            this.radio_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_me.ForeColor = System.Drawing.Color.White;
            this.radio_me.Location = new System.Drawing.Point(28, 189);
            this.radio_me.Name = "radio_me";
            this.radio_me.Size = new System.Drawing.Size(201, 35);
            this.radio_me.TabIndex = 5;
            this.radio_me.Text = "MEDITATION";
            this.radio_me.UseVisualStyleBackColor = true;
            // 
            // radio_blink
            // 
            this.radio_blink.AutoSize = true;
            this.radio_blink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio_blink.ForeColor = System.Drawing.Color.White;
            this.radio_blink.Location = new System.Drawing.Point(28, 231);
            this.radio_blink.Name = "radio_blink";
            this.radio_blink.Size = new System.Drawing.Size(111, 35);
            this.radio_blink.TabIndex = 5;
            this.radio_blink.Text = "BLINK";
            this.radio_blink.UseVisualStyleBackColor = true;
            // 
            // picConnectionStatus
            // 
            this.picConnectionStatus.Image = ((System.Drawing.Image)(resources.GetObject("picConnectionStatus.Image")));
            this.picConnectionStatus.Location = new System.Drawing.Point(375, 12);
            this.picConnectionStatus.Name = "picConnectionStatus";
            this.picConnectionStatus.Size = new System.Drawing.Size(106, 95);
            this.picConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConnectionStatus.TabIndex = 6;
            this.picConnectionStatus.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Neurosky.Properties.Resources.off;
            this.pictureBox1.Location = new System.Drawing.Point(375, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.BackColor = System.Drawing.Color.Transparent;
            this.lb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_value.ForeColor = System.Drawing.Color.Red;
            this.lb_value.Location = new System.Drawing.Point(136, 269);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(23, 33);
            this.lb_value.TabIndex = 7;
            this.lb_value.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 370);
            this.Controls.Add(this.lb_value);
            this.Controls.Add(this.picConnectionStatus);
            this.Controls.Add(this.radio_blink);
            this.Controls.Add(this.radio_me);
            this.Controls.Add(this.radio_att);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_dis);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_dis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radio_att;
        private System.Windows.Forms.RadioButton radio_me;
        private System.Windows.Forms.RadioButton radio_blink;
        private System.Windows.Forms.PictureBox picConnectionStatus;
        private System.Windows.Forms.Label lb_value;
    }
}

