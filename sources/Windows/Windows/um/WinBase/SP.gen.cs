// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SP
{
    [NativeTypeName("#define SP_SERIALCOMM ((DWORD)0x00000001)")]
    public const uint SP_SERIALCOMM = ((uint)(0x00000001));
    [NativeTypeName("#define SP_PARITY ((DWORD)0x0001)")]
    public const uint SP_PARITY = ((uint)(0x0001));
    [NativeTypeName("#define SP_BAUD ((DWORD)0x0002)")]
    public const uint SP_BAUD = ((uint)(0x0002));
    [NativeTypeName("#define SP_DATABITS ((DWORD)0x0004)")]
    public const uint SP_DATABITS = ((uint)(0x0004));
    [NativeTypeName("#define SP_STOPBITS ((DWORD)0x0008)")]
    public const uint SP_STOPBITS = ((uint)(0x0008));
    [NativeTypeName("#define SP_HANDSHAKING ((DWORD)0x0010)")]
    public const uint SP_HANDSHAKING = ((uint)(0x0010));
    [NativeTypeName("#define SP_PARITY_CHECK ((DWORD)0x0020)")]
    public const uint SP_PARITY_CHECK = ((uint)(0x0020));
    [NativeTypeName("#define SP_RLSD ((DWORD)0x0040)")]
    public const uint SP_RLSD = ((uint)(0x0040));
}