// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_FLAGS")]
    public enum DredFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_DRED_FLAG_NONE")]
        DredFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ForceEnable\"")]
        [NativeName("Name", "D3D12_DRED_FLAG_FORCE_ENABLE")]
        DredFlagForceEnable = 0x1,
        [Obsolete("Deprecated in favour of \"DisableAutobreadcrumbs\"")]
        [NativeName("Name", "D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS")]
        DredFlagDisableAutobreadcrumbs = 0x2,
        [NativeName("Name", "D3D12_DRED_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_DRED_FLAG_FORCE_ENABLE")]
        ForceEnable = 0x1,
        [NativeName("Name", "D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS")]
        DisableAutobreadcrumbs = 0x2,
    }
}
