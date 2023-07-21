// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_LIFETIME_STATE.xml' path='doc/member[@name="D3D12_LIFETIME_STATE"]/*' />
public enum D3D12_LIFETIME_STATE
{
    /// <include file='D3D12_LIFETIME_STATE.xml' path='doc/member[@name="D3D12_LIFETIME_STATE.D3D12_LIFETIME_STATE_IN_USE"]/*' />
    D3D12_LIFETIME_STATE_IN_USE = 0,

    /// <include file='D3D12_LIFETIME_STATE.xml' path='doc/member[@name="D3D12_LIFETIME_STATE.D3D12_LIFETIME_STATE_NOT_IN_USE"]/*' />
    D3D12_LIFETIME_STATE_NOT_IN_USE = (D3D12_LIFETIME_STATE_IN_USE + 1),
}
