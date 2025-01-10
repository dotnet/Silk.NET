// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FLG
{
    [NativeTypeName("#define FLG_ADDREG_DELREG_BIT ( 0x00008000 )")]
    public const int FLG_ADDREG_DELREG_BIT = (0x00008000);

    [NativeTypeName("#define FLG_ADDREG_BINVALUETYPE ( 0x00000001 )")]
    public const int FLG_ADDREG_BINVALUETYPE = (0x00000001);

    [NativeTypeName("#define FLG_ADDREG_NOCLOBBER ( 0x00000002 )")]
    public const int FLG_ADDREG_NOCLOBBER = (0x00000002);

    [NativeTypeName("#define FLG_ADDREG_DELVAL ( 0x00000004 )")]
    public const int FLG_ADDREG_DELVAL = (0x00000004);

    [NativeTypeName("#define FLG_ADDREG_APPEND ( 0x00000008 )")]
    public const int FLG_ADDREG_APPEND = (0x00000008);

    [NativeTypeName("#define FLG_ADDREG_KEYONLY ( 0x00000010 )")]
    public const int FLG_ADDREG_KEYONLY = (0x00000010);

    [NativeTypeName("#define FLG_ADDREG_OVERWRITEONLY ( 0x00000020 )")]
    public const int FLG_ADDREG_OVERWRITEONLY = (0x00000020);

    [NativeTypeName("#define FLG_ADDREG_64BITKEY ( 0x00001000 )")]
    public const int FLG_ADDREG_64BITKEY = (0x00001000);

    [NativeTypeName("#define FLG_ADDREG_KEYONLY_COMMON ( 0x00002000 )")]
    public const int FLG_ADDREG_KEYONLY_COMMON = (0x00002000);

    [NativeTypeName("#define FLG_ADDREG_32BITKEY ( 0x00004000 )")]
    public const int FLG_ADDREG_32BITKEY = (0x00004000);

    [NativeTypeName("#define FLG_ADDREG_TYPE_MASK ( 0xFFFF0000 | FLG_ADDREG_BINVALUETYPE )")]
    public const uint FLG_ADDREG_TYPE_MASK = (0xFFFF0000 | (0x00000001));

    [NativeTypeName("#define FLG_ADDREG_TYPE_SZ ( 0x00000000                           )")]
    public const int FLG_ADDREG_TYPE_SZ = (0x00000000);

    [NativeTypeName("#define FLG_ADDREG_TYPE_MULTI_SZ ( 0x00010000                           )")]
    public const int FLG_ADDREG_TYPE_MULTI_SZ = (0x00010000);

    [NativeTypeName("#define FLG_ADDREG_TYPE_EXPAND_SZ ( 0x00020000                           )")]
    public const int FLG_ADDREG_TYPE_EXPAND_SZ = (0x00020000);

    [NativeTypeName("#define FLG_ADDREG_TYPE_BINARY ( 0x00000000 | FLG_ADDREG_BINVALUETYPE )")]
    public const int FLG_ADDREG_TYPE_BINARY = (0x00000000 | (0x00000001));

    [NativeTypeName("#define FLG_ADDREG_TYPE_DWORD ( 0x00010000 | FLG_ADDREG_BINVALUETYPE )")]
    public const int FLG_ADDREG_TYPE_DWORD = (0x00010000 | (0x00000001));

    [NativeTypeName("#define FLG_ADDREG_TYPE_NONE ( 0x00020000 | FLG_ADDREG_BINVALUETYPE )")]
    public const int FLG_ADDREG_TYPE_NONE = (0x00020000 | (0x00000001));

    [NativeTypeName("#define FLG_ADDREG_TYPE_QWORD ( 0x000B0000 | FLG_ADDREG_BINVALUETYPE )")]
    public const int FLG_ADDREG_TYPE_QWORD = (0x000B0000 | (0x00000001));

    [NativeTypeName("#define FLG_DELREG_VALUE (0x00000000)")]
    public const int FLG_DELREG_VALUE = (0x00000000);

    [NativeTypeName("#define FLG_DELREG_TYPE_MASK FLG_ADDREG_TYPE_MASK")]
    public const uint FLG_DELREG_TYPE_MASK = (0xFFFF0000 | (0x00000001));

    [NativeTypeName("#define FLG_DELREG_TYPE_SZ FLG_ADDREG_TYPE_SZ")]
    public const int FLG_DELREG_TYPE_SZ = (0x00000000);

    [NativeTypeName("#define FLG_DELREG_TYPE_MULTI_SZ FLG_ADDREG_TYPE_MULTI_SZ")]
    public const int FLG_DELREG_TYPE_MULTI_SZ = (0x00010000);

    [NativeTypeName("#define FLG_DELREG_TYPE_EXPAND_SZ FLG_ADDREG_TYPE_EXPAND_SZ")]
    public const int FLG_DELREG_TYPE_EXPAND_SZ = (0x00020000);

    [NativeTypeName("#define FLG_DELREG_TYPE_BINARY FLG_ADDREG_TYPE_BINARY")]
    public const int FLG_DELREG_TYPE_BINARY = (0x00000000 | (0x00000001));

    [NativeTypeName("#define FLG_DELREG_TYPE_DWORD FLG_ADDREG_TYPE_DWORD")]
    public const int FLG_DELREG_TYPE_DWORD = (0x00010000 | (0x00000001));

    [NativeTypeName("#define FLG_DELREG_TYPE_NONE FLG_ADDREG_TYPE_NONE")]
    public const int FLG_DELREG_TYPE_NONE = (0x00020000 | (0x00000001));

    [NativeTypeName("#define FLG_DELREG_64BITKEY FLG_ADDREG_64BITKEY")]
    public const int FLG_DELREG_64BITKEY = (0x00001000);

    [NativeTypeName("#define FLG_DELREG_KEYONLY_COMMON FLG_ADDREG_KEYONLY_COMMON")]
    public const int FLG_DELREG_KEYONLY_COMMON = (0x00002000);

    [NativeTypeName("#define FLG_DELREG_32BITKEY FLG_ADDREG_32BITKEY")]
    public const int FLG_DELREG_32BITKEY = (0x00004000);

    [NativeTypeName("#define FLG_DELREG_OPERATION_MASK (0x000000FE)")]
    public const int FLG_DELREG_OPERATION_MASK = (0x000000FE);

    [NativeTypeName(
        "#define FLG_DELREG_MULTI_SZ_DELSTRING ( FLG_DELREG_TYPE_MULTI_SZ | FLG_ADDREG_DELREG_BIT | 0x00000002 )"
    )]
    public const int FLG_DELREG_MULTI_SZ_DELSTRING = ((0x00010000) | (0x00008000) | 0x00000002);

    [NativeTypeName("#define FLG_DELREG_TYPE_QWORD FLG_ADDREG_TYPE_QWORD")]
    public const int FLG_DELREG_TYPE_QWORD = (0x000B0000 | (0x00000001));

    [NativeTypeName("#define FLG_BITREG_CLEARBITS ( 0x00000000 )")]
    public const int FLG_BITREG_CLEARBITS = (0x00000000);

    [NativeTypeName("#define FLG_BITREG_SETBITS ( 0x00000001 )")]
    public const int FLG_BITREG_SETBITS = (0x00000001);

    [NativeTypeName("#define FLG_BITREG_64BITKEY ( 0x00001000 )")]
    public const int FLG_BITREG_64BITKEY = (0x00001000);

    [NativeTypeName("#define FLG_BITREG_32BITKEY ( 0x00004000 )")]
    public const int FLG_BITREG_32BITKEY = (0x00004000);

    [NativeTypeName("#define FLG_INI2REG_64BITKEY ( 0x00001000 )")]
    public const int FLG_INI2REG_64BITKEY = (0x00001000);

    [NativeTypeName("#define FLG_INI2REG_32BITKEY ( 0x00004000 )")]
    public const int FLG_INI2REG_32BITKEY = (0x00004000);

    [NativeTypeName("#define FLG_REGSVR_DLLREGISTER ( 0x00000001 )")]
    public const int FLG_REGSVR_DLLREGISTER = (0x00000001);

    [NativeTypeName("#define FLG_REGSVR_DLLINSTALL ( 0x00000002 )")]
    public const int FLG_REGSVR_DLLINSTALL = (0x00000002);

    [NativeTypeName("#define FLG_PROFITEM_CURRENTUSER ( 0x00000001 )")]
    public const int FLG_PROFITEM_CURRENTUSER = (0x00000001);

    [NativeTypeName("#define FLG_PROFITEM_DELETE ( 0x00000002 )")]
    public const int FLG_PROFITEM_DELETE = (0x00000002);

    [NativeTypeName("#define FLG_PROFITEM_GROUP ( 0x00000004 )")]
    public const int FLG_PROFITEM_GROUP = (0x00000004);

    [NativeTypeName("#define FLG_PROFITEM_CSIDL ( 0x00000008 )")]
    public const int FLG_PROFITEM_CSIDL = (0x00000008);

    [NativeTypeName("#define FLG_ADDPROPERTY_NOCLOBBER ( 0x00000001 )")]
    public const int FLG_ADDPROPERTY_NOCLOBBER = (0x00000001);

    [NativeTypeName("#define FLG_ADDPROPERTY_OVERWRITEONLY ( 0x00000002 )")]
    public const int FLG_ADDPROPERTY_OVERWRITEONLY = (0x00000002);

    [NativeTypeName("#define FLG_ADDPROPERTY_APPEND ( 0x00000004 )")]
    public const int FLG_ADDPROPERTY_APPEND = (0x00000004);

    [NativeTypeName("#define FLG_ADDPROPERTY_OR ( 0x00000008 )")]
    public const int FLG_ADDPROPERTY_OR = (0x00000008);

    [NativeTypeName("#define FLG_ADDPROPERTY_AND ( 0x00000010 )")]
    public const int FLG_ADDPROPERTY_AND = (0x00000010);

    [NativeTypeName("#define FLG_DELPROPERTY_MULTI_SZ_DELSTRING ( 0x00000001 )")]
    public const int FLG_DELPROPERTY_MULTI_SZ_DELSTRING = (0x00000001);
}
