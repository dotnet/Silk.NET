// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SHGVSPB
{
    [NativeTypeName("#define SHGVSPB_PERUSER 0x00000001")]
    public const int SHGVSPB_PERUSER = 0x00000001;

    [NativeTypeName("#define SHGVSPB_ALLUSERS 0x00000002")]
    public const int SHGVSPB_ALLUSERS = 0x00000002;

    [NativeTypeName("#define SHGVSPB_PERFOLDER 0x00000004")]
    public const int SHGVSPB_PERFOLDER = 0x00000004;

    [NativeTypeName("#define SHGVSPB_ALLFOLDERS 0x00000008")]
    public const int SHGVSPB_ALLFOLDERS = 0x00000008;

    [NativeTypeName("#define SHGVSPB_INHERIT 0x00000010")]
    public const int SHGVSPB_INHERIT = 0x00000010;

    [NativeTypeName("#define SHGVSPB_ROAM 0x00000020")]
    public const int SHGVSPB_ROAM = 0x00000020;

    [NativeTypeName("#define SHGVSPB_NOAUTODEFAULTS 0x80000000")]
    public const uint SHGVSPB_NOAUTODEFAULTS = 0x80000000;

    [NativeTypeName("#define SHGVSPB_FOLDER (SHGVSPB_PERUSER | SHGVSPB_PERFOLDER)")]
    public const int SHGVSPB_FOLDER = (0x00000001 | 0x00000004);

    [NativeTypeName("#define SHGVSPB_FOLDERNODEFAULTS (SHGVSPB_PERUSER | SHGVSPB_PERFOLDER | SHGVSPB_NOAUTODEFAULTS)")]
    public const uint SHGVSPB_FOLDERNODEFAULTS = (0x00000001 | 0x00000004 | 0x80000000);

    [NativeTypeName("#define SHGVSPB_USERDEFAULTS (SHGVSPB_PERUSER | SHGVSPB_ALLFOLDERS)")]
    public const int SHGVSPB_USERDEFAULTS = (0x00000001 | 0x00000008);

    [NativeTypeName("#define SHGVSPB_GLOBALDEFAULTS (SHGVSPB_ALLUSERS | SHGVSPB_ALLFOLDERS)")]
    public const int SHGVSPB_GLOBALDEFAULTS = (0x00000002 | 0x00000008);
}
