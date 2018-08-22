namespace GrayUniformityApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbox_WinSetting = new System.Windows.Forms.GroupBox();
            this.txtWinsVerInterval = new System.Windows.Forms.TextBox();
            this.label_WinInterval_Ver = new System.Windows.Forms.Label();
            this.label_WinInterval_Hor = new System.Windows.Forms.Label();
            this.txtWinsHorInterval = new System.Windows.Forms.TextBox();
            this.txt1WinY = new System.Windows.Forms.TextBox();
            this.txt1WinX = new System.Windows.Forms.TextBox();
            this.txtWinSize = new System.Windows.Forms.TextBox();
            this.txtWinNum = new System.Windows.Forms.TextBox();
            this.label_1st_y = new System.Windows.Forms.Label();
            this.label_1st_x = new System.Windows.Forms.Label();
            this.label_WinSize = new System.Windows.Forms.Label();
            this.label_WinNumber = new System.Windows.Forms.Label();
            this.label_1stWinSet = new System.Windows.Forms.Label();
            this.btn_DrawWin = new System.Windows.Forms.Button();
            this.dataGrid_Data = new System.Windows.Forms.DataGridView();
            this.WinNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrayMean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinGray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxGray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnConduct = new System.Windows.Forms.Button();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnShowOutline = new System.Windows.Forms.Button();
            this.label_position = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_FileName = new System.Windows.Forms.Label();
            this.pctbx_Display = new System.Windows.Forms.PictureBox();
            this.grpbox_WinSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Data)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox_WinSetting
            // 
            this.grpbox_WinSetting.Controls.Add(this.txtWinsVerInterval);
            this.grpbox_WinSetting.Controls.Add(this.label_WinInterval_Ver);
            this.grpbox_WinSetting.Controls.Add(this.label_WinInterval_Hor);
            this.grpbox_WinSetting.Controls.Add(this.txtWinsHorInterval);
            this.grpbox_WinSetting.Controls.Add(this.txt1WinY);
            this.grpbox_WinSetting.Controls.Add(this.txt1WinX);
            this.grpbox_WinSetting.Controls.Add(this.txtWinSize);
            this.grpbox_WinSetting.Controls.Add(this.txtWinNum);
            this.grpbox_WinSetting.Controls.Add(this.label_1st_y);
            this.grpbox_WinSetting.Controls.Add(this.label_1st_x);
            this.grpbox_WinSetting.Controls.Add(this.label_WinSize);
            this.grpbox_WinSetting.Controls.Add(this.label_WinNumber);
            this.grpbox_WinSetting.Controls.Add(this.label_1stWinSet);
            this.grpbox_WinSetting.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpbox_WinSetting.Location = new System.Drawing.Point(809, 50);
            this.grpbox_WinSetting.Name = "grpbox_WinSetting";
            this.grpbox_WinSetting.Size = new System.Drawing.Size(374, 310);
            this.grpbox_WinSetting.TabIndex = 1;
            this.grpbox_WinSetting.TabStop = false;
            this.grpbox_WinSetting.Text = "Windows setting：";
            // 
            // txtWinsVerInterval
            // 
            this.txtWinsVerInterval.Location = new System.Drawing.Point(244, 153);
            this.txtWinsVerInterval.Name = "txtWinsVerInterval";
            this.txtWinsVerInterval.Size = new System.Drawing.Size(99, 31);
            this.txtWinsVerInterval.TabIndex = 12;
            this.txtWinsVerInterval.Text = "20";
            // 
            // label_WinInterval_Ver
            // 
            this.label_WinInterval_Ver.AutoSize = true;
            this.label_WinInterval_Ver.Location = new System.Drawing.Point(8, 153);
            this.label_WinInterval_Ver.Name = "label_WinInterval_Ver";
            this.label_WinInterval_Ver.Size = new System.Drawing.Size(222, 20);
            this.label_WinInterval_Ver.TabIndex = 11;
            this.label_WinInterval_Ver.Text = "Ver. Interval Between Wins:";
            // 
            // label_WinInterval_Hor
            // 
            this.label_WinInterval_Hor.AutoSize = true;
            this.label_WinInterval_Hor.Location = new System.Drawing.Point(6, 118);
            this.label_WinInterval_Hor.Name = "label_WinInterval_Hor";
            this.label_WinInterval_Hor.Size = new System.Drawing.Size(223, 20);
            this.label_WinInterval_Hor.TabIndex = 10;
            this.label_WinInterval_Hor.Text = "Hor. Interval Between Wins:";
            // 
            // txtWinsHorInterval
            // 
            this.txtWinsHorInterval.Location = new System.Drawing.Point(243, 115);
            this.txtWinsHorInterval.Name = "txtWinsHorInterval";
            this.txtWinsHorInterval.Size = new System.Drawing.Size(100, 31);
            this.txtWinsHorInterval.TabIndex = 9;
            this.txtWinsHorInterval.Text = "350";
            // 
            // txt1WinY
            // 
            this.txt1WinY.Location = new System.Drawing.Point(243, 261);
            this.txt1WinY.Name = "txt1WinY";
            this.txt1WinY.Size = new System.Drawing.Size(100, 31);
            this.txt1WinY.TabIndex = 8;
            this.txt1WinY.Text = "180";
            // 
            // txt1WinX
            // 
            this.txt1WinX.Location = new System.Drawing.Point(243, 221);
            this.txt1WinX.Name = "txt1WinX";
            this.txt1WinX.Size = new System.Drawing.Size(100, 31);
            this.txt1WinX.TabIndex = 7;
            this.txt1WinX.Text = "350";
            // 
            // txtWinSize
            // 
            this.txtWinSize.Location = new System.Drawing.Point(243, 75);
            this.txtWinSize.Name = "txtWinSize";
            this.txtWinSize.Size = new System.Drawing.Size(100, 31);
            this.txtWinSize.TabIndex = 6;
            this.txtWinSize.Text = "150";
            // 
            // txtWinNum
            // 
            this.txtWinNum.Enabled = false;
            this.txtWinNum.Location = new System.Drawing.Point(243, 36);
            this.txtWinNum.Name = "txtWinNum";
            this.txtWinNum.Size = new System.Drawing.Size(100, 31);
            this.txtWinNum.TabIndex = 5;
            this.txtWinNum.Text = "9";
            // 
            // label_1st_y
            // 
            this.label_1st_y.AutoSize = true;
            this.label_1st_y.Location = new System.Drawing.Point(43, 261);
            this.label_1st_y.Name = "label_1st_y";
            this.label_1st_y.Size = new System.Drawing.Size(23, 20);
            this.label_1st_y.TabIndex = 4;
            this.label_1st_y.Text = "y:";
            // 
            // label_1st_x
            // 
            this.label_1st_x.AutoSize = true;
            this.label_1st_x.Location = new System.Drawing.Point(43, 224);
            this.label_1st_x.Name = "label_1st_x";
            this.label_1st_x.Size = new System.Drawing.Size(23, 20);
            this.label_1st_x.TabIndex = 3;
            this.label_1st_x.Text = "x:";
            // 
            // label_WinSize
            // 
            this.label_WinSize.AutoSize = true;
            this.label_WinSize.Location = new System.Drawing.Point(6, 78);
            this.label_WinSize.Name = "label_WinSize";
            this.label_WinSize.Size = new System.Drawing.Size(124, 20);
            this.label_WinSize.TabIndex = 2;
            this.label_WinSize.Text = "Window\'s Size:";
            // 
            // label_WinNumber
            // 
            this.label_WinNumber.AutoSize = true;
            this.label_WinNumber.Location = new System.Drawing.Point(6, 39);
            this.label_WinNumber.Name = "label_WinNumber";
            this.label_WinNumber.Size = new System.Drawing.Size(151, 20);
            this.label_WinNumber.TabIndex = 1;
            this.label_WinNumber.Text = "Windows Number:";
            // 
            // label_1stWinSet
            // 
            this.label_1stWinSet.AutoSize = true;
            this.label_1stWinSet.Location = new System.Drawing.Point(6, 192);
            this.label_1stWinSet.Name = "label_1stWinSet";
            this.label_1stWinSet.Size = new System.Drawing.Size(226, 20);
            this.label_1stWinSet.TabIndex = 0;
            this.label_1stWinSet.Text = "1st Window Left Top Point : ";
            // 
            // btn_DrawWin
            // 
            this.btn_DrawWin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DrawWin.Location = new System.Drawing.Point(903, 366);
            this.btn_DrawWin.Name = "btn_DrawWin";
            this.btn_DrawWin.Size = new System.Drawing.Size(170, 48);
            this.btn_DrawWin.TabIndex = 2;
            this.btn_DrawWin.Text = "Draw Windows";
            this.btn_DrawWin.UseVisualStyleBackColor = true;
            this.btn_DrawWin.Click += new System.EventHandler(this.btn_DrawWin_Click);
            // 
            // dataGrid_Data
            // 
            this.dataGrid_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WinNo,
            this.GrayMean,
            this.MinGray,
            this.MaxGray});
            this.dataGrid_Data.Location = new System.Drawing.Point(760, 429);
            this.dataGrid_Data.Name = "dataGrid_Data";
            this.dataGrid_Data.RowTemplate.Height = 27;
            this.dataGrid_Data.Size = new System.Drawing.Size(444, 242);
            this.dataGrid_Data.TabIndex = 3;
            // 
            // WinNo
            // 
            this.WinNo.HeaderText = "Win No";
            this.WinNo.Name = "WinNo";
            // 
            // GrayMean
            // 
            this.GrayMean.HeaderText = "Mean";
            this.GrayMean.Name = "GrayMean";
            // 
            // MinGray
            // 
            this.MinGray.HeaderText = "Min Gray";
            this.MinGray.Name = "MinGray";
            // 
            // MaxGray
            // 
            this.MaxGray.HeaderText = "Max Gray";
            this.MaxGray.Name = "MaxGray";
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoadImg.Location = new System.Drawing.Point(97, 626);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(123, 45);
            this.btnLoadImg.TabIndex = 4;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // btnConduct
            // 
            this.btnConduct.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConduct.Location = new System.Drawing.Point(300, 626);
            this.btnConduct.Name = "btnConduct";
            this.btnConduct.Size = new System.Drawing.Size(121, 45);
            this.btnConduct.TabIndex = 5;
            this.btnConduct.Text = "Calculate";
            this.btnConduct.UseVisualStyleBackColor = true;
            this.btnConduct.Click += new System.EventHandler(this.btnConduct_Click);
            // 
            // openImgDialog
            // 
            this.openImgDialog.FileName = "openFileDialog1";
            // 
            // btnShowOutline
            // 
            this.btnShowOutline.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowOutline.Location = new System.Drawing.Point(506, 626);
            this.btnShowOutline.Name = "btnShowOutline";
            this.btnShowOutline.Size = new System.Drawing.Size(147, 45);
            this.btnShowOutline.TabIndex = 7;
            this.btnShowOutline.Text = "Show Outline";
            this.btnShowOutline.UseVisualStyleBackColor = true;
            this.btnShowOutline.Click += new System.EventHandler(this.btnShowOutline_Click);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_position.Location = new System.Drawing.Point(542, 525);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(159, 27);
            this.label_position.TabIndex = 9;
            this.label_position.Text = "(x, y) = ( 0, 0) || Gray = ()";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_FileName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pctbx_Display, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_position, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.1087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.891304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 575);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Location = new System.Drawing.Point(3, 552);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(58, 15);
            this.label_FileName.TabIndex = 11;
            this.label_FileName.Text = "File Path";
            this.label_FileName.Visible = false;
            // 
            // pctbx_Display
            // 
            this.pctbx_Display.BackColor = System.Drawing.Color.MintCream;
            this.pctbx_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbx_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbx_Display.Location = new System.Drawing.Point(3, 3);
            this.pctbx_Display.Name = "pctbx_Display";
            this.pctbx_Display.Size = new System.Drawing.Size(698, 519);
            this.pctbx_Display.TabIndex = 10;
            this.pctbx_Display.TabStop = false;
            this.pctbx_Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctbx_Display_MouseDown);
            this.pctbx_Display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctbx_Display_MouseMove);
            this.pctbx_Display.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pctbx_Display_MouseWheel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnShowOutline);
            this.Controls.Add(this.btnConduct);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.dataGrid_Data);
            this.Controls.Add(this.btn_DrawWin);
            this.Controls.Add(this.grpbox_WinSetting);
            this.Name = "MainForm";
            this.Text = "Gray Uniformity Test";
            this.grpbox_WinSetting.ResumeLayout(false);
            this.grpbox_WinSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Data)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbox_WinSetting;
        private System.Windows.Forms.Label label_WinInterval_Hor;
        private System.Windows.Forms.TextBox txtWinsHorInterval;
        private System.Windows.Forms.TextBox txt1WinY;
        private System.Windows.Forms.TextBox txt1WinX;
        private System.Windows.Forms.TextBox txtWinSize;
        private System.Windows.Forms.TextBox txtWinNum;
        private System.Windows.Forms.Label label_1st_y;
        private System.Windows.Forms.Label label_1st_x;
        private System.Windows.Forms.Label label_WinSize;
        private System.Windows.Forms.Label label_WinNumber;
        private System.Windows.Forms.Label label_1stWinSet;
        private System.Windows.Forms.Button btn_DrawWin;
        private System.Windows.Forms.DataGridView dataGrid_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrayMean;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinGray;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxGray;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnConduct;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
        private System.Windows.Forms.Button btnShowOutline;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.PictureBox pctbx_Display;
        private System.Windows.Forms.Label label_WinInterval_Ver;
        private System.Windows.Forms.TextBox txtWinsVerInterval;
    }
}

