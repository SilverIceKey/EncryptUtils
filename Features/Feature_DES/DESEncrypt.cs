using EncryptUtils.Features.Feature_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features.Feature_DES
{
    /// <summary>
    /// DES加密类
    /// </summary>
    internal class DESEncrypt : Encrypt
    {
        private string FillMode = "";
        private string EncryptMode = "";
        private bool IsIVEnable = false;
        private DES des;

        public DESEncrypt()
        {
            des = DES.Create();
        }
        public string Decrypt(string content, string key, string iv = "")
        {
            des.Key = Encoding.UTF8.GetBytes(key).Take(8).ToArray();
            switch (EncryptMode)
            {
                case "ECB":
                    des.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    des.Mode= CipherMode.CBC;
                    if (!string.IsNullOrEmpty(iv))
                    {
                        des.IV = Encoding.UTF8.GetBytes(iv);
                    }
                    break;
                default:
                    des.Mode = CipherMode.ECB;
                    break;
            }
            switch (FillMode)
            {
                case "ZeroPadding":
                    des.Padding = PaddingMode.Zeros;
                    break;
                case "PKCS7Padding":
                    des.Padding = PaddingMode.PKCS7;
                    break;
                default:
                    des.Padding = PaddingMode.Zeros;
                    break;
            }
            byte[] _contentBytes = Convert.FromBase64String(content);
            ICryptoTransform cryptoTransform = des.CreateDecryptor();
            string _result = Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(_contentBytes,0,_contentBytes.Length));
            return _result;
        }

        public string Encrypt(string content, string key, string iv = "")
        {
            des.Key = Encoding.UTF8.GetBytes(key).Take(8).ToArray();
            switch (EncryptMode)
            {
                case "ECB":
                    des.Mode = CipherMode.ECB;
                    break;
                case "CBC":
                    des.Mode = CipherMode.CBC;
                    if (!string.IsNullOrEmpty(iv))
                    {
                        des.IV = Encoding.UTF8.GetBytes(iv);
                    }
                    break;
                default:
                    des.Mode = CipherMode.ECB;
                    break;
            }
            switch (FillMode)
            {
                case "ZeroPadding":
                    des.Padding = PaddingMode.Zeros;
                    break;
                case "PKCS7Padding":
                    des.Padding = PaddingMode.PKCS7;
                    break;
                default:
                    des.Padding = PaddingMode.Zeros;
                    break;
            }
            byte[] _contentBytes = Encoding.UTF8.GetBytes(content);
            ICryptoTransform cryptoTransform = des.CreateEncryptor();
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
        public void SetEncryptFillMode(string fillMode)
        {
            FillMode = fillMode;
        }

        public void SetEncryptMode(string mode)
        {
            EncryptMode = mode;
        }
        public string IsKeyCorrect(string key)
        {
            return "";
        }
        public string IsContentCorrent(string content)
        {
            //if ("NoPadding".Equals(FillMode) && Encoding.UTF8.GetBytes(content).Length % 16 != 0)
            //{
            //    return "加密内容长度不正确";
            //}
            return "";
        }
        bool Encrypt.IsIVEnable()
        {
            return IsIVEnable;
        }
    }
}
