// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public enum PathPointType
{
    PathPointTypeStart = 0,
    PathPointTypeLine = 1,
    PathPointTypeBezier = 3,
    PathPointTypePathTypeMask = 0x07,
    PathPointTypeDashMode = 0x10,
    PathPointTypePathMarker = 0x20,
    PathPointTypeCloseSubpath = 0x80,
    PathPointTypeBezier3 = 3,
}
