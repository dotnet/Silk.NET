// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class CF
{
    [NativeTypeName("#define CF_SCREENFONTS 0x00000001")]
    public const int CF_SCREENFONTS = 0x00000001;

    [NativeTypeName("#define CF_PRINTERFONTS 0x00000002")]
    public const int CF_PRINTERFONTS = 0x00000002;

    [NativeTypeName("#define CF_BOTH (CF_SCREENFONTS | CF_PRINTERFONTS)")]
    public const int CF_BOTH = (0x00000001 | 0x00000002);

    [NativeTypeName("#define CF_SHOWHELP 0x00000004L")]
    public const int CF_SHOWHELP = 0x00000004;

    [NativeTypeName("#define CF_ENABLEHOOK 0x00000008L")]
    public const int CF_ENABLEHOOK = 0x00000008;

    [NativeTypeName("#define CF_ENABLETEMPLATE 0x00000010L")]
    public const int CF_ENABLETEMPLATE = 0x00000010;

    [NativeTypeName("#define CF_ENABLETEMPLATEHANDLE 0x00000020L")]
    public const int CF_ENABLETEMPLATEHANDLE = 0x00000020;

    [NativeTypeName("#define CF_INITTOLOGFONTSTRUCT 0x00000040L")]
    public const int CF_INITTOLOGFONTSTRUCT = 0x00000040;

    [NativeTypeName("#define CF_USESTYLE 0x00000080L")]
    public const int CF_USESTYLE = 0x00000080;

    [NativeTypeName("#define CF_EFFECTS 0x00000100L")]
    public const int CF_EFFECTS = 0x00000100;

    [NativeTypeName("#define CF_APPLY 0x00000200L")]
    public const int CF_APPLY = 0x00000200;

    [NativeTypeName("#define CF_ANSIONLY 0x00000400L")]
    public const int CF_ANSIONLY = 0x00000400;

    [NativeTypeName("#define CF_SCRIPTSONLY CF_ANSIONLY")]
    public const int CF_SCRIPTSONLY = 0x00000400;

    [NativeTypeName("#define CF_NOVECTORFONTS 0x00000800L")]
    public const int CF_NOVECTORFONTS = 0x00000800;

    [NativeTypeName("#define CF_NOOEMFONTS CF_NOVECTORFONTS")]
    public const int CF_NOOEMFONTS = 0x00000800;

    [NativeTypeName("#define CF_NOSIMULATIONS 0x00001000L")]
    public const int CF_NOSIMULATIONS = 0x00001000;

    [NativeTypeName("#define CF_LIMITSIZE 0x00002000L")]
    public const int CF_LIMITSIZE = 0x00002000;

    [NativeTypeName("#define CF_FIXEDPITCHONLY 0x00004000L")]
    public const int CF_FIXEDPITCHONLY = 0x00004000;

    [NativeTypeName("#define CF_WYSIWYG 0x00008000L")]
    public const int CF_WYSIWYG = 0x00008000;

    [NativeTypeName("#define CF_FORCEFONTEXIST 0x00010000L")]
    public const int CF_FORCEFONTEXIST = 0x00010000;

    [NativeTypeName("#define CF_SCALABLEONLY 0x00020000L")]
    public const int CF_SCALABLEONLY = 0x00020000;

    [NativeTypeName("#define CF_TTONLY 0x00040000L")]
    public const int CF_TTONLY = 0x00040000;

    [NativeTypeName("#define CF_NOFACESEL 0x00080000L")]
    public const int CF_NOFACESEL = 0x00080000;

    [NativeTypeName("#define CF_NOSTYLESEL 0x00100000L")]
    public const int CF_NOSTYLESEL = 0x00100000;

    [NativeTypeName("#define CF_NOSIZESEL 0x00200000L")]
    public const int CF_NOSIZESEL = 0x00200000;

    [NativeTypeName("#define CF_SELECTSCRIPT 0x00400000L")]
    public const int CF_SELECTSCRIPT = 0x00400000;

    [NativeTypeName("#define CF_NOSCRIPTSEL 0x00800000L")]
    public const int CF_NOSCRIPTSEL = 0x00800000;

    [NativeTypeName("#define CF_NOVERTFONTS 0x01000000L")]
    public const int CF_NOVERTFONTS = 0x01000000;

    [NativeTypeName("#define CF_INACTIVEFONTS 0x02000000L")]
    public const int CF_INACTIVEFONTS = 0x02000000;
}
