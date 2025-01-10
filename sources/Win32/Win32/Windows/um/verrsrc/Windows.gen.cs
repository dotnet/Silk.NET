// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/verrsrc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("#define VS_FILE_INFO RT_VERSION")]
    public static ushort* VS_FILE_INFO => ((ushort*)((nuint)((ushort)(16))));

    [NativeTypeName("#define VS_VERSION_INFO 1")]
    public const int VS_VERSION_INFO = 1;

    [NativeTypeName("#define VS_USER_DEFINED 100")]
    public const int VS_USER_DEFINED = 100;

    [NativeTypeName("#define VS_FFI_SIGNATURE 0xFEEF04BDL")]
    public const uint VS_FFI_SIGNATURE = 0xFEEF04BD;

    [NativeTypeName("#define VS_FFI_STRUCVERSION 0x00010000L")]
    public const int VS_FFI_STRUCVERSION = 0x00010000;

    [NativeTypeName("#define VS_FFI_FILEFLAGSMASK 0x0000003FL")]
    public const int VS_FFI_FILEFLAGSMASK = 0x0000003F;

    [NativeTypeName("#define VS_FF_DEBUG 0x00000001L")]
    public const int VS_FF_DEBUG = 0x00000001;

    [NativeTypeName("#define VS_FF_PRERELEASE 0x00000002L")]
    public const int VS_FF_PRERELEASE = 0x00000002;

    [NativeTypeName("#define VS_FF_PATCHED 0x00000004L")]
    public const int VS_FF_PATCHED = 0x00000004;

    [NativeTypeName("#define VS_FF_PRIVATEBUILD 0x00000008L")]
    public const int VS_FF_PRIVATEBUILD = 0x00000008;

    [NativeTypeName("#define VS_FF_INFOINFERRED 0x00000010L")]
    public const int VS_FF_INFOINFERRED = 0x00000010;

    [NativeTypeName("#define VS_FF_SPECIALBUILD 0x00000020L")]
    public const int VS_FF_SPECIALBUILD = 0x00000020;

    [NativeTypeName("#define VOS_UNKNOWN 0x00000000L")]
    public const int VOS_UNKNOWN = 0x00000000;

    [NativeTypeName("#define VOS_DOS 0x00010000L")]
    public const int VOS_DOS = 0x00010000;

    [NativeTypeName("#define VOS_OS216 0x00020000L")]
    public const int VOS_OS216 = 0x00020000;

    [NativeTypeName("#define VOS_OS232 0x00030000L")]
    public const int VOS_OS232 = 0x00030000;

    [NativeTypeName("#define VOS_NT 0x00040000L")]
    public const int VOS_NT = 0x00040000;

    [NativeTypeName("#define VOS_WINCE 0x00050000L")]
    public const int VOS_WINCE = 0x00050000;

    [NativeTypeName("#define VOS__BASE 0x00000000L")]
    public const int VOS__BASE = 0x00000000;

    [NativeTypeName("#define VOS__WINDOWS16 0x00000001L")]
    public const int VOS__WINDOWS16 = 0x00000001;

    [NativeTypeName("#define VOS__PM16 0x00000002L")]
    public const int VOS__PM16 = 0x00000002;

    [NativeTypeName("#define VOS__PM32 0x00000003L")]
    public const int VOS__PM32 = 0x00000003;

    [NativeTypeName("#define VOS__WINDOWS32 0x00000004L")]
    public const int VOS__WINDOWS32 = 0x00000004;

    [NativeTypeName("#define VOS_DOS_WINDOWS16 0x00010001L")]
    public const int VOS_DOS_WINDOWS16 = 0x00010001;

    [NativeTypeName("#define VOS_DOS_WINDOWS32 0x00010004L")]
    public const int VOS_DOS_WINDOWS32 = 0x00010004;

    [NativeTypeName("#define VOS_OS216_PM16 0x00020002L")]
    public const int VOS_OS216_PM16 = 0x00020002;

    [NativeTypeName("#define VOS_OS232_PM32 0x00030003L")]
    public const int VOS_OS232_PM32 = 0x00030003;

    [NativeTypeName("#define VOS_NT_WINDOWS32 0x00040004L")]
    public const int VOS_NT_WINDOWS32 = 0x00040004;

    [NativeTypeName("#define VFT_UNKNOWN 0x00000000L")]
    public const int VFT_UNKNOWN = 0x00000000;

    [NativeTypeName("#define VFT_APP 0x00000001L")]
    public const int VFT_APP = 0x00000001;

    [NativeTypeName("#define VFT_DLL 0x00000002L")]
    public const int VFT_DLL = 0x00000002;

    [NativeTypeName("#define VFT_DRV 0x00000003L")]
    public const int VFT_DRV = 0x00000003;

    [NativeTypeName("#define VFT_FONT 0x00000004L")]
    public const int VFT_FONT = 0x00000004;

    [NativeTypeName("#define VFT_VXD 0x00000005L")]
    public const int VFT_VXD = 0x00000005;

    [NativeTypeName("#define VFT_STATIC_LIB 0x00000007L")]
    public const int VFT_STATIC_LIB = 0x00000007;

    [NativeTypeName("#define VFT2_UNKNOWN 0x00000000L")]
    public const int VFT2_UNKNOWN = 0x00000000;

    [NativeTypeName("#define VFT2_DRV_PRINTER 0x00000001L")]
    public const int VFT2_DRV_PRINTER = 0x00000001;

    [NativeTypeName("#define VFT2_DRV_KEYBOARD 0x00000002L")]
    public const int VFT2_DRV_KEYBOARD = 0x00000002;

    [NativeTypeName("#define VFT2_DRV_LANGUAGE 0x00000003L")]
    public const int VFT2_DRV_LANGUAGE = 0x00000003;

    [NativeTypeName("#define VFT2_DRV_DISPLAY 0x00000004L")]
    public const int VFT2_DRV_DISPLAY = 0x00000004;

    [NativeTypeName("#define VFT2_DRV_MOUSE 0x00000005L")]
    public const int VFT2_DRV_MOUSE = 0x00000005;

    [NativeTypeName("#define VFT2_DRV_NETWORK 0x00000006L")]
    public const int VFT2_DRV_NETWORK = 0x00000006;

    [NativeTypeName("#define VFT2_DRV_SYSTEM 0x00000007L")]
    public const int VFT2_DRV_SYSTEM = 0x00000007;

    [NativeTypeName("#define VFT2_DRV_INSTALLABLE 0x00000008L")]
    public const int VFT2_DRV_INSTALLABLE = 0x00000008;

    [NativeTypeName("#define VFT2_DRV_SOUND 0x00000009L")]
    public const int VFT2_DRV_SOUND = 0x00000009;

    [NativeTypeName("#define VFT2_DRV_COMM 0x0000000AL")]
    public const int VFT2_DRV_COMM = 0x0000000A;

    [NativeTypeName("#define VFT2_DRV_INPUTMETHOD 0x0000000BL")]
    public const int VFT2_DRV_INPUTMETHOD = 0x0000000B;

    [NativeTypeName("#define VFT2_DRV_VERSIONED_PRINTER 0x0000000CL")]
    public const int VFT2_DRV_VERSIONED_PRINTER = 0x0000000C;

    [NativeTypeName("#define VFT2_FONT_RASTER 0x00000001L")]
    public const int VFT2_FONT_RASTER = 0x00000001;

    [NativeTypeName("#define VFT2_FONT_VECTOR 0x00000002L")]
    public const int VFT2_FONT_VECTOR = 0x00000002;

    [NativeTypeName("#define VFT2_FONT_TRUETYPE 0x00000003L")]
    public const int VFT2_FONT_TRUETYPE = 0x00000003;

    [NativeTypeName("#define VFFF_ISSHAREDFILE 0x0001")]
    public const int VFFF_ISSHAREDFILE = 0x0001;

    [NativeTypeName("#define VFF_CURNEDEST 0x0001")]
    public const int VFF_CURNEDEST = 0x0001;

    [NativeTypeName("#define VFF_FILEINUSE 0x0002")]
    public const int VFF_FILEINUSE = 0x0002;

    [NativeTypeName("#define VFF_BUFFTOOSMALL 0x0004")]
    public const int VFF_BUFFTOOSMALL = 0x0004;

    [NativeTypeName("#define VIFF_FORCEINSTALL 0x0001")]
    public const int VIFF_FORCEINSTALL = 0x0001;

    [NativeTypeName("#define VIFF_DONTDELETEOLD 0x0002")]
    public const int VIFF_DONTDELETEOLD = 0x0002;

    [NativeTypeName("#define VIF_TEMPFILE 0x00000001L")]
    public const int VIF_TEMPFILE = 0x00000001;

    [NativeTypeName("#define VIF_MISMATCH 0x00000002L")]
    public const int VIF_MISMATCH = 0x00000002;

    [NativeTypeName("#define VIF_SRCOLD 0x00000004L")]
    public const int VIF_SRCOLD = 0x00000004;

    [NativeTypeName("#define VIF_DIFFLANG 0x00000008L")]
    public const int VIF_DIFFLANG = 0x00000008;

    [NativeTypeName("#define VIF_DIFFCODEPG 0x00000010L")]
    public const int VIF_DIFFCODEPG = 0x00000010;

    [NativeTypeName("#define VIF_DIFFTYPE 0x00000020L")]
    public const int VIF_DIFFTYPE = 0x00000020;

    [NativeTypeName("#define VIF_WRITEPROT 0x00000040L")]
    public const int VIF_WRITEPROT = 0x00000040;

    [NativeTypeName("#define VIF_FILEINUSE 0x00000080L")]
    public const int VIF_FILEINUSE = 0x00000080;

    [NativeTypeName("#define VIF_OUTOFSPACE 0x00000100L")]
    public const int VIF_OUTOFSPACE = 0x00000100;

    [NativeTypeName("#define VIF_ACCESSVIOLATION 0x00000200L")]
    public const int VIF_ACCESSVIOLATION = 0x00000200;

    [NativeTypeName("#define VIF_SHARINGVIOLATION 0x00000400L")]
    public const int VIF_SHARINGVIOLATION = 0x00000400;

    [NativeTypeName("#define VIF_CANNOTCREATE 0x00000800L")]
    public const int VIF_CANNOTCREATE = 0x00000800;

    [NativeTypeName("#define VIF_CANNOTDELETE 0x00001000L")]
    public const int VIF_CANNOTDELETE = 0x00001000;

    [NativeTypeName("#define VIF_CANNOTRENAME 0x00002000L")]
    public const int VIF_CANNOTRENAME = 0x00002000;

    [NativeTypeName("#define VIF_CANNOTDELETECUR 0x00004000L")]
    public const int VIF_CANNOTDELETECUR = 0x00004000;

    [NativeTypeName("#define VIF_OUTOFMEMORY 0x00008000L")]
    public const int VIF_OUTOFMEMORY = 0x00008000;

    [NativeTypeName("#define VIF_CANNOTREADSRC 0x00010000L")]
    public const int VIF_CANNOTREADSRC = 0x00010000;

    [NativeTypeName("#define VIF_CANNOTREADDST 0x00020000L")]
    public const int VIF_CANNOTREADDST = 0x00020000;

    [NativeTypeName("#define VIF_BUFFTOOSMALL 0x00040000L")]
    public const int VIF_BUFFTOOSMALL = 0x00040000;

    [NativeTypeName("#define VIF_CANNOTLOADLZ32 0x00080000L")]
    public const int VIF_CANNOTLOADLZ32 = 0x00080000;

    [NativeTypeName("#define VIF_CANNOTLOADCABINET 0x00100000L")]
    public const int VIF_CANNOTLOADCABINET = 0x00100000;
}
