// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_ENABLEMENT")]
    public enum DredEnablement : int
    {
        [Obsolete("Deprecated in favour of \"SystemControlled\"")]
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_SYSTEM_CONTROLLED")]
        DredEnablementSystemControlled = 0x0,
        [Obsolete("Deprecated in favour of \"ForcedOff\"")]
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_FORCED_OFF")]
        DredEnablementForcedOff = 0x1,
        [Obsolete("Deprecated in favour of \"ForcedOn\"")]
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_FORCED_ON")]
        DredEnablementForcedOn = 0x2,
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_SYSTEM_CONTROLLED")]
        SystemControlled = 0x0,
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_FORCED_OFF")]
        ForcedOff = 0x1,
        [NativeName("Name", "D3D12_DRED_ENABLEMENT_FORCED_ON")]
        ForcedOn = 0x2,
    }
}
