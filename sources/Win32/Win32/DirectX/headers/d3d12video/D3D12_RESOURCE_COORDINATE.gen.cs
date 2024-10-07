// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_RESOURCE_COORDINATE"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12_RESOURCE_COORDINATE
{
    /// <include file='D3D12_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_RESOURCE_COORDINATE.X"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong X;

    /// <include file='D3D12_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_RESOURCE_COORDINATE.Y"]/*'/>

    public uint Y;

    /// <include file='D3D12_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_RESOURCE_COORDINATE.Z"]/*'/>

    public uint Z;

    /// <include file='D3D12_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_RESOURCE_COORDINATE.SubresourceIndex"]/*'/>

    public uint SubresourceIndex;
}
