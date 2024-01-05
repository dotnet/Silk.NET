// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT"]/*'/>
public partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT.Support"]/*'/>

    public D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS Support;
}
