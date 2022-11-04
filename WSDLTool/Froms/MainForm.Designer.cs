namespace WSDLTool.Froms
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDropdown = new System.Windows.Forms.Panel();
            this.btnService = new System.Windows.Forms.Button();
            this.btnBinding = new System.Windows.Forms.Button();
            this.btnPortType = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.panelType = new System.Windows.Forms.Panel();
            this.tblPanelType = new System.Windows.Forms.TableLayoutPanel();
            this.btnOnlyType = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tblPanelMessage = new System.Windows.Forms.TableLayoutPanel();
            this.btnMessageShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMessageExport = new System.Windows.Forms.Button();
            this.btnOnlyMessage = new System.Windows.Forms.Button();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.panelPortType = new System.Windows.Forms.Panel();
            this.tblPanelPortType = new System.Windows.Forms.TableLayoutPanel();
            this.btnOnlyPortTypeShow = new System.Windows.Forms.Button();
            this.btnPortTypeShow = new System.Windows.Forms.Button();
            this.btnPortTypeExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDropdown.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLoad.SuspendLayout();
            this.tblPanelType.SuspendLayout();
            this.tblPanelMessage.SuspendLayout();
            this.tblPanelPortType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panelDropdown, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLoad, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDropdown
            // 
            this.panelDropdown.Controls.Add(this.btnService);
            this.panelDropdown.Controls.Add(this.btnBinding);
            this.panelDropdown.Controls.Add(this.btnPortType);
            this.panelDropdown.Controls.Add(this.btnMessage);
            this.panelDropdown.Controls.Add(this.btnType);
            this.panelDropdown.Controls.Add(this.btnModel);
            this.panelDropdown.Location = new System.Drawing.Point(3, 3);
            this.panelDropdown.MaximumSize = new System.Drawing.Size(144, 250);
            this.panelDropdown.MinimumSize = new System.Drawing.Size(144, 43);
            this.panelDropdown.Name = "panelDropdown";
            this.panelDropdown.Size = new System.Drawing.Size(144, 43);
            this.panelDropdown.TabIndex = 0;
            // 
            // btnService
            // 
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Location = new System.Drawing.Point(0, 212);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(145, 35);
            this.btnService.TabIndex = 5;
            this.btnService.Text = "Services";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnBinding
            // 
            this.btnBinding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinding.Location = new System.Drawing.Point(0, 171);
            this.btnBinding.Name = "btnBinding";
            this.btnBinding.Size = new System.Drawing.Size(145, 35);
            this.btnBinding.TabIndex = 4;
            this.btnBinding.Text = "Bindings";
            this.btnBinding.UseVisualStyleBackColor = true;
            this.btnBinding.Click += new System.EventHandler(this.btnBinding_Click);
            // 
            // btnPortType
            // 
            this.btnPortType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortType.Location = new System.Drawing.Point(0, 130);
            this.btnPortType.Name = "btnPortType";
            this.btnPortType.Size = new System.Drawing.Size(145, 35);
            this.btnPortType.TabIndex = 3;
            this.btnPortType.Text = "PortTypes";
            this.btnPortType.UseVisualStyleBackColor = true;
            this.btnPortType.Click += new System.EventHandler(this.btnPortType_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.Location = new System.Drawing.Point(0, 85);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(145, 35);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "Messages";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnType
            // 
            this.btnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Location = new System.Drawing.Point(0, 44);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(145, 35);
            this.btnType.TabIndex = 1;
            this.btnType.Text = "Types";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnModel
            // 
            this.btnModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModel.Location = new System.Drawing.Point(0, 4);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(145, 35);
            this.btnModel.TabIndex = 0;
            this.btnModel.Text = "Model";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.MouseHover += new System.EventHandler(this.btnModel_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(799, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 626);
            this.panel3.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(92, 317);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 37);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Properties";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.SystemColors.Info;
            this.panelLoad.Controls.Add(this.panelType);
            this.panelLoad.Controls.Add(this.tblPanelType);
            this.panelLoad.Controls.Add(this.tblPanelMessage);
            this.panelLoad.Controls.Add(this.panelMessage);
            this.panelLoad.Controls.Add(this.panelPortType);
            this.panelLoad.Controls.Add(this.tblPanelPortType);
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(153, 3);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(640, 626);
            this.panelLoad.TabIndex = 3;
            // 
            // panelType
            // 
            this.panelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelType.Location = new System.Drawing.Point(0, 129);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(640, 497);
            this.panelType.TabIndex = 4;
            // 
            // tblPanelType
            // 
            this.tblPanelType.ColumnCount = 4;
            this.tblPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelType.Controls.Add(this.btnOnlyType, 0, 0);
            this.tblPanelType.Controls.Add(this.label3, 0, 0);
            this.tblPanelType.Controls.Add(this.btnShow, 1, 0);
            this.tblPanelType.Controls.Add(this.btnExport, 3, 0);
            this.tblPanelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPanelType.Location = new System.Drawing.Point(0, 90);
            this.tblPanelType.Name = "tblPanelType";
            this.tblPanelType.RowCount = 1;
            this.tblPanelType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblPanelType.Size = new System.Drawing.Size(640, 39);
            this.tblPanelType.TabIndex = 3;
            // 
            // btnOnlyType
            // 
            this.btnOnlyType.Location = new System.Drawing.Point(433, 3);
            this.btnOnlyType.Name = "btnOnlyType";
            this.btnOnlyType.Size = new System.Drawing.Size(64, 34);
            this.btnOnlyType.TabIndex = 4;
            this.btnOnlyType.Text = "Show";
            this.btnOnlyType.UseVisualStyleBackColor = true;
            this.btnOnlyType.Click += new System.EventHandler(this.btnOnlyType_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Types";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(503, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(64, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "ShowALL";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(573, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(64, 34);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tblPanelMessage
            // 
            this.tblPanelMessage.ColumnCount = 4;
            this.tblPanelMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelMessage.Controls.Add(this.btnMessageShow, 2, 0);
            this.tblPanelMessage.Controls.Add(this.label1, 0, 0);
            this.tblPanelMessage.Controls.Add(this.btnMessageExport, 3, 0);
            this.tblPanelMessage.Controls.Add(this.btnOnlyMessage, 1, 0);
            this.tblPanelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPanelMessage.Location = new System.Drawing.Point(0, 45);
            this.tblPanelMessage.Name = "tblPanelMessage";
            this.tblPanelMessage.RowCount = 1;
            this.tblPanelMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelMessage.Size = new System.Drawing.Size(640, 45);
            this.tblPanelMessage.TabIndex = 0;
            // 
            // btnMessageShow
            // 
            this.btnMessageShow.Location = new System.Drawing.Point(503, 3);
            this.btnMessageShow.Name = "btnMessageShow";
            this.btnMessageShow.Size = new System.Drawing.Size(64, 34);
            this.btnMessageShow.TabIndex = 2;
            this.btnMessageShow.Text = "ShowALL";
            this.btnMessageShow.UseVisualStyleBackColor = true;
            this.btnMessageShow.Click += new System.EventHandler(this.btnMessageShow_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMessageExport
            // 
            this.btnMessageExport.Location = new System.Drawing.Point(573, 3);
            this.btnMessageExport.Name = "btnMessageExport";
            this.btnMessageExport.Size = new System.Drawing.Size(64, 34);
            this.btnMessageExport.TabIndex = 3;
            this.btnMessageExport.Text = "Export";
            this.btnMessageExport.UseVisualStyleBackColor = true;
            this.btnMessageExport.Click += new System.EventHandler(this.btnMessageExport_Click);
            // 
            // btnOnlyMessage
            // 
            this.btnOnlyMessage.Location = new System.Drawing.Point(433, 3);
            this.btnOnlyMessage.Name = "btnOnlyMessage";
            this.btnOnlyMessage.Size = new System.Drawing.Size(64, 34);
            this.btnOnlyMessage.TabIndex = 4;
            this.btnOnlyMessage.Text = "Show";
            this.btnOnlyMessage.UseVisualStyleBackColor = true;
            this.btnOnlyMessage.Click += new System.EventHandler(this.btnOnlyMessage_Click);
            // 
            // panelMessage
            // 
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(0, 45);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(640, 581);
            this.panelMessage.TabIndex = 4;
            this.panelMessage.Visible = false;
            // 
            // panelPortType
            // 
            this.panelPortType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPortType.Location = new System.Drawing.Point(0, 45);
            this.panelPortType.Name = "panelPortType";
            this.panelPortType.Size = new System.Drawing.Size(640, 581);
            this.panelPortType.TabIndex = 0;
            // 
            // tblPanelPortType
            // 
            this.tblPanelPortType.ColumnCount = 4;
            this.tblPanelPortType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelPortType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelPortType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelPortType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelPortType.Controls.Add(this.btnOnlyPortTypeShow, 1, 0);
            this.tblPanelPortType.Controls.Add(this.btnPortTypeShow, 2, 0);
            this.tblPanelPortType.Controls.Add(this.btnPortTypeExport, 3, 0);
            this.tblPanelPortType.Controls.Add(this.label4, 0, 0);
            this.tblPanelPortType.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPanelPortType.Location = new System.Drawing.Point(0, 0);
            this.tblPanelPortType.Name = "tblPanelPortType";
            this.tblPanelPortType.RowCount = 1;
            this.tblPanelPortType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblPanelPortType.Size = new System.Drawing.Size(640, 45);
            this.tblPanelPortType.TabIndex = 0;
            // 
            // btnOnlyPortTypeShow
            // 
            this.btnOnlyPortTypeShow.Location = new System.Drawing.Point(433, 3);
            this.btnOnlyPortTypeShow.Name = "btnOnlyPortTypeShow";
            this.btnOnlyPortTypeShow.Size = new System.Drawing.Size(64, 34);
            this.btnOnlyPortTypeShow.TabIndex = 5;
            this.btnOnlyPortTypeShow.Text = "Show";
            this.btnOnlyPortTypeShow.UseVisualStyleBackColor = true;
            this.btnOnlyPortTypeShow.Click += new System.EventHandler(this.btnOnlyPortTypeShow_Click);
            // 
            // btnPortTypeShow
            // 
            this.btnPortTypeShow.Location = new System.Drawing.Point(503, 3);
            this.btnPortTypeShow.Name = "btnPortTypeShow";
            this.btnPortTypeShow.Size = new System.Drawing.Size(64, 34);
            this.btnPortTypeShow.TabIndex = 6;
            this.btnPortTypeShow.Text = "ShowALL";
            this.btnPortTypeShow.UseVisualStyleBackColor = true;
            this.btnPortTypeShow.Click += new System.EventHandler(this.btnPortTypeShow_Click);
            // 
            // btnPortTypeExport
            // 
            this.btnPortTypeExport.Location = new System.Drawing.Point(573, 3);
            this.btnPortTypeExport.Name = "btnPortTypeExport";
            this.btnPortTypeExport.Size = new System.Drawing.Size(64, 34);
            this.btnPortTypeExport.TabIndex = 7;
            this.btnPortTypeExport.Text = "Export";
            this.btnPortTypeExport.UseVisualStyleBackColor = true;
            this.btnPortTypeExport.Click += new System.EventHandler(this.btnPortTypeExport_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "PortType";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDropdown.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLoad.ResumeLayout(false);
            this.tblPanelType.ResumeLayout(false);
            this.tblPanelMessage.ResumeLayout(false);
            this.tblPanelPortType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelDropdown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnBinding;
        private System.Windows.Forms.Button btnPortType;
        private System.Windows.Forms.Button btnMessage;
        public System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.TableLayoutPanel tblPanelMessage;
        private System.Windows.Forms.Button btnMessageExport;
        private System.Windows.Forms.Button btnMessageShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblPanelType;
        public System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Button btnOnlyMessage;
        private System.Windows.Forms.Button btnOnlyType;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Panel panelPortType;
        private System.Windows.Forms.TableLayoutPanel tblPanelPortType;
        private System.Windows.Forms.Button btnOnlyPortTypeShow;
        private System.Windows.Forms.Button btnPortTypeShow;
        private System.Windows.Forms.Button btnPortTypeExport;
        private System.Windows.Forms.Label label4;
    }
}