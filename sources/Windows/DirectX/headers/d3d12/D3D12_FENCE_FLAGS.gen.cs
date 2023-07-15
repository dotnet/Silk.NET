// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_FENCE_FLAGS.xml' path='doc/member[@name="D3D12_FENCE_FLAGS"]/*'/>
[Flags]
public enum D3D12_FENCE_FLAGS
{
    /// <include file='D3D12_FENCE_FLAGS.xml' path='doc/member[@name="D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE"]/*'/>
    D3D12_FENCE_FLAG_NONE = 0,
    /// <include file='D3D12_FENCE_FLAGS.xml' path='doc/member[@name="D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_SHARED"]/*'/>
    D3D12_FENCE_FLAG_SHARED = 0x1,
    /// <include file='D3D12_FENCE_FLAGS.xml' path='doc/member[@name="D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_SHARED_CROSS_ADAPTER"]/*'/>
    D3D12_FENCE_FLAG_SHARED_CROSS_ADAPTER = 0x2,
    /// <include file='D3D12_FENCE_FLAGS.xml' path='doc/member[@name="D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NON_MONITORED"]/*'/>
    D3D12_FENCE_FLAG_NON_MONITORED = 0x4,
}