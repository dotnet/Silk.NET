// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MM
{
    [NativeTypeName("#define MM_JOY1MOVE 0x3A0")]
    public const int MM_JOY1MOVE = 0x3A0;

    [NativeTypeName("#define MM_JOY2MOVE 0x3A1")]
    public const int MM_JOY2MOVE = 0x3A1;

    [NativeTypeName("#define MM_JOY1ZMOVE 0x3A2")]
    public const int MM_JOY1ZMOVE = 0x3A2;

    [NativeTypeName("#define MM_JOY2ZMOVE 0x3A3")]
    public const int MM_JOY2ZMOVE = 0x3A3;

    [NativeTypeName("#define MM_JOY1BUTTONDOWN 0x3B5")]
    public const int MM_JOY1BUTTONDOWN = 0x3B5;

    [NativeTypeName("#define MM_JOY2BUTTONDOWN 0x3B6")]
    public const int MM_JOY2BUTTONDOWN = 0x3B6;

    [NativeTypeName("#define MM_JOY1BUTTONUP 0x3B7")]
    public const int MM_JOY1BUTTONUP = 0x3B7;

    [NativeTypeName("#define MM_JOY2BUTTONUP 0x3B8")]
    public const int MM_JOY2BUTTONUP = 0x3B8;

    [NativeTypeName("#define MM_MCINOTIFY 0x3B9")]
    public const int MM_MCINOTIFY = 0x3B9;

    [NativeTypeName("#define MM_WOM_OPEN 0x3BB")]
    public const int MM_WOM_OPEN = 0x3BB;

    [NativeTypeName("#define MM_WOM_CLOSE 0x3BC")]
    public const int MM_WOM_CLOSE = 0x3BC;

    [NativeTypeName("#define MM_WOM_DONE 0x3BD")]
    public const int MM_WOM_DONE = 0x3BD;

    [NativeTypeName("#define MM_WIM_OPEN 0x3BE")]
    public const int MM_WIM_OPEN = 0x3BE;

    [NativeTypeName("#define MM_WIM_CLOSE 0x3BF")]
    public const int MM_WIM_CLOSE = 0x3BF;

    [NativeTypeName("#define MM_WIM_DATA 0x3C0")]
    public const int MM_WIM_DATA = 0x3C0;

    [NativeTypeName("#define MM_MIM_OPEN 0x3C1")]
    public const int MM_MIM_OPEN = 0x3C1;

    [NativeTypeName("#define MM_MIM_CLOSE 0x3C2")]
    public const int MM_MIM_CLOSE = 0x3C2;

    [NativeTypeName("#define MM_MIM_DATA 0x3C3")]
    public const int MM_MIM_DATA = 0x3C3;

    [NativeTypeName("#define MM_MIM_LONGDATA 0x3C4")]
    public const int MM_MIM_LONGDATA = 0x3C4;

    [NativeTypeName("#define MM_MIM_ERROR 0x3C5")]
    public const int MM_MIM_ERROR = 0x3C5;

    [NativeTypeName("#define MM_MIM_LONGERROR 0x3C6")]
    public const int MM_MIM_LONGERROR = 0x3C6;

    [NativeTypeName("#define MM_MOM_OPEN 0x3C7")]
    public const int MM_MOM_OPEN = 0x3C7;

    [NativeTypeName("#define MM_MOM_CLOSE 0x3C8")]
    public const int MM_MOM_CLOSE = 0x3C8;

    [NativeTypeName("#define MM_MOM_DONE 0x3C9")]
    public const int MM_MOM_DONE = 0x3C9;

    [NativeTypeName("#define MM_DRVM_OPEN 0x3D0")]
    public const int MM_DRVM_OPEN = 0x3D0;

    [NativeTypeName("#define MM_DRVM_CLOSE 0x3D1")]
    public const int MM_DRVM_CLOSE = 0x3D1;

    [NativeTypeName("#define MM_DRVM_DATA 0x3D2")]
    public const int MM_DRVM_DATA = 0x3D2;

    [NativeTypeName("#define MM_DRVM_ERROR 0x3D3")]
    public const int MM_DRVM_ERROR = 0x3D3;

    [NativeTypeName("#define MM_STREAM_OPEN 0x3D4")]
    public const int MM_STREAM_OPEN = 0x3D4;

    [NativeTypeName("#define MM_STREAM_CLOSE 0x3D5")]
    public const int MM_STREAM_CLOSE = 0x3D5;

    [NativeTypeName("#define MM_STREAM_DONE 0x3D6")]
    public const int MM_STREAM_DONE = 0x3D6;

    [NativeTypeName("#define MM_STREAM_ERROR 0x3D7")]
    public const int MM_STREAM_ERROR = 0x3D7;

    [NativeTypeName("#define MM_MOM_POSITIONCB 0x3CA")]
    public const int MM_MOM_POSITIONCB = 0x3CA;

    [NativeTypeName("#define MM_MCISIGNAL 0x3CB")]
    public const int MM_MCISIGNAL = 0x3CB;

    [NativeTypeName("#define MM_MIM_MOREDATA 0x3CC")]
    public const int MM_MIM_MOREDATA = 0x3CC;

    [NativeTypeName("#define MM_MIXM_LINE_CHANGE 0x3D0")]
    public const int MM_MIXM_LINE_CHANGE = 0x3D0;

    [NativeTypeName("#define MM_MIXM_CONTROL_CHANGE 0x3D1")]
    public const int MM_MIXM_CONTROL_CHANGE = 0x3D1;
}
