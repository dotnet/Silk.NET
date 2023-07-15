// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FLAG
{
    [NativeTypeName("#define FLAG_NO_GPO_FILTER 0x80000000")]
    public const uint FLAG_NO_GPO_FILTER = 0x80000000;
    [NativeTypeName("#define FLAG_NO_CSE_INVOKE 0x40000000")]
    public const int FLAG_NO_CSE_INVOKE = 0x40000000;
    [NativeTypeName("#define FLAG_ASSUME_SLOW_LINK 0x20000000")]
    public const int FLAG_ASSUME_SLOW_LINK = 0x20000000;
    [NativeTypeName("#define FLAG_LOOPBACK_MERGE 0x10000000")]
    public const int FLAG_LOOPBACK_MERGE = 0x10000000;
    [NativeTypeName("#define FLAG_LOOPBACK_REPLACE 0x08000000")]
    public const int FLAG_LOOPBACK_REPLACE = 0x08000000;
    [NativeTypeName("#define FLAG_ASSUME_USER_WQLFILTER_TRUE 0x04000000")]
    public const int FLAG_ASSUME_USER_WQLFILTER_TRUE = 0x04000000;
    [NativeTypeName("#define FLAG_ASSUME_COMP_WQLFILTER_TRUE 0x02000000")]
    public const int FLAG_ASSUME_COMP_WQLFILTER_TRUE = 0x02000000;
    [NativeTypeName("#define FLAG_PLANNING_MODE 0x01000000")]
    public const int FLAG_PLANNING_MODE = 0x01000000;
    [NativeTypeName("#define FLAG_NO_USER 0x00000001")]
    public const int FLAG_NO_USER = 0x00000001;
    [NativeTypeName("#define FLAG_NO_COMPUTER 0x00000002")]
    public const int FLAG_NO_COMPUTER = 0x00000002;
    [NativeTypeName("#define FLAG_FORCE_CREATENAMESPACE 0x00000004")]
    public const int FLAG_FORCE_CREATENAMESPACE = 0x00000004;
}