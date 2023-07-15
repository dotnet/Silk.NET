// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PRF
{
    [NativeTypeName("#define PRF_VERIFYEXISTS 0x0001")]
    public const int PRF_VERIFYEXISTS = 0x0001;
    [NativeTypeName("#define PRF_TRYPROGRAMEXTENSIONS (0x0002 | PRF_VERIFYEXISTS)")]
    public const int PRF_TRYPROGRAMEXTENSIONS = (0x0002 | 0x0001);
    [NativeTypeName("#define PRF_FIRSTDIRDEF 0x0004")]
    public const int PRF_FIRSTDIRDEF = 0x0004;
    [NativeTypeName("#define PRF_DONTFINDLNK 0x0008")]
    public const int PRF_DONTFINDLNK = 0x0008;
    [NativeTypeName("#define PRF_REQUIREABSOLUTE 0x0010")]
    public const int PRF_REQUIREABSOLUTE = 0x0010;
}