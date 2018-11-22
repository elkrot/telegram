using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://elkrotbot.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "elkrotbot";

        public static string Key { get; set; }  = "764370336:AAEay1tQQodk4TpFHQ-nYtylP9hLGsnVVKE";

    }
}