using EncryptUtils.Common;
using EncryptUtils.Features.Feature_Common;
using EncryptUtils.Utils;

namespace EncryptUtils
{
    public partial class Form1 : Form
    {
        private Encrypt encrypt;
        public Form1()
        {
            InitializeComponent();
            encryptFunCB.DataSource = CommonData.EncryptFun;
            encryptFunCB.SelectedValueChanged += EncryptFunCB_SelectedValueChanged;
            encrypt = EncryptHelper.GetEncryptImpl(encryptFunCB.SelectedItem.ToString()!);
            encryptModeCB.SelectedValueChanged += EncryptModeCB_SelectedValueChanged;
            encryptFillModeCB.SelectedValueChanged += EncryptFillModeCB_SelectedValueChanged;
        }

        private void EncryptFillModeCB_SelectedValueChanged(object? sender, EventArgs e)
        {
            encrypt.SetEncryptFillMode(encryptFillModeCB.SelectedItem.ToString()!);
        }

        private void EncryptModeCB_SelectedValueChanged(object? sender, EventArgs e)
        {
            encrypt.SetEncryptMode(encryptModeCB.SelectedItem.ToString()!);
        }

        private void EncryptFunCB_SelectedValueChanged(object? sender, EventArgs e)
        {
            encrypt = EncryptHelper.GetEncryptImpl(encryptFunCB.SelectedItem.ToString()!);
            encryptModeCB.DataSource = encrypt.GetEncryptMode();
            encryptFillModeCB.DataSource = encrypt.GetEncryptFillMode();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contentWaitToDeal.Text))
            {
                MessageBox.Show("请输入待处理内容");
                return;
            }
            if (string.IsNullOrEmpty(encryptKeyTB.Text.ToString()) &&
                !"MD5".Equals(encryptFunCB.SelectedItem.ToString()))
            {
                MessageBox.Show("请输入密钥");
                return;
            }
            string _isKeyCorrect = encrypt.IsKeyCorrect(encryptKeyTB.Text);
            if (!string.IsNullOrEmpty(_isKeyCorrect))
            {
                MessageBox.Show(_isKeyCorrect);
                return;
            }
            string _isContentCorrent = encrypt.IsContentCorrent(contentWaitToDeal.Text);
            if (!string.IsNullOrEmpty(_isContentCorrent))
            {
                MessageBox.Show(_isContentCorrent);
                return;
            }
            string _resultContent = encrypt.Encrypt(contentWaitToDeal.Text, encryptKeyTB.Text);
            contentResult.Text = _resultContent;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if ("MD5".Equals(encryptFunCB.SelectedItem.ToString()))
            {
                MessageBox.Show("MD5无法解密");
                return;
            }
            if (string.IsNullOrEmpty(contentWaitToDeal.Text))
            {
                MessageBox.Show("请输入待处理内容");
                return;
            }
            if (string.IsNullOrEmpty(encryptKeyTB.Text.ToString()) &&
                !"MD5".Equals(encryptFunCB.SelectedItem.ToString()))
            {
                MessageBox.Show("请输入密钥");
                return;
            }
            string _isKeyCorrect = encrypt.IsKeyCorrect(encryptKeyTB.Text);
            if (!string.IsNullOrEmpty(_isKeyCorrect))
            {
                MessageBox.Show(_isKeyCorrect);
                return;
            }
            contentResult.Text = encrypt.Decrypt(contentWaitToDeal.Text, encryptKeyTB.Text);
        }
    }
}