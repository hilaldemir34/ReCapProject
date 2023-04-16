using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash//verdiğimiz passwordün hashini oluşturuyor
        (string password, out byte[] passwordHash, out byte[] passwordSalt)//bir password verip dışarıya passwordHash ve passwordSalt çıkartıcaz
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }

        }
        public static bool VerifyPasswordHah(string password, byte[]passwordHash, byte[] passwordSalt)//sonradan sisteme girmek isteyen 
                                                                                                      //kişinin vermiş olduğu passwordün
                                                                                                      //veri kaynağımızdaki hashle ilgili salta göre eşleşip
                                                                                                      //eşleşmediğini verdiğimiz yer.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//aşağıda hesaplanan hash bu saltı kullanarak yapılır.
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for(int i=0;i<computedHash.Length;i++)
                {
                    if (computedHash != passwordHash)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
