// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CS
{
    [NativeTypeName("#define CS_INSERTCHAR 0x2000")]
    public const int CS_INSERTCHAR = 0x2000;
    [NativeTypeName("#define CS_NOMOVECARET 0x4000")]
    public const int CS_NOMOVECARET = 0x4000;
}