﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MonikAIBot.Services
{
    public class Configuration
    {
        public string Token { get; set; }
        public string Prefix { get; set; }
        public ulong[] Owners { get; set; }
    }
}
