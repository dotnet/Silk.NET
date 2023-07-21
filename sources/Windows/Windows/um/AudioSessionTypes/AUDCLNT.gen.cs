// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AudioSessionTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class AUDCLNT
{
    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_CROSSPROCESS 0x00010000")]
    public const int AUDCLNT_STREAMFLAGS_CROSSPROCESS = 0x00010000;

    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_LOOPBACK 0x00020000")]
    public const int AUDCLNT_STREAMFLAGS_LOOPBACK = 0x00020000;

    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_EVENTCALLBACK 0x00040000")]
    public const int AUDCLNT_STREAMFLAGS_EVENTCALLBACK = 0x00040000;

    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_NOPERSIST 0x00080000")]
    public const int AUDCLNT_STREAMFLAGS_NOPERSIST = 0x00080000;

    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_RATEADJUST 0x00100000")]
    public const int AUDCLNT_STREAMFLAGS_RATEADJUST = 0x00100000;

    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_SRC_DEFAULT_QUALITY 0x08000000")]
    public const int AUDCLNT_STREAMFLAGS_SRC_DEFAULT_QUALITY = 0x08000000;

    [NativeTypeName("#define AUDCLNT_STREAMFLAGS_AUTOCONVERTPCM 0x80000000")]
    public const uint AUDCLNT_STREAMFLAGS_AUTOCONVERTPCM = 0x80000000;

    [NativeTypeName("#define AUDCLNT_SESSIONFLAGS_EXPIREWHENUNOWNED 0x10000000")]
    public const int AUDCLNT_SESSIONFLAGS_EXPIREWHENUNOWNED = 0x10000000;

    [NativeTypeName("#define AUDCLNT_SESSIONFLAGS_DISPLAY_HIDE 0x20000000")]
    public const int AUDCLNT_SESSIONFLAGS_DISPLAY_HIDE = 0x20000000;

    [NativeTypeName("#define AUDCLNT_SESSIONFLAGS_DISPLAY_HIDEWHENEXPIRED 0x40000000")]
    public const int AUDCLNT_SESSIONFLAGS_DISPLAY_HIDEWHENEXPIRED = 0x40000000;
}
