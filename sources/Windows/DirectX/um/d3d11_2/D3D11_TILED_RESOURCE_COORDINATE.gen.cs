// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D11_TILED_RESOURCE_COORDINATE"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct D3D11_TILED_RESOURCE_COORDINATE
{
    /// <include file='D3D11_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D11_TILED_RESOURCE_COORDINATE.X"]/*'/>
    public uint X;
    /// <include file='D3D11_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D11_TILED_RESOURCE_COORDINATE.Y"]/*'/>
    public uint Y;
    /// <include file='D3D11_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D11_TILED_RESOURCE_COORDINATE.Z"]/*'/>
    public uint Z;
    /// <include file='D3D11_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D11_TILED_RESOURCE_COORDINATE.Subresource"]/*'/>
    public uint Subresource;
}