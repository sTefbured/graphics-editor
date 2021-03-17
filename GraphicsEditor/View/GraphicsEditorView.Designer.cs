namespace GraphicsEditor.View
{
    partial class GraphicsEditorView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.primitivesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.colorButton = new System.Windows.Forms.Button();
            this.penWidthPanel = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrimitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPrimitiveDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.widthTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsPanel
            // 
            this.toolsPanel.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.toolsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.primitivesPanel);
            this.toolsPanel.Controls.Add(this.saveButton);
            this.toolsPanel.Controls.Add(this.loadButton);
            this.toolsPanel.Controls.Add(this.widthTrackBar);
            this.toolsPanel.Controls.Add(this.colorButton);
            this.toolsPanel.Controls.Add(this.penWidthPanel);
            this.toolsPanel.Controls.Add(this.colorPanel);
            this.toolsPanel.Location = new System.Drawing.Point(12, 37);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(150, 602);
            this.toolsPanel.TabIndex = 0;
            // 
            // primitivesPanel
            // 
            this.primitivesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.primitivesPanel.Location = new System.Drawing.Point(40, 300);
            this.primitivesPanel.Name = "primitivesPanel";
            this.primitivesPanel.Size = new System.Drawing.Size(70, 200);
            this.primitivesPanel.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 571);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(40, 542);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(70, 23);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.Location = new System.Drawing.Point(25, 225);
            this.widthTrackBar.Maximum = 70;
            this.widthTrackBar.Minimum = 1;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(100, 45);
            this.widthTrackBar.SmallChange = 5;
            this.widthTrackBar.TabIndex = 2;
            this.widthTrackBar.TickFrequency = 5;
            this.widthTrackBar.Value = 1;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(40, 98);
            this.colorButton.Margin = new System.Windows.Forms.Padding(5);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(70, 23);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // penWidthPanel
            // 
            this.penWidthPanel.BackColor = System.Drawing.SystemColors.Control;
            this.penWidthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penWidthPanel.Location = new System.Drawing.Point(40, 140);
            this.penWidthPanel.Name = "penWidthPanel";
            this.penWidthPanel.Size = new System.Drawing.Size(70, 70);
            this.penWidthPanel.TabIndex = 0;
            this.penWidthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.penWidthPanel_Paint);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(40, 20);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(70, 70);
            this.colorPanel.TabIndex = 0;
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvasPanel.Location = new System.Drawing.Point(177, 37);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(12);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(635, 602);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Xml files|*.xml";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.Filter = "Xml files|*.xml";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addPrimitiveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPrimitiveToolStripMenuItem
            // 
            this.addPrimitiveToolStripMenuItem.Name = "addPrimitiveToolStripMenuItem";
            this.addPrimitiveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addPrimitiveToolStripMenuItem.Text = "Add primitive...";
            this.addPrimitiveToolStripMenuItem.Click += new System.EventHandler(this.addPrimitiveToolStripMenuItem_Click);
            // 
            // loadPrimitiveDialog
            // 
            this.loadPrimitiveDialog.Filter = "Dynamic Link Library|*.dll";
            // 
            // GraphicsEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 651);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphicsEditorView";
            this.Text = "Graphics editor";
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.widthTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.FlowLayoutPanel primitivesPanel;

        private System.Windows.Forms.OpenFileDialog loadPrimitiveDialog;

        private System.Windows.Forms.ToolStripMenuItem addPrimitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.OpenFileDialog loadFileDialog;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel penWidthPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TrackBar widthTrackBar;

        private System.Windows.Forms.Button colorButton;

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog penColorDialog;

        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Panel toolsPanel;

        #endregion
    }
}