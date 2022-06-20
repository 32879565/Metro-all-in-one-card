namespace 登录界面
{
    partial class yhzbxxgli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yhzbxxgli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yhkh = new System.Windows.Forms.TextBox();
            this.yhxm = new System.Windows.Forms.TextBox();
            this.yhxb = new System.Windows.Forms.ComboBox();
            this.yhnl = new System.Windows.Forms.TextBox();
            this.chusje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.yhxingm = new System.Windows.Forms.TextBox();
            this.ZX市 = new System.Windows.Forms.Button();
            this.dgv_userInfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(309, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(543, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(75, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户年龄：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(312, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "初始金额：";
            // 
            // yhkh
            // 
            this.yhkh.Location = new System.Drawing.Point(153, 45);
            this.yhkh.Margin = new System.Windows.Forms.Padding(4);
            this.yhkh.MaxLength = 5;
            this.yhkh.Name = "yhkh";
            this.yhkh.Size = new System.Drawing.Size(132, 25);
            this.yhkh.TabIndex = 5;
            // 
            // yhxm
            // 
            this.yhxm.Location = new System.Drawing.Point(392, 44);
            this.yhxm.Margin = new System.Windows.Forms.Padding(4);
            this.yhxm.Name = "yhxm";
            this.yhxm.Size = new System.Drawing.Size(132, 25);
            this.yhxm.TabIndex = 6;
            // 
            // yhxb
            // 
            this.yhxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yhxb.FormattingEnabled = true;
            this.yhxb.Items.AddRange(new object[] {
            "男",
            "女"});
            this.yhxb.Location = new System.Drawing.Point(625, 44);
            this.yhxb.Margin = new System.Windows.Forms.Padding(4);
            this.yhxb.Name = "yhxb";
            this.yhxb.Size = new System.Drawing.Size(79, 23);
            this.yhxb.TabIndex = 7;
            this.yhxb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // yhnl
            // 
            this.yhnl.Location = new System.Drawing.Point(153, 121);
            this.yhnl.Margin = new System.Windows.Forms.Padding(4);
            this.yhnl.Name = "yhnl";
            this.yhnl.Size = new System.Drawing.Size(132, 25);
            this.yhnl.TabIndex = 8;
            // 
            // chusje
            // 
            this.chusje.Location = new System.Drawing.Point(392, 120);
            this.chusje.Margin = new System.Windows.Forms.Padding(4);
            this.chusje.Name = "chusje";
            this.chusje.ReadOnly = true;
            this.chusje.Size = new System.Drawing.Size(132, 25);
            this.chusje.TabIndex = 9;
            this.chusje.Text = "100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(153, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "添加用户基本信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(72, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "用户姓名：";
            // 
            // yhxingm
            // 
            this.yhxingm.Location = new System.Drawing.Point(157, 274);
            this.yhxingm.Margin = new System.Windows.Forms.Padding(4);
            this.yhxingm.Name = "yhxingm";
            this.yhxingm.Size = new System.Drawing.Size(132, 25);
            this.yhxingm.TabIndex = 12;
            // 
            // ZX市
            // 
            this.ZX市.BackColor = System.Drawing.Color.Transparent;
            this.ZX市.Location = new System.Drawing.Point(341, 268);
            this.ZX市.Margin = new System.Windows.Forms.Padding(4);
            this.ZX市.Name = "ZX市";
            this.ZX市.Size = new System.Drawing.Size(100, 29);
            this.ZX市.TabIndex = 13;
            this.ZX市.Text = "查询数据";
            this.ZX市.UseVisualStyleBackColor = false;
            this.ZX市.Click += new System.EventHandler(this.ZX市_Click);
            // 
            // dgv_userInfo
            // 
            this.dgv_userInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userInfo.Location = new System.Drawing.Point(13, 310);
            this.dgv_userInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_userInfo.MultiSelect = false;
            this.dgv_userInfo.Name = "dgv_userInfo";
            this.dgv_userInfo.RowHeadersWidth = 51;
            this.dgv_userInfo.RowTemplate.Height = 23;
            this.dgv_userInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_userInfo.Size = new System.Drawing.Size(733, 212);
            this.dgv_userInfo.TabIndex = 14;
            this.dgv_userInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_userInfo_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 121);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // yhzbxxgli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 522);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgv_userInfo);
            this.Controls.Add(this.ZX市);
            this.Controls.Add(this.yhxingm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chusje);
            this.Controls.Add(this.yhnl);
            this.Controls.Add(this.yhxb);
            this.Controls.Add(this.yhxm);
            this.Controls.Add(this.yhkh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yhzbxxgli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户基本信息管理";
            this.Load += new System.EventHandler(this.用户基本信息管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yhkh;
        private System.Windows.Forms.TextBox yhxm;
        private System.Windows.Forms.ComboBox yhxb;
        private System.Windows.Forms.TextBox yhnl;
        private System.Windows.Forms.TextBox chusje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yhxingm;
        private System.Windows.Forms.Button ZX市;
        private System.Windows.Forms.DataGridView dgv_userInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;


    }
}