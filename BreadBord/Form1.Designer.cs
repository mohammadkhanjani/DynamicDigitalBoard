namespace BreadBord
{
    partial class ADBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADBoard));
            this.bread = new AdBoard.AdBoard();
            this.change = new System.Windows.Forms.HScrollBar();
            this.text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bread
            // 
            this.bread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bread.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bread.BackColor = System.Drawing.Color.Black;
            this.bread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bread.Interval = 40;
            this.bread.Location = new System.Drawing.Point(3, 121);
            this.bread.MaximumSize = new System.Drawing.Size(1000, 55);
            this.bread.Message = "Mohammad Khanjani                                    ";
            this.bread.MinimumSize = new System.Drawing.Size(55, 55);
            this.bread.Name = "bread";
            this.bread.Size = new System.Drawing.Size(389, 55);
            this.bread.TabIndex = 1;
            // 
            // change
            // 
            this.change.LargeChange = 5;
            this.change.Location = new System.Drawing.Point(3, 96);
            this.change.Name = "change";
            this.change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.change.Size = new System.Drawing.Size(326, 17);
            this.change.TabIndex = 2;
            this.change.Value = 100;
            this.change.Scroll += new System.Windows.Forms.ScrollEventHandler(this.change_Scroll);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(3, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(203, 20);
            this.text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = " : پیغام خود را در این قسمت وارد کنید ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " : سرعت ";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(337, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(48, 50);
            this.close.TabIndex = 7;
            this.close.TabStop = false;
            this.toolTip5.SetToolTip(this.close, ".");
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // stop
            // 
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(84, 6);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(49, 50);
            this.stop.TabIndex = 10;
            this.stop.TabStop = false;
            this.toolTip2.SetToolTip(this.stop, ".");
            this.stop.Click += new System.EventHandler(this.stop_Click);
            this.stop.MouseLeave += new System.EventHandler(this.stop_MouseLeave);
            this.stop.MouseHover += new System.EventHandler(this.stop_MouseHover);
            // 
            // play
            // 
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(3, 6);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(49, 50);
            this.play.TabIndex = 11;
            this.play.TabStop = false;
            this.toolTip1.SetToolTip(this.play, ".");
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            this.play.MouseHover += new System.EventHandler(this.play_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 49);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox1, ".");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 49);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.toolTip4.SetToolTip(this.pictureBox2, ".");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "شروع";
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipTitle = "توقف ";
            // 
            // toolTip3
            // 
            this.toolTip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipTitle = "پاک کردن متن";
            // 
            // toolTip4
            // 
            this.toolTip4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip4.IsBalloon = true;
            this.toolTip4.ToolTipTitle = "پشتیبانی";
            // 
            // toolTip5
            // 
            this.toolTip5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolTip5.IsBalloon = true;
            this.toolTip5.ToolTipTitle = "بستن";
            // 
            // ADBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(397, 180);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.change);
            this.Controls.Add(this.bread);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ADBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADBoard";
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdBoard.AdBoard bread;
        private System.Windows.Forms.HScrollBar change;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

