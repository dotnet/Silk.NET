// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATE_SUBOBJECT.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT"]/*'/>
public unsafe partial struct D3D12_STATE_SUBOBJECT
{
    /// <include file='D3D12_STATE_SUBOBJECT.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT.Type"]/*'/>

    public D3D12_STATE_SUBOBJECT_TYPE Type;

    /// <include file='D3D12_STATE_SUBOBJECT.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT.pDesc"]/*'/>

    [NativeTypeName("const void *")]
    public void* pDesc;
}
