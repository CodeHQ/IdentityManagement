﻿using System.Collections.Generic;
using IdentityManagement.Web.Areas.IdentityManagement.Models;

namespace IdentityManagement.Web.Areas.IdentityManagement.Helpers
{
    public static class ErrorHelper
    {
        public static void AddError(this ActionStatus status, string error)
        {
            if (status.Errors == null)
            {
                status.Errors = new List<ActionError>();
            }
            status.Errors.Add(new ActionError(){Reason = error});
        }

        public static void AddErrors(this ActionStatus status, IEnumerable<string> errors)
        {
            if (status.Errors == null)
            {
                status.Errors = new List<ActionError>();
            }
            foreach (var error in errors)
            {
                status.Errors.Add(new ActionError(){Reason = error});
            }
        }
    }
}