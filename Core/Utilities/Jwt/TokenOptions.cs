﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Jwt
{
   public class TokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpration { get; set; }
        public string SecurityKey { get; set; }
    }
}
