// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIEW_INSTANCING_FLAGS")]
    public enum ViewInstancingFlags : int
    {
        [NativeName("Name", "D3D12_VIEW_INSTANCING_FLAG_NONE")]
        ViewInstancingFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIEW_INSTANCING_FLAG_ENABLE_VIEW_INSTANCE_MASKING")]
        ViewInstancingFlagEnableViewInstanceMasking = 0x1,
    }
}
