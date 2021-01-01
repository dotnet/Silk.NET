// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_ADAPTER_FLAG")]
    public enum AdapterFlag : int
    {
        [NativeName("Name", "DXGI_ADAPTER_FLAG_NONE")]
        AdapterFlagNone = 0x0,
        [NativeName("Name", "DXGI_ADAPTER_FLAG_REMOTE")]
        AdapterFlagRemote = 0x1,
        [NativeName("Name", "DXGI_ADAPTER_FLAG_SOFTWARE")]
        AdapterFlagSoftware = 0x2,
        [NativeName("Name", "DXGI_ADAPTER_FLAG_FORCE_DWORD")]
        AdapterFlagForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
