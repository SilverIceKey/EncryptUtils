using EncryptUtils.Features.Feature_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features.Feature_MD5
{
    /// <summary>
    /// MD5加密类
    /// </summary>
    internal class MD5Encrypt : Encrypt
    {
        private string FillMode = "";
        private string EncryptMode = "";
        public string Decrypt(string content, string key, string iv = "")
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string content, string key, string iv = "")
        {
            return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(content))).Replace("-","");
        }

        public string[] GetEncryptFillMode()
        {
            return new string[] { };
        }

        public string[] GetEncryptMode()
        {
            return new string[] { };
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
            return "";
        }
        bool Encrypt.IsIVEnable()
        {
            return false;
        }
    }
}
