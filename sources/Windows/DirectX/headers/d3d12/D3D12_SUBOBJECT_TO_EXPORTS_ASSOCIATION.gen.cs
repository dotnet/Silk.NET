// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*' />
public unsafe partial struct D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION
{
    /// <include file='D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.pSubobjectToAssociate"]/*' />
    [NativeTypeName("const D3D12_STATE_SUBOBJECT *")]
    public D3D12_STATE_SUBOBJECT* pSubobjectToAssociate;

    /// <include file='D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.NumExports"]/*' />
    public uint NumExports;

    /// <include file='D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION.pExports"]/*' />
    [NativeTypeName("LPCWSTR *")]
    public ushort** pExports;
}
