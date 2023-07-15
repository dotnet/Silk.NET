// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WT
{
    [NativeTypeName("#define WT_EXECUTEDEFAULT 0x00000000")]
    public const int WT_EXECUTEDEFAULT = 0x00000000;
    [NativeTypeName("#define WT_EXECUTEINIOTHREAD 0x00000001")]
    public const int WT_EXECUTEINIOTHREAD = 0x00000001;
    [NativeTypeName("#define WT_EXECUTEINUITHREAD 0x00000002")]
    public const int WT_EXECUTEINUITHREAD = 0x00000002;
    [NativeTypeName("#define WT_EXECUTEINWAITTHREAD 0x00000004")]
    public const int WT_EXECUTEINWAITTHREAD = 0x00000004;
    [NativeTypeName("#define WT_EXECUTEONLYONCE 0x00000008")]
    public const int WT_EXECUTEONLYONCE = 0x00000008;
    [NativeTypeName("#define WT_EXECUTEINTIMERTHREAD 0x00000020")]
    public const int WT_EXECUTEINTIMERTHREAD = 0x00000020;
    [NativeTypeName("#define WT_EXECUTELONGFUNCTION 0x00000010")]
    public const int WT_EXECUTELONGFUNCTION = 0x00000010;
    [NativeTypeName("#define WT_EXECUTEINPERSISTENTIOTHREAD 0x00000040")]
    public const int WT_EXECUTEINPERSISTENTIOTHREAD = 0x00000040;
    [NativeTypeName("#define WT_EXECUTEINPERSISTENTTHREAD 0x00000080")]
    public const int WT_EXECUTEINPERSISTENTTHREAD = 0x00000080;
    [NativeTypeName("#define WT_TRANSFER_IMPERSONATION 0x00000100")]
    public const int WT_TRANSFER_IMPERSONATION = 0x00000100;
    [NativeTypeName("#define WT_EXECUTEINLONGTHREAD 0x00000010")]
    public const int WT_EXECUTEINLONGTHREAD = 0x00000010;
    [NativeTypeName("#define WT_EXECUTEDELETEWAIT 0x00000008")]
    public const int WT_EXECUTEDELETEWAIT = 0x00000008;
}