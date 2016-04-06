namespace Hxj.Tools.EntityDesign
{
    partial class ContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.Btn_MakeDal = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEntityTableName = new System.Windows.Forms.CheckBox();
            this.cbToupperFrstword = new System.Windows.Forms.CheckBox();
            this.btnRemovePrimarykey = new System.Windows.Forms.Button();
            this.btnAddPrimarykey = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrimarykey = new System.Windows.Forms.ComboBox();
            this.Btn_MakeModel = new System.Windows.Forms.Button();
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.txtTemplate = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveEntity = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.tp2.SuspendLayout();
            this.contextMenuStripSave.SuspendLayout();
            this.tp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Controls.Add(this.tp3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 831);
            this.tabControl1.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.Btn_MakeDal);
            this.tp1.Controls.Add(this.button6);
            this.tp1.Controls.Add(this.button5);
            this.tp1.Controls.Add(this.button4);
            this.tp1.Controls.Add(this.button3);
            this.tp1.Controls.Add(this.button2);
            this.tp1.Controls.Add(this.groupBox1);
            this.tp1.Controls.Add(this.Btn_MakeModel);
            this.tp1.Controls.Add(this.gridColumns);
            this.tp1.ImageIndex = 0;
            this.tp1.Location = new System.Drawing.Point(4, 4);
            this.tp1.Margin = new System.Windows.Forms.Padding(4);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(4);
            this.tp1.Size = new System.Drawing.Size(1159, 802);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "生成设置";
            this.tp1.UseVisualStyleBackColor = true;
            this.tp1.Click += new System.EventHandler(this.tp1_Click);
            // 
            // Btn_MakeDal
            // 
            this.Btn_MakeDal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MakeDal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_MakeDal.Location = new System.Drawing.Point(209, 673);
            this.Btn_MakeDal.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_MakeDal.Name = "Btn_MakeDal";
            this.Btn_MakeDal.Size = new System.Drawing.Size(119, 29);
            this.Btn_MakeDal.TabIndex = 12;
            this.Btn_MakeDal.Text = "生成 DAL";
            this.Btn_MakeDal.UseVisualStyleBackColor = true;
            this.Btn_MakeDal.Click += new System.EventHandler(this.Btn_MakeDal_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(351, 608);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 29);
            this.button6.TabIndex = 11;
            this.button6.Text = "生成 Repository";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Location = new System.Drawing.Point(999, 608);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "生成 JavaScript";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(825, 608);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "生成 ParamExpand";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(657, 608);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "生成 Controller";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(519, 608);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "生成 Logic";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEntityTableName);
            this.groupBox1.Controls.Add(this.cbToupperFrstword);
            this.groupBox1.Controls.Add(this.btnRemovePrimarykey);
            this.groupBox1.Controls.Add(this.btnAddPrimarykey);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnamespace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPrimarykey);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 366);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1151, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成配置";
            // 
            // cbEntityTableName
            // 
            this.cbEntityTableName.AutoSize = true;
            this.cbEntityTableName.Checked = true;
            this.cbEntityTableName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEntityTableName.Location = new System.Drawing.Point(25, 146);
            this.cbEntityTableName.Margin = new System.Windows.Forms.Padding(4);
            this.cbEntityTableName.Name = "cbEntityTableName";
            this.cbEntityTableName.Size = new System.Drawing.Size(220, 19);
            this.cbEntityTableName.TabIndex = 7;
            this.cbEntityTableName.Text = "生成v1.10.3及以上版本实体";
            this.cbEntityTableName.UseVisualStyleBackColor = true;
            // 
            // cbToupperFrstword
            // 
            this.cbToupperFrstword.AutoSize = true;
            this.cbToupperFrstword.Location = new System.Drawing.Point(365, 146);
            this.cbToupperFrstword.Margin = new System.Windows.Forms.Padding(4);
            this.cbToupperFrstword.Name = "cbToupperFrstword";
            this.cbToupperFrstword.Size = new System.Drawing.Size(104, 19);
            this.cbToupperFrstword.TabIndex = 6;
            this.cbToupperFrstword.Text = "首字母大写";
            this.cbToupperFrstword.UseVisualStyleBackColor = true;
            // 
            // btnRemovePrimarykey
            // 
            this.btnRemovePrimarykey.Location = new System.Drawing.Point(556, 34);
            this.btnRemovePrimarykey.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemovePrimarykey.Name = "btnRemovePrimarykey";
            this.btnRemovePrimarykey.Size = new System.Drawing.Size(100, 29);
            this.btnRemovePrimarykey.TabIndex = 3;
            this.btnRemovePrimarykey.Text = "删除主键";
            this.btnRemovePrimarykey.UseVisualStyleBackColor = true;
            this.btnRemovePrimarykey.Click += new System.EventHandler(this.btnRemovePrimarykey_Click);
            // 
            // btnAddPrimarykey
            // 
            this.btnAddPrimarykey.Location = new System.Drawing.Point(429, 35);
            this.btnAddPrimarykey.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPrimarykey.Name = "btnAddPrimarykey";
            this.btnAddPrimarykey.Size = new System.Drawing.Size(100, 29);
            this.btnAddPrimarykey.TabIndex = 2;
            this.btnAddPrimarykey.Text = "添加主键";
            this.btnAddPrimarykey.UseVisualStyleBackColor = true;
            this.btnAddPrimarykey.Click += new System.EventHandler(this.btnAddPrimarykey_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(429, 92);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(185, 25);
            this.txtClassName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "类名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "命名空间:";
            // 
            // txtnamespace
            // 
            this.txtnamespace.Location = new System.Drawing.Point(121, 92);
            this.txtnamespace.Margin = new System.Windows.Forms.Padding(4);
            this.txtnamespace.Name = "txtnamespace";
            this.txtnamespace.Size = new System.Drawing.Size(191, 25);
            this.txtnamespace.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "主键:";
            // 
            // cbPrimarykey
            // 
            this.cbPrimarykey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrimarykey.FormattingEnabled = true;
            this.cbPrimarykey.Location = new System.Drawing.Point(121, 38);
            this.cbPrimarykey.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrimarykey.Name = "cbPrimarykey";
            this.cbPrimarykey.Size = new System.Drawing.Size(191, 23);
            this.cbPrimarykey.TabIndex = 1;
            // 
            // Btn_MakeModel
            // 
            this.Btn_MakeModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MakeModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_MakeModel.Location = new System.Drawing.Point(209, 608);
            this.Btn_MakeModel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_MakeModel.Name = "Btn_MakeModel";
            this.Btn_MakeModel.Size = new System.Drawing.Size(119, 29);
            this.Btn_MakeModel.TabIndex = 6;
            this.Btn_MakeModel.Text = "生成 Model";
            this.Btn_MakeModel.UseVisualStyleBackColor = true;
            this.Btn_MakeModel.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridColumns
            // 
            this.gridColumns.AllowUserToAddRows = false;
            this.gridColumns.AllowUserToDeleteRows = false;
            this.gridColumns.AllowUserToOrderColumns = true;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridColumns.Location = new System.Drawing.Point(4, 4);
            this.gridColumns.Margin = new System.Windows.Forms.Padding(4);
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.RowTemplate.Height = 23;
            this.gridColumns.Size = new System.Drawing.Size(1151, 362);
            this.gridColumns.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.txtContent);
            this.tp2.ImageIndex = 1;
            this.tp2.Location = new System.Drawing.Point(4, 4);
            this.tp2.Margin = new System.Windows.Forms.Padding(4);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(4);
            this.tp2.Size = new System.Drawing.Size(1159, 802);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "代码查看";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.ContextMenuStrip = this.contextMenuStripSave;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(4, 4);
            this.txtContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(1151, 794);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // contextMenuStripSave
            // 
            this.contextMenuStripSave.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem});
            this.contextMenuStripSave.Name = "contextMenuStripSave";
            this.contextMenuStripSave.Size = new System.Drawing.Size(164, 28);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.txtTemplate);
            this.tp3.ImageIndex = 1;
            this.tp3.Location = new System.Drawing.Point(4, 4);
            this.tp3.Name = "tp3";
            this.tp3.Size = new System.Drawing.Size(1159, 802);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "DAL接口模板";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // txtTemplate
            // 
            this.txtTemplate.ContextMenuStrip = this.contextMenuStripSave;
            this.txtTemplate.DetectUrls = false;
            this.txtTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplate.Location = new System.Drawing.Point(0, 0);
            this.txtTemplate.Margin = new System.Windows.Forms.Padding(0);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ReadOnly = true;
            this.txtTemplate.Size = new System.Drawing.Size(1159, 802);
            this.txtTemplate.TabIndex = 1;
            this.txtTemplate.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pz.ICO");
            this.imageList1.Images.SetKeyName(1, "cs.ICO");
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 831);
            this.Controls.Add(this.tabControl1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "ContentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.tp2.ResumeLayout(false);
            this.contextMenuStripSave.ResumeLayout(false);
            this.tp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.Button Btn_MakeModel;
        private System.Windows.Forms.ComboBox cbPrimarykey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPrimarykey;
        private System.Windows.Forms.Button btnRemovePrimarykey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSave;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveEntity;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cbToupperFrstword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbEntityTableName;
        private System.Windows.Forms.Button Btn_MakeDal;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.RichTextBox txtTemplate;
    }
}