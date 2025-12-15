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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PROGRAM_IDENTIFIER")]
    public unsafe partial struct ProgramIdentifier
    {
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "OpaqueData")]
        public fixed ulong OpaqueData[4];
    }
}
