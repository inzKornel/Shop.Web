﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    public class Cover
    {
        public int CoverId { get; set; }
        public CoverType Type { get; set; }
    }

    public enum CoverType { BROSZURA, TWARDA, MIĘKKA, SZYTA, WKLEJANA }
}