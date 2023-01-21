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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_OMAC")]
    public unsafe partial struct OMAC
    {
        [NativeName("Type", "BYTE[16]")]
        [NativeName("Type.Name", "BYTE[16]")]
        [NativeName("Name", "Omac")]
        public fixed byte Omac[16];
    }
}
