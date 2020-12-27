﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesizleMvcCore.Constants
{
    public static class Messages
    {
        public static string Required = "Bu alan zorunludur.";
        public static string Email = "Doğru bir e-mail adresi giriniz.";

        //App
        public static string LoginFailed = "Email veya password hatalı.";
        public static string RegisterSuccess = "Register Success: Register was success.";
        public static string RoleCreateSuccess = "Role create was success.";
        public static string RoleNotFound = "Role not found";
        public static string RoleOrUserNotFound = "Role or user not found";
        public static string RoleDeleteSuccess = "Role deleted to successful.";
        public static string AddToRoleSuccess = "Role Added to successful..";
        public static string RemoveToRoleSuccess = "Role removed to successful.";
        public static string OldPasswordFail = "Eski şifre hatalı.";
        public static string LoginSuccess = "Giriş başarılı.";

        //Auth
        public static string AccessDenied = "Access denied.";
        public static string Unauthorized = "Unauthorized.";

        //Toast
        public static string AlreadyInFavorite = "This movie is already in your favorites.";
        public static string AlreadyInReminders = "This movie is already in your Reminders.";
        public static string AlreadyInWatchedList = "This movie is already in your WatchedList.";
        public static string AlreadyInWatchList = "This movie is already in your WatchList.";

        public static string AddFavoriteSuccess = "Successfully added to favorites.";
        public static string RemoveFavoriteSuccess = "Successfully removed from favorites.";

        public static string AddWatchListSuccess = "Successfully added to watch list.";
        public static string RemoveWatchListSuccess = "Successfully removed from watch list.";

        public static string AddWatchedListSuccess = "Successfully added to watched list.";
        public static string RemoveWatchedListSuccess = "Successfully removed from watched list.";

        public static string ThereWasAnError = "There was an error.";
    }
}
