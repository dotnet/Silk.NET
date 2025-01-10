// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CSIDL
{
    [NativeTypeName("#define CSIDL_DESKTOP 0x0000")]
    public const int CSIDL_DESKTOP = 0x0000;

    [NativeTypeName("#define CSIDL_INTERNET 0x0001")]
    public const int CSIDL_INTERNET = 0x0001;

    [NativeTypeName("#define CSIDL_PROGRAMS 0x0002")]
    public const int CSIDL_PROGRAMS = 0x0002;

    [NativeTypeName("#define CSIDL_CONTROLS 0x0003")]
    public const int CSIDL_CONTROLS = 0x0003;

    [NativeTypeName("#define CSIDL_PRINTERS 0x0004")]
    public const int CSIDL_PRINTERS = 0x0004;

    [NativeTypeName("#define CSIDL_PERSONAL 0x0005")]
    public const int CSIDL_PERSONAL = 0x0005;

    [NativeTypeName("#define CSIDL_FAVORITES 0x0006")]
    public const int CSIDL_FAVORITES = 0x0006;

    [NativeTypeName("#define CSIDL_STARTUP 0x0007")]
    public const int CSIDL_STARTUP = 0x0007;

    [NativeTypeName("#define CSIDL_RECENT 0x0008")]
    public const int CSIDL_RECENT = 0x0008;

    [NativeTypeName("#define CSIDL_SENDTO 0x0009")]
    public const int CSIDL_SENDTO = 0x0009;

    [NativeTypeName("#define CSIDL_BITBUCKET 0x000a")]
    public const int CSIDL_BITBUCKET = 0x000a;

    [NativeTypeName("#define CSIDL_STARTMENU 0x000b")]
    public const int CSIDL_STARTMENU = 0x000b;

    [NativeTypeName("#define CSIDL_MYDOCUMENTS CSIDL_PERSONAL")]
    public const int CSIDL_MYDOCUMENTS = 0x0005;

    [NativeTypeName("#define CSIDL_MYMUSIC 0x000d")]
    public const int CSIDL_MYMUSIC = 0x000d;

    [NativeTypeName("#define CSIDL_MYVIDEO 0x000e")]
    public const int CSIDL_MYVIDEO = 0x000e;

    [NativeTypeName("#define CSIDL_DESKTOPDIRECTORY 0x0010")]
    public const int CSIDL_DESKTOPDIRECTORY = 0x0010;

    [NativeTypeName("#define CSIDL_DRIVES 0x0011")]
    public const int CSIDL_DRIVES = 0x0011;

    [NativeTypeName("#define CSIDL_NETWORK 0x0012")]
    public const int CSIDL_NETWORK = 0x0012;

    [NativeTypeName("#define CSIDL_NETHOOD 0x0013")]
    public const int CSIDL_NETHOOD = 0x0013;

    [NativeTypeName("#define CSIDL_FONTS 0x0014")]
    public const int CSIDL_FONTS = 0x0014;

    [NativeTypeName("#define CSIDL_TEMPLATES 0x0015")]
    public const int CSIDL_TEMPLATES = 0x0015;

    [NativeTypeName("#define CSIDL_COMMON_STARTMENU 0x0016")]
    public const int CSIDL_COMMON_STARTMENU = 0x0016;

    [NativeTypeName("#define CSIDL_COMMON_PROGRAMS 0X0017")]
    public const int CSIDL_COMMON_PROGRAMS = 0X0017;

    [NativeTypeName("#define CSIDL_COMMON_STARTUP 0x0018")]
    public const int CSIDL_COMMON_STARTUP = 0x0018;

    [NativeTypeName("#define CSIDL_COMMON_DESKTOPDIRECTORY 0x0019")]
    public const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x0019;

    [NativeTypeName("#define CSIDL_APPDATA 0x001a")]
    public const int CSIDL_APPDATA = 0x001a;

    [NativeTypeName("#define CSIDL_PRINTHOOD 0x001b")]
    public const int CSIDL_PRINTHOOD = 0x001b;

    [NativeTypeName("#define CSIDL_LOCAL_APPDATA 0x001c")]
    public const int CSIDL_LOCAL_APPDATA = 0x001c;

    [NativeTypeName("#define CSIDL_ALTSTARTUP 0x001d")]
    public const int CSIDL_ALTSTARTUP = 0x001d;

    [NativeTypeName("#define CSIDL_COMMON_ALTSTARTUP 0x001e")]
    public const int CSIDL_COMMON_ALTSTARTUP = 0x001e;

    [NativeTypeName("#define CSIDL_COMMON_FAVORITES 0x001f")]
    public const int CSIDL_COMMON_FAVORITES = 0x001f;

    [NativeTypeName("#define CSIDL_INTERNET_CACHE 0x0020")]
    public const int CSIDL_INTERNET_CACHE = 0x0020;

    [NativeTypeName("#define CSIDL_COOKIES 0x0021")]
    public const int CSIDL_COOKIES = 0x0021;

    [NativeTypeName("#define CSIDL_HISTORY 0x0022")]
    public const int CSIDL_HISTORY = 0x0022;

    [NativeTypeName("#define CSIDL_COMMON_APPDATA 0x0023")]
    public const int CSIDL_COMMON_APPDATA = 0x0023;

    [NativeTypeName("#define CSIDL_WINDOWS 0x0024")]
    public const int CSIDL_WINDOWS = 0x0024;

    [NativeTypeName("#define CSIDL_SYSTEM 0x0025")]
    public const int CSIDL_SYSTEM = 0x0025;

    [NativeTypeName("#define CSIDL_PROGRAM_FILES 0x0026")]
    public const int CSIDL_PROGRAM_FILES = 0x0026;

    [NativeTypeName("#define CSIDL_MYPICTURES 0x0027")]
    public const int CSIDL_MYPICTURES = 0x0027;

    [NativeTypeName("#define CSIDL_PROFILE 0x0028")]
    public const int CSIDL_PROFILE = 0x0028;

    [NativeTypeName("#define CSIDL_SYSTEMX86 0x0029")]
    public const int CSIDL_SYSTEMX86 = 0x0029;

    [NativeTypeName("#define CSIDL_PROGRAM_FILESX86 0x002a")]
    public const int CSIDL_PROGRAM_FILESX86 = 0x002a;

    [NativeTypeName("#define CSIDL_PROGRAM_FILES_COMMON 0x002b")]
    public const int CSIDL_PROGRAM_FILES_COMMON = 0x002b;

    [NativeTypeName("#define CSIDL_PROGRAM_FILES_COMMONX86 0x002c")]
    public const int CSIDL_PROGRAM_FILES_COMMONX86 = 0x002c;

    [NativeTypeName("#define CSIDL_COMMON_TEMPLATES 0x002d")]
    public const int CSIDL_COMMON_TEMPLATES = 0x002d;

    [NativeTypeName("#define CSIDL_COMMON_DOCUMENTS 0x002e")]
    public const int CSIDL_COMMON_DOCUMENTS = 0x002e;

    [NativeTypeName("#define CSIDL_COMMON_ADMINTOOLS 0x002f")]
    public const int CSIDL_COMMON_ADMINTOOLS = 0x002f;

    [NativeTypeName("#define CSIDL_ADMINTOOLS 0x0030")]
    public const int CSIDL_ADMINTOOLS = 0x0030;

    [NativeTypeName("#define CSIDL_CONNECTIONS 0x0031")]
    public const int CSIDL_CONNECTIONS = 0x0031;

    [NativeTypeName("#define CSIDL_COMMON_MUSIC 0x0035")]
    public const int CSIDL_COMMON_MUSIC = 0x0035;

    [NativeTypeName("#define CSIDL_COMMON_PICTURES 0x0036")]
    public const int CSIDL_COMMON_PICTURES = 0x0036;

    [NativeTypeName("#define CSIDL_COMMON_VIDEO 0x0037")]
    public const int CSIDL_COMMON_VIDEO = 0x0037;

    [NativeTypeName("#define CSIDL_RESOURCES 0x0038")]
    public const int CSIDL_RESOURCES = 0x0038;

    [NativeTypeName("#define CSIDL_RESOURCES_LOCALIZED 0x0039")]
    public const int CSIDL_RESOURCES_LOCALIZED = 0x0039;

    [NativeTypeName("#define CSIDL_COMMON_OEM_LINKS 0x003a")]
    public const int CSIDL_COMMON_OEM_LINKS = 0x003a;

    [NativeTypeName("#define CSIDL_CDBURN_AREA 0x003b")]
    public const int CSIDL_CDBURN_AREA = 0x003b;

    [NativeTypeName("#define CSIDL_COMPUTERSNEARME 0x003d")]
    public const int CSIDL_COMPUTERSNEARME = 0x003d;

    [NativeTypeName("#define CSIDL_FLAG_CREATE 0x8000")]
    public const int CSIDL_FLAG_CREATE = 0x8000;

    [NativeTypeName("#define CSIDL_FLAG_DONT_VERIFY 0x4000")]
    public const int CSIDL_FLAG_DONT_VERIFY = 0x4000;

    [NativeTypeName("#define CSIDL_FLAG_DONT_UNEXPAND 0x2000")]
    public const int CSIDL_FLAG_DONT_UNEXPAND = 0x2000;

    [NativeTypeName("#define CSIDL_FLAG_NO_ALIAS 0x1000")]
    public const int CSIDL_FLAG_NO_ALIAS = 0x1000;

    [NativeTypeName("#define CSIDL_FLAG_PER_USER_INIT 0x0800")]
    public const int CSIDL_FLAG_PER_USER_INIT = 0x0800;

    [NativeTypeName("#define CSIDL_FLAG_MASK 0xFF00")]
    public const int CSIDL_FLAG_MASK = 0xFF00;
}
