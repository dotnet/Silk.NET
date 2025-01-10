// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_PARENTAL_LEVEL
{
    DVD_PARENTAL_LEVEL_8 = 0x8000,
    DVD_PARENTAL_LEVEL_7 = 0x4000,
    DVD_PARENTAL_LEVEL_6 = 0x2000,
    DVD_PARENTAL_LEVEL_5 = 0x1000,
    DVD_PARENTAL_LEVEL_4 = 0x800,
    DVD_PARENTAL_LEVEL_3 = 0x400,
    DVD_PARENTAL_LEVEL_2 = 0x200,
    DVD_PARENTAL_LEVEL_1 = 0x100,
}
