// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/coml2api.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class STGM
{
    [NativeTypeName("#define STGM_DIRECT 0x00000000L")]
    public const int STGM_DIRECT = 0x00000000;
    [NativeTypeName("#define STGM_TRANSACTED 0x00010000L")]
    public const int STGM_TRANSACTED = 0x00010000;
    [NativeTypeName("#define STGM_SIMPLE 0x08000000L")]
    public const int STGM_SIMPLE = 0x08000000;
    [NativeTypeName("#define STGM_READ 0x00000000L")]
    public const int STGM_READ = 0x00000000;
    [NativeTypeName("#define STGM_WRITE 0x00000001L")]
    public const int STGM_WRITE = 0x00000001;
    [NativeTypeName("#define STGM_READWRITE 0x00000002L")]
    public const int STGM_READWRITE = 0x00000002;
    [NativeTypeName("#define STGM_SHARE_DENY_NONE 0x00000040L")]
    public const int STGM_SHARE_DENY_NONE = 0x00000040;
    [NativeTypeName("#define STGM_SHARE_DENY_READ 0x00000030L")]
    public const int STGM_SHARE_DENY_READ = 0x00000030;
    [NativeTypeName("#define STGM_SHARE_DENY_WRITE 0x00000020L")]
    public const int STGM_SHARE_DENY_WRITE = 0x00000020;
    [NativeTypeName("#define STGM_SHARE_EXCLUSIVE 0x00000010L")]
    public const int STGM_SHARE_EXCLUSIVE = 0x00000010;
    [NativeTypeName("#define STGM_PRIORITY 0x00040000L")]
    public const int STGM_PRIORITY = 0x00040000;
    [NativeTypeName("#define STGM_DELETEONRELEASE 0x04000000L")]
    public const int STGM_DELETEONRELEASE = 0x04000000;
    [NativeTypeName("#define STGM_NOSCRATCH 0x00100000L")]
    public const int STGM_NOSCRATCH = 0x00100000;
    [NativeTypeName("#define STGM_CREATE 0x00001000L")]
    public const int STGM_CREATE = 0x00001000;
    [NativeTypeName("#define STGM_CONVERT 0x00020000L")]
    public const int STGM_CONVERT = 0x00020000;
    [NativeTypeName("#define STGM_FAILIFTHERE 0x00000000L")]
    public const int STGM_FAILIFTHERE = 0x00000000;
    [NativeTypeName("#define STGM_NOSNAPSHOT 0x00200000L")]
    public const int STGM_NOSNAPSHOT = 0x00200000;
    [NativeTypeName("#define STGM_DIRECT_SWMR 0x00400000L")]
    public const int STGM_DIRECT_SWMR = 0x00400000;
}