namespace sajad_slider
{
    partial class slider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slider));
            this.back = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.zoomout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackgroundImage = global::sajad_slider.Properties.Resources.icons8_back_48;
            this.back.Location = new System.Drawing.Point(105, 371);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 49);
            this.back.TabIndex = 6;
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // change
            // 
            this.change.BackgroundImage = global::sajad_slider.Properties.Resources.icons8_next_50;
            this.change.Location = new System.Drawing.Point(608, 371);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(57, 49);
            this.change.TabIndex = 5;
            this.change.UseVisualStyleBackColor = true;
            this.change.Visible = false;
            this.change.Click += new System.EventHandler(this.next_Click);
            // 
            // zoomout
            // 
            this.zoomout.ForeColor = System.Drawing.Color.White;
            this.zoomout.Image = global::sajad_slider.Properties.Resources.icons8_zoom_out_48;
            this.zoomout.Location = new System.Drawing.Point(36, 108);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(63, 64);
            this.zoomout.TabIndex = 4;
            this.zoomout.UseVisualStyleBackColor = true;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::sajad_slider.Properties.Resources.icons8_browse_64;
            this.button1.Location = new System.Drawing.Point(671, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 61);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browser);
            // 
            // zoomin
            // 
            this.zoomin.ForeColor = System.Drawing.Color.White;
            this.zoomin.Image = global::sajad_slider.Properties.Resources.icons8_zoom_in_481;
            this.zoomin.Location = new System.Drawing.Point(37, 178);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(62, 64);
            this.zoomin.TabIndex = 1;
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // images
            // 
            this.images.Image = global::sajad_slider.Properties.Resources._404_error_300x225;
            this.images.Location = new System.Drawing.Point(105, 108);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(560, 257);
            this.images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.images.TabIndex = 0;
            this.images.TabStop = false;
            // 
            // slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 432);
            this.Controls.Add(this.back);
            this.Controls.Add(this.change);
            this.Controls.Add(this.zoomout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zoomin);
            this.Controls.Add(this.images);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "slider";
            this.Text = "slider";
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button back;
    }
}

