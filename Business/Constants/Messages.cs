using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategoride 10 üründen fazlası var";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var";
        internal static string CategoryLimitExceded = "Kategori Limiti aşıldı";
    }
}
