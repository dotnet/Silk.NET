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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_NONE")]
        RenderPassFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowUavWrites\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES")]
        RenderPassFlagAllowUavWrites = 0x1,
        [Obsolete("Deprecated in favour of \"SuspendingPass\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS")]
        RenderPassFlagSuspendingPass = 0x2,
        [Obsolete("Deprecated in favour of \"ResumingPass\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_RESUMING_PASS")]
        RenderPassFlagResumingPass = 0x4,
        [Obsolete("Deprecated in favour of \"BindReadOnlyDepth\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_BIND_READ_ONLY_DEPTH")]
        RenderPassFlagBindReadOnlyDepth = 0x8,
        [Obsolete("Deprecated in favour of \"BindReadOnlyStencil\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_BIND_READ_ONLY_STENCIL")]
        RenderPassFlagBindReadOnlyStencil = 0x10,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES")]
        AllowUavWrites = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS")]
        SuspendingPass = 0x2,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_RESUMING_PASS")]
        ResumingPass = 0x4,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_BIND_READ_ONLY_DEPTH")]
        BindReadOnlyDepth = 0x8,
        [NativeName("Name", "D3D12_RENDER_PASS_FLAG_BIND_READ_ONLY_STENCIL")]
        BindReadOnlyStencil = 0x10,
    }
}
