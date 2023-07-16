// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1"]/*'/>
public partial struct D3D12_RESOURCE_DESC1
{
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Dimension"]/*'/>
    public D3D12_RESOURCE_DIMENSION Dimension;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Alignment"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong Alignment;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Width"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong Width;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Height"]/*'/>
    public uint Height;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.DepthOrArraySize"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort DepthOrArraySize;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.MipLevels"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort MipLevels;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.SampleDesc"]/*'/>
    public DXGI_SAMPLE_DESC SampleDesc;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Layout"]/*'/>
    public D3D12_TEXTURE_LAYOUT Layout;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.Flags"]/*'/>
    public D3D12_RESOURCE_FLAGS Flags;
    /// <include file='D3D12_RESOURCE_DESC1.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1.SamplerFeedbackMipRegion"]/*'/>
    public D3D12_MIP_REGION SamplerFeedbackMipRegion;
}