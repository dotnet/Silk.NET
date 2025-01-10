// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D11_CONTEXT_TYPE
{
    D3D11_CONTEXT_TYPE_ALL = 0,
    D3D11_CONTEXT_TYPE_3D = 1,
    D3D11_CONTEXT_TYPE_COMPUTE = 2,
    D3D11_CONTEXT_TYPE_COPY = 3,
    D3D11_CONTEXT_TYPE_VIDEO = 4,
}
