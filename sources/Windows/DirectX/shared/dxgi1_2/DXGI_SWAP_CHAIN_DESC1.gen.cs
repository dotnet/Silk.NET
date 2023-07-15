// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1"]/*'/>
public partial struct DXGI_SWAP_CHAIN_DESC1
{
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.Width"]/*'/>
    public uint Width;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.Height"]/*'/>
    public uint Height;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.Stereo"]/*'/>
    public BOOL Stereo;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.SampleDesc"]/*'/>
    public DXGI_SAMPLE_DESC SampleDesc;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.BufferUsage"]/*'/>
    [NativeTypeName("DXGI_USAGE")]
    public uint BufferUsage;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.BufferCount"]/*'/>
    public uint BufferCount;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.Scaling"]/*'/>
    public DXGI_SCALING Scaling;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.SwapEffect"]/*'/>
    public DXGI_SWAP_EFFECT SwapEffect;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.AlphaMode"]/*'/>
    public DXGI_ALPHA_MODE AlphaMode;
    /// <include file='DXGI_SWAP_CHAIN_DESC1.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1.Flags"]/*'/>
    public uint Flags;
}