using System;
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
        잔여금액,
        성별,
        이름
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
            isTextValid = CheckTextIfEmpty(name, TextBoxType.이름);
            if (!isTextValid)
            {
                return;
            }

            string phone = phoneTextBox.Text.Replace("-", "").Trim().Replace(" ", "");
            isTextValid = CheckTextIfEmpty(phone, TextBoxType.핸드폰번호) && CheckTextIfValid(phone, TextBoxType.핸드폰번호);
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

            isTextValid = CheckTextIfEmpty(sexComboBox.Text.Trim().Replace(" ", ""), TextBoxType.성별);
            if (!isTextValid)
            {
                return;
            }
            string sex = sexComboBox.Text.Replace(" ", "");

            var birth = birthDate.Value.ToString("yyyy-MM-dd");
            var register = registerDate.Value.ToString("yyyy-MM-dd");
            var lastVisit = lastVisitDate.Value.ToString("yyyy-MM-dd");

            string memo = memoTextBox.Text;

            Database db = new Database();
            bool result = db.RegisterMember(name, phone, sex, point, birth, register, lastVisit,memo);

            if (result)
            {
                ShowConfirmMessage("회원등록이 완료되었습니다.", "등록 성공");
                this.Close();
            }
            else
            {
                ShowWarningMessage("회원등록 실패. 아마 이미 가입되었을지도?!", "등록 실패");
            }
        }

        private void ShowWarningMessage(string text, string header)
        {
            MessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowConfirmMessage(string text, string header)
        {
            MessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckTextIfEmpty(string text, TextBoxType type)
        {
            if (text.Replace(" ", "").Length <= 0)
            {
                ShowWarningMessage($"{type.ToString()}을(를) 다시 입력해주세요. 원인 : {ErrorType.공란}", "틀렸다 닝겐");
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
                        ShowWarningMessage($"{type.ToString()}을(를) 다시 입력해주세요. 원인 : {ErrorType.유효하지않음}", "틀렸다 닝겐");
                        isTextValid = false;
                    }
                    break;
                case TextBoxType.핸드폰번호:
                    if (text.Length > 11)
                    {
                        ShowWarningMessage($"{type.ToString()}을(를) 다시 입력해주세요. 원인 : {ErrorType.유효하지않음}", "틀렸다 닝겐");
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
