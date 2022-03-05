// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "_D3D_INCLUDE_TYPE")]
    public enum D3DIncludeType : int
    {
        [NativeName("Name", "D3D_INCLUDE_LOCAL")]
        D3DIncludeLocal = 0x0,
        [NativeName("Name", "D3D_INCLUDE_SYSTEM")]
        D3DIncludeSystem = 0x1,
        [NativeName("Name", "D3D10_INCLUDE_LOCAL")]
        D3D10IncludeLocal = 0x0,
        [NativeName("Name", "D3D10_INCLUDE_SYSTEM")]
        D3D10IncludeSystem = 0x1,
        [NativeName("Name", "D3D_INCLUDE_FORCE_DWORD")]
        D3DIncludeForceDword = 0x7FFFFFFF,
    }
}
