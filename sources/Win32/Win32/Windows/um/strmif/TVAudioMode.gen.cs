// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TVAudioMode
{
    AMTVAUDIO_MODE_MONO = 0x1,
    AMTVAUDIO_MODE_STEREO = 0x2,
    AMTVAUDIO_MODE_LANG_A = 0x10,
    AMTVAUDIO_MODE_LANG_B = 0x20,
    AMTVAUDIO_MODE_LANG_C = 0x40,
    AMTVAUDIO_PRESET_STEREO = 0x200,
    AMTVAUDIO_PRESET_LANG_A = 0x1000,
    AMTVAUDIO_PRESET_LANG_B = 0x2000,
    AMTVAUDIO_PRESET_LANG_C = 0x4000,
}
