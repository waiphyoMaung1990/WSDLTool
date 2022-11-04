namespace WSDLTool.Popups
{
    partial class AddExistingElement
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
            this.txtParamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_already = new System.Windows.Forms.Button();
            this.cboMessageType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rSimpleType = new System.Windows.Forms.RadioButton();
            this.rComplexType = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ElementName :";
            // 
            // txtParamName
            // 
            this.txtParamName.Location = new System.Drawing.Point(129, 21);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(168, 20);
            this.txtParamName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type :";
            // 
            // btn_already
            // 
            this.btn_already.Location = new System.Drawing.Point(259, 61);
            this.btn_already.Name = "btn_already";
            this.btn_already.Size = new System.Drawing.Size(38, 23);
            this.btn_already.TabIndex = 6;
            this.btn_already.Text = "...";
            this.btn_already.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_already.UseVisualStyleBackColor = true;
            this.btn_already.Click += new System.EventHandler(this.btn_already_Click);
            // 
            // cboMessageType
            // 
            this.cboMessageType.FormattingEnabled = true;
            this.cboMessageType.Location = new System.Drawing.Point(129, 61);
            this.cboMessageType.Name = "cboMessageType";
            this.cboMessageType.Size = new System.Drawing.Size(121, 21);
            this.cboMessageType.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rSimpleType);
            this.groupBox1.Controls.Add(this.rComplexType);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nested Type";
            // 
            // rSimpleType
            // 
            this.rSimpleType.AutoSize = true;
            this.rSimpleType.Location = new System.Drawing.Point(25, 55);
            this.rSimpleType.Name = "rSimpleType";
            this.rSimpleType.Size = new System.Drawing.Size(80, 17);
            this.rSimpleType.TabIndex = 1;
            this.rSimpleType.TabStop = true;
            this.rSimpleType.Text = "SimpleType";
            this.rSimpleType.UseVisualStyleBackColor = true;
            // 
            // rComplexType
            // 
            this.rComplexType.AutoSize = true;
            this.rComplexType.Location = new System.Drawing.Point(25, 25);
            this.rComplexType.Name = "rComplexType";
            this.rComplexType.Size = new System.Drawing.Size(89, 17);
            this.rComplexType.TabIndex = 0;
            this.rComplexType.TabStop = true;
            this.rComplexType.Text = "ComplexType";
            this.rComplexType.UseVisualStyleBackColor = true;
            // 
            // AddExistingElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 205);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMessageType);
            this.Controls.Add(this.btn_already);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParamName);
            this.Controls.Add(this.label1);
            this.Name = "AddExistingElement";
            this.Text = "AddExistingElement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_already;
        private System.Windows.Forms.ComboBox cboMessageType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rSimpleType;
        private System.Windows.Forms.RadioButton rComplexType;
    }
}