// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC"]/*'/>
public unsafe partial struct D3D12_VIEW_INSTANCING_DESC
{
    /// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC.ViewInstanceCount"]/*'/>
    public uint ViewInstanceCount;
    /// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC.pViewInstanceLocations"]/*'/>
    [NativeTypeName("const D3D12_VIEW_INSTANCE_LOCATION *")]
    public D3D12_VIEW_INSTANCE_LOCATION* pViewInstanceLocations;
    /// <include file='D3D12_VIEW_INSTANCING_DESC.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_DESC.Flags"]/*'/>
    public D3D12_VIEW_INSTANCING_FLAGS Flags;
}