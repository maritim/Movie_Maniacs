namespace Movie_Maniacs
{
    partial class ListIMDBform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListIMDBform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListOfMovies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToYourListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitIMDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addbutton = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.MarkBox = new System.Windows.Forms.TextBox();
            this.TopPicture = new System.Windows.Forms.PictureBox();
            this.BottomPicture = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PosterImage = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosterImage)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 385);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ListOfMovies);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel3.Size = new System.Drawing.Size(223, 324);
            this.panel3.TabIndex = 2;
            // 
            // ListOfMovies
            // 
            this.ListOfMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListOfMovies.ContextMenuStrip = this.contextMenuStrip1;
            this.ListOfMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfMovies.FullRowSelect = true;
            this.ListOfMovies.Location = new System.Drawing.Point(15, 0);
            this.ListOfMovies.Name = "ListOfMovies";
            this.ListOfMovies.ShowItemToolTips = true;
            this.ListOfMovies.Size = new System.Drawing.Size(193, 309);
            this.ListOfMovies.TabIndex = 0;
            this.ListOfMovies.UseCompatibleStateImageBehavior = false;
            this.ListOfMovies.View = System.Windows.Forms.View.Details;
            this.ListOfMovies.ItemActivate += new System.EventHandler(this.ListOfMovies_SelectedIndexChanged);
            this.ListOfMovies.SelectedIndexChanged += new System.EventHandler(this.ListOfMovies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Top";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 165;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToYourListToolStripMenuItem,
            this.visitIMDbToolStripMenuItem,
            this.toolStripSeparator1,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 76);
            // 
            // addToYourListToolStripMenuItem
            // 
            this.addToYourListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToYourListToolStripMenuItem.Image")));
            this.addToYourListToolStripMenuItem.Name = "addToYourListToolStripMenuItem";
            this.addToYourListToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addToYourListToolStripMenuItem.Text = "Add to your list";
            this.addToYourListToolStripMenuItem.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // visitIMDbToolStripMenuItem
            // 
            this.visitIMDbToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitIMDbToolStripMenuItem.Image")));
            this.visitIMDbToolStripMenuItem.Name = "visitIMDbToolStripMenuItem";
            this.visitIMDbToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.visitIMDbToolStripMenuItem.Text = "Visit &IMDb";
            this.visitIMDbToolStripMenuItem.Click += new System.EventHandler(this.visitIMDbToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Visible = false;
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel4.Size = new System.Drawing.Size(223, 61);
            this.panel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(213, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import";
            // 
            // AddBox
            // 
            this.AddBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBox.Location = new System.Drawing.Point(10, 21);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(193, 20);
            this.AddBox.TabIndex = 0;
            this.AddBox.Text = "Type link from IMDb...";
            this.AddBox.Click += new System.EventHandler(this.AddBox_TextChanged);
            this.AddBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Addbutton);
            this.panel2.Controls.Add(this.DescriptionBox);
            this.panel2.Controls.Add(this.MarkBox);
            this.panel2.Controls.Add(this.TopPicture);
            this.panel2.Controls.Add(this.BottomPicture);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.PosterImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 355);
            this.panel2.TabIndex = 2;
            // 
            // Addbutton
            // 
            this.Addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Addbutton.BackgroundImage")));
            this.Addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addbutton.Location = new System.Drawing.Point(407, 307);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(32, 32);
            this.Addbutton.TabIndex = 34;
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Visible = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(187, 161);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(252, 140);
            this.DescriptionBox.TabIndex = 33;
            this.DescriptionBox.Text = "";
            // 
            // MarkBox
            // 
            this.MarkBox.BackColor = System.Drawing.SystemColors.Control;
            this.MarkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MarkBox.Location = new System.Drawing.Point(187, 92);
            this.MarkBox.Name = "MarkBox";
            this.MarkBox.ReadOnly = true;
            this.MarkBox.Size = new System.Drawing.Size(252, 13);
            this.MarkBox.TabIndex = 32;
            this.MarkBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopPicture
            // 
            this.TopPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPicture.Image = ((System.Drawing.Image)(resources.GetObject("TopPicture.Image")));
            this.TopPicture.Location = new System.Drawing.Point(187, 116);
            this.TopPicture.Name = "TopPicture";
            this.TopPicture.Size = new System.Drawing.Size(252, 20);
            this.TopPicture.TabIndex = 30;
            this.TopPicture.TabStop = false;
            this.TopPicture.Visible = false;
            // 
            // BottomPicture
            // 
            this.BottomPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomPicture.Image = ((System.Drawing.Image)(resources.GetObject("BottomPicture.Image")));
            this.BottomPicture.Location = new System.Drawing.Point(187, 116);
            this.BottomPicture.Name = "BottomPicture";
            this.BottomPicture.Size = new System.Drawing.Size(252, 20);
            this.BottomPicture.TabIndex = 30;
            this.BottomPicture.TabStop = false;
            this.BottomPicture.Visible = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(17, 16);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(422, 70);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PosterImage
            // 
            this.PosterImage.Location = new System.Drawing.Point(17, 92);
            this.PosterImage.Name = "PosterImage";
            this.PosterImage.Size = new System.Drawing.Size(140, 209);
            this.PosterImage.TabIndex = 0;
            this.PosterImage.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "17842198701615733599.png");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(223, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.panel5.Size = new System.Drawing.Size(473, 385);
            this.panel5.TabIndex = 1;
            // 
            // ListIMDBform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 385);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListIMDBform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List from IMDB";
            this.Load += new System.EventHandler(this.ListIMDBform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListIMDBform_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosterImage)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView ListOfMovies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox PosterImage;
        private System.Windows.Forms.PictureBox TopPicture;
        private System.Windows.Forms.PictureBox BottomPicture;
        private System.Windows.Forms.TextBox MarkBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitIMDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToYourListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel5;
    }
}