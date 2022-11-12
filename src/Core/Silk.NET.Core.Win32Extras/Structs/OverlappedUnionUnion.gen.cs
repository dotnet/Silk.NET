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
    [NativeName("Name", "__AnonymousRecord_minwinbase_L56_C9")]
    public unsafe partial struct OverlappedUnionUnion
    {
        public OverlappedUnionUnion
        (
            int? offset = null,
            int? offsetHigh = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (offsetHigh is not null)
            {
                OffsetHigh = offsetHigh.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Offset")]
        public int Offset;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "OffsetHigh")]
        public int OffsetHigh;
    }
}
