namespace SymbolicinkCreator.Presentations
{
    partial class SymbolicinkCreator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymbolicinkCreator));
            this.pnlScreen = new NexFx.Controls.ExPanel();
            this.btnExecute = new NexFx.Controls.ExButton();
            this.txtName = new NexFx.Controls.ExTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.txtCreate = new NexFx.Controls.ExTextBox();
            this.txtLinkPath = new NexFx.Controls.ExTextBox();
            this.lblLinkPath = new System.Windows.Forms.Label();
            this.btnCreate = new NexFx.Controls.ExButton();
            this.btnLinkPath = new NexFx.Controls.ExButton();
            this.pnlScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.Controls.Add(this.btnExecute);
            this.pnlScreen.Controls.Add(this.txtName);
            this.pnlScreen.Controls.Add(this.lblName);
            this.pnlScreen.Controls.Add(this.lblCreate);
            this.pnlScreen.Controls.Add(this.txtCreate);
            this.pnlScreen.Controls.Add(this.txtLinkPath);
            this.pnlScreen.Controls.Add(this.btnCreate);
            this.pnlScreen.Controls.Add(this.btnLinkPath);
            this.pnlScreen.Controls.Add(this.lblLinkPath);
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(433, 193);
            this.pnlScreen.TabIndex = 0;
            // 
            // btnExecute
            // 
            this.btnExecute.CaptionControl = null;
            this.btnExecute.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.btnExecute.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecute.Location = new System.Drawing.Point(15, 148);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(400, 29);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "作成";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtName
            // 
            this.txtName.CaptionControl = this.lblName;
            this.txtName.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(61, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "名称";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(12, 66);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(43, 15);
            this.lblCreate.TabIndex = 3;
            this.lblCreate.Text = "作成元";
            // 
            // txtCreate
            // 
            this.txtCreate.CaptionControl = this.lblCreate;
            this.txtCreate.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtCreate.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCreate.Location = new System.Drawing.Point(90, 63);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(325, 23);
            this.txtCreate.TabIndex = 5;
            this.txtCreate.TabStop = false;
            // 
            // txtLinkPath
            // 
            this.txtLinkPath.CaptionControl = this.lblLinkPath;
            this.txtLinkPath.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtLinkPath.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLinkPath.Location = new System.Drawing.Point(90, 20);
            this.txtLinkPath.Name = "txtLinkPath";
            this.txtLinkPath.Size = new System.Drawing.Size(325, 23);
            this.txtLinkPath.TabIndex = 2;
            this.txtLinkPath.TabStop = false;
            // 
            // lblLinkPath
            // 
            this.lblLinkPath.AutoSize = true;
            this.lblLinkPath.Location = new System.Drawing.Point(12, 23);
            this.lblLinkPath.Name = "lblLinkPath";
            this.lblLinkPath.Size = new System.Drawing.Size(43, 15);
            this.lblLinkPath.TabIndex = 0;
            this.lblLinkPath.Text = "リンク先";
            // 
            // btnCreate
            // 
            this.btnCreate.CaptionControl = this.lblCreate;
            this.btnCreate.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.btnCreate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(61, 62);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(23, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLinkPath
            // 
            this.btnLinkPath.CaptionControl = this.lblLinkPath;
            this.btnLinkPath.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.btnLinkPath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLinkPath.Location = new System.Drawing.Point(61, 19);
            this.btnLinkPath.Name = "btnLinkPath";
            this.btnLinkPath.Size = new System.Drawing.Size(23, 23);
            this.btnLinkPath.TabIndex = 1;
            this.btnLinkPath.UseVisualStyleBackColor = true;
            this.btnLinkPath.Click += new System.EventHandler(this.btnLinkPath_Click);
            // 
            // SymbolicinkCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(433, 193);
            this.Controls.Add(this.pnlScreen);
            this.DuplicateLastTimePosition = true;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.GradationColor1 = System.Drawing.Color.AliceBlue;
            this.GradationColor2 = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SymbolicinkCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SymbolicinkCreator";
            this.Load += new System.EventHandler(this.SymbolicinkCreator_Load);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NexFx.Controls.ExPanel pnlScreen;
        private System.Windows.Forms.Label lblCreate;
        private NexFx.Controls.ExTextBox txtLinkPath;
        private NexFx.Controls.ExButton btnLinkPath;
        private System.Windows.Forms.Label lblLinkPath;
        private NexFx.Controls.ExTextBox txtCreate;
        private NexFx.Controls.ExButton btnCreate;
        private NexFx.Controls.ExTextBox txtName;
        private System.Windows.Forms.Label lblName;
        private NexFx.Controls.ExButton btnExecute;
    }
}
