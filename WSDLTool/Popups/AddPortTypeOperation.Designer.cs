namespace WSDLTool.Popups
{
    partial class AddPortTypeOperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOperationType = new System.Windows.Forms.ComboBox();
            this.gpboxInput = new System.Windows.Forms.GroupBox();
            this.gpboxOutput = new System.Windows.Forms.GroupBox();
            this.gpboxFaults = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.FaultName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboInputMessage = new System.Windows.Forms.ComboBox();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.cboOutputMessage = new System.Windows.Forms.ComboBox();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.gpboxInput.SuspendLayout();
            this.gpboxOutput.SuspendLayout();
            this.gpboxFaults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ;";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "OperationType;";
            // 
            // cboOperationType
            // 
            this.cboOperationType.FormattingEnabled = true;
            this.cboOperationType.Location = new System.Drawing.Point(140, 79);
            this.cboOperationType.Name = "cboOperationType";
            this.cboOperationType.Size = new System.Drawing.Size(272, 21);
            this.cboOperationType.TabIndex = 3;
            this.cboOperationType.SelectedIndexChanged += new System.EventHandler(this.cboOperationType_SelectedIndexChanged);
            // 
            // gpboxInput
            // 
            this.gpboxInput.Controls.Add(this.cboInputMessage);
            this.gpboxInput.Controls.Add(this.txtInputName);
            this.gpboxInput.Controls.Add(this.label4);
            this.gpboxInput.Controls.Add(this.label3);
            this.gpboxInput.Location = new System.Drawing.Point(15, 123);
            this.gpboxInput.Name = "gpboxInput";
            this.gpboxInput.Size = new System.Drawing.Size(419, 113);
            this.gpboxInput.TabIndex = 4;
            this.gpboxInput.TabStop = false;
            this.gpboxInput.Text = "Input";
            // 
            // gpboxOutput
            // 
            this.gpboxOutput.Controls.Add(this.cboOutputMessage);
            this.gpboxOutput.Controls.Add(this.txtOutputName);
            this.gpboxOutput.Controls.Add(this.label6);
            this.gpboxOutput.Controls.Add(this.label5);
            this.gpboxOutput.Location = new System.Drawing.Point(12, 257);
            this.gpboxOutput.Name = "gpboxOutput";
            this.gpboxOutput.Size = new System.Drawing.Size(422, 112);
            this.gpboxOutput.TabIndex = 5;
            this.gpboxOutput.TabStop = false;
            this.gpboxOutput.Text = "Output";
            // 
            // gpboxFaults
            // 
            this.gpboxFaults.Controls.Add(this.btnDelete);
            this.gpboxFaults.Controls.Add(this.btnNew);
            this.gpboxFaults.Controls.Add(this.dataGridView1);
            this.gpboxFaults.Location = new System.Drawing.Point(15, 388);
            this.gpboxFaults.Name = "gpboxFaults";
            this.gpboxFaults.Size = new System.Drawing.Size(419, 156);
            this.gpboxFaults.TabIndex = 6;
            this.gpboxFaults.TabStop = false;
            this.gpboxFaults.Text = "Faults";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Message :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Message :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaultName,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(413, 95);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(229, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FaultName
            // 
            this.FaultName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FaultName.HeaderText = "Fault Name";
            this.FaultName.Name = "FaultName";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(334, 560);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cboInputMessage
            // 
            this.cboInputMessage.FormattingEnabled = true;
            this.cboInputMessage.Location = new System.Drawing.Point(125, 70);
            this.cboInputMessage.Name = "cboInputMessage";
            this.cboInputMessage.Size = new System.Drawing.Size(272, 21);
            this.cboInputMessage.TabIndex = 5;
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(125, 30);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(272, 20);
            this.txtInputName.TabIndex = 4;
            // 
            // cboOutputMessage
            // 
            this.cboOutputMessage.FormattingEnabled = true;
            this.cboOutputMessage.Location = new System.Drawing.Point(125, 66);
            this.cboOutputMessage.Name = "cboOutputMessage";
            this.cboOutputMessage.Size = new System.Drawing.Size(272, 21);
            this.cboOutputMessage.TabIndex = 5;
            // 
            // txtOutputName
            // 
            this.txtOutputName.Location = new System.Drawing.Point(128, 27);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(272, 20);
            this.txtOutputName.TabIndex = 4;
            // 
            // AddPortTypeOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 605);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gpboxFaults);
            this.Controls.Add(this.gpboxOutput);
            this.Controls.Add(this.gpboxInput);
            this.Controls.Add(this.cboOperationType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddPortTypeOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WSDL PortType Operation";
            this.gpboxInput.ResumeLayout(false);
            this.gpboxInput.PerformLayout();
            this.gpboxOutput.ResumeLayout(false);
            this.gpboxOutput.PerformLayout();
            this.gpboxFaults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOperationType;
        private System.Windows.Forms.GroupBox gpboxInput;
        private System.Windows.Forms.GroupBox gpboxOutput;
        private System.Windows.Forms.GroupBox gpboxFaults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaultName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboInputMessage;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.ComboBox cboOutputMessage;
        private System.Windows.Forms.TextBox txtOutputName;
    }
}