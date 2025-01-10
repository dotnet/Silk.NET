// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_KARAOKE_CONTENTS
{
    DVD_Karaoke_GuideVocal1 = 0x1,
    DVD_Karaoke_GuideVocal2 = 0x2,
    DVD_Karaoke_GuideMelody1 = 0x4,
    DVD_Karaoke_GuideMelody2 = 0x8,
    DVD_Karaoke_GuideMelodyA = 0x10,
    DVD_Karaoke_GuideMelodyB = 0x20,
    DVD_Karaoke_SoundEffectA = 0x40,
    DVD_Karaoke_SoundEffectB = 0x80,
}
