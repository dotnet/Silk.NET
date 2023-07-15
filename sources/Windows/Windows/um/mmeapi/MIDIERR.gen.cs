// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MIDIERR
{
    [NativeTypeName("#define MIDIERR_UNPREPARED (MIDIERR_BASE + 0)")]
    public const int MIDIERR_UNPREPARED = (64 + 0);
    [NativeTypeName("#define MIDIERR_STILLPLAYING (MIDIERR_BASE + 1)")]
    public const int MIDIERR_STILLPLAYING = (64 + 1);
    [NativeTypeName("#define MIDIERR_NOMAP (MIDIERR_BASE + 2)")]
    public const int MIDIERR_NOMAP = (64 + 2);
    [NativeTypeName("#define MIDIERR_NOTREADY (MIDIERR_BASE + 3)")]
    public const int MIDIERR_NOTREADY = (64 + 3);
    [NativeTypeName("#define MIDIERR_NODEVICE (MIDIERR_BASE + 4)")]
    public const int MIDIERR_NODEVICE = (64 + 4);
    [NativeTypeName("#define MIDIERR_INVALIDSETUP (MIDIERR_BASE + 5)")]
    public const int MIDIERR_INVALIDSETUP = (64 + 5);
    [NativeTypeName("#define MIDIERR_BADOPENMODE (MIDIERR_BASE + 6)")]
    public const int MIDIERR_BADOPENMODE = (64 + 6);
    [NativeTypeName("#define MIDIERR_DONT_CONTINUE (MIDIERR_BASE + 7)")]
    public const int MIDIERR_DONT_CONTINUE = (64 + 7);
    [NativeTypeName("#define MIDIERR_LASTERROR (MIDIERR_BASE + 7)")]
    public const int MIDIERR_LASTERROR = (64 + 7);
}