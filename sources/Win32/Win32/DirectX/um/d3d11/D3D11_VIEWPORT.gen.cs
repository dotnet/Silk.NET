// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_VIEWPORT
{
    public float TopLeftX;
    public float TopLeftY;
    public float Width;
    public float Height;
    public float MinDepth;
    public float MaxDepth;
}
