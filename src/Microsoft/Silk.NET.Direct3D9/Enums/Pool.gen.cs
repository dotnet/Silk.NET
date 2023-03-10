// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPOOL")]
    public enum Pool : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3DPOOL_DEFAULT")]
        PoolDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Managed\"")]
        [NativeName("Name", "D3DPOOL_MANAGED")]
        PoolManaged = 0x1,
        [Obsolete("Deprecated in favour of \"Systemmem\"")]
        [NativeName("Name", "D3DPOOL_SYSTEMMEM")]
        PoolSystemmem = 0x2,
        [Obsolete("Deprecated in favour of \"Scratch\"")]
        [NativeName("Name", "D3DPOOL_SCRATCH")]
        PoolScratch = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DPOOL_FORCE_DWORD")]
        PoolForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DPOOL_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D3DPOOL_MANAGED")]
        Managed = 0x1,
        [NativeName("Name", "D3DPOOL_SYSTEMMEM")]
        Systemmem = 0x2,
        [NativeName("Name", "D3DPOOL_SCRATCH")]
        Scratch = 0x3,
        [NativeName("Name", "D3DPOOL_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
