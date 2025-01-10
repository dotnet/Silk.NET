// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class EV
{
    [NativeTypeName("#define EV_RXCHAR 0x0001")]
    public const int EV_RXCHAR = 0x0001;

    [NativeTypeName("#define EV_RXFLAG 0x0002")]
    public const int EV_RXFLAG = 0x0002;

    [NativeTypeName("#define EV_TXEMPTY 0x0004")]
    public const int EV_TXEMPTY = 0x0004;

    [NativeTypeName("#define EV_CTS 0x0008")]
    public const int EV_CTS = 0x0008;

    [NativeTypeName("#define EV_DSR 0x0010")]
    public const int EV_DSR = 0x0010;

    [NativeTypeName("#define EV_RLSD 0x0020")]
    public const int EV_RLSD = 0x0020;

    [NativeTypeName("#define EV_BREAK 0x0040")]
    public const int EV_BREAK = 0x0040;

    [NativeTypeName("#define EV_ERR 0x0080")]
    public const int EV_ERR = 0x0080;

    [NativeTypeName("#define EV_RING 0x0100")]
    public const int EV_RING = 0x0100;

    [NativeTypeName("#define EV_PERR 0x0200")]
    public const int EV_PERR = 0x0200;

    [NativeTypeName("#define EV_RX80FULL 0x0400")]
    public const int EV_RX80FULL = 0x0400;

    [NativeTypeName("#define EV_EVENT1 0x0800")]
    public const int EV_EVENT1 = 0x0800;

    [NativeTypeName("#define EV_EVENT2 0x1000")]
    public const int EV_EVENT2 = 0x1000;
}
