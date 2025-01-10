// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_BITMAPSOURCE_ALPHA_MODE
{
    D2D1_BITMAPSOURCE_ALPHA_MODE_PREMULTIPLIED = 1,
    D2D1_BITMAPSOURCE_ALPHA_MODE_STRAIGHT = 2,
    D2D1_BITMAPSOURCE_ALPHA_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
