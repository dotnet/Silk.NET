// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_SERIALIZATION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SERIALIZATION"]/*'/>
public partial struct D3D12_FEATURE_DATA_SERIALIZATION
{
    /// <include file='D3D12_FEATURE_DATA_SERIALIZATION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SERIALIZATION.NodeIndex"]/*'/>
    public uint NodeIndex;
    /// <include file='D3D12_FEATURE_DATA_SERIALIZATION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_SERIALIZATION.HeapSerializationTier"]/*'/>
    public D3D12_HEAP_SERIALIZATION_TIER HeapSerializationTier;
}