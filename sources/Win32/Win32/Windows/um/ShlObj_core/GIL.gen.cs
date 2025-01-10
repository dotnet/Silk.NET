// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GIL
{
    [NativeTypeName("#define GIL_OPENICON 0x0001")]
    public const int GIL_OPENICON = 0x0001;

    [NativeTypeName("#define GIL_FORSHELL 0x0002")]
    public const int GIL_FORSHELL = 0x0002;

    [NativeTypeName("#define GIL_ASYNC 0x0020")]
    public const int GIL_ASYNC = 0x0020;

    [NativeTypeName("#define GIL_DEFAULTICON 0x0040")]
    public const int GIL_DEFAULTICON = 0x0040;

    [NativeTypeName("#define GIL_FORSHORTCUT 0x0080")]
    public const int GIL_FORSHORTCUT = 0x0080;

    [NativeTypeName("#define GIL_CHECKSHIELD 0x0200")]
    public const int GIL_CHECKSHIELD = 0x0200;

    [NativeTypeName("#define GIL_SIMULATEDOC 0x0001")]
    public const int GIL_SIMULATEDOC = 0x0001;

    [NativeTypeName("#define GIL_PERINSTANCE 0x0002")]
    public const int GIL_PERINSTANCE = 0x0002;

    [NativeTypeName("#define GIL_PERCLASS 0x0004")]
    public const int GIL_PERCLASS = 0x0004;

    [NativeTypeName("#define GIL_NOTFILENAME 0x0008")]
    public const int GIL_NOTFILENAME = 0x0008;

    [NativeTypeName("#define GIL_DONTCACHE 0x0010")]
    public const int GIL_DONTCACHE = 0x0010;

    [NativeTypeName("#define GIL_SHIELD 0x0200")]
    public const int GIL_SHIELD = 0x0200;

    [NativeTypeName("#define GIL_FORCENOSHIELD 0x0400")]
    public const int GIL_FORCENOSHIELD = 0x0400;
}
