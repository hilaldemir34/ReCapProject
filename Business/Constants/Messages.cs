using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarInvalidName = "Araba ismi geçersiz";
        internal static string MaintenanceTime="Ürünler listelendi";
        public static string  CarsListed;
        public static string InvalidNameError;
        public static string Succeed;
        public static object CarColorError="Araba sayısı en fazla 25 olabilir.";
        internal static string CarNameAlreadyExist;
        internal static string CarNameAlreadyExists;
        internal static string ColorUpdated;
    }
}
