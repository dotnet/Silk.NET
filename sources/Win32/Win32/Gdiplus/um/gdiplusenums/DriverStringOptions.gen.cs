// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

[Flags]
public enum DriverStringOptions
{
    DriverStringOptionsCmapLookup = 1,
    DriverStringOptionsVertical = 2,
    DriverStringOptionsRealizedAdvance = 4,
    DriverStringOptionsLimitSubpixel = 8,
}
