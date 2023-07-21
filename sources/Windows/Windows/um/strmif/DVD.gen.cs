// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DVD
{
    [NativeTypeName("#define DVD_TITLE_MENU 0x000")]
    public const int DVD_TITLE_MENU = 0x000;

    [NativeTypeName("#define DVD_STREAM_DATA_CURRENT 0x800")]
    public const int DVD_STREAM_DATA_CURRENT = 0x800;

    [NativeTypeName("#define DVD_STREAM_DATA_VMGM 0x400")]
    public const int DVD_STREAM_DATA_VMGM = 0x400;

    [NativeTypeName("#define DVD_STREAM_DATA_VTSM 0x401")]
    public const int DVD_STREAM_DATA_VTSM = 0x401;

    [NativeTypeName("#define DVD_DEFAULT_AUDIO_STREAM 0x0f")]
    public const int DVD_DEFAULT_AUDIO_STREAM = 0x0f;

    [NativeTypeName("#define DVD_AUDIO_CAPS_AC3 0x00000001")]
    public const int DVD_AUDIO_CAPS_AC3 = 0x00000001;

    [NativeTypeName("#define DVD_AUDIO_CAPS_MPEG2 0x00000002")]
    public const int DVD_AUDIO_CAPS_MPEG2 = 0x00000002;

    [NativeTypeName("#define DVD_AUDIO_CAPS_LPCM 0x00000004")]
    public const int DVD_AUDIO_CAPS_LPCM = 0x00000004;

    [NativeTypeName("#define DVD_AUDIO_CAPS_DTS 0x00000008")]
    public const int DVD_AUDIO_CAPS_DTS = 0x00000008;

    [NativeTypeName("#define DVD_AUDIO_CAPS_SDDS 0x00000010")]
    public const int DVD_AUDIO_CAPS_SDDS = 0x00000010;
}
