// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class IME
{
    [NativeTypeName("#define IME_CHOTKEY_IME_NONIME_TOGGLE 0x10")]
    public const int IME_CHOTKEY_IME_NONIME_TOGGLE = 0x10;
    [NativeTypeName("#define IME_CHOTKEY_SHAPE_TOGGLE 0x11")]
    public const int IME_CHOTKEY_SHAPE_TOGGLE = 0x11;
    [NativeTypeName("#define IME_CHOTKEY_SYMBOL_TOGGLE 0x12")]
    public const int IME_CHOTKEY_SYMBOL_TOGGLE = 0x12;
    [NativeTypeName("#define IME_JHOTKEY_CLOSE_OPEN 0x30")]
    public const int IME_JHOTKEY_CLOSE_OPEN = 0x30;
    [NativeTypeName("#define IME_KHOTKEY_SHAPE_TOGGLE 0x50")]
    public const int IME_KHOTKEY_SHAPE_TOGGLE = 0x50;
    [NativeTypeName("#define IME_KHOTKEY_HANJACONVERT 0x51")]
    public const int IME_KHOTKEY_HANJACONVERT = 0x51;
    [NativeTypeName("#define IME_KHOTKEY_ENGLISH 0x52")]
    public const int IME_KHOTKEY_ENGLISH = 0x52;
    [NativeTypeName("#define IME_THOTKEY_IME_NONIME_TOGGLE 0x70")]
    public const int IME_THOTKEY_IME_NONIME_TOGGLE = 0x70;
    [NativeTypeName("#define IME_THOTKEY_SHAPE_TOGGLE 0x71")]
    public const int IME_THOTKEY_SHAPE_TOGGLE = 0x71;
    [NativeTypeName("#define IME_THOTKEY_SYMBOL_TOGGLE 0x72")]
    public const int IME_THOTKEY_SYMBOL_TOGGLE = 0x72;
    [NativeTypeName("#define IME_HOTKEY_DSWITCH_FIRST 0x100")]
    public const int IME_HOTKEY_DSWITCH_FIRST = 0x100;
    [NativeTypeName("#define IME_HOTKEY_DSWITCH_LAST 0x11F")]
    public const int IME_HOTKEY_DSWITCH_LAST = 0x11F;
    [NativeTypeName("#define IME_HOTKEY_PRIVATE_FIRST 0x200")]
    public const int IME_HOTKEY_PRIVATE_FIRST = 0x200;
    [NativeTypeName("#define IME_ITHOTKEY_RESEND_RESULTSTR 0x200")]
    public const int IME_ITHOTKEY_RESEND_RESULTSTR = 0x200;
    [NativeTypeName("#define IME_ITHOTKEY_PREVIOUS_COMPOSITION 0x201")]
    public const int IME_ITHOTKEY_PREVIOUS_COMPOSITION = 0x201;
    [NativeTypeName("#define IME_ITHOTKEY_UISTYLE_TOGGLE 0x202")]
    public const int IME_ITHOTKEY_UISTYLE_TOGGLE = 0x202;
    [NativeTypeName("#define IME_ITHOTKEY_RECONVERTSTRING 0x203")]
    public const int IME_ITHOTKEY_RECONVERTSTRING = 0x203;
    [NativeTypeName("#define IME_HOTKEY_PRIVATE_LAST 0x21F")]
    public const int IME_HOTKEY_PRIVATE_LAST = 0x21F;
    [NativeTypeName("#define IME_PROP_AT_CARET 0x00010000")]
    public const int IME_PROP_AT_CARET = 0x00010000;
    [NativeTypeName("#define IME_PROP_SPECIAL_UI 0x00020000")]
    public const int IME_PROP_SPECIAL_UI = 0x00020000;
    [NativeTypeName("#define IME_PROP_CANDLIST_START_FROM_1 0x00040000")]
    public const int IME_PROP_CANDLIST_START_FROM_1 = 0x00040000;
    [NativeTypeName("#define IME_PROP_UNICODE 0x00080000")]
    public const int IME_PROP_UNICODE = 0x00080000;
    [NativeTypeName("#define IME_PROP_COMPLETE_ON_UNSELECT 0x00100000")]
    public const int IME_PROP_COMPLETE_ON_UNSELECT = 0x00100000;
    [NativeTypeName("#define IME_CMODE_HANGEUL IME_CMODE_NATIVE")]
    public const int IME_CMODE_HANGEUL = 0x0001;
    [NativeTypeName("#define IME_CMODE_SOFTKBD 0x0080")]
    public const int IME_CMODE_SOFTKBD = 0x0080;
    [NativeTypeName("#define IME_CMODE_NOCONVERSION 0x0100")]
    public const int IME_CMODE_NOCONVERSION = 0x0100;
    [NativeTypeName("#define IME_CMODE_EUDC 0x0200")]
    public const int IME_CMODE_EUDC = 0x0200;
    [NativeTypeName("#define IME_CMODE_SYMBOL 0x0400")]
    public const int IME_CMODE_SYMBOL = 0x0400;
    [NativeTypeName("#define IME_CMODE_FIXED 0x0800")]
    public const int IME_CMODE_FIXED = 0x0800;
    [NativeTypeName("#define IME_CMODE_RESERVED 0xF0000000")]
    public const uint IME_CMODE_RESERVED = 0xF0000000;
    [NativeTypeName("#define IME_SMODE_NONE 0x0000")]
    public const int IME_SMODE_NONE = 0x0000;
    [NativeTypeName("#define IME_SMODE_PLAURALCLAUSE 0x0001")]
    public const int IME_SMODE_PLAURALCLAUSE = 0x0001;
    [NativeTypeName("#define IME_SMODE_SINGLECONVERT 0x0002")]
    public const int IME_SMODE_SINGLECONVERT = 0x0002;
    [NativeTypeName("#define IME_SMODE_AUTOMATIC 0x0004")]
    public const int IME_SMODE_AUTOMATIC = 0x0004;
    [NativeTypeName("#define IME_SMODE_PHRASEPREDICT 0x0008")]
    public const int IME_SMODE_PHRASEPREDICT = 0x0008;
    [NativeTypeName("#define IME_SMODE_CONVERSATION 0x0010")]
    public const int IME_SMODE_CONVERSATION = 0x0010;
    [NativeTypeName("#define IME_SMODE_RESERVED 0x0000F000")]
    public const int IME_SMODE_RESERVED = 0x0000F000;
    [NativeTypeName("#define IME_CAND_UNKNOWN 0x0000")]
    public const int IME_CAND_UNKNOWN = 0x0000;
    [NativeTypeName("#define IME_CAND_READ 0x0001")]
    public const int IME_CAND_READ = 0x0001;
    [NativeTypeName("#define IME_CAND_CODE 0x0002")]
    public const int IME_CAND_CODE = 0x0002;
    [NativeTypeName("#define IME_CAND_MEANING 0x0003")]
    public const int IME_CAND_MEANING = 0x0003;
    [NativeTypeName("#define IME_CAND_RADICAL 0x0004")]
    public const int IME_CAND_RADICAL = 0x0004;
    [NativeTypeName("#define IME_CAND_STROKE 0x0005")]
    public const int IME_CAND_STROKE = 0x0005;
    [NativeTypeName("#define IME_CONFIG_GENERAL 1")]
    public const int IME_CONFIG_GENERAL = 1;
    [NativeTypeName("#define IME_CONFIG_REGISTERWORD 2")]
    public const int IME_CONFIG_REGISTERWORD = 2;
    [NativeTypeName("#define IME_CONFIG_SELECTDICTIONARY 3")]
    public const int IME_CONFIG_SELECTDICTIONARY = 3;
    [NativeTypeName("#define IME_ESC_QUERY_SUPPORT 0x0003")]
    public const int IME_ESC_QUERY_SUPPORT = 0x0003;
    [NativeTypeName("#define IME_ESC_RESERVED_FIRST 0x0004")]
    public const int IME_ESC_RESERVED_FIRST = 0x0004;
    [NativeTypeName("#define IME_ESC_RESERVED_LAST 0x07FF")]
    public const int IME_ESC_RESERVED_LAST = 0x07FF;
    [NativeTypeName("#define IME_ESC_PRIVATE_FIRST 0x0800")]
    public const int IME_ESC_PRIVATE_FIRST = 0x0800;
    [NativeTypeName("#define IME_ESC_PRIVATE_LAST 0x0FFF")]
    public const int IME_ESC_PRIVATE_LAST = 0x0FFF;
    [NativeTypeName("#define IME_ESC_SEQUENCE_TO_INTERNAL 0x1001")]
    public const int IME_ESC_SEQUENCE_TO_INTERNAL = 0x1001;
    [NativeTypeName("#define IME_ESC_GET_EUDC_DICTIONARY 0x1003")]
    public const int IME_ESC_GET_EUDC_DICTIONARY = 0x1003;
    [NativeTypeName("#define IME_ESC_SET_EUDC_DICTIONARY 0x1004")]
    public const int IME_ESC_SET_EUDC_DICTIONARY = 0x1004;
    [NativeTypeName("#define IME_ESC_MAX_KEY 0x1005")]
    public const int IME_ESC_MAX_KEY = 0x1005;
    [NativeTypeName("#define IME_ESC_IME_NAME 0x1006")]
    public const int IME_ESC_IME_NAME = 0x1006;
    [NativeTypeName("#define IME_ESC_SYNC_HOTKEY 0x1007")]
    public const int IME_ESC_SYNC_HOTKEY = 0x1007;
    [NativeTypeName("#define IME_ESC_HANJA_MODE 0x1008")]
    public const int IME_ESC_HANJA_MODE = 0x1008;
    [NativeTypeName("#define IME_ESC_AUTOMATA 0x1009")]
    public const int IME_ESC_AUTOMATA = 0x1009;
    [NativeTypeName("#define IME_ESC_PRIVATE_HOTKEY 0x100a")]
    public const int IME_ESC_PRIVATE_HOTKEY = 0x100a;
    [NativeTypeName("#define IME_ESC_GETHELPFILENAME 0x100b")]
    public const int IME_ESC_GETHELPFILENAME = 0x100b;
    [NativeTypeName("#define IME_REGWORD_STYLE_EUDC 0x00000001")]
    public const int IME_REGWORD_STYLE_EUDC = 0x00000001;
    [NativeTypeName("#define IME_REGWORD_STYLE_USER_FIRST 0x80000000")]
    public const uint IME_REGWORD_STYLE_USER_FIRST = 0x80000000;
    [NativeTypeName("#define IME_REGWORD_STYLE_USER_LAST 0xFFFFFFFF")]
    public const uint IME_REGWORD_STYLE_USER_LAST = 0xFFFFFFFF;
}