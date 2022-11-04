namespace WSDLTool.Froms
{
    partial class PropertiesForm
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
            this.txtWsdlFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtWsdlFile
            // 
            this.txtWsdlFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWsdlFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWsdlFile.Location = new System.Drawing.Point(0, 0);
            this.txtWsdlFile.Name = "txtWsdlFile";
            this.txtWsdlFile.Size = new System.Drawing.Size(736, 456);
            this.txtWsdlFile.TabIndex = 0;
            this.txtWsdlFile.Text = "";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.txtWsdlFile);
            this.Name = "PropertiesForm";
            this.Text = "WSDL Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtWsdlFile;
    }
}