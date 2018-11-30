﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kooboo.Data.Models;

namespace Kooboo.Web.ViewModel
{
    public class SupplierItemViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public bool IsOwner { get; set; }

        public string Introduction { get; set; }

        public List<ResouceAttachment> Attachments { get; set; }
    }
}