using MvcParty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcParty.Helpers
{
    public static class Extensions
    {
        public static string GetUserInfo (this GuestResponse model)
        {
            return String.Format("User: {0}-{1}-{2}", model.Name, model.Email, model.Phone);
        }
    }
}