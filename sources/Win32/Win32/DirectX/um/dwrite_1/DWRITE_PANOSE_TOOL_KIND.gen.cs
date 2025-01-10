// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_TOOL_KIND
{
    DWRITE_PANOSE_TOOL_KIND_ANY = 0,
    DWRITE_PANOSE_TOOL_KIND_NO_FIT = 1,
    DWRITE_PANOSE_TOOL_KIND_FLAT_NIB = 2,
    DWRITE_PANOSE_TOOL_KIND_PRESSURE_POINT = 3,
    DWRITE_PANOSE_TOOL_KIND_ENGRAVED = 4,
    DWRITE_PANOSE_TOOL_KIND_BALL = 5,
    DWRITE_PANOSE_TOOL_KIND_BRUSH = 6,
    DWRITE_PANOSE_TOOL_KIND_ROUGH = 7,
    DWRITE_PANOSE_TOOL_KIND_FELT_PEN_BRUSH_TIP = 8,
    DWRITE_PANOSE_TOOL_KIND_WILD_BRUSH = 9,
}
