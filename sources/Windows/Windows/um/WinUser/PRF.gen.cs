// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PRF
{
    [NativeTypeName("#define PRF_CHECKVISIBLE 0x00000001L")]
    public const int PRF_CHECKVISIBLE = 0x00000001;
    [NativeTypeName("#define PRF_NONCLIENT 0x00000002L")]
    public const int PRF_NONCLIENT = 0x00000002;
    [NativeTypeName("#define PRF_CLIENT 0x00000004L")]
    public const int PRF_CLIENT = 0x00000004;
    [NativeTypeName("#define PRF_ERASEBKGND 0x00000008L")]
    public const int PRF_ERASEBKGND = 0x00000008;
    [NativeTypeName("#define PRF_CHILDREN 0x00000010L")]
    public const int PRF_CHILDREN = 0x00000010;
    [NativeTypeName("#define PRF_OWNED 0x00000020L")]
    public const int PRF_OWNED = 0x00000020;
}