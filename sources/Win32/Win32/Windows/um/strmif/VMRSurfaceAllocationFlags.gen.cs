// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum VMRSurfaceAllocationFlags
{
    AMAP_PIXELFORMAT_VALID = 0x1,
    AMAP_3D_TARGET = 0x2,
    AMAP_ALLOW_SYSMEM = 0x4,
    AMAP_FORCE_SYSMEM = 0x8,
    AMAP_DIRECTED_FLIP = 0x10,
    AMAP_DXVA_TARGET = 0x20,
}
