using System;
using System.Collections.Generic;

#nullable disable

namespace T2010A_WEBAPI.Models
{
    public partial class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string BrandImage { get; set; }
        public string Description { get; set; }
    }
}
