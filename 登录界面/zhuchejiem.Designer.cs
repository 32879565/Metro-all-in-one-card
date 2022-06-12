namespace 登录界面
{
    partial class zc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yhm = new System.Windows.Forms.TextBox();
            this.miman = new System.Windows.Forms.TextBox();
            this.qrmiman = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(211, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(189, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // yhm
            // 
            this.yhm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yhm.Location = new System.Drawing.Point(307, 98);
            this.yhm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yhm.Multiline = true;
            this.yhm.Name = "yhm";
            this.yhm.Size = new System.Drawing.Size(313, 34);
            this.yhm.TabIndex = 4;
            this.yhm.TextChanged += new System.EventHandler(this.yhm_TextChanged);
            // 
            // miman
            // 
            this.miman.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miman.Location = new System.Drawing.Point(307, 160);
            this.miman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miman.Multiline = true;
            this.miman.Name = "miman";
            this.miman.PasswordChar = '*';
            this.miman.Size = new System.Drawing.Size(313, 34);
            this.miman.TabIndex = 5;
            // 
            // qrmiman
            // 
            this.qrmiman.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qrmiman.Location = new System.Drawing.Point(307, 228);
            this.qrmiman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qrmiman.Multiline = true;
            this.qrmiman.Name = "qrmiman";
            this.qrmiman.PasswordChar = '*';
            this.qrmiman.Size = new System.Drawing.Size(313, 34);
            this.qrmiman.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(377, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "立即注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zc
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qrmiman);
            this.Controls.Add(this.miman);
            this.Controls.Add(this.yhm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "zc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.zc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yhm;
        private System.Windows.Forms.TextBox miman;
        private System.Windows.Forms.TextBox qrmiman;
        private System.Windows.Forms.Button button1;
    }
}