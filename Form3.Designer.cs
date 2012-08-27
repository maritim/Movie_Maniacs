namespace Movie_Maniacs
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.StarList = new System.Windows.Forms.ListView();
            this.ActorImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActorRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visitPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StarsImageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StarList
            // 
            this.StarList.AllowColumnReorder = true;
            this.StarList.BackColor = System.Drawing.SystemColors.Window;
            this.StarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActorImage,
            this.ActorName,
            this.ActorRole});
            this.StarList.ContextMenuStrip = this.contextMenuStrip1;
            this.StarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StarList.FullRowSelect = true;
            this.StarList.GridLines = true;
            this.StarList.LargeImageList = this.StarsImageList;
            this.StarList.Location = new System.Drawing.Point(0, 0);
            this.StarList.MultiSelect = false;
            this.StarList.Name = "StarList";
            this.StarList.Size = new System.Drawing.Size(281, 299);
            this.StarList.SmallImageList = this.StarsImageList;
            this.StarList.TabIndex = 0;
            this.StarList.TileSize = new System.Drawing.Size(190, 50);
            this.StarList.UseCompatibleStateImageBehavior = false;
            this.StarList.View = System.Windows.Forms.View.Details;
            this.StarList.ItemActivate += new System.EventHandler(this.visitPageToolStripMenuItem_Click);
            // 
            // ActorImage
            // 
            this.ActorImage.Text = "";
            this.ActorImage.Width = 57;
            // 
            // ActorName
            // 
            this.ActorName.Text = "Name";
            this.ActorName.Width = 101;
            // 
            // ActorRole
            // 
            this.ActorRole.Text = "Character";
            this.ActorRole.Width = 119;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitPageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 26);
            // 
            // visitPageToolStripMenuItem
            // 
            this.visitPageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitPageToolStripMenuItem.Image")));
            this.visitPageToolStripMenuItem.Name = "visitPageToolStripMenuItem";
            this.visitPageToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.visitPageToolStripMenuItem.Text = "Visit page";
            this.visitPageToolStripMenuItem.Click += new System.EventHandler(this.visitPageToolStripMenuItem_Click);
            // 
            // StarsImageList
            // 
            this.StarsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.StarsImageList.ImageSize = new System.Drawing.Size(32, 44);
            this.StarsImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 299);
            this.Controls.Add(this.StarList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(297, 38);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stars";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StarList;
        private System.Windows.Forms.ColumnHeader ActorImage;
        private System.Windows.Forms.ColumnHeader ActorName;
        private System.Windows.Forms.ColumnHeader ActorRole;
        private System.Windows.Forms.ImageList StarsImageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitPageToolStripMenuItem;
    }
}