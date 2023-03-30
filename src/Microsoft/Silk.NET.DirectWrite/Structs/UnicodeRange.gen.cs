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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_UNICODE_RANGE")]
    public unsafe partial struct UnicodeRange
    {
        public UnicodeRange
        (
            uint? first = null,
            uint? last = null
        ) : this()
        {
            if (first is not null)
            {
                First = first.Value;
            }

            if (last is not null)
            {
                Last = last.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "first")]
        public uint First;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "last")]
        public uint Last;
    }
}
