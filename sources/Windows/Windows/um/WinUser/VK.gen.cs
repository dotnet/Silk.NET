// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class VK
{
    [NativeTypeName("#define VK_LBUTTON 0x01")]
    public const int VK_LBUTTON = 0x01;
    [NativeTypeName("#define VK_RBUTTON 0x02")]
    public const int VK_RBUTTON = 0x02;
    [NativeTypeName("#define VK_CANCEL 0x03")]
    public const int VK_CANCEL = 0x03;
    [NativeTypeName("#define VK_MBUTTON 0x04")]
    public const int VK_MBUTTON = 0x04;
    [NativeTypeName("#define VK_XBUTTON1 0x05")]
    public const int VK_XBUTTON1 = 0x05;
    [NativeTypeName("#define VK_XBUTTON2 0x06")]
    public const int VK_XBUTTON2 = 0x06;
    [NativeTypeName("#define VK_BACK 0x08")]
    public const int VK_BACK = 0x08;
    [NativeTypeName("#define VK_TAB 0x09")]
    public const int VK_TAB = 0x09;
    [NativeTypeName("#define VK_CLEAR 0x0C")]
    public const int VK_CLEAR = 0x0C;
    [NativeTypeName("#define VK_RETURN 0x0D")]
    public const int VK_RETURN = 0x0D;
    [NativeTypeName("#define VK_SHIFT 0x10")]
    public const int VK_SHIFT = 0x10;
    [NativeTypeName("#define VK_CONTROL 0x11")]
    public const int VK_CONTROL = 0x11;
    [NativeTypeName("#define VK_MENU 0x12")]
    public const int VK_MENU = 0x12;
    [NativeTypeName("#define VK_PAUSE 0x13")]
    public const int VK_PAUSE = 0x13;
    [NativeTypeName("#define VK_CAPITAL 0x14")]
    public const int VK_CAPITAL = 0x14;
    [NativeTypeName("#define VK_KANA 0x15")]
    public const int VK_KANA = 0x15;
    [NativeTypeName("#define VK_HANGEUL 0x15")]
    public const int VK_HANGEUL = 0x15;
    [NativeTypeName("#define VK_HANGUL 0x15")]
    public const int VK_HANGUL = 0x15;
    [NativeTypeName("#define VK_IME_ON 0x16")]
    public const int VK_IME_ON = 0x16;
    [NativeTypeName("#define VK_JUNJA 0x17")]
    public const int VK_JUNJA = 0x17;
    [NativeTypeName("#define VK_FINAL 0x18")]
    public const int VK_FINAL = 0x18;
    [NativeTypeName("#define VK_HANJA 0x19")]
    public const int VK_HANJA = 0x19;
    [NativeTypeName("#define VK_KANJI 0x19")]
    public const int VK_KANJI = 0x19;
    [NativeTypeName("#define VK_IME_OFF 0x1A")]
    public const int VK_IME_OFF = 0x1A;
    [NativeTypeName("#define VK_ESCAPE 0x1B")]
    public const int VK_ESCAPE = 0x1B;
    [NativeTypeName("#define VK_CONVERT 0x1C")]
    public const int VK_CONVERT = 0x1C;
    [NativeTypeName("#define VK_NONCONVERT 0x1D")]
    public const int VK_NONCONVERT = 0x1D;
    [NativeTypeName("#define VK_ACCEPT 0x1E")]
    public const int VK_ACCEPT = 0x1E;
    [NativeTypeName("#define VK_MODECHANGE 0x1F")]
    public const int VK_MODECHANGE = 0x1F;
    [NativeTypeName("#define VK_SPACE 0x20")]
    public const int VK_SPACE = 0x20;
    [NativeTypeName("#define VK_PRIOR 0x21")]
    public const int VK_PRIOR = 0x21;
    [NativeTypeName("#define VK_NEXT 0x22")]
    public const int VK_NEXT = 0x22;
    [NativeTypeName("#define VK_END 0x23")]
    public const int VK_END = 0x23;
    [NativeTypeName("#define VK_HOME 0x24")]
    public const int VK_HOME = 0x24;
    [NativeTypeName("#define VK_LEFT 0x25")]
    public const int VK_LEFT = 0x25;
    [NativeTypeName("#define VK_UP 0x26")]
    public const int VK_UP = 0x26;
    [NativeTypeName("#define VK_RIGHT 0x27")]
    public const int VK_RIGHT = 0x27;
    [NativeTypeName("#define VK_DOWN 0x28")]
    public const int VK_DOWN = 0x28;
    [NativeTypeName("#define VK_SELECT 0x29")]
    public const int VK_SELECT = 0x29;
    [NativeTypeName("#define VK_PRINT 0x2A")]
    public const int VK_PRINT = 0x2A;
    [NativeTypeName("#define VK_EXECUTE 0x2B")]
    public const int VK_EXECUTE = 0x2B;
    [NativeTypeName("#define VK_SNAPSHOT 0x2C")]
    public const int VK_SNAPSHOT = 0x2C;
    [NativeTypeName("#define VK_INSERT 0x2D")]
    public const int VK_INSERT = 0x2D;
    [NativeTypeName("#define VK_DELETE 0x2E")]
    public const int VK_DELETE = 0x2E;
    [NativeTypeName("#define VK_HELP 0x2F")]
    public const int VK_HELP = 0x2F;
    [NativeTypeName("#define VK_LWIN 0x5B")]
    public const int VK_LWIN = 0x5B;
    [NativeTypeName("#define VK_RWIN 0x5C")]
    public const int VK_RWIN = 0x5C;
    [NativeTypeName("#define VK_APPS 0x5D")]
    public const int VK_APPS = 0x5D;
    [NativeTypeName("#define VK_SLEEP 0x5F")]
    public const int VK_SLEEP = 0x5F;
    [NativeTypeName("#define VK_NUMPAD0 0x60")]
    public const int VK_NUMPAD0 = 0x60;
    [NativeTypeName("#define VK_NUMPAD1 0x61")]
    public const int VK_NUMPAD1 = 0x61;
    [NativeTypeName("#define VK_NUMPAD2 0x62")]
    public const int VK_NUMPAD2 = 0x62;
    [NativeTypeName("#define VK_NUMPAD3 0x63")]
    public const int VK_NUMPAD3 = 0x63;
    [NativeTypeName("#define VK_NUMPAD4 0x64")]
    public const int VK_NUMPAD4 = 0x64;
    [NativeTypeName("#define VK_NUMPAD5 0x65")]
    public const int VK_NUMPAD5 = 0x65;
    [NativeTypeName("#define VK_NUMPAD6 0x66")]
    public const int VK_NUMPAD6 = 0x66;
    [NativeTypeName("#define VK_NUMPAD7 0x67")]
    public const int VK_NUMPAD7 = 0x67;
    [NativeTypeName("#define VK_NUMPAD8 0x68")]
    public const int VK_NUMPAD8 = 0x68;
    [NativeTypeName("#define VK_NUMPAD9 0x69")]
    public const int VK_NUMPAD9 = 0x69;
    [NativeTypeName("#define VK_MULTIPLY 0x6A")]
    public const int VK_MULTIPLY = 0x6A;
    [NativeTypeName("#define VK_ADD 0x6B")]
    public const int VK_ADD = 0x6B;
    [NativeTypeName("#define VK_SEPARATOR 0x6C")]
    public const int VK_SEPARATOR = 0x6C;
    [NativeTypeName("#define VK_SUBTRACT 0x6D")]
    public const int VK_SUBTRACT = 0x6D;
    [NativeTypeName("#define VK_DECIMAL 0x6E")]
    public const int VK_DECIMAL = 0x6E;
    [NativeTypeName("#define VK_DIVIDE 0x6F")]
    public const int VK_DIVIDE = 0x6F;
    [NativeTypeName("#define VK_F1 0x70")]
    public const int VK_F1 = 0x70;
    [NativeTypeName("#define VK_F2 0x71")]
    public const int VK_F2 = 0x71;
    [NativeTypeName("#define VK_F3 0x72")]
    public const int VK_F3 = 0x72;
    [NativeTypeName("#define VK_F4 0x73")]
    public const int VK_F4 = 0x73;
    [NativeTypeName("#define VK_F5 0x74")]
    public const int VK_F5 = 0x74;
    [NativeTypeName("#define VK_F6 0x75")]
    public const int VK_F6 = 0x75;
    [NativeTypeName("#define VK_F7 0x76")]
    public const int VK_F7 = 0x76;
    [NativeTypeName("#define VK_F8 0x77")]
    public const int VK_F8 = 0x77;
    [NativeTypeName("#define VK_F9 0x78")]
    public const int VK_F9 = 0x78;
    [NativeTypeName("#define VK_F10 0x79")]
    public const int VK_F10 = 0x79;
    [NativeTypeName("#define VK_F11 0x7A")]
    public const int VK_F11 = 0x7A;
    [NativeTypeName("#define VK_F12 0x7B")]
    public const int VK_F12 = 0x7B;
    [NativeTypeName("#define VK_F13 0x7C")]
    public const int VK_F13 = 0x7C;
    [NativeTypeName("#define VK_F14 0x7D")]
    public const int VK_F14 = 0x7D;
    [NativeTypeName("#define VK_F15 0x7E")]
    public const int VK_F15 = 0x7E;
    [NativeTypeName("#define VK_F16 0x7F")]
    public const int VK_F16 = 0x7F;
    [NativeTypeName("#define VK_F17 0x80")]
    public const int VK_F17 = 0x80;
    [NativeTypeName("#define VK_F18 0x81")]
    public const int VK_F18 = 0x81;
    [NativeTypeName("#define VK_F19 0x82")]
    public const int VK_F19 = 0x82;
    [NativeTypeName("#define VK_F20 0x83")]
    public const int VK_F20 = 0x83;
    [NativeTypeName("#define VK_F21 0x84")]
    public const int VK_F21 = 0x84;
    [NativeTypeName("#define VK_F22 0x85")]
    public const int VK_F22 = 0x85;
    [NativeTypeName("#define VK_F23 0x86")]
    public const int VK_F23 = 0x86;
    [NativeTypeName("#define VK_F24 0x87")]
    public const int VK_F24 = 0x87;
    [NativeTypeName("#define VK_NAVIGATION_VIEW 0x88")]
    public const int VK_NAVIGATION_VIEW = 0x88;
    [NativeTypeName("#define VK_NAVIGATION_MENU 0x89")]
    public const int VK_NAVIGATION_MENU = 0x89;
    [NativeTypeName("#define VK_NAVIGATION_UP 0x8A")]
    public const int VK_NAVIGATION_UP = 0x8A;
    [NativeTypeName("#define VK_NAVIGATION_DOWN 0x8B")]
    public const int VK_NAVIGATION_DOWN = 0x8B;
    [NativeTypeName("#define VK_NAVIGATION_LEFT 0x8C")]
    public const int VK_NAVIGATION_LEFT = 0x8C;
    [NativeTypeName("#define VK_NAVIGATION_RIGHT 0x8D")]
    public const int VK_NAVIGATION_RIGHT = 0x8D;
    [NativeTypeName("#define VK_NAVIGATION_ACCEPT 0x8E")]
    public const int VK_NAVIGATION_ACCEPT = 0x8E;
    [NativeTypeName("#define VK_NAVIGATION_CANCEL 0x8F")]
    public const int VK_NAVIGATION_CANCEL = 0x8F;
    [NativeTypeName("#define VK_NUMLOCK 0x90")]
    public const int VK_NUMLOCK = 0x90;
    [NativeTypeName("#define VK_SCROLL 0x91")]
    public const int VK_SCROLL = 0x91;
    [NativeTypeName("#define VK_OEM_NEC_EQUAL 0x92")]
    public const int VK_OEM_NEC_EQUAL = 0x92;
    [NativeTypeName("#define VK_OEM_FJ_JISHO 0x92")]
    public const int VK_OEM_FJ_JISHO = 0x92;
    [NativeTypeName("#define VK_OEM_FJ_MASSHOU 0x93")]
    public const int VK_OEM_FJ_MASSHOU = 0x93;
    [NativeTypeName("#define VK_OEM_FJ_TOUROKU 0x94")]
    public const int VK_OEM_FJ_TOUROKU = 0x94;
    [NativeTypeName("#define VK_OEM_FJ_LOYA 0x95")]
    public const int VK_OEM_FJ_LOYA = 0x95;
    [NativeTypeName("#define VK_OEM_FJ_ROYA 0x96")]
    public const int VK_OEM_FJ_ROYA = 0x96;
    [NativeTypeName("#define VK_LSHIFT 0xA0")]
    public const int VK_LSHIFT = 0xA0;
    [NativeTypeName("#define VK_RSHIFT 0xA1")]
    public const int VK_RSHIFT = 0xA1;
    [NativeTypeName("#define VK_LCONTROL 0xA2")]
    public const int VK_LCONTROL = 0xA2;
    [NativeTypeName("#define VK_RCONTROL 0xA3")]
    public const int VK_RCONTROL = 0xA3;
    [NativeTypeName("#define VK_LMENU 0xA4")]
    public const int VK_LMENU = 0xA4;
    [NativeTypeName("#define VK_RMENU 0xA5")]
    public const int VK_RMENU = 0xA5;
    [NativeTypeName("#define VK_BROWSER_BACK 0xA6")]
    public const int VK_BROWSER_BACK = 0xA6;
    [NativeTypeName("#define VK_BROWSER_FORWARD 0xA7")]
    public const int VK_BROWSER_FORWARD = 0xA7;
    [NativeTypeName("#define VK_BROWSER_REFRESH 0xA8")]
    public const int VK_BROWSER_REFRESH = 0xA8;
    [NativeTypeName("#define VK_BROWSER_STOP 0xA9")]
    public const int VK_BROWSER_STOP = 0xA9;
    [NativeTypeName("#define VK_BROWSER_SEARCH 0xAA")]
    public const int VK_BROWSER_SEARCH = 0xAA;
    [NativeTypeName("#define VK_BROWSER_FAVORITES 0xAB")]
    public const int VK_BROWSER_FAVORITES = 0xAB;
    [NativeTypeName("#define VK_BROWSER_HOME 0xAC")]
    public const int VK_BROWSER_HOME = 0xAC;
    [NativeTypeName("#define VK_VOLUME_MUTE 0xAD")]
    public const int VK_VOLUME_MUTE = 0xAD;
    [NativeTypeName("#define VK_VOLUME_DOWN 0xAE")]
    public const int VK_VOLUME_DOWN = 0xAE;
    [NativeTypeName("#define VK_VOLUME_UP 0xAF")]
    public const int VK_VOLUME_UP = 0xAF;
    [NativeTypeName("#define VK_MEDIA_NEXT_TRACK 0xB0")]
    public const int VK_MEDIA_NEXT_TRACK = 0xB0;
    [NativeTypeName("#define VK_MEDIA_PREV_TRACK 0xB1")]
    public const int VK_MEDIA_PREV_TRACK = 0xB1;
    [NativeTypeName("#define VK_MEDIA_STOP 0xB2")]
    public const int VK_MEDIA_STOP = 0xB2;
    [NativeTypeName("#define VK_MEDIA_PLAY_PAUSE 0xB3")]
    public const int VK_MEDIA_PLAY_PAUSE = 0xB3;
    [NativeTypeName("#define VK_LAUNCH_MAIL 0xB4")]
    public const int VK_LAUNCH_MAIL = 0xB4;
    [NativeTypeName("#define VK_LAUNCH_MEDIA_SELECT 0xB5")]
    public const int VK_LAUNCH_MEDIA_SELECT = 0xB5;
    [NativeTypeName("#define VK_LAUNCH_APP1 0xB6")]
    public const int VK_LAUNCH_APP1 = 0xB6;
    [NativeTypeName("#define VK_LAUNCH_APP2 0xB7")]
    public const int VK_LAUNCH_APP2 = 0xB7;
    [NativeTypeName("#define VK_OEM_1 0xBA")]
    public const int VK_OEM_1 = 0xBA;
    [NativeTypeName("#define VK_OEM_PLUS 0xBB")]
    public const int VK_OEM_PLUS = 0xBB;
    [NativeTypeName("#define VK_OEM_COMMA 0xBC")]
    public const int VK_OEM_COMMA = 0xBC;
    [NativeTypeName("#define VK_OEM_MINUS 0xBD")]
    public const int VK_OEM_MINUS = 0xBD;
    [NativeTypeName("#define VK_OEM_PERIOD 0xBE")]
    public const int VK_OEM_PERIOD = 0xBE;
    [NativeTypeName("#define VK_OEM_2 0xBF")]
    public const int VK_OEM_2 = 0xBF;
    [NativeTypeName("#define VK_OEM_3 0xC0")]
    public const int VK_OEM_3 = 0xC0;
    [NativeTypeName("#define VK_GAMEPAD_A 0xC3")]
    public const int VK_GAMEPAD_A = 0xC3;
    [NativeTypeName("#define VK_GAMEPAD_B 0xC4")]
    public const int VK_GAMEPAD_B = 0xC4;
    [NativeTypeName("#define VK_GAMEPAD_X 0xC5")]
    public const int VK_GAMEPAD_X = 0xC5;
    [NativeTypeName("#define VK_GAMEPAD_Y 0xC6")]
    public const int VK_GAMEPAD_Y = 0xC6;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_SHOULDER 0xC7")]
    public const int VK_GAMEPAD_RIGHT_SHOULDER = 0xC7;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_SHOULDER 0xC8")]
    public const int VK_GAMEPAD_LEFT_SHOULDER = 0xC8;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_TRIGGER 0xC9")]
    public const int VK_GAMEPAD_LEFT_TRIGGER = 0xC9;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_TRIGGER 0xCA")]
    public const int VK_GAMEPAD_RIGHT_TRIGGER = 0xCA;
    [NativeTypeName("#define VK_GAMEPAD_DPAD_UP 0xCB")]
    public const int VK_GAMEPAD_DPAD_UP = 0xCB;
    [NativeTypeName("#define VK_GAMEPAD_DPAD_DOWN 0xCC")]
    public const int VK_GAMEPAD_DPAD_DOWN = 0xCC;
    [NativeTypeName("#define VK_GAMEPAD_DPAD_LEFT 0xCD")]
    public const int VK_GAMEPAD_DPAD_LEFT = 0xCD;
    [NativeTypeName("#define VK_GAMEPAD_DPAD_RIGHT 0xCE")]
    public const int VK_GAMEPAD_DPAD_RIGHT = 0xCE;
    [NativeTypeName("#define VK_GAMEPAD_MENU 0xCF")]
    public const int VK_GAMEPAD_MENU = 0xCF;
    [NativeTypeName("#define VK_GAMEPAD_VIEW 0xD0")]
    public const int VK_GAMEPAD_VIEW = 0xD0;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON 0xD1")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON = 0xD1;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON 0xD2")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON = 0xD2;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_UP 0xD3")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_UP = 0xD3;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_DOWN 0xD4")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_DOWN = 0xD4;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT 0xD5")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT = 0xD5;
    [NativeTypeName("#define VK_GAMEPAD_LEFT_THUMBSTICK_LEFT 0xD6")]
    public const int VK_GAMEPAD_LEFT_THUMBSTICK_LEFT = 0xD6;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_UP 0xD7")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_UP = 0xD7;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN 0xD8")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN = 0xD8;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT 0xD9")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT = 0xD9;
    [NativeTypeName("#define VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT 0xDA")]
    public const int VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT = 0xDA;
    [NativeTypeName("#define VK_OEM_4 0xDB")]
    public const int VK_OEM_4 = 0xDB;
    [NativeTypeName("#define VK_OEM_5 0xDC")]
    public const int VK_OEM_5 = 0xDC;
    [NativeTypeName("#define VK_OEM_6 0xDD")]
    public const int VK_OEM_6 = 0xDD;
    [NativeTypeName("#define VK_OEM_7 0xDE")]
    public const int VK_OEM_7 = 0xDE;
    [NativeTypeName("#define VK_OEM_8 0xDF")]
    public const int VK_OEM_8 = 0xDF;
    [NativeTypeName("#define VK_OEM_AX 0xE1")]
    public const int VK_OEM_AX = 0xE1;
    [NativeTypeName("#define VK_OEM_102 0xE2")]
    public const int VK_OEM_102 = 0xE2;
    [NativeTypeName("#define VK_ICO_HELP 0xE3")]
    public const int VK_ICO_HELP = 0xE3;
    [NativeTypeName("#define VK_ICO_00 0xE4")]
    public const int VK_ICO_00 = 0xE4;
    [NativeTypeName("#define VK_PROCESSKEY 0xE5")]
    public const int VK_PROCESSKEY = 0xE5;
    [NativeTypeName("#define VK_ICO_CLEAR 0xE6")]
    public const int VK_ICO_CLEAR = 0xE6;
    [NativeTypeName("#define VK_PACKET 0xE7")]
    public const int VK_PACKET = 0xE7;
    [NativeTypeName("#define VK_OEM_RESET 0xE9")]
    public const int VK_OEM_RESET = 0xE9;
    [NativeTypeName("#define VK_OEM_JUMP 0xEA")]
    public const int VK_OEM_JUMP = 0xEA;
    [NativeTypeName("#define VK_OEM_PA1 0xEB")]
    public const int VK_OEM_PA1 = 0xEB;
    [NativeTypeName("#define VK_OEM_PA2 0xEC")]
    public const int VK_OEM_PA2 = 0xEC;
    [NativeTypeName("#define VK_OEM_PA3 0xED")]
    public const int VK_OEM_PA3 = 0xED;
    [NativeTypeName("#define VK_OEM_WSCTRL 0xEE")]
    public const int VK_OEM_WSCTRL = 0xEE;
    [NativeTypeName("#define VK_OEM_CUSEL 0xEF")]
    public const int VK_OEM_CUSEL = 0xEF;
    [NativeTypeName("#define VK_OEM_ATTN 0xF0")]
    public const int VK_OEM_ATTN = 0xF0;
    [NativeTypeName("#define VK_OEM_FINISH 0xF1")]
    public const int VK_OEM_FINISH = 0xF1;
    [NativeTypeName("#define VK_OEM_COPY 0xF2")]
    public const int VK_OEM_COPY = 0xF2;
    [NativeTypeName("#define VK_OEM_AUTO 0xF3")]
    public const int VK_OEM_AUTO = 0xF3;
    [NativeTypeName("#define VK_OEM_ENLW 0xF4")]
    public const int VK_OEM_ENLW = 0xF4;
    [NativeTypeName("#define VK_OEM_BACKTAB 0xF5")]
    public const int VK_OEM_BACKTAB = 0xF5;
    [NativeTypeName("#define VK_ATTN 0xF6")]
    public const int VK_ATTN = 0xF6;
    [NativeTypeName("#define VK_CRSEL 0xF7")]
    public const int VK_CRSEL = 0xF7;
    [NativeTypeName("#define VK_EXSEL 0xF8")]
    public const int VK_EXSEL = 0xF8;
    [NativeTypeName("#define VK_EREOF 0xF9")]
    public const int VK_EREOF = 0xF9;
    [NativeTypeName("#define VK_PLAY 0xFA")]
    public const int VK_PLAY = 0xFA;
    [NativeTypeName("#define VK_ZOOM 0xFB")]
    public const int VK_ZOOM = 0xFB;
    [NativeTypeName("#define VK_NONAME 0xFC")]
    public const int VK_NONAME = 0xFC;
    [NativeTypeName("#define VK_PA1 0xFD")]
    public const int VK_PA1 = 0xFD;
    [NativeTypeName("#define VK_OEM_CLEAR 0xFE")]
    public const int VK_OEM_CLEAR = 0xFE;
}