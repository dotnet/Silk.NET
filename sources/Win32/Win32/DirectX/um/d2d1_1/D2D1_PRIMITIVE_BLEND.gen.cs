// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_PRIMITIVE_BLEND
{
    D2D1_PRIMITIVE_BLEND_SOURCE_OVER = 0,
    D2D1_PRIMITIVE_BLEND_COPY = 1,
    D2D1_PRIMITIVE_BLEND_MIN = 2,
    D2D1_PRIMITIVE_BLEND_ADD = 3,
    D2D1_PRIMITIVE_BLEND_MAX = 4,
    D2D1_PRIMITIVE_BLEND_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
