using System.Security.Cryptography;
using System.Text;

namespace KB.Security.Hasher
{
    public static partial class KB_Security
    {
        private static UnicodeEncoding hashUE = new UnicodeEncoding();
        public static string HashMD5(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = md5.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA1(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha1.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA256(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha256.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA384(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA384 sha384 = SHA384.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha384.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA512(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA512 sha512 = SHA512.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha512.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        #region Supported => .NET 8, .NET 9, Windows Desktop 9
        //public static string HashSHA3_256(string str)
        //{
        //    if (!String.IsNullOrEmpty(str))
        //    {
        //        using (SHA3_256 sha3_256 = SHA3_256.Create())
        //        {
        //            byte[] strBytes = hashUE.GetBytes(str);
        //            byte[] hashBytes = sha3_256.ComputeHash(strBytes);
        //            return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
        //        }
        //    }
        //    return "";
        //}
        //public static string HashSHA3_384(string str)
        //{
        //    if (!String.IsNullOrEmpty(str))
        //    {
        //        using (SHA3_384 sha3_384 = SHA3_384.Create())
        //        {
        //            byte[] strBytes = hashUE.GetBytes(str);
        //            byte[] hashBytes = sha3_384.ComputeHash(strBytes);
        //            return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
        //        }
        //    }
        //    return "";
        //}
        //public static string HashSHA3_512(string str)
        //{
        //    if (!String.IsNullOrEmpty(str))
        //    {
        //        using (SHA3_512 sha3_512 = SHA3_512.Create())
        //        {
        //            byte[] strBytes = hashUE.GetBytes(str);
        //            byte[] hashBytes = sha3_512.ComputeHash(strBytes);
        //            return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
        //        }
        //    }
        //    return "";
        //}
        #endregion
    }

    public static partial class KB_Security_Extensions
    {
        private static UnicodeEncoding hashUE = new UnicodeEncoding();
        public static string HashMD5(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = md5.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA1(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha1.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA256(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha256.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA384(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA384 sha384 = SHA384.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha384.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        public static string HashSHA512(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                using (SHA512 sha512 = SHA512.Create())
                {
                    byte[] strBytes = hashUE.GetBytes(str);
                    byte[] hashBytes = sha512.ComputeHash(strBytes);
                    return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
                }
            }
            return "";
        }
        #region Supported => .NET 8, .NET 9, Windows Desktop 9
        //public static string HashSHA3_256(this string str)
        //{
        //    if (!String.IsNullOrEmpty(str))
        //    {
        //        using (SHA3_256 sha3_256 = SHA3_256.Create())
        //        {
        //            byte[] strBytes = hashUE.GetBytes(str);
        //            byte[] hashBytes = sha3_256.ComputeHash(strBytes);
        //            return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
        //        }
        //    }
        //    return "";
        //}
        //public static string HashSHA3_384(this string str)
        //{
        //    if (!String.IsNullOrEmpty(str))
        //    {
        //        using (SHA3_384 sha3_384 = SHA3_384.Create())
        //        {
        //            byte[] strBytes = hashUE.GetBytes(str);
        //            byte[] hashBytes = sha3_384.ComputeHash(strBytes);
        //            return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
        //        }
        //    }
        //    return "";
        //}
        //public static string HashSHA3_512(this string str)
        //{
        //    if (!String.IsNullOrEmpty(str))
        //    {
        //        using (SHA3_512 sha3_512 = SHA3_512.Create())
        //        {
        //            byte[] strBytes = hashUE.GetBytes(str);
        //            byte[] hashBytes = sha3_512.ComputeHash(strBytes);
        //            return BitConverter.ToString(hashBytes).ToUpper().Replace("-", "");
        //        }
        //    }
        //    return "";
        //}
        #endregion
    }
}
