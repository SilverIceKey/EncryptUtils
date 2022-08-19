using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Common
{
    /// <summary>
    /// 通用数据
    /// </summary>
    internal class CommonData
    {
        public static string[] EncryptFun = { "MD5", "AES", "DES", "RSA" };

        public static byte[] zeroIV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}
