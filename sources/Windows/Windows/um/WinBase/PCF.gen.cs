// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PCF
{
    [NativeTypeName("#define PCF_DTRDSR ((DWORD)0x0001)")]
    public const uint PCF_DTRDSR = ((uint)(0x0001));
    [NativeTypeName("#define PCF_RTSCTS ((DWORD)0x0002)")]
    public const uint PCF_RTSCTS = ((uint)(0x0002));
    [NativeTypeName("#define PCF_RLSD ((DWORD)0x0004)")]
    public const uint PCF_RLSD = ((uint)(0x0004));
    [NativeTypeName("#define PCF_PARITY_CHECK ((DWORD)0x0008)")]
    public const uint PCF_PARITY_CHECK = ((uint)(0x0008));
    [NativeTypeName("#define PCF_XONXOFF ((DWORD)0x0010)")]
    public const uint PCF_XONXOFF = ((uint)(0x0010));
    [NativeTypeName("#define PCF_SETXCHAR ((DWORD)0x0020)")]
    public const uint PCF_SETXCHAR = ((uint)(0x0020));
    [NativeTypeName("#define PCF_TOTALTIMEOUTS ((DWORD)0x0040)")]
    public const uint PCF_TOTALTIMEOUTS = ((uint)(0x0040));
    [NativeTypeName("#define PCF_INTTIMEOUTS ((DWORD)0x0080)")]
    public const uint PCF_INTTIMEOUTS = ((uint)(0x0080));
    [NativeTypeName("#define PCF_SPECIALCHARS ((DWORD)0x0100)")]
    public const uint PCF_SPECIALCHARS = ((uint)(0x0100));
    [NativeTypeName("#define PCF_16BITMODE ((DWORD)0x0200)")]
    public const uint PCF_16BITMODE = ((uint)(0x0200));
}