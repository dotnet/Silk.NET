// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DFCS
{
    [NativeTypeName("#define DFCS_CAPTIONCLOSE 0x0000")]
    public const int DFCS_CAPTIONCLOSE = 0x0000;

    [NativeTypeName("#define DFCS_CAPTIONMIN 0x0001")]
    public const int DFCS_CAPTIONMIN = 0x0001;

    [NativeTypeName("#define DFCS_CAPTIONMAX 0x0002")]
    public const int DFCS_CAPTIONMAX = 0x0002;

    [NativeTypeName("#define DFCS_CAPTIONRESTORE 0x0003")]
    public const int DFCS_CAPTIONRESTORE = 0x0003;

    [NativeTypeName("#define DFCS_CAPTIONHELP 0x0004")]
    public const int DFCS_CAPTIONHELP = 0x0004;

    [NativeTypeName("#define DFCS_MENUARROW 0x0000")]
    public const int DFCS_MENUARROW = 0x0000;

    [NativeTypeName("#define DFCS_MENUCHECK 0x0001")]
    public const int DFCS_MENUCHECK = 0x0001;

    [NativeTypeName("#define DFCS_MENUBULLET 0x0002")]
    public const int DFCS_MENUBULLET = 0x0002;

    [NativeTypeName("#define DFCS_MENUARROWRIGHT 0x0004")]
    public const int DFCS_MENUARROWRIGHT = 0x0004;

    [NativeTypeName("#define DFCS_SCROLLUP 0x0000")]
    public const int DFCS_SCROLLUP = 0x0000;

    [NativeTypeName("#define DFCS_SCROLLDOWN 0x0001")]
    public const int DFCS_SCROLLDOWN = 0x0001;

    [NativeTypeName("#define DFCS_SCROLLLEFT 0x0002")]
    public const int DFCS_SCROLLLEFT = 0x0002;

    [NativeTypeName("#define DFCS_SCROLLRIGHT 0x0003")]
    public const int DFCS_SCROLLRIGHT = 0x0003;

    [NativeTypeName("#define DFCS_SCROLLCOMBOBOX 0x0005")]
    public const int DFCS_SCROLLCOMBOBOX = 0x0005;

    [NativeTypeName("#define DFCS_SCROLLSIZEGRIP 0x0008")]
    public const int DFCS_SCROLLSIZEGRIP = 0x0008;

    [NativeTypeName("#define DFCS_SCROLLSIZEGRIPRIGHT 0x0010")]
    public const int DFCS_SCROLLSIZEGRIPRIGHT = 0x0010;

    [NativeTypeName("#define DFCS_BUTTONCHECK 0x0000")]
    public const int DFCS_BUTTONCHECK = 0x0000;

    [NativeTypeName("#define DFCS_BUTTONRADIOIMAGE 0x0001")]
    public const int DFCS_BUTTONRADIOIMAGE = 0x0001;

    [NativeTypeName("#define DFCS_BUTTONRADIOMASK 0x0002")]
    public const int DFCS_BUTTONRADIOMASK = 0x0002;

    [NativeTypeName("#define DFCS_BUTTONRADIO 0x0004")]
    public const int DFCS_BUTTONRADIO = 0x0004;

    [NativeTypeName("#define DFCS_BUTTON3STATE 0x0008")]
    public const int DFCS_BUTTON3STATE = 0x0008;

    [NativeTypeName("#define DFCS_BUTTONPUSH 0x0010")]
    public const int DFCS_BUTTONPUSH = 0x0010;

    [NativeTypeName("#define DFCS_INACTIVE 0x0100")]
    public const int DFCS_INACTIVE = 0x0100;

    [NativeTypeName("#define DFCS_PUSHED 0x0200")]
    public const int DFCS_PUSHED = 0x0200;

    [NativeTypeName("#define DFCS_CHECKED 0x0400")]
    public const int DFCS_CHECKED = 0x0400;

    [NativeTypeName("#define DFCS_TRANSPARENT 0x0800")]
    public const int DFCS_TRANSPARENT = 0x0800;

    [NativeTypeName("#define DFCS_HOT 0x1000")]
    public const int DFCS_HOT = 0x1000;

    [NativeTypeName("#define DFCS_ADJUSTRECT 0x2000")]
    public const int DFCS_ADJUSTRECT = 0x2000;

    [NativeTypeName("#define DFCS_FLAT 0x4000")]
    public const int DFCS_FLAT = 0x4000;

    [NativeTypeName("#define DFCS_MONO 0x8000")]
    public const int DFCS_MONO = 0x8000;
}
