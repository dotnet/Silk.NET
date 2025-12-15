// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE")]
    public enum RenderPassBeginningAccessType : int
    {
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD")]
        RenderPassBeginningAccessTypeDiscard = 0x0,
        [Obsolete("Deprecated in favour of \"Preserve\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE")]
        RenderPassBeginningAccessTypePreserve = 0x1,
        [Obsolete("Deprecated in favour of \"Clear\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR")]
        RenderPassBeginningAccessTypeClear = 0x2,
        [Obsolete("Deprecated in favour of \"NoAccess\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS")]
        RenderPassBeginningAccessTypeNoAccess = 0x3,
        [Obsolete("Deprecated in favour of \"PreserveLocalRender\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER")]
        RenderPassBeginningAccessTypePreserveLocalRender = 0x4,
        [Obsolete("Deprecated in favour of \"PreserveLocalSrv\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_SRV")]
        RenderPassBeginningAccessTypePreserveLocalSrv = 0x5,
        [Obsolete("Deprecated in favour of \"PreserveLocalUav\"")]
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_UAV")]
        RenderPassBeginningAccessTypePreserveLocalUav = 0x6,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD")]
        Discard = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE")]
        Preserve = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR")]
        Clear = 0x2,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS")]
        NoAccess = 0x3,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER")]
        PreserveLocalRender = 0x4,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_SRV")]
        PreserveLocalSrv = 0x5,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_UAV")]
        PreserveLocalUav = 0x6,
    }
}
