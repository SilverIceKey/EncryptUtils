using EncryptUtils.Features.Feature_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features.Feature_SM
{
    internal class SMEncrypt : Encrypt
    {
        private string EncryptMode = "";
        private string PaddingMode = "";
        public string Decrypt(string content, string key, string iv = "")
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string content, string key, string iv = "")
        {
            throw new NotImplementedException();
        }

        public string[] GetEncryptFillMode()
        {
            return new string[] { };
        }

        public string[] GetEncryptMode()
        {
            return new string[] { "SM2", "SM3", "SM4" };
        }

        public string IsContentCorrent(string content)
        {
            return "";
        }

        public bool IsIVEnable()
        {
            return false;
        }

        public string IsKeyCorrect(string key)
        {
            throw new NotImplementedException();
        }

        public void SetEncryptFillMode(string fillMode)
        {
            PaddingMode = fillMode;
        }

        public void SetEncryptMode(string mode)
        {
            EncryptMode = mode;
        }
    }
}
