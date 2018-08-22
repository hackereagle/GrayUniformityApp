namespace GrayUniformityApp
{
    partial class formOutline
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
            this.pctOrigImg = new System.Windows.Forms.PictureBox();
            this.pctHorOutline = new System.Windows.Forms.PictureBox();
            this.pctVerOutline = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkProfile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrigImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHorOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVerOutline)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctOrigImg
            // 
            this.pctOrigImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pctOrigImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctOrigImg.Location = new System.Drawing.Point(230, 3);
            this.pctOrigImg.Name = "pctOrigImg";
            this.pctOrigImg.Size = new System.Drawing.Size(740, 473);
            this.pctOrigImg.TabIndex = 0;
            this.pctOrigImg.TabStop = false;
            this.pctOrigImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctOrigImg_MouseDown);
            this.pctOrigImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctOrigImg_MouseMove);
            this.pctOrigImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctOrigImg_MouseUp);
            this.pctOrigImg.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pctOrigImg_MouseWheel);
            // 
            // pctHorOutline
            // 
            this.pctHorOutline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pctHorOutline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pctHorOutline.Location = new System.Drawing.Point(230, 488);
            this.pctHorOutline.Name = "pctHorOutline";
            this.pctHorOutline.Size = new System.Drawing.Size(740, 147);
            this.pctHorOutline.TabIndex = 1;
            this.pctHorOutline.TabStop = false;
            this.pctHorOutline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctHorOutline_MouseMove);
            // 
            // pctVerOutline
            // 
            this.pctVerOutline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pctVerOutline.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctVerOutline.Location = new System.Drawing.Point(3, 3);
            this.pctVerOutline.Name = "pctVerOutline";
            this.pctVerOutline.Size = new System.Drawing.Size(211, 473);
            this.pctVerOutline.TabIndex = 2;
            this.pctVerOutline.TabStop = false;
            this.pctVerOutline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctVerOutline_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.41568F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.58432F));
            this.tableLayoutPanel1.Controls.Add(this.pctVerOutline, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pctHorOutline, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pctOrigImg, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("新細明體", 12F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 638);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // chkProfile
            // 
            this.chkProfile.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkProfile.AutoSize = true;
            this.chkProfile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkProfile.Location = new System.Drawing.Point(442, 693);
            this.chkProfile.Name = "chkProfile";
            this.chkProfile.Size = new System.Drawing.Size(198, 35);
            this.chkProfile.TabIndex = 4;
            this.chkProfile.Text = "Profile Open/Close";
            this.chkProfile.UseVisualStyleBackColor = true;
            this.chkProfile.CheckedChanged += new System.EventHandler(this.chkProfile_CheckedChanged);
            // 
            // formOutline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 767);
            this.Controls.Add(this.chkProfile);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formOutline";
            this.Text = "Outline";
            this.Load += new System.EventHandler(this.formOutline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctOrigImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHorOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVerOutline)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctOrigImg;
        private System.Windows.Forms.PictureBox pctHorOutline;
        private System.Windows.Forms.PictureBox pctVerOutline;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkProfile;
    }
}