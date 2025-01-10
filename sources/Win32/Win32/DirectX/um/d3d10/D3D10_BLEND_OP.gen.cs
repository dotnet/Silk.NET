// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_BLEND_OP
{
    D3D10_BLEND_OP_ADD = 1,
    D3D10_BLEND_OP_SUBTRACT = 2,
    D3D10_BLEND_OP_REV_SUBTRACT = 3,
    D3D10_BLEND_OP_MIN = 4,
    D3D10_BLEND_OP_MAX = 5,
}
