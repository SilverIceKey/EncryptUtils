using EncryptUtils.Features.Feature_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features
{
    /// <summary>
    /// 空加密类
    /// </summary>
    internal class EmptyEncrypt : Encrypt
    {
        private string FillMode = "";
        private string EncryptMode = "";
        public string Decrypt(string content, string key)
        {
            return content;
        }

        public string Encrypt(string content, string key)
        {
            return content;
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
    }
}
