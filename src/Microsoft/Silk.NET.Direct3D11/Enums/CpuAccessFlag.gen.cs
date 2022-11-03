// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_CPU_ACCESS_FLAG")]
    public enum CpuAccessFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Write\"")]
        [NativeName("Name", "D3D11_CPU_ACCESS_WRITE")]
        CpuAccessWrite = 0x10000,
        [Obsolete("Deprecated in favour of \"Read\"")]
        [NativeName("Name", "D3D11_CPU_ACCESS_READ")]
        CpuAccessRead = 0x20000,
        [NativeName("Name", "D3D11_CPU_ACCESS_WRITE")]
        Write = 0x10000,
        [NativeName("Name", "D3D11_CPU_ACCESS_READ")]
        Read = 0x20000,
    }
}
