namespace BLL
{
    partial class ucCheckbox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checktrue = new System.Windows.Forms.CheckBox();
            this.checkfalse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checktrue
            // 
            this.checktrue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.checktrue.AutoSize = true;
            this.checktrue.Location = new System.Drawing.Point(4, 4);
            this.checktrue.Name = "checktrue";
            this.checktrue.Size = new System.Drawing.Size(48, 16);
            this.checktrue.TabIndex = 0;
            this.checktrue.Text = "已投";
            this.checktrue.UseVisualStyleBackColor = true;
            this.checktrue.CheckedChanged += new System.EventHandler(this.checktrue_CheckedChanged);
            // 
            // checkfalse
            // 
            this.checkfalse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.checkfalse.AutoSize = true;
            this.checkfalse.Location = new System.Drawing.Point(56, 4);
            this.checkfalse.Name = "checkfalse";
            this.checkfalse.Size = new System.Drawing.Size(48, 16);
            this.checkfalse.TabIndex = 1;
            this.checkfalse.Text = "未投";
            this.checkfalse.UseVisualStyleBackColor = true;
            this.checkfalse.CheckedChanged += new System.EventHandler(this.checkfalse_CheckedChanged);
            // 
            // ucCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkfalse);
            this.Controls.Add(this.checktrue);
            this.Name = "ucCheckbox";
            this.Size = new System.Drawing.Size(116, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checktrue;
        private System.Windows.Forms.CheckBox checkfalse;
    }
}
