using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptUtils.Features.Feature_Common
{
    /// <summary>
    /// 加密接口
    /// </summary>
    internal interface Encrypt
    {
        /// <summary>
        /// 设置加密模式
        /// </summary>
        /// <param name="mode"></param>
        void SetEncryptMode(string mode);

        /// <summary>
        /// 设置填充方式
        /// </summary>
        /// <param name="fillMode"></param>
        void SetEncryptFillMode(string fillMode);

        /// <summary>
        /// 密钥是否正确
        /// </summary>
        /// <param name="key"></param>
        /// <returns>正确时返回空或者null</returns>
        string IsKeyCorrect(string key);

        /// <summary>
        /// 获取加密模式
        /// </summary>
        /// <returns></returns>
        string[] GetEncryptMode();

        /// <summary>
        /// 获取加密填充模式
        /// </summary>
        /// <returns></returns>
        string[] GetEncryptFillMode();

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="content">待处理内容</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        string Encrypt(string content, string key);

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="content">待处理内容</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        string Decrypt(string content, string key);
    }
}
