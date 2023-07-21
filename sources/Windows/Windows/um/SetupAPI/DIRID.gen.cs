// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DIRID
{
    [NativeTypeName("#define DIRID_ABSOLUTE -1")]
    public const int DIRID_ABSOLUTE = -1;

    [NativeTypeName("#define DIRID_ABSOLUTE_16BIT 0xffff")]
    public const int DIRID_ABSOLUTE_16BIT = 0xffff;

    [NativeTypeName("#define DIRID_NULL 0")]
    public const int DIRID_NULL = 0;

    [NativeTypeName("#define DIRID_SRCPATH 1")]
    public const int DIRID_SRCPATH = 1;

    [NativeTypeName("#define DIRID_WINDOWS 10")]
    public const int DIRID_WINDOWS = 10;

    [NativeTypeName("#define DIRID_SYSTEM 11")]
    public const int DIRID_SYSTEM = 11;

    [NativeTypeName("#define DIRID_DRIVERS 12")]
    public const int DIRID_DRIVERS = 12;

    [NativeTypeName("#define DIRID_IOSUBSYS DIRID_DRIVERS")]
    public const int DIRID_IOSUBSYS = 12;

    [NativeTypeName("#define DIRID_DRIVER_STORE 13")]
    public const int DIRID_DRIVER_STORE = 13;

    [NativeTypeName("#define DIRID_INF 17")]
    public const int DIRID_INF = 17;

    [NativeTypeName("#define DIRID_HELP 18")]
    public const int DIRID_HELP = 18;

    [NativeTypeName("#define DIRID_FONTS 20")]
    public const int DIRID_FONTS = 20;

    [NativeTypeName("#define DIRID_VIEWERS 21")]
    public const int DIRID_VIEWERS = 21;

    [NativeTypeName("#define DIRID_COLOR 23")]
    public const int DIRID_COLOR = 23;

    [NativeTypeName("#define DIRID_APPS 24")]
    public const int DIRID_APPS = 24;

    [NativeTypeName("#define DIRID_SHARED 25")]
    public const int DIRID_SHARED = 25;

    [NativeTypeName("#define DIRID_BOOT 30")]
    public const int DIRID_BOOT = 30;

    [NativeTypeName("#define DIRID_SYSTEM16 50")]
    public const int DIRID_SYSTEM16 = 50;

    [NativeTypeName("#define DIRID_SPOOL 51")]
    public const int DIRID_SPOOL = 51;

    [NativeTypeName("#define DIRID_SPOOLDRIVERS 52")]
    public const int DIRID_SPOOLDRIVERS = 52;

    [NativeTypeName("#define DIRID_USERPROFILE 53")]
    public const int DIRID_USERPROFILE = 53;

    [NativeTypeName("#define DIRID_LOADER 54")]
    public const int DIRID_LOADER = 54;

    [NativeTypeName("#define DIRID_PRINTPROCESSOR 55")]
    public const int DIRID_PRINTPROCESSOR = 55;

    [NativeTypeName("#define DIRID_DEFAULT DIRID_SYSTEM")]
    public const int DIRID_DEFAULT = 11;

    [NativeTypeName("#define DIRID_COMMON_STARTMENU 16406")]
    public const int DIRID_COMMON_STARTMENU = 16406;

    [NativeTypeName("#define DIRID_COMMON_PROGRAMS 16407")]
    public const int DIRID_COMMON_PROGRAMS = 16407;

    [NativeTypeName("#define DIRID_COMMON_STARTUP 16408")]
    public const int DIRID_COMMON_STARTUP = 16408;

    [NativeTypeName("#define DIRID_COMMON_DESKTOPDIRECTORY 16409")]
    public const int DIRID_COMMON_DESKTOPDIRECTORY = 16409;

    [NativeTypeName("#define DIRID_COMMON_FAVORITES 16415")]
    public const int DIRID_COMMON_FAVORITES = 16415;

    [NativeTypeName("#define DIRID_COMMON_APPDATA 16419")]
    public const int DIRID_COMMON_APPDATA = 16419;

    [NativeTypeName("#define DIRID_PROGRAM_FILES 16422")]
    public const int DIRID_PROGRAM_FILES = 16422;

    [NativeTypeName("#define DIRID_SYSTEM_X86 16425")]
    public const int DIRID_SYSTEM_X86 = 16425;

    [NativeTypeName("#define DIRID_PROGRAM_FILES_X86 16426")]
    public const int DIRID_PROGRAM_FILES_X86 = 16426;

    [NativeTypeName("#define DIRID_PROGRAM_FILES_COMMON 16427")]
    public const int DIRID_PROGRAM_FILES_COMMON = 16427;

    [NativeTypeName("#define DIRID_PROGRAM_FILES_COMMONX86 16428")]
    public const int DIRID_PROGRAM_FILES_COMMONX86 = 16428;

    [NativeTypeName("#define DIRID_COMMON_TEMPLATES 16429")]
    public const int DIRID_COMMON_TEMPLATES = 16429;

    [NativeTypeName("#define DIRID_COMMON_DOCUMENTS 16430")]
    public const int DIRID_COMMON_DOCUMENTS = 16430;

    [NativeTypeName("#define DIRID_USER 0x8000")]
    public const int DIRID_USER = 0x8000;
}
