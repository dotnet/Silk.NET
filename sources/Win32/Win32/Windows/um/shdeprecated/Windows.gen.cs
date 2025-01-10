// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define TLOG_BACK -1")]
    public const int TLOG_BACK = -1;

    [NativeTypeName("#define TLOG_CURRENT 0")]
    public const int TLOG_CURRENT = 0;

    [NativeTypeName("#define TLOG_FORE 1")]
    public const int TLOG_FORE = 1;

    [NativeTypeName("#define TLMENUF_INCLUDECURRENT 0x00000001")]
    public const int TLMENUF_INCLUDECURRENT = 0x00000001;

    [NativeTypeName("#define TLMENUF_CHECKCURRENT (TLMENUF_INCLUDECURRENT | 0x00000002)")]
    public const int TLMENUF_CHECKCURRENT = (0x00000001 | 0x00000002);

    [NativeTypeName("#define TLMENUF_BACK 0x00000010")]
    public const int TLMENUF_BACK = 0x00000010;

    [NativeTypeName("#define TLMENUF_FORE 0x00000020")]
    public const int TLMENUF_FORE = 0x00000020;

    [NativeTypeName(
        "#define TLMENUF_BACKANDFORTH (TLMENUF_BACK | TLMENUF_FORE | TLMENUF_INCLUDECURRENT)"
    )]
    public const int TLMENUF_BACKANDFORTH = (0x00000010 | 0x00000020 | 0x00000001);

    [NativeTypeName("#define HLNF_CALLERUNTRUSTED 0x00200000")]
    public const int HLNF_CALLERUNTRUSTED = 0x00200000;

    [NativeTypeName("#define HLNF_TRUSTEDFORACTIVEX 0x00400000")]
    public const int HLNF_TRUSTEDFORACTIVEX = 0x00400000;

    [NativeTypeName("#define HLNF_DISABLEWINDOWRESTRICTIONS 0x00800000")]
    public const int HLNF_DISABLEWINDOWRESTRICTIONS = 0x00800000;

    [NativeTypeName("#define HLNF_TRUSTFIRSTDOWNLOAD 0x01000000")]
    public const int HLNF_TRUSTFIRSTDOWNLOAD = 0x01000000;

    [NativeTypeName("#define HLNF_UNTRUSTEDFORDOWNLOAD 0x02000000")]
    public const int HLNF_UNTRUSTEDFORDOWNLOAD = 0x02000000;

    [NativeTypeName("#define SHHLNF_NOAUTOSELECT 0x04000000")]
    public const int SHHLNF_NOAUTOSELECT = 0x04000000;

    [NativeTypeName("#define SHHLNF_WRITENOHISTORY 0x08000000")]
    public const int SHHLNF_WRITENOHISTORY = 0x08000000;

    [NativeTypeName("#define HLNF_EXTERNALNAVIGATE 0x10000000")]
    public const int HLNF_EXTERNALNAVIGATE = 0x10000000;

    [NativeTypeName("#define HLNF_ALLOW_AUTONAVIGATE 0x20000000")]
    public const int HLNF_ALLOW_AUTONAVIGATE = 0x20000000;

    [NativeTypeName("#define HLNF_NEWWINDOWSMANAGED 0x80000000")]
    public const uint HLNF_NEWWINDOWSMANAGED = 0x80000000;

    [NativeTypeName("#define ITB_VIEW ((UINT)-1)")]
    public const uint ITB_VIEW = unchecked((uint)(-1));
}
