using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public static class Criptografia
    {

        //Method using to Encode, you can use internal, public, private...
        public static string Ecript(string pValue)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(pValue);
            return Convert.ToBase64String(plainTextBytes);
        }

        //Method using to Decode, you can use internal, public, private...
        public static string Decript(string pValue)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(pValue);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
