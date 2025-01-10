// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MM
{
    [NativeTypeName("#define MM_MICROSOFT 1")]
    public const int MM_MICROSOFT = 1;

    [NativeTypeName("#define MM_CREATIVE 2")]
    public const int MM_CREATIVE = 2;

    [NativeTypeName("#define MM_MEDIAVISION 3")]
    public const int MM_MEDIAVISION = 3;

    [NativeTypeName("#define MM_FUJITSU 4")]
    public const int MM_FUJITSU = 4;

    [NativeTypeName("#define MM_PRAGMATRAX 5")]
    public const int MM_PRAGMATRAX = 5;

    [NativeTypeName("#define MM_CYRIX 6")]
    public const int MM_CYRIX = 6;

    [NativeTypeName("#define MM_PHILIPS_SPEECH_PROCESSING 7")]
    public const int MM_PHILIPS_SPEECH_PROCESSING = 7;

    [NativeTypeName("#define MM_NETXL 8")]
    public const int MM_NETXL = 8;

    [NativeTypeName("#define MM_ZYXEL 9")]
    public const int MM_ZYXEL = 9;

    [NativeTypeName("#define MM_BECUBED 10")]
    public const int MM_BECUBED = 10;

    [NativeTypeName("#define MM_AARDVARK 11")]
    public const int MM_AARDVARK = 11;

    [NativeTypeName("#define MM_BINTEC 12")]
    public const int MM_BINTEC = 12;

    [NativeTypeName("#define MM_HEWLETT_PACKARD 13")]
    public const int MM_HEWLETT_PACKARD = 13;

    [NativeTypeName("#define MM_ACULAB 14")]
    public const int MM_ACULAB = 14;

    [NativeTypeName("#define MM_FAITH 15")]
    public const int MM_FAITH = 15;

    [NativeTypeName("#define MM_MITEL 16")]
    public const int MM_MITEL = 16;

    [NativeTypeName("#define MM_QUANTUM3D 17")]
    public const int MM_QUANTUM3D = 17;

    [NativeTypeName("#define MM_SNI 18")]
    public const int MM_SNI = 18;

    [NativeTypeName("#define MM_EMU 19")]
    public const int MM_EMU = 19;

    [NativeTypeName("#define MM_ARTISOFT 20")]
    public const int MM_ARTISOFT = 20;

    [NativeTypeName("#define MM_TURTLE_BEACH 21")]
    public const int MM_TURTLE_BEACH = 21;

    [NativeTypeName("#define MM_IBM 22")]
    public const int MM_IBM = 22;

    [NativeTypeName("#define MM_VOCALTEC 23")]
    public const int MM_VOCALTEC = 23;

    [NativeTypeName("#define MM_ROLAND 24")]
    public const int MM_ROLAND = 24;

    [NativeTypeName("#define MM_DSP_SOLUTIONS 25")]
    public const int MM_DSP_SOLUTIONS = 25;

    [NativeTypeName("#define MM_NEC 26")]
    public const int MM_NEC = 26;

    [NativeTypeName("#define MM_ATI 27")]
    public const int MM_ATI = 27;

    [NativeTypeName("#define MM_WANGLABS 28")]
    public const int MM_WANGLABS = 28;

    [NativeTypeName("#define MM_TANDY 29")]
    public const int MM_TANDY = 29;

    [NativeTypeName("#define MM_VOYETRA 30")]
    public const int MM_VOYETRA = 30;

    [NativeTypeName("#define MM_ANTEX 31")]
    public const int MM_ANTEX = 31;

    [NativeTypeName("#define MM_ICL_PS 32")]
    public const int MM_ICL_PS = 32;

    [NativeTypeName("#define MM_INTEL 33")]
    public const int MM_INTEL = 33;

    [NativeTypeName("#define MM_GRAVIS 34")]
    public const int MM_GRAVIS = 34;

    [NativeTypeName("#define MM_VAL 35")]
    public const int MM_VAL = 35;

    [NativeTypeName("#define MM_INTERACTIVE 36")]
    public const int MM_INTERACTIVE = 36;

    [NativeTypeName("#define MM_YAMAHA 37")]
    public const int MM_YAMAHA = 37;

    [NativeTypeName("#define MM_EVEREX 38")]
    public const int MM_EVEREX = 38;

    [NativeTypeName("#define MM_ECHO 39")]
    public const int MM_ECHO = 39;

    [NativeTypeName("#define MM_SIERRA 40")]
    public const int MM_SIERRA = 40;

    [NativeTypeName("#define MM_CAT 41")]
    public const int MM_CAT = 41;

    [NativeTypeName("#define MM_APPS 42")]
    public const int MM_APPS = 42;

    [NativeTypeName("#define MM_DSP_GROUP 43")]
    public const int MM_DSP_GROUP = 43;

    [NativeTypeName("#define MM_MELABS 44")]
    public const int MM_MELABS = 44;

    [NativeTypeName("#define MM_COMPUTER_FRIENDS 45")]
    public const int MM_COMPUTER_FRIENDS = 45;

    [NativeTypeName("#define MM_ESS 46")]
    public const int MM_ESS = 46;

    [NativeTypeName("#define MM_AUDIOFILE 47")]
    public const int MM_AUDIOFILE = 47;

    [NativeTypeName("#define MM_MOTOROLA 48")]
    public const int MM_MOTOROLA = 48;

    [NativeTypeName("#define MM_CANOPUS 49")]
    public const int MM_CANOPUS = 49;

    [NativeTypeName("#define MM_EPSON 50")]
    public const int MM_EPSON = 50;

    [NativeTypeName("#define MM_TRUEVISION 51")]
    public const int MM_TRUEVISION = 51;

    [NativeTypeName("#define MM_AZTECH 52")]
    public const int MM_AZTECH = 52;

    [NativeTypeName("#define MM_VIDEOLOGIC 53")]
    public const int MM_VIDEOLOGIC = 53;

    [NativeTypeName("#define MM_SCALACS 54")]
    public const int MM_SCALACS = 54;

    [NativeTypeName("#define MM_KORG 55")]
    public const int MM_KORG = 55;

    [NativeTypeName("#define MM_APT 56")]
    public const int MM_APT = 56;

    [NativeTypeName("#define MM_ICS 57")]
    public const int MM_ICS = 57;

    [NativeTypeName("#define MM_ITERATEDSYS 58")]
    public const int MM_ITERATEDSYS = 58;

    [NativeTypeName("#define MM_METHEUS 59")]
    public const int MM_METHEUS = 59;

    [NativeTypeName("#define MM_LOGITECH 60")]
    public const int MM_LOGITECH = 60;

    [NativeTypeName("#define MM_WINNOV 61")]
    public const int MM_WINNOV = 61;

    [NativeTypeName("#define MM_NCR 62")]
    public const int MM_NCR = 62;

    [NativeTypeName("#define MM_EXAN 63")]
    public const int MM_EXAN = 63;

    [NativeTypeName("#define MM_AST 64")]
    public const int MM_AST = 64;

    [NativeTypeName("#define MM_WILLOWPOND 65")]
    public const int MM_WILLOWPOND = 65;

    [NativeTypeName("#define MM_SONICFOUNDRY 66")]
    public const int MM_SONICFOUNDRY = 66;

    [NativeTypeName("#define MM_VITEC 67")]
    public const int MM_VITEC = 67;

    [NativeTypeName("#define MM_MOSCOM 68")]
    public const int MM_MOSCOM = 68;

    [NativeTypeName("#define MM_SILICONSOFT 69")]
    public const int MM_SILICONSOFT = 69;

    [NativeTypeName("#define MM_TERRATEC 70")]
    public const int MM_TERRATEC = 70;

    [NativeTypeName("#define MM_MEDIASONIC 71")]
    public const int MM_MEDIASONIC = 71;

    [NativeTypeName("#define MM_SANYO 72")]
    public const int MM_SANYO = 72;

    [NativeTypeName("#define MM_SUPERMAC 73")]
    public const int MM_SUPERMAC = 73;

    [NativeTypeName("#define MM_AUDIOPT 74")]
    public const int MM_AUDIOPT = 74;

    [NativeTypeName("#define MM_NOGATECH 75")]
    public const int MM_NOGATECH = 75;

    [NativeTypeName("#define MM_SPEECHCOMP 76")]
    public const int MM_SPEECHCOMP = 76;

    [NativeTypeName("#define MM_AHEAD 77")]
    public const int MM_AHEAD = 77;

    [NativeTypeName("#define MM_DOLBY 78")]
    public const int MM_DOLBY = 78;

    [NativeTypeName("#define MM_OKI 79")]
    public const int MM_OKI = 79;

    [NativeTypeName("#define MM_AURAVISION 80")]
    public const int MM_AURAVISION = 80;

    [NativeTypeName("#define MM_OLIVETTI 81")]
    public const int MM_OLIVETTI = 81;

    [NativeTypeName("#define MM_IOMAGIC 82")]
    public const int MM_IOMAGIC = 82;

    [NativeTypeName("#define MM_MATSUSHITA 83")]
    public const int MM_MATSUSHITA = 83;

    [NativeTypeName("#define MM_CONTROLRES 84")]
    public const int MM_CONTROLRES = 84;

    [NativeTypeName("#define MM_XEBEC 85")]
    public const int MM_XEBEC = 85;

    [NativeTypeName("#define MM_NEWMEDIA 86")]
    public const int MM_NEWMEDIA = 86;

    [NativeTypeName("#define MM_NMS 87")]
    public const int MM_NMS = 87;

    [NativeTypeName("#define MM_LYRRUS 88")]
    public const int MM_LYRRUS = 88;

    [NativeTypeName("#define MM_COMPUSIC 89")]
    public const int MM_COMPUSIC = 89;

    [NativeTypeName("#define MM_OPTI 90")]
    public const int MM_OPTI = 90;

    [NativeTypeName("#define MM_ADLACC 91")]
    public const int MM_ADLACC = 91;

    [NativeTypeName("#define MM_COMPAQ 92")]
    public const int MM_COMPAQ = 92;

    [NativeTypeName("#define MM_DIALOGIC 93")]
    public const int MM_DIALOGIC = 93;

    [NativeTypeName("#define MM_INSOFT 94")]
    public const int MM_INSOFT = 94;

    [NativeTypeName("#define MM_MPTUS 95")]
    public const int MM_MPTUS = 95;

    [NativeTypeName("#define MM_WEITEK 96")]
    public const int MM_WEITEK = 96;

    [NativeTypeName("#define MM_LERNOUT_AND_HAUSPIE 97")]
    public const int MM_LERNOUT_AND_HAUSPIE = 97;

    [NativeTypeName("#define MM_QCIAR 98")]
    public const int MM_QCIAR = 98;

    [NativeTypeName("#define MM_APPLE 99")]
    public const int MM_APPLE = 99;

    [NativeTypeName("#define MM_DIGITAL 100")]
    public const int MM_DIGITAL = 100;

    [NativeTypeName("#define MM_MOTU 101")]
    public const int MM_MOTU = 101;

    [NativeTypeName("#define MM_WORKBIT 102")]
    public const int MM_WORKBIT = 102;

    [NativeTypeName("#define MM_OSITECH 103")]
    public const int MM_OSITECH = 103;

    [NativeTypeName("#define MM_MIRO 104")]
    public const int MM_MIRO = 104;

    [NativeTypeName("#define MM_CIRRUSLOGIC 105")]
    public const int MM_CIRRUSLOGIC = 105;

    [NativeTypeName("#define MM_ISOLUTION 106")]
    public const int MM_ISOLUTION = 106;

    [NativeTypeName("#define MM_HORIZONS 107")]
    public const int MM_HORIZONS = 107;

    [NativeTypeName("#define MM_CONCEPTS 108")]
    public const int MM_CONCEPTS = 108;

    [NativeTypeName("#define MM_VTG 109")]
    public const int MM_VTG = 109;

    [NativeTypeName("#define MM_RADIUS 110")]
    public const int MM_RADIUS = 110;

    [NativeTypeName("#define MM_ROCKWELL 111")]
    public const int MM_ROCKWELL = 111;

    [NativeTypeName("#define MM_XYZ 112")]
    public const int MM_XYZ = 112;

    [NativeTypeName("#define MM_OPCODE 113")]
    public const int MM_OPCODE = 113;

    [NativeTypeName("#define MM_VOXWARE 114")]
    public const int MM_VOXWARE = 114;

    [NativeTypeName("#define MM_NORTHERN_TELECOM 115")]
    public const int MM_NORTHERN_TELECOM = 115;

    [NativeTypeName("#define MM_APICOM 116")]
    public const int MM_APICOM = 116;

    [NativeTypeName("#define MM_GRANDE 117")]
    public const int MM_GRANDE = 117;

    [NativeTypeName("#define MM_ADDX 118")]
    public const int MM_ADDX = 118;

    [NativeTypeName("#define MM_WILDCAT 119")]
    public const int MM_WILDCAT = 119;

    [NativeTypeName("#define MM_RHETOREX 120")]
    public const int MM_RHETOREX = 120;

    [NativeTypeName("#define MM_BROOKTREE 121")]
    public const int MM_BROOKTREE = 121;

    [NativeTypeName("#define MM_ENSONIQ 125")]
    public const int MM_ENSONIQ = 125;

    [NativeTypeName("#define MM_FAST 126")]
    public const int MM_FAST = 126;

    [NativeTypeName("#define MM_NVIDIA 127")]
    public const int MM_NVIDIA = 127;

    [NativeTypeName("#define MM_OKSORI 128")]
    public const int MM_OKSORI = 128;

    [NativeTypeName("#define MM_DIACOUSTICS 129")]
    public const int MM_DIACOUSTICS = 129;

    [NativeTypeName("#define MM_GULBRANSEN 130")]
    public const int MM_GULBRANSEN = 130;

    [NativeTypeName("#define MM_KAY_ELEMETRICS 131")]
    public const int MM_KAY_ELEMETRICS = 131;

    [NativeTypeName("#define MM_CRYSTAL 132")]
    public const int MM_CRYSTAL = 132;

    [NativeTypeName("#define MM_SPLASH_STUDIOS 133")]
    public const int MM_SPLASH_STUDIOS = 133;

    [NativeTypeName("#define MM_QUARTERDECK 134")]
    public const int MM_QUARTERDECK = 134;

    [NativeTypeName("#define MM_TDK 135")]
    public const int MM_TDK = 135;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS 136")]
    public const int MM_DIGITAL_AUDIO_LABS = 136;

    [NativeTypeName("#define MM_SEERSYS 137")]
    public const int MM_SEERSYS = 137;

    [NativeTypeName("#define MM_PICTURETEL 138")]
    public const int MM_PICTURETEL = 138;

    [NativeTypeName("#define MM_ATT_MICROELECTRONICS 139")]
    public const int MM_ATT_MICROELECTRONICS = 139;

    [NativeTypeName("#define MM_OSPREY 140")]
    public const int MM_OSPREY = 140;

    [NativeTypeName("#define MM_MEDIATRIX 141")]
    public const int MM_MEDIATRIX = 141;

    [NativeTypeName("#define MM_SOUNDESIGNS 142")]
    public const int MM_SOUNDESIGNS = 142;

    [NativeTypeName("#define MM_ALDIGITAL 143")]
    public const int MM_ALDIGITAL = 143;

    [NativeTypeName("#define MM_SPECTRUM_SIGNAL_PROCESSING 144")]
    public const int MM_SPECTRUM_SIGNAL_PROCESSING = 144;

    [NativeTypeName("#define MM_ECS 145")]
    public const int MM_ECS = 145;

    [NativeTypeName("#define MM_AMD 146")]
    public const int MM_AMD = 146;

    [NativeTypeName("#define MM_COREDYNAMICS 147")]
    public const int MM_COREDYNAMICS = 147;

    [NativeTypeName("#define MM_CANAM 148")]
    public const int MM_CANAM = 148;

    [NativeTypeName("#define MM_SOFTSOUND 149")]
    public const int MM_SOFTSOUND = 149;

    [NativeTypeName("#define MM_NORRIS 150")]
    public const int MM_NORRIS = 150;

    [NativeTypeName("#define MM_DDD 151")]
    public const int MM_DDD = 151;

    [NativeTypeName("#define MM_EUPHONICS 152")]
    public const int MM_EUPHONICS = 152;

    [NativeTypeName("#define MM_PRECEPT 153")]
    public const int MM_PRECEPT = 153;

    [NativeTypeName("#define MM_CRYSTAL_NET 154")]
    public const int MM_CRYSTAL_NET = 154;

    [NativeTypeName("#define MM_CHROMATIC 155")]
    public const int MM_CHROMATIC = 155;

    [NativeTypeName("#define MM_VOICEINFO 156")]
    public const int MM_VOICEINFO = 156;

    [NativeTypeName("#define MM_VIENNASYS 157")]
    public const int MM_VIENNASYS = 157;

    [NativeTypeName("#define MM_CONNECTIX 158")]
    public const int MM_CONNECTIX = 158;

    [NativeTypeName("#define MM_GADGETLABS 159")]
    public const int MM_GADGETLABS = 159;

    [NativeTypeName("#define MM_FRONTIER 160")]
    public const int MM_FRONTIER = 160;

    [NativeTypeName("#define MM_VIONA 161")]
    public const int MM_VIONA = 161;

    [NativeTypeName("#define MM_CASIO 162")]
    public const int MM_CASIO = 162;

    [NativeTypeName("#define MM_DIAMONDMM 163")]
    public const int MM_DIAMONDMM = 163;

    [NativeTypeName("#define MM_S3 164")]
    public const int MM_S3 = 164;

    [NativeTypeName("#define MM_DVISION 165")]
    public const int MM_DVISION = 165;

    [NativeTypeName("#define MM_NETSCAPE 166")]
    public const int MM_NETSCAPE = 166;

    [NativeTypeName("#define MM_SOUNDSPACE 167")]
    public const int MM_SOUNDSPACE = 167;

    [NativeTypeName("#define MM_VANKOEVERING 168")]
    public const int MM_VANKOEVERING = 168;

    [NativeTypeName("#define MM_QTEAM 169")]
    public const int MM_QTEAM = 169;

    [NativeTypeName("#define MM_ZEFIRO 170")]
    public const int MM_ZEFIRO = 170;

    [NativeTypeName("#define MM_STUDER 171")]
    public const int MM_STUDER = 171;

    [NativeTypeName("#define MM_FRAUNHOFER_IIS 172")]
    public const int MM_FRAUNHOFER_IIS = 172;

    [NativeTypeName("#define MM_QUICKNET 173")]
    public const int MM_QUICKNET = 173;

    [NativeTypeName("#define MM_ALARIS 174")]
    public const int MM_ALARIS = 174;

    [NativeTypeName("#define MM_SICRESOURCE 175")]
    public const int MM_SICRESOURCE = 175;

    [NativeTypeName("#define MM_NEOMAGIC 176")]
    public const int MM_NEOMAGIC = 176;

    [NativeTypeName("#define MM_MERGING_TECHNOLOGIES 177")]
    public const int MM_MERGING_TECHNOLOGIES = 177;

    [NativeTypeName("#define MM_XIRLINK 178")]
    public const int MM_XIRLINK = 178;

    [NativeTypeName("#define MM_COLORGRAPH 179")]
    public const int MM_COLORGRAPH = 179;

    [NativeTypeName("#define MM_OTI 180")]
    public const int MM_OTI = 180;

    [NativeTypeName("#define MM_AUREAL 181")]
    public const int MM_AUREAL = 181;

    [NativeTypeName("#define MM_VIVO 182")]
    public const int MM_VIVO = 182;

    [NativeTypeName("#define MM_SHARP 183")]
    public const int MM_SHARP = 183;

    [NativeTypeName("#define MM_LUCENT 184")]
    public const int MM_LUCENT = 184;

    [NativeTypeName("#define MM_ATT 185")]
    public const int MM_ATT = 185;

    [NativeTypeName("#define MM_SUNCOM 186")]
    public const int MM_SUNCOM = 186;

    [NativeTypeName("#define MM_SORVIS 187")]
    public const int MM_SORVIS = 187;

    [NativeTypeName("#define MM_INVISION 188")]
    public const int MM_INVISION = 188;

    [NativeTypeName("#define MM_BERKOM 189")]
    public const int MM_BERKOM = 189;

    [NativeTypeName("#define MM_MARIAN 190")]
    public const int MM_MARIAN = 190;

    [NativeTypeName("#define MM_DPSINC 191")]
    public const int MM_DPSINC = 191;

    [NativeTypeName("#define MM_BCB 192")]
    public const int MM_BCB = 192;

    [NativeTypeName("#define MM_MOTIONPIXELS 193")]
    public const int MM_MOTIONPIXELS = 193;

    [NativeTypeName("#define MM_QDESIGN 194")]
    public const int MM_QDESIGN = 194;

    [NativeTypeName("#define MM_NMP 195")]
    public const int MM_NMP = 195;

    [NativeTypeName("#define MM_DATAFUSION 196")]
    public const int MM_DATAFUSION = 196;

    [NativeTypeName("#define MM_DUCK 197")]
    public const int MM_DUCK = 197;

    [NativeTypeName("#define MM_FTR 198")]
    public const int MM_FTR = 198;

    [NativeTypeName("#define MM_BERCOS 199")]
    public const int MM_BERCOS = 199;

    [NativeTypeName("#define MM_ONLIVE 200")]
    public const int MM_ONLIVE = 200;

    [NativeTypeName("#define MM_SIEMENS_SBC 201")]
    public const int MM_SIEMENS_SBC = 201;

    [NativeTypeName("#define MM_TERALOGIC 202")]
    public const int MM_TERALOGIC = 202;

    [NativeTypeName("#define MM_PHONET 203")]
    public const int MM_PHONET = 203;

    [NativeTypeName("#define MM_WINBOND 204")]
    public const int MM_WINBOND = 204;

    [NativeTypeName("#define MM_VIRTUALMUSIC 205")]
    public const int MM_VIRTUALMUSIC = 205;

    [NativeTypeName("#define MM_ENET 206")]
    public const int MM_ENET = 206;

    [NativeTypeName("#define MM_GUILLEMOT 207")]
    public const int MM_GUILLEMOT = 207;

    [NativeTypeName("#define MM_EMAGIC 208")]
    public const int MM_EMAGIC = 208;

    [NativeTypeName("#define MM_MWM 209")]
    public const int MM_MWM = 209;

    [NativeTypeName("#define MM_PACIFICRESEARCH 210")]
    public const int MM_PACIFICRESEARCH = 210;

    [NativeTypeName("#define MM_SIPROLAB 211")]
    public const int MM_SIPROLAB = 211;

    [NativeTypeName("#define MM_LYNX 212")]
    public const int MM_LYNX = 212;

    [NativeTypeName("#define MM_SPECTRUM_PRODUCTIONS 213")]
    public const int MM_SPECTRUM_PRODUCTIONS = 213;

    [NativeTypeName("#define MM_DICTAPHONE 214")]
    public const int MM_DICTAPHONE = 214;

    [NativeTypeName("#define MM_QUALCOMM 215")]
    public const int MM_QUALCOMM = 215;

    [NativeTypeName("#define MM_RZS 216")]
    public const int MM_RZS = 216;

    [NativeTypeName("#define MM_AUDIOSCIENCE 217")]
    public const int MM_AUDIOSCIENCE = 217;

    [NativeTypeName("#define MM_PINNACLE 218")]
    public const int MM_PINNACLE = 218;

    [NativeTypeName("#define MM_EES 219")]
    public const int MM_EES = 219;

    [NativeTypeName("#define MM_HAFTMANN 220")]
    public const int MM_HAFTMANN = 220;

    [NativeTypeName("#define MM_LUCID 221")]
    public const int MM_LUCID = 221;

    [NativeTypeName("#define MM_HEADSPACE 222")]
    public const int MM_HEADSPACE = 222;

    [NativeTypeName("#define MM_UNISYS 223")]
    public const int MM_UNISYS = 223;

    [NativeTypeName("#define MM_LUMINOSITI 224")]
    public const int MM_LUMINOSITI = 224;

    [NativeTypeName("#define MM_ACTIVEVOICE 225")]
    public const int MM_ACTIVEVOICE = 225;

    [NativeTypeName("#define MM_DTS 226")]
    public const int MM_DTS = 226;

    [NativeTypeName("#define MM_DIGIGRAM 227")]
    public const int MM_DIGIGRAM = 227;

    [NativeTypeName("#define MM_SOFTLAB_NSK 228")]
    public const int MM_SOFTLAB_NSK = 228;

    [NativeTypeName("#define MM_FORTEMEDIA 229")]
    public const int MM_FORTEMEDIA = 229;

    [NativeTypeName("#define MM_SONORUS 230")]
    public const int MM_SONORUS = 230;

    [NativeTypeName("#define MM_ARRAY 231")]
    public const int MM_ARRAY = 231;

    [NativeTypeName("#define MM_DATARAN 232")]
    public const int MM_DATARAN = 232;

    [NativeTypeName("#define MM_I_LINK 233")]
    public const int MM_I_LINK = 233;

    [NativeTypeName("#define MM_SELSIUS_SYSTEMS 234")]
    public const int MM_SELSIUS_SYSTEMS = 234;

    [NativeTypeName("#define MM_ADMOS 235")]
    public const int MM_ADMOS = 235;

    [NativeTypeName("#define MM_LEXICON 236")]
    public const int MM_LEXICON = 236;

    [NativeTypeName("#define MM_SGI 237")]
    public const int MM_SGI = 237;

    [NativeTypeName("#define MM_IPI 238")]
    public const int MM_IPI = 238;

    [NativeTypeName("#define MM_ICE 239")]
    public const int MM_ICE = 239;

    [NativeTypeName("#define MM_VQST 240")]
    public const int MM_VQST = 240;

    [NativeTypeName("#define MM_ETEK 241")]
    public const int MM_ETEK = 241;

    [NativeTypeName("#define MM_CS 242")]
    public const int MM_CS = 242;

    [NativeTypeName("#define MM_ALESIS 243")]
    public const int MM_ALESIS = 243;

    [NativeTypeName("#define MM_INTERNET 244")]
    public const int MM_INTERNET = 244;

    [NativeTypeName("#define MM_SONY 245")]
    public const int MM_SONY = 245;

    [NativeTypeName("#define MM_HYPERACTIVE 246")]
    public const int MM_HYPERACTIVE = 246;

    [NativeTypeName("#define MM_UHER_INFORMATIC 247")]
    public const int MM_UHER_INFORMATIC = 247;

    [NativeTypeName("#define MM_SYDEC_NV 248")]
    public const int MM_SYDEC_NV = 248;

    [NativeTypeName("#define MM_FLEXION 249")]
    public const int MM_FLEXION = 249;

    [NativeTypeName("#define MM_VIA 250")]
    public const int MM_VIA = 250;

    [NativeTypeName("#define MM_MICRONAS 251")]
    public const int MM_MICRONAS = 251;

    [NativeTypeName("#define MM_ANALOGDEVICES 252")]
    public const int MM_ANALOGDEVICES = 252;

    [NativeTypeName("#define MM_HP 253")]
    public const int MM_HP = 253;

    [NativeTypeName("#define MM_MATROX_DIV 254")]
    public const int MM_MATROX_DIV = 254;

    [NativeTypeName("#define MM_QUICKAUDIO 255")]
    public const int MM_QUICKAUDIO = 255;

    [NativeTypeName("#define MM_YOUCOM 256")]
    public const int MM_YOUCOM = 256;

    [NativeTypeName("#define MM_RICHMOND 257")]
    public const int MM_RICHMOND = 257;

    [NativeTypeName("#define MM_IODD 258")]
    public const int MM_IODD = 258;

    [NativeTypeName("#define MM_ICCC 259")]
    public const int MM_ICCC = 259;

    [NativeTypeName("#define MM_3COM 260")]
    public const int MM_3COM = 260;

    [NativeTypeName("#define MM_MALDEN 261")]
    public const int MM_MALDEN = 261;

    [NativeTypeName("#define MM_3DFX 262")]
    public const int MM_3DFX = 262;

    [NativeTypeName("#define MM_MINDMAKER 263")]
    public const int MM_MINDMAKER = 263;

    [NativeTypeName("#define MM_TELEKOL 264")]
    public const int MM_TELEKOL = 264;

    [NativeTypeName("#define MM_ST_MICROELECTRONICS 265")]
    public const int MM_ST_MICROELECTRONICS = 265;

    [NativeTypeName("#define MM_ALGOVISION 266")]
    public const int MM_ALGOVISION = 266;

    [NativeTypeName("#define MM_UNMAPPED 0xffff")]
    public const int MM_UNMAPPED = 0xffff;

    [NativeTypeName("#define MM_PID_UNMAPPED MM_UNMAPPED")]
    public const int MM_PID_UNMAPPED = 0xffff;

    [NativeTypeName("#define MM_MIDI_MAPPER 1")]
    public const int MM_MIDI_MAPPER = 1;

    [NativeTypeName("#define MM_WAVE_MAPPER 2")]
    public const int MM_WAVE_MAPPER = 2;

    [NativeTypeName("#define MM_SNDBLST_MIDIOUT 3")]
    public const int MM_SNDBLST_MIDIOUT = 3;

    [NativeTypeName("#define MM_SNDBLST_MIDIIN 4")]
    public const int MM_SNDBLST_MIDIIN = 4;

    [NativeTypeName("#define MM_SNDBLST_SYNTH 5")]
    public const int MM_SNDBLST_SYNTH = 5;

    [NativeTypeName("#define MM_SNDBLST_WAVEOUT 6")]
    public const int MM_SNDBLST_WAVEOUT = 6;

    [NativeTypeName("#define MM_SNDBLST_WAVEIN 7")]
    public const int MM_SNDBLST_WAVEIN = 7;

    [NativeTypeName("#define MM_ADLIB 9")]
    public const int MM_ADLIB = 9;

    [NativeTypeName("#define MM_MPU401_MIDIOUT 10")]
    public const int MM_MPU401_MIDIOUT = 10;

    [NativeTypeName("#define MM_MPU401_MIDIIN 11")]
    public const int MM_MPU401_MIDIIN = 11;

    [NativeTypeName("#define MM_PC_JOYSTICK 12")]
    public const int MM_PC_JOYSTICK = 12;

    [NativeTypeName("#define MM_PCSPEAKER_WAVEOUT 13")]
    public const int MM_PCSPEAKER_WAVEOUT = 13;

    [NativeTypeName("#define MM_MSFT_WSS_WAVEIN 14")]
    public const int MM_MSFT_WSS_WAVEIN = 14;

    [NativeTypeName("#define MM_MSFT_WSS_WAVEOUT 15")]
    public const int MM_MSFT_WSS_WAVEOUT = 15;

    [NativeTypeName("#define MM_MSFT_WSS_FMSYNTH_STEREO 16")]
    public const int MM_MSFT_WSS_FMSYNTH_STEREO = 16;

    [NativeTypeName("#define MM_MSFT_WSS_MIXER 17")]
    public const int MM_MSFT_WSS_MIXER = 17;

    [NativeTypeName("#define MM_MSFT_WSS_OEM_WAVEIN 18")]
    public const int MM_MSFT_WSS_OEM_WAVEIN = 18;

    [NativeTypeName("#define MM_MSFT_WSS_OEM_WAVEOUT 19")]
    public const int MM_MSFT_WSS_OEM_WAVEOUT = 19;

    [NativeTypeName("#define MM_MSFT_WSS_OEM_FMSYNTH_STEREO 20")]
    public const int MM_MSFT_WSS_OEM_FMSYNTH_STEREO = 20;

    [NativeTypeName("#define MM_MSFT_WSS_AUX 21")]
    public const int MM_MSFT_WSS_AUX = 21;

    [NativeTypeName("#define MM_MSFT_WSS_OEM_AUX 22")]
    public const int MM_MSFT_WSS_OEM_AUX = 22;

    [NativeTypeName("#define MM_MSFT_GENERIC_WAVEIN 23")]
    public const int MM_MSFT_GENERIC_WAVEIN = 23;

    [NativeTypeName("#define MM_MSFT_GENERIC_WAVEOUT 24")]
    public const int MM_MSFT_GENERIC_WAVEOUT = 24;

    [NativeTypeName("#define MM_MSFT_GENERIC_MIDIIN 25")]
    public const int MM_MSFT_GENERIC_MIDIIN = 25;

    [NativeTypeName("#define MM_MSFT_GENERIC_MIDIOUT 26")]
    public const int MM_MSFT_GENERIC_MIDIOUT = 26;

    [NativeTypeName("#define MM_MSFT_GENERIC_MIDISYNTH 27")]
    public const int MM_MSFT_GENERIC_MIDISYNTH = 27;

    [NativeTypeName("#define MM_MSFT_GENERIC_AUX_LINE 28")]
    public const int MM_MSFT_GENERIC_AUX_LINE = 28;

    [NativeTypeName("#define MM_MSFT_GENERIC_AUX_MIC 29")]
    public const int MM_MSFT_GENERIC_AUX_MIC = 29;

    [NativeTypeName("#define MM_MSFT_GENERIC_AUX_CD 30")]
    public const int MM_MSFT_GENERIC_AUX_CD = 30;

    [NativeTypeName("#define MM_MSFT_WSS_OEM_MIXER 31")]
    public const int MM_MSFT_WSS_OEM_MIXER = 31;

    [NativeTypeName("#define MM_MSFT_MSACM 32")]
    public const int MM_MSFT_MSACM = 32;

    [NativeTypeName("#define MM_MSFT_ACM_MSADPCM 33")]
    public const int MM_MSFT_ACM_MSADPCM = 33;

    [NativeTypeName("#define MM_MSFT_ACM_IMAADPCM 34")]
    public const int MM_MSFT_ACM_IMAADPCM = 34;

    [NativeTypeName("#define MM_MSFT_ACM_MSFILTER 35")]
    public const int MM_MSFT_ACM_MSFILTER = 35;

    [NativeTypeName("#define MM_MSFT_ACM_GSM610 36")]
    public const int MM_MSFT_ACM_GSM610 = 36;

    [NativeTypeName("#define MM_MSFT_ACM_G711 37")]
    public const int MM_MSFT_ACM_G711 = 37;

    [NativeTypeName("#define MM_MSFT_ACM_PCM 38")]
    public const int MM_MSFT_ACM_PCM = 38;

    [NativeTypeName("#define MM_WSS_SB16_WAVEIN 39")]
    public const int MM_WSS_SB16_WAVEIN = 39;

    [NativeTypeName("#define MM_WSS_SB16_WAVEOUT 40")]
    public const int MM_WSS_SB16_WAVEOUT = 40;

    [NativeTypeName("#define MM_WSS_SB16_MIDIIN 41")]
    public const int MM_WSS_SB16_MIDIIN = 41;

    [NativeTypeName("#define MM_WSS_SB16_MIDIOUT 42")]
    public const int MM_WSS_SB16_MIDIOUT = 42;

    [NativeTypeName("#define MM_WSS_SB16_SYNTH 43")]
    public const int MM_WSS_SB16_SYNTH = 43;

    [NativeTypeName("#define MM_WSS_SB16_AUX_LINE 44")]
    public const int MM_WSS_SB16_AUX_LINE = 44;

    [NativeTypeName("#define MM_WSS_SB16_AUX_CD 45")]
    public const int MM_WSS_SB16_AUX_CD = 45;

    [NativeTypeName("#define MM_WSS_SB16_MIXER 46")]
    public const int MM_WSS_SB16_MIXER = 46;

    [NativeTypeName("#define MM_WSS_SBPRO_WAVEIN 47")]
    public const int MM_WSS_SBPRO_WAVEIN = 47;

    [NativeTypeName("#define MM_WSS_SBPRO_WAVEOUT 48")]
    public const int MM_WSS_SBPRO_WAVEOUT = 48;

    [NativeTypeName("#define MM_WSS_SBPRO_MIDIIN 49")]
    public const int MM_WSS_SBPRO_MIDIIN = 49;

    [NativeTypeName("#define MM_WSS_SBPRO_MIDIOUT 50")]
    public const int MM_WSS_SBPRO_MIDIOUT = 50;

    [NativeTypeName("#define MM_WSS_SBPRO_SYNTH 51")]
    public const int MM_WSS_SBPRO_SYNTH = 51;

    [NativeTypeName("#define MM_WSS_SBPRO_AUX_LINE 52")]
    public const int MM_WSS_SBPRO_AUX_LINE = 52;

    [NativeTypeName("#define MM_WSS_SBPRO_AUX_CD 53")]
    public const int MM_WSS_SBPRO_AUX_CD = 53;

    [NativeTypeName("#define MM_WSS_SBPRO_MIXER 54")]
    public const int MM_WSS_SBPRO_MIXER = 54;

    [NativeTypeName("#define MM_MSFT_WSS_NT_WAVEIN 55")]
    public const int MM_MSFT_WSS_NT_WAVEIN = 55;

    [NativeTypeName("#define MM_MSFT_WSS_NT_WAVEOUT 56")]
    public const int MM_MSFT_WSS_NT_WAVEOUT = 56;

    [NativeTypeName("#define MM_MSFT_WSS_NT_FMSYNTH_STEREO 57")]
    public const int MM_MSFT_WSS_NT_FMSYNTH_STEREO = 57;

    [NativeTypeName("#define MM_MSFT_WSS_NT_MIXER 58")]
    public const int MM_MSFT_WSS_NT_MIXER = 58;

    [NativeTypeName("#define MM_MSFT_WSS_NT_AUX 59")]
    public const int MM_MSFT_WSS_NT_AUX = 59;

    [NativeTypeName("#define MM_MSFT_SB16_WAVEIN 60")]
    public const int MM_MSFT_SB16_WAVEIN = 60;

    [NativeTypeName("#define MM_MSFT_SB16_WAVEOUT 61")]
    public const int MM_MSFT_SB16_WAVEOUT = 61;

    [NativeTypeName("#define MM_MSFT_SB16_MIDIIN 62")]
    public const int MM_MSFT_SB16_MIDIIN = 62;

    [NativeTypeName("#define MM_MSFT_SB16_MIDIOUT 63")]
    public const int MM_MSFT_SB16_MIDIOUT = 63;

    [NativeTypeName("#define MM_MSFT_SB16_SYNTH 64")]
    public const int MM_MSFT_SB16_SYNTH = 64;

    [NativeTypeName("#define MM_MSFT_SB16_AUX_LINE 65")]
    public const int MM_MSFT_SB16_AUX_LINE = 65;

    [NativeTypeName("#define MM_MSFT_SB16_AUX_CD 66")]
    public const int MM_MSFT_SB16_AUX_CD = 66;

    [NativeTypeName("#define MM_MSFT_SB16_MIXER 67")]
    public const int MM_MSFT_SB16_MIXER = 67;

    [NativeTypeName("#define MM_MSFT_SBPRO_WAVEIN 68")]
    public const int MM_MSFT_SBPRO_WAVEIN = 68;

    [NativeTypeName("#define MM_MSFT_SBPRO_WAVEOUT 69")]
    public const int MM_MSFT_SBPRO_WAVEOUT = 69;

    [NativeTypeName("#define MM_MSFT_SBPRO_MIDIIN 70")]
    public const int MM_MSFT_SBPRO_MIDIIN = 70;

    [NativeTypeName("#define MM_MSFT_SBPRO_MIDIOUT 71")]
    public const int MM_MSFT_SBPRO_MIDIOUT = 71;

    [NativeTypeName("#define MM_MSFT_SBPRO_SYNTH 72")]
    public const int MM_MSFT_SBPRO_SYNTH = 72;

    [NativeTypeName("#define MM_MSFT_SBPRO_AUX_LINE 73")]
    public const int MM_MSFT_SBPRO_AUX_LINE = 73;

    [NativeTypeName("#define MM_MSFT_SBPRO_AUX_CD 74")]
    public const int MM_MSFT_SBPRO_AUX_CD = 74;

    [NativeTypeName("#define MM_MSFT_SBPRO_MIXER 75")]
    public const int MM_MSFT_SBPRO_MIXER = 75;

    [NativeTypeName("#define MM_MSFT_MSOPL_SYNTH 76")]
    public const int MM_MSFT_MSOPL_SYNTH = 76;

    [NativeTypeName("#define MM_MSFT_VMDMS_LINE_WAVEIN 80")]
    public const int MM_MSFT_VMDMS_LINE_WAVEIN = 80;

    [NativeTypeName("#define MM_MSFT_VMDMS_LINE_WAVEOUT 81")]
    public const int MM_MSFT_VMDMS_LINE_WAVEOUT = 81;

    [NativeTypeName("#define MM_MSFT_VMDMS_HANDSET_WAVEIN 82")]
    public const int MM_MSFT_VMDMS_HANDSET_WAVEIN = 82;

    [NativeTypeName("#define MM_MSFT_VMDMS_HANDSET_WAVEOUT 83")]
    public const int MM_MSFT_VMDMS_HANDSET_WAVEOUT = 83;

    [NativeTypeName("#define MM_MSFT_VMDMW_LINE_WAVEIN 84")]
    public const int MM_MSFT_VMDMW_LINE_WAVEIN = 84;

    [NativeTypeName("#define MM_MSFT_VMDMW_LINE_WAVEOUT 85")]
    public const int MM_MSFT_VMDMW_LINE_WAVEOUT = 85;

    [NativeTypeName("#define MM_MSFT_VMDMW_HANDSET_WAVEIN 86")]
    public const int MM_MSFT_VMDMW_HANDSET_WAVEIN = 86;

    [NativeTypeName("#define MM_MSFT_VMDMW_HANDSET_WAVEOUT 87")]
    public const int MM_MSFT_VMDMW_HANDSET_WAVEOUT = 87;

    [NativeTypeName("#define MM_MSFT_VMDMW_MIXER 88")]
    public const int MM_MSFT_VMDMW_MIXER = 88;

    [NativeTypeName("#define MM_MSFT_VMDM_GAME_WAVEOUT 89")]
    public const int MM_MSFT_VMDM_GAME_WAVEOUT = 89;

    [NativeTypeName("#define MM_MSFT_VMDM_GAME_WAVEIN 90")]
    public const int MM_MSFT_VMDM_GAME_WAVEIN = 90;

    [NativeTypeName("#define MM_MSFT_ACM_MSNAUDIO 91")]
    public const int MM_MSFT_ACM_MSNAUDIO = 91;

    [NativeTypeName("#define MM_MSFT_ACM_MSG723 92")]
    public const int MM_MSFT_ACM_MSG723 = 92;

    [NativeTypeName("#define MM_MSFT_ACM_MSRT24 93")]
    public const int MM_MSFT_ACM_MSRT24 = 93;

    [NativeTypeName("#define MM_MSFT_WDMAUDIO_WAVEOUT 100")]
    public const int MM_MSFT_WDMAUDIO_WAVEOUT = 100;

    [NativeTypeName("#define MM_MSFT_WDMAUDIO_WAVEIN 101")]
    public const int MM_MSFT_WDMAUDIO_WAVEIN = 101;

    [NativeTypeName("#define MM_MSFT_WDMAUDIO_MIDIOUT 102")]
    public const int MM_MSFT_WDMAUDIO_MIDIOUT = 102;

    [NativeTypeName("#define MM_MSFT_WDMAUDIO_MIDIIN 103")]
    public const int MM_MSFT_WDMAUDIO_MIDIIN = 103;

    [NativeTypeName("#define MM_MSFT_WDMAUDIO_MIXER 104")]
    public const int MM_MSFT_WDMAUDIO_MIXER = 104;

    [NativeTypeName("#define MM_MSFT_WDMAUDIO_AUX 105")]
    public const int MM_MSFT_WDMAUDIO_AUX = 105;

    [NativeTypeName("#define MM_CREATIVE_SB15_WAVEIN 1")]
    public const int MM_CREATIVE_SB15_WAVEIN = 1;

    [NativeTypeName("#define MM_CREATIVE_SB20_WAVEIN 2")]
    public const int MM_CREATIVE_SB20_WAVEIN = 2;

    [NativeTypeName("#define MM_CREATIVE_SBPRO_WAVEIN 3")]
    public const int MM_CREATIVE_SBPRO_WAVEIN = 3;

    [NativeTypeName("#define MM_CREATIVE_SBP16_WAVEIN 4")]
    public const int MM_CREATIVE_SBP16_WAVEIN = 4;

    [NativeTypeName("#define MM_CREATIVE_PHNBLST_WAVEIN 5")]
    public const int MM_CREATIVE_PHNBLST_WAVEIN = 5;

    [NativeTypeName("#define MM_CREATIVE_SB15_WAVEOUT 101")]
    public const int MM_CREATIVE_SB15_WAVEOUT = 101;

    [NativeTypeName("#define MM_CREATIVE_SB20_WAVEOUT 102")]
    public const int MM_CREATIVE_SB20_WAVEOUT = 102;

    [NativeTypeName("#define MM_CREATIVE_SBPRO_WAVEOUT 103")]
    public const int MM_CREATIVE_SBPRO_WAVEOUT = 103;

    [NativeTypeName("#define MM_CREATIVE_SBP16_WAVEOUT 104")]
    public const int MM_CREATIVE_SBP16_WAVEOUT = 104;

    [NativeTypeName("#define MM_CREATIVE_PHNBLST_WAVEOUT 105")]
    public const int MM_CREATIVE_PHNBLST_WAVEOUT = 105;

    [NativeTypeName("#define MM_CREATIVE_MIDIOUT 201")]
    public const int MM_CREATIVE_MIDIOUT = 201;

    [NativeTypeName("#define MM_CREATIVE_MIDIIN 202")]
    public const int MM_CREATIVE_MIDIIN = 202;

    [NativeTypeName("#define MM_CREATIVE_FMSYNTH_MONO 301")]
    public const int MM_CREATIVE_FMSYNTH_MONO = 301;

    [NativeTypeName("#define MM_CREATIVE_FMSYNTH_STEREO 302")]
    public const int MM_CREATIVE_FMSYNTH_STEREO = 302;

    [NativeTypeName("#define MM_CREATIVE_MIDI_AWE32 303")]
    public const int MM_CREATIVE_MIDI_AWE32 = 303;

    [NativeTypeName("#define MM_CREATIVE_AUX_CD 401")]
    public const int MM_CREATIVE_AUX_CD = 401;

    [NativeTypeName("#define MM_CREATIVE_AUX_LINE 402")]
    public const int MM_CREATIVE_AUX_LINE = 402;

    [NativeTypeName("#define MM_CREATIVE_AUX_MIC 403")]
    public const int MM_CREATIVE_AUX_MIC = 403;

    [NativeTypeName("#define MM_CREATIVE_AUX_MASTER 404")]
    public const int MM_CREATIVE_AUX_MASTER = 404;

    [NativeTypeName("#define MM_CREATIVE_AUX_PCSPK 405")]
    public const int MM_CREATIVE_AUX_PCSPK = 405;

    [NativeTypeName("#define MM_CREATIVE_AUX_WAVE 406")]
    public const int MM_CREATIVE_AUX_WAVE = 406;

    [NativeTypeName("#define MM_CREATIVE_AUX_MIDI 407")]
    public const int MM_CREATIVE_AUX_MIDI = 407;

    [NativeTypeName("#define MM_CREATIVE_SBPRO_MIXER 408")]
    public const int MM_CREATIVE_SBPRO_MIXER = 408;

    [NativeTypeName("#define MM_CREATIVE_SB16_MIXER 409")]
    public const int MM_CREATIVE_SB16_MIXER = 409;

    [NativeTypeName("#define MM_MEDIAVISION_PROAUDIO 0x10")]
    public const int MM_MEDIAVISION_PROAUDIO = 0x10;

    [NativeTypeName("#define MM_PROAUD_MIDIOUT (MM_MEDIAVISION_PROAUDIO+1)")]
    public const int MM_PROAUD_MIDIOUT = (0x10 + 1);

    [NativeTypeName("#define MM_PROAUD_MIDIIN (MM_MEDIAVISION_PROAUDIO+2)")]
    public const int MM_PROAUD_MIDIIN = (0x10 + 2);

    [NativeTypeName("#define MM_PROAUD_SYNTH (MM_MEDIAVISION_PROAUDIO+3)")]
    public const int MM_PROAUD_SYNTH = (0x10 + 3);

    [NativeTypeName("#define MM_PROAUD_WAVEOUT (MM_MEDIAVISION_PROAUDIO+4)")]
    public const int MM_PROAUD_WAVEOUT = (0x10 + 4);

    [NativeTypeName("#define MM_PROAUD_WAVEIN (MM_MEDIAVISION_PROAUDIO+5)")]
    public const int MM_PROAUD_WAVEIN = (0x10 + 5);

    [NativeTypeName("#define MM_PROAUD_MIXER (MM_MEDIAVISION_PROAUDIO+6)")]
    public const int MM_PROAUD_MIXER = (0x10 + 6);

    [NativeTypeName("#define MM_PROAUD_AUX (MM_MEDIAVISION_PROAUDIO+7)")]
    public const int MM_PROAUD_AUX = (0x10 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_THUNDER 0x20")]
    public const int MM_MEDIAVISION_THUNDER = 0x20;

    [NativeTypeName("#define MM_THUNDER_SYNTH (MM_MEDIAVISION_THUNDER+3)")]
    public const int MM_THUNDER_SYNTH = (0x20 + 3);

    [NativeTypeName("#define MM_THUNDER_WAVEOUT (MM_MEDIAVISION_THUNDER+4)")]
    public const int MM_THUNDER_WAVEOUT = (0x20 + 4);

    [NativeTypeName("#define MM_THUNDER_WAVEIN (MM_MEDIAVISION_THUNDER+5)")]
    public const int MM_THUNDER_WAVEIN = (0x20 + 5);

    [NativeTypeName("#define MM_THUNDER_AUX (MM_MEDIAVISION_THUNDER+7)")]
    public const int MM_THUNDER_AUX = (0x20 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_TPORT 0x40")]
    public const int MM_MEDIAVISION_TPORT = 0x40;

    [NativeTypeName("#define MM_TPORT_WAVEOUT (MM_MEDIAVISION_TPORT+1)")]
    public const int MM_TPORT_WAVEOUT = (0x40 + 1);

    [NativeTypeName("#define MM_TPORT_WAVEIN (MM_MEDIAVISION_TPORT+2)")]
    public const int MM_TPORT_WAVEIN = (0x40 + 2);

    [NativeTypeName("#define MM_TPORT_SYNTH (MM_MEDIAVISION_TPORT+3)")]
    public const int MM_TPORT_SYNTH = (0x40 + 3);

    [NativeTypeName("#define MM_MEDIAVISION_PROAUDIO_PLUS 0x50")]
    public const int MM_MEDIAVISION_PROAUDIO_PLUS = 0x50;

    [NativeTypeName("#define MM_PROAUD_PLUS_MIDIOUT (MM_MEDIAVISION_PROAUDIO_PLUS+1)")]
    public const int MM_PROAUD_PLUS_MIDIOUT = (0x50 + 1);

    [NativeTypeName("#define MM_PROAUD_PLUS_MIDIIN (MM_MEDIAVISION_PROAUDIO_PLUS+2)")]
    public const int MM_PROAUD_PLUS_MIDIIN = (0x50 + 2);

    [NativeTypeName("#define MM_PROAUD_PLUS_SYNTH (MM_MEDIAVISION_PROAUDIO_PLUS+3)")]
    public const int MM_PROAUD_PLUS_SYNTH = (0x50 + 3);

    [NativeTypeName("#define MM_PROAUD_PLUS_WAVEOUT (MM_MEDIAVISION_PROAUDIO_PLUS+4)")]
    public const int MM_PROAUD_PLUS_WAVEOUT = (0x50 + 4);

    [NativeTypeName("#define MM_PROAUD_PLUS_WAVEIN (MM_MEDIAVISION_PROAUDIO_PLUS+5)")]
    public const int MM_PROAUD_PLUS_WAVEIN = (0x50 + 5);

    [NativeTypeName("#define MM_PROAUD_PLUS_MIXER (MM_MEDIAVISION_PROAUDIO_PLUS+6)")]
    public const int MM_PROAUD_PLUS_MIXER = (0x50 + 6);

    [NativeTypeName("#define MM_PROAUD_PLUS_AUX (MM_MEDIAVISION_PROAUDIO_PLUS+7)")]
    public const int MM_PROAUD_PLUS_AUX = (0x50 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_PROAUDIO_16 0x60")]
    public const int MM_MEDIAVISION_PROAUDIO_16 = 0x60;

    [NativeTypeName("#define MM_PROAUD_16_MIDIOUT (MM_MEDIAVISION_PROAUDIO_16+1)")]
    public const int MM_PROAUD_16_MIDIOUT = (0x60 + 1);

    [NativeTypeName("#define MM_PROAUD_16_MIDIIN (MM_MEDIAVISION_PROAUDIO_16+2)")]
    public const int MM_PROAUD_16_MIDIIN = (0x60 + 2);

    [NativeTypeName("#define MM_PROAUD_16_SYNTH (MM_MEDIAVISION_PROAUDIO_16+3)")]
    public const int MM_PROAUD_16_SYNTH = (0x60 + 3);

    [NativeTypeName("#define MM_PROAUD_16_WAVEOUT (MM_MEDIAVISION_PROAUDIO_16+4)")]
    public const int MM_PROAUD_16_WAVEOUT = (0x60 + 4);

    [NativeTypeName("#define MM_PROAUD_16_WAVEIN (MM_MEDIAVISION_PROAUDIO_16+5)")]
    public const int MM_PROAUD_16_WAVEIN = (0x60 + 5);

    [NativeTypeName("#define MM_PROAUD_16_MIXER (MM_MEDIAVISION_PROAUDIO_16+6)")]
    public const int MM_PROAUD_16_MIXER = (0x60 + 6);

    [NativeTypeName("#define MM_PROAUD_16_AUX (MM_MEDIAVISION_PROAUDIO_16+7)")]
    public const int MM_PROAUD_16_AUX = (0x60 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_PROSTUDIO_16 0x60")]
    public const int MM_MEDIAVISION_PROSTUDIO_16 = 0x60;

    [NativeTypeName("#define MM_STUDIO_16_MIDIOUT (MM_MEDIAVISION_PROSTUDIO_16+1)")]
    public const int MM_STUDIO_16_MIDIOUT = (0x60 + 1);

    [NativeTypeName("#define MM_STUDIO_16_MIDIIN (MM_MEDIAVISION_PROSTUDIO_16+2)")]
    public const int MM_STUDIO_16_MIDIIN = (0x60 + 2);

    [NativeTypeName("#define MM_STUDIO_16_SYNTH (MM_MEDIAVISION_PROSTUDIO_16+3)")]
    public const int MM_STUDIO_16_SYNTH = (0x60 + 3);

    [NativeTypeName("#define MM_STUDIO_16_WAVEOUT (MM_MEDIAVISION_PROSTUDIO_16+4)")]
    public const int MM_STUDIO_16_WAVEOUT = (0x60 + 4);

    [NativeTypeName("#define MM_STUDIO_16_WAVEIN (MM_MEDIAVISION_PROSTUDIO_16+5)")]
    public const int MM_STUDIO_16_WAVEIN = (0x60 + 5);

    [NativeTypeName("#define MM_STUDIO_16_MIXER (MM_MEDIAVISION_PROSTUDIO_16+6)")]
    public const int MM_STUDIO_16_MIXER = (0x60 + 6);

    [NativeTypeName("#define MM_STUDIO_16_AUX (MM_MEDIAVISION_PROSTUDIO_16+7)")]
    public const int MM_STUDIO_16_AUX = (0x60 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_CDPC 0x70")]
    public const int MM_MEDIAVISION_CDPC = 0x70;

    [NativeTypeName("#define MM_CDPC_MIDIOUT (MM_MEDIAVISION_CDPC+1)")]
    public const int MM_CDPC_MIDIOUT = (0x70 + 1);

    [NativeTypeName("#define MM_CDPC_MIDIIN (MM_MEDIAVISION_CDPC+2)")]
    public const int MM_CDPC_MIDIIN = (0x70 + 2);

    [NativeTypeName("#define MM_CDPC_SYNTH (MM_MEDIAVISION_CDPC+3)")]
    public const int MM_CDPC_SYNTH = (0x70 + 3);

    [NativeTypeName("#define MM_CDPC_WAVEOUT (MM_MEDIAVISION_CDPC+4)")]
    public const int MM_CDPC_WAVEOUT = (0x70 + 4);

    [NativeTypeName("#define MM_CDPC_WAVEIN (MM_MEDIAVISION_CDPC+5)")]
    public const int MM_CDPC_WAVEIN = (0x70 + 5);

    [NativeTypeName("#define MM_CDPC_MIXER (MM_MEDIAVISION_CDPC+6)")]
    public const int MM_CDPC_MIXER = (0x70 + 6);

    [NativeTypeName("#define MM_CDPC_AUX (MM_MEDIAVISION_CDPC+7)")]
    public const int MM_CDPC_AUX = (0x70 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_OPUS1208 0x80")]
    public const int MM_MEDIAVISION_OPUS1208 = 0x80;

    [NativeTypeName("#define MM_OPUS401_MIDIOUT (MM_MEDIAVISION_OPUS1208+1)")]
    public const int MM_OPUS401_MIDIOUT = (0x80 + 1);

    [NativeTypeName("#define MM_OPUS401_MIDIIN (MM_MEDIAVISION_OPUS1208+2)")]
    public const int MM_OPUS401_MIDIIN = (0x80 + 2);

    [NativeTypeName("#define MM_OPUS1208_SYNTH (MM_MEDIAVISION_OPUS1208+3)")]
    public const int MM_OPUS1208_SYNTH = (0x80 + 3);

    [NativeTypeName("#define MM_OPUS1208_WAVEOUT (MM_MEDIAVISION_OPUS1208+4)")]
    public const int MM_OPUS1208_WAVEOUT = (0x80 + 4);

    [NativeTypeName("#define MM_OPUS1208_WAVEIN (MM_MEDIAVISION_OPUS1208+5)")]
    public const int MM_OPUS1208_WAVEIN = (0x80 + 5);

    [NativeTypeName("#define MM_OPUS1208_MIXER (MM_MEDIAVISION_OPUS1208+6)")]
    public const int MM_OPUS1208_MIXER = (0x80 + 6);

    [NativeTypeName("#define MM_OPUS1208_AUX (MM_MEDIAVISION_OPUS1208+7)")]
    public const int MM_OPUS1208_AUX = (0x80 + 7);

    [NativeTypeName("#define MM_MEDIAVISION_OPUS1216 0x90")]
    public const int MM_MEDIAVISION_OPUS1216 = 0x90;

    [NativeTypeName("#define MM_OPUS1216_MIDIOUT (MM_MEDIAVISION_OPUS1216+1)")]
    public const int MM_OPUS1216_MIDIOUT = (0x90 + 1);

    [NativeTypeName("#define MM_OPUS1216_MIDIIN (MM_MEDIAVISION_OPUS1216+2)")]
    public const int MM_OPUS1216_MIDIIN = (0x90 + 2);

    [NativeTypeName("#define MM_OPUS1216_SYNTH (MM_MEDIAVISION_OPUS1216+3)")]
    public const int MM_OPUS1216_SYNTH = (0x90 + 3);

    [NativeTypeName("#define MM_OPUS1216_WAVEOUT (MM_MEDIAVISION_OPUS1216+4)")]
    public const int MM_OPUS1216_WAVEOUT = (0x90 + 4);

    [NativeTypeName("#define MM_OPUS1216_WAVEIN (MM_MEDIAVISION_OPUS1216+5)")]
    public const int MM_OPUS1216_WAVEIN = (0x90 + 5);

    [NativeTypeName("#define MM_OPUS1216_MIXER (MM_MEDIAVISION_OPUS1216+6)")]
    public const int MM_OPUS1216_MIXER = (0x90 + 6);

    [NativeTypeName("#define MM_OPUS1216_AUX (MM_MEDIAVISION_OPUS1216+7)")]
    public const int MM_OPUS1216_AUX = (0x90 + 7);

    [NativeTypeName("#define MM_CYRIX_XASYNTH 1")]
    public const int MM_CYRIX_XASYNTH = 1;

    [NativeTypeName("#define MM_CYRIX_XAMIDIIN 2")]
    public const int MM_CYRIX_XAMIDIIN = 2;

    [NativeTypeName("#define MM_CYRIX_XAMIDIOUT 3")]
    public const int MM_CYRIX_XAMIDIOUT = 3;

    [NativeTypeName("#define MM_CYRIX_XAWAVEIN 4")]
    public const int MM_CYRIX_XAWAVEIN = 4;

    [NativeTypeName("#define MM_CYRIX_XAWAVEOUT 5")]
    public const int MM_CYRIX_XAWAVEOUT = 5;

    [NativeTypeName("#define MM_CYRIX_XAAUX 6")]
    public const int MM_CYRIX_XAAUX = 6;

    [NativeTypeName("#define MM_CYRIX_XAMIXER 7")]
    public const int MM_CYRIX_XAMIXER = 7;

    [NativeTypeName("#define MM_PHILIPS_ACM_LPCBB 1")]
    public const int MM_PHILIPS_ACM_LPCBB = 1;

    [NativeTypeName("#define MM_NETXL_XLVIDEO 1")]
    public const int MM_NETXL_XLVIDEO = 1;

    [NativeTypeName("#define MM_ZYXEL_ACM_ADPCM 1")]
    public const int MM_ZYXEL_ACM_ADPCM = 1;

    [NativeTypeName("#define MM_AARDVARK_STUDIO12_WAVEOUT 1")]
    public const int MM_AARDVARK_STUDIO12_WAVEOUT = 1;

    [NativeTypeName("#define MM_AARDVARK_STUDIO12_WAVEIN 2")]
    public const int MM_AARDVARK_STUDIO12_WAVEIN = 2;

    [NativeTypeName("#define MM_AARDVARK_STUDIO88_WAVEOUT 3")]
    public const int MM_AARDVARK_STUDIO88_WAVEOUT = 3;

    [NativeTypeName("#define MM_AARDVARK_STUDIO88_WAVEIN 4")]
    public const int MM_AARDVARK_STUDIO88_WAVEIN = 4;

    [NativeTypeName("#define MM_BINTEC_TAPI_WAVE 1")]
    public const int MM_BINTEC_TAPI_WAVE = 1;

    [NativeTypeName("#define MM_HEWLETT_PACKARD_CU_CODEC 1")]
    public const int MM_HEWLETT_PACKARD_CU_CODEC = 1;

    [NativeTypeName("#define MM_MITEL_TALKTO_LINE_WAVEOUT 100")]
    public const int MM_MITEL_TALKTO_LINE_WAVEOUT = 100;

    [NativeTypeName("#define MM_MITEL_TALKTO_LINE_WAVEIN 101")]
    public const int MM_MITEL_TALKTO_LINE_WAVEIN = 101;

    [NativeTypeName("#define MM_MITEL_TALKTO_HANDSET_WAVEOUT 102")]
    public const int MM_MITEL_TALKTO_HANDSET_WAVEOUT = 102;

    [NativeTypeName("#define MM_MITEL_TALKTO_HANDSET_WAVEIN 103")]
    public const int MM_MITEL_TALKTO_HANDSET_WAVEIN = 103;

    [NativeTypeName("#define MM_MITEL_TALKTO_BRIDGED_WAVEOUT 104")]
    public const int MM_MITEL_TALKTO_BRIDGED_WAVEOUT = 104;

    [NativeTypeName("#define MM_MITEL_TALKTO_BRIDGED_WAVEIN 105")]
    public const int MM_MITEL_TALKTO_BRIDGED_WAVEIN = 105;

    [NativeTypeName("#define MM_MITEL_MPA_HANDSET_WAVEOUT 200")]
    public const int MM_MITEL_MPA_HANDSET_WAVEOUT = 200;

    [NativeTypeName("#define MM_MITEL_MPA_HANDSET_WAVEIN 201")]
    public const int MM_MITEL_MPA_HANDSET_WAVEIN = 201;

    [NativeTypeName("#define MM_MITEL_MPA_HANDSFREE_WAVEOUT 202")]
    public const int MM_MITEL_MPA_HANDSFREE_WAVEOUT = 202;

    [NativeTypeName("#define MM_MITEL_MPA_HANDSFREE_WAVEIN 203")]
    public const int MM_MITEL_MPA_HANDSFREE_WAVEIN = 203;

    [NativeTypeName("#define MM_MITEL_MPA_LINE1_WAVEOUT 204")]
    public const int MM_MITEL_MPA_LINE1_WAVEOUT = 204;

    [NativeTypeName("#define MM_MITEL_MPA_LINE1_WAVEIN 205")]
    public const int MM_MITEL_MPA_LINE1_WAVEIN = 205;

    [NativeTypeName("#define MM_MITEL_MPA_LINE2_WAVEOUT 206")]
    public const int MM_MITEL_MPA_LINE2_WAVEOUT = 206;

    [NativeTypeName("#define MM_MITEL_MPA_LINE2_WAVEIN 207")]
    public const int MM_MITEL_MPA_LINE2_WAVEIN = 207;

    [NativeTypeName("#define MM_MITEL_MEDIAPATH_WAVEOUT 300")]
    public const int MM_MITEL_MEDIAPATH_WAVEOUT = 300;

    [NativeTypeName("#define MM_MITEL_MEDIAPATH_WAVEIN 301")]
    public const int MM_MITEL_MEDIAPATH_WAVEIN = 301;

    [NativeTypeName("#define MM_SNI_ACM_G721 1")]
    public const int MM_SNI_ACM_G721 = 1;

    [NativeTypeName("#define MM_EMU_APSSYNTH 1")]
    public const int MM_EMU_APSSYNTH = 1;

    [NativeTypeName("#define MM_EMU_APSMIDIIN 2")]
    public const int MM_EMU_APSMIDIIN = 2;

    [NativeTypeName("#define MM_EMU_APSMIDIOUT 3")]
    public const int MM_EMU_APSMIDIOUT = 3;

    [NativeTypeName("#define MM_EMU_APSWAVEIN 4")]
    public const int MM_EMU_APSWAVEIN = 4;

    [NativeTypeName("#define MM_EMU_APSWAVEOUT 5")]
    public const int MM_EMU_APSWAVEOUT = 5;

    [NativeTypeName("#define MM_ARTISOFT_SBWAVEIN 1")]
    public const int MM_ARTISOFT_SBWAVEIN = 1;

    [NativeTypeName("#define MM_ARTISOFT_SBWAVEOUT 2")]
    public const int MM_ARTISOFT_SBWAVEOUT = 2;

    [NativeTypeName("#define MM_TBS_TROPEZ_WAVEIN 37")]
    public const int MM_TBS_TROPEZ_WAVEIN = 37;

    [NativeTypeName("#define MM_TBS_TROPEZ_WAVEOUT 38")]
    public const int MM_TBS_TROPEZ_WAVEOUT = 38;

    [NativeTypeName("#define MM_TBS_TROPEZ_AUX1 39")]
    public const int MM_TBS_TROPEZ_AUX1 = 39;

    [NativeTypeName("#define MM_TBS_TROPEZ_AUX2 40")]
    public const int MM_TBS_TROPEZ_AUX2 = 40;

    [NativeTypeName("#define MM_TBS_TROPEZ_LINE 41")]
    public const int MM_TBS_TROPEZ_LINE = 41;

    [NativeTypeName("#define MM_MMOTION_WAVEAUX 1")]
    public const int MM_MMOTION_WAVEAUX = 1;

    [NativeTypeName("#define MM_MMOTION_WAVEOUT 2")]
    public const int MM_MMOTION_WAVEOUT = 2;

    [NativeTypeName("#define MM_MMOTION_WAVEIN 3")]
    public const int MM_MMOTION_WAVEIN = 3;

    [NativeTypeName("#define MM_IBM_PCMCIA_WAVEIN 11")]
    public const int MM_IBM_PCMCIA_WAVEIN = 11;

    [NativeTypeName("#define MM_IBM_PCMCIA_WAVEOUT 12")]
    public const int MM_IBM_PCMCIA_WAVEOUT = 12;

    [NativeTypeName("#define MM_IBM_PCMCIA_SYNTH 13")]
    public const int MM_IBM_PCMCIA_SYNTH = 13;

    [NativeTypeName("#define MM_IBM_PCMCIA_MIDIIN 14")]
    public const int MM_IBM_PCMCIA_MIDIIN = 14;

    [NativeTypeName("#define MM_IBM_PCMCIA_MIDIOUT 15")]
    public const int MM_IBM_PCMCIA_MIDIOUT = 15;

    [NativeTypeName("#define MM_IBM_PCMCIA_AUX 16")]
    public const int MM_IBM_PCMCIA_AUX = 16;

    [NativeTypeName("#define MM_IBM_THINKPAD200 17")]
    public const int MM_IBM_THINKPAD200 = 17;

    [NativeTypeName("#define MM_IBM_MWAVE_WAVEIN 18")]
    public const int MM_IBM_MWAVE_WAVEIN = 18;

    [NativeTypeName("#define MM_IBM_MWAVE_WAVEOUT 19")]
    public const int MM_IBM_MWAVE_WAVEOUT = 19;

    [NativeTypeName("#define MM_IBM_MWAVE_MIXER 20")]
    public const int MM_IBM_MWAVE_MIXER = 20;

    [NativeTypeName("#define MM_IBM_MWAVE_MIDIIN 21")]
    public const int MM_IBM_MWAVE_MIDIIN = 21;

    [NativeTypeName("#define MM_IBM_MWAVE_MIDIOUT 22")]
    public const int MM_IBM_MWAVE_MIDIOUT = 22;

    [NativeTypeName("#define MM_IBM_MWAVE_AUX 23")]
    public const int MM_IBM_MWAVE_AUX = 23;

    [NativeTypeName("#define MM_IBM_WC_MIDIOUT 30")]
    public const int MM_IBM_WC_MIDIOUT = 30;

    [NativeTypeName("#define MM_IBM_WC_WAVEOUT 31")]
    public const int MM_IBM_WC_WAVEOUT = 31;

    [NativeTypeName("#define MM_IBM_WC_MIXEROUT 33")]
    public const int MM_IBM_WC_MIXEROUT = 33;

    [NativeTypeName("#define MM_VOCALTEC_WAVEOUT 1")]
    public const int MM_VOCALTEC_WAVEOUT = 1;

    [NativeTypeName("#define MM_VOCALTEC_WAVEIN 2")]
    public const int MM_VOCALTEC_WAVEIN = 2;

    [NativeTypeName("#define MM_ROLAND_RAP10_MIDIOUT 10")]
    public const int MM_ROLAND_RAP10_MIDIOUT = 10;

    [NativeTypeName("#define MM_ROLAND_RAP10_MIDIIN 11")]
    public const int MM_ROLAND_RAP10_MIDIIN = 11;

    [NativeTypeName("#define MM_ROLAND_RAP10_SYNTH 12")]
    public const int MM_ROLAND_RAP10_SYNTH = 12;

    [NativeTypeName("#define MM_ROLAND_RAP10_WAVEOUT 13")]
    public const int MM_ROLAND_RAP10_WAVEOUT = 13;

    [NativeTypeName("#define MM_ROLAND_RAP10_WAVEIN 14")]
    public const int MM_ROLAND_RAP10_WAVEIN = 14;

    [NativeTypeName("#define MM_ROLAND_MPU401_MIDIOUT 15")]
    public const int MM_ROLAND_MPU401_MIDIOUT = 15;

    [NativeTypeName("#define MM_ROLAND_MPU401_MIDIIN 16")]
    public const int MM_ROLAND_MPU401_MIDIIN = 16;

    [NativeTypeName("#define MM_ROLAND_SMPU_MIDIOUTA 17")]
    public const int MM_ROLAND_SMPU_MIDIOUTA = 17;

    [NativeTypeName("#define MM_ROLAND_SMPU_MIDIOUTB 18")]
    public const int MM_ROLAND_SMPU_MIDIOUTB = 18;

    [NativeTypeName("#define MM_ROLAND_SMPU_MIDIINA 19")]
    public const int MM_ROLAND_SMPU_MIDIINA = 19;

    [NativeTypeName("#define MM_ROLAND_SMPU_MIDIINB 20")]
    public const int MM_ROLAND_SMPU_MIDIINB = 20;

    [NativeTypeName("#define MM_ROLAND_SC7_MIDIOUT 21")]
    public const int MM_ROLAND_SC7_MIDIOUT = 21;

    [NativeTypeName("#define MM_ROLAND_SC7_MIDIIN 22")]
    public const int MM_ROLAND_SC7_MIDIIN = 22;

    [NativeTypeName("#define MM_ROLAND_SERIAL_MIDIOUT 23")]
    public const int MM_ROLAND_SERIAL_MIDIOUT = 23;

    [NativeTypeName("#define MM_ROLAND_SERIAL_MIDIIN 24")]
    public const int MM_ROLAND_SERIAL_MIDIIN = 24;

    [NativeTypeName("#define MM_ROLAND_SCP_MIDIOUT 38")]
    public const int MM_ROLAND_SCP_MIDIOUT = 38;

    [NativeTypeName("#define MM_ROLAND_SCP_MIDIIN 39")]
    public const int MM_ROLAND_SCP_MIDIIN = 39;

    [NativeTypeName("#define MM_ROLAND_SCP_WAVEOUT 40")]
    public const int MM_ROLAND_SCP_WAVEOUT = 40;

    [NativeTypeName("#define MM_ROLAND_SCP_WAVEIN 41")]
    public const int MM_ROLAND_SCP_WAVEIN = 41;

    [NativeTypeName("#define MM_ROLAND_SCP_MIXER 42")]
    public const int MM_ROLAND_SCP_MIXER = 42;

    [NativeTypeName("#define MM_ROLAND_SCP_AUX 48")]
    public const int MM_ROLAND_SCP_AUX = 48;

    [NativeTypeName("#define MM_DSP_SOLUTIONS_WAVEOUT 1")]
    public const int MM_DSP_SOLUTIONS_WAVEOUT = 1;

    [NativeTypeName("#define MM_DSP_SOLUTIONS_WAVEIN 2")]
    public const int MM_DSP_SOLUTIONS_WAVEIN = 2;

    [NativeTypeName("#define MM_DSP_SOLUTIONS_SYNTH 3")]
    public const int MM_DSP_SOLUTIONS_SYNTH = 3;

    [NativeTypeName("#define MM_DSP_SOLUTIONS_AUX 4")]
    public const int MM_DSP_SOLUTIONS_AUX = 4;

    [NativeTypeName("#define MM_NEC_73_86_SYNTH 5")]
    public const int MM_NEC_73_86_SYNTH = 5;

    [NativeTypeName("#define MM_NEC_73_86_WAVEOUT 6")]
    public const int MM_NEC_73_86_WAVEOUT = 6;

    [NativeTypeName("#define MM_NEC_73_86_WAVEIN 7")]
    public const int MM_NEC_73_86_WAVEIN = 7;

    [NativeTypeName("#define MM_NEC_26_SYNTH 9")]
    public const int MM_NEC_26_SYNTH = 9;

    [NativeTypeName("#define MM_NEC_MPU401_MIDIOUT 10")]
    public const int MM_NEC_MPU401_MIDIOUT = 10;

    [NativeTypeName("#define MM_NEC_MPU401_MIDIIN 11")]
    public const int MM_NEC_MPU401_MIDIIN = 11;

    [NativeTypeName("#define MM_NEC_JOYSTICK 12")]
    public const int MM_NEC_JOYSTICK = 12;

    [NativeTypeName("#define MM_WANGLABS_WAVEIN1 1")]
    public const int MM_WANGLABS_WAVEIN1 = 1;

    [NativeTypeName("#define MM_WANGLABS_WAVEOUT1 2")]
    public const int MM_WANGLABS_WAVEOUT1 = 2;

    [NativeTypeName("#define MM_TANDY_VISWAVEIN 1")]
    public const int MM_TANDY_VISWAVEIN = 1;

    [NativeTypeName("#define MM_TANDY_VISWAVEOUT 2")]
    public const int MM_TANDY_VISWAVEOUT = 2;

    [NativeTypeName("#define MM_TANDY_VISBIOSSYNTH 3")]
    public const int MM_TANDY_VISBIOSSYNTH = 3;

    [NativeTypeName("#define MM_TANDY_SENS_MMAWAVEIN 4")]
    public const int MM_TANDY_SENS_MMAWAVEIN = 4;

    [NativeTypeName("#define MM_TANDY_SENS_MMAWAVEOUT 5")]
    public const int MM_TANDY_SENS_MMAWAVEOUT = 5;

    [NativeTypeName("#define MM_TANDY_SENS_MMAMIDIIN 6")]
    public const int MM_TANDY_SENS_MMAMIDIIN = 6;

    [NativeTypeName("#define MM_TANDY_SENS_MMAMIDIOUT 7")]
    public const int MM_TANDY_SENS_MMAMIDIOUT = 7;

    [NativeTypeName("#define MM_TANDY_SENS_VISWAVEOUT 8")]
    public const int MM_TANDY_SENS_VISWAVEOUT = 8;

    [NativeTypeName("#define MM_TANDY_PSSJWAVEIN 9")]
    public const int MM_TANDY_PSSJWAVEIN = 9;

    [NativeTypeName("#define MM_TANDY_PSSJWAVEOUT 10")]
    public const int MM_TANDY_PSSJWAVEOUT = 10;

    [NativeTypeName("#define MM_ANTEX_SX12_WAVEIN 1")]
    public const int MM_ANTEX_SX12_WAVEIN = 1;

    [NativeTypeName("#define MM_ANTEX_SX12_WAVEOUT 2")]
    public const int MM_ANTEX_SX12_WAVEOUT = 2;

    [NativeTypeName("#define MM_ANTEX_SX15_WAVEIN 3")]
    public const int MM_ANTEX_SX15_WAVEIN = 3;

    [NativeTypeName("#define MM_ANTEX_SX15_WAVEOUT 4")]
    public const int MM_ANTEX_SX15_WAVEOUT = 4;

    [NativeTypeName("#define MM_ANTEX_VP625_WAVEIN 5")]
    public const int MM_ANTEX_VP625_WAVEIN = 5;

    [NativeTypeName("#define MM_ANTEX_VP625_WAVEOUT 6")]
    public const int MM_ANTEX_VP625_WAVEOUT = 6;

    [NativeTypeName("#define MM_ANTEX_AUDIOPORT22_WAVEIN 7")]
    public const int MM_ANTEX_AUDIOPORT22_WAVEIN = 7;

    [NativeTypeName("#define MM_ANTEX_AUDIOPORT22_WAVEOUT 8")]
    public const int MM_ANTEX_AUDIOPORT22_WAVEOUT = 8;

    [NativeTypeName("#define MM_ANTEX_AUDIOPORT22_FEEDTHRU 9")]
    public const int MM_ANTEX_AUDIOPORT22_FEEDTHRU = 9;

    [NativeTypeName("#define MM_INTELOPD_WAVEIN 1")]
    public const int MM_INTELOPD_WAVEIN = 1;

    [NativeTypeName("#define MM_INTELOPD_WAVEOUT 101")]
    public const int MM_INTELOPD_WAVEOUT = 101;

    [NativeTypeName("#define MM_INTELOPD_AUX 401")]
    public const int MM_INTELOPD_AUX = 401;

    [NativeTypeName("#define MM_INTEL_NSPMODEMLINEIN 501")]
    public const int MM_INTEL_NSPMODEMLINEIN = 501;

    [NativeTypeName("#define MM_INTEL_NSPMODEMLINEOUT 502")]
    public const int MM_INTEL_NSPMODEMLINEOUT = 502;

    [NativeTypeName("#define MM_VAL_MICROKEY_AP_WAVEIN 1")]
    public const int MM_VAL_MICROKEY_AP_WAVEIN = 1;

    [NativeTypeName("#define MM_VAL_MICROKEY_AP_WAVEOUT 2")]
    public const int MM_VAL_MICROKEY_AP_WAVEOUT = 2;

    [NativeTypeName("#define MM_INTERACTIVE_WAVEIN 0x45")]
    public const int MM_INTERACTIVE_WAVEIN = 0x45;

    [NativeTypeName("#define MM_INTERACTIVE_WAVEOUT 0x45")]
    public const int MM_INTERACTIVE_WAVEOUT = 0x45;

    [NativeTypeName("#define MM_YAMAHA_GSS_SYNTH 0x01")]
    public const int MM_YAMAHA_GSS_SYNTH = 0x01;

    [NativeTypeName("#define MM_YAMAHA_GSS_WAVEOUT 0x02")]
    public const int MM_YAMAHA_GSS_WAVEOUT = 0x02;

    [NativeTypeName("#define MM_YAMAHA_GSS_WAVEIN 0x03")]
    public const int MM_YAMAHA_GSS_WAVEIN = 0x03;

    [NativeTypeName("#define MM_YAMAHA_GSS_MIDIOUT 0x04")]
    public const int MM_YAMAHA_GSS_MIDIOUT = 0x04;

    [NativeTypeName("#define MM_YAMAHA_GSS_MIDIIN 0x05")]
    public const int MM_YAMAHA_GSS_MIDIIN = 0x05;

    [NativeTypeName("#define MM_YAMAHA_GSS_AUX 0x06")]
    public const int MM_YAMAHA_GSS_AUX = 0x06;

    [NativeTypeName("#define MM_YAMAHA_SERIAL_MIDIOUT 0x07")]
    public const int MM_YAMAHA_SERIAL_MIDIOUT = 0x07;

    [NativeTypeName("#define MM_YAMAHA_SERIAL_MIDIIN 0x08")]
    public const int MM_YAMAHA_SERIAL_MIDIIN = 0x08;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_WAVEOUT 0x10")]
    public const int MM_YAMAHA_OPL3SA_WAVEOUT = 0x10;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_WAVEIN 0x11")]
    public const int MM_YAMAHA_OPL3SA_WAVEIN = 0x11;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_FMSYNTH 0x12")]
    public const int MM_YAMAHA_OPL3SA_FMSYNTH = 0x12;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_YSYNTH 0x13")]
    public const int MM_YAMAHA_OPL3SA_YSYNTH = 0x13;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_MIDIOUT 0x14")]
    public const int MM_YAMAHA_OPL3SA_MIDIOUT = 0x14;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_MIDIIN 0x15")]
    public const int MM_YAMAHA_OPL3SA_MIDIIN = 0x15;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_MIXER 0x17")]
    public const int MM_YAMAHA_OPL3SA_MIXER = 0x17;

    [NativeTypeName("#define MM_YAMAHA_OPL3SA_JOYSTICK 0x18")]
    public const int MM_YAMAHA_OPL3SA_JOYSTICK = 0x18;

    [NativeTypeName("#define MM_YAMAHA_YMF724LEG_MIDIOUT 0x19")]
    public const int MM_YAMAHA_YMF724LEG_MIDIOUT = 0x19;

    [NativeTypeName("#define MM_YAMAHA_YMF724LEG_MIDIIN 0x1a")]
    public const int MM_YAMAHA_YMF724LEG_MIDIIN = 0x1a;

    [NativeTypeName("#define MM_YAMAHA_YMF724_WAVEOUT 0x1b")]
    public const int MM_YAMAHA_YMF724_WAVEOUT = 0x1b;

    [NativeTypeName("#define MM_YAMAHA_YMF724_WAVEIN 0x1c")]
    public const int MM_YAMAHA_YMF724_WAVEIN = 0x1c;

    [NativeTypeName("#define MM_YAMAHA_YMF724_MIDIOUT 0x1d")]
    public const int MM_YAMAHA_YMF724_MIDIOUT = 0x1d;

    [NativeTypeName("#define MM_YAMAHA_YMF724_AUX 0x1e")]
    public const int MM_YAMAHA_YMF724_AUX = 0x1e;

    [NativeTypeName("#define MM_YAMAHA_YMF724_MIXER 0x1f")]
    public const int MM_YAMAHA_YMF724_MIXER = 0x1f;

    [NativeTypeName("#define MM_YAMAHA_YMF724LEG_FMSYNTH 0x20")]
    public const int MM_YAMAHA_YMF724LEG_FMSYNTH = 0x20;

    [NativeTypeName("#define MM_YAMAHA_YMF724LEG_MIXER 0x21")]
    public const int MM_YAMAHA_YMF724LEG_MIXER = 0x21;

    [NativeTypeName("#define MM_YAMAHA_SXG_MIDIOUT 0x22")]
    public const int MM_YAMAHA_SXG_MIDIOUT = 0x22;

    [NativeTypeName("#define MM_YAMAHA_SXG_WAVEOUT 0x23")]
    public const int MM_YAMAHA_SXG_WAVEOUT = 0x23;

    [NativeTypeName("#define MM_YAMAHA_SXG_MIXER 0x24")]
    public const int MM_YAMAHA_SXG_MIXER = 0x24;

    [NativeTypeName("#define MM_YAMAHA_ACXG_WAVEIN 0x25")]
    public const int MM_YAMAHA_ACXG_WAVEIN = 0x25;

    [NativeTypeName("#define MM_YAMAHA_ACXG_WAVEOUT 0x26")]
    public const int MM_YAMAHA_ACXG_WAVEOUT = 0x26;

    [NativeTypeName("#define MM_YAMAHA_ACXG_MIDIOUT 0x27")]
    public const int MM_YAMAHA_ACXG_MIDIOUT = 0x27;

    [NativeTypeName("#define MM_YAMAHA_ACXG_MIXER 0x28")]
    public const int MM_YAMAHA_ACXG_MIXER = 0x28;

    [NativeTypeName("#define MM_YAMAHA_ACXG_AUX 0x29")]
    public const int MM_YAMAHA_ACXG_AUX = 0x29;

    [NativeTypeName("#define MM_EVEREX_CARRIER 1")]
    public const int MM_EVEREX_CARRIER = 1;

    [NativeTypeName("#define MM_ECHO_SYNTH 1")]
    public const int MM_ECHO_SYNTH = 1;

    [NativeTypeName("#define MM_ECHO_WAVEOUT 2")]
    public const int MM_ECHO_WAVEOUT = 2;

    [NativeTypeName("#define MM_ECHO_WAVEIN 3")]
    public const int MM_ECHO_WAVEIN = 3;

    [NativeTypeName("#define MM_ECHO_MIDIOUT 4")]
    public const int MM_ECHO_MIDIOUT = 4;

    [NativeTypeName("#define MM_ECHO_MIDIIN 5")]
    public const int MM_ECHO_MIDIIN = 5;

    [NativeTypeName("#define MM_ECHO_AUX 6")]
    public const int MM_ECHO_AUX = 6;

    [NativeTypeName("#define MM_SIERRA_ARIA_MIDIOUT 0x14")]
    public const int MM_SIERRA_ARIA_MIDIOUT = 0x14;

    [NativeTypeName("#define MM_SIERRA_ARIA_MIDIIN 0x15")]
    public const int MM_SIERRA_ARIA_MIDIIN = 0x15;

    [NativeTypeName("#define MM_SIERRA_ARIA_SYNTH 0x16")]
    public const int MM_SIERRA_ARIA_SYNTH = 0x16;

    [NativeTypeName("#define MM_SIERRA_ARIA_WAVEOUT 0x17")]
    public const int MM_SIERRA_ARIA_WAVEOUT = 0x17;

    [NativeTypeName("#define MM_SIERRA_ARIA_WAVEIN 0x18")]
    public const int MM_SIERRA_ARIA_WAVEIN = 0x18;

    [NativeTypeName("#define MM_SIERRA_ARIA_AUX 0x19")]
    public const int MM_SIERRA_ARIA_AUX = 0x19;

    [NativeTypeName("#define MM_SIERRA_ARIA_AUX2 0x20")]
    public const int MM_SIERRA_ARIA_AUX2 = 0x20;

    [NativeTypeName("#define MM_SIERRA_QUARTET_WAVEIN 0x50")]
    public const int MM_SIERRA_QUARTET_WAVEIN = 0x50;

    [NativeTypeName("#define MM_SIERRA_QUARTET_WAVEOUT 0x51")]
    public const int MM_SIERRA_QUARTET_WAVEOUT = 0x51;

    [NativeTypeName("#define MM_SIERRA_QUARTET_MIDIIN 0x52")]
    public const int MM_SIERRA_QUARTET_MIDIIN = 0x52;

    [NativeTypeName("#define MM_SIERRA_QUARTET_MIDIOUT 0x53")]
    public const int MM_SIERRA_QUARTET_MIDIOUT = 0x53;

    [NativeTypeName("#define MM_SIERRA_QUARTET_SYNTH 0x54")]
    public const int MM_SIERRA_QUARTET_SYNTH = 0x54;

    [NativeTypeName("#define MM_SIERRA_QUARTET_AUX_CD 0x55")]
    public const int MM_SIERRA_QUARTET_AUX_CD = 0x55;

    [NativeTypeName("#define MM_SIERRA_QUARTET_AUX_LINE 0x56")]
    public const int MM_SIERRA_QUARTET_AUX_LINE = 0x56;

    [NativeTypeName("#define MM_SIERRA_QUARTET_AUX_MODEM 0x57")]
    public const int MM_SIERRA_QUARTET_AUX_MODEM = 0x57;

    [NativeTypeName("#define MM_SIERRA_QUARTET_MIXER 0x58")]
    public const int MM_SIERRA_QUARTET_MIXER = 0x58;

    [NativeTypeName("#define MM_CAT_WAVEOUT 1")]
    public const int MM_CAT_WAVEOUT = 1;

    [NativeTypeName("#define MM_DSP_GROUP_TRUESPEECH 1")]
    public const int MM_DSP_GROUP_TRUESPEECH = 1;

    [NativeTypeName("#define MM_MELABS_MIDI2GO 1")]
    public const int MM_MELABS_MIDI2GO = 1;

    [NativeTypeName("#define MM_ESS_AMWAVEOUT 0x01")]
    public const int MM_ESS_AMWAVEOUT = 0x01;

    [NativeTypeName("#define MM_ESS_AMWAVEIN 0x02")]
    public const int MM_ESS_AMWAVEIN = 0x02;

    [NativeTypeName("#define MM_ESS_AMAUX 0x03")]
    public const int MM_ESS_AMAUX = 0x03;

    [NativeTypeName("#define MM_ESS_AMSYNTH 0x04")]
    public const int MM_ESS_AMSYNTH = 0x04;

    [NativeTypeName("#define MM_ESS_AMMIDIOUT 0x05")]
    public const int MM_ESS_AMMIDIOUT = 0x05;

    [NativeTypeName("#define MM_ESS_AMMIDIIN 0x06")]
    public const int MM_ESS_AMMIDIIN = 0x06;

    [NativeTypeName("#define MM_ESS_MIXER 0x07")]
    public const int MM_ESS_MIXER = 0x07;

    [NativeTypeName("#define MM_ESS_AUX_CD 0x08")]
    public const int MM_ESS_AUX_CD = 0x08;

    [NativeTypeName("#define MM_ESS_MPU401_MIDIOUT 0x09")]
    public const int MM_ESS_MPU401_MIDIOUT = 0x09;

    [NativeTypeName("#define MM_ESS_MPU401_MIDIIN 0x0A")]
    public const int MM_ESS_MPU401_MIDIIN = 0x0A;

    [NativeTypeName("#define MM_ESS_ES488_WAVEOUT 0x10")]
    public const int MM_ESS_ES488_WAVEOUT = 0x10;

    [NativeTypeName("#define MM_ESS_ES488_WAVEIN 0x11")]
    public const int MM_ESS_ES488_WAVEIN = 0x11;

    [NativeTypeName("#define MM_ESS_ES488_MIXER 0x12")]
    public const int MM_ESS_ES488_MIXER = 0x12;

    [NativeTypeName("#define MM_ESS_ES688_WAVEOUT 0x13")]
    public const int MM_ESS_ES688_WAVEOUT = 0x13;

    [NativeTypeName("#define MM_ESS_ES688_WAVEIN 0x14")]
    public const int MM_ESS_ES688_WAVEIN = 0x14;

    [NativeTypeName("#define MM_ESS_ES688_MIXER 0x15")]
    public const int MM_ESS_ES688_MIXER = 0x15;

    [NativeTypeName("#define MM_ESS_ES1488_WAVEOUT 0x16")]
    public const int MM_ESS_ES1488_WAVEOUT = 0x16;

    [NativeTypeName("#define MM_ESS_ES1488_WAVEIN 0x17")]
    public const int MM_ESS_ES1488_WAVEIN = 0x17;

    [NativeTypeName("#define MM_ESS_ES1488_MIXER 0x18")]
    public const int MM_ESS_ES1488_MIXER = 0x18;

    [NativeTypeName("#define MM_ESS_ES1688_WAVEOUT 0x19")]
    public const int MM_ESS_ES1688_WAVEOUT = 0x19;

    [NativeTypeName("#define MM_ESS_ES1688_WAVEIN 0x1A")]
    public const int MM_ESS_ES1688_WAVEIN = 0x1A;

    [NativeTypeName("#define MM_ESS_ES1688_MIXER 0x1B")]
    public const int MM_ESS_ES1688_MIXER = 0x1B;

    [NativeTypeName("#define MM_ESS_ES1788_WAVEOUT 0x1C")]
    public const int MM_ESS_ES1788_WAVEOUT = 0x1C;

    [NativeTypeName("#define MM_ESS_ES1788_WAVEIN 0x1D")]
    public const int MM_ESS_ES1788_WAVEIN = 0x1D;

    [NativeTypeName("#define MM_ESS_ES1788_MIXER 0x1E")]
    public const int MM_ESS_ES1788_MIXER = 0x1E;

    [NativeTypeName("#define MM_ESS_ES1888_WAVEOUT 0x1F")]
    public const int MM_ESS_ES1888_WAVEOUT = 0x1F;

    [NativeTypeName("#define MM_ESS_ES1888_WAVEIN 0x20")]
    public const int MM_ESS_ES1888_WAVEIN = 0x20;

    [NativeTypeName("#define MM_ESS_ES1888_MIXER 0x21")]
    public const int MM_ESS_ES1888_MIXER = 0x21;

    [NativeTypeName("#define MM_ESS_ES1868_WAVEOUT 0x22")]
    public const int MM_ESS_ES1868_WAVEOUT = 0x22;

    [NativeTypeName("#define MM_ESS_ES1868_WAVEIN 0x23")]
    public const int MM_ESS_ES1868_WAVEIN = 0x23;

    [NativeTypeName("#define MM_ESS_ES1868_MIXER 0x24")]
    public const int MM_ESS_ES1868_MIXER = 0x24;

    [NativeTypeName("#define MM_ESS_ES1878_WAVEOUT 0x25")]
    public const int MM_ESS_ES1878_WAVEOUT = 0x25;

    [NativeTypeName("#define MM_ESS_ES1878_WAVEIN 0x26")]
    public const int MM_ESS_ES1878_WAVEIN = 0x26;

    [NativeTypeName("#define MM_ESS_ES1878_MIXER 0x27")]
    public const int MM_ESS_ES1878_MIXER = 0x27;

    [NativeTypeName("#define MM_CANOPUS_ACM_DVREX 1")]
    public const int MM_CANOPUS_ACM_DVREX = 1;

    [NativeTypeName("#define MM_EPS_FMSND 1")]
    public const int MM_EPS_FMSND = 1;

    [NativeTypeName("#define MM_TRUEVISION_WAVEIN1 1")]
    public const int MM_TRUEVISION_WAVEIN1 = 1;

    [NativeTypeName("#define MM_TRUEVISION_WAVEOUT1 2")]
    public const int MM_TRUEVISION_WAVEOUT1 = 2;

    [NativeTypeName("#define MM_AZTECH_MIDIOUT 3")]
    public const int MM_AZTECH_MIDIOUT = 3;

    [NativeTypeName("#define MM_AZTECH_MIDIIN 4")]
    public const int MM_AZTECH_MIDIIN = 4;

    [NativeTypeName("#define MM_AZTECH_WAVEIN 17")]
    public const int MM_AZTECH_WAVEIN = 17;

    [NativeTypeName("#define MM_AZTECH_WAVEOUT 18")]
    public const int MM_AZTECH_WAVEOUT = 18;

    [NativeTypeName("#define MM_AZTECH_FMSYNTH 20")]
    public const int MM_AZTECH_FMSYNTH = 20;

    [NativeTypeName("#define MM_AZTECH_MIXER 21")]
    public const int MM_AZTECH_MIXER = 21;

    [NativeTypeName("#define MM_AZTECH_PRO16_WAVEIN 33")]
    public const int MM_AZTECH_PRO16_WAVEIN = 33;

    [NativeTypeName("#define MM_AZTECH_PRO16_WAVEOUT 34")]
    public const int MM_AZTECH_PRO16_WAVEOUT = 34;

    [NativeTypeName("#define MM_AZTECH_PRO16_FMSYNTH 38")]
    public const int MM_AZTECH_PRO16_FMSYNTH = 38;

    [NativeTypeName("#define MM_AZTECH_DSP16_WAVEIN 65")]
    public const int MM_AZTECH_DSP16_WAVEIN = 65;

    [NativeTypeName("#define MM_AZTECH_DSP16_WAVEOUT 66")]
    public const int MM_AZTECH_DSP16_WAVEOUT = 66;

    [NativeTypeName("#define MM_AZTECH_DSP16_FMSYNTH 68")]
    public const int MM_AZTECH_DSP16_FMSYNTH = 68;

    [NativeTypeName("#define MM_AZTECH_DSP16_WAVESYNTH 70")]
    public const int MM_AZTECH_DSP16_WAVESYNTH = 70;

    [NativeTypeName("#define MM_AZTECH_NOVA16_WAVEIN 71")]
    public const int MM_AZTECH_NOVA16_WAVEIN = 71;

    [NativeTypeName("#define MM_AZTECH_NOVA16_WAVEOUT 72")]
    public const int MM_AZTECH_NOVA16_WAVEOUT = 72;

    [NativeTypeName("#define MM_AZTECH_NOVA16_MIXER 73")]
    public const int MM_AZTECH_NOVA16_MIXER = 73;

    [NativeTypeName("#define MM_AZTECH_WASH16_WAVEIN 74")]
    public const int MM_AZTECH_WASH16_WAVEIN = 74;

    [NativeTypeName("#define MM_AZTECH_WASH16_WAVEOUT 75")]
    public const int MM_AZTECH_WASH16_WAVEOUT = 75;

    [NativeTypeName("#define MM_AZTECH_WASH16_MIXER 76")]
    public const int MM_AZTECH_WASH16_MIXER = 76;

    [NativeTypeName("#define MM_AZTECH_AUX_CD 401")]
    public const int MM_AZTECH_AUX_CD = 401;

    [NativeTypeName("#define MM_AZTECH_AUX_LINE 402")]
    public const int MM_AZTECH_AUX_LINE = 402;

    [NativeTypeName("#define MM_AZTECH_AUX_MIC 403")]
    public const int MM_AZTECH_AUX_MIC = 403;

    [NativeTypeName("#define MM_AZTECH_AUX 404")]
    public const int MM_AZTECH_AUX = 404;

    [NativeTypeName("#define MM_VIDEOLOGIC_MSWAVEIN 1")]
    public const int MM_VIDEOLOGIC_MSWAVEIN = 1;

    [NativeTypeName("#define MM_VIDEOLOGIC_MSWAVEOUT 2")]
    public const int MM_VIDEOLOGIC_MSWAVEOUT = 2;

    [NativeTypeName("#define MM_KORG_PCIF_MIDIOUT 1")]
    public const int MM_KORG_PCIF_MIDIOUT = 1;

    [NativeTypeName("#define MM_KORG_PCIF_MIDIIN 2")]
    public const int MM_KORG_PCIF_MIDIIN = 2;

    [NativeTypeName("#define MM_KORG_1212IO_MSWAVEIN 3")]
    public const int MM_KORG_1212IO_MSWAVEIN = 3;

    [NativeTypeName("#define MM_KORG_1212IO_MSWAVEOUT 4")]
    public const int MM_KORG_1212IO_MSWAVEOUT = 4;

    [NativeTypeName("#define MM_APT_ACE100CD 1")]
    public const int MM_APT_ACE100CD = 1;

    [NativeTypeName("#define MM_ICS_WAVEDECK_WAVEOUT 1")]
    public const int MM_ICS_WAVEDECK_WAVEOUT = 1;

    [NativeTypeName("#define MM_ICS_WAVEDECK_WAVEIN 2")]
    public const int MM_ICS_WAVEDECK_WAVEIN = 2;

    [NativeTypeName("#define MM_ICS_WAVEDECK_MIXER 3")]
    public const int MM_ICS_WAVEDECK_MIXER = 3;

    [NativeTypeName("#define MM_ICS_WAVEDECK_AUX 4")]
    public const int MM_ICS_WAVEDECK_AUX = 4;

    [NativeTypeName("#define MM_ICS_WAVEDECK_SYNTH 5")]
    public const int MM_ICS_WAVEDECK_SYNTH = 5;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_WAVEOUT 6")]
    public const int MM_ICS_WAVEDEC_SB_WAVEOUT = 6;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_WAVEIN 7")]
    public const int MM_ICS_WAVEDEC_SB_WAVEIN = 7;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_FM_MIDIOUT 8")]
    public const int MM_ICS_WAVEDEC_SB_FM_MIDIOUT = 8;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_MPU401_MIDIOUT 9")]
    public const int MM_ICS_WAVEDEC_SB_MPU401_MIDIOUT = 9;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_MPU401_MIDIIN 10")]
    public const int MM_ICS_WAVEDEC_SB_MPU401_MIDIIN = 10;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_MIXER 11")]
    public const int MM_ICS_WAVEDEC_SB_MIXER = 11;

    [NativeTypeName("#define MM_ICS_WAVEDEC_SB_AUX 12")]
    public const int MM_ICS_WAVEDEC_SB_AUX = 12;

    [NativeTypeName("#define MM_ICS_2115_LITE_MIDIOUT 13")]
    public const int MM_ICS_2115_LITE_MIDIOUT = 13;

    [NativeTypeName("#define MM_ICS_2120_LITE_MIDIOUT 14")]
    public const int MM_ICS_2120_LITE_MIDIOUT = 14;

    [NativeTypeName("#define MM_ITERATEDSYS_FUFCODEC 1")]
    public const int MM_ITERATEDSYS_FUFCODEC = 1;

    [NativeTypeName("#define MM_METHEUS_ZIPPER 1")]
    public const int MM_METHEUS_ZIPPER = 1;

    [NativeTypeName("#define MM_WINNOV_CAVIAR_WAVEIN 1")]
    public const int MM_WINNOV_CAVIAR_WAVEIN = 1;

    [NativeTypeName("#define MM_WINNOV_CAVIAR_WAVEOUT 2")]
    public const int MM_WINNOV_CAVIAR_WAVEOUT = 2;

    [NativeTypeName("#define MM_WINNOV_CAVIAR_VIDC 3")]
    public const int MM_WINNOV_CAVIAR_VIDC = 3;

    [NativeTypeName("#define MM_WINNOV_CAVIAR_CHAMPAGNE 4")]
    public const int MM_WINNOV_CAVIAR_CHAMPAGNE = 4;

    [NativeTypeName("#define MM_WINNOV_CAVIAR_YUV8 5")]
    public const int MM_WINNOV_CAVIAR_YUV8 = 5;

    [NativeTypeName("#define MM_NCR_BA_WAVEIN 1")]
    public const int MM_NCR_BA_WAVEIN = 1;

    [NativeTypeName("#define MM_NCR_BA_WAVEOUT 2")]
    public const int MM_NCR_BA_WAVEOUT = 2;

    [NativeTypeName("#define MM_NCR_BA_SYNTH 3")]
    public const int MM_NCR_BA_SYNTH = 3;

    [NativeTypeName("#define MM_NCR_BA_AUX 4")]
    public const int MM_NCR_BA_AUX = 4;

    [NativeTypeName("#define MM_NCR_BA_MIXER 5")]
    public const int MM_NCR_BA_MIXER = 5;

    [NativeTypeName("#define MM_AST_MODEMWAVE_WAVEIN 13")]
    public const int MM_AST_MODEMWAVE_WAVEIN = 13;

    [NativeTypeName("#define MM_AST_MODEMWAVE_WAVEOUT 14")]
    public const int MM_AST_MODEMWAVE_WAVEOUT = 14;

    [NativeTypeName("#define MM_WILLOWPOND_FMSYNTH_STEREO 20")]
    public const int MM_WILLOWPOND_FMSYNTH_STEREO = 20;

    [NativeTypeName("#define MM_WILLOWPOND_MPU401 21")]
    public const int MM_WILLOWPOND_MPU401 = 21;

    [NativeTypeName("#define MM_WILLOWPOND_SNDPORT_WAVEIN 100")]
    public const int MM_WILLOWPOND_SNDPORT_WAVEIN = 100;

    [NativeTypeName("#define MM_WILLOWPOND_SNDPORT_WAVEOUT 101")]
    public const int MM_WILLOWPOND_SNDPORT_WAVEOUT = 101;

    [NativeTypeName("#define MM_WILLOWPOND_SNDPORT_MIXER 102")]
    public const int MM_WILLOWPOND_SNDPORT_MIXER = 102;

    [NativeTypeName("#define MM_WILLOWPOND_SNDPORT_AUX 103")]
    public const int MM_WILLOWPOND_SNDPORT_AUX = 103;

    [NativeTypeName("#define MM_WILLOWPOND_PH_WAVEIN 104")]
    public const int MM_WILLOWPOND_PH_WAVEIN = 104;

    [NativeTypeName("#define MM_WILLOWPOND_PH_WAVEOUT 105")]
    public const int MM_WILLOWPOND_PH_WAVEOUT = 105;

    [NativeTypeName("#define MM_WILLOWPOND_PH_MIXER 106")]
    public const int MM_WILLOWPOND_PH_MIXER = 106;

    [NativeTypeName("#define MM_WILLOWPOND_PH_AUX 107")]
    public const int MM_WILLOWPOND_PH_AUX = 107;

    [NativeTypeName("#define MM_WILLOPOND_SNDCOMM_WAVEIN 108")]
    public const int MM_WILLOPOND_SNDCOMM_WAVEIN = 108;

    [NativeTypeName("#define MM_WILLOWPOND_SNDCOMM_WAVEOUT 109")]
    public const int MM_WILLOWPOND_SNDCOMM_WAVEOUT = 109;

    [NativeTypeName("#define MM_WILLOWPOND_SNDCOMM_MIXER 110")]
    public const int MM_WILLOWPOND_SNDCOMM_MIXER = 110;

    [NativeTypeName("#define MM_WILLOWPOND_SNDCOMM_AUX 111")]
    public const int MM_WILLOWPOND_SNDCOMM_AUX = 111;

    [NativeTypeName("#define MM_WILLOWPOND_GENERIC_WAVEIN 112")]
    public const int MM_WILLOWPOND_GENERIC_WAVEIN = 112;

    [NativeTypeName("#define MM_WILLOWPOND_GENERIC_WAVEOUT 113")]
    public const int MM_WILLOWPOND_GENERIC_WAVEOUT = 113;

    [NativeTypeName("#define MM_WILLOWPOND_GENERIC_MIXER 114")]
    public const int MM_WILLOWPOND_GENERIC_MIXER = 114;

    [NativeTypeName("#define MM_WILLOWPOND_GENERIC_AUX 115")]
    public const int MM_WILLOWPOND_GENERIC_AUX = 115;

    [NativeTypeName("#define MM_VITEC_VMAKER 1")]
    public const int MM_VITEC_VMAKER = 1;

    [NativeTypeName("#define MM_VITEC_VMPRO 2")]
    public const int MM_VITEC_VMPRO = 2;

    [NativeTypeName("#define MM_MOSCOM_VPC2400_IN 1")]
    public const int MM_MOSCOM_VPC2400_IN = 1;

    [NativeTypeName("#define MM_MOSCOM_VPC2400_OUT 2")]
    public const int MM_MOSCOM_VPC2400_OUT = 2;

    [NativeTypeName("#define MM_SILICONSOFT_SC1_WAVEIN 1")]
    public const int MM_SILICONSOFT_SC1_WAVEIN = 1;

    [NativeTypeName("#define MM_SILICONSOFT_SC1_WAVEOUT 2")]
    public const int MM_SILICONSOFT_SC1_WAVEOUT = 2;

    [NativeTypeName("#define MM_SILICONSOFT_SC2_WAVEIN 3")]
    public const int MM_SILICONSOFT_SC2_WAVEIN = 3;

    [NativeTypeName("#define MM_SILICONSOFT_SC2_WAVEOUT 4")]
    public const int MM_SILICONSOFT_SC2_WAVEOUT = 4;

    [NativeTypeName("#define MM_SILICONSOFT_SOUNDJR2_WAVEOUT 5")]
    public const int MM_SILICONSOFT_SOUNDJR2_WAVEOUT = 5;

    [NativeTypeName("#define MM_SILICONSOFT_SOUNDJR2PR_WAVEIN 6")]
    public const int MM_SILICONSOFT_SOUNDJR2PR_WAVEIN = 6;

    [NativeTypeName("#define MM_SILICONSOFT_SOUNDJR2PR_WAVEOUT 7")]
    public const int MM_SILICONSOFT_SOUNDJR2PR_WAVEOUT = 7;

    [NativeTypeName("#define MM_SILICONSOFT_SOUNDJR3_WAVEOUT 8")]
    public const int MM_SILICONSOFT_SOUNDJR3_WAVEOUT = 8;

    [NativeTypeName("#define MM_TTEWS_WAVEIN 1")]
    public const int MM_TTEWS_WAVEIN = 1;

    [NativeTypeName("#define MM_TTEWS_WAVEOUT 2")]
    public const int MM_TTEWS_WAVEOUT = 2;

    [NativeTypeName("#define MM_TTEWS_MIDIIN 3")]
    public const int MM_TTEWS_MIDIIN = 3;

    [NativeTypeName("#define MM_TTEWS_MIDIOUT 4")]
    public const int MM_TTEWS_MIDIOUT = 4;

    [NativeTypeName("#define MM_TTEWS_MIDISYNTH 5")]
    public const int MM_TTEWS_MIDISYNTH = 5;

    [NativeTypeName("#define MM_TTEWS_MIDIMONITOR 6")]
    public const int MM_TTEWS_MIDIMONITOR = 6;

    [NativeTypeName("#define MM_TTEWS_VMIDIIN 7")]
    public const int MM_TTEWS_VMIDIIN = 7;

    [NativeTypeName("#define MM_TTEWS_VMIDIOUT 8")]
    public const int MM_TTEWS_VMIDIOUT = 8;

    [NativeTypeName("#define MM_TTEWS_AUX 9")]
    public const int MM_TTEWS_AUX = 9;

    [NativeTypeName("#define MM_TTEWS_MIXER 10")]
    public const int MM_TTEWS_MIXER = 10;

    [NativeTypeName("#define MM_MEDIASONIC_ACM_G723 1")]
    public const int MM_MEDIASONIC_ACM_G723 = 1;

    [NativeTypeName("#define MM_MEDIASONIC_ICOM 2")]
    public const int MM_MEDIASONIC_ICOM = 2;

    [NativeTypeName("#define MM_ICOM_WAVEIN 3")]
    public const int MM_ICOM_WAVEIN = 3;

    [NativeTypeName("#define MM_ICOM_WAVEOUT 4")]
    public const int MM_ICOM_WAVEOUT = 4;

    [NativeTypeName("#define MM_ICOM_MIXER 5")]
    public const int MM_ICOM_MIXER = 5;

    [NativeTypeName("#define MM_ICOM_AUX 6")]
    public const int MM_ICOM_AUX = 6;

    [NativeTypeName("#define MM_ICOM_LINE 7")]
    public const int MM_ICOM_LINE = 7;

    [NativeTypeName("#define MM_SANYO_ACM_LD_ADPCM 1")]
    public const int MM_SANYO_ACM_LD_ADPCM = 1;

    [NativeTypeName("#define MM_AHEAD_MULTISOUND 1")]
    public const int MM_AHEAD_MULTISOUND = 1;

    [NativeTypeName("#define MM_AHEAD_SOUNDBLASTER 2")]
    public const int MM_AHEAD_SOUNDBLASTER = 2;

    [NativeTypeName("#define MM_AHEAD_PROAUDIO 3")]
    public const int MM_AHEAD_PROAUDIO = 3;

    [NativeTypeName("#define MM_AHEAD_GENERIC 4")]
    public const int MM_AHEAD_GENERIC = 4;

    [NativeTypeName("#define MM_OLIVETTI_WAVEIN 1")]
    public const int MM_OLIVETTI_WAVEIN = 1;

    [NativeTypeName("#define MM_OLIVETTI_WAVEOUT 2")]
    public const int MM_OLIVETTI_WAVEOUT = 2;

    [NativeTypeName("#define MM_OLIVETTI_MIXER 3")]
    public const int MM_OLIVETTI_MIXER = 3;

    [NativeTypeName("#define MM_OLIVETTI_AUX 4")]
    public const int MM_OLIVETTI_AUX = 4;

    [NativeTypeName("#define MM_OLIVETTI_MIDIIN 5")]
    public const int MM_OLIVETTI_MIDIIN = 5;

    [NativeTypeName("#define MM_OLIVETTI_MIDIOUT 6")]
    public const int MM_OLIVETTI_MIDIOUT = 6;

    [NativeTypeName("#define MM_OLIVETTI_SYNTH 7")]
    public const int MM_OLIVETTI_SYNTH = 7;

    [NativeTypeName("#define MM_OLIVETTI_JOYSTICK 8")]
    public const int MM_OLIVETTI_JOYSTICK = 8;

    [NativeTypeName("#define MM_OLIVETTI_ACM_GSM 9")]
    public const int MM_OLIVETTI_ACM_GSM = 9;

    [NativeTypeName("#define MM_OLIVETTI_ACM_ADPCM 10")]
    public const int MM_OLIVETTI_ACM_ADPCM = 10;

    [NativeTypeName("#define MM_OLIVETTI_ACM_CELP 11")]
    public const int MM_OLIVETTI_ACM_CELP = 11;

    [NativeTypeName("#define MM_OLIVETTI_ACM_SBC 12")]
    public const int MM_OLIVETTI_ACM_SBC = 12;

    [NativeTypeName("#define MM_OLIVETTI_ACM_OPR 13")]
    public const int MM_OLIVETTI_ACM_OPR = 13;

    [NativeTypeName("#define MM_IOMAGIC_TEMPO_WAVEOUT 1")]
    public const int MM_IOMAGIC_TEMPO_WAVEOUT = 1;

    [NativeTypeName("#define MM_IOMAGIC_TEMPO_WAVEIN 2")]
    public const int MM_IOMAGIC_TEMPO_WAVEIN = 2;

    [NativeTypeName("#define MM_IOMAGIC_TEMPO_SYNTH 3")]
    public const int MM_IOMAGIC_TEMPO_SYNTH = 3;

    [NativeTypeName("#define MM_IOMAGIC_TEMPO_MIDIOUT 4")]
    public const int MM_IOMAGIC_TEMPO_MIDIOUT = 4;

    [NativeTypeName("#define MM_IOMAGIC_TEMPO_MXDOUT 5")]
    public const int MM_IOMAGIC_TEMPO_MXDOUT = 5;

    [NativeTypeName("#define MM_IOMAGIC_TEMPO_AUXOUT 6")]
    public const int MM_IOMAGIC_TEMPO_AUXOUT = 6;

    [NativeTypeName("#define MM_MATSUSHITA_WAVEIN 1")]
    public const int MM_MATSUSHITA_WAVEIN = 1;

    [NativeTypeName("#define MM_MATSUSHITA_WAVEOUT 2")]
    public const int MM_MATSUSHITA_WAVEOUT = 2;

    [NativeTypeName("#define MM_MATSUSHITA_FMSYNTH_STEREO 3")]
    public const int MM_MATSUSHITA_FMSYNTH_STEREO = 3;

    [NativeTypeName("#define MM_MATSUSHITA_MIXER 4")]
    public const int MM_MATSUSHITA_MIXER = 4;

    [NativeTypeName("#define MM_MATSUSHITA_AUX 5")]
    public const int MM_MATSUSHITA_AUX = 5;

    [NativeTypeName("#define MM_NEWMEDIA_WAVJAMMER 1")]
    public const int MM_NEWMEDIA_WAVJAMMER = 1;

    [NativeTypeName("#define MM_LYRRUS_BRIDGE_GUITAR 1")]
    public const int MM_LYRRUS_BRIDGE_GUITAR = 1;

    [NativeTypeName("#define MM_OPTI_M16_FMSYNTH_STEREO 0x0001")]
    public const int MM_OPTI_M16_FMSYNTH_STEREO = 0x0001;

    [NativeTypeName("#define MM_OPTI_M16_MIDIIN 0x0002")]
    public const int MM_OPTI_M16_MIDIIN = 0x0002;

    [NativeTypeName("#define MM_OPTI_M16_MIDIOUT 0x0003")]
    public const int MM_OPTI_M16_MIDIOUT = 0x0003;

    [NativeTypeName("#define MM_OPTI_M16_WAVEIN 0x0004")]
    public const int MM_OPTI_M16_WAVEIN = 0x0004;

    [NativeTypeName("#define MM_OPTI_M16_WAVEOUT 0x0005")]
    public const int MM_OPTI_M16_WAVEOUT = 0x0005;

    [NativeTypeName("#define MM_OPTI_M16_MIXER 0x0006")]
    public const int MM_OPTI_M16_MIXER = 0x0006;

    [NativeTypeName("#define MM_OPTI_M16_AUX 0x0007")]
    public const int MM_OPTI_M16_AUX = 0x0007;

    [NativeTypeName("#define MM_OPTI_P16_FMSYNTH_STEREO 0x0010")]
    public const int MM_OPTI_P16_FMSYNTH_STEREO = 0x0010;

    [NativeTypeName("#define MM_OPTI_P16_MIDIIN 0x0011")]
    public const int MM_OPTI_P16_MIDIIN = 0x0011;

    [NativeTypeName("#define MM_OPTI_P16_MIDIOUT 0x0012")]
    public const int MM_OPTI_P16_MIDIOUT = 0x0012;

    [NativeTypeName("#define MM_OPTI_P16_WAVEIN 0x0013")]
    public const int MM_OPTI_P16_WAVEIN = 0x0013;

    [NativeTypeName("#define MM_OPTI_P16_WAVEOUT 0x0014")]
    public const int MM_OPTI_P16_WAVEOUT = 0x0014;

    [NativeTypeName("#define MM_OPTI_P16_MIXER 0x0015")]
    public const int MM_OPTI_P16_MIXER = 0x0015;

    [NativeTypeName("#define MM_OPTI_P16_AUX 0x0016")]
    public const int MM_OPTI_P16_AUX = 0x0016;

    [NativeTypeName("#define MM_OPTI_M32_WAVEIN 0x0020")]
    public const int MM_OPTI_M32_WAVEIN = 0x0020;

    [NativeTypeName("#define MM_OPTI_M32_WAVEOUT 0x0021")]
    public const int MM_OPTI_M32_WAVEOUT = 0x0021;

    [NativeTypeName("#define MM_OPTI_M32_MIDIIN 0x0022")]
    public const int MM_OPTI_M32_MIDIIN = 0x0022;

    [NativeTypeName("#define MM_OPTI_M32_MIDIOUT 0x0023")]
    public const int MM_OPTI_M32_MIDIOUT = 0x0023;

    [NativeTypeName("#define MM_OPTI_M32_SYNTH_STEREO 0x0024")]
    public const int MM_OPTI_M32_SYNTH_STEREO = 0x0024;

    [NativeTypeName("#define MM_OPTI_M32_MIXER 0x0025")]
    public const int MM_OPTI_M32_MIXER = 0x0025;

    [NativeTypeName("#define MM_OPTI_M32_AUX 0x0026")]
    public const int MM_OPTI_M32_AUX = 0x0026;

    [NativeTypeName("#define MM_COMPAQ_BB_WAVEIN 1")]
    public const int MM_COMPAQ_BB_WAVEIN = 1;

    [NativeTypeName("#define MM_COMPAQ_BB_WAVEOUT 2")]
    public const int MM_COMPAQ_BB_WAVEOUT = 2;

    [NativeTypeName("#define MM_COMPAQ_BB_WAVEAUX 3")]
    public const int MM_COMPAQ_BB_WAVEAUX = 3;

    [NativeTypeName("#define MM_MPTUS_SPWAVEOUT 1")]
    public const int MM_MPTUS_SPWAVEOUT = 1;

    [NativeTypeName("#define MM_LERNOUT_ANDHAUSPIE_LHCODECACM 1")]
    public const int MM_LERNOUT_ANDHAUSPIE_LHCODECACM = 1;

    [NativeTypeName("#define MM_DIGITAL_AV320_WAVEIN 1")]
    public const int MM_DIGITAL_AV320_WAVEIN = 1;

    [NativeTypeName("#define MM_DIGITAL_AV320_WAVEOUT 2")]
    public const int MM_DIGITAL_AV320_WAVEOUT = 2;

    [NativeTypeName("#define MM_DIGITAL_ACM_G723 3")]
    public const int MM_DIGITAL_ACM_G723 = 3;

    [NativeTypeName("#define MM_DIGITAL_ICM_H263 4")]
    public const int MM_DIGITAL_ICM_H263 = 4;

    [NativeTypeName("#define MM_DIGITAL_ICM_H261 5")]
    public const int MM_DIGITAL_ICM_H261 = 5;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_ALL 100")]
    public const int MM_MOTU_MTP_MIDIOUT_ALL = 100;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_1 101")]
    public const int MM_MOTU_MTP_MIDIIN_1 = 101;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_1 101")]
    public const int MM_MOTU_MTP_MIDIOUT_1 = 101;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_2 102")]
    public const int MM_MOTU_MTP_MIDIIN_2 = 102;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_2 102")]
    public const int MM_MOTU_MTP_MIDIOUT_2 = 102;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_3 103")]
    public const int MM_MOTU_MTP_MIDIIN_3 = 103;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_3 103")]
    public const int MM_MOTU_MTP_MIDIOUT_3 = 103;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_4 104")]
    public const int MM_MOTU_MTP_MIDIIN_4 = 104;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_4 104")]
    public const int MM_MOTU_MTP_MIDIOUT_4 = 104;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_5 105")]
    public const int MM_MOTU_MTP_MIDIIN_5 = 105;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_5 105")]
    public const int MM_MOTU_MTP_MIDIOUT_5 = 105;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_6 106")]
    public const int MM_MOTU_MTP_MIDIIN_6 = 106;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_6 106")]
    public const int MM_MOTU_MTP_MIDIOUT_6 = 106;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_7 107")]
    public const int MM_MOTU_MTP_MIDIIN_7 = 107;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_7 107")]
    public const int MM_MOTU_MTP_MIDIOUT_7 = 107;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIIN_8 108")]
    public const int MM_MOTU_MTP_MIDIIN_8 = 108;

    [NativeTypeName("#define MM_MOTU_MTP_MIDIOUT_8 108")]
    public const int MM_MOTU_MTP_MIDIOUT_8 = 108;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_ALL 200")]
    public const int MM_MOTU_MTPII_MIDIOUT_ALL = 200;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_SYNC 200")]
    public const int MM_MOTU_MTPII_MIDIIN_SYNC = 200;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_1 201")]
    public const int MM_MOTU_MTPII_MIDIIN_1 = 201;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_1 201")]
    public const int MM_MOTU_MTPII_MIDIOUT_1 = 201;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_2 202")]
    public const int MM_MOTU_MTPII_MIDIIN_2 = 202;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_2 202")]
    public const int MM_MOTU_MTPII_MIDIOUT_2 = 202;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_3 203")]
    public const int MM_MOTU_MTPII_MIDIIN_3 = 203;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_3 203")]
    public const int MM_MOTU_MTPII_MIDIOUT_3 = 203;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_4 204")]
    public const int MM_MOTU_MTPII_MIDIIN_4 = 204;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_4 204")]
    public const int MM_MOTU_MTPII_MIDIOUT_4 = 204;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_5 205")]
    public const int MM_MOTU_MTPII_MIDIIN_5 = 205;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_5 205")]
    public const int MM_MOTU_MTPII_MIDIOUT_5 = 205;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_6 206")]
    public const int MM_MOTU_MTPII_MIDIIN_6 = 206;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_6 206")]
    public const int MM_MOTU_MTPII_MIDIOUT_6 = 206;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_7 207")]
    public const int MM_MOTU_MTPII_MIDIIN_7 = 207;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_7 207")]
    public const int MM_MOTU_MTPII_MIDIOUT_7 = 207;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIIN_8 208")]
    public const int MM_MOTU_MTPII_MIDIIN_8 = 208;

    [NativeTypeName("#define MM_MOTU_MTPII_MIDIOUT_8 208")]
    public const int MM_MOTU_MTPII_MIDIOUT_8 = 208;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_1 209")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_1 = 209;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_1 209")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_1 = 209;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_2 210")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_2 = 210;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_2 210")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_2 = 210;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_3 211")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_3 = 211;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_3 211")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_3 = 211;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_4 212")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_4 = 212;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_4 212")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_4 = 212;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_5 213")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_5 = 213;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_5 213")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_5 = 213;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_6 214")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_6 = 214;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_6 214")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_6 = 214;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_7 215")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_7 = 215;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_7 215")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_7 = 215;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIIN_8 216")]
    public const int MM_MOTU_MTPII_NET_MIDIIN_8 = 216;

    [NativeTypeName("#define MM_MOTU_MTPII_NET_MIDIOUT_8 216")]
    public const int MM_MOTU_MTPII_NET_MIDIOUT_8 = 216;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_ALL 300")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_ALL = 300;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_SYNC 300")]
    public const int MM_MOTU_MXP_MIDIIN_SYNC = 300;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIIN_1 301")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIIN_1 = 301;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_1 301")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_1 = 301;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIIN_2 302")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIIN_2 = 302;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_2 302")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_2 = 302;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIIN_3 303")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIIN_3 = 303;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_3 303")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_3 = 303;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIIN_4 304")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIIN_4 = 304;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_4 304")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_4 = 304;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIIN_5 305")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIIN_5 = 305;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_5 305")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_5 = 305;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIIN_6 306")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIIN_6 = 306;

    [NativeTypeName("#define MM_MOTU_MXP_MIDIIN_MIDIOUT_6 306")]
    public const int MM_MOTU_MXP_MIDIIN_MIDIOUT_6 = 306;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_ALL 400")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_ALL = 400;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_SYNC 400")]
    public const int MM_MOTU_MXPMPU_MIDIIN_SYNC = 400;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_1 401")]
    public const int MM_MOTU_MXPMPU_MIDIIN_1 = 401;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_1 401")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_1 = 401;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_2 402")]
    public const int MM_MOTU_MXPMPU_MIDIIN_2 = 402;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_2 402")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_2 = 402;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_3 403")]
    public const int MM_MOTU_MXPMPU_MIDIIN_3 = 403;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_3 403")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_3 = 403;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_4 404")]
    public const int MM_MOTU_MXPMPU_MIDIIN_4 = 404;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_4 404")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_4 = 404;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_5 405")]
    public const int MM_MOTU_MXPMPU_MIDIIN_5 = 405;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_5 405")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_5 = 405;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIIN_6 406")]
    public const int MM_MOTU_MXPMPU_MIDIIN_6 = 406;

    [NativeTypeName("#define MM_MOTU_MXPMPU_MIDIOUT_6 406")]
    public const int MM_MOTU_MXPMPU_MIDIOUT_6 = 406;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIOUT_ALL 500")]
    public const int MM_MOTU_MXN_MIDIOUT_ALL = 500;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIIN_SYNC 500")]
    public const int MM_MOTU_MXN_MIDIIN_SYNC = 500;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIIN_1 501")]
    public const int MM_MOTU_MXN_MIDIIN_1 = 501;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIOUT_1 501")]
    public const int MM_MOTU_MXN_MIDIOUT_1 = 501;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIIN_2 502")]
    public const int MM_MOTU_MXN_MIDIIN_2 = 502;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIOUT_2 502")]
    public const int MM_MOTU_MXN_MIDIOUT_2 = 502;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIIN_3 503")]
    public const int MM_MOTU_MXN_MIDIIN_3 = 503;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIOUT_3 503")]
    public const int MM_MOTU_MXN_MIDIOUT_3 = 503;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIIN_4 504")]
    public const int MM_MOTU_MXN_MIDIIN_4 = 504;

    [NativeTypeName("#define MM_MOTU_MXN_MIDIOUT_4 504")]
    public const int MM_MOTU_MXN_MIDIOUT_4 = 504;

    [NativeTypeName("#define MM_MOTU_FLYER_MIDI_IN_SYNC 600")]
    public const int MM_MOTU_FLYER_MIDI_IN_SYNC = 600;

    [NativeTypeName("#define MM_MOTU_FLYER_MIDI_IN_A 601")]
    public const int MM_MOTU_FLYER_MIDI_IN_A = 601;

    [NativeTypeName("#define MM_MOTU_FLYER_MIDI_OUT_A 601")]
    public const int MM_MOTU_FLYER_MIDI_OUT_A = 601;

    [NativeTypeName("#define MM_MOTU_FLYER_MIDI_IN_B 602")]
    public const int MM_MOTU_FLYER_MIDI_IN_B = 602;

    [NativeTypeName("#define MM_MOTU_FLYER_MIDI_OUT_B 602")]
    public const int MM_MOTU_FLYER_MIDI_OUT_B = 602;

    [NativeTypeName("#define MM_MOTU_PKX_MIDI_IN_SYNC 700")]
    public const int MM_MOTU_PKX_MIDI_IN_SYNC = 700;

    [NativeTypeName("#define MM_MOTU_PKX_MIDI_IN_A 701")]
    public const int MM_MOTU_PKX_MIDI_IN_A = 701;

    [NativeTypeName("#define MM_MOTU_PKX_MIDI_OUT_A 701")]
    public const int MM_MOTU_PKX_MIDI_OUT_A = 701;

    [NativeTypeName("#define MM_MOTU_PKX_MIDI_IN_B 702")]
    public const int MM_MOTU_PKX_MIDI_IN_B = 702;

    [NativeTypeName("#define MM_MOTU_PKX_MIDI_OUT_B 702")]
    public const int MM_MOTU_PKX_MIDI_OUT_B = 702;

    [NativeTypeName("#define MM_MOTU_DTX_MIDI_IN_SYNC 800")]
    public const int MM_MOTU_DTX_MIDI_IN_SYNC = 800;

    [NativeTypeName("#define MM_MOTU_DTX_MIDI_IN_A 801")]
    public const int MM_MOTU_DTX_MIDI_IN_A = 801;

    [NativeTypeName("#define MM_MOTU_DTX_MIDI_OUT_A 801")]
    public const int MM_MOTU_DTX_MIDI_OUT_A = 801;

    [NativeTypeName("#define MM_MOTU_DTX_MIDI_IN_B 802")]
    public const int MM_MOTU_DTX_MIDI_IN_B = 802;

    [NativeTypeName("#define MM_MOTU_DTX_MIDI_OUT_B 802")]
    public const int MM_MOTU_DTX_MIDI_OUT_B = 802;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_ALL 900")]
    public const int MM_MOTU_MTPAV_MIDIOUT_ALL = 900;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_SYNC 900")]
    public const int MM_MOTU_MTPAV_MIDIIN_SYNC = 900;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_1 901")]
    public const int MM_MOTU_MTPAV_MIDIIN_1 = 901;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_1 901")]
    public const int MM_MOTU_MTPAV_MIDIOUT_1 = 901;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_2 902")]
    public const int MM_MOTU_MTPAV_MIDIIN_2 = 902;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_2 902")]
    public const int MM_MOTU_MTPAV_MIDIOUT_2 = 902;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_3 903")]
    public const int MM_MOTU_MTPAV_MIDIIN_3 = 903;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_3 903")]
    public const int MM_MOTU_MTPAV_MIDIOUT_3 = 903;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_4 904")]
    public const int MM_MOTU_MTPAV_MIDIIN_4 = 904;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_4 904")]
    public const int MM_MOTU_MTPAV_MIDIOUT_4 = 904;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_5 905")]
    public const int MM_MOTU_MTPAV_MIDIIN_5 = 905;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_5 905")]
    public const int MM_MOTU_MTPAV_MIDIOUT_5 = 905;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_6 906")]
    public const int MM_MOTU_MTPAV_MIDIIN_6 = 906;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_6 906")]
    public const int MM_MOTU_MTPAV_MIDIOUT_6 = 906;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_7 907")]
    public const int MM_MOTU_MTPAV_MIDIIN_7 = 907;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_7 907")]
    public const int MM_MOTU_MTPAV_MIDIOUT_7 = 907;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_8 908")]
    public const int MM_MOTU_MTPAV_MIDIIN_8 = 908;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_8 908")]
    public const int MM_MOTU_MTPAV_MIDIOUT_8 = 908;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_1 909")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_1 = 909;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_1 909")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_1 = 909;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_2 910")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_2 = 910;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_2 910")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_2 = 910;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_3 911")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_3 = 911;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_3 911")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_3 = 911;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_4 912")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_4 = 912;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_4 912")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_4 = 912;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_5 913")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_5 = 913;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_5 913")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_5 = 913;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_6 914")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_6 = 914;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_6 914")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_6 = 914;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_7 915")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_7 = 915;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_7 915")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_7 = 915;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIIN_8 916")]
    public const int MM_MOTU_MTPAV_NET_MIDIIN_8 = 916;

    [NativeTypeName("#define MM_MOTU_MTPAV_NET_MIDIOUT_8 916")]
    public const int MM_MOTU_MTPAV_NET_MIDIOUT_8 = 916;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIIN_ADAT 917")]
    public const int MM_MOTU_MTPAV_MIDIIN_ADAT = 917;

    [NativeTypeName("#define MM_MOTU_MTPAV_MIDIOUT_ADAT 917")]
    public const int MM_MOTU_MTPAV_MIDIOUT_ADAT = 917;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_SYNC 1000")]
    public const int MM_MOTU_MXPXT_MIDIIN_SYNC = 1000;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_ALL 1000")]
    public const int MM_MOTU_MXPXT_MIDIOUT_ALL = 1000;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_1 1001")]
    public const int MM_MOTU_MXPXT_MIDIIN_1 = 1001;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_1 1001")]
    public const int MM_MOTU_MXPXT_MIDIOUT_1 = 1001;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_2 1002")]
    public const int MM_MOTU_MXPXT_MIDIOUT_2 = 1002;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_2 1002")]
    public const int MM_MOTU_MXPXT_MIDIIN_2 = 1002;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_3 1003")]
    public const int MM_MOTU_MXPXT_MIDIIN_3 = 1003;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_3 1003")]
    public const int MM_MOTU_MXPXT_MIDIOUT_3 = 1003;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_4 1004")]
    public const int MM_MOTU_MXPXT_MIDIIN_4 = 1004;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_4 1004")]
    public const int MM_MOTU_MXPXT_MIDIOUT_4 = 1004;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_5 1005")]
    public const int MM_MOTU_MXPXT_MIDIIN_5 = 1005;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_5 1005")]
    public const int MM_MOTU_MXPXT_MIDIOUT_5 = 1005;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_6 1006")]
    public const int MM_MOTU_MXPXT_MIDIOUT_6 = 1006;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_6 1006")]
    public const int MM_MOTU_MXPXT_MIDIIN_6 = 1006;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_7 1007")]
    public const int MM_MOTU_MXPXT_MIDIOUT_7 = 1007;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_7 1007")]
    public const int MM_MOTU_MXPXT_MIDIIN_7 = 1007;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIOUT_8 1008")]
    public const int MM_MOTU_MXPXT_MIDIOUT_8 = 1008;

    [NativeTypeName("#define MM_MOTU_MXPXT_MIDIIN_8 1008")]
    public const int MM_MOTU_MXPXT_MIDIIN_8 = 1008;

    [NativeTypeName("#define MM_WORKBIT_MIXER 1")]
    public const int MM_WORKBIT_MIXER = 1;

    [NativeTypeName("#define MM_WORKBIT_WAVEOUT 2")]
    public const int MM_WORKBIT_WAVEOUT = 2;

    [NativeTypeName("#define MM_WORKBIT_WAVEIN 3")]
    public const int MM_WORKBIT_WAVEIN = 3;

    [NativeTypeName("#define MM_WORKBIT_MIDIIN 4")]
    public const int MM_WORKBIT_MIDIIN = 4;

    [NativeTypeName("#define MM_WORKBIT_MIDIOUT 5")]
    public const int MM_WORKBIT_MIDIOUT = 5;

    [NativeTypeName("#define MM_WORKBIT_FMSYNTH 6")]
    public const int MM_WORKBIT_FMSYNTH = 6;

    [NativeTypeName("#define MM_WORKBIT_AUX 7")]
    public const int MM_WORKBIT_AUX = 7;

    [NativeTypeName("#define MM_WORKBIT_JOYSTICK 8")]
    public const int MM_WORKBIT_JOYSTICK = 8;

    [NativeTypeName("#define MM_OSITECH_TRUMPCARD 1")]
    public const int MM_OSITECH_TRUMPCARD = 1;

    [NativeTypeName("#define MM_MIRO_MOVIEPRO 1")]
    public const int MM_MIRO_MOVIEPRO = 1;

    [NativeTypeName("#define MM_MIRO_VIDEOD1 2")]
    public const int MM_MIRO_VIDEOD1 = 2;

    [NativeTypeName("#define MM_MIRO_VIDEODC1TV 3")]
    public const int MM_MIRO_VIDEODC1TV = 3;

    [NativeTypeName("#define MM_MIRO_VIDEOTD 4")]
    public const int MM_MIRO_VIDEOTD = 4;

    [NativeTypeName("#define MM_MIRO_DC30_WAVEOUT 5")]
    public const int MM_MIRO_DC30_WAVEOUT = 5;

    [NativeTypeName("#define MM_MIRO_DC30_WAVEIN 6")]
    public const int MM_MIRO_DC30_WAVEIN = 6;

    [NativeTypeName("#define MM_MIRO_DC30_MIX 7")]
    public const int MM_MIRO_DC30_MIX = 7;

    [NativeTypeName("#define MM_ISOLUTION_PASCAL 1")]
    public const int MM_ISOLUTION_PASCAL = 1;

    [NativeTypeName("#define MM_VOICEMIXER 1")]
    public const int MM_VOICEMIXER = 1;

    [NativeTypeName("#define MM_VOXWARE_CODEC 1")]
    public const int MM_VOXWARE_CODEC = 1;

    [NativeTypeName("#define MM_NORTEL_MPXAC_WAVEIN 1")]
    public const int MM_NORTEL_MPXAC_WAVEIN = 1;

    [NativeTypeName("#define MM_NORTEL_MPXAC_WAVEOUT 2")]
    public const int MM_NORTEL_MPXAC_WAVEOUT = 2;

    [NativeTypeName("#define MM_ADDX_PCTV_DIGITALMIX 1")]
    public const int MM_ADDX_PCTV_DIGITALMIX = 1;

    [NativeTypeName("#define MM_ADDX_PCTV_WAVEIN 2")]
    public const int MM_ADDX_PCTV_WAVEIN = 2;

    [NativeTypeName("#define MM_ADDX_PCTV_WAVEOUT 3")]
    public const int MM_ADDX_PCTV_WAVEOUT = 3;

    [NativeTypeName("#define MM_ADDX_PCTV_MIXER 4")]
    public const int MM_ADDX_PCTV_MIXER = 4;

    [NativeTypeName("#define MM_ADDX_PCTV_AUX_CD 5")]
    public const int MM_ADDX_PCTV_AUX_CD = 5;

    [NativeTypeName("#define MM_ADDX_PCTV_AUX_LINE 6")]
    public const int MM_ADDX_PCTV_AUX_LINE = 6;

    [NativeTypeName("#define MM_WILDCAT_AUTOSCOREMIDIIN 1")]
    public const int MM_WILDCAT_AUTOSCOREMIDIIN = 1;

    [NativeTypeName("#define MM_RHETOREX_WAVEIN 1")]
    public const int MM_RHETOREX_WAVEIN = 1;

    [NativeTypeName("#define MM_RHETOREX_WAVEOUT 2")]
    public const int MM_RHETOREX_WAVEOUT = 2;

    [NativeTypeName("#define MM_BTV_WAVEIN 1")]
    public const int MM_BTV_WAVEIN = 1;

    [NativeTypeName("#define MM_BTV_WAVEOUT 2")]
    public const int MM_BTV_WAVEOUT = 2;

    [NativeTypeName("#define MM_BTV_MIDIIN 3")]
    public const int MM_BTV_MIDIIN = 3;

    [NativeTypeName("#define MM_BTV_MIDIOUT 4")]
    public const int MM_BTV_MIDIOUT = 4;

    [NativeTypeName("#define MM_BTV_MIDISYNTH 5")]
    public const int MM_BTV_MIDISYNTH = 5;

    [NativeTypeName("#define MM_BTV_AUX_LINE 6")]
    public const int MM_BTV_AUX_LINE = 6;

    [NativeTypeName("#define MM_BTV_AUX_MIC 7")]
    public const int MM_BTV_AUX_MIC = 7;

    [NativeTypeName("#define MM_BTV_AUX_CD 8")]
    public const int MM_BTV_AUX_CD = 8;

    [NativeTypeName("#define MM_BTV_DIGITALIN 9")]
    public const int MM_BTV_DIGITALIN = 9;

    [NativeTypeName("#define MM_BTV_DIGITALOUT 10")]
    public const int MM_BTV_DIGITALOUT = 10;

    [NativeTypeName("#define MM_BTV_MIDIWAVESTREAM 11")]
    public const int MM_BTV_MIDIWAVESTREAM = 11;

    [NativeTypeName("#define MM_BTV_MIXER 12")]
    public const int MM_BTV_MIXER = 12;

    [NativeTypeName("#define MM_ENSONIQ_SOUNDSCAPE 0x10")]
    public const int MM_ENSONIQ_SOUNDSCAPE = 0x10;

    [NativeTypeName("#define MM_SOUNDSCAPE_WAVEOUT MM_ENSONIQ_SOUNDSCAPE+1")]
    public const int MM_SOUNDSCAPE_WAVEOUT = 0x10 + 1;

    [NativeTypeName("#define MM_SOUNDSCAPE_WAVEOUT_AUX MM_ENSONIQ_SOUNDSCAPE+2")]
    public const int MM_SOUNDSCAPE_WAVEOUT_AUX = 0x10 + 2;

    [NativeTypeName("#define MM_SOUNDSCAPE_WAVEIN MM_ENSONIQ_SOUNDSCAPE+3")]
    public const int MM_SOUNDSCAPE_WAVEIN = 0x10 + 3;

    [NativeTypeName("#define MM_SOUNDSCAPE_MIDIOUT MM_ENSONIQ_SOUNDSCAPE+4")]
    public const int MM_SOUNDSCAPE_MIDIOUT = 0x10 + 4;

    [NativeTypeName("#define MM_SOUNDSCAPE_MIDIIN MM_ENSONIQ_SOUNDSCAPE+5")]
    public const int MM_SOUNDSCAPE_MIDIIN = 0x10 + 5;

    [NativeTypeName("#define MM_SOUNDSCAPE_SYNTH MM_ENSONIQ_SOUNDSCAPE+6")]
    public const int MM_SOUNDSCAPE_SYNTH = 0x10 + 6;

    [NativeTypeName("#define MM_SOUNDSCAPE_MIXER MM_ENSONIQ_SOUNDSCAPE+7")]
    public const int MM_SOUNDSCAPE_MIXER = 0x10 + 7;

    [NativeTypeName("#define MM_SOUNDSCAPE_AUX MM_ENSONIQ_SOUNDSCAPE+8")]
    public const int MM_SOUNDSCAPE_AUX = 0x10 + 8;

    [NativeTypeName("#define MM_NVIDIA_WAVEOUT 1")]
    public const int MM_NVIDIA_WAVEOUT = 1;

    [NativeTypeName("#define MM_NVIDIA_WAVEIN 2")]
    public const int MM_NVIDIA_WAVEIN = 2;

    [NativeTypeName("#define MM_NVIDIA_MIDIOUT 3")]
    public const int MM_NVIDIA_MIDIOUT = 3;

    [NativeTypeName("#define MM_NVIDIA_MIDIIN 4")]
    public const int MM_NVIDIA_MIDIIN = 4;

    [NativeTypeName("#define MM_NVIDIA_GAMEPORT 5")]
    public const int MM_NVIDIA_GAMEPORT = 5;

    [NativeTypeName("#define MM_NVIDIA_MIXER 6")]
    public const int MM_NVIDIA_MIXER = 6;

    [NativeTypeName("#define MM_NVIDIA_AUX 7")]
    public const int MM_NVIDIA_AUX = 7;

    [NativeTypeName("#define MM_OKSORI_BASE 0")]
    public const int MM_OKSORI_BASE = 0;

    [NativeTypeName("#define MM_OKSORI_OSR8_WAVEOUT MM_OKSORI_BASE+1")]
    public const int MM_OKSORI_OSR8_WAVEOUT = 0 + 1;

    [NativeTypeName("#define MM_OKSORI_OSR8_WAVEIN MM_OKSORI_BASE+2")]
    public const int MM_OKSORI_OSR8_WAVEIN = 0 + 2;

    [NativeTypeName("#define MM_OKSORI_OSR16_WAVEOUT MM_OKSORI_BASE+3")]
    public const int MM_OKSORI_OSR16_WAVEOUT = 0 + 3;

    [NativeTypeName("#define MM_OKSORI_OSR16_WAVEIN MM_OKSORI_BASE+4")]
    public const int MM_OKSORI_OSR16_WAVEIN = 0 + 4;

    [NativeTypeName("#define MM_OKSORI_FM_OPL4 MM_OKSORI_BASE+5")]
    public const int MM_OKSORI_FM_OPL4 = 0 + 5;

    [NativeTypeName("#define MM_OKSORI_MIX_MASTER MM_OKSORI_BASE+6")]
    public const int MM_OKSORI_MIX_MASTER = 0 + 6;

    [NativeTypeName("#define MM_OKSORI_MIX_WAVE MM_OKSORI_BASE+7")]
    public const int MM_OKSORI_MIX_WAVE = 0 + 7;

    [NativeTypeName("#define MM_OKSORI_MIX_FM MM_OKSORI_BASE+8")]
    public const int MM_OKSORI_MIX_FM = 0 + 8;

    [NativeTypeName("#define MM_OKSORI_MIX_LINE MM_OKSORI_BASE+9")]
    public const int MM_OKSORI_MIX_LINE = 0 + 9;

    [NativeTypeName("#define MM_OKSORI_MIX_CD MM_OKSORI_BASE+10")]
    public const int MM_OKSORI_MIX_CD = 0 + 10;

    [NativeTypeName("#define MM_OKSORI_MIX_MIC MM_OKSORI_BASE+11")]
    public const int MM_OKSORI_MIX_MIC = 0 + 11;

    [NativeTypeName("#define MM_OKSORI_MIX_ECHO MM_OKSORI_BASE+12")]
    public const int MM_OKSORI_MIX_ECHO = 0 + 12;

    [NativeTypeName("#define MM_OKSORI_MIX_AUX1 MM_OKSORI_BASE+13")]
    public const int MM_OKSORI_MIX_AUX1 = 0 + 13;

    [NativeTypeName("#define MM_OKSORI_MIX_LINE1 MM_OKSORI_BASE+14")]
    public const int MM_OKSORI_MIX_LINE1 = 0 + 14;

    [NativeTypeName("#define MM_OKSORI_EXT_MIC1 MM_OKSORI_BASE+15")]
    public const int MM_OKSORI_EXT_MIC1 = 0 + 15;

    [NativeTypeName("#define MM_OKSORI_EXT_MIC2 MM_OKSORI_BASE+16")]
    public const int MM_OKSORI_EXT_MIC2 = 0 + 16;

    [NativeTypeName("#define MM_OKSORI_MIDIOUT MM_OKSORI_BASE+17")]
    public const int MM_OKSORI_MIDIOUT = 0 + 17;

    [NativeTypeName("#define MM_OKSORI_MIDIIN MM_OKSORI_BASE+18")]
    public const int MM_OKSORI_MIDIIN = 0 + 18;

    [NativeTypeName("#define MM_OKSORI_MPEG_CDVISION MM_OKSORI_BASE+19")]
    public const int MM_OKSORI_MPEG_CDVISION = 0 + 19;

    [NativeTypeName("#define MM_DIACOUSTICS_DRUM_ACTION 1")]
    public const int MM_DIACOUSTICS_DRUM_ACTION = 1;

    [NativeTypeName("#define MM_KAY_ELEMETRICS_CSL 0x4300")]
    public const int MM_KAY_ELEMETRICS_CSL = 0x4300;

    [NativeTypeName("#define MM_KAY_ELEMETRICS_CSL_DAT 0x4308")]
    public const int MM_KAY_ELEMETRICS_CSL_DAT = 0x4308;

    [NativeTypeName("#define MM_KAY_ELEMETRICS_CSL_4CHANNEL 0x4309")]
    public const int MM_KAY_ELEMETRICS_CSL_4CHANNEL = 0x4309;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEIN 1")]
    public const int MM_CRYSTAL_CS4232_WAVEIN = 1;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEOUT 2")]
    public const int MM_CRYSTAL_CS4232_WAVEOUT = 2;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEMIXER 3")]
    public const int MM_CRYSTAL_CS4232_WAVEMIXER = 3;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEAUX_AUX1 4")]
    public const int MM_CRYSTAL_CS4232_WAVEAUX_AUX1 = 4;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEAUX_AUX2 5")]
    public const int MM_CRYSTAL_CS4232_WAVEAUX_AUX2 = 5;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEAUX_LINE 6")]
    public const int MM_CRYSTAL_CS4232_WAVEAUX_LINE = 6;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEAUX_MONO 7")]
    public const int MM_CRYSTAL_CS4232_WAVEAUX_MONO = 7;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_WAVEAUX_MASTER 8")]
    public const int MM_CRYSTAL_CS4232_WAVEAUX_MASTER = 8;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_MIDIIN 9")]
    public const int MM_CRYSTAL_CS4232_MIDIIN = 9;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_MIDIOUT 10")]
    public const int MM_CRYSTAL_CS4232_MIDIOUT = 10;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_INPUTGAIN_AUX1 13")]
    public const int MM_CRYSTAL_CS4232_INPUTGAIN_AUX1 = 13;

    [NativeTypeName("#define MM_CRYSTAL_CS4232_INPUTGAIN_LOOP 14")]
    public const int MM_CRYSTAL_CS4232_INPUTGAIN_LOOP = 14;

    [NativeTypeName("#define MM_CRYSTAL_SOUND_FUSION_WAVEIN 21")]
    public const int MM_CRYSTAL_SOUND_FUSION_WAVEIN = 21;

    [NativeTypeName("#define MM_CRYSTAL_SOUND_FUSION_WAVEOUT 22")]
    public const int MM_CRYSTAL_SOUND_FUSION_WAVEOUT = 22;

    [NativeTypeName("#define MM_CRYSTAL_SOUND_FUSION_MIXER 23")]
    public const int MM_CRYSTAL_SOUND_FUSION_MIXER = 23;

    [NativeTypeName("#define MM_CRYSTAL_SOUND_FUSION_MIDIIN 24")]
    public const int MM_CRYSTAL_SOUND_FUSION_MIDIIN = 24;

    [NativeTypeName("#define MM_CRYSTAL_SOUND_FUSION_MIDIOUT 25")]
    public const int MM_CRYSTAL_SOUND_FUSION_MIDIOUT = 25;

    [NativeTypeName("#define MM_CRYSTAL_SOUND_FUSION_JOYSTICK 26")]
    public const int MM_CRYSTAL_SOUND_FUSION_JOYSTICK = 26;

    [NativeTypeName("#define MM_QUARTERDECK_LHWAVEIN 0")]
    public const int MM_QUARTERDECK_LHWAVEIN = 0;

    [NativeTypeName("#define MM_QUARTERDECK_LHWAVEOUT 1")]
    public const int MM_QUARTERDECK_LHWAVEOUT = 1;

    [NativeTypeName("#define MM_TDK_MW_MIDI_SYNTH 1")]
    public const int MM_TDK_MW_MIDI_SYNTH = 1;

    [NativeTypeName("#define MM_TDK_MW_MIDI_IN 2")]
    public const int MM_TDK_MW_MIDI_IN = 2;

    [NativeTypeName("#define MM_TDK_MW_MIDI_OUT 3")]
    public const int MM_TDK_MW_MIDI_OUT = 3;

    [NativeTypeName("#define MM_TDK_MW_WAVE_IN 4")]
    public const int MM_TDK_MW_WAVE_IN = 4;

    [NativeTypeName("#define MM_TDK_MW_WAVE_OUT 5")]
    public const int MM_TDK_MW_WAVE_OUT = 5;

    [NativeTypeName("#define MM_TDK_MW_AUX 6")]
    public const int MM_TDK_MW_AUX = 6;

    [NativeTypeName("#define MM_TDK_MW_MIXER 10")]
    public const int MM_TDK_MW_MIXER = 10;

    [NativeTypeName("#define MM_TDK_MW_AUX_MASTER 100")]
    public const int MM_TDK_MW_AUX_MASTER = 100;

    [NativeTypeName("#define MM_TDK_MW_AUX_BASS 101")]
    public const int MM_TDK_MW_AUX_BASS = 101;

    [NativeTypeName("#define MM_TDK_MW_AUX_TREBLE 102")]
    public const int MM_TDK_MW_AUX_TREBLE = 102;

    [NativeTypeName("#define MM_TDK_MW_AUX_MIDI_VOL 103")]
    public const int MM_TDK_MW_AUX_MIDI_VOL = 103;

    [NativeTypeName("#define MM_TDK_MW_AUX_WAVE_VOL 104")]
    public const int MM_TDK_MW_AUX_WAVE_VOL = 104;

    [NativeTypeName("#define MM_TDK_MW_AUX_WAVE_RVB 105")]
    public const int MM_TDK_MW_AUX_WAVE_RVB = 105;

    [NativeTypeName("#define MM_TDK_MW_AUX_WAVE_CHR 106")]
    public const int MM_TDK_MW_AUX_WAVE_CHR = 106;

    [NativeTypeName("#define MM_TDK_MW_AUX_VOL 107")]
    public const int MM_TDK_MW_AUX_VOL = 107;

    [NativeTypeName("#define MM_TDK_MW_AUX_RVB 108")]
    public const int MM_TDK_MW_AUX_RVB = 108;

    [NativeTypeName("#define MM_TDK_MW_AUX_CHR 109")]
    public const int MM_TDK_MW_AUX_CHR = 109;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_TC 0x01")]
    public const int MM_DIGITAL_AUDIO_LABS_TC = 0x01;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_DOC 0x02")]
    public const int MM_DIGITAL_AUDIO_LABS_DOC = 0x02;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_V8 0x10")]
    public const int MM_DIGITAL_AUDIO_LABS_V8 = 0x10;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_CPRO 0x11")]
    public const int MM_DIGITAL_AUDIO_LABS_CPRO = 0x11;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_VP 0x12")]
    public const int MM_DIGITAL_AUDIO_LABS_VP = 0x12;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_CDLX 0x13")]
    public const int MM_DIGITAL_AUDIO_LABS_CDLX = 0x13;

    [NativeTypeName("#define MM_DIGITAL_AUDIO_LABS_CTDIF 0x14")]
    public const int MM_DIGITAL_AUDIO_LABS_CTDIF = 0x14;

    [NativeTypeName("#define MM_SEERSYS_SEERSYNTH 1")]
    public const int MM_SEERSYS_SEERSYNTH = 1;

    [NativeTypeName("#define MM_SEERSYS_SEERWAVE 2")]
    public const int MM_SEERSYS_SEERWAVE = 2;

    [NativeTypeName("#define MM_SEERSYS_SEERMIX 3")]
    public const int MM_SEERSYS_SEERMIX = 3;

    [NativeTypeName("#define MM_SEERSYS_WAVESYNTH 4")]
    public const int MM_SEERSYS_WAVESYNTH = 4;

    [NativeTypeName("#define MM_SEERSYS_WAVESYNTH_WG 5")]
    public const int MM_SEERSYS_WAVESYNTH_WG = 5;

    [NativeTypeName("#define MM_SEERSYS_REALITY 6")]
    public const int MM_SEERSYS_REALITY = 6;

    [NativeTypeName("#define MM_OSPREY_1000WAVEIN 1")]
    public const int MM_OSPREY_1000WAVEIN = 1;

    [NativeTypeName("#define MM_OSPREY_1000WAVEOUT 2")]
    public const int MM_OSPREY_1000WAVEOUT = 2;

    [NativeTypeName("#define MM_SOUNDESIGNS_WAVEIN 1")]
    public const int MM_SOUNDESIGNS_WAVEIN = 1;

    [NativeTypeName("#define MM_SOUNDESIGNS_WAVEOUT 2")]
    public const int MM_SOUNDESIGNS_WAVEOUT = 2;

    [NativeTypeName("#define MM_SSP_SNDFESWAVEIN 1")]
    public const int MM_SSP_SNDFESWAVEIN = 1;

    [NativeTypeName("#define MM_SSP_SNDFESWAVEOUT 2")]
    public const int MM_SSP_SNDFESWAVEOUT = 2;

    [NativeTypeName("#define MM_SSP_SNDFESMIDIIN 3")]
    public const int MM_SSP_SNDFESMIDIIN = 3;

    [NativeTypeName("#define MM_SSP_SNDFESMIDIOUT 4")]
    public const int MM_SSP_SNDFESMIDIOUT = 4;

    [NativeTypeName("#define MM_SSP_SNDFESSYNTH 5")]
    public const int MM_SSP_SNDFESSYNTH = 5;

    [NativeTypeName("#define MM_SSP_SNDFESMIX 6")]
    public const int MM_SSP_SNDFESMIX = 6;

    [NativeTypeName("#define MM_SSP_SNDFESAUX 7")]
    public const int MM_SSP_SNDFESAUX = 7;

    [NativeTypeName("#define MM_ECS_AADF_MIDI_IN 10")]
    public const int MM_ECS_AADF_MIDI_IN = 10;

    [NativeTypeName("#define MM_ECS_AADF_MIDI_OUT 11")]
    public const int MM_ECS_AADF_MIDI_OUT = 11;

    [NativeTypeName("#define MM_ECS_AADF_WAVE2MIDI_IN 12")]
    public const int MM_ECS_AADF_WAVE2MIDI_IN = 12;

    [NativeTypeName("#define MM_AMD_INTERWAVE_WAVEIN 1")]
    public const int MM_AMD_INTERWAVE_WAVEIN = 1;

    [NativeTypeName("#define MM_AMD_INTERWAVE_WAVEOUT 2")]
    public const int MM_AMD_INTERWAVE_WAVEOUT = 2;

    [NativeTypeName("#define MM_AMD_INTERWAVE_SYNTH 3")]
    public const int MM_AMD_INTERWAVE_SYNTH = 3;

    [NativeTypeName("#define MM_AMD_INTERWAVE_MIXER1 4")]
    public const int MM_AMD_INTERWAVE_MIXER1 = 4;

    [NativeTypeName("#define MM_AMD_INTERWAVE_MIXER2 5")]
    public const int MM_AMD_INTERWAVE_MIXER2 = 5;

    [NativeTypeName("#define MM_AMD_INTERWAVE_JOYSTICK 6")]
    public const int MM_AMD_INTERWAVE_JOYSTICK = 6;

    [NativeTypeName("#define MM_AMD_INTERWAVE_EX_CD 7")]
    public const int MM_AMD_INTERWAVE_EX_CD = 7;

    [NativeTypeName("#define MM_AMD_INTERWAVE_MIDIIN 8")]
    public const int MM_AMD_INTERWAVE_MIDIIN = 8;

    [NativeTypeName("#define MM_AMD_INTERWAVE_MIDIOUT 9")]
    public const int MM_AMD_INTERWAVE_MIDIOUT = 9;

    [NativeTypeName("#define MM_AMD_INTERWAVE_AUX1 10")]
    public const int MM_AMD_INTERWAVE_AUX1 = 10;

    [NativeTypeName("#define MM_AMD_INTERWAVE_AUX2 11")]
    public const int MM_AMD_INTERWAVE_AUX2 = 11;

    [NativeTypeName("#define MM_AMD_INTERWAVE_AUX_MIC 12")]
    public const int MM_AMD_INTERWAVE_AUX_MIC = 12;

    [NativeTypeName("#define MM_AMD_INTERWAVE_AUX_CD 13")]
    public const int MM_AMD_INTERWAVE_AUX_CD = 13;

    [NativeTypeName("#define MM_AMD_INTERWAVE_MONO_IN 14")]
    public const int MM_AMD_INTERWAVE_MONO_IN = 14;

    [NativeTypeName("#define MM_AMD_INTERWAVE_MONO_OUT 15")]
    public const int MM_AMD_INTERWAVE_MONO_OUT = 15;

    [NativeTypeName("#define MM_AMD_INTERWAVE_EX_TELEPHONY 16")]
    public const int MM_AMD_INTERWAVE_EX_TELEPHONY = 16;

    [NativeTypeName("#define MM_AMD_INTERWAVE_WAVEOUT_BASE 17")]
    public const int MM_AMD_INTERWAVE_WAVEOUT_BASE = 17;

    [NativeTypeName("#define MM_AMD_INTERWAVE_WAVEOUT_TREBLE 18")]
    public const int MM_AMD_INTERWAVE_WAVEOUT_TREBLE = 18;

    [NativeTypeName("#define MM_AMD_INTERWAVE_STEREO_ENHANCED 19")]
    public const int MM_AMD_INTERWAVE_STEREO_ENHANCED = 19;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNAMIXHR 1")]
    public const int MM_COREDYNAMICS_DYNAMIXHR = 1;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_SYNTH 2")]
    public const int MM_COREDYNAMICS_DYNASONIX_SYNTH = 2;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_MIDI_IN 3")]
    public const int MM_COREDYNAMICS_DYNASONIX_MIDI_IN = 3;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_MIDI_OUT 4")]
    public const int MM_COREDYNAMICS_DYNASONIX_MIDI_OUT = 4;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_WAVE_IN 5")]
    public const int MM_COREDYNAMICS_DYNASONIX_WAVE_IN = 5;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_WAVE_OUT 6")]
    public const int MM_COREDYNAMICS_DYNASONIX_WAVE_OUT = 6;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_AUDIO_IN 7")]
    public const int MM_COREDYNAMICS_DYNASONIX_AUDIO_IN = 7;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNASONIX_AUDIO_OUT 8")]
    public const int MM_COREDYNAMICS_DYNASONIX_AUDIO_OUT = 8;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNAGRAFX_VGA 9")]
    public const int MM_COREDYNAMICS_DYNAGRAFX_VGA = 9;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNAGRAFX_WAVE_IN 10")]
    public const int MM_COREDYNAMICS_DYNAGRAFX_WAVE_IN = 10;

    [NativeTypeName("#define MM_COREDYNAMICS_DYNAGRAFX_WAVE_OUT 11")]
    public const int MM_COREDYNAMICS_DYNAGRAFX_WAVE_OUT = 11;

    [NativeTypeName("#define MM_CANAM_CBXWAVEOUT 1")]
    public const int MM_CANAM_CBXWAVEOUT = 1;

    [NativeTypeName("#define MM_CANAM_CBXWAVEIN 2")]
    public const int MM_CANAM_CBXWAVEIN = 2;

    [NativeTypeName("#define MM_SOFTSOUND_CODEC 1")]
    public const int MM_SOFTSOUND_CODEC = 1;

    [NativeTypeName("#define MM_NORRIS_VOICELINK 1")]
    public const int MM_NORRIS_VOICELINK = 1;

    [NativeTypeName("#define MM_DDD_MIDILINK_MIDIIN 1")]
    public const int MM_DDD_MIDILINK_MIDIIN = 1;

    [NativeTypeName("#define MM_DDD_MIDILINK_MIDIOUT 2")]
    public const int MM_DDD_MIDILINK_MIDIOUT = 2;

    [NativeTypeName("#define MM_EUPHONICS_AUX_CD 1")]
    public const int MM_EUPHONICS_AUX_CD = 1;

    [NativeTypeName("#define MM_EUPHONICS_AUX_LINE 2")]
    public const int MM_EUPHONICS_AUX_LINE = 2;

    [NativeTypeName("#define MM_EUPHONICS_AUX_MASTER 3")]
    public const int MM_EUPHONICS_AUX_MASTER = 3;

    [NativeTypeName("#define MM_EUPHONICS_AUX_MIC 4")]
    public const int MM_EUPHONICS_AUX_MIC = 4;

    [NativeTypeName("#define MM_EUPHONICS_AUX_MIDI 5")]
    public const int MM_EUPHONICS_AUX_MIDI = 5;

    [NativeTypeName("#define MM_EUPHONICS_AUX_WAVE 6")]
    public const int MM_EUPHONICS_AUX_WAVE = 6;

    [NativeTypeName("#define MM_EUPHONICS_FMSYNTH_MONO 7")]
    public const int MM_EUPHONICS_FMSYNTH_MONO = 7;

    [NativeTypeName("#define MM_EUPHONICS_FMSYNTH_STEREO 8")]
    public const int MM_EUPHONICS_FMSYNTH_STEREO = 8;

    [NativeTypeName("#define MM_EUPHONICS_MIDIIN 9")]
    public const int MM_EUPHONICS_MIDIIN = 9;

    [NativeTypeName("#define MM_EUPHONICS_MIDIOUT 10")]
    public const int MM_EUPHONICS_MIDIOUT = 10;

    [NativeTypeName("#define MM_EUPHONICS_MIXER 11")]
    public const int MM_EUPHONICS_MIXER = 11;

    [NativeTypeName("#define MM_EUPHONICS_WAVEIN 12")]
    public const int MM_EUPHONICS_WAVEIN = 12;

    [NativeTypeName("#define MM_EUPHONICS_WAVEOUT 13")]
    public const int MM_EUPHONICS_WAVEOUT = 13;

    [NativeTypeName("#define MM_EUPHONICS_EUSYNTH 14")]
    public const int MM_EUPHONICS_EUSYNTH = 14;

    [NativeTypeName("#define MM_CHROMATIC_M1 0x0001")]
    public const int MM_CHROMATIC_M1 = 0x0001;

    [NativeTypeName("#define MM_CHROMATIC_M1_WAVEIN 0x0002")]
    public const int MM_CHROMATIC_M1_WAVEIN = 0x0002;

    [NativeTypeName("#define MM_CHROMATIC_M1_WAVEOUT 0x0003")]
    public const int MM_CHROMATIC_M1_WAVEOUT = 0x0003;

    [NativeTypeName("#define MM_CHROMATIC_M1_FMSYNTH 0x0004")]
    public const int MM_CHROMATIC_M1_FMSYNTH = 0x0004;

    [NativeTypeName("#define MM_CHROMATIC_M1_MIXER 0x0005")]
    public const int MM_CHROMATIC_M1_MIXER = 0x0005;

    [NativeTypeName("#define MM_CHROMATIC_M1_AUX 0x0006")]
    public const int MM_CHROMATIC_M1_AUX = 0x0006;

    [NativeTypeName("#define MM_CHROMATIC_M1_AUX_CD 0x0007")]
    public const int MM_CHROMATIC_M1_AUX_CD = 0x0007;

    [NativeTypeName("#define MM_CHROMATIC_M1_MIDIIN 0x0008")]
    public const int MM_CHROMATIC_M1_MIDIIN = 0x0008;

    [NativeTypeName("#define MM_CHROMATIC_M1_MIDIOUT 0x0009")]
    public const int MM_CHROMATIC_M1_MIDIOUT = 0x0009;

    [NativeTypeName("#define MM_CHROMATIC_M1_WTSYNTH 0x0010")]
    public const int MM_CHROMATIC_M1_WTSYNTH = 0x0010;

    [NativeTypeName("#define MM_CHROMATIC_M1_MPEGWAVEIN 0x0011")]
    public const int MM_CHROMATIC_M1_MPEGWAVEIN = 0x0011;

    [NativeTypeName("#define MM_CHROMATIC_M1_MPEGWAVEOUT 0x0012")]
    public const int MM_CHROMATIC_M1_MPEGWAVEOUT = 0x0012;

    [NativeTypeName("#define MM_CHROMATIC_M2 0x0013")]
    public const int MM_CHROMATIC_M2 = 0x0013;

    [NativeTypeName("#define MM_CHROMATIC_M2_WAVEIN 0x0014")]
    public const int MM_CHROMATIC_M2_WAVEIN = 0x0014;

    [NativeTypeName("#define MM_CHROMATIC_M2_WAVEOUT 0x0015")]
    public const int MM_CHROMATIC_M2_WAVEOUT = 0x0015;

    [NativeTypeName("#define MM_CHROMATIC_M2_FMSYNTH 0x0016")]
    public const int MM_CHROMATIC_M2_FMSYNTH = 0x0016;

    [NativeTypeName("#define MM_CHROMATIC_M2_MIXER 0x0017")]
    public const int MM_CHROMATIC_M2_MIXER = 0x0017;

    [NativeTypeName("#define MM_CHROMATIC_M2_AUX 0x0018")]
    public const int MM_CHROMATIC_M2_AUX = 0x0018;

    [NativeTypeName("#define MM_CHROMATIC_M2_AUX_CD 0x0019")]
    public const int MM_CHROMATIC_M2_AUX_CD = 0x0019;

    [NativeTypeName("#define MM_CHROMATIC_M2_MIDIIN 0x0020")]
    public const int MM_CHROMATIC_M2_MIDIIN = 0x0020;

    [NativeTypeName("#define MM_CHROMATIC_M2_MIDIOUT 0x0021")]
    public const int MM_CHROMATIC_M2_MIDIOUT = 0x0021;

    [NativeTypeName("#define MM_CHROMATIC_M2_WTSYNTH 0x0022")]
    public const int MM_CHROMATIC_M2_WTSYNTH = 0x0022;

    [NativeTypeName("#define MM_CHROMATIC_M2_MPEGWAVEIN 0x0023")]
    public const int MM_CHROMATIC_M2_MPEGWAVEIN = 0x0023;

    [NativeTypeName("#define MM_CHROMATIC_M2_MPEGWAVEOUT 0x0024")]
    public const int MM_CHROMATIC_M2_MPEGWAVEOUT = 0x0024;

    [NativeTypeName("#define MM_VIENNASYS_TSP_WAVE_DRIVER 1")]
    public const int MM_VIENNASYS_TSP_WAVE_DRIVER = 1;

    [NativeTypeName("#define MM_CONNECTIX_VIDEC_CODEC 1")]
    public const int MM_CONNECTIX_VIDEC_CODEC = 1;

    [NativeTypeName("#define MM_GADGETLABS_WAVE44_WAVEIN 1")]
    public const int MM_GADGETLABS_WAVE44_WAVEIN = 1;

    [NativeTypeName("#define MM_GADGETLABS_WAVE44_WAVEOUT 2")]
    public const int MM_GADGETLABS_WAVE44_WAVEOUT = 2;

    [NativeTypeName("#define MM_GADGETLABS_WAVE42_WAVEIN 3")]
    public const int MM_GADGETLABS_WAVE42_WAVEIN = 3;

    [NativeTypeName("#define MM_GADGETLABS_WAVE42_WAVEOUT 4")]
    public const int MM_GADGETLABS_WAVE42_WAVEOUT = 4;

    [NativeTypeName("#define MM_GADGETLABS_WAVE4_MIDIIN 5")]
    public const int MM_GADGETLABS_WAVE4_MIDIIN = 5;

    [NativeTypeName("#define MM_GADGETLABS_WAVE4_MIDIOUT 6")]
    public const int MM_GADGETLABS_WAVE4_MIDIOUT = 6;

    [NativeTypeName("#define MM_FRONTIER_WAVECENTER_MIDIIN 1")]
    public const int MM_FRONTIER_WAVECENTER_MIDIIN = 1;

    [NativeTypeName("#define MM_FRONTIER_WAVECENTER_MIDIOUT 2")]
    public const int MM_FRONTIER_WAVECENTER_MIDIOUT = 2;

    [NativeTypeName("#define MM_FRONTIER_WAVECENTER_WAVEIN 3")]
    public const int MM_FRONTIER_WAVECENTER_WAVEIN = 3;

    [NativeTypeName("#define MM_FRONTIER_WAVECENTER_WAVEOUT 4")]
    public const int MM_FRONTIER_WAVECENTER_WAVEOUT = 4;

    [NativeTypeName("#define MM_VIONA_QVINPCI_MIXER 1")]
    public const int MM_VIONA_QVINPCI_MIXER = 1;

    [NativeTypeName("#define MM_VIONA_QVINPCI_WAVEIN 2")]
    public const int MM_VIONA_QVINPCI_WAVEIN = 2;

    [NativeTypeName("#define MM_VIONAQVINPCI_WAVEOUT 3")]
    public const int MM_VIONAQVINPCI_WAVEOUT = 3;

    [NativeTypeName("#define MM_VIONA_BUSTER_MIXER 4")]
    public const int MM_VIONA_BUSTER_MIXER = 4;

    [NativeTypeName("#define MM_VIONA_CINEMASTER_MIXER 5")]
    public const int MM_VIONA_CINEMASTER_MIXER = 5;

    [NativeTypeName("#define MM_VIONA_CONCERTO_MIXER 6")]
    public const int MM_VIONA_CONCERTO_MIXER = 6;

    [NativeTypeName("#define MM_CASIO_WP150_MIDIOUT 1")]
    public const int MM_CASIO_WP150_MIDIOUT = 1;

    [NativeTypeName("#define MM_CASIO_WP150_MIDIIN 2")]
    public const int MM_CASIO_WP150_MIDIIN = 2;

    [NativeTypeName("#define MM_CASIO_LSG_MIDIOUT 3")]
    public const int MM_CASIO_LSG_MIDIOUT = 3;

    [NativeTypeName("#define MM_DIMD_PLATFORM 0")]
    public const int MM_DIMD_PLATFORM = 0;

    [NativeTypeName("#define MM_DIMD_DIRSOUND 1")]
    public const int MM_DIMD_DIRSOUND = 1;

    [NativeTypeName("#define MM_DIMD_VIRTMPU 2")]
    public const int MM_DIMD_VIRTMPU = 2;

    [NativeTypeName("#define MM_DIMD_VIRTSB 3")]
    public const int MM_DIMD_VIRTSB = 3;

    [NativeTypeName("#define MM_DIMD_VIRTJOY 4")]
    public const int MM_DIMD_VIRTJOY = 4;

    [NativeTypeName("#define MM_DIMD_WAVEIN 5")]
    public const int MM_DIMD_WAVEIN = 5;

    [NativeTypeName("#define MM_DIMD_WAVEOUT 6")]
    public const int MM_DIMD_WAVEOUT = 6;

    [NativeTypeName("#define MM_DIMD_MIDIIN 7")]
    public const int MM_DIMD_MIDIIN = 7;

    [NativeTypeName("#define MM_DIMD_MIDIOUT 8")]
    public const int MM_DIMD_MIDIOUT = 8;

    [NativeTypeName("#define MM_DIMD_AUX_LINE 9")]
    public const int MM_DIMD_AUX_LINE = 9;

    [NativeTypeName("#define MM_DIMD_MIXER 10")]
    public const int MM_DIMD_MIXER = 10;

    [NativeTypeName("#define MM_DIMD_WSS_WAVEIN 14")]
    public const int MM_DIMD_WSS_WAVEIN = 14;

    [NativeTypeName("#define MM_DIMD_WSS_WAVEOUT 15")]
    public const int MM_DIMD_WSS_WAVEOUT = 15;

    [NativeTypeName("#define MM_DIMD_WSS_MIXER 17")]
    public const int MM_DIMD_WSS_MIXER = 17;

    [NativeTypeName("#define MM_DIMD_WSS_AUX 21")]
    public const int MM_DIMD_WSS_AUX = 21;

    [NativeTypeName("#define MM_DIMD_WSS_SYNTH 76")]
    public const int MM_DIMD_WSS_SYNTH = 76;

    [NativeTypeName("#define MM_S3_WAVEOUT 1")]
    public const int MM_S3_WAVEOUT = 1;

    [NativeTypeName("#define MM_S3_WAVEIN 2")]
    public const int MM_S3_WAVEIN = 2;

    [NativeTypeName("#define MM_S3_MIDIOUT 3")]
    public const int MM_S3_MIDIOUT = 3;

    [NativeTypeName("#define MM_S3_MIDIIN 4")]
    public const int MM_S3_MIDIIN = 4;

    [NativeTypeName("#define MM_S3_FMSYNTH 5")]
    public const int MM_S3_FMSYNTH = 5;

    [NativeTypeName("#define MM_S3_MIXER 6")]
    public const int MM_S3_MIXER = 6;

    [NativeTypeName("#define MM_S3_AUX 7")]
    public const int MM_S3_AUX = 7;

    [NativeTypeName("#define MM_VKC_MPU401_MIDIIN 0x0100")]
    public const int MM_VKC_MPU401_MIDIIN = 0x0100;

    [NativeTypeName("#define MM_VKC_SERIAL_MIDIIN 0x0101")]
    public const int MM_VKC_SERIAL_MIDIIN = 0x0101;

    [NativeTypeName("#define MM_VKC_MPU401_MIDIOUT 0x0200")]
    public const int MM_VKC_MPU401_MIDIOUT = 0x0200;

    [NativeTypeName("#define MM_VKC_SERIAL_MIDIOUT 0x0201")]
    public const int MM_VKC_SERIAL_MIDIOUT = 0x0201;

    [NativeTypeName("#define MM_ZEFIRO_ZA2 2")]
    public const int MM_ZEFIRO_ZA2 = 2;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3_DECODE 9")]
    public const int MM_FHGIIS_MPEGLAYER3_DECODE = 9;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3 10")]
    public const int MM_FHGIIS_MPEGLAYER3 = 10;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3_LITE 10")]
    public const int MM_FHGIIS_MPEGLAYER3_LITE = 10;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3_BASIC 11")]
    public const int MM_FHGIIS_MPEGLAYER3_BASIC = 11;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3_ADVANCED 12")]
    public const int MM_FHGIIS_MPEGLAYER3_ADVANCED = 12;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3_PROFESSIONAL 13")]
    public const int MM_FHGIIS_MPEGLAYER3_PROFESSIONAL = 13;

    [NativeTypeName("#define MM_FHGIIS_MPEGLAYER3_ADVANCEDPLUS 14")]
    public const int MM_FHGIIS_MPEGLAYER3_ADVANCEDPLUS = 14;

    [NativeTypeName("#define MM_QUICKNET_PJWAVEIN 1")]
    public const int MM_QUICKNET_PJWAVEIN = 1;

    [NativeTypeName("#define MM_QUICKNET_PJWAVEOUT 2")]
    public const int MM_QUICKNET_PJWAVEOUT = 2;

    [NativeTypeName("#define MM_SICRESOURCE_SSO3D 2")]
    public const int MM_SICRESOURCE_SSO3D = 2;

    [NativeTypeName("#define MM_SICRESOURCE_SSOW3DI 3")]
    public const int MM_SICRESOURCE_SSOW3DI = 3;

    [NativeTypeName("#define MM_NEOMAGIC_SYNTH 1")]
    public const int MM_NEOMAGIC_SYNTH = 1;

    [NativeTypeName("#define MM_NEOMAGIC_WAVEOUT 2")]
    public const int MM_NEOMAGIC_WAVEOUT = 2;

    [NativeTypeName("#define MM_NEOMAGIC_WAVEIN 3")]
    public const int MM_NEOMAGIC_WAVEIN = 3;

    [NativeTypeName("#define MM_NEOMAGIC_MIDIOUT 4")]
    public const int MM_NEOMAGIC_MIDIOUT = 4;

    [NativeTypeName("#define MM_NEOMAGIC_MIDIIN 5")]
    public const int MM_NEOMAGIC_MIDIIN = 5;

    [NativeTypeName("#define MM_NEOMAGIC_AUX 6")]
    public const int MM_NEOMAGIC_AUX = 6;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_WAVEOUT 10")]
    public const int MM_NEOMAGIC_MW3DX_WAVEOUT = 10;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_WAVEIN 11")]
    public const int MM_NEOMAGIC_MW3DX_WAVEIN = 11;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_MIDIOUT 12")]
    public const int MM_NEOMAGIC_MW3DX_MIDIOUT = 12;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_MIDIIN 13")]
    public const int MM_NEOMAGIC_MW3DX_MIDIIN = 13;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_FMSYNTH 14")]
    public const int MM_NEOMAGIC_MW3DX_FMSYNTH = 14;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_GMSYNTH 15")]
    public const int MM_NEOMAGIC_MW3DX_GMSYNTH = 15;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_MIXER 16")]
    public const int MM_NEOMAGIC_MW3DX_MIXER = 16;

    [NativeTypeName("#define MM_NEOMAGIC_MW3DX_AUX 17")]
    public const int MM_NEOMAGIC_MW3DX_AUX = 17;

    [NativeTypeName("#define MM_NEOMAGIC_MWAVE_WAVEOUT 20")]
    public const int MM_NEOMAGIC_MWAVE_WAVEOUT = 20;

    [NativeTypeName("#define MM_NEOMAGIC_MWAVE_WAVEIN 21")]
    public const int MM_NEOMAGIC_MWAVE_WAVEIN = 21;

    [NativeTypeName("#define MM_NEOMAGIC_MWAVE_MIDIOUT 22")]
    public const int MM_NEOMAGIC_MWAVE_MIDIOUT = 22;

    [NativeTypeName("#define MM_NEOMAGIC_MWAVE_MIDIIN 23")]
    public const int MM_NEOMAGIC_MWAVE_MIDIIN = 23;

    [NativeTypeName("#define MM_NEOMAGIC_MWAVE_MIXER 24")]
    public const int MM_NEOMAGIC_MWAVE_MIXER = 24;

    [NativeTypeName("#define MM_NEOMAGIC_MWAVE_AUX 25")]
    public const int MM_NEOMAGIC_MWAVE_AUX = 25;

    [NativeTypeName("#define MM_MERGING_MPEGL3 1")]
    public const int MM_MERGING_MPEGL3 = 1;

    [NativeTypeName("#define MM_XIRLINK_VISIONLINK 1")]
    public const int MM_XIRLINK_VISIONLINK = 1;

    [NativeTypeName("#define MM_OTI_611WAVEIN 5")]
    public const int MM_OTI_611WAVEIN = 5;

    [NativeTypeName("#define MM_OTI_611WAVEOUT 6")]
    public const int MM_OTI_611WAVEOUT = 6;

    [NativeTypeName("#define MM_OTI_611MIXER 7")]
    public const int MM_OTI_611MIXER = 7;

    [NativeTypeName("#define MM_OTI_611MIDIN 0x12")]
    public const int MM_OTI_611MIDIN = 0x12;

    [NativeTypeName("#define MM_OTI_611MIDIOUT 0x13")]
    public const int MM_OTI_611MIDIOUT = 0x13;

    [NativeTypeName("#define MM_AUREAL_AU8820 16")]
    public const int MM_AUREAL_AU8820 = 16;

    [NativeTypeName("#define MM_AU8820_SYNTH 17")]
    public const int MM_AU8820_SYNTH = 17;

    [NativeTypeName("#define MM_AU8820_WAVEOUT 18")]
    public const int MM_AU8820_WAVEOUT = 18;

    [NativeTypeName("#define MM_AU8820_WAVEIN 19")]
    public const int MM_AU8820_WAVEIN = 19;

    [NativeTypeName("#define MM_AU8820_MIXER 20")]
    public const int MM_AU8820_MIXER = 20;

    [NativeTypeName("#define MM_AU8820_AUX 21")]
    public const int MM_AU8820_AUX = 21;

    [NativeTypeName("#define MM_AU8820_MIDIOUT 22")]
    public const int MM_AU8820_MIDIOUT = 22;

    [NativeTypeName("#define MM_AU8820_MIDIIN 23")]
    public const int MM_AU8820_MIDIIN = 23;

    [NativeTypeName("#define MM_AUREAL_AU8830 32")]
    public const int MM_AUREAL_AU8830 = 32;

    [NativeTypeName("#define MM_AU8830_SYNTH 33")]
    public const int MM_AU8830_SYNTH = 33;

    [NativeTypeName("#define MM_AU8830_WAVEOUT 34")]
    public const int MM_AU8830_WAVEOUT = 34;

    [NativeTypeName("#define MM_AU8830_WAVEIN 35")]
    public const int MM_AU8830_WAVEIN = 35;

    [NativeTypeName("#define MM_AU8830_MIXER 36")]
    public const int MM_AU8830_MIXER = 36;

    [NativeTypeName("#define MM_AU8830_AUX 37")]
    public const int MM_AU8830_AUX = 37;

    [NativeTypeName("#define MM_AU8830_MIDIOUT 38")]
    public const int MM_AU8830_MIDIOUT = 38;

    [NativeTypeName("#define MM_AU8830_MIDIIN 39")]
    public const int MM_AU8830_MIDIIN = 39;

    [NativeTypeName("#define MM_VIVO_AUDIO_CODEC 1")]
    public const int MM_VIVO_AUDIO_CODEC = 1;

    [NativeTypeName("#define MM_SHARP_MDC_MIDI_SYNTH 1")]
    public const int MM_SHARP_MDC_MIDI_SYNTH = 1;

    [NativeTypeName("#define MM_SHARP_MDC_MIDI_IN 2")]
    public const int MM_SHARP_MDC_MIDI_IN = 2;

    [NativeTypeName("#define MM_SHARP_MDC_MIDI_OUT 3")]
    public const int MM_SHARP_MDC_MIDI_OUT = 3;

    [NativeTypeName("#define MM_SHARP_MDC_WAVE_IN 4")]
    public const int MM_SHARP_MDC_WAVE_IN = 4;

    [NativeTypeName("#define MM_SHARP_MDC_WAVE_OUT 5")]
    public const int MM_SHARP_MDC_WAVE_OUT = 5;

    [NativeTypeName("#define MM_SHARP_MDC_AUX 6")]
    public const int MM_SHARP_MDC_AUX = 6;

    [NativeTypeName("#define MM_SHARP_MDC_MIXER 10")]
    public const int MM_SHARP_MDC_MIXER = 10;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_MASTER 100")]
    public const int MM_SHARP_MDC_AUX_MASTER = 100;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_BASS 101")]
    public const int MM_SHARP_MDC_AUX_BASS = 101;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_TREBLE 102")]
    public const int MM_SHARP_MDC_AUX_TREBLE = 102;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_MIDI_VOL 103")]
    public const int MM_SHARP_MDC_AUX_MIDI_VOL = 103;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_WAVE_VOL 104")]
    public const int MM_SHARP_MDC_AUX_WAVE_VOL = 104;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_WAVE_RVB 105")]
    public const int MM_SHARP_MDC_AUX_WAVE_RVB = 105;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_WAVE_CHR 106")]
    public const int MM_SHARP_MDC_AUX_WAVE_CHR = 106;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_VOL 107")]
    public const int MM_SHARP_MDC_AUX_VOL = 107;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_RVB 108")]
    public const int MM_SHARP_MDC_AUX_RVB = 108;

    [NativeTypeName("#define MM_SHARP_MDC_AUX_CHR 109")]
    public const int MM_SHARP_MDC_AUX_CHR = 109;

    [NativeTypeName("#define MM_LUCENT_ACM_G723 0")]
    public const int MM_LUCENT_ACM_G723 = 0;

    [NativeTypeName("#define MM_ATT_G729A 1")]
    public const int MM_ATT_G729A = 1;

    [NativeTypeName("#define MM_MARIAN_ARC44WAVEIN 1")]
    public const int MM_MARIAN_ARC44WAVEIN = 1;

    [NativeTypeName("#define MM_MARIAN_ARC44WAVEOUT 2")]
    public const int MM_MARIAN_ARC44WAVEOUT = 2;

    [NativeTypeName("#define MM_MARIAN_PRODIF24WAVEIN 3")]
    public const int MM_MARIAN_PRODIF24WAVEIN = 3;

    [NativeTypeName("#define MM_MARIAN_PRODIF24WAVEOUT 4")]
    public const int MM_MARIAN_PRODIF24WAVEOUT = 4;

    [NativeTypeName("#define MM_MARIAN_ARC88WAVEIN 5")]
    public const int MM_MARIAN_ARC88WAVEIN = 5;

    [NativeTypeName("#define MM_MARIAN_ARC88WAVEOUT 6")]
    public const int MM_MARIAN_ARC88WAVEOUT = 6;

    [NativeTypeName("#define MM_BCB_NETBOARD_10 1")]
    public const int MM_BCB_NETBOARD_10 = 1;

    [NativeTypeName("#define MM_BCB_TT75_10 2")]
    public const int MM_BCB_TT75_10 = 2;

    [NativeTypeName("#define MM_MOTIONPIXELS_MVI2 1")]
    public const int MM_MOTIONPIXELS_MVI2 = 1;

    [NativeTypeName("#define MM_QDESIGN_ACM_MPEG 1")]
    public const int MM_QDESIGN_ACM_MPEG = 1;

    [NativeTypeName("#define MM_QDESIGN_ACM_QDESIGN_MUSIC 2")]
    public const int MM_QDESIGN_ACM_QDESIGN_MUSIC = 2;

    [NativeTypeName("#define MM_NMP_CCP_WAVEIN 1")]
    public const int MM_NMP_CCP_WAVEIN = 1;

    [NativeTypeName("#define MM_NMP_CCP_WAVEOUT 2")]
    public const int MM_NMP_CCP_WAVEOUT = 2;

    [NativeTypeName("#define MM_NMP_ACM_AMR 10")]
    public const int MM_NMP_ACM_AMR = 10;

    [NativeTypeName("#define MM_DF_ACM_G726 1")]
    public const int MM_DF_ACM_G726 = 1;

    [NativeTypeName("#define MM_DF_ACM_GSM610 2")]
    public const int MM_DF_ACM_GSM610 = 2;

    [NativeTypeName("#define MM_BERCOS_WAVEIN 1")]
    public const int MM_BERCOS_WAVEIN = 1;

    [NativeTypeName("#define MM_BERCOS_MIXER 2")]
    public const int MM_BERCOS_MIXER = 2;

    [NativeTypeName("#define MM_BERCOS_WAVEOUT 3")]
    public const int MM_BERCOS_WAVEOUT = 3;

    [NativeTypeName("#define MM_ONLIVE_MPCODEC 1")]
    public const int MM_ONLIVE_MPCODEC = 1;

    [NativeTypeName("#define MM_PHONET_PP_WAVEOUT 1")]
    public const int MM_PHONET_PP_WAVEOUT = 1;

    [NativeTypeName("#define MM_PHONET_PP_WAVEIN 2")]
    public const int MM_PHONET_PP_WAVEIN = 2;

    [NativeTypeName("#define MM_PHONET_PP_MIXER 3")]
    public const int MM_PHONET_PP_MIXER = 3;

    [NativeTypeName("#define MM_FTR_ENCODER_WAVEIN 1")]
    public const int MM_FTR_ENCODER_WAVEIN = 1;

    [NativeTypeName("#define MM_FTR_ACM 2")]
    public const int MM_FTR_ACM = 2;

    [NativeTypeName("#define MM_ENET_T2000_LINEIN 1")]
    public const int MM_ENET_T2000_LINEIN = 1;

    [NativeTypeName("#define MM_ENET_T2000_LINEOUT 2")]
    public const int MM_ENET_T2000_LINEOUT = 2;

    [NativeTypeName("#define MM_ENET_T2000_HANDSETIN 3")]
    public const int MM_ENET_T2000_HANDSETIN = 3;

    [NativeTypeName("#define MM_ENET_T2000_HANDSETOUT 4")]
    public const int MM_ENET_T2000_HANDSETOUT = 4;

    [NativeTypeName("#define MM_EMAGIC_UNITOR8 1")]
    public const int MM_EMAGIC_UNITOR8 = 1;

    [NativeTypeName("#define MM_SIPROLAB_ACELPNET 1")]
    public const int MM_SIPROLAB_ACELPNET = 1;

    [NativeTypeName("#define MM_DICTAPHONE_G726 1")]
    public const int MM_DICTAPHONE_G726 = 1;

    [NativeTypeName("#define MM_RZS_ACM_TUBGSM 1")]
    public const int MM_RZS_ACM_TUBGSM = 1;

    [NativeTypeName("#define MM_EES_PCMIDI14 1")]
    public const int MM_EES_PCMIDI14 = 1;

    [NativeTypeName("#define MM_EES_PCMIDI14_IN 2")]
    public const int MM_EES_PCMIDI14_IN = 2;

    [NativeTypeName("#define MM_EES_PCMIDI14_OUT1 3")]
    public const int MM_EES_PCMIDI14_OUT1 = 3;

    [NativeTypeName("#define MM_EES_PCMIDI14_OUT2 4")]
    public const int MM_EES_PCMIDI14_OUT2 = 4;

    [NativeTypeName("#define MM_EES_PCMIDI14_OUT3 5")]
    public const int MM_EES_PCMIDI14_OUT3 = 5;

    [NativeTypeName("#define MM_EES_PCMIDI14_OUT4 6")]
    public const int MM_EES_PCMIDI14_OUT4 = 6;

    [NativeTypeName("#define MM_HAFTMANN_LPTDAC2 1")]
    public const int MM_HAFTMANN_LPTDAC2 = 1;

    [NativeTypeName("#define MM_LUCID_PCI24WAVEIN 1")]
    public const int MM_LUCID_PCI24WAVEIN = 1;

    [NativeTypeName("#define MM_LUCID_PCI24WAVEOUT 2")]
    public const int MM_LUCID_PCI24WAVEOUT = 2;

    [NativeTypeName("#define MM_HEADSPACE_HAESYNTH 1")]
    public const int MM_HEADSPACE_HAESYNTH = 1;

    [NativeTypeName("#define MM_HEADSPACE_HAEWAVEOUT 2")]
    public const int MM_HEADSPACE_HAEWAVEOUT = 2;

    [NativeTypeName("#define MM_HEADSPACE_HAEWAVEIN 3")]
    public const int MM_HEADSPACE_HAEWAVEIN = 3;

    [NativeTypeName("#define MM_HEADSPACE_HAEMIXER 4")]
    public const int MM_HEADSPACE_HAEMIXER = 4;

    [NativeTypeName("#define MM_UNISYS_ACM_NAP 1")]
    public const int MM_UNISYS_ACM_NAP = 1;

    [NativeTypeName("#define MM_LUMINOSITI_SCWAVEIN 1")]
    public const int MM_LUMINOSITI_SCWAVEIN = 1;

    [NativeTypeName("#define MM_LUMINOSITI_SCWAVEOUT 2")]
    public const int MM_LUMINOSITI_SCWAVEOUT = 2;

    [NativeTypeName("#define MM_LUMINOSITI_SCWAVEMIX 3")]
    public const int MM_LUMINOSITI_SCWAVEMIX = 3;

    [NativeTypeName("#define MM_ACTIVEVOICE_ACM_VOXADPCM 1")]
    public const int MM_ACTIVEVOICE_ACM_VOXADPCM = 1;

    [NativeTypeName("#define MM_DTS_DS 1")]
    public const int MM_DTS_DS = 1;

    [NativeTypeName("#define MM_SOFTLAB_NSK_FRW_WAVEIN 1")]
    public const int MM_SOFTLAB_NSK_FRW_WAVEIN = 1;

    [NativeTypeName("#define MM_SOFTLAB_NSK_FRW_WAVEOUT 2")]
    public const int MM_SOFTLAB_NSK_FRW_WAVEOUT = 2;

    [NativeTypeName("#define MM_SOFTLAB_NSK_FRW_MIXER 3")]
    public const int MM_SOFTLAB_NSK_FRW_MIXER = 3;

    [NativeTypeName("#define MM_SOFTLAB_NSK_FRW_AUX 4")]
    public const int MM_SOFTLAB_NSK_FRW_AUX = 4;

    [NativeTypeName("#define MM_FORTEMEDIA_WAVEIN 1")]
    public const int MM_FORTEMEDIA_WAVEIN = 1;

    [NativeTypeName("#define MM_FORTEMEDIA_WAVEOUT 2")]
    public const int MM_FORTEMEDIA_WAVEOUT = 2;

    [NativeTypeName("#define MM_FORTEMEDIA_FMSYNC 3")]
    public const int MM_FORTEMEDIA_FMSYNC = 3;

    [NativeTypeName("#define MM_FORTEMEDIA_MIXER 4")]
    public const int MM_FORTEMEDIA_MIXER = 4;

    [NativeTypeName("#define MM_FORTEMEDIA_AUX 5")]
    public const int MM_FORTEMEDIA_AUX = 5;

    [NativeTypeName("#define MM_SONORUS_STUDIO 1")]
    public const int MM_SONORUS_STUDIO = 1;

    [NativeTypeName("#define MM_I_LINK_VOICE_CODER 1")]
    public const int MM_I_LINK_VOICE_CODER = 1;

    [NativeTypeName("#define MM_SELSIUS_SYSTEMS_RTPWAVEOUT 1")]
    public const int MM_SELSIUS_SYSTEMS_RTPWAVEOUT = 1;

    [NativeTypeName("#define MM_SELSIUS_SYSTEMS_RTPWAVEIN 2")]
    public const int MM_SELSIUS_SYSTEMS_RTPWAVEIN = 2;

    [NativeTypeName("#define MM_ADMOS_FM_SYNTH 1")]
    public const int MM_ADMOS_FM_SYNTH = 1;

    [NativeTypeName("#define MM_ADMOS_QS3AMIDIOUT 2")]
    public const int MM_ADMOS_QS3AMIDIOUT = 2;

    [NativeTypeName("#define MM_ADMOS_QS3AMIDIIN 3")]
    public const int MM_ADMOS_QS3AMIDIIN = 3;

    [NativeTypeName("#define MM_ADMOS_QS3AWAVEOUT 4")]
    public const int MM_ADMOS_QS3AWAVEOUT = 4;

    [NativeTypeName("#define MM_ADMOS_QS3AWAVEIN 5")]
    public const int MM_ADMOS_QS3AWAVEIN = 5;

    [NativeTypeName("#define MM_LEXICON_STUDIO_WAVE_OUT 1")]
    public const int MM_LEXICON_STUDIO_WAVE_OUT = 1;

    [NativeTypeName("#define MM_LEXICON_STUDIO_WAVE_IN 2")]
    public const int MM_LEXICON_STUDIO_WAVE_IN = 2;

    [NativeTypeName("#define MM_SGI_320_WAVEIN 1")]
    public const int MM_SGI_320_WAVEIN = 1;

    [NativeTypeName("#define MM_SGI_320_WAVEOUT 2")]
    public const int MM_SGI_320_WAVEOUT = 2;

    [NativeTypeName("#define MM_SGI_320_MIXER 3")]
    public const int MM_SGI_320_MIXER = 3;

    [NativeTypeName("#define MM_SGI_540_WAVEIN 4")]
    public const int MM_SGI_540_WAVEIN = 4;

    [NativeTypeName("#define MM_SGI_540_WAVEOUT 5")]
    public const int MM_SGI_540_WAVEOUT = 5;

    [NativeTypeName("#define MM_SGI_540_MIXER 6")]
    public const int MM_SGI_540_MIXER = 6;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO1_WAVEIN 7")]
    public const int MM_SGI_RAD_ADATMONO1_WAVEIN = 7;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO2_WAVEIN 8")]
    public const int MM_SGI_RAD_ADATMONO2_WAVEIN = 8;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO3_WAVEIN 9")]
    public const int MM_SGI_RAD_ADATMONO3_WAVEIN = 9;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO4_WAVEIN 10")]
    public const int MM_SGI_RAD_ADATMONO4_WAVEIN = 10;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO5_WAVEIN 11")]
    public const int MM_SGI_RAD_ADATMONO5_WAVEIN = 11;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO6_WAVEIN 12")]
    public const int MM_SGI_RAD_ADATMONO6_WAVEIN = 12;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO7_WAVEIN 13")]
    public const int MM_SGI_RAD_ADATMONO7_WAVEIN = 13;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO8_WAVEIN 14")]
    public const int MM_SGI_RAD_ADATMONO8_WAVEIN = 14;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO12_WAVEIN 15")]
    public const int MM_SGI_RAD_ADATSTEREO12_WAVEIN = 15;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO34_WAVEIN 16")]
    public const int MM_SGI_RAD_ADATSTEREO34_WAVEIN = 16;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO56_WAVEIN 17")]
    public const int MM_SGI_RAD_ADATSTEREO56_WAVEIN = 17;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO78_WAVEIN 18")]
    public const int MM_SGI_RAD_ADATSTEREO78_WAVEIN = 18;

    [NativeTypeName("#define MM_SGI_RAD_ADAT8CHAN_WAVEIN 19")]
    public const int MM_SGI_RAD_ADAT8CHAN_WAVEIN = 19;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO1_WAVEOUT 20")]
    public const int MM_SGI_RAD_ADATMONO1_WAVEOUT = 20;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO2_WAVEOUT 21")]
    public const int MM_SGI_RAD_ADATMONO2_WAVEOUT = 21;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO3_WAVEOUT 22")]
    public const int MM_SGI_RAD_ADATMONO3_WAVEOUT = 22;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO4_WAVEOUT 23")]
    public const int MM_SGI_RAD_ADATMONO4_WAVEOUT = 23;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO5_WAVEOUT 24")]
    public const int MM_SGI_RAD_ADATMONO5_WAVEOUT = 24;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO6_WAVEOUT 25")]
    public const int MM_SGI_RAD_ADATMONO6_WAVEOUT = 25;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO7_WAVEOUT 26")]
    public const int MM_SGI_RAD_ADATMONO7_WAVEOUT = 26;

    [NativeTypeName("#define MM_SGI_RAD_ADATMONO8_WAVEOUT 27")]
    public const int MM_SGI_RAD_ADATMONO8_WAVEOUT = 27;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO12_WAVEOUT 28")]
    public const int MM_SGI_RAD_ADATSTEREO12_WAVEOUT = 28;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO32_WAVEOUT 29")]
    public const int MM_SGI_RAD_ADATSTEREO32_WAVEOUT = 29;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO56_WAVEOUT 30")]
    public const int MM_SGI_RAD_ADATSTEREO56_WAVEOUT = 30;

    [NativeTypeName("#define MM_SGI_RAD_ADATSTEREO78_WAVEOUT 31")]
    public const int MM_SGI_RAD_ADATSTEREO78_WAVEOUT = 31;

    [NativeTypeName("#define MM_SGI_RAD_ADAT8CHAN_WAVEOUT 32")]
    public const int MM_SGI_RAD_ADAT8CHAN_WAVEOUT = 32;

    [NativeTypeName("#define MM_SGI_RAD_AESMONO1_WAVEIN 33")]
    public const int MM_SGI_RAD_AESMONO1_WAVEIN = 33;

    [NativeTypeName("#define MM_SGI_RAD_AESMONO2_WAVEIN 34")]
    public const int MM_SGI_RAD_AESMONO2_WAVEIN = 34;

    [NativeTypeName("#define MM_SGI_RAD_AESSTEREO_WAVEIN 35")]
    public const int MM_SGI_RAD_AESSTEREO_WAVEIN = 35;

    [NativeTypeName("#define MM_SGI_RAD_AESMONO1_WAVEOUT 36")]
    public const int MM_SGI_RAD_AESMONO1_WAVEOUT = 36;

    [NativeTypeName("#define MM_SGI_RAD_AESMONO2_WAVEOUT 37")]
    public const int MM_SGI_RAD_AESMONO2_WAVEOUT = 37;

    [NativeTypeName("#define MM_SGI_RAD_AESSTEREO_WAVEOUT 38")]
    public const int MM_SGI_RAD_AESSTEREO_WAVEOUT = 38;

    [NativeTypeName("#define MM_IPI_ACM_HSX 1")]
    public const int MM_IPI_ACM_HSX = 1;

    [NativeTypeName("#define MM_IPI_ACM_RPELP 2")]
    public const int MM_IPI_ACM_RPELP = 2;

    [NativeTypeName("#define MM_IPI_WF_ASSS 3")]
    public const int MM_IPI_WF_ASSS = 3;

    [NativeTypeName("#define MM_IPI_AT_WAVEOUT 4")]
    public const int MM_IPI_AT_WAVEOUT = 4;

    [NativeTypeName("#define MM_IPI_AT_WAVEIN 5")]
    public const int MM_IPI_AT_WAVEIN = 5;

    [NativeTypeName("#define MM_IPI_AT_MIXER 6")]
    public const int MM_IPI_AT_MIXER = 6;

    [NativeTypeName("#define MM_ICE_WAVEOUT 1")]
    public const int MM_ICE_WAVEOUT = 1;

    [NativeTypeName("#define MM_ICE_WAVEIN 2")]
    public const int MM_ICE_WAVEIN = 2;

    [NativeTypeName("#define MM_ICE_MTWAVEOUT 3")]
    public const int MM_ICE_MTWAVEOUT = 3;

    [NativeTypeName("#define MM_ICE_MTWAVEIN 4")]
    public const int MM_ICE_MTWAVEIN = 4;

    [NativeTypeName("#define MM_ICE_MIDIOUT1 5")]
    public const int MM_ICE_MIDIOUT1 = 5;

    [NativeTypeName("#define MM_ICE_MIDIIN1 6")]
    public const int MM_ICE_MIDIIN1 = 6;

    [NativeTypeName("#define MM_ICE_MIDIOUT2 7")]
    public const int MM_ICE_MIDIOUT2 = 7;

    [NativeTypeName("#define MM_ICE_MIDIIN2 8")]
    public const int MM_ICE_MIDIIN2 = 8;

    [NativeTypeName("#define MM_ICE_SYNTH 9")]
    public const int MM_ICE_SYNTH = 9;

    [NativeTypeName("#define MM_ICE_MIXER 10")]
    public const int MM_ICE_MIXER = 10;

    [NativeTypeName("#define MM_ICE_AUX 11")]
    public const int MM_ICE_AUX = 11;

    [NativeTypeName("#define MM_VQST_VQC1 1")]
    public const int MM_VQST_VQC1 = 1;

    [NativeTypeName("#define MM_VQST_VQC2 2")]
    public const int MM_VQST_VQC2 = 2;

    [NativeTypeName("#define MM_ETEK_KWIKMIDI_MIDIIN 1")]
    public const int MM_ETEK_KWIKMIDI_MIDIIN = 1;

    [NativeTypeName("#define MM_ETEK_KWIKMIDI_MIDIOUT 2")]
    public const int MM_ETEK_KWIKMIDI_MIDIOUT = 2;

    [NativeTypeName("#define MM_INTERNET_SSW_MIDIOUT 10")]
    public const int MM_INTERNET_SSW_MIDIOUT = 10;

    [NativeTypeName("#define MM_INTERNET_SSW_MIDIIN 11")]
    public const int MM_INTERNET_SSW_MIDIIN = 11;

    [NativeTypeName("#define MM_INTERNET_SSW_WAVEOUT 12")]
    public const int MM_INTERNET_SSW_WAVEOUT = 12;

    [NativeTypeName("#define MM_INTERNET_SSW_WAVEIN 13")]
    public const int MM_INTERNET_SSW_WAVEIN = 13;

    [NativeTypeName("#define MM_SONY_ACM_SCX 1")]
    public const int MM_SONY_ACM_SCX = 1;

    [NativeTypeName("#define MM_UH_ACM_ADPCM 1")]
    public const int MM_UH_ACM_ADPCM = 1;

    [NativeTypeName("#define MM_SYDEC_NV_WAVEIN 1")]
    public const int MM_SYDEC_NV_WAVEIN = 1;

    [NativeTypeName("#define MM_SYDEC_NV_WAVEOUT 2")]
    public const int MM_SYDEC_NV_WAVEOUT = 2;

    [NativeTypeName("#define MM_FLEXION_X300_WAVEIN 1")]
    public const int MM_FLEXION_X300_WAVEIN = 1;

    [NativeTypeName("#define MM_FLEXION_X300_WAVEOUT 2")]
    public const int MM_FLEXION_X300_WAVEOUT = 2;

    [NativeTypeName("#define MM_VIA_WAVEOUT 1")]
    public const int MM_VIA_WAVEOUT = 1;

    [NativeTypeName("#define MM_VIA_WAVEIN 2")]
    public const int MM_VIA_WAVEIN = 2;

    [NativeTypeName("#define MM_VIA_MIXER 3")]
    public const int MM_VIA_MIXER = 3;

    [NativeTypeName("#define MM_VIA_AUX 4")]
    public const int MM_VIA_AUX = 4;

    [NativeTypeName("#define MM_VIA_MPU401_MIDIOUT 5")]
    public const int MM_VIA_MPU401_MIDIOUT = 5;

    [NativeTypeName("#define MM_VIA_MPU401_MIDIIN 6")]
    public const int MM_VIA_MPU401_MIDIIN = 6;

    [NativeTypeName("#define MM_VIA_SWFM_SYNTH 7")]
    public const int MM_VIA_SWFM_SYNTH = 7;

    [NativeTypeName("#define MM_VIA_WDM_WAVEOUT 8")]
    public const int MM_VIA_WDM_WAVEOUT = 8;

    [NativeTypeName("#define MM_VIA_WDM_WAVEIN 9")]
    public const int MM_VIA_WDM_WAVEIN = 9;

    [NativeTypeName("#define MM_VIA_WDM_MIXER 10")]
    public const int MM_VIA_WDM_MIXER = 10;

    [NativeTypeName("#define MM_VIA_WDM_MPU401_MIDIOUT 11")]
    public const int MM_VIA_WDM_MPU401_MIDIOUT = 11;

    [NativeTypeName("#define MM_VIA_WDM_MPU401_MIDIIN 12")]
    public const int MM_VIA_WDM_MPU401_MIDIIN = 12;

    [NativeTypeName("#define MM_MICRONAS_SC4 1")]
    public const int MM_MICRONAS_SC4 = 1;

    [NativeTypeName("#define MM_MICRONAS_CLP833 2")]
    public const int MM_MICRONAS_CLP833 = 2;

    [NativeTypeName("#define MM_HP_WAVEOUT 1")]
    public const int MM_HP_WAVEOUT = 1;

    [NativeTypeName("#define MM_HP_WAVEIN 2")]
    public const int MM_HP_WAVEIN = 2;

    [NativeTypeName("#define MM_QUICKAUDIO_MINIMIDI 1")]
    public const int MM_QUICKAUDIO_MINIMIDI = 1;

    [NativeTypeName("#define MM_QUICKAUDIO_MAXIMIDI 2")]
    public const int MM_QUICKAUDIO_MAXIMIDI = 2;

    [NativeTypeName("#define MM_ICCC_UNA3_WAVEIN 1")]
    public const int MM_ICCC_UNA3_WAVEIN = 1;

    [NativeTypeName("#define MM_ICCC_UNA3_WAVEOUT 2")]
    public const int MM_ICCC_UNA3_WAVEOUT = 2;

    [NativeTypeName("#define MM_ICCC_UNA3_AUX 3")]
    public const int MM_ICCC_UNA3_AUX = 3;

    [NativeTypeName("#define MM_ICCC_UNA3_MIXER 4")]
    public const int MM_ICCC_UNA3_MIXER = 4;

    [NativeTypeName("#define MM_3COM_CB_MIXER 1")]
    public const int MM_3COM_CB_MIXER = 1;

    [NativeTypeName("#define MM_3COM_CB_WAVEIN 2")]
    public const int MM_3COM_CB_WAVEIN = 2;

    [NativeTypeName("#define MM_3COM_CB_WAVEOUT 3")]
    public const int MM_3COM_CB_WAVEOUT = 3;

    [NativeTypeName("#define MM_MINDMAKER_GC_WAVEIN 1")]
    public const int MM_MINDMAKER_GC_WAVEIN = 1;

    [NativeTypeName("#define MM_MINDMAKER_GC_WAVEOUT 2")]
    public const int MM_MINDMAKER_GC_WAVEOUT = 2;

    [NativeTypeName("#define MM_MINDMAKER_GC_MIXER 3")]
    public const int MM_MINDMAKER_GC_MIXER = 3;

    [NativeTypeName("#define MM_TELEKOL_WAVEOUT 1")]
    public const int MM_TELEKOL_WAVEOUT = 1;

    [NativeTypeName("#define MM_TELEKOL_WAVEIN 2")]
    public const int MM_TELEKOL_WAVEIN = 2;

    [NativeTypeName("#define MM_ALGOVISION_VB80WAVEOUT 1")]
    public const int MM_ALGOVISION_VB80WAVEOUT = 1;

    [NativeTypeName("#define MM_ALGOVISION_VB80WAVEIN 2")]
    public const int MM_ALGOVISION_VB80WAVEIN = 2;

    [NativeTypeName("#define MM_ALGOVISION_VB80MIXER 3")]
    public const int MM_ALGOVISION_VB80MIXER = 3;

    [NativeTypeName("#define MM_ALGOVISION_VB80AUX 4")]
    public const int MM_ALGOVISION_VB80AUX = 4;

    [NativeTypeName("#define MM_ALGOVISION_VB80AUX2 5")]
    public const int MM_ALGOVISION_VB80AUX2 = 5;

    [NativeTypeName("#define MM_MSFT_ACM_WMAUDIO 39")]
    public const int MM_MSFT_ACM_WMAUDIO = 39;

    [NativeTypeName("#define MM_MSFT_ACM_MSAUDIO1 39")]
    public const int MM_MSFT_ACM_MSAUDIO1 = 39;

    [NativeTypeName("#define MM_MSFT_ACM_WMAUDIO2 101")]
    public const int MM_MSFT_ACM_WMAUDIO2 = 101;
}
