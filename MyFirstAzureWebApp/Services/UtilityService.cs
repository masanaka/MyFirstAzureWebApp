using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp.Services
{
    public class UtilityService
    {
        ///<summary>
        ///生成随机字符串 
        ///</summary>
        ///<param name="length">目标字符串的长度</param>
        ///<param name="useNumber">是否包含数字，true=包含，默认为包含</param>
        ///<param name="useLower">是否包含小写字母，true=包含，默认为包含</param>
        ///<param name="useUpper">是否包含大写字母，true=包含，默认为包含</param>
        ///<param name="useSpe">是否包含特殊字符，true=包含，默认为不包含</param>
        ///<param name="custom">要包含的自定义字符，直接输入要包含的字符列表</param>
        ///<param name="start">start with</param>
        ///<returns>指定长度的随机字符串</returns>
        public static string GetRandomString(int length, bool useNumber = true, bool useLower = true, bool useUpper = true
                                                , bool useSpecial = false, string custom = "", string start = "")
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNumber) { str += "0123456789"; }
            if (useLower) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpper) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpecial) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length - start.Length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return start + s;
        }
    }
}
