
namespace CustomerRelationshipManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MemberInfoLabel = new System.Windows.Forms.Label();
            this.MemberInfoTxtBox = new System.Windows.Forms.TextBox();
            this.MemberSearchBtn = new System.Windows.Forms.Button();
            this.MemberRegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemberInfoLabel
            // 
            this.MemberInfoLabel.AutoSize = true;
            this.MemberInfoLabel.Font = new System.Drawing.Font("서울남산 장체B", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberInfoLabel.Location = new System.Drawing.Point(52, 152);
            this.MemberInfoLabel.Name = "MemberInfoLabel";
            this.MemberInfoLabel.Size = new System.Drawing.Size(172, 48);
            this.MemberInfoLabel.TabIndex = 0;
            this.MemberInfoLabel.Text = "회원정보";
            // 
            // MemberInfoTxtBox
            // 
            this.MemberInfoTxtBox.Font = new System.Drawing.Font("서울남산 장체B", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberInfoTxtBox.Location = new System.Drawing.Point(341, 155);
            this.MemberInfoTxtBox.Name = "MemberInfoTxtBox";
            this.MemberInfoTxtBox.Size = new System.Drawing.Size(264, 31);
            this.MemberInfoTxtBox.TabIndex = 3;
            // 
            // MemberSearchBtn
            // 
            this.MemberSearchBtn.Font = new System.Drawing.Font("서울남산 장체B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberSearchBtn.Location = new System.Drawing.Point(662, 155);
            this.MemberSearchBtn.Name = "MemberSearchBtn";
            this.MemberSearchBtn.Size = new System.Drawing.Size(111, 36);
            this.MemberSearchBtn.TabIndex = 4;
            this.MemberSearchBtn.Text = "검색";
            this.MemberSearchBtn.UseVisualStyleBackColor = true;
            this.MemberSearchBtn.Click += new System.EventHandler(this.MemberSearchBtn_Click);
            // 
            // MemberRegisterBtn
            // 
            this.MemberRegisterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberRegisterBtn.Font = new System.Drawing.Font("서울남산 장체B", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberRegisterBtn.Location = new System.Drawing.Point(416, 318);
            this.MemberRegisterBtn.Name = "MemberRegisterBtn";
            this.MemberRegisterBtn.Size = new System.Drawing.Size(348, 75);
            this.MemberRegisterBtn.TabIndex = 7;
            this.MemberRegisterBtn.Text = "회원등록";
            this.MemberRegisterBtn.UseVisualStyleBackColor = true;
            this.MemberRegisterBtn.Click += new System.EventHandler(this.MemberRegisterBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MemberRegisterBtn);
            this.Controls.Add(this.MemberSearchBtn);
            this.Controls.Add(this.MemberInfoTxtBox);
            this.Controls.Add(this.MemberInfoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "재희네 네일샵";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberInfoLabel;
        private System.Windows.Forms.TextBox MemberInfoTxtBox;
        private System.Windows.Forms.Button MemberSearchBtn;
        private System.Windows.Forms.Button MemberRegisterBtn;
    }
}

