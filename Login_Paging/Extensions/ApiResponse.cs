﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Paging.Extensions
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object data { get; set; }
    }
}
