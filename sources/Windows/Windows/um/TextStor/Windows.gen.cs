// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define GXFPF_ROUND_NEAREST ( 0x1 )")]
    public const int GXFPF_ROUND_NEAREST = (0x1);
    [NativeTypeName("#define GXFPF_NEAREST ( 0x2 )")]
    public const int GXFPF_NEAREST = (0x2);
}