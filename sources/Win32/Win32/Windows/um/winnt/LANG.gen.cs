// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LANG
{
    [NativeTypeName("#define LANG_NEUTRAL 0x00")]
    public const int LANG_NEUTRAL = 0x00;

    [NativeTypeName("#define LANG_INVARIANT 0x7f")]
    public const int LANG_INVARIANT = 0x7f;

    [NativeTypeName("#define LANG_AFRIKAANS 0x36")]
    public const int LANG_AFRIKAANS = 0x36;

    [NativeTypeName("#define LANG_ALBANIAN 0x1c")]
    public const int LANG_ALBANIAN = 0x1c;

    [NativeTypeName("#define LANG_ALSATIAN 0x84")]
    public const int LANG_ALSATIAN = 0x84;

    [NativeTypeName("#define LANG_AMHARIC 0x5e")]
    public const int LANG_AMHARIC = 0x5e;

    [NativeTypeName("#define LANG_ARABIC 0x01")]
    public const int LANG_ARABIC = 0x01;

    [NativeTypeName("#define LANG_ARMENIAN 0x2b")]
    public const int LANG_ARMENIAN = 0x2b;

    [NativeTypeName("#define LANG_ASSAMESE 0x4d")]
    public const int LANG_ASSAMESE = 0x4d;

    [NativeTypeName("#define LANG_AZERI 0x2c")]
    public const int LANG_AZERI = 0x2c;

    [NativeTypeName("#define LANG_AZERBAIJANI 0x2c")]
    public const int LANG_AZERBAIJANI = 0x2c;

    [NativeTypeName("#define LANG_BANGLA 0x45")]
    public const int LANG_BANGLA = 0x45;

    [NativeTypeName("#define LANG_BASHKIR 0x6d")]
    public const int LANG_BASHKIR = 0x6d;

    [NativeTypeName("#define LANG_BASQUE 0x2d")]
    public const int LANG_BASQUE = 0x2d;

    [NativeTypeName("#define LANG_BELARUSIAN 0x23")]
    public const int LANG_BELARUSIAN = 0x23;

    [NativeTypeName("#define LANG_BENGALI 0x45")]
    public const int LANG_BENGALI = 0x45;

    [NativeTypeName("#define LANG_BRETON 0x7e")]
    public const int LANG_BRETON = 0x7e;

    [NativeTypeName("#define LANG_BOSNIAN 0x1a")]
    public const int LANG_BOSNIAN = 0x1a;

    [NativeTypeName("#define LANG_BOSNIAN_NEUTRAL 0x781a")]
    public const int LANG_BOSNIAN_NEUTRAL = 0x781a;

    [NativeTypeName("#define LANG_BULGARIAN 0x02")]
    public const int LANG_BULGARIAN = 0x02;

    [NativeTypeName("#define LANG_CATALAN 0x03")]
    public const int LANG_CATALAN = 0x03;

    [NativeTypeName("#define LANG_CENTRAL_KURDISH 0x92")]
    public const int LANG_CENTRAL_KURDISH = 0x92;

    [NativeTypeName("#define LANG_CHEROKEE 0x5c")]
    public const int LANG_CHEROKEE = 0x5c;

    [NativeTypeName("#define LANG_CHINESE 0x04")]
    public const int LANG_CHINESE = 0x04;

    [NativeTypeName("#define LANG_CHINESE_SIMPLIFIED 0x04")]
    public const int LANG_CHINESE_SIMPLIFIED = 0x04;

    [NativeTypeName("#define LANG_CHINESE_TRADITIONAL 0x7c04")]
    public const int LANG_CHINESE_TRADITIONAL = 0x7c04;

    [NativeTypeName("#define LANG_CORSICAN 0x83")]
    public const int LANG_CORSICAN = 0x83;

    [NativeTypeName("#define LANG_CROATIAN 0x1a")]
    public const int LANG_CROATIAN = 0x1a;

    [NativeTypeName("#define LANG_CZECH 0x05")]
    public const int LANG_CZECH = 0x05;

    [NativeTypeName("#define LANG_DANISH 0x06")]
    public const int LANG_DANISH = 0x06;

    [NativeTypeName("#define LANG_DARI 0x8c")]
    public const int LANG_DARI = 0x8c;

    [NativeTypeName("#define LANG_DIVEHI 0x65")]
    public const int LANG_DIVEHI = 0x65;

    [NativeTypeName("#define LANG_DUTCH 0x13")]
    public const int LANG_DUTCH = 0x13;

    [NativeTypeName("#define LANG_ENGLISH 0x09")]
    public const int LANG_ENGLISH = 0x09;

    [NativeTypeName("#define LANG_ESTONIAN 0x25")]
    public const int LANG_ESTONIAN = 0x25;

    [NativeTypeName("#define LANG_FAEROESE 0x38")]
    public const int LANG_FAEROESE = 0x38;

    [NativeTypeName("#define LANG_FARSI 0x29")]
    public const int LANG_FARSI = 0x29;

    [NativeTypeName("#define LANG_FILIPINO 0x64")]
    public const int LANG_FILIPINO = 0x64;

    [NativeTypeName("#define LANG_FINNISH 0x0b")]
    public const int LANG_FINNISH = 0x0b;

    [NativeTypeName("#define LANG_FRENCH 0x0c")]
    public const int LANG_FRENCH = 0x0c;

    [NativeTypeName("#define LANG_FRISIAN 0x62")]
    public const int LANG_FRISIAN = 0x62;

    [NativeTypeName("#define LANG_FULAH 0x67")]
    public const int LANG_FULAH = 0x67;

    [NativeTypeName("#define LANG_GALICIAN 0x56")]
    public const int LANG_GALICIAN = 0x56;

    [NativeTypeName("#define LANG_GEORGIAN 0x37")]
    public const int LANG_GEORGIAN = 0x37;

    [NativeTypeName("#define LANG_GERMAN 0x07")]
    public const int LANG_GERMAN = 0x07;

    [NativeTypeName("#define LANG_GREEK 0x08")]
    public const int LANG_GREEK = 0x08;

    [NativeTypeName("#define LANG_GREENLANDIC 0x6f")]
    public const int LANG_GREENLANDIC = 0x6f;

    [NativeTypeName("#define LANG_GUJARATI 0x47")]
    public const int LANG_GUJARATI = 0x47;

    [NativeTypeName("#define LANG_HAUSA 0x68")]
    public const int LANG_HAUSA = 0x68;

    [NativeTypeName("#define LANG_HAWAIIAN 0x75")]
    public const int LANG_HAWAIIAN = 0x75;

    [NativeTypeName("#define LANG_HEBREW 0x0d")]
    public const int LANG_HEBREW = 0x0d;

    [NativeTypeName("#define LANG_HINDI 0x39")]
    public const int LANG_HINDI = 0x39;

    [NativeTypeName("#define LANG_HUNGARIAN 0x0e")]
    public const int LANG_HUNGARIAN = 0x0e;

    [NativeTypeName("#define LANG_ICELANDIC 0x0f")]
    public const int LANG_ICELANDIC = 0x0f;

    [NativeTypeName("#define LANG_IGBO 0x70")]
    public const int LANG_IGBO = 0x70;

    [NativeTypeName("#define LANG_INDONESIAN 0x21")]
    public const int LANG_INDONESIAN = 0x21;

    [NativeTypeName("#define LANG_INUKTITUT 0x5d")]
    public const int LANG_INUKTITUT = 0x5d;

    [NativeTypeName("#define LANG_IRISH 0x3c")]
    public const int LANG_IRISH = 0x3c;

    [NativeTypeName("#define LANG_ITALIAN 0x10")]
    public const int LANG_ITALIAN = 0x10;

    [NativeTypeName("#define LANG_JAPANESE 0x11")]
    public const int LANG_JAPANESE = 0x11;

    [NativeTypeName("#define LANG_KANNADA 0x4b")]
    public const int LANG_KANNADA = 0x4b;

    [NativeTypeName("#define LANG_KASHMIRI 0x60")]
    public const int LANG_KASHMIRI = 0x60;

    [NativeTypeName("#define LANG_KAZAK 0x3f")]
    public const int LANG_KAZAK = 0x3f;

    [NativeTypeName("#define LANG_KHMER 0x53")]
    public const int LANG_KHMER = 0x53;

    [NativeTypeName("#define LANG_KICHE 0x86")]
    public const int LANG_KICHE = 0x86;

    [NativeTypeName("#define LANG_KINYARWANDA 0x87")]
    public const int LANG_KINYARWANDA = 0x87;

    [NativeTypeName("#define LANG_KONKANI 0x57")]
    public const int LANG_KONKANI = 0x57;

    [NativeTypeName("#define LANG_KOREAN 0x12")]
    public const int LANG_KOREAN = 0x12;

    [NativeTypeName("#define LANG_KYRGYZ 0x40")]
    public const int LANG_KYRGYZ = 0x40;

    [NativeTypeName("#define LANG_LAO 0x54")]
    public const int LANG_LAO = 0x54;

    [NativeTypeName("#define LANG_LATVIAN 0x26")]
    public const int LANG_LATVIAN = 0x26;

    [NativeTypeName("#define LANG_LITHUANIAN 0x27")]
    public const int LANG_LITHUANIAN = 0x27;

    [NativeTypeName("#define LANG_LOWER_SORBIAN 0x2e")]
    public const int LANG_LOWER_SORBIAN = 0x2e;

    [NativeTypeName("#define LANG_LUXEMBOURGISH 0x6e")]
    public const int LANG_LUXEMBOURGISH = 0x6e;

    [NativeTypeName("#define LANG_MACEDONIAN 0x2f")]
    public const int LANG_MACEDONIAN = 0x2f;

    [NativeTypeName("#define LANG_MALAY 0x3e")]
    public const int LANG_MALAY = 0x3e;

    [NativeTypeName("#define LANG_MALAYALAM 0x4c")]
    public const int LANG_MALAYALAM = 0x4c;

    [NativeTypeName("#define LANG_MALTESE 0x3a")]
    public const int LANG_MALTESE = 0x3a;

    [NativeTypeName("#define LANG_MANIPURI 0x58")]
    public const int LANG_MANIPURI = 0x58;

    [NativeTypeName("#define LANG_MAORI 0x81")]
    public const int LANG_MAORI = 0x81;

    [NativeTypeName("#define LANG_MAPUDUNGUN 0x7a")]
    public const int LANG_MAPUDUNGUN = 0x7a;

    [NativeTypeName("#define LANG_MARATHI 0x4e")]
    public const int LANG_MARATHI = 0x4e;

    [NativeTypeName("#define LANG_MOHAWK 0x7c")]
    public const int LANG_MOHAWK = 0x7c;

    [NativeTypeName("#define LANG_MONGOLIAN 0x50")]
    public const int LANG_MONGOLIAN = 0x50;

    [NativeTypeName("#define LANG_NEPALI 0x61")]
    public const int LANG_NEPALI = 0x61;

    [NativeTypeName("#define LANG_NORWEGIAN 0x14")]
    public const int LANG_NORWEGIAN = 0x14;

    [NativeTypeName("#define LANG_OCCITAN 0x82")]
    public const int LANG_OCCITAN = 0x82;

    [NativeTypeName("#define LANG_ODIA 0x48")]
    public const int LANG_ODIA = 0x48;

    [NativeTypeName("#define LANG_ORIYA 0x48")]
    public const int LANG_ORIYA = 0x48;

    [NativeTypeName("#define LANG_PASHTO 0x63")]
    public const int LANG_PASHTO = 0x63;

    [NativeTypeName("#define LANG_PERSIAN 0x29")]
    public const int LANG_PERSIAN = 0x29;

    [NativeTypeName("#define LANG_POLISH 0x15")]
    public const int LANG_POLISH = 0x15;

    [NativeTypeName("#define LANG_PORTUGUESE 0x16")]
    public const int LANG_PORTUGUESE = 0x16;

    [NativeTypeName("#define LANG_PULAR 0x67")]
    public const int LANG_PULAR = 0x67;

    [NativeTypeName("#define LANG_PUNJABI 0x46")]
    public const int LANG_PUNJABI = 0x46;

    [NativeTypeName("#define LANG_QUECHUA 0x6b")]
    public const int LANG_QUECHUA = 0x6b;

    [NativeTypeName("#define LANG_ROMANIAN 0x18")]
    public const int LANG_ROMANIAN = 0x18;

    [NativeTypeName("#define LANG_ROMANSH 0x17")]
    public const int LANG_ROMANSH = 0x17;

    [NativeTypeName("#define LANG_RUSSIAN 0x19")]
    public const int LANG_RUSSIAN = 0x19;

    [NativeTypeName("#define LANG_SAKHA 0x85")]
    public const int LANG_SAKHA = 0x85;

    [NativeTypeName("#define LANG_SAMI 0x3b")]
    public const int LANG_SAMI = 0x3b;

    [NativeTypeName("#define LANG_SANSKRIT 0x4f")]
    public const int LANG_SANSKRIT = 0x4f;

    [NativeTypeName("#define LANG_SCOTTISH_GAELIC 0x91")]
    public const int LANG_SCOTTISH_GAELIC = 0x91;

    [NativeTypeName("#define LANG_SERBIAN 0x1a")]
    public const int LANG_SERBIAN = 0x1a;

    [NativeTypeName("#define LANG_SERBIAN_NEUTRAL 0x7c1a")]
    public const int LANG_SERBIAN_NEUTRAL = 0x7c1a;

    [NativeTypeName("#define LANG_SINDHI 0x59")]
    public const int LANG_SINDHI = 0x59;

    [NativeTypeName("#define LANG_SINHALESE 0x5b")]
    public const int LANG_SINHALESE = 0x5b;

    [NativeTypeName("#define LANG_SLOVAK 0x1b")]
    public const int LANG_SLOVAK = 0x1b;

    [NativeTypeName("#define LANG_SLOVENIAN 0x24")]
    public const int LANG_SLOVENIAN = 0x24;

    [NativeTypeName("#define LANG_SOTHO 0x6c")]
    public const int LANG_SOTHO = 0x6c;

    [NativeTypeName("#define LANG_SPANISH 0x0a")]
    public const int LANG_SPANISH = 0x0a;

    [NativeTypeName("#define LANG_SWAHILI 0x41")]
    public const int LANG_SWAHILI = 0x41;

    [NativeTypeName("#define LANG_SWEDISH 0x1d")]
    public const int LANG_SWEDISH = 0x1d;

    [NativeTypeName("#define LANG_SYRIAC 0x5a")]
    public const int LANG_SYRIAC = 0x5a;

    [NativeTypeName("#define LANG_TAJIK 0x28")]
    public const int LANG_TAJIK = 0x28;

    [NativeTypeName("#define LANG_TAMAZIGHT 0x5f")]
    public const int LANG_TAMAZIGHT = 0x5f;

    [NativeTypeName("#define LANG_TAMIL 0x49")]
    public const int LANG_TAMIL = 0x49;

    [NativeTypeName("#define LANG_TATAR 0x44")]
    public const int LANG_TATAR = 0x44;

    [NativeTypeName("#define LANG_TELUGU 0x4a")]
    public const int LANG_TELUGU = 0x4a;

    [NativeTypeName("#define LANG_THAI 0x1e")]
    public const int LANG_THAI = 0x1e;

    [NativeTypeName("#define LANG_TIBETAN 0x51")]
    public const int LANG_TIBETAN = 0x51;

    [NativeTypeName("#define LANG_TIGRIGNA 0x73")]
    public const int LANG_TIGRIGNA = 0x73;

    [NativeTypeName("#define LANG_TIGRINYA 0x73")]
    public const int LANG_TIGRINYA = 0x73;

    [NativeTypeName("#define LANG_TSWANA 0x32")]
    public const int LANG_TSWANA = 0x32;

    [NativeTypeName("#define LANG_TURKISH 0x1f")]
    public const int LANG_TURKISH = 0x1f;

    [NativeTypeName("#define LANG_TURKMEN 0x42")]
    public const int LANG_TURKMEN = 0x42;

    [NativeTypeName("#define LANG_UIGHUR 0x80")]
    public const int LANG_UIGHUR = 0x80;

    [NativeTypeName("#define LANG_UKRAINIAN 0x22")]
    public const int LANG_UKRAINIAN = 0x22;

    [NativeTypeName("#define LANG_UPPER_SORBIAN 0x2e")]
    public const int LANG_UPPER_SORBIAN = 0x2e;

    [NativeTypeName("#define LANG_URDU 0x20")]
    public const int LANG_URDU = 0x20;

    [NativeTypeName("#define LANG_UZBEK 0x43")]
    public const int LANG_UZBEK = 0x43;

    [NativeTypeName("#define LANG_VALENCIAN 0x03")]
    public const int LANG_VALENCIAN = 0x03;

    [NativeTypeName("#define LANG_VIETNAMESE 0x2a")]
    public const int LANG_VIETNAMESE = 0x2a;

    [NativeTypeName("#define LANG_WELSH 0x52")]
    public const int LANG_WELSH = 0x52;

    [NativeTypeName("#define LANG_WOLOF 0x88")]
    public const int LANG_WOLOF = 0x88;

    [NativeTypeName("#define LANG_XHOSA 0x34")]
    public const int LANG_XHOSA = 0x34;

    [NativeTypeName("#define LANG_YAKUT 0x85")]
    public const int LANG_YAKUT = 0x85;

    [NativeTypeName("#define LANG_YI 0x78")]
    public const int LANG_YI = 0x78;

    [NativeTypeName("#define LANG_YORUBA 0x6a")]
    public const int LANG_YORUBA = 0x6a;

    [NativeTypeName("#define LANG_ZULU 0x35")]
    public const int LANG_ZULU = 0x35;

    [NativeTypeName("#define LANG_SYSTEM_DEFAULT (MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT))")]
    public const int LANG_SYSTEM_DEFAULT = unchecked(((((ushort)(0x02)) << 10) | (ushort)(0x00)));

    [NativeTypeName("#define LANG_USER_DEFAULT (MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT))")]
    public const int LANG_USER_DEFAULT = unchecked(((((ushort)(0x01)) << 10) | (ushort)(0x00)));
}
