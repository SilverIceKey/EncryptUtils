using EncryptUtils.Features.Feature_Common;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public string Decrypt(string content, string key)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string content, string key)
        {
            throw new NotImplementedException();
        }

        public string[] GetEncryptFillMode()
        {
            return new string[] { "NoPadding", "PKCS7Padding" };
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
            if (key.Length == 128)
            {
                return "";
            }
            else
            {
                return "密钥长度不对";
            }
        }
        public string IsContentCorrent(string content)
        {
            if ("NoPadding".Equals(FillMode) && Encoding.UTF8.GetBytes(content).Length % 16 != 0)
            {
                return "加密内容长度不正确";
            }
            return "";
        }
    }
}
