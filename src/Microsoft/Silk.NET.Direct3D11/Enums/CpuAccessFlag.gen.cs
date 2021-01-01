// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CPU_ACCESS_FLAG")]
    public enum CpuAccessFlag : int
    {
        [NativeName("Name", "D3D11_CPU_ACCESS_WRITE")]
        CpuAccessWrite = 0x10000,
        [NativeName("Name", "D3D11_CPU_ACCESS_READ")]
        CpuAccessRead = 0x20000,
    }
}
