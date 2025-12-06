// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Scancode")]
public enum Scancode : uint
{
    [NativeName("SDL_SCANCODE_UNKNOWN")]
    ScancodeUnknown = 0,

    [NativeName("SDL_SCANCODE_A")]
    ScancodeA = 4,

    [NativeName("SDL_SCANCODE_B")]
    ScancodeB = 5,

    [NativeName("SDL_SCANCODE_C")]
    ScancodeC = 6,

    [NativeName("SDL_SCANCODE_D")]
    ScancodeD = 7,

    [NativeName("SDL_SCANCODE_E")]
    ScancodeE = 8,

    [NativeName("SDL_SCANCODE_F")]
    ScancodeF = 9,

    [NativeName("SDL_SCANCODE_G")]
    ScancodeG = 10,

    [NativeName("SDL_SCANCODE_H")]
    ScancodeH = 11,

    [NativeName("SDL_SCANCODE_I")]
    ScancodeI = 12,

    [NativeName("SDL_SCANCODE_J")]
    ScancodeJ = 13,

    [NativeName("SDL_SCANCODE_K")]
    ScancodeK = 14,

    [NativeName("SDL_SCANCODE_L")]
    ScancodeL = 15,

    [NativeName("SDL_SCANCODE_M")]
    ScancodeM = 16,

    [NativeName("SDL_SCANCODE_N")]
    ScancodeN = 17,

    [NativeName("SDL_SCANCODE_O")]
    ScancodeO = 18,

    [NativeName("SDL_SCANCODE_P")]
    ScancodeP = 19,

    [NativeName("SDL_SCANCODE_Q")]
    ScancodeQ = 20,

    [NativeName("SDL_SCANCODE_R")]
    ScancodeR = 21,

    [NativeName("SDL_SCANCODE_S")]
    ScancodeS = 22,

    [NativeName("SDL_SCANCODE_T")]
    ScancodeT = 23,

    [NativeName("SDL_SCANCODE_U")]
    ScancodeU = 24,

    [NativeName("SDL_SCANCODE_V")]
    ScancodeV = 25,

    [NativeName("SDL_SCANCODE_W")]
    ScancodeW = 26,

    [NativeName("SDL_SCANCODE_X")]
    ScancodeX = 27,

    [NativeName("SDL_SCANCODE_Y")]
    ScancodeY = 28,

    [NativeName("SDL_SCANCODE_Z")]
    ScancodeZ = 29,

    [NativeName("SDL_SCANCODE_1")]
    Scancode1 = 30,

    [NativeName("SDL_SCANCODE_2")]
    Scancode2 = 31,

    [NativeName("SDL_SCANCODE_3")]
    Scancode3 = 32,

    [NativeName("SDL_SCANCODE_4")]
    Scancode4 = 33,

    [NativeName("SDL_SCANCODE_5")]
    Scancode5 = 34,

    [NativeName("SDL_SCANCODE_6")]
    Scancode6 = 35,

    [NativeName("SDL_SCANCODE_7")]
    Scancode7 = 36,

    [NativeName("SDL_SCANCODE_8")]
    Scancode8 = 37,

    [NativeName("SDL_SCANCODE_9")]
    Scancode9 = 38,

    [NativeName("SDL_SCANCODE_0")]
    Scancode0 = 39,

    [NativeName("SDL_SCANCODE_RETURN")]
    ScancodeReturn = 40,

    [NativeName("SDL_SCANCODE_ESCAPE")]
    ScancodeEscape = 41,

    [NativeName("SDL_SCANCODE_BACKSPACE")]
    ScancodeBackspace = 42,

    [NativeName("SDL_SCANCODE_TAB")]
    ScancodeTab = 43,

    [NativeName("SDL_SCANCODE_SPACE")]
    ScancodeSpace = 44,

    [NativeName("SDL_SCANCODE_MINUS")]
    ScancodeMinus = 45,

    [NativeName("SDL_SCANCODE_EQUALS")]
    ScancodeEquals = 46,

    [NativeName("SDL_SCANCODE_LEFTBRACKET")]
    ScancodeLeftbracket = 47,

    [NativeName("SDL_SCANCODE_RIGHTBRACKET")]
    ScancodeRightbracket = 48,

    [NativeName("SDL_SCANCODE_BACKSLASH")]
    ScancodeBackslash = 49,

    [NativeName("SDL_SCANCODE_NONUSHASH")]
    ScancodeNonushash = 50,

    [NativeName("SDL_SCANCODE_SEMICOLON")]
    ScancodeSemicolon = 51,

    [NativeName("SDL_SCANCODE_APOSTROPHE")]
    ScancodeApostrophe = 52,

    [NativeName("SDL_SCANCODE_GRAVE")]
    ScancodeGrave = 53,

    [NativeName("SDL_SCANCODE_COMMA")]
    ScancodeComma = 54,

    [NativeName("SDL_SCANCODE_PERIOD")]
    ScancodePeriod = 55,

    [NativeName("SDL_SCANCODE_SLASH")]
    ScancodeSlash = 56,

    [NativeName("SDL_SCANCODE_CAPSLOCK")]
    ScancodeCapslock = 57,

    [NativeName("SDL_SCANCODE_F1")]
    ScancodeF1 = 58,

    [NativeName("SDL_SCANCODE_F2")]
    ScancodeF2 = 59,

    [NativeName("SDL_SCANCODE_F3")]
    ScancodeF3 = 60,

    [NativeName("SDL_SCANCODE_F4")]
    ScancodeF4 = 61,

    [NativeName("SDL_SCANCODE_F5")]
    ScancodeF5 = 62,

    [NativeName("SDL_SCANCODE_F6")]
    ScancodeF6 = 63,

    [NativeName("SDL_SCANCODE_F7")]
    ScancodeF7 = 64,

    [NativeName("SDL_SCANCODE_F8")]
    ScancodeF8 = 65,

    [NativeName("SDL_SCANCODE_F9")]
    ScancodeF9 = 66,

    [NativeName("SDL_SCANCODE_F10")]
    ScancodeF10 = 67,

    [NativeName("SDL_SCANCODE_F11")]
    ScancodeF11 = 68,

    [NativeName("SDL_SCANCODE_F12")]
    ScancodeF12 = 69,

    [NativeName("SDL_SCANCODE_PRINTSCREEN")]
    ScancodePrintscreen = 70,

    [NativeName("SDL_SCANCODE_SCROLLLOCK")]
    ScancodeScrolllock = 71,

    [NativeName("SDL_SCANCODE_PAUSE")]
    ScancodePause = 72,

    [NativeName("SDL_SCANCODE_INSERT")]
    ScancodeInsert = 73,

    [NativeName("SDL_SCANCODE_HOME")]
    ScancodeHome = 74,

    [NativeName("SDL_SCANCODE_PAGEUP")]
    ScancodePageup = 75,

    [NativeName("SDL_SCANCODE_DELETE")]
    ScancodeDelete = 76,

    [NativeName("SDL_SCANCODE_END")]
    ScancodeEnd = 77,

    [NativeName("SDL_SCANCODE_PAGEDOWN")]
    ScancodePagedown = 78,

    [NativeName("SDL_SCANCODE_RIGHT")]
    ScancodeRight = 79,

    [NativeName("SDL_SCANCODE_LEFT")]
    ScancodeLeft = 80,

    [NativeName("SDL_SCANCODE_DOWN")]
    ScancodeDown = 81,

    [NativeName("SDL_SCANCODE_UP")]
    ScancodeUp = 82,

    [NativeName("SDL_SCANCODE_NUMLOCKCLEAR")]
    ScancodeNumlockclear = 83,

    [NativeName("SDL_SCANCODE_KP_DIVIDE")]
    ScancodeKpDivide = 84,

    [NativeName("SDL_SCANCODE_KP_MULTIPLY")]
    ScancodeKpMultiply = 85,

    [NativeName("SDL_SCANCODE_KP_MINUS")]
    ScancodeKpMinus = 86,

    [NativeName("SDL_SCANCODE_KP_PLUS")]
    ScancodeKpPlus = 87,

    [NativeName("SDL_SCANCODE_KP_ENTER")]
    ScancodeKpEnter = 88,

    [NativeName("SDL_SCANCODE_KP_1")]
    ScancodeKp1 = 89,

    [NativeName("SDL_SCANCODE_KP_2")]
    ScancodeKp2 = 90,

    [NativeName("SDL_SCANCODE_KP_3")]
    ScancodeKp3 = 91,

    [NativeName("SDL_SCANCODE_KP_4")]
    ScancodeKp4 = 92,

    [NativeName("SDL_SCANCODE_KP_5")]
    ScancodeKp5 = 93,

    [NativeName("SDL_SCANCODE_KP_6")]
    ScancodeKp6 = 94,

    [NativeName("SDL_SCANCODE_KP_7")]
    ScancodeKp7 = 95,

    [NativeName("SDL_SCANCODE_KP_8")]
    ScancodeKp8 = 96,

    [NativeName("SDL_SCANCODE_KP_9")]
    ScancodeKp9 = 97,

    [NativeName("SDL_SCANCODE_KP_0")]
    ScancodeKp0 = 98,

    [NativeName("SDL_SCANCODE_KP_PERIOD")]
    ScancodeKpPeriod = 99,

    [NativeName("SDL_SCANCODE_NONUSBACKSLASH")]
    ScancodeNonusbackslash = 100,

    [NativeName("SDL_SCANCODE_APPLICATION")]
    ScancodeApplication = 101,

    [NativeName("SDL_SCANCODE_POWER")]
    ScancodePower = 102,

    [NativeName("SDL_SCANCODE_KP_EQUALS")]
    ScancodeKpEquals = 103,

    [NativeName("SDL_SCANCODE_F13")]
    ScancodeF13 = 104,

    [NativeName("SDL_SCANCODE_F14")]
    ScancodeF14 = 105,

    [NativeName("SDL_SCANCODE_F15")]
    ScancodeF15 = 106,

    [NativeName("SDL_SCANCODE_F16")]
    ScancodeF16 = 107,

    [NativeName("SDL_SCANCODE_F17")]
    ScancodeF17 = 108,

    [NativeName("SDL_SCANCODE_F18")]
    ScancodeF18 = 109,

    [NativeName("SDL_SCANCODE_F19")]
    ScancodeF19 = 110,

    [NativeName("SDL_SCANCODE_F20")]
    ScancodeF20 = 111,

    [NativeName("SDL_SCANCODE_F21")]
    ScancodeF21 = 112,

    [NativeName("SDL_SCANCODE_F22")]
    ScancodeF22 = 113,

    [NativeName("SDL_SCANCODE_F23")]
    ScancodeF23 = 114,

    [NativeName("SDL_SCANCODE_F24")]
    ScancodeF24 = 115,

    [NativeName("SDL_SCANCODE_EXECUTE")]
    ScancodeExecute = 116,

    [NativeName("SDL_SCANCODE_HELP")]
    ScancodeHelp = 117,

    [NativeName("SDL_SCANCODE_MENU")]
    ScancodeMenu = 118,

    [NativeName("SDL_SCANCODE_SELECT")]
    ScancodeSelect = 119,

    [NativeName("SDL_SCANCODE_STOP")]
    ScancodeStop = 120,

    [NativeName("SDL_SCANCODE_AGAIN")]
    ScancodeAgain = 121,

    [NativeName("SDL_SCANCODE_UNDO")]
    ScancodeUndo = 122,

    [NativeName("SDL_SCANCODE_CUT")]
    ScancodeCut = 123,

    [NativeName("SDL_SCANCODE_COPY")]
    ScancodeCopy = 124,

    [NativeName("SDL_SCANCODE_PASTE")]
    ScancodePaste = 125,

    [NativeName("SDL_SCANCODE_FIND")]
    ScancodeFind = 126,

    [NativeName("SDL_SCANCODE_MUTE")]
    ScancodeMute = 127,

    [NativeName("SDL_SCANCODE_VOLUMEUP")]
    ScancodeVolumeup = 128,

    [NativeName("SDL_SCANCODE_VOLUMEDOWN")]
    ScancodeVolumedown = 129,

    [NativeName("SDL_SCANCODE_KP_COMMA")]
    ScancodeKpComma = 133,

    [NativeName("SDL_SCANCODE_KP_EQUALSAS400")]
    ScancodeKpEqualsas400 = 134,

    [NativeName("SDL_SCANCODE_INTERNATIONAL1")]
    ScancodeInternational1 = 135,

    [NativeName("SDL_SCANCODE_INTERNATIONAL2")]
    ScancodeInternational2 = 136,

    [NativeName("SDL_SCANCODE_INTERNATIONAL3")]
    ScancodeInternational3 = 137,

    [NativeName("SDL_SCANCODE_INTERNATIONAL4")]
    ScancodeInternational4 = 138,

    [NativeName("SDL_SCANCODE_INTERNATIONAL5")]
    ScancodeInternational5 = 139,

    [NativeName("SDL_SCANCODE_INTERNATIONAL6")]
    ScancodeInternational6 = 140,

    [NativeName("SDL_SCANCODE_INTERNATIONAL7")]
    ScancodeInternational7 = 141,

    [NativeName("SDL_SCANCODE_INTERNATIONAL8")]
    ScancodeInternational8 = 142,

    [NativeName("SDL_SCANCODE_INTERNATIONAL9")]
    ScancodeInternational9 = 143,

    [NativeName("SDL_SCANCODE_LANG1")]
    ScancodeLang1 = 144,

    [NativeName("SDL_SCANCODE_LANG2")]
    ScancodeLang2 = 145,

    [NativeName("SDL_SCANCODE_LANG3")]
    ScancodeLang3 = 146,

    [NativeName("SDL_SCANCODE_LANG4")]
    ScancodeLang4 = 147,

    [NativeName("SDL_SCANCODE_LANG5")]
    ScancodeLang5 = 148,

    [NativeName("SDL_SCANCODE_LANG6")]
    ScancodeLang6 = 149,

    [NativeName("SDL_SCANCODE_LANG7")]
    ScancodeLang7 = 150,

    [NativeName("SDL_SCANCODE_LANG8")]
    ScancodeLang8 = 151,

    [NativeName("SDL_SCANCODE_LANG9")]
    ScancodeLang9 = 152,

    [NativeName("SDL_SCANCODE_ALTERASE")]
    ScancodeAlterase = 153,

    [NativeName("SDL_SCANCODE_SYSREQ")]
    ScancodeSysreq = 154,

    [NativeName("SDL_SCANCODE_CANCEL")]
    ScancodeCancel = 155,

    [NativeName("SDL_SCANCODE_CLEAR")]
    ScancodeClear = 156,

    [NativeName("SDL_SCANCODE_PRIOR")]
    ScancodePrior = 157,

    [NativeName("SDL_SCANCODE_RETURN2")]
    ScancodeReturn2 = 158,

    [NativeName("SDL_SCANCODE_SEPARATOR")]
    ScancodeSeparator = 159,

    [NativeName("SDL_SCANCODE_OUT")]
    ScancodeOut = 160,

    [NativeName("SDL_SCANCODE_OPER")]
    ScancodeOper = 161,

    [NativeName("SDL_SCANCODE_CLEARAGAIN")]
    ScancodeClearagain = 162,

    [NativeName("SDL_SCANCODE_CRSEL")]
    ScancodeCrsel = 163,

    [NativeName("SDL_SCANCODE_EXSEL")]
    ScancodeExsel = 164,

    [NativeName("SDL_SCANCODE_KP_00")]
    ScancodeKp00 = 176,

    [NativeName("SDL_SCANCODE_KP_000")]
    ScancodeKp000 = 177,

    [NativeName("SDL_SCANCODE_THOUSANDSSEPARATOR")]
    ScancodeThousandsseparator = 178,

    [NativeName("SDL_SCANCODE_DECIMALSEPARATOR")]
    ScancodeDecimalseparator = 179,

    [NativeName("SDL_SCANCODE_CURRENCYUNIT")]
    ScancodeCurrencyunit = 180,

    [NativeName("SDL_SCANCODE_CURRENCYSUBUNIT")]
    ScancodeCurrencysubunit = 181,

    [NativeName("SDL_SCANCODE_KP_LEFTPAREN")]
    ScancodeKpLeftparen = 182,

    [NativeName("SDL_SCANCODE_KP_RIGHTPAREN")]
    ScancodeKpRightparen = 183,

    [NativeName("SDL_SCANCODE_KP_LEFTBRACE")]
    ScancodeKpLeftbrace = 184,

    [NativeName("SDL_SCANCODE_KP_RIGHTBRACE")]
    ScancodeKpRightbrace = 185,

    [NativeName("SDL_SCANCODE_KP_TAB")]
    ScancodeKpTab = 186,

    [NativeName("SDL_SCANCODE_KP_BACKSPACE")]
    ScancodeKpBackspace = 187,

    [NativeName("SDL_SCANCODE_KP_A")]
    ScancodeKpA = 188,

    [NativeName("SDL_SCANCODE_KP_B")]
    ScancodeKpB = 189,

    [NativeName("SDL_SCANCODE_KP_C")]
    ScancodeKpC = 190,

    [NativeName("SDL_SCANCODE_KP_D")]
    ScancodeKpD = 191,

    [NativeName("SDL_SCANCODE_KP_E")]
    ScancodeKpE = 192,

    [NativeName("SDL_SCANCODE_KP_F")]
    ScancodeKpF = 193,

    [NativeName("SDL_SCANCODE_KP_XOR")]
    ScancodeKpXor = 194,

    [NativeName("SDL_SCANCODE_KP_POWER")]
    ScancodeKpPower = 195,

    [NativeName("SDL_SCANCODE_KP_PERCENT")]
    ScancodeKpPercent = 196,

    [NativeName("SDL_SCANCODE_KP_LESS")]
    ScancodeKpLess = 197,

    [NativeName("SDL_SCANCODE_KP_GREATER")]
    ScancodeKpGreater = 198,

    [NativeName("SDL_SCANCODE_KP_AMPERSAND")]
    ScancodeKpAmpersand = 199,

    [NativeName("SDL_SCANCODE_KP_DBLAMPERSAND")]
    ScancodeKpDblampersand = 200,

    [NativeName("SDL_SCANCODE_KP_VERTICALBAR")]
    ScancodeKpVerticalbar = 201,

    [NativeName("SDL_SCANCODE_KP_DBLVERTICALBAR")]
    ScancodeKpDblverticalbar = 202,

    [NativeName("SDL_SCANCODE_KP_COLON")]
    ScancodeKpColon = 203,

    [NativeName("SDL_SCANCODE_KP_HASH")]
    ScancodeKpHash = 204,

    [NativeName("SDL_SCANCODE_KP_SPACE")]
    ScancodeKpSpace = 205,

    [NativeName("SDL_SCANCODE_KP_AT")]
    ScancodeKpAt = 206,

    [NativeName("SDL_SCANCODE_KP_EXCLAM")]
    ScancodeKpExclam = 207,

    [NativeName("SDL_SCANCODE_KP_MEMSTORE")]
    ScancodeKpMemstore = 208,

    [NativeName("SDL_SCANCODE_KP_MEMRECALL")]
    ScancodeKpMemrecall = 209,

    [NativeName("SDL_SCANCODE_KP_MEMCLEAR")]
    ScancodeKpMemclear = 210,

    [NativeName("SDL_SCANCODE_KP_MEMADD")]
    ScancodeKpMemadd = 211,

    [NativeName("SDL_SCANCODE_KP_MEMSUBTRACT")]
    ScancodeKpMemsubtract = 212,

    [NativeName("SDL_SCANCODE_KP_MEMMULTIPLY")]
    ScancodeKpMemmultiply = 213,

    [NativeName("SDL_SCANCODE_KP_MEMDIVIDE")]
    ScancodeKpMemdivide = 214,

    [NativeName("SDL_SCANCODE_KP_PLUSMINUS")]
    ScancodeKpPlusminus = 215,

    [NativeName("SDL_SCANCODE_KP_CLEAR")]
    ScancodeKpClear = 216,

    [NativeName("SDL_SCANCODE_KP_CLEARENTRY")]
    ScancodeKpClearentry = 217,

    [NativeName("SDL_SCANCODE_KP_BINARY")]
    ScancodeKpBinary = 218,

    [NativeName("SDL_SCANCODE_KP_OCTAL")]
    ScancodeKpOctal = 219,

    [NativeName("SDL_SCANCODE_KP_DECIMAL")]
    ScancodeKpDecimal = 220,

    [NativeName("SDL_SCANCODE_KP_HEXADECIMAL")]
    ScancodeKpHexadecimal = 221,

    [NativeName("SDL_SCANCODE_LCTRL")]
    ScancodeLctrl = 224,

    [NativeName("SDL_SCANCODE_LSHIFT")]
    ScancodeLshift = 225,

    [NativeName("SDL_SCANCODE_LALT")]
    ScancodeLalt = 226,

    [NativeName("SDL_SCANCODE_LGUI")]
    ScancodeLgui = 227,

    [NativeName("SDL_SCANCODE_RCTRL")]
    ScancodeRctrl = 228,

    [NativeName("SDL_SCANCODE_RSHIFT")]
    ScancodeRshift = 229,

    [NativeName("SDL_SCANCODE_RALT")]
    ScancodeRalt = 230,

    [NativeName("SDL_SCANCODE_RGUI")]
    ScancodeRgui = 231,

    [NativeName("SDL_SCANCODE_MODE")]
    ScancodeMode = 257,

    [NativeName("SDL_SCANCODE_SLEEP")]
    ScancodeSleep = 258,

    [NativeName("SDL_SCANCODE_WAKE")]
    ScancodeWake = 259,

    [NativeName("SDL_SCANCODE_CHANNEL_INCREMENT")]
    ScancodeChannelIncrement = 260,

    [NativeName("SDL_SCANCODE_CHANNEL_DECREMENT")]
    ScancodeChannelDecrement = 261,

    [NativeName("SDL_SCANCODE_MEDIA_PLAY")]
    ScancodeMediaPlay = 262,

    [NativeName("SDL_SCANCODE_MEDIA_PAUSE")]
    ScancodeMediaPause = 263,

    [NativeName("SDL_SCANCODE_MEDIA_RECORD")]
    ScancodeMediaRecord = 264,

    [NativeName("SDL_SCANCODE_MEDIA_FAST_FORWARD")]
    ScancodeMediaFastForward = 265,

    [NativeName("SDL_SCANCODE_MEDIA_REWIND")]
    ScancodeMediaRewind = 266,

    [NativeName("SDL_SCANCODE_MEDIA_NEXT_TRACK")]
    ScancodeMediaNextTrack = 267,

    [NativeName("SDL_SCANCODE_MEDIA_PREVIOUS_TRACK")]
    ScancodeMediaPreviousTrack = 268,

    [NativeName("SDL_SCANCODE_MEDIA_STOP")]
    ScancodeMediaStop = 269,

    [NativeName("SDL_SCANCODE_MEDIA_EJECT")]
    ScancodeMediaEject = 270,

    [NativeName("SDL_SCANCODE_MEDIA_PLAY_PAUSE")]
    ScancodeMediaPlayPause = 271,

    [NativeName("SDL_SCANCODE_MEDIA_SELECT")]
    ScancodeMediaSelect = 272,

    [NativeName("SDL_SCANCODE_AC_NEW")]
    ScancodeAcNew = 273,

    [NativeName("SDL_SCANCODE_AC_OPEN")]
    ScancodeAcOpen = 274,

    [NativeName("SDL_SCANCODE_AC_CLOSE")]
    ScancodeAcClose = 275,

    [NativeName("SDL_SCANCODE_AC_EXIT")]
    ScancodeAcExit = 276,

    [NativeName("SDL_SCANCODE_AC_SAVE")]
    ScancodeAcSave = 277,

    [NativeName("SDL_SCANCODE_AC_PRINT")]
    ScancodeAcPrint = 278,

    [NativeName("SDL_SCANCODE_AC_PROPERTIES")]
    ScancodeAcProperties = 279,

    [NativeName("SDL_SCANCODE_AC_SEARCH")]
    ScancodeAcSearch = 280,

    [NativeName("SDL_SCANCODE_AC_HOME")]
    ScancodeAcHome = 281,

    [NativeName("SDL_SCANCODE_AC_BACK")]
    ScancodeAcBack = 282,

    [NativeName("SDL_SCANCODE_AC_FORWARD")]
    ScancodeAcForward = 283,

    [NativeName("SDL_SCANCODE_AC_STOP")]
    ScancodeAcStop = 284,

    [NativeName("SDL_SCANCODE_AC_REFRESH")]
    ScancodeAcRefresh = 285,

    [NativeName("SDL_SCANCODE_AC_BOOKMARKS")]
    ScancodeAcBookmarks = 286,

    [NativeName("SDL_SCANCODE_SOFTLEFT")]
    ScancodeSoftleft = 287,

    [NativeName("SDL_SCANCODE_SOFTRIGHT")]
    ScancodeSoftright = 288,

    [NativeName("SDL_SCANCODE_CALL")]
    ScancodeCall = 289,

    [NativeName("SDL_SCANCODE_ENDCALL")]
    ScancodeEndcall = 290,

    [NativeName("SDL_SCANCODE_RESERVED")]
    ScancodeReserved = 400,

    [NativeName("SDL_SCANCODE_COUNT")]
    ScancodeCount = 512,
}
