﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Jwt
{
   public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expration { get; set; }
    }
}
