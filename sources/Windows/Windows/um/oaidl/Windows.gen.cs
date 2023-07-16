// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define PARAMFLAG_NONE ( 0 )")]
    public const int PARAMFLAG_NONE = (0);
    [NativeTypeName("#define PARAMFLAG_FIN ( 0x1 )")]
    public const int PARAMFLAG_FIN = (0x1);
    [NativeTypeName("#define PARAMFLAG_FOUT ( 0x2 )")]
    public const int PARAMFLAG_FOUT = (0x2);
    [NativeTypeName("#define PARAMFLAG_FLCID ( 0x4 )")]
    public const int PARAMFLAG_FLCID = (0x4);
    [NativeTypeName("#define PARAMFLAG_FRETVAL ( 0x8 )")]
    public const int PARAMFLAG_FRETVAL = (0x8);
    [NativeTypeName("#define PARAMFLAG_FOPT ( 0x10 )")]
    public const int PARAMFLAG_FOPT = (0x10);
    [NativeTypeName("#define PARAMFLAG_FHASDEFAULT ( 0x20 )")]
    public const int PARAMFLAG_FHASDEFAULT = (0x20);
    [NativeTypeName("#define PARAMFLAG_FHASCUSTDATA ( 0x40 )")]
    public const int PARAMFLAG_FHASCUSTDATA = (0x40);
    [NativeTypeName("#define IDLFLAG_NONE ( PARAMFLAG_NONE )")]
    public const int IDLFLAG_NONE = ((0));
    [NativeTypeName("#define IDLFLAG_FIN ( PARAMFLAG_FIN )")]
    public const int IDLFLAG_FIN = ((0x1));
    [NativeTypeName("#define IDLFLAG_FOUT ( PARAMFLAG_FOUT )")]
    public const int IDLFLAG_FOUT = ((0x2));
    [NativeTypeName("#define IDLFLAG_FLCID ( PARAMFLAG_FLCID )")]
    public const int IDLFLAG_FLCID = ((0x4));
    [NativeTypeName("#define IDLFLAG_FRETVAL ( PARAMFLAG_FRETVAL )")]
    public const int IDLFLAG_FRETVAL = ((0x8));
    [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULT ( 0x1 )")]
    public const int IMPLTYPEFLAG_FDEFAULT = (0x1);
    [NativeTypeName("#define IMPLTYPEFLAG_FSOURCE ( 0x2 )")]
    public const int IMPLTYPEFLAG_FSOURCE = (0x2);
    [NativeTypeName("#define IMPLTYPEFLAG_FRESTRICTED ( 0x4 )")]
    public const int IMPLTYPEFLAG_FRESTRICTED = (0x4);
    [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULTVTABLE ( 0x8 )")]
    public const int IMPLTYPEFLAG_FDEFAULTVTABLE = (0x8);
}