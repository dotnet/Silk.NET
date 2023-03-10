// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEBUGMONITORTOKENS")]
    public enum Debugmonitortokens : int
    {
        [Obsolete("Deprecated in favour of \"Enable\"")]
        [NativeName("Name", "D3DDMT_ENABLE")]
        DmtEnable = 0x0,
        [Obsolete("Deprecated in favour of \"Disable\"")]
        [NativeName("Name", "D3DDMT_DISABLE")]
        DmtDisable = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DDMT_FORCE_DWORD")]
        DmtForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DDMT_ENABLE")]
        Enable = 0x0,
        [NativeName("Name", "D3DDMT_DISABLE")]
        Disable = 0x1,
        [NativeName("Name", "D3DDMT_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
