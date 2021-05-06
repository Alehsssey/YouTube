
namespace ytv
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tburl = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnget = new System.Windows.Forms.Button();
            this.btnpaste = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblduration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pbpreview = new System.Windows.Forms.PictureBox();
            this.lblnamedesc = new System.Windows.Forms.Label();
            this.cbresolution = new System.Windows.Forms.ComboBox();
            this.btndownload = new System.Windows.Forms.Button();
            this.lblresolution = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.інфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інструкціяКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "YouTube URL";
            // 
            // tburl
            // 
            this.tburl.Location = new System.Drawing.Point(8, 37);
            this.tburl.Name = "tburl";
            this.tburl.Size = new System.Drawing.Size(331, 20);
            this.tburl.TabIndex = 1;
            this.tburl.TextChanged += new System.EventHandler(this.tburl_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(491, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnget);
            this.panel1.Controls.Add(this.btnpaste);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tburl);
            this.panel1.Location = new System.Drawing.Point(164, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 99);
            this.panel1.TabIndex = 4;
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(211, 73);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(128, 23);
            this.btnget.TabIndex = 8;
            this.btnget.Text = "Попередній перегляд";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // btnpaste
            // 
            this.btnpaste.Location = new System.Drawing.Point(130, 73);
            this.btnpaste.Name = "btnpaste";
            this.btnpaste.Size = new System.Drawing.Size(75, 23);
            this.btnpaste.TabIndex = 7;
            this.btnpaste.Text = "Вставити";
            this.btnpaste.UseVisualStyleBackColor = true;
            this.btnpaste.Click += new System.EventHandler(this.btnpaste_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblduration);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.pbpreview);
            this.panel2.Controls.Add(this.lblnamedesc);
            this.panel2.Controls.Add(this.cbresolution);
            this.panel2.Controls.Add(this.btndownload);
            this.panel2.Controls.Add(this.lblresolution);
            this.panel2.Location = new System.Drawing.Point(9, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 136);
            this.panel2.TabIndex = 8;
            // 
            // lblduration
            // 
            this.lblduration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblduration.Location = new System.Drawing.Point(253, 43);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(229, 20);
            this.lblduration.TabIndex = 20;
            this.lblduration.Text = "--";
            this.lblduration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(134, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Тривалість відео:";
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.Location = new System.Drawing.Point(253, 11);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(229, 20);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "--";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbpreview
            // 
            this.pbpreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbpreview.BackColor = System.Drawing.Color.Gainsboro;
            this.pbpreview.Location = new System.Drawing.Point(3, 3);
            this.pbpreview.Name = "pbpreview";
            this.pbpreview.Size = new System.Drawing.Size(125, 100);
            this.pbpreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpreview.TabIndex = 18;
            this.pbpreview.TabStop = false;
            // 
            // lblnamedesc
            // 
            this.lblnamedesc.AutoEllipsis = true;
            this.lblnamedesc.AutoSize = true;
            this.lblnamedesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblnamedesc.Location = new System.Drawing.Point(134, 15);
            this.lblnamedesc.Name = "lblnamedesc";
            this.lblnamedesc.Size = new System.Drawing.Size(71, 13);
            this.lblnamedesc.TabIndex = 12;
            this.lblnamedesc.Text = "Назва відео:";
            // 
            // cbresolution
            // 
            this.cbresolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbresolution.DisplayMember = "Quality";
            this.cbresolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbresolution.FormattingEnabled = true;
            this.cbresolution.Location = new System.Drawing.Point(256, 75);
            this.cbresolution.Name = "cbresolution";
            this.cbresolution.Size = new System.Drawing.Size(226, 21);
            this.cbresolution.TabIndex = 16;
            this.cbresolution.SelectedIndexChanged += new System.EventHandler(this.cbresolution_SelectedIndexChanged);
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(393, 102);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(89, 23);
            this.btndownload.TabIndex = 15;
            this.btndownload.Text = "Завантажити";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // lblresolution
            // 
            this.lblresolution.AutoEllipsis = true;
            this.lblresolution.AutoSize = true;
            this.lblresolution.ForeColor = System.Drawing.Color.DimGray;
            this.lblresolution.Location = new System.Drawing.Point(134, 75);
            this.lblresolution.Name = "lblresolution";
            this.lblresolution.Size = new System.Drawing.Size(109, 13);
            this.lblresolution.TabIndex = 14;
            this.lblresolution.Text = "Роздільна здатність";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інфоToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // інфоToolStripMenuItem
            // 
            this.інфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.інструкціяКористувачаToolStripMenuItem});
            this.інфоToolStripMenuItem.Name = "інфоToolStripMenuItem";
            this.інфоToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.інфоToolStripMenuItem.Text = "Інфо";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // інструкціяКористувачаToolStripMenuItem
            // 
            this.інструкціяКористувачаToolStripMenuItem.Name = "інструкціяКористувачаToolStripMenuItem";
            this.інструкціяКористувачаToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.інструкціяКористувачаToolStripMenuItem.Text = "Інструкція користувача";
            this.інструкціяКористувачаToolStripMenuItem.Click += new System.EventHandler(this.інструкціяКористувачаToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tburl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Button btnpaste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pbpreview;
        private System.Windows.Forms.Label lblnamedesc;
        private System.Windows.Forms.ComboBox cbresolution;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Label lblresolution;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem інфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інструкціяКористувачаToolStripMenuItem;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label label2;
    }
}

