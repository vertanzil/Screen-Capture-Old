namespace ScreenGrabber
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butdone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkmodeset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxopenibrowser = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.chkboxcopytoclipboard = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.AutoSize = false;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click_1);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click_1);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Loaded";
            this.notifyIcon1.BalloonTipTitle = "Screen Grabber";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Screen  Grabber";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // butdone
            // 
            this.butdone.Location = new System.Drawing.Point(100, 127);
            this.butdone.Name = "butdone";
            this.butdone.Size = new System.Drawing.Size(146, 24);
            this.butdone.TabIndex = 20;
            this.butdone.Text = "Done";
            this.butdone.UseVisualStyleBackColor = true;
            this.butdone.Click += new System.EventHandler(this.butdone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkboxcopytoclipboard);
            this.groupBox1.Controls.Add(this.chkmodeset);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butdone);
            this.groupBox1.Controls.Add(this.chkboxopenibrowser);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 169);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkmodeset
            // 
            this.chkmodeset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chkmodeset.FormattingEnabled = true;
            this.chkmodeset.Items.AddRange(new object[] {
            "Link Mode",
            "Image Mode"});
            this.chkmodeset.Location = new System.Drawing.Point(109, 19);
            this.chkmodeset.Name = "chkmodeset";
            this.chkmodeset.Size = new System.Drawing.Size(137, 21);
            this.chkmodeset.TabIndex = 26;
            this.chkmodeset.SelectedIndexChanged += new System.EventHandler(this.chkmodeset_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Copy Mode";
            // 
            // chkboxopenibrowser
            // 
            this.chkboxopenibrowser.Location = new System.Drawing.Point(142, 59);
            this.chkboxopenibrowser.Name = "chkboxopenibrowser";
            this.chkboxopenibrowser.Size = new System.Drawing.Size(104, 24);
            this.chkboxopenibrowser.TabIndex = 20;
            this.chkboxopenibrowser.CheckedChanged += new System.EventHandler(this.chkboxopenibrowser_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 13);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Open in Browser?";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(24, 184);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(0, 13);
            this.lbltext.TabIndex = 22;
            // 
            // chkboxcopytoclipboard
            // 
            this.chkboxcopytoclipboard.AutoSize = true;
            this.chkboxcopytoclipboard.Location = new System.Drawing.Point(142, 87);
            this.chkboxcopytoclipboard.Name = "chkboxcopytoclipboard";
            this.chkboxcopytoclipboard.Size = new System.Drawing.Size(15, 14);
            this.chkboxcopytoclipboard.TabIndex = 27;
            this.chkboxcopytoclipboard.UseVisualStyleBackColor = true;
            this.chkboxcopytoclipboard.CheckedChanged += new System.EventHandler(this.chkboxcopytoclipboard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Copy to Clipboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(308, 196);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Screen Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button butdone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkboxopenibrowser;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.ComboBox chkmodeset;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkboxcopytoclipboard;
    }
}

