namespace WSDLTool.Controls
{
    partial class uc_Element
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblElement = new System.Windows.Forms.Label();
            this.ElementMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addElementItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ElementMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblElement
            // 
            this.lblElement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement.Location = new System.Drawing.Point(0, 0);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(256, 31);
            this.lblElement.TabIndex = 0;
            this.lblElement.Text = "ElementName";
            this.lblElement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblElement.Click += new System.EventHandler(this.lblElement_Click);
            // 
            // ElementMenu
            // 
            this.ElementMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addElementItem,
            this.deleteToolStripMenuItem,
            this.showPropertiesToolStripMenuItem});
            this.ElementMenu.Name = "ElementMenu";
            this.ElementMenu.Size = new System.Drawing.Size(157, 70);
            // 
            // addElementItem
            // 
            this.addElementItem.Name = "addElementItem";
            this.addElementItem.Size = new System.Drawing.Size(156, 22);
            this.addElementItem.Text = "AddElement";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // showPropertiesToolStripMenuItem
            // 
            this.showPropertiesToolStripMenuItem.Name = "showPropertiesToolStripMenuItem";
            this.showPropertiesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showPropertiesToolStripMenuItem.Text = "ShowProperties";
            // 
            // lblTypeName
            // 
            this.lblTypeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeName.Location = new System.Drawing.Point(0, 31);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(256, 25);
            this.lblTypeName.TabIndex = 2;
            this.lblTypeName.Text = "label1";
            this.lblTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 1);
            this.panel1.TabIndex = 1;
            // 
            // uc_Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.ElementMenu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.lblElement);
            this.Name = "uc_Element";
            this.Size = new System.Drawing.Size(256, 173);
            this.ElementMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.ContextMenuStrip ElementMenu;
        private System.Windows.Forms.ToolStripMenuItem addElementItem;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPropertiesToolStripMenuItem;
    }
}
