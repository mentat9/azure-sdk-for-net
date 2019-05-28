﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault.Keys
{
    public class KeyImportOptions : Key
    {
        public bool Hsm { get; set; }

        public KeyImportOptions(string name) : base(name) { }

        public KeyImportOptions(string name, JsonWebKey keyMaterial, bool hsm)
            :base(name)
        {
            KeyMaterial = keyMaterial;
            Hsm = hsm;
        }
    }
}
