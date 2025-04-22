namespace MachVision_Sz_Form
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.calendar1 = new AntdUI.Calendar();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(389, 12);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(369, 405);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendar1);
            this.Name = "MainForm";
            this.Text = "视觉控制软件";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Calendar calendar1;
    }
}

