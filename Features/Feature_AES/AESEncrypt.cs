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
        private bool IsIVEnable = false;
        private Aes aes;
        public AESEncrypt()
        {
            aes = Aes.Create();
        }
        public string Decrypt(string content, string key, string iv = "")
        {
            aes.Key = EncryptHelper.GetKey(Encoding.UTF8.GetBytes(key));
            switch (EncryptMode)
            {
                case "ECB":
                    aes.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    aes.Mode = CipherMode.CBC;
                    if (!string.IsNullOrEmpty(iv))
                    {
                        aes.IV = Encoding.UTF8.GetBytes(iv);
                    }
                    break;
                default:
                    aes.Mode = CipherMode.ECB;
                    break;
            }
            switch (FillMode)
            {
                case "ZeroPadding":
                    aes.Padding = PaddingMode.Zeros;
                    break;
                case "PKCS7Padding":
                    aes.Padding = PaddingMode.PKCS7;
                    break;
            }

            ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] _contentBytes = Convert.FromBase64String(content);
            string _result = Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(_contentBytes, 0, _contentBytes.Length));
            return _result;
        }

        public string Encrypt(string content, string key, string iv = "")
        {
            aes.Key = EncryptHelper.GetKey(Encoding.UTF8.GetBytes(key));
            switch (EncryptMode)
            {
                case "ECB":
                    aes.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    aes.Mode = CipherMode.CBC;
                    if (!string.IsNullOrEmpty(iv))
                    {
                        aes.IV = Encoding.UTF8.GetBytes(iv);
                    }
                    break;
                default:
                    aes.Mode = CipherMode.ECB;
                    break;
            }
            switch (FillMode)
            {
                case "ZeroPadding":
                    aes.Padding = PaddingMode.Zeros;
                    break;
                case "PKCS7Padding":
                    aes.Padding = PaddingMode.PKCS7;
                    break;
            }
            ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] _contentBytes = Encoding.UTF8.GetBytes(content);
            string _result = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(_contentBytes, 0, _contentBytes.Length));
            return _result;
        }

        public string[] GetEncryptFillMode()
        {
            return new string[] { "ZeroPadding", "PKCS7Padding" };
        }

        public string[] GetEncryptMode()
        {
            return new string[] { "ECB", "CBC" };
        }

        public string IsContentCorrent(string content)
        {
            //if ("NoPadding".Equals(FillMode) && Encoding.UTF8.GetBytes(content).Length % 16 != 0)
            //{
            //    return "加密内容长度不正确";
            //}
            return "";
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
            IsIVEnable = "CBC".Equals(mode);
            EncryptMode = mode;
        }

        bool Encrypt.IsIVEnable()
        {
            return IsIVEnable;
        }
    }
}
