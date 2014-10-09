namespace irairabou
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.field = new System.Windows.Forms.Panel();
            this.Goal = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape24 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape23 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape22 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape21 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape20 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape19 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape18 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape17 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape16 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape15 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape14 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.playTimeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.field.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 438);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.field, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.27002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72998F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // field
            // 
            this.field.Controls.Add(this.Goal);
            this.field.Controls.Add(this.shapeContainer1);
            this.field.Location = new System.Drawing.Point(4, 4);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(452, 369);
            this.field.TabIndex = 0;
            // 
            // Goal
            // 
            this.Goal.AutoSize = true;
            this.Goal.Font = new System.Drawing.Font("メイリオ", 23F);
            this.Goal.Location = new System.Drawing.Point(384, 285);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(43, 47);
            this.Goal.TabIndex = 1;
            this.Goal.Text = "G";
            this.Goal.MouseEnter += new System.EventHandler(this.Goal_MouseEnter);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape24,
            this.lineShape23,
            this.lineShape22,
            this.lineShape21,
            this.lineShape20,
            this.lineShape19,
            this.lineShape18,
            this.lineShape17,
            this.lineShape16,
            this.lineShape15,
            this.lineShape14,
            this.lineShape13,
            this.lineShape12,
            this.lineShape11,
            this.lineShape10,
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(452, 369);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape24
            // 
            this.lineShape24.Name = "lineShape24";
            this.lineShape24.X1 = 340;
            this.lineShape24.X2 = 340;
            this.lineShape24.Y1 = 235;
            this.lineShape24.Y2 = 321;
            this.lineShape24.Click += new System.EventHandler(this.lineShape24_Click);
            this.lineShape24.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape23
            // 
            this.lineShape23.Name = "lineShape23";
            this.lineShape23.X1 = 360;
            this.lineShape23.X2 = 360;
            this.lineShape23.Y1 = 200;
            this.lineShape23.Y2 = 291;
            this.lineShape23.Click += new System.EventHandler(this.lineShape23_Click);
            this.lineShape23.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape22
            // 
            this.lineShape22.Name = "lineShape22";
            this.lineShape22.X1 = 380;
            this.lineShape22.X2 = 340;
            this.lineShape22.Y1 = 321;
            this.lineShape22.Y2 = 321;
            this.lineShape22.Click += new System.EventHandler(this.lineShape22_Click);
            this.lineShape22.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape21
            // 
            this.lineShape21.Name = "lineShape21";
            this.lineShape21.X1 = 380;
            this.lineShape21.X2 = 360;
            this.lineShape21.Y1 = 291;
            this.lineShape21.Y2 = 291;
            this.lineShape21.Click += new System.EventHandler(this.lineShape21_Click);
            this.lineShape21.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape20
            // 
            this.lineShape20.Name = "lineShape20";
            this.lineShape20.X1 = 55;
            this.lineShape20.X2 = 55;
            this.lineShape20.Y1 = 210;
            this.lineShape20.Y2 = 310;
            this.lineShape20.Click += new System.EventHandler(this.lineShape20_Click);
            this.lineShape20.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape19
            // 
            this.lineShape19.Name = "lineShape19";
            this.lineShape19.X1 = 25;
            this.lineShape19.X2 = 25;
            this.lineShape19.Y1 = 180;
            this.lineShape19.Y2 = 350;
            this.lineShape19.Click += new System.EventHandler(this.lineShape19_Click);
            this.lineShape19.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape18
            // 
            this.lineShape18.Name = "lineShape18";
            this.lineShape18.X1 = 360;
            this.lineShape18.X2 = 55;
            this.lineShape18.Y1 = 200;
            this.lineShape18.Y2 = 310;
            this.lineShape18.Click += new System.EventHandler(this.lineShape18_Click);
            this.lineShape18.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape17
            // 
            this.lineShape17.Name = "lineShape17";
            this.lineShape17.X1 = 340;
            this.lineShape17.X2 = 25;
            this.lineShape17.Y1 = 235;
            this.lineShape17.Y2 = 350;
            this.lineShape17.Click += new System.EventHandler(this.lineShape17_Click);
            this.lineShape17.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape16
            // 
            this.lineShape16.Name = "lineShape16";
            this.lineShape16.X1 = 433;
            this.lineShape16.X2 = 55;
            this.lineShape16.Y1 = 150;
            this.lineShape16.Y2 = 210;
            this.lineShape16.Click += new System.EventHandler(this.lineShape16_Click);
            this.lineShape16.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape15
            // 
            this.lineShape15.Name = "lineShape15";
            this.lineShape15.X1 = 403;
            this.lineShape15.X2 = 25;
            this.lineShape15.Y1 = 120;
            this.lineShape15.Y2 = 180;
            this.lineShape15.Click += new System.EventHandler(this.lineShape15_Click);
            this.lineShape15.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape14
            // 
            this.lineShape14.Name = "lineShape14";
            this.lineShape14.X1 = 380;
            this.lineShape14.X2 = 430;
            this.lineShape14.Y1 = 351;
            this.lineShape14.Y2 = 351;
            this.lineShape14.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape13
            // 
            this.lineShape13.Name = "lineShape13";
            this.lineShape13.X1 = 380;
            this.lineShape13.X2 = 380;
            this.lineShape13.Y1 = 321;
            this.lineShape13.Y2 = 351;
            this.lineShape13.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape12
            // 
            this.lineShape12.Name = "lineShape12";
            this.lineShape12.X1 = 380;
            this.lineShape12.X2 = 380;
            this.lineShape12.Y1 = 261;
            this.lineShape12.Y2 = 291;
            this.lineShape12.Click += new System.EventHandler(this.lineShape12_Click);
            this.lineShape12.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape11
            // 
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 380;
            this.lineShape11.X2 = 430;
            this.lineShape11.Y1 = 261;
            this.lineShape11.Y2 = 261;
            this.lineShape11.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape10
            // 
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 430;
            this.lineShape10.X2 = 430;
            this.lineShape10.Y1 = 261;
            this.lineShape10.Y2 = 351;
            this.lineShape10.Click += new System.EventHandler(this.lineShape1_Click);
            this.lineShape10.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape9
            // 
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 403;
            this.lineShape9.X2 = 403;
            this.lineShape9.Y1 = 70;
            this.lineShape9.Y2 = 120;
            this.lineShape9.Click += new System.EventHandler(this.lineShape9_Click);
            this.lineShape9.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 433;
            this.lineShape8.X2 = 433;
            this.lineShape8.Y1 = 40;
            this.lineShape8.Y2 = 150;
            this.lineShape8.Click += new System.EventHandler(this.lineShape8_Click);
            this.lineShape8.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 70;
            this.lineShape7.X2 = 403;
            this.lineShape7.Y1 = 70;
            this.lineShape7.Y2 = 70;
            this.lineShape7.Click += new System.EventHandler(this.lineShape7_Click);
            this.lineShape7.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 70;
            this.lineShape6.X2 = 433;
            this.lineShape6.Y1 = 40;
            this.lineShape6.Y2 = 40;
            this.lineShape6.Click += new System.EventHandler(this.lineShape6_Click);
            this.lineShape6.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 70;
            this.lineShape5.X2 = 70;
            this.lineShape5.Y1 = 70;
            this.lineShape5.Y2 = 100;
            this.lineShape5.Click += new System.EventHandler(this.lineShape5_Click);
            this.lineShape5.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 70;
            this.lineShape4.X2 = 70;
            this.lineShape4.Y1 = 10;
            this.lineShape4.Y2 = 40;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 20;
            this.lineShape3.X2 = 70;
            this.lineShape3.Y1 = 100;
            this.lineShape3.Y2 = 100;
            this.lineShape3.Click += new System.EventHandler(this.lineShape3_Click);
            this.lineShape3.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 20;
            this.lineShape2.X2 = 70;
            this.lineShape2.Y1 = 10;
            this.lineShape2.Y2 = 10;
            this.lineShape2.Click += new System.EventHandler(this.lineShape2_Click);
            this.lineShape2.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 20;
            this.lineShape1.X2 = 20;
            this.lineShape1.Y1 = 10;
            this.lineShape1.Y2 = 100;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click_1);
            this.lineShape1.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.playTimeLabel);
            this.panel3.Controls.Add(this.startButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 54);
            this.panel3.TabIndex = 1;
            // 
            // playTimeLabel
            // 
            this.playTimeLabel.Font = new System.Drawing.Font("メイリオ", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.playTimeLabel.Location = new System.Drawing.Point(190, 3);
            this.playTimeLabel.Name = "playTimeLabel";
            this.playTimeLabel.Size = new System.Drawing.Size(259, 48);
            this.playTimeLabel.TabIndex = 1;
            this.playTimeLabel.Text = "Time:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("メイリオ", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 48);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.field.ResumeLayout(false);
            this.field.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel field;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label Goal;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape24;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape23;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape22;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape21;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape20;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape19;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape18;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape17;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape16;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape15;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape14;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape13;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label playTimeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

