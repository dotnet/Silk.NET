// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DRED_ENABLEMENT")]
    public enum DredEnablement : int
    {
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_SYSTEM_CONTROLLED")]
        DredEnablementSystemControlled = 0x0,
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_FORCED_OFF")]
        DredEnablementForcedOff = 0x1,
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_FORCED_ON")]
        DredEnablementForcedOn = 0x2,
    }
}
