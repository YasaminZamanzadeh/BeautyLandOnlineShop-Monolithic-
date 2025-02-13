﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyLand.Application.Services.Administrator.Catalogs.Types.Dtos.TypeDto
{
    public class TypeGetCatalogDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int ChildCount { get; set; }
    }
}
