// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC"]/*' />
public partial struct DXGI_SWAP_CHAIN_DESC
{
    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferDesc"]/*' />
    public DXGI_MODE_DESC BufferDesc;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.SampleDesc"]/*' />
    public DXGI_SAMPLE_DESC SampleDesc;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferUsage"]/*' />
    [NativeTypeName("DXGI_USAGE")]
    public uint BufferUsage;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferCount"]/*' />
    public uint BufferCount;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.OutputWindow"]/*' />
    public HWND OutputWindow;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.Windowed"]/*' />
    public BOOL Windowed;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.SwapEffect"]/*' />
    public DXGI_SWAP_EFFECT SwapEffect;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.Flags"]/*' />
    public uint Flags;
}
