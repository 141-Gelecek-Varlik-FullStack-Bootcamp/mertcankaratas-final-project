﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    /// <summary>
    /// Yapılan istekler ve  işlem sonucunda gösterilen hata veya başarı mesajları bulunduğu static classtır
    /// Döndürülen mesajlar sistemle işlemle ilgili bilgiler içerir dolayısı ile döndürülen mesajlar API projelerinde önemlidir.
    /// </summary>
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";
        public static string CategoryAdded = "Category Eklendi";
        public static string CategoryDeleted = "Category Silindi";
        public static string CategoryUpdated = "Category Güncellendi";
        public static string CategoryListed = "Category Listelendi";

        public static string ProductNameInvalid = "Ürün İsmi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Urunler listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün limitini aştınız";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Categori limit aşıldı";
        public static string AuthorizationDenied = "Bu işlemi gerçekleştirmek için Yetkiniz yok";
        public static string UserRegistered = "giriş yapıldı";
        public static string PasswordError = "parola hatası";
        public static string LoginRequired = "Bu işlemi gerçekleştirmek için Lütfen giriş yapınız";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "giriş tokenı yaratıldı";
        public static string CheckEmailOrPassword = "Email ve Parolanızı kontrol edip tekrar deneyiniz.";
        public static string FieldNotNull = "Filtreleme yapılacak alanlar boş bırakılmamalıdır.";

        public static string PaymentAdded = "Ödeme Eklendi.";
        public static string PaymentDeleted = "Ödeme Silindi.";
        public static string PaymentUpdated = "Ödeme Güncellendi";
        public static string PaymentListed = "Ödemeler Listelendi";


        public static string DuesAdded = "Aidat Eklendi.";
        public static string DuesDeleted = "Aidat Silindi.";
        public static string DuesUpdated = "Aidaat Güncellendi";
        public static string DuesListed = "Aditlar Listelendi";

        public static string ApartmentAdded = "Daire Eklendi.";
        public static string ApartmentDeleted = "Daire Silindi.";
        public static string ApartmentUpdated = "Daire Güncellendi";
        public static string ApartmentListed = "Daire Listelendi";

        public static string InvoiceTypeAdded = "Fatura tipi Eklendi.";
        public static string InvoiceTypeDeleted = "Fatura tipi Silindi.";
        public static string InvoiceTypeUpdated = "Fatura tipi Güncellendi";
        public static string InvoiceTypeListed = "Fatura tipleri Listelendi";

    }
}