﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Techsist
{
    // Class that encrypt sensitive information like password
    public class Encrypt
    {
        public Encrypt() { }

        //Uses MD5 to hash the password
        public string MD5Hash(string inputPass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(inputPass));
                return Convert.ToBase64String(data);
            }
            
        }
    }
}
