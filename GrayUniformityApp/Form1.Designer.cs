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
            this.label_WinInterval = new System.Windows.Forms.Label();
            this.txtWinsInterval = new System.Windows.Forms.TextBox();
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
            this.label_FileName = new System.Windows.Forms.Label();
            this.btnShowOutline = new System.Windows.Forms.Button();
            this.label_position = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Pctbx = new System.Windows.Forms.TableLayoutPanel();
            this.pctbx_Display = new System.Windows.Forms.PictureBox();
            this.grpbox_WinSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Data)).BeginInit();
            this.tableLayoutPanel_Pctbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox_WinSetting
            // 
            this.grpbox_WinSetting.Controls.Add(this.label_WinInterval);
            this.grpbox_WinSetting.Controls.Add(this.txtWinsInterval);
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
            this.grpbox_WinSetting.Location = new System.Drawing.Point(845, 50);
            this.grpbox_WinSetting.Name = "grpbox_WinSetting";
            this.grpbox_WinSetting.Size = new System.Drawing.Size(326, 272);
            this.grpbox_WinSetting.TabIndex = 1;
            this.grpbox_WinSetting.TabStop = false;
            this.grpbox_WinSetting.Text = "Windows setting：";
            // 
            // label_WinInterval
            // 
            this.label_WinInterval.AutoSize = true;
            this.label_WinInterval.Location = new System.Drawing.Point(6, 118);
            this.label_WinInterval.Name = "label_WinInterval";
            this.label_WinInterval.Size = new System.Drawing.Size(184, 20);
            this.label_WinInterval.TabIndex = 10;
            this.label_WinInterval.Text = "Interval Between Wins:";
            // 
            // txtWinsInterval
            // 
            this.txtWinsInterval.Location = new System.Drawing.Point(220, 115);
            this.txtWinsInterval.Name = "txtWinsInterval";
            this.txtWinsInterval.Size = new System.Drawing.Size(100, 31);
            this.txtWinsInterval.TabIndex = 9;
            this.txtWinsInterval.Text = "20";
            // 
            // txt1WinY
            // 
            this.txt1WinY.Location = new System.Drawing.Point(220, 220);
            this.txt1WinY.Name = "txt1WinY";
            this.txt1WinY.Size = new System.Drawing.Size(100, 31);
            this.txt1WinY.TabIndex = 8;
            // 
            // txt1WinX
            // 
            this.txt1WinX.Location = new System.Drawing.Point(220, 180);
            this.txt1WinX.Name = "txt1WinX";
            this.txt1WinX.Size = new System.Drawing.Size(100, 31);
            this.txt1WinX.TabIndex = 7;
            // 
            // txtWinSize
            // 
            this.txtWinSize.Location = new System.Drawing.Point(220, 75);
            this.txtWinSize.Name = "txtWinSize";
            this.txtWinSize.Size = new System.Drawing.Size(100, 31);
            this.txtWinSize.TabIndex = 6;
            this.txtWinSize.Text = "100";
            // 
            // txtWinNum
            // 
            this.txtWinNum.Enabled = false;
            this.txtWinNum.Location = new System.Drawing.Point(220, 36);
            this.txtWinNum.Name = "txtWinNum";
            this.txtWinNum.Size = new System.Drawing.Size(100, 31);
            this.txtWinNum.TabIndex = 5;
            this.txtWinNum.Text = "9";
            // 
            // label_1st_y
            // 
            this.label_1st_y.AutoSize = true;
            this.label_1st_y.Location = new System.Drawing.Point(43, 220);
            this.label_1st_y.Name = "label_1st_y";
            this.label_1st_y.Size = new System.Drawing.Size(23, 20);
            this.label_1st_y.TabIndex = 4;
            this.label_1st_y.Text = "y:";
            // 
            // label_1st_x
            // 
            this.label_1st_x.AutoSize = true;
            this.label_1st_x.Location = new System.Drawing.Point(43, 183);
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
            this.label_1stWinSet.Location = new System.Drawing.Point(6, 151);
            this.label_1stWinSet.Name = "label_1stWinSet";
            this.label_1stWinSet.Size = new System.Drawing.Size(226, 20);
            this.label_1stWinSet.TabIndex = 0;
            this.label_1stWinSet.Text = "1st Window Left Top Point : ";
            // 
            // btn_DrawWin
            // 
            this.btn_DrawWin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DrawWin.Location = new System.Drawing.Point(940, 328);
            this.btn_DrawWin.Name = "btn_DrawWin";
            this.btn_DrawWin.Size = new System.Drawing.Size(137, 48);
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
            this.dataGrid_Data.Location = new System.Drawing.Point(796, 394);
            this.dataGrid_Data.Name = "dataGrid_Data";
            this.dataGrid_Data.RowTemplate.Height = 27;
            this.dataGrid_Data.Size = new System.Drawing.Size(441, 265);
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
            this.btnLoadImg.Location = new System.Drawing.Point(125, 614);
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
            this.btnConduct.Location = new System.Drawing.Point(328, 614);
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
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_FileName.Location = new System.Drawing.Point(3, 543);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(727, 15);
            this.label_FileName.TabIndex = 6;
            this.label_FileName.Text = "File Path";
            this.label_FileName.Visible = false;
            // 
            // btnShowOutline
            // 
            this.btnShowOutline.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowOutline.Location = new System.Drawing.Point(534, 614);
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
            this.label_position.Location = new System.Drawing.Point(34, 9);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(165, 15);
            this.label_position.TabIndex = 9;
            this.label_position.Text = "(x, y) = ( 0, 0)     Gray = ()";
            // 
            // tableLayoutPanel_Pctbx
            // 
            this.tableLayoutPanel_Pctbx.ColumnCount = 1;
            this.tableLayoutPanel_Pctbx.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Pctbx.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Pctbx.Controls.Add(this.pctbx_Display, 0, 0);
            this.tableLayoutPanel_Pctbx.Controls.Add(this.label_FileName, 0, 1);
            this.tableLayoutPanel_Pctbx.Location = new System.Drawing.Point(37, 36);
            this.tableLayoutPanel_Pctbx.Name = "tableLayoutPanel_Pctbx";
            this.tableLayoutPanel_Pctbx.RowCount = 2;
            this.tableLayoutPanel_Pctbx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.80286F));
            this.tableLayoutPanel_Pctbx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.197133F));
            this.tableLayoutPanel_Pctbx.Size = new System.Drawing.Size(733, 558);
            this.tableLayoutPanel_Pctbx.TabIndex = 10;
            this.tableLayoutPanel_Pctbx.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Pctbx_Paint);
            // 
            // pctbx_Display
            // 
            this.pctbx_Display.BackColor = System.Drawing.Color.MintCream;
            this.pctbx_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbx_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbx_Display.Location = new System.Drawing.Point(3, 3);
            this.pctbx_Display.Name = "pctbx_Display";
            this.pctbx_Display.Size = new System.Drawing.Size(727, 522);
            this.pctbx_Display.TabIndex = 10;
            this.pctbx_Display.TabStop = false;
            this.pctbx_Display.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pctbx_Display_MouseWheel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 691);
            this.Controls.Add(this.tableLayoutPanel_Pctbx);
            this.Controls.Add(this.label_position);
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
            this.tableLayoutPanel_Pctbx.ResumeLayout(false);
            this.tableLayoutPanel_Pctbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbox_WinSetting;
        private System.Windows.Forms.Label label_WinInterval;
        private System.Windows.Forms.TextBox txtWinsInterval;
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
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.Button btnShowOutline;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Pctbx;
        private System.Windows.Forms.PictureBox pctbx_Display;
    }
}

