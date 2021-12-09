using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Common
{
    public class RSA
    {
        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="publickey"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RSAEncrypt(string publickey, string content)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            //rsa.FromXmlString(publickey);
            rsa.ImportCspBlob(Convert.FromBase64String(publickey));
            cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);

            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="privatekey"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RSADecrypt(string privatekey, string content)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            //rsa.FromXmlString(privatekey);
            rsa.ImportCspBlob(Convert.FromBase64String(privatekey));
            cipherbytes = rsa.Decrypt(Convert.FromBase64String(content), false);

            return Encoding.UTF8.GetString(cipherbytes);
        }

        /// <summary>
        /// 生成一对公钥和私钥
        /// </summary>
        /// <returns></returns>
        public static KeyValuePair<string, string> GenerateKey()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string publicKey = Convert.ToBase64String(RSA.ExportCspBlob(false));
            string privateKey = Convert.ToBase64String(RSA.ExportCspBlob(true));
            return new KeyValuePair<string, string>(publicKey, privateKey);
        }
    }
}
