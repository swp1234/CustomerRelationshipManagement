
namespace CustomerRelationshipManagement
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.registerDateLabel = new System.Windows.Forms.Label();
            this.lastVisitDateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.registerDate = new System.Windows.Forms.DateTimePicker();
            this.lastVisitDate = new System.Windows.Forms.DateTimePicker();
            this.registerButton = new System.Windows.Forms.Button();
            this.memoLabel = new System.Windows.Forms.Label();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(33, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "이름";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(19, 89);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(71, 16);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "핸드폰번호";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexLabel.Location = new System.Drawing.Point(34, 142);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(31, 16);
            this.sexLabel.TabIndex = 2;
            this.sexLabel.Text = "성별";
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointLabel.Location = new System.Drawing.Point(19, 196);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(58, 16);
            this.pointLabel.TabIndex = 3;
            this.pointLabel.Text = "잔여금액";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthLabel.Location = new System.Drawing.Point(20, 258);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(57, 16);
            this.birthLabel.TabIndex = 4;
            this.birthLabel.Text = "생년월일";
            // 
            // registerDateLabel
            // 
            this.registerDateLabel.AutoSize = true;
            this.registerDateLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerDateLabel.Location = new System.Drawing.Point(20, 316);
            this.registerDateLabel.Name = "registerDateLabel";
            this.registerDateLabel.Size = new System.Drawing.Size(59, 16);
            this.registerDateLabel.TabIndex = 5;
            this.registerDateLabel.Text = "등록날짜";
            // 
            // lastVisitDateLabel
            // 
            this.lastVisitDateLabel.AutoSize = true;
            this.lastVisitDateLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastVisitDateLabel.Location = new System.Drawing.Point(4, 367);
            this.lastVisitDateLabel.Name = "lastVisitDateLabel";
            this.lastVisitDateLabel.Size = new System.Drawing.Size(97, 16);
            this.lastVisitDateLabel.TabIndex = 6;
            this.lastVisitDateLabel.Text = "마지막방문날짜";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(334, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(105, 23);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(280, 82);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(159, 23);
            this.phoneTextBox.TabIndex = 8;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sexComboBox
            // 
            this.sexComboBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexComboBox.Location = new System.Drawing.Point(318, 142);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sexComboBox.Size = new System.Drawing.Size(121, 23);
            this.sexComboBox.TabIndex = 9;
            this.sexComboBox.Text = "F";
            // 
            // pointTextBox
            // 
            this.pointTextBox.Location = new System.Drawing.Point(318, 189);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(121, 23);
            this.pointTextBox.TabIndex = 10;
            this.pointTextBox.Text = "0";
            this.pointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(239, 254);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 23);
            this.birthDate.TabIndex = 11;
            this.birthDate.Value = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            // 
            // registerDate
            // 
            this.registerDate.Location = new System.Drawing.Point(239, 312);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(200, 23);
            this.registerDate.TabIndex = 12;
            this.registerDate.Value = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            // 
            // lastVisitDate
            // 
            this.lastVisitDate.Location = new System.Drawing.Point(239, 363);
            this.lastVisitDate.Name = "lastVisitDate";
            this.lastVisitDate.Size = new System.Drawing.Size(200, 23);
            this.lastVisitDate.TabIndex = 13;
            this.lastVisitDate.Value = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("서울남산 장체B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(328, 647);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(111, 36);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "등록";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // memoLabel
            // 
            this.memoLabel.AutoSize = true;
            this.memoLabel.Font = new System.Drawing.Font("서울남산 장체B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoLabel.Location = new System.Drawing.Point(32, 418);
            this.memoLabel.Name = "memoLabel";
            this.memoLabel.Size = new System.Drawing.Size(33, 16);
            this.memoLabel.TabIndex = 15;
            this.memoLabel.Text = "메모";
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(239, 411);
            this.memoTextBox.Multiline = true;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(200, 190);
            this.memoTextBox.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 725);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.memoLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.lastVisitDate);
            this.Controls.Add(this.registerDate);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lastVisitDateLabel);
            this.Controls.Add(this.registerDateLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "회원등록허쉴?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label registerDateLabel;
        private System.Windows.Forms.Label lastVisitDateLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.DateTimePicker registerDate;
        private System.Windows.Forms.DateTimePicker lastVisitDate;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label memoLabel;
        private System.Windows.Forms.TextBox memoTextBox;
    }
}