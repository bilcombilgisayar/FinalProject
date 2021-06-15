using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime= "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde bir Ürün zaten mevcut";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni kategori eklenemez";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Giriş Başarılı";
    }
}
