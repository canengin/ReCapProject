using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddSingular = " eklendi.";
        public static string UpdateSingular = " Güncellendi";
        public static string DeleteSingular = " silindi.";
        public static string CarNameValidation = "En az 2 karakter girilmelidir..";
        public static string PriceValidation = "Girdiğiniz değer 0'dan büyük olmak zorunda";
        public static string NotExist = "Bulunamadı ";
        public static string AlreadyExist = "Zaten var";
        public static string RentSuccess = "Araç kiralama başarılı";
        public static string ReturnSuccess = "Araç iade gerçekleşti";
        public static string InvalidName = "İsim en az 2 harften oluşmalı";
        public static string InvalidPrice = "Fiyat 0'dan büyük bir değer olmalı";
        public static string InvalidFileExtension = "Geçersiz dosya ";
        public static string ImageNumberLimitExceeded = "Araç için resim limiti dolmuştur.Daha fazla ekleyemessiniz";

        public static string AuthorizationDenied = "Yetkilendirme Reddedildi.";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string PasswordError = "Parola Hatalı.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string UserRegistered = "Kayıt olundu.";
    }
}
