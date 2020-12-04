// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEBUGMONITORTOKENS")]
    public enum Debugmonitortokens
    {
        [NativeName("Name", "D3DDMT_ENABLE")]
        DmtEnable = 0x0,
        [NativeName("Name", "D3DDMT_DISABLE")]
        DmtDisable = 0x1,
        [NativeName("Name", "D3DDMT_FORCE_DWORD")]
        DmtForceDword = 0x7FFFFFFF,
    }
}
