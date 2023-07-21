// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT"]/*' />
public enum DXGI_SWAP_EFFECT
{
    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_DISCARD"]/*' />
    DXGI_SWAP_EFFECT_DISCARD = 0,

    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_SEQUENTIAL"]/*' />
    DXGI_SWAP_EFFECT_SEQUENTIAL = 1,

    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL"]/*' />
    DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL = 3,

    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_DISCARD"]/*' />
    DXGI_SWAP_EFFECT_FLIP_DISCARD = 4,
}
