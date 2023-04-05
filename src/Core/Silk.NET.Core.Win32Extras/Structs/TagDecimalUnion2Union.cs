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
    [NativeName("Name", "__AnonymousRecord_wtypes_L714_C9")]
    public unsafe partial struct TagDecimalUnion2Union
    {
        public TagDecimalUnion2Union
        (
            uint? lo32 = null,
            uint? mid32 = null
        ) : this()
        {
            if (lo32 is not null)
            {
                Lo32 = lo32.Value;
            }

            if (mid32 is not null)
            {
                Mid32 = mid32.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Lo32")]
        public uint Lo32;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Mid32")]
        public uint Mid32;
    }
}
