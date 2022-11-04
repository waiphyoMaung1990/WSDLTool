namespace WSDLTool.Controls
{
    partial class uc_Message
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addParameterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPropertiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "WSDL Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Location = new System.Drawing.Point(0, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(254, 23);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "label2";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 3);
            this.panel1.TabIndex = 1;
            // 
            // MessageMenu
            // 
            this.MessageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addParameterItem,
            this.deleteMenuItem,
            this.showPropertiesItem});
            this.MessageMenu.Name = "MessageMenu";
            this.MessageMenu.Size = new System.Drawing.Size(160, 70);
            // 
            // addParameterItem
            // 
            this.addParameterItem.Name = "addParameterItem";
            this.addParameterItem.Size = new System.Drawing.Size(159, 22);
            this.addParameterItem.Text = "Add Parameter";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteMenuItem.Text = "Delete";
            // 
            // showPropertiesItem
            // 
            this.showPropertiesItem.Name = "showPropertiesItem";
            this.showPropertiesItem.Size = new System.Drawing.Size(159, 22);
            this.showPropertiesItem.Text = "Show Properties";
            // 
            // uc_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.MessageMenu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Name = "uc_Message";
            this.Size = new System.Drawing.Size(254, 171);
            this.MessageMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip MessageMenu;
        private System.Windows.Forms.ToolStripMenuItem addParameterItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPropertiesItem;
    }
}
