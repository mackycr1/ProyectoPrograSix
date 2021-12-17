﻿using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Programacion61
{
    public static class SessionExtension
    {


        public static void Set<T>(this ISession session, string key, T value)
        {

            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) :
                JsonSerializer.Deserialize<T>(value);
        }


        public static bool SessionOnline(this HttpContext ct)
        {
            var Session = ct.Session.Get<UsuarioEntity>(IApp.UsuarioSession);
            if (Session == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
