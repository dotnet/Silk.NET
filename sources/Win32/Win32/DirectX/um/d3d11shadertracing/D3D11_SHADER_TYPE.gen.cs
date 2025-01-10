// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public enum D3D11_SHADER_TYPE
{
    D3D11_VERTEX_SHADER = 1,
    D3D11_HULL_SHADER = 2,
    D3D11_DOMAIN_SHADER = 3,
    D3D11_GEOMETRY_SHADER = 4,
    D3D11_PIXEL_SHADER = 5,
    D3D11_COMPUTE_SHADER = 6,
}
