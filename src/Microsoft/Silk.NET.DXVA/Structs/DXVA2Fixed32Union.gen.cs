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

namespace Silk.NET.DXVA
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_dxva2api_L458_C5")]
    public unsafe partial struct DXVA2Fixed32Union
    {
        public DXVA2Fixed32Union
        (
            int? ll = null
        ) : this()
        {
            if (ll is not null)
            {
                Ll = ll.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "ll")]
        public int Ll;
    }
}
