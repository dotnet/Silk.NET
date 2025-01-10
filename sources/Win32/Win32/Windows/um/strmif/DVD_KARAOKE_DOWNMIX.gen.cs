// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_KARAOKE_DOWNMIX
{
    DVD_Mix_0to0 = 0x1,
    DVD_Mix_1to0 = 0x2,
    DVD_Mix_2to0 = 0x4,
    DVD_Mix_3to0 = 0x8,
    DVD_Mix_4to0 = 0x10,
    DVD_Mix_Lto0 = 0x20,
    DVD_Mix_Rto0 = 0x40,
    DVD_Mix_0to1 = 0x100,
    DVD_Mix_1to1 = 0x200,
    DVD_Mix_2to1 = 0x400,
    DVD_Mix_3to1 = 0x800,
    DVD_Mix_4to1 = 0x1000,
    DVD_Mix_Lto1 = 0x2000,
    DVD_Mix_Rto1 = 0x4000,
}
