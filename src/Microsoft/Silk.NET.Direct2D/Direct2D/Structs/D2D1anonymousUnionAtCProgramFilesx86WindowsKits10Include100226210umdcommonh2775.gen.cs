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

namespace Silk.NET.Direct2D
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "(anonymous union at C:\Program Files (x86)\Windows Kits\10\Include\10.0.22621.0\um\dcommon.h:277:5)")]
    public unsafe partial struct D2D1anonymousUnionAtCProgramFilesx86WindowsKits10Include100226210umdcommonh2775
    {
        public D2D1anonymousUnionAtCProgramFilesx86WindowsKits10Include100226210umdcommonh2775
        (
            __AnonymousRecord_dcommon_L312_C9? anonymous2 = null
        ) : this()
        {
            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }
        }


        [FieldOffset(0)]
        [BuildToolsIntrinsic($FUSECPP, __AnonymousRecord_dcommon_L312_C9)]
        [NativeName("Type", "(anonymous struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.22621.0\\um\\dcommon.h:312:9)")]
        [NativeName("Type.Name", "__AnonymousRecord_dcommon_L312_C9")]
        [NativeName("Name", "anonymous2")]
        public __AnonymousRecord_dcommon_L312_C9 Anonymous2;
        [FieldOffset(0)]
        [NativeName("Type", "FLOAT[3][2]")]
        [NativeName("Type.Name", "FLOAT[3][2]")]
        [NativeName("Name", "m")]
        public fixed float M[6];
    }
}
