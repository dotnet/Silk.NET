// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SMC
{
    [NativeTypeName("#define SMC_INITMENU 0x00000001")]
    public const int SMC_INITMENU = 0x00000001;
    [NativeTypeName("#define SMC_CREATE 0x00000002")]
    public const int SMC_CREATE = 0x00000002;
    [NativeTypeName("#define SMC_EXITMENU 0x00000003")]
    public const int SMC_EXITMENU = 0x00000003;
    [NativeTypeName("#define SMC_GETINFO 0x00000005")]
    public const int SMC_GETINFO = 0x00000005;
    [NativeTypeName("#define SMC_GETSFINFO 0x00000006")]
    public const int SMC_GETSFINFO = 0x00000006;
    [NativeTypeName("#define SMC_GETOBJECT 0x00000007")]
    public const int SMC_GETOBJECT = 0x00000007;
    [NativeTypeName("#define SMC_GETSFOBJECT 0x00000008")]
    public const int SMC_GETSFOBJECT = 0x00000008;
    [NativeTypeName("#define SMC_SFEXEC 0x00000009")]
    public const int SMC_SFEXEC = 0x00000009;
    [NativeTypeName("#define SMC_SFSELECTITEM 0x0000000A")]
    public const int SMC_SFSELECTITEM = 0x0000000A;
    [NativeTypeName("#define SMC_REFRESH 0x00000010")]
    public const int SMC_REFRESH = 0x00000010;
    [NativeTypeName("#define SMC_DEMOTE 0x00000011")]
    public const int SMC_DEMOTE = 0x00000011;
    [NativeTypeName("#define SMC_PROMOTE 0x00000012")]
    public const int SMC_PROMOTE = 0x00000012;
    [NativeTypeName("#define SMC_DEFAULTICON 0x00000016")]
    public const int SMC_DEFAULTICON = 0x00000016;
    [NativeTypeName("#define SMC_NEWITEM 0x00000017")]
    public const int SMC_NEWITEM = 0x00000017;
    [NativeTypeName("#define SMC_CHEVRONEXPAND 0x00000019")]
    public const int SMC_CHEVRONEXPAND = 0x00000019;
    [NativeTypeName("#define SMC_DISPLAYCHEVRONTIP 0x0000002A")]
    public const int SMC_DISPLAYCHEVRONTIP = 0x0000002A;
    [NativeTypeName("#define SMC_SETSFOBJECT 0x0000002D")]
    public const int SMC_SETSFOBJECT = 0x0000002D;
    [NativeTypeName("#define SMC_SHCHANGENOTIFY 0x0000002E")]
    public const int SMC_SHCHANGENOTIFY = 0x0000002E;
    [NativeTypeName("#define SMC_CHEVRONGETTIP 0x0000002F")]
    public const int SMC_CHEVRONGETTIP = 0x0000002F;
    [NativeTypeName("#define SMC_SFDDRESTRICTED 0x00000030")]
    public const int SMC_SFDDRESTRICTED = 0x00000030;
    [NativeTypeName("#define SMC_SFEXEC_MIDDLE 0x00000031")]
    public const int SMC_SFEXEC_MIDDLE = 0x00000031;
    [NativeTypeName("#define SMC_GETAUTOEXPANDSTATE 0x00000041")]
    public const int SMC_GETAUTOEXPANDSTATE = 0x00000041;
    [NativeTypeName("#define SMC_AUTOEXPANDCHANGE 0x00000042")]
    public const int SMC_AUTOEXPANDCHANGE = 0x00000042;
    [NativeTypeName("#define SMC_GETCONTEXTMENUMODIFIER 0x00000043")]
    public const int SMC_GETCONTEXTMENUMODIFIER = 0x00000043;
    [NativeTypeName("#define SMC_GETBKCONTEXTMENU 0x00000044")]
    public const int SMC_GETBKCONTEXTMENU = 0x00000044;
    [NativeTypeName("#define SMC_OPEN 0x00000045")]
    public const int SMC_OPEN = 0x00000045;
}