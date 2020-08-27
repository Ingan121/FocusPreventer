namespace FocusPreventer
{
    partial class FocusPreventer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FocusPreventer));
            this.textBox = new System.Windows.Forms.TextBox();
            this.PreventFocusFromClassBtn = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PreventFocusFromTitleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PreventFocusFromBothBtn = new System.Windows.Forms.Button();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(51, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(253, 21);
            this.textBox.TabIndex = 0;
            // 
            // PreventFocusFromClassBtn
            // 
            this.PreventFocusFromClassBtn.Location = new System.Drawing.Point(311, 4);
            this.PreventFocusFromClassBtn.Name = "PreventFocusFromClassBtn";
            this.PreventFocusFromClassBtn.Size = new System.Drawing.Size(42, 23);
            this.PreventFocusFromClassBtn.TabIndex = 1;
            this.PreventFocusFromClassBtn.Text = "Do";
            this.PreventFocusFromClassBtn.UseVisualStyleBackColor = true;
            this.PreventFocusFromClassBtn.Click += new System.EventHandler(this.PreventFocusFromClassBtn_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(3, 64);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(190, 12);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "FocusPreventer v0.1 by Ingan121";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 21);
            this.textBox2.TabIndex = 0;
            // 
            // PreventFocusFromTitleBtn
            // 
            this.PreventFocusFromTitleBtn.Location = new System.Drawing.Point(311, 31);
            this.PreventFocusFromTitleBtn.Name = "PreventFocusFromTitleBtn";
            this.PreventFocusFromTitleBtn.Size = new System.Drawing.Size(42, 23);
            this.PreventFocusFromTitleBtn.TabIndex = 1;
            this.PreventFocusFromTitleBtn.Text = "Do";
            this.PreventFocusFromTitleBtn.UseVisualStyleBackColor = true;
            this.PreventFocusFromTitleBtn.Click += new System.EventHandler(this.PreventFocusFromTitleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // PreventFocusFromBothBtn
            // 
            this.PreventFocusFromBothBtn.Location = new System.Drawing.Point(252, 59);
            this.PreventFocusFromBothBtn.Name = "PreventFocusFromBothBtn";
            this.PreventFocusFromBothBtn.Size = new System.Drawing.Size(101, 23);
            this.PreventFocusFromBothBtn.TabIndex = 1;
            this.PreventFocusFromBothBtn.Text = "Match Both";
            this.PreventFocusFromBothBtn.UseVisualStyleBackColor = true;
            this.PreventFocusFromBothBtn.Click += new System.EventHandler(this.PreventFocusFromBothBtn_Click);
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Location = new System.Drawing.Point(204, 64);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(42, 12);
            this.GitHubLink.TabIndex = 4;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "GitHub";
            this.GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 85);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.PreventFocusFromBothBtn);
            this.Controls.Add(this.PreventFocusFromTitleBtn);
            this.Controls.Add(this.PreventFocusFromClassBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FocusPreventer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button PreventFocusFromClassBtn;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PreventFocusFromTitleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PreventFocusFromBothBtn;
        private System.Windows.Forms.LinkLabel GitHubLink;
    }
}

