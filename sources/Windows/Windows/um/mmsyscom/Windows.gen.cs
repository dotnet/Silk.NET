// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define MAXPNAMELEN 32")]
    public const int MAXPNAMELEN = 32;
    [NativeTypeName("#define MAXERRORLENGTH 256")]
    public const int MAXERRORLENGTH = 256;
    [NativeTypeName("#define WAVERR_BASE 32")]
    public const int WAVERR_BASE = 32;
    [NativeTypeName("#define TIMERR_BASE 96")]
    public const int TIMERR_BASE = 96;
    [NativeTypeName("#define JOYERR_BASE 160")]
    public const int JOYERR_BASE = 160;
    [NativeTypeName("#define MCIERR_BASE 256")]
    public const int MCIERR_BASE = 256;
    [NativeTypeName("#define MIXERR_BASE 1024")]
    public const int MIXERR_BASE = 1024;
    [NativeTypeName("#define MCI_STRING_OFFSET 512")]
    public const int MCI_STRING_OFFSET = 512;
    [NativeTypeName("#define MCI_VD_OFFSET 1024")]
    public const int MCI_VD_OFFSET = 1024;
    [NativeTypeName("#define MCI_CD_OFFSET 1088")]
    public const int MCI_CD_OFFSET = 1088;
    [NativeTypeName("#define MCI_WAVE_OFFSET 1152")]
    public const int MCI_WAVE_OFFSET = 1152;
    [NativeTypeName("#define MCI_SEQ_OFFSET 1216")]
    public const int MCI_SEQ_OFFSET = 1216;
    [NativeTypeName("#define CALLBACK_TYPEMASK 0x00070000l")]
    public const int CALLBACK_TYPEMASK = 0x00070000;
    [NativeTypeName("#define CALLBACK_NULL 0x00000000l")]
    public const int CALLBACK_NULL = 0x00000000;
    [NativeTypeName("#define CALLBACK_WINDOW 0x00010000l")]
    public const int CALLBACK_WINDOW = 0x00010000;
    [NativeTypeName("#define CALLBACK_TASK 0x00020000l")]
    public const int CALLBACK_TASK = 0x00020000;
    [NativeTypeName("#define CALLBACK_FUNCTION 0x00030000l")]
    public const int CALLBACK_FUNCTION = 0x00030000;
    [NativeTypeName("#define CALLBACK_THREAD (CALLBACK_TASK)")]
    public const int CALLBACK_THREAD = (0x00020000);
    [NativeTypeName("#define CALLBACK_EVENT 0x00050000l")]
    public const int CALLBACK_EVENT = 0x00050000;
}