// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TPM
{
    [NativeTypeName("#define TPM_LEFTBUTTON 0x0000L")]
    public const int TPM_LEFTBUTTON = 0x0000;
    [NativeTypeName("#define TPM_RIGHTBUTTON 0x0002L")]
    public const int TPM_RIGHTBUTTON = 0x0002;
    [NativeTypeName("#define TPM_LEFTALIGN 0x0000L")]
    public const int TPM_LEFTALIGN = 0x0000;
    [NativeTypeName("#define TPM_CENTERALIGN 0x0004L")]
    public const int TPM_CENTERALIGN = 0x0004;
    [NativeTypeName("#define TPM_RIGHTALIGN 0x0008L")]
    public const int TPM_RIGHTALIGN = 0x0008;
    [NativeTypeName("#define TPM_TOPALIGN 0x0000L")]
    public const int TPM_TOPALIGN = 0x0000;
    [NativeTypeName("#define TPM_VCENTERALIGN 0x0010L")]
    public const int TPM_VCENTERALIGN = 0x0010;
    [NativeTypeName("#define TPM_BOTTOMALIGN 0x0020L")]
    public const int TPM_BOTTOMALIGN = 0x0020;
    [NativeTypeName("#define TPM_HORIZONTAL 0x0000L")]
    public const int TPM_HORIZONTAL = 0x0000;
    [NativeTypeName("#define TPM_VERTICAL 0x0040L")]
    public const int TPM_VERTICAL = 0x0040;
    [NativeTypeName("#define TPM_NONOTIFY 0x0080L")]
    public const int TPM_NONOTIFY = 0x0080;
    [NativeTypeName("#define TPM_RETURNCMD 0x0100L")]
    public const int TPM_RETURNCMD = 0x0100;
    [NativeTypeName("#define TPM_RECURSE 0x0001L")]
    public const int TPM_RECURSE = 0x0001;
    [NativeTypeName("#define TPM_HORPOSANIMATION 0x0400L")]
    public const int TPM_HORPOSANIMATION = 0x0400;
    [NativeTypeName("#define TPM_HORNEGANIMATION 0x0800L")]
    public const int TPM_HORNEGANIMATION = 0x0800;
    [NativeTypeName("#define TPM_VERPOSANIMATION 0x1000L")]
    public const int TPM_VERPOSANIMATION = 0x1000;
    [NativeTypeName("#define TPM_VERNEGANIMATION 0x2000L")]
    public const int TPM_VERNEGANIMATION = 0x2000;
    [NativeTypeName("#define TPM_NOANIMATION 0x4000L")]
    public const int TPM_NOANIMATION = 0x4000;
    [NativeTypeName("#define TPM_LAYOUTRTL 0x8000L")]
    public const int TPM_LAYOUTRTL = 0x8000;
    [NativeTypeName("#define TPM_WORKAREA 0x10000L")]
    public const int TPM_WORKAREA = 0x10000;
}