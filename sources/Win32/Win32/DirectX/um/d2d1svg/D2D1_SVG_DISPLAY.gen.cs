// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_SVG_DISPLAY
{
    D2D1_SVG_DISPLAY_INLINE = 0,
    D2D1_SVG_DISPLAY_NONE = 1,
    D2D1_SVG_DISPLAY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
