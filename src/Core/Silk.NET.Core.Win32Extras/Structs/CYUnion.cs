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
    [NativeName("Name", "__AnonymousRecord_wtypes_L679_C5")]
    public unsafe partial struct CYUnion
    {
        public CYUnion
        (
            uint? lo = null,
            int? hi = null
        ) : this()
        {
            if (lo is not null)
            {
                Lo = lo.Value;
            }

            if (hi is not null)
            {
                Hi = hi.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Lo")]
        public uint Lo;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "Hi")]
        public int Hi;
    }
}
