using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountofCategoryError = "Bir Kategoride en fazla 10 ürün olabilir !!";
        public static string ProductNameAlreadyExists = "Aynı İsimde Ürün Eklenemez !!";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı!!";
    }
}
