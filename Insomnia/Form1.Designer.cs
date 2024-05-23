namespace Insomnia
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.title = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.insomnia = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.ContextMenuStrip = this.menu;
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "Insomnia";
            this.icon.Visible = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Indigo;
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.title,
            this.toolStripSeparator1,
            this.status,
            this.toolStripSeparator2,
            this.exit});
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(241, 159);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Lavender;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(240, 54);
            this.title.Text = "Insomnia";
            this.title.Click += new System.EventHandler(this.title_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.LightCoral;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(240, 54);
            this.status.Text = "Disabled";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // exit
            // 
            this.exit.AutoSize = false;
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(240, 35);
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // insomnia
            // 
            this.insomnia.Interval = 20000;
            this.insomnia.Tick += new System.EventHandler(this.insomnia_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 63);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Insomnia";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon icon;
        private ContextMenuStrip menu;
        private ToolStripMenuItem title;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem status;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exit;
        private System.Windows.Forms.Timer insomnia;
    }
}