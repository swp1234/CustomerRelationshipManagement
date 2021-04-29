using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRelationshipManagement
{
    enum ErrorType
    {
        공란,
        유효하지않음,
    };

    enum TextBoxType
    {
        핸드폰번호,
        잔여금액
    }

    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool isTextValid = true;
            string name = nameTextBox.Text.Trim().Replace(" ", "");
            isTextValid = CheckTextIfEmpty(name, "이름");
            if(!isTextValid)
            {
                return;
            }

            string phone = phoneTextBox.Text.Replace("-", "").Trim().Replace(" ", "");
            isTextValid = CheckTextIfEmpty(phone, "핸드폰 번호") && CheckTextIfValid(phone,TextBoxType.핸드폰번호);
            if (!isTextValid)
            {
                return;
            }

            isTextValid = CheckTextIfValid(pointTextBox.Text.Trim().Replace(" ", ""), TextBoxType.잔여금액);
            if (!isTextValid)
            {
                return;
            }
            int point = int.Parse(pointTextBox.Text.Trim().Replace(" ", ""));

        }

        private void ShowWarningMessage(string warningContext, ErrorType type)
        {
            MessageBox.Show($"{warningContext}을(를) 다시 입력해주세요. 원인 : {type.ToString()}", "틀렸다 닝겐", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool CheckTextIfEmpty(string text, string textName)
        {
            if (text.Replace(" ", "").Length <= 0)
            {
                ShowWarningMessage(textName, ErrorType.공란);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckTextIfValid(string text, TextBoxType type)
        {
            bool isTextValid = true;
            switch (type)
            {
                case TextBoxType.잔여금액:
                    if (text.Equals("") || int.Parse(text) < 0)
                    {
                        ShowWarningMessage(type.ToString(), ErrorType.유효하지않음);
                        isTextValid = false;
                    }
                    break;
                case TextBoxType.핸드폰번호:
                    if (text.Length > 11)
                    {
                        ShowWarningMessage(type.ToString(), ErrorType.유효하지않음);
                        isTextValid = false;
                    }
                    break;
            }
            return isTextValid;
        }

        private void pointTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar != '-');
        }
    }
}
