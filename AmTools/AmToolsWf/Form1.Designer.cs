namespace AmToolsWf
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBodyCN = new System.Windows.Forms.TextBox();
            this.txtBodyEn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBodyCN
            // 
            this.txtBodyCN.Location = new System.Drawing.Point(79, 74);
            this.txtBodyCN.Multiline = true;
            this.txtBodyCN.Name = "txtBodyCN";
            this.txtBodyCN.Size = new System.Drawing.Size(207, 269);
            this.txtBodyCN.TabIndex = 0;
            // 
            // txtBodyEn
            // 
            this.txtBodyEn.Location = new System.Drawing.Point(348, 74);
            this.txtBodyEn.Multiline = true;
            this.txtBodyEn.Name = "txtBodyEn";
            this.txtBodyEn.Size = new System.Drawing.Size(207, 269);
            this.txtBodyEn.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBodyEn);
            this.Controls.Add(this.txtBodyCN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBodyCN;
        private System.Windows.Forms.TextBox txtBodyEn;
        private System.Windows.Forms.Button button1;
    }
}

