// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ScrnSave.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define IDS_DESCRIPTION 1")]
    public const int IDS_DESCRIPTION = 1;

    [NativeTypeName("#define DLG_SCRNSAVECONFIGURE 2003")]
    public const int DLG_SCRNSAVECONFIGURE = 2003;

    [NativeTypeName("#define idsIsPassword 1000")]
    public const int idsIsPassword = 1000;

    [NativeTypeName("#define idsIniFile 1001")]
    public const int idsIniFile = 1001;

    [NativeTypeName("#define idsScreenSaver 1002")]
    public const int idsScreenSaver = 1002;

    [NativeTypeName("#define idsPassword 1003")]
    public const int idsPassword = 1003;

    [NativeTypeName("#define idsDifferentPW 1004")]
    public const int idsDifferentPW = 1004;

    [NativeTypeName("#define idsChangePW 1005")]
    public const int idsChangePW = 1005;

    [NativeTypeName("#define idsBadOldPW 1006")]
    public const int idsBadOldPW = 1006;

    [NativeTypeName("#define idsAppName 1007")]
    public const int idsAppName = 1007;

    [NativeTypeName("#define idsNoHelpMemory 1008")]
    public const int idsNoHelpMemory = 1008;

    [NativeTypeName("#define idsHelpFile 1009")]
    public const int idsHelpFile = 1009;

    [NativeTypeName("#define idsDefKeyword 1010")]
    public const int idsDefKeyword = 1010;

    [NativeTypeName("#define MAXFILELEN 13")]
    public const int MAXFILELEN = 13;

    [NativeTypeName("#define TITLEBARNAMELEN 40")]
    public const int TITLEBARNAMELEN = 40;

    [NativeTypeName("#define APPNAMEBUFFERLEN 40")]
    public const int APPNAMEBUFFERLEN = 40;

    [NativeTypeName("#define BUFFLEN 255")]
    public const int BUFFLEN = 255;

    [NativeTypeName("#define SCRM_VERIFYPW WM_APP")]
    public const int SCRM_VERIFYPW = 0x8000;
}
