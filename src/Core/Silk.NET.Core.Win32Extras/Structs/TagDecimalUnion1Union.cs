// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "__AnonymousRecord_wtypes_L706_C9")]
    public unsafe partial struct TagDecimalUnion1Union
    {
        public TagDecimalUnion1Union
        (
            byte? scale = null,
            byte? sign = null
        ) : this()
        {
            if (scale is not null)
            {
                Scale = scale.Value;
            }

            if (sign is not null)
            {
                Sign = sign.Value;
            }
        }


        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "scale")]
        public byte Scale;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "sign")]
        public byte Sign;
    }
}
