// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE")]
    public enum RenderPassBeginningAccessType
    {
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD")]
        RenderPassBeginningAccessTypeDiscard = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE")]
        RenderPassBeginningAccessTypePreserve = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR")]
        RenderPassBeginningAccessTypeClear = 0x2,
        [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS")]
        RenderPassBeginningAccessTypeNoAccess = 0x3,
    }
}
