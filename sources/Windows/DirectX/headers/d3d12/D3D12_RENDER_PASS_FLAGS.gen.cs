// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_PASS_FLAGS.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS"]/*' />
[Flags]
public enum D3D12_RENDER_PASS_FLAGS
{
    /// <include file='D3D12_RENDER_PASS_FLAGS.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS.D3D12_RENDER_PASS_FLAG_NONE"]/*' />
    D3D12_RENDER_PASS_FLAG_NONE = 0,

    /// <include file='D3D12_RENDER_PASS_FLAGS.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS.D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES"]/*' />
    D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES = 0x1,

    /// <include file='D3D12_RENDER_PASS_FLAGS.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS.D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS"]/*' />
    D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS = 0x2,

    /// <include file='D3D12_RENDER_PASS_FLAGS.xml' path='doc/member[@name="D3D12_RENDER_PASS_FLAGS.D3D12_RENDER_PASS_FLAG_RESUMING_PASS"]/*' />
    D3D12_RENDER_PASS_FLAG_RESUMING_PASS = 0x4,
}
