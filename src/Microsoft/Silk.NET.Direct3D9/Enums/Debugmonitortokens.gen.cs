// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DDEBUGMONITORTOKENS")]
    public enum Debugmonitortokens : int
    {
        [NativeName("Name", "D3DDMT_ENABLE")]
        DmtEnable = 0x0,
        [NativeName("Name", "D3DDMT_DISABLE")]
        DmtDisable = 0x1,
        [NativeName("Name", "D3DDMT_FORCE_DWORD")]
        DmtForceDword = 0x7FFFFFFF,
    }
}
