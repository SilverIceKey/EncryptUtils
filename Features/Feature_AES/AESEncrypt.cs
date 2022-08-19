using EncryptUtils.Common;
using EncryptUtils.Features.Feature_Common;
using EncryptUtils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features.Feature_AES
{
    /// <summary>
    /// AES加密类
    /// </summary>
    internal class AESEncrypt : Encrypt
    {
        private string FillMode = "";
        private string EncryptMode = "";
        private Aes aes;
        public AESEncrypt()
        {
            aes = Aes.Create();
        }
        public string Decrypt(string content, string key)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string content, string key)
        {
            aes.Key = EncryptHelper.GetKey(Encoding.UTF8.GetBytes(key));
            aes.IV = CommonData.zeroIV;
            switch (EncryptMode)
            {
                case "ECB":
                    aes.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    aes.Mode = CipherMode.CBC;
                    break;
                default:
                    aes.Mode = CipherMode.ECB;
                    break;
            }
            switch (FillMode)
            {
                case "NoPadding":
                    aes.Padding = PaddingMode.None;
                    break;
                case "PKCS5Padding":
                    aes.Padding = PaddingMode.PKCS7;
                    break;
            }
            switch (key.Length)
            {
                case 16:
                    aes.KeySize = 128;
                    break;
                case 24:
                    aes.KeySize = 192;
                    break;
                case 32:
                    aes.KeySize = 256;
                    break;

            }
            aes.BlockSize = 128;
            ICryptoTransform cryptoTransform = aes.CreateEncryptor();
            byte[] _contentBytes = Encoding.UTF8.GetBytes(content);
            //if (aes.Padding != PaddingMode.None)
            //{

            //}
            string _result = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(_contentBytes, 0, _contentBytes.Length));
            return _result;
        }

        public string[] GetEncryptFillMode()
        {
            return new string[] { "NoPadding", "PKCS5Padding" };
        }

        public string[] GetEncryptMode()
        {
            return new string[] { "ECB", "CBC" };
        }

        public string IsKeyCorrect(string key)
        {
            if (key.Length == 16 || key.Length == 24 || key.Length == 32)
            {
                return "";
            }
            else
            {
                return "密钥长度不对";
            }
        }

        public void SetEncryptFillMode(string fillMode)
        {
            FillMode = fillMode;
        }

        public void SetEncryptMode(string mode)
        {
            EncryptMode = mode;
        }
    }
}
