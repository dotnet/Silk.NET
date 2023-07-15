// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SHDID
{
    [NativeTypeName("#define SHDID_ROOT_REGITEM 1")]
    public const int SHDID_ROOT_REGITEM = 1;
    [NativeTypeName("#define SHDID_FS_FILE 2")]
    public const int SHDID_FS_FILE = 2;
    [NativeTypeName("#define SHDID_FS_DIRECTORY 3")]
    public const int SHDID_FS_DIRECTORY = 3;
    [NativeTypeName("#define SHDID_FS_OTHER 4")]
    public const int SHDID_FS_OTHER = 4;
    [NativeTypeName("#define SHDID_COMPUTER_DRIVE35 5")]
    public const int SHDID_COMPUTER_DRIVE35 = 5;
    [NativeTypeName("#define SHDID_COMPUTER_DRIVE525 6")]
    public const int SHDID_COMPUTER_DRIVE525 = 6;
    [NativeTypeName("#define SHDID_COMPUTER_REMOVABLE 7")]
    public const int SHDID_COMPUTER_REMOVABLE = 7;
    [NativeTypeName("#define SHDID_COMPUTER_FIXED 8")]
    public const int SHDID_COMPUTER_FIXED = 8;
    [NativeTypeName("#define SHDID_COMPUTER_NETDRIVE 9")]
    public const int SHDID_COMPUTER_NETDRIVE = 9;
    [NativeTypeName("#define SHDID_COMPUTER_CDROM 10")]
    public const int SHDID_COMPUTER_CDROM = 10;
    [NativeTypeName("#define SHDID_COMPUTER_RAMDISK 11")]
    public const int SHDID_COMPUTER_RAMDISK = 11;
    [NativeTypeName("#define SHDID_COMPUTER_OTHER 12")]
    public const int SHDID_COMPUTER_OTHER = 12;
    [NativeTypeName("#define SHDID_NET_DOMAIN 13")]
    public const int SHDID_NET_DOMAIN = 13;
    [NativeTypeName("#define SHDID_NET_SERVER 14")]
    public const int SHDID_NET_SERVER = 14;
    [NativeTypeName("#define SHDID_NET_SHARE 15")]
    public const int SHDID_NET_SHARE = 15;
    [NativeTypeName("#define SHDID_NET_RESTOFNET 16")]
    public const int SHDID_NET_RESTOFNET = 16;
    [NativeTypeName("#define SHDID_NET_OTHER 17")]
    public const int SHDID_NET_OTHER = 17;
    [NativeTypeName("#define SHDID_COMPUTER_IMAGING 18")]
    public const int SHDID_COMPUTER_IMAGING = 18;
    [NativeTypeName("#define SHDID_COMPUTER_AUDIO 19")]
    public const int SHDID_COMPUTER_AUDIO = 19;
    [NativeTypeName("#define SHDID_COMPUTER_SHAREDDOCS 20")]
    public const int SHDID_COMPUTER_SHAREDDOCS = 20;
    [NativeTypeName("#define SHDID_MOBILE_DEVICE 21")]
    public const int SHDID_MOBILE_DEVICE = 21;
    [NativeTypeName("#define SHDID_REMOTE_DESKTOP_DRIVE 22")]
    public const int SHDID_REMOTE_DESKTOP_DRIVE = 22;
}