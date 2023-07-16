// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MS
{
    [NativeTypeName("#define MS_CTS_ON ((DWORD)0x0010)")]
    public const uint MS_CTS_ON = ((uint)(0x0010));
    [NativeTypeName("#define MS_DSR_ON ((DWORD)0x0020)")]
    public const uint MS_DSR_ON = ((uint)(0x0020));
    [NativeTypeName("#define MS_RING_ON ((DWORD)0x0040)")]
    public const uint MS_RING_ON = ((uint)(0x0040));
    [NativeTypeName("#define MS_RLSD_ON ((DWORD)0x0080)")]
    public const uint MS_RLSD_ON = ((uint)(0x0080));
}