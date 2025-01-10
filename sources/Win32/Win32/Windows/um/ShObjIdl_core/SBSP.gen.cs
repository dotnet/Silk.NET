// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SBSP
{
    [NativeTypeName("#define SBSP_DEFBROWSER 0x0000")]
    public const int SBSP_DEFBROWSER = 0x0000;

    [NativeTypeName("#define SBSP_SAMEBROWSER 0x0001")]
    public const int SBSP_SAMEBROWSER = 0x0001;

    [NativeTypeName("#define SBSP_NEWBROWSER 0x0002")]
    public const int SBSP_NEWBROWSER = 0x0002;

    [NativeTypeName("#define SBSP_DEFMODE 0x0000")]
    public const int SBSP_DEFMODE = 0x0000;

    [NativeTypeName("#define SBSP_OPENMODE 0x0010")]
    public const int SBSP_OPENMODE = 0x0010;

    [NativeTypeName("#define SBSP_EXPLOREMODE 0x0020")]
    public const int SBSP_EXPLOREMODE = 0x0020;

    [NativeTypeName("#define SBSP_HELPMODE 0x0040")]
    public const int SBSP_HELPMODE = 0x0040;

    [NativeTypeName("#define SBSP_NOTRANSFERHIST 0x0080")]
    public const int SBSP_NOTRANSFERHIST = 0x0080;

    [NativeTypeName("#define SBSP_ABSOLUTE 0x0000")]
    public const int SBSP_ABSOLUTE = 0x0000;

    [NativeTypeName("#define SBSP_RELATIVE 0x1000")]
    public const int SBSP_RELATIVE = 0x1000;

    [NativeTypeName("#define SBSP_PARENT 0x2000")]
    public const int SBSP_PARENT = 0x2000;

    [NativeTypeName("#define SBSP_NAVIGATEBACK 0x4000")]
    public const int SBSP_NAVIGATEBACK = 0x4000;

    [NativeTypeName("#define SBSP_NAVIGATEFORWARD 0x8000")]
    public const int SBSP_NAVIGATEFORWARD = 0x8000;

    [NativeTypeName("#define SBSP_ALLOW_AUTONAVIGATE 0x00010000")]
    public const int SBSP_ALLOW_AUTONAVIGATE = 0x00010000;

    [NativeTypeName("#define SBSP_KEEPSAMETEMPLATE 0x00020000")]
    public const int SBSP_KEEPSAMETEMPLATE = 0x00020000;

    [NativeTypeName("#define SBSP_KEEPWORDWHEELTEXT 0x00040000")]
    public const int SBSP_KEEPWORDWHEELTEXT = 0x00040000;

    [NativeTypeName("#define SBSP_ACTIVATE_NOFOCUS 0x00080000")]
    public const int SBSP_ACTIVATE_NOFOCUS = 0x00080000;

    [NativeTypeName("#define SBSP_CREATENOHISTORY 0x00100000")]
    public const int SBSP_CREATENOHISTORY = 0x00100000;

    [NativeTypeName("#define SBSP_PLAYNOSOUND 0x00200000")]
    public const int SBSP_PLAYNOSOUND = 0x00200000;

    [NativeTypeName("#define SBSP_CALLERUNTRUSTED 0x00800000")]
    public const int SBSP_CALLERUNTRUSTED = 0x00800000;

    [NativeTypeName("#define SBSP_TRUSTFIRSTDOWNLOAD 0x01000000")]
    public const int SBSP_TRUSTFIRSTDOWNLOAD = 0x01000000;

    [NativeTypeName("#define SBSP_UNTRUSTEDFORDOWNLOAD 0x02000000")]
    public const int SBSP_UNTRUSTEDFORDOWNLOAD = 0x02000000;

    [NativeTypeName("#define SBSP_NOAUTOSELECT 0x04000000")]
    public const int SBSP_NOAUTOSELECT = 0x04000000;

    [NativeTypeName("#define SBSP_WRITENOHISTORY 0x08000000")]
    public const int SBSP_WRITENOHISTORY = 0x08000000;

    [NativeTypeName("#define SBSP_TRUSTEDFORACTIVEX 0x10000000")]
    public const int SBSP_TRUSTEDFORACTIVEX = 0x10000000;

    [NativeTypeName("#define SBSP_FEEDNAVIGATION 0x20000000")]
    public const int SBSP_FEEDNAVIGATION = 0x20000000;

    [NativeTypeName("#define SBSP_REDIRECT 0x40000000")]
    public const int SBSP_REDIRECT = 0x40000000;

    [NativeTypeName("#define SBSP_INITIATEDBYHLINKFRAME 0x80000000")]
    public const uint SBSP_INITIATEDBYHLINKFRAME = 0x80000000;
}
