// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC"]/*' />
public partial struct DXGI_SWAP_CHAIN_FULLSCREEN_DESC
{
    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.RefreshRate"]/*' />
    public DXGI_RATIONAL RefreshRate;

    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.ScanlineOrdering"]/*' />
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;

    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.Scaling"]/*' />
    public DXGI_MODE_SCALING Scaling;

    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.Windowed"]/*' />
    public BOOL Windowed;
}
