// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RENDER_PASS_FLAGS")]
    public enum RenderPassFlags : int
    {
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_NONE")]
        RenderPassFlagNone = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES")]
        RenderPassFlagAllowUavWrites = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS")]
        RenderPassFlagSuspendingPass = 0x2,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_RESUMING_PASS")]
        RenderPassFlagResumingPass = 0x4,
    }
}
