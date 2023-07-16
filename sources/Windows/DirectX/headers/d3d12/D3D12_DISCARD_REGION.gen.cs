// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D12_DISCARD_REGION.xml' path='doc/member[@name="D3D12_DISCARD_REGION"]/*'/>
public unsafe partial struct D3D12_DISCARD_REGION
{
    /// <include file='D3D12_DISCARD_REGION.xml' path='doc/member[@name="D3D12_DISCARD_REGION.NumRects"]/*'/>
    public uint NumRects;
    /// <include file='D3D12_DISCARD_REGION.xml' path='doc/member[@name="D3D12_DISCARD_REGION.pRects"]/*'/>
    [NativeTypeName("const D3D12_RECT *")]
    public RECT* pRects;
    /// <include file='D3D12_DISCARD_REGION.xml' path='doc/member[@name="D3D12_DISCARD_REGION.FirstSubresource"]/*'/>
    public uint FirstSubresource;
    /// <include file='D3D12_DISCARD_REGION.xml' path='doc/member[@name="D3D12_DISCARD_REGION.NumSubresources"]/*'/>
    public uint NumSubresources;
}