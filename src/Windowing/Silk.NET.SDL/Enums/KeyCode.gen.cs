// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_keycode_L50_C9")]
    [NativeName("Name", "SDL_KeyCode")]
    public enum KeyCode : int
    {
        [NativeName("Name", "SDLK_UNKNOWN")]
        KUnknown = 0x0,
        [NativeName("Name", "SDLK_RETURN")]
        KReturn = 0xD,
        [NativeName("Name", "SDLK_ESCAPE")]
        KEscape = 0x1B,
        [NativeName("Name", "SDLK_BACKSPACE")]
        KBackspace = 0x8,
        [NativeName("Name", "SDLK_TAB")]
        KTab = 0x9,
        [NativeName("Name", "SDLK_SPACE")]
        KSpace = 0x20,
        [NativeName("Name", "SDLK_EXCLAIM")]
        KExclaim = 0x21,
        [NativeName("Name", "SDLK_QUOTEDBL")]
        KQuotedbl = 0x22,
        [NativeName("Name", "SDLK_HASH")]
        KHash = 0x23,
        [NativeName("Name", "SDLK_PERCENT")]
        KPercent = 0x25,
        [NativeName("Name", "SDLK_DOLLAR")]
        KDollar = 0x24,
        [NativeName("Name", "SDLK_AMPERSAND")]
        KAmpersand = 0x26,
        [NativeName("Name", "SDLK_QUOTE")]
        KQuote = 0x27,
        [NativeName("Name", "SDLK_LEFTPAREN")]
        KLeftparen = 0x28,
        [NativeName("Name", "SDLK_RIGHTPAREN")]
        KRightparen = 0x29,
        [NativeName("Name", "SDLK_ASTERISK")]
        KAsterisk = 0x2A,
        [NativeName("Name", "SDLK_PLUS")]
        KPlus = 0x2B,
        [NativeName("Name", "SDLK_COMMA")]
        KComma = 0x2C,
        [NativeName("Name", "SDLK_MINUS")]
        KMinus = 0x2D,
        [NativeName("Name", "SDLK_PERIOD")]
        KPeriod = 0x2E,
        [NativeName("Name", "SDLK_SLASH")]
        KSlash = 0x2F,
        [NativeName("Name", "SDLK_0")]
        K0 = 0x30,
        [NativeName("Name", "SDLK_1")]
        K1 = 0x31,
        [NativeName("Name", "SDLK_2")]
        K2 = 0x32,
        [NativeName("Name", "SDLK_3")]
        K3 = 0x33,
        [NativeName("Name", "SDLK_4")]
        K4 = 0x34,
        [NativeName("Name", "SDLK_5")]
        K5 = 0x35,
        [NativeName("Name", "SDLK_6")]
        K6 = 0x36,
        [NativeName("Name", "SDLK_7")]
        K7 = 0x37,
        [NativeName("Name", "SDLK_8")]
        K8 = 0x38,
        [NativeName("Name", "SDLK_9")]
        K9 = 0x39,
        [NativeName("Name", "SDLK_COLON")]
        KColon = 0x3A,
        [NativeName("Name", "SDLK_SEMICOLON")]
        KSemicolon = 0x3B,
        [NativeName("Name", "SDLK_LESS")]
        KLess = 0x3C,
        [NativeName("Name", "SDLK_EQUALS")]
        KEquals = 0x3D,
        [NativeName("Name", "SDLK_GREATER")]
        KGreater = 0x3E,
        [NativeName("Name", "SDLK_QUESTION")]
        KQuestion = 0x3F,
        [NativeName("Name", "SDLK_AT")]
        KAT = 0x40,
        [NativeName("Name", "SDLK_LEFTBRACKET")]
        KLeftbracket = 0x5B,
        [NativeName("Name", "SDLK_BACKSLASH")]
        KBackslash = 0x5C,
        [NativeName("Name", "SDLK_RIGHTBRACKET")]
        KRightbracket = 0x5D,
        [NativeName("Name", "SDLK_CARET")]
        KCaret = 0x5E,
        [NativeName("Name", "SDLK_UNDERSCORE")]
        KUnderscore = 0x5F,
        [NativeName("Name", "SDLK_BACKQUOTE")]
        KBackquote = 0x60,
        [NativeName("Name", "SDLK_a")]
        KA = 0x61,
        [NativeName("Name", "SDLK_b")]
        KB = 0x62,
        [NativeName("Name", "SDLK_c")]
        KC = 0x63,
        [NativeName("Name", "SDLK_d")]
        KD = 0x64,
        [NativeName("Name", "SDLK_e")]
        KE = 0x65,
        [NativeName("Name", "SDLK_f")]
        KF = 0x66,
        [NativeName("Name", "SDLK_g")]
        KG = 0x67,
        [NativeName("Name", "SDLK_h")]
        KH = 0x68,
        [NativeName("Name", "SDLK_i")]
        KI = 0x69,
        [NativeName("Name", "SDLK_j")]
        KJ = 0x6A,
        [NativeName("Name", "SDLK_k")]
        KK = 0x6B,
        [NativeName("Name", "SDLK_l")]
        KL = 0x6C,
        [NativeName("Name", "SDLK_m")]
        KM = 0x6D,
        [NativeName("Name", "SDLK_n")]
        KN = 0x6E,
        [NativeName("Name", "SDLK_o")]
        KO = 0x6F,
        [NativeName("Name", "SDLK_p")]
        KP = 0x70,
        [NativeName("Name", "SDLK_q")]
        KQ = 0x71,
        [NativeName("Name", "SDLK_r")]
        KR = 0x72,
        [NativeName("Name", "SDLK_s")]
        KS = 0x73,
        [NativeName("Name", "SDLK_t")]
        KT = 0x74,
        [NativeName("Name", "SDLK_u")]
        KU = 0x75,
        [NativeName("Name", "SDLK_v")]
        KV = 0x76,
        [NativeName("Name", "SDLK_w")]
        KW = 0x77,
        [NativeName("Name", "SDLK_x")]
        KX = 0x78,
        [NativeName("Name", "SDLK_y")]
        KY = 0x79,
        [NativeName("Name", "SDLK_z")]
        KZ = 0x7A,
        [NativeName("Name", "SDLK_CAPSLOCK")]
        KCapslock = 0x40000039,
        [NativeName("Name", "SDLK_F1")]
        KF1 = 0x4000003A,
        [NativeName("Name", "SDLK_F2")]
        KF2 = 0x4000003B,
        [NativeName("Name", "SDLK_F3")]
        KF3 = 0x4000003C,
        [NativeName("Name", "SDLK_F4")]
        KF4 = 0x4000003D,
        [NativeName("Name", "SDLK_F5")]
        KF5 = 0x4000003E,
        [NativeName("Name", "SDLK_F6")]
        KF6 = 0x4000003F,
        [NativeName("Name", "SDLK_F7")]
        KF7 = 0x40000040,
        [NativeName("Name", "SDLK_F8")]
        KF8 = 0x40000041,
        [NativeName("Name", "SDLK_F9")]
        KF9 = 0x40000042,
        [NativeName("Name", "SDLK_F10")]
        KF10 = 0x40000043,
        [NativeName("Name", "SDLK_F11")]
        KF11 = 0x40000044,
        [NativeName("Name", "SDLK_F12")]
        KF12 = 0x40000045,
        [NativeName("Name", "SDLK_PRINTSCREEN")]
        KPrintscreen = 0x40000046,
        [NativeName("Name", "SDLK_SCROLLLOCK")]
        KScrolllock = 0x40000047,
        [NativeName("Name", "SDLK_PAUSE")]
        KPause = 0x40000048,
        [NativeName("Name", "SDLK_INSERT")]
        KInsert = 0x40000049,
        [NativeName("Name", "SDLK_HOME")]
        KHome = 0x4000004A,
        [NativeName("Name", "SDLK_PAGEUP")]
        KPageup = 0x4000004B,
        [NativeName("Name", "SDLK_DELETE")]
        KDelete = 0x7F,
        [NativeName("Name", "SDLK_END")]
        KEnd = 0x4000004D,
        [NativeName("Name", "SDLK_PAGEDOWN")]
        KPagedown = 0x4000004E,
        [NativeName("Name", "SDLK_RIGHT")]
        KRight = 0x4000004F,
        [NativeName("Name", "SDLK_LEFT")]
        KLeft = 0x40000050,
        [NativeName("Name", "SDLK_DOWN")]
        KDown = 0x40000051,
        [NativeName("Name", "SDLK_UP")]
        KUp = 0x40000052,
        [NativeName("Name", "SDLK_NUMLOCKCLEAR")]
        KNumlockclear = 0x40000053,
        [NativeName("Name", "SDLK_KP_DIVIDE")]
        KKPDivide = 0x40000054,
        [NativeName("Name", "SDLK_KP_MULTIPLY")]
        KKPMultiply = 0x40000055,
        [NativeName("Name", "SDLK_KP_MINUS")]
        KKPMinus = 0x40000056,
        [NativeName("Name", "SDLK_KP_PLUS")]
        KKPPlus = 0x40000057,
        [NativeName("Name", "SDLK_KP_ENTER")]
        KKPEnter = 0x40000058,
        [NativeName("Name", "SDLK_KP_1")]
        KKP1 = 0x40000059,
        [NativeName("Name", "SDLK_KP_2")]
        KKP2 = 0x4000005A,
        [NativeName("Name", "SDLK_KP_3")]
        KKP3 = 0x4000005B,
        [NativeName("Name", "SDLK_KP_4")]
        KKP4 = 0x4000005C,
        [NativeName("Name", "SDLK_KP_5")]
        KKP5 = 0x4000005D,
        [NativeName("Name", "SDLK_KP_6")]
        KKP6 = 0x4000005E,
        [NativeName("Name", "SDLK_KP_7")]
        KKP7 = 0x4000005F,
        [NativeName("Name", "SDLK_KP_8")]
        KKP8 = 0x40000060,
        [NativeName("Name", "SDLK_KP_9")]
        KKP9 = 0x40000061,
        [NativeName("Name", "SDLK_KP_0")]
        KKP0 = 0x40000062,
        [NativeName("Name", "SDLK_KP_PERIOD")]
        KKPPeriod = 0x40000063,
        [NativeName("Name", "SDLK_APPLICATION")]
        KApplication = 0x40000065,
        [NativeName("Name", "SDLK_POWER")]
        KPower = 0x40000066,
        [NativeName("Name", "SDLK_KP_EQUALS")]
        KKPEquals = 0x40000067,
        [NativeName("Name", "SDLK_F13")]
        KF13 = 0x40000068,
        [NativeName("Name", "SDLK_F14")]
        KF14 = 0x40000069,
        [NativeName("Name", "SDLK_F15")]
        KF15 = 0x4000006A,
        [NativeName("Name", "SDLK_F16")]
        KF16 = 0x4000006B,
        [NativeName("Name", "SDLK_F17")]
        KF17 = 0x4000006C,
        [NativeName("Name", "SDLK_F18")]
        KF18 = 0x4000006D,
        [NativeName("Name", "SDLK_F19")]
        KF19 = 0x4000006E,
        [NativeName("Name", "SDLK_F20")]
        KF20 = 0x4000006F,
        [NativeName("Name", "SDLK_F21")]
        KF21 = 0x40000070,
        [NativeName("Name", "SDLK_F22")]
        KF22 = 0x40000071,
        [NativeName("Name", "SDLK_F23")]
        KF23 = 0x40000072,
        [NativeName("Name", "SDLK_F24")]
        KF24 = 0x40000073,
        [NativeName("Name", "SDLK_EXECUTE")]
        KExecute = 0x40000074,
        [NativeName("Name", "SDLK_HELP")]
        KHelp = 0x40000075,
        [NativeName("Name", "SDLK_MENU")]
        KMenu = 0x40000076,
        [NativeName("Name", "SDLK_SELECT")]
        KSelect = 0x40000077,
        [NativeName("Name", "SDLK_STOP")]
        KStop = 0x40000078,
        [NativeName("Name", "SDLK_AGAIN")]
        KAgain = 0x40000079,
        [NativeName("Name", "SDLK_UNDO")]
        KUndo = 0x4000007A,
        [NativeName("Name", "SDLK_CUT")]
        KCut = 0x4000007B,
        [NativeName("Name", "SDLK_COPY")]
        KCopy = 0x4000007C,
        [NativeName("Name", "SDLK_PASTE")]
        KPaste = 0x4000007D,
        [NativeName("Name", "SDLK_FIND")]
        KFind = 0x4000007E,
        [NativeName("Name", "SDLK_MUTE")]
        KMute = 0x4000007F,
        [NativeName("Name", "SDLK_VOLUMEUP")]
        KVolumeup = 0x40000080,
        [NativeName("Name", "SDLK_VOLUMEDOWN")]
        KVolumedown = 0x40000081,
        [NativeName("Name", "SDLK_KP_COMMA")]
        KKPComma = 0x40000085,
        [NativeName("Name", "SDLK_KP_EQUALSAS400")]
        KKPEqualsas400 = 0x40000086,
        [NativeName("Name", "SDLK_ALTERASE")]
        KAlterase = 0x40000099,
        [NativeName("Name", "SDLK_SYSREQ")]
        KSysreq = 0x4000009A,
        [NativeName("Name", "SDLK_CANCEL")]
        KCancel = 0x4000009B,
        [NativeName("Name", "SDLK_CLEAR")]
        KClear = 0x4000009C,
        [NativeName("Name", "SDLK_PRIOR")]
        KPrior = 0x4000009D,
        [NativeName("Name", "SDLK_RETURN2")]
        KReturn2 = 0x4000009E,
        [NativeName("Name", "SDLK_SEPARATOR")]
        KSeparator = 0x4000009F,
        [NativeName("Name", "SDLK_OUT")]
        KOut = 0x400000A0,
        [NativeName("Name", "SDLK_OPER")]
        KOper = 0x400000A1,
        [NativeName("Name", "SDLK_CLEARAGAIN")]
        KClearagain = 0x400000A2,
        [NativeName("Name", "SDLK_CRSEL")]
        KCrsel = 0x400000A3,
        [NativeName("Name", "SDLK_EXSEL")]
        KExsel = 0x400000A4,
        [NativeName("Name", "SDLK_KP_00")]
        KKP00 = 0x400000B0,
        [NativeName("Name", "SDLK_KP_000")]
        KKP000 = 0x400000B1,
        [NativeName("Name", "SDLK_THOUSANDSSEPARATOR")]
        KThousandsseparator = 0x400000B2,
        [NativeName("Name", "SDLK_DECIMALSEPARATOR")]
        KDecimalseparator = 0x400000B3,
        [NativeName("Name", "SDLK_CURRENCYUNIT")]
        KCurrencyunit = 0x400000B4,
        [NativeName("Name", "SDLK_CURRENCYSUBUNIT")]
        KCurrencysubunit = 0x400000B5,
        [NativeName("Name", "SDLK_KP_LEFTPAREN")]
        KKPLeftparen = 0x400000B6,
        [NativeName("Name", "SDLK_KP_RIGHTPAREN")]
        KKPRightparen = 0x400000B7,
        [NativeName("Name", "SDLK_KP_LEFTBRACE")]
        KKPLeftbrace = 0x400000B8,
        [NativeName("Name", "SDLK_KP_RIGHTBRACE")]
        KKPRightbrace = 0x400000B9,
        [NativeName("Name", "SDLK_KP_TAB")]
        KKPTab = 0x400000BA,
        [NativeName("Name", "SDLK_KP_BACKSPACE")]
        KKPBackspace = 0x400000BB,
        [NativeName("Name", "SDLK_KP_A")]
        KKPA = 0x400000BC,
        [NativeName("Name", "SDLK_KP_B")]
        KKPB = 0x400000BD,
        [NativeName("Name", "SDLK_KP_C")]
        KKPC = 0x400000BE,
        [NativeName("Name", "SDLK_KP_D")]
        KKPD = 0x400000BF,
        [NativeName("Name", "SDLK_KP_E")]
        KKPE = 0x400000C0,
        [NativeName("Name", "SDLK_KP_F")]
        KKPF = 0x400000C1,
        [NativeName("Name", "SDLK_KP_XOR")]
        KKPXor = 0x400000C2,
        [NativeName("Name", "SDLK_KP_POWER")]
        KKPPower = 0x400000C3,
        [NativeName("Name", "SDLK_KP_PERCENT")]
        KKPPercent = 0x400000C4,
        [NativeName("Name", "SDLK_KP_LESS")]
        KKPLess = 0x400000C5,
        [NativeName("Name", "SDLK_KP_GREATER")]
        KKPGreater = 0x400000C6,
        [NativeName("Name", "SDLK_KP_AMPERSAND")]
        KKPAmpersand = 0x400000C7,
        [NativeName("Name", "SDLK_KP_DBLAMPERSAND")]
        KKPDblampersand = 0x400000C8,
        [NativeName("Name", "SDLK_KP_VERTICALBAR")]
        KKPVerticalbar = 0x400000C9,
        [NativeName("Name", "SDLK_KP_DBLVERTICALBAR")]
        KKPDblverticalbar = 0x400000CA,
        [NativeName("Name", "SDLK_KP_COLON")]
        KKPColon = 0x400000CB,
        [NativeName("Name", "SDLK_KP_HASH")]
        KKPHash = 0x400000CC,
        [NativeName("Name", "SDLK_KP_SPACE")]
        KKPSpace = 0x400000CD,
        [NativeName("Name", "SDLK_KP_AT")]
        KKPAT = 0x400000CE,
        [NativeName("Name", "SDLK_KP_EXCLAM")]
        KKPExclam = 0x400000CF,
        [NativeName("Name", "SDLK_KP_MEMSTORE")]
        KKPMemstore = 0x400000D0,
        [NativeName("Name", "SDLK_KP_MEMRECALL")]
        KKPMemrecall = 0x400000D1,
        [NativeName("Name", "SDLK_KP_MEMCLEAR")]
        KKPMemclear = 0x400000D2,
        [NativeName("Name", "SDLK_KP_MEMADD")]
        KKPMemadd = 0x400000D3,
        [NativeName("Name", "SDLK_KP_MEMSUBTRACT")]
        KKPMemsubtract = 0x400000D4,
        [NativeName("Name", "SDLK_KP_MEMMULTIPLY")]
        KKPMemmultiply = 0x400000D5,
        [NativeName("Name", "SDLK_KP_MEMDIVIDE")]
        KKPMemdivide = 0x400000D6,
        [NativeName("Name", "SDLK_KP_PLUSMINUS")]
        KKPPlusminus = 0x400000D7,
        [NativeName("Name", "SDLK_KP_CLEAR")]
        KKPClear = 0x400000D8,
        [NativeName("Name", "SDLK_KP_CLEARENTRY")]
        KKPClearentry = 0x400000D9,
        [NativeName("Name", "SDLK_KP_BINARY")]
        KKPBinary = 0x400000DA,
        [NativeName("Name", "SDLK_KP_OCTAL")]
        KKPOctal = 0x400000DB,
        [NativeName("Name", "SDLK_KP_DECIMAL")]
        KKPDecimal = 0x400000DC,
        [NativeName("Name", "SDLK_KP_HEXADECIMAL")]
        KKPHexadecimal = 0x400000DD,
        [NativeName("Name", "SDLK_LCTRL")]
        KLctrl = 0x400000E0,
        [NativeName("Name", "SDLK_LSHIFT")]
        KLshift = 0x400000E1,
        [NativeName("Name", "SDLK_LALT")]
        KLalt = 0x400000E2,
        [NativeName("Name", "SDLK_LGUI")]
        KLgui = 0x400000E3,
        [NativeName("Name", "SDLK_RCTRL")]
        KRctrl = 0x400000E4,
        [NativeName("Name", "SDLK_RSHIFT")]
        KRshift = 0x400000E5,
        [NativeName("Name", "SDLK_RALT")]
        KRalt = 0x400000E6,
        [NativeName("Name", "SDLK_RGUI")]
        KRgui = 0x400000E7,
        [NativeName("Name", "SDLK_MODE")]
        KMode = 0x40000101,
        [NativeName("Name", "SDLK_AUDIONEXT")]
        KAudionext = 0x40000102,
        [NativeName("Name", "SDLK_AUDIOPREV")]
        KAudioprev = 0x40000103,
        [NativeName("Name", "SDLK_AUDIOSTOP")]
        KAudiostop = 0x40000104,
        [NativeName("Name", "SDLK_AUDIOPLAY")]
        KAudioplay = 0x40000105,
        [NativeName("Name", "SDLK_AUDIOMUTE")]
        KAudiomute = 0x40000106,
        [NativeName("Name", "SDLK_MEDIASELECT")]
        KMediaselect = 0x40000107,
        [NativeName("Name", "SDLK_WWW")]
        KWww = 0x40000108,
        [NativeName("Name", "SDLK_MAIL")]
        KMail = 0x40000109,
        [NativeName("Name", "SDLK_CALCULATOR")]
        KCalculator = 0x4000010A,
        [NativeName("Name", "SDLK_COMPUTER")]
        KComputer = 0x4000010B,
        [NativeName("Name", "SDLK_AC_SEARCH")]
        KACSearch = 0x4000010C,
        [NativeName("Name", "SDLK_AC_HOME")]
        KACHome = 0x4000010D,
        [NativeName("Name", "SDLK_AC_BACK")]
        KACBack = 0x4000010E,
        [NativeName("Name", "SDLK_AC_FORWARD")]
        KACForward = 0x4000010F,
        [NativeName("Name", "SDLK_AC_STOP")]
        KACStop = 0x40000110,
        [NativeName("Name", "SDLK_AC_REFRESH")]
        KACRefresh = 0x40000111,
        [NativeName("Name", "SDLK_AC_BOOKMARKS")]
        KACBookmarks = 0x40000112,
        [NativeName("Name", "SDLK_BRIGHTNESSDOWN")]
        KBrightnessdown = 0x40000113,
        [NativeName("Name", "SDLK_BRIGHTNESSUP")]
        KBrightnessup = 0x40000114,
        [NativeName("Name", "SDLK_DISPLAYSWITCH")]
        KDisplayswitch = 0x40000115,
        [NativeName("Name", "SDLK_KBDILLUMTOGGLE")]
        KKbdillumtoggle = 0x40000116,
        [NativeName("Name", "SDLK_KBDILLUMDOWN")]
        KKbdillumdown = 0x40000117,
        [NativeName("Name", "SDLK_KBDILLUMUP")]
        KKbdillumup = 0x40000118,
        [NativeName("Name", "SDLK_EJECT")]
        KEject = 0x40000119,
        [NativeName("Name", "SDLK_SLEEP")]
        KSleep = 0x4000011A,
        [NativeName("Name", "SDLK_APP1")]
        KApp1 = 0x4000011B,
        [NativeName("Name", "SDLK_APP2")]
        KApp2 = 0x4000011C,
        [NativeName("Name", "SDLK_AUDIOREWIND")]
        KAudiorewind = 0x4000011D,
        [NativeName("Name", "SDLK_AUDIOFASTFORWARD")]
        KAudiofastforward = 0x4000011E,
        [NativeName("Name", "SDLK_SOFTLEFT")]
        KSoftleft = 0x4000011F,
        [NativeName("Name", "SDLK_SOFTRIGHT")]
        KSoftright = 0x40000120,
        [NativeName("Name", "SDLK_CALL")]
        KCall = 0x40000121,
        [NativeName("Name", "SDLK_ENDCALL")]
        KEndcall = 0x40000122,
    }
}
