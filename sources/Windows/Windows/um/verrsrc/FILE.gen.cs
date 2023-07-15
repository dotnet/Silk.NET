// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/verrsrc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FILE
{
    [NativeTypeName("#define FILE_VER_GET_LOCALISED 0x01")]
    public const int FILE_VER_GET_LOCALISED = 0x01;
    [NativeTypeName("#define FILE_VER_GET_NEUTRAL 0x02")]
    public const int FILE_VER_GET_NEUTRAL = 0x02;
    [NativeTypeName("#define FILE_VER_GET_PREFETCHED 0x04")]
    public const int FILE_VER_GET_PREFETCHED = 0x04;
}