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
    [NativeName("Name", "(anonymous union at C:\Program Files (x86)\Windows Kits\10\Include\10.0.22621.0\um\dcommon.h:352:5)")]
    public unsafe partial struct D2D1anonymousUnionAtCProgramFilesx86WindowsKits10Include100226210umdcommonh3525
    {
        [FieldOffset(0)]
        [NativeName("Type", "FLOAT[4][4]")]
        [NativeName("Type.Name", "FLOAT[4][4]")]
        [NativeName("Name", "m")]
        public fixed float M[16];
    }
}
