using EncryptUtils.Features.Feature_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features.Feature_RSA
{
    /// <summary>
    /// RSA加密类
    /// </summary>
    internal class RSAEncrypt : Encrypt
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
            return new string[] { "PKCS1Padding", "OAEPWithSHA-1AndMGF1Padding", "OAEPWithSHA-256AndMGF1Padding" };
        }

        public string[] GetEncryptMode()
        {
            return new string[] { "ECB" };
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
            return "";
        }
    }
}
