// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DMPAPER
{
    [NativeTypeName("#define DMPAPER_FIRST DMPAPER_LETTER")]
    public const int DMPAPER_FIRST = 1;

    [NativeTypeName("#define DMPAPER_LETTER 1")]
    public const int DMPAPER_LETTER = 1;

    [NativeTypeName("#define DMPAPER_LETTERSMALL 2")]
    public const int DMPAPER_LETTERSMALL = 2;

    [NativeTypeName("#define DMPAPER_TABLOID 3")]
    public const int DMPAPER_TABLOID = 3;

    [NativeTypeName("#define DMPAPER_LEDGER 4")]
    public const int DMPAPER_LEDGER = 4;

    [NativeTypeName("#define DMPAPER_LEGAL 5")]
    public const int DMPAPER_LEGAL = 5;

    [NativeTypeName("#define DMPAPER_STATEMENT 6")]
    public const int DMPAPER_STATEMENT = 6;

    [NativeTypeName("#define DMPAPER_EXECUTIVE 7")]
    public const int DMPAPER_EXECUTIVE = 7;

    [NativeTypeName("#define DMPAPER_A3 8")]
    public const int DMPAPER_A3 = 8;

    [NativeTypeName("#define DMPAPER_A4 9")]
    public const int DMPAPER_A4 = 9;

    [NativeTypeName("#define DMPAPER_A4SMALL 10")]
    public const int DMPAPER_A4SMALL = 10;

    [NativeTypeName("#define DMPAPER_A5 11")]
    public const int DMPAPER_A5 = 11;

    [NativeTypeName("#define DMPAPER_B4 12")]
    public const int DMPAPER_B4 = 12;

    [NativeTypeName("#define DMPAPER_B5 13")]
    public const int DMPAPER_B5 = 13;

    [NativeTypeName("#define DMPAPER_FOLIO 14")]
    public const int DMPAPER_FOLIO = 14;

    [NativeTypeName("#define DMPAPER_QUARTO 15")]
    public const int DMPAPER_QUARTO = 15;

    [NativeTypeName("#define DMPAPER_10X14 16")]
    public const int DMPAPER_10X14 = 16;

    [NativeTypeName("#define DMPAPER_11X17 17")]
    public const int DMPAPER_11X17 = 17;

    [NativeTypeName("#define DMPAPER_NOTE 18")]
    public const int DMPAPER_NOTE = 18;

    [NativeTypeName("#define DMPAPER_ENV_9 19")]
    public const int DMPAPER_ENV_9 = 19;

    [NativeTypeName("#define DMPAPER_ENV_10 20")]
    public const int DMPAPER_ENV_10 = 20;

    [NativeTypeName("#define DMPAPER_ENV_11 21")]
    public const int DMPAPER_ENV_11 = 21;

    [NativeTypeName("#define DMPAPER_ENV_12 22")]
    public const int DMPAPER_ENV_12 = 22;

    [NativeTypeName("#define DMPAPER_ENV_14 23")]
    public const int DMPAPER_ENV_14 = 23;

    [NativeTypeName("#define DMPAPER_CSHEET 24")]
    public const int DMPAPER_CSHEET = 24;

    [NativeTypeName("#define DMPAPER_DSHEET 25")]
    public const int DMPAPER_DSHEET = 25;

    [NativeTypeName("#define DMPAPER_ESHEET 26")]
    public const int DMPAPER_ESHEET = 26;

    [NativeTypeName("#define DMPAPER_ENV_DL 27")]
    public const int DMPAPER_ENV_DL = 27;

    [NativeTypeName("#define DMPAPER_ENV_C5 28")]
    public const int DMPAPER_ENV_C5 = 28;

    [NativeTypeName("#define DMPAPER_ENV_C3 29")]
    public const int DMPAPER_ENV_C3 = 29;

    [NativeTypeName("#define DMPAPER_ENV_C4 30")]
    public const int DMPAPER_ENV_C4 = 30;

    [NativeTypeName("#define DMPAPER_ENV_C6 31")]
    public const int DMPAPER_ENV_C6 = 31;

    [NativeTypeName("#define DMPAPER_ENV_C65 32")]
    public const int DMPAPER_ENV_C65 = 32;

    [NativeTypeName("#define DMPAPER_ENV_B4 33")]
    public const int DMPAPER_ENV_B4 = 33;

    [NativeTypeName("#define DMPAPER_ENV_B5 34")]
    public const int DMPAPER_ENV_B5 = 34;

    [NativeTypeName("#define DMPAPER_ENV_B6 35")]
    public const int DMPAPER_ENV_B6 = 35;

    [NativeTypeName("#define DMPAPER_ENV_ITALY 36")]
    public const int DMPAPER_ENV_ITALY = 36;

    [NativeTypeName("#define DMPAPER_ENV_MONARCH 37")]
    public const int DMPAPER_ENV_MONARCH = 37;

    [NativeTypeName("#define DMPAPER_ENV_PERSONAL 38")]
    public const int DMPAPER_ENV_PERSONAL = 38;

    [NativeTypeName("#define DMPAPER_FANFOLD_US 39")]
    public const int DMPAPER_FANFOLD_US = 39;

    [NativeTypeName("#define DMPAPER_FANFOLD_STD_GERMAN 40")]
    public const int DMPAPER_FANFOLD_STD_GERMAN = 40;

    [NativeTypeName("#define DMPAPER_FANFOLD_LGL_GERMAN 41")]
    public const int DMPAPER_FANFOLD_LGL_GERMAN = 41;

    [NativeTypeName("#define DMPAPER_ISO_B4 42")]
    public const int DMPAPER_ISO_B4 = 42;

    [NativeTypeName("#define DMPAPER_JAPANESE_POSTCARD 43")]
    public const int DMPAPER_JAPANESE_POSTCARD = 43;

    [NativeTypeName("#define DMPAPER_9X11 44")]
    public const int DMPAPER_9X11 = 44;

    [NativeTypeName("#define DMPAPER_10X11 45")]
    public const int DMPAPER_10X11 = 45;

    [NativeTypeName("#define DMPAPER_15X11 46")]
    public const int DMPAPER_15X11 = 46;

    [NativeTypeName("#define DMPAPER_ENV_INVITE 47")]
    public const int DMPAPER_ENV_INVITE = 47;

    [NativeTypeName("#define DMPAPER_RESERVED_48 48")]
    public const int DMPAPER_RESERVED_48 = 48;

    [NativeTypeName("#define DMPAPER_RESERVED_49 49")]
    public const int DMPAPER_RESERVED_49 = 49;

    [NativeTypeName("#define DMPAPER_LETTER_EXTRA 50")]
    public const int DMPAPER_LETTER_EXTRA = 50;

    [NativeTypeName("#define DMPAPER_LEGAL_EXTRA 51")]
    public const int DMPAPER_LEGAL_EXTRA = 51;

    [NativeTypeName("#define DMPAPER_TABLOID_EXTRA 52")]
    public const int DMPAPER_TABLOID_EXTRA = 52;

    [NativeTypeName("#define DMPAPER_A4_EXTRA 53")]
    public const int DMPAPER_A4_EXTRA = 53;

    [NativeTypeName("#define DMPAPER_LETTER_TRANSVERSE 54")]
    public const int DMPAPER_LETTER_TRANSVERSE = 54;

    [NativeTypeName("#define DMPAPER_A4_TRANSVERSE 55")]
    public const int DMPAPER_A4_TRANSVERSE = 55;

    [NativeTypeName("#define DMPAPER_LETTER_EXTRA_TRANSVERSE 56")]
    public const int DMPAPER_LETTER_EXTRA_TRANSVERSE = 56;

    [NativeTypeName("#define DMPAPER_A_PLUS 57")]
    public const int DMPAPER_A_PLUS = 57;

    [NativeTypeName("#define DMPAPER_B_PLUS 58")]
    public const int DMPAPER_B_PLUS = 58;

    [NativeTypeName("#define DMPAPER_LETTER_PLUS 59")]
    public const int DMPAPER_LETTER_PLUS = 59;

    [NativeTypeName("#define DMPAPER_A4_PLUS 60")]
    public const int DMPAPER_A4_PLUS = 60;

    [NativeTypeName("#define DMPAPER_A5_TRANSVERSE 61")]
    public const int DMPAPER_A5_TRANSVERSE = 61;

    [NativeTypeName("#define DMPAPER_B5_TRANSVERSE 62")]
    public const int DMPAPER_B5_TRANSVERSE = 62;

    [NativeTypeName("#define DMPAPER_A3_EXTRA 63")]
    public const int DMPAPER_A3_EXTRA = 63;

    [NativeTypeName("#define DMPAPER_A5_EXTRA 64")]
    public const int DMPAPER_A5_EXTRA = 64;

    [NativeTypeName("#define DMPAPER_B5_EXTRA 65")]
    public const int DMPAPER_B5_EXTRA = 65;

    [NativeTypeName("#define DMPAPER_A2 66")]
    public const int DMPAPER_A2 = 66;

    [NativeTypeName("#define DMPAPER_A3_TRANSVERSE 67")]
    public const int DMPAPER_A3_TRANSVERSE = 67;

    [NativeTypeName("#define DMPAPER_A3_EXTRA_TRANSVERSE 68")]
    public const int DMPAPER_A3_EXTRA_TRANSVERSE = 68;

    [NativeTypeName("#define DMPAPER_DBL_JAPANESE_POSTCARD 69")]
    public const int DMPAPER_DBL_JAPANESE_POSTCARD = 69;

    [NativeTypeName("#define DMPAPER_A6 70")]
    public const int DMPAPER_A6 = 70;

    [NativeTypeName("#define DMPAPER_JENV_KAKU2 71")]
    public const int DMPAPER_JENV_KAKU2 = 71;

    [NativeTypeName("#define DMPAPER_JENV_KAKU3 72")]
    public const int DMPAPER_JENV_KAKU3 = 72;

    [NativeTypeName("#define DMPAPER_JENV_CHOU3 73")]
    public const int DMPAPER_JENV_CHOU3 = 73;

    [NativeTypeName("#define DMPAPER_JENV_CHOU4 74")]
    public const int DMPAPER_JENV_CHOU4 = 74;

    [NativeTypeName("#define DMPAPER_LETTER_ROTATED 75")]
    public const int DMPAPER_LETTER_ROTATED = 75;

    [NativeTypeName("#define DMPAPER_A3_ROTATED 76")]
    public const int DMPAPER_A3_ROTATED = 76;

    [NativeTypeName("#define DMPAPER_A4_ROTATED 77")]
    public const int DMPAPER_A4_ROTATED = 77;

    [NativeTypeName("#define DMPAPER_A5_ROTATED 78")]
    public const int DMPAPER_A5_ROTATED = 78;

    [NativeTypeName("#define DMPAPER_B4_JIS_ROTATED 79")]
    public const int DMPAPER_B4_JIS_ROTATED = 79;

    [NativeTypeName("#define DMPAPER_B5_JIS_ROTATED 80")]
    public const int DMPAPER_B5_JIS_ROTATED = 80;

    [NativeTypeName("#define DMPAPER_JAPANESE_POSTCARD_ROTATED 81")]
    public const int DMPAPER_JAPANESE_POSTCARD_ROTATED = 81;

    [NativeTypeName("#define DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED 82")]
    public const int DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED = 82;

    [NativeTypeName("#define DMPAPER_A6_ROTATED 83")]
    public const int DMPAPER_A6_ROTATED = 83;

    [NativeTypeName("#define DMPAPER_JENV_KAKU2_ROTATED 84")]
    public const int DMPAPER_JENV_KAKU2_ROTATED = 84;

    [NativeTypeName("#define DMPAPER_JENV_KAKU3_ROTATED 85")]
    public const int DMPAPER_JENV_KAKU3_ROTATED = 85;

    [NativeTypeName("#define DMPAPER_JENV_CHOU3_ROTATED 86")]
    public const int DMPAPER_JENV_CHOU3_ROTATED = 86;

    [NativeTypeName("#define DMPAPER_JENV_CHOU4_ROTATED 87")]
    public const int DMPAPER_JENV_CHOU4_ROTATED = 87;

    [NativeTypeName("#define DMPAPER_B6_JIS 88")]
    public const int DMPAPER_B6_JIS = 88;

    [NativeTypeName("#define DMPAPER_B6_JIS_ROTATED 89")]
    public const int DMPAPER_B6_JIS_ROTATED = 89;

    [NativeTypeName("#define DMPAPER_12X11 90")]
    public const int DMPAPER_12X11 = 90;

    [NativeTypeName("#define DMPAPER_JENV_YOU4 91")]
    public const int DMPAPER_JENV_YOU4 = 91;

    [NativeTypeName("#define DMPAPER_JENV_YOU4_ROTATED 92")]
    public const int DMPAPER_JENV_YOU4_ROTATED = 92;

    [NativeTypeName("#define DMPAPER_P16K 93")]
    public const int DMPAPER_P16K = 93;

    [NativeTypeName("#define DMPAPER_P32K 94")]
    public const int DMPAPER_P32K = 94;

    [NativeTypeName("#define DMPAPER_P32KBIG 95")]
    public const int DMPAPER_P32KBIG = 95;

    [NativeTypeName("#define DMPAPER_PENV_1 96")]
    public const int DMPAPER_PENV_1 = 96;

    [NativeTypeName("#define DMPAPER_PENV_2 97")]
    public const int DMPAPER_PENV_2 = 97;

    [NativeTypeName("#define DMPAPER_PENV_3 98")]
    public const int DMPAPER_PENV_3 = 98;

    [NativeTypeName("#define DMPAPER_PENV_4 99")]
    public const int DMPAPER_PENV_4 = 99;

    [NativeTypeName("#define DMPAPER_PENV_5 100")]
    public const int DMPAPER_PENV_5 = 100;

    [NativeTypeName("#define DMPAPER_PENV_6 101")]
    public const int DMPAPER_PENV_6 = 101;

    [NativeTypeName("#define DMPAPER_PENV_7 102")]
    public const int DMPAPER_PENV_7 = 102;

    [NativeTypeName("#define DMPAPER_PENV_8 103")]
    public const int DMPAPER_PENV_8 = 103;

    [NativeTypeName("#define DMPAPER_PENV_9 104")]
    public const int DMPAPER_PENV_9 = 104;

    [NativeTypeName("#define DMPAPER_PENV_10 105")]
    public const int DMPAPER_PENV_10 = 105;

    [NativeTypeName("#define DMPAPER_P16K_ROTATED 106")]
    public const int DMPAPER_P16K_ROTATED = 106;

    [NativeTypeName("#define DMPAPER_P32K_ROTATED 107")]
    public const int DMPAPER_P32K_ROTATED = 107;

    [NativeTypeName("#define DMPAPER_P32KBIG_ROTATED 108")]
    public const int DMPAPER_P32KBIG_ROTATED = 108;

    [NativeTypeName("#define DMPAPER_PENV_1_ROTATED 109")]
    public const int DMPAPER_PENV_1_ROTATED = 109;

    [NativeTypeName("#define DMPAPER_PENV_2_ROTATED 110")]
    public const int DMPAPER_PENV_2_ROTATED = 110;

    [NativeTypeName("#define DMPAPER_PENV_3_ROTATED 111")]
    public const int DMPAPER_PENV_3_ROTATED = 111;

    [NativeTypeName("#define DMPAPER_PENV_4_ROTATED 112")]
    public const int DMPAPER_PENV_4_ROTATED = 112;

    [NativeTypeName("#define DMPAPER_PENV_5_ROTATED 113")]
    public const int DMPAPER_PENV_5_ROTATED = 113;

    [NativeTypeName("#define DMPAPER_PENV_6_ROTATED 114")]
    public const int DMPAPER_PENV_6_ROTATED = 114;

    [NativeTypeName("#define DMPAPER_PENV_7_ROTATED 115")]
    public const int DMPAPER_PENV_7_ROTATED = 115;

    [NativeTypeName("#define DMPAPER_PENV_8_ROTATED 116")]
    public const int DMPAPER_PENV_8_ROTATED = 116;

    [NativeTypeName("#define DMPAPER_PENV_9_ROTATED 117")]
    public const int DMPAPER_PENV_9_ROTATED = 117;

    [NativeTypeName("#define DMPAPER_PENV_10_ROTATED 118")]
    public const int DMPAPER_PENV_10_ROTATED = 118;

    [NativeTypeName("#define DMPAPER_LAST DMPAPER_PENV_10_ROTATED")]
    public const int DMPAPER_LAST = 118;

    [NativeTypeName("#define DMPAPER_USER 256")]
    public const int DMPAPER_USER = 256;
}
