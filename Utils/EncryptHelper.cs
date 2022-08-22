using EncryptUtils.Features;
using EncryptUtils.Features.Feature_AES;
using EncryptUtils.Features.Feature_Common;
using EncryptUtils.Features.Feature_DES;
using EncryptUtils.Features.Feature_MD5;
using EncryptUtils.Features.Feature_RSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Utils
{
    /// <summary>
    /// 加密帮助类
    /// </summary>
    internal class EncryptHelper
    {
        /// <summary>
        /// 切换加密类
        /// </summary>
        /// <param name="encryptFun"></param>
        /// <returns></returns>
        public static Encrypt GetEncryptImpl(string encryptFun)
        {
            switch (encryptFun)
            {
                case "MD5":
                    return new MD5Encrypt();
                case "AES":
                    return new AESEncrypt();
                case "DES":
                    return new DESEncrypt();
                case "RSA":
                    return new RSAEncrypt();
                default:
                    return new EmptyEncrypt();
            }
        }
        /// <summary>
        /// 密钥补齐
        /// </summary>
        /// <param name="keyBytes"></param>
        public static byte[] GetKey(byte[] keyBytes)
        {
            if (keyBytes.Length % 16 != 0)
            {
                int groups = (keyBytes.Length / 16) + ((keyBytes.Length % 16) != 0 ? 1 : 0);
                byte[] temp = new byte[groups * 16];
                // 关键代码 补全
                BitConverter.ToInt32(temp, 0);
                Array.Copy(keyBytes, 0, temp, 0, keyBytes.Length);
                keyBytes = temp;
            }
            return keyBytes;
        }

        public static byte[] GetContent(byte[] contentBytes,bool paddingZero = true)
        {
            if (contentBytes.Length % 8 != 0)
            {
                int groups = ((contentBytes.Length / 8) + 2) * 8;
                byte[] temp = new byte[groups];
                Array.Copy(contentBytes, 0, temp, 0, contentBytes.Length);
                for (int i = contentBytes.Length; i < temp.Length; i++)
                {
                    if (paddingZero)
                    {
                        temp[i] = 0;
                    }
                    else
                    {
                        if ((contentBytes.Length % 8) != 0)
                        {
                            temp[i] = (byte)(temp.Length - contentBytes.Length % 8);
                        }
                        else
                        {
                            temp[i] = 0;
                        }
                    }
                }
                contentBytes = temp;
            }
            return contentBytes;
        }
    }
}
