// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IF
{
    [NativeTypeName("#define IF_TYPE_OTHER 1")]
    public const int IF_TYPE_OTHER = 1;

    [NativeTypeName("#define IF_TYPE_REGULAR_1822 2")]
    public const int IF_TYPE_REGULAR_1822 = 2;

    [NativeTypeName("#define IF_TYPE_HDH_1822 3")]
    public const int IF_TYPE_HDH_1822 = 3;

    [NativeTypeName("#define IF_TYPE_DDN_X25 4")]
    public const int IF_TYPE_DDN_X25 = 4;

    [NativeTypeName("#define IF_TYPE_RFC877_X25 5")]
    public const int IF_TYPE_RFC877_X25 = 5;

    [NativeTypeName("#define IF_TYPE_ETHERNET_CSMACD 6")]
    public const int IF_TYPE_ETHERNET_CSMACD = 6;

    [NativeTypeName("#define IF_TYPE_IS088023_CSMACD 7")]
    public const int IF_TYPE_IS088023_CSMACD = 7;

    [NativeTypeName("#define IF_TYPE_ISO88024_TOKENBUS 8")]
    public const int IF_TYPE_ISO88024_TOKENBUS = 8;

    [NativeTypeName("#define IF_TYPE_ISO88025_TOKENRING 9")]
    public const int IF_TYPE_ISO88025_TOKENRING = 9;

    [NativeTypeName("#define IF_TYPE_ISO88026_MAN 10")]
    public const int IF_TYPE_ISO88026_MAN = 10;

    [NativeTypeName("#define IF_TYPE_STARLAN 11")]
    public const int IF_TYPE_STARLAN = 11;

    [NativeTypeName("#define IF_TYPE_PROTEON_10MBIT 12")]
    public const int IF_TYPE_PROTEON_10MBIT = 12;

    [NativeTypeName("#define IF_TYPE_PROTEON_80MBIT 13")]
    public const int IF_TYPE_PROTEON_80MBIT = 13;

    [NativeTypeName("#define IF_TYPE_HYPERCHANNEL 14")]
    public const int IF_TYPE_HYPERCHANNEL = 14;

    [NativeTypeName("#define IF_TYPE_FDDI 15")]
    public const int IF_TYPE_FDDI = 15;

    [NativeTypeName("#define IF_TYPE_LAP_B 16")]
    public const int IF_TYPE_LAP_B = 16;

    [NativeTypeName("#define IF_TYPE_SDLC 17")]
    public const int IF_TYPE_SDLC = 17;

    [NativeTypeName("#define IF_TYPE_DS1 18")]
    public const int IF_TYPE_DS1 = 18;

    [NativeTypeName("#define IF_TYPE_E1 19")]
    public const int IF_TYPE_E1 = 19;

    [NativeTypeName("#define IF_TYPE_BASIC_ISDN 20")]
    public const int IF_TYPE_BASIC_ISDN = 20;

    [NativeTypeName("#define IF_TYPE_PRIMARY_ISDN 21")]
    public const int IF_TYPE_PRIMARY_ISDN = 21;

    [NativeTypeName("#define IF_TYPE_PROP_POINT2POINT_SERIAL 22")]
    public const int IF_TYPE_PROP_POINT2POINT_SERIAL = 22;

    [NativeTypeName("#define IF_TYPE_PPP 23")]
    public const int IF_TYPE_PPP = 23;

    [NativeTypeName("#define IF_TYPE_SOFTWARE_LOOPBACK 24")]
    public const int IF_TYPE_SOFTWARE_LOOPBACK = 24;

    [NativeTypeName("#define IF_TYPE_EON 25")]
    public const int IF_TYPE_EON = 25;

    [NativeTypeName("#define IF_TYPE_ETHERNET_3MBIT 26")]
    public const int IF_TYPE_ETHERNET_3MBIT = 26;

    [NativeTypeName("#define IF_TYPE_NSIP 27")]
    public const int IF_TYPE_NSIP = 27;

    [NativeTypeName("#define IF_TYPE_SLIP 28")]
    public const int IF_TYPE_SLIP = 28;

    [NativeTypeName("#define IF_TYPE_ULTRA 29")]
    public const int IF_TYPE_ULTRA = 29;

    [NativeTypeName("#define IF_TYPE_DS3 30")]
    public const int IF_TYPE_DS3 = 30;

    [NativeTypeName("#define IF_TYPE_SIP 31")]
    public const int IF_TYPE_SIP = 31;

    [NativeTypeName("#define IF_TYPE_FRAMERELAY 32")]
    public const int IF_TYPE_FRAMERELAY = 32;

    [NativeTypeName("#define IF_TYPE_RS232 33")]
    public const int IF_TYPE_RS232 = 33;

    [NativeTypeName("#define IF_TYPE_PARA 34")]
    public const int IF_TYPE_PARA = 34;

    [NativeTypeName("#define IF_TYPE_ARCNET 35")]
    public const int IF_TYPE_ARCNET = 35;

    [NativeTypeName("#define IF_TYPE_ARCNET_PLUS 36")]
    public const int IF_TYPE_ARCNET_PLUS = 36;

    [NativeTypeName("#define IF_TYPE_ATM 37")]
    public const int IF_TYPE_ATM = 37;

    [NativeTypeName("#define IF_TYPE_MIO_X25 38")]
    public const int IF_TYPE_MIO_X25 = 38;

    [NativeTypeName("#define IF_TYPE_SONET 39")]
    public const int IF_TYPE_SONET = 39;

    [NativeTypeName("#define IF_TYPE_X25_PLE 40")]
    public const int IF_TYPE_X25_PLE = 40;

    [NativeTypeName("#define IF_TYPE_ISO88022_LLC 41")]
    public const int IF_TYPE_ISO88022_LLC = 41;

    [NativeTypeName("#define IF_TYPE_LOCALTALK 42")]
    public const int IF_TYPE_LOCALTALK = 42;

    [NativeTypeName("#define IF_TYPE_SMDS_DXI 43")]
    public const int IF_TYPE_SMDS_DXI = 43;

    [NativeTypeName("#define IF_TYPE_FRAMERELAY_SERVICE 44")]
    public const int IF_TYPE_FRAMERELAY_SERVICE = 44;

    [NativeTypeName("#define IF_TYPE_V35 45")]
    public const int IF_TYPE_V35 = 45;

    [NativeTypeName("#define IF_TYPE_HSSI 46")]
    public const int IF_TYPE_HSSI = 46;

    [NativeTypeName("#define IF_TYPE_HIPPI 47")]
    public const int IF_TYPE_HIPPI = 47;

    [NativeTypeName("#define IF_TYPE_MODEM 48")]
    public const int IF_TYPE_MODEM = 48;

    [NativeTypeName("#define IF_TYPE_AAL5 49")]
    public const int IF_TYPE_AAL5 = 49;

    [NativeTypeName("#define IF_TYPE_SONET_PATH 50")]
    public const int IF_TYPE_SONET_PATH = 50;

    [NativeTypeName("#define IF_TYPE_SONET_VT 51")]
    public const int IF_TYPE_SONET_VT = 51;

    [NativeTypeName("#define IF_TYPE_SMDS_ICIP 52")]
    public const int IF_TYPE_SMDS_ICIP = 52;

    [NativeTypeName("#define IF_TYPE_PROP_VIRTUAL 53")]
    public const int IF_TYPE_PROP_VIRTUAL = 53;

    [NativeTypeName("#define IF_TYPE_PROP_MULTIPLEXOR 54")]
    public const int IF_TYPE_PROP_MULTIPLEXOR = 54;

    [NativeTypeName("#define IF_TYPE_IEEE80212 55")]
    public const int IF_TYPE_IEEE80212 = 55;

    [NativeTypeName("#define IF_TYPE_FIBRECHANNEL 56")]
    public const int IF_TYPE_FIBRECHANNEL = 56;

    [NativeTypeName("#define IF_TYPE_HIPPIINTERFACE 57")]
    public const int IF_TYPE_HIPPIINTERFACE = 57;

    [NativeTypeName("#define IF_TYPE_FRAMERELAY_INTERCONNECT 58")]
    public const int IF_TYPE_FRAMERELAY_INTERCONNECT = 58;

    [NativeTypeName("#define IF_TYPE_AFLANE_8023 59")]
    public const int IF_TYPE_AFLANE_8023 = 59;

    [NativeTypeName("#define IF_TYPE_AFLANE_8025 60")]
    public const int IF_TYPE_AFLANE_8025 = 60;

    [NativeTypeName("#define IF_TYPE_CCTEMUL 61")]
    public const int IF_TYPE_CCTEMUL = 61;

    [NativeTypeName("#define IF_TYPE_FASTETHER 62")]
    public const int IF_TYPE_FASTETHER = 62;

    [NativeTypeName("#define IF_TYPE_ISDN 63")]
    public const int IF_TYPE_ISDN = 63;

    [NativeTypeName("#define IF_TYPE_V11 64")]
    public const int IF_TYPE_V11 = 64;

    [NativeTypeName("#define IF_TYPE_V36 65")]
    public const int IF_TYPE_V36 = 65;

    [NativeTypeName("#define IF_TYPE_G703_64K 66")]
    public const int IF_TYPE_G703_64K = 66;

    [NativeTypeName("#define IF_TYPE_G703_2MB 67")]
    public const int IF_TYPE_G703_2MB = 67;

    [NativeTypeName("#define IF_TYPE_QLLC 68")]
    public const int IF_TYPE_QLLC = 68;

    [NativeTypeName("#define IF_TYPE_FASTETHER_FX 69")]
    public const int IF_TYPE_FASTETHER_FX = 69;

    [NativeTypeName("#define IF_TYPE_CHANNEL 70")]
    public const int IF_TYPE_CHANNEL = 70;

    [NativeTypeName("#define IF_TYPE_IEEE80211 71")]
    public const int IF_TYPE_IEEE80211 = 71;

    [NativeTypeName("#define IF_TYPE_IBM370PARCHAN 72")]
    public const int IF_TYPE_IBM370PARCHAN = 72;

    [NativeTypeName("#define IF_TYPE_ESCON 73")]
    public const int IF_TYPE_ESCON = 73;

    [NativeTypeName("#define IF_TYPE_DLSW 74")]
    public const int IF_TYPE_DLSW = 74;

    [NativeTypeName("#define IF_TYPE_ISDN_S 75")]
    public const int IF_TYPE_ISDN_S = 75;

    [NativeTypeName("#define IF_TYPE_ISDN_U 76")]
    public const int IF_TYPE_ISDN_U = 76;

    [NativeTypeName("#define IF_TYPE_LAP_D 77")]
    public const int IF_TYPE_LAP_D = 77;

    [NativeTypeName("#define IF_TYPE_IPSWITCH 78")]
    public const int IF_TYPE_IPSWITCH = 78;

    [NativeTypeName("#define IF_TYPE_RSRB 79")]
    public const int IF_TYPE_RSRB = 79;

    [NativeTypeName("#define IF_TYPE_ATM_LOGICAL 80")]
    public const int IF_TYPE_ATM_LOGICAL = 80;

    [NativeTypeName("#define IF_TYPE_DS0 81")]
    public const int IF_TYPE_DS0 = 81;

    [NativeTypeName("#define IF_TYPE_DS0_BUNDLE 82")]
    public const int IF_TYPE_DS0_BUNDLE = 82;

    [NativeTypeName("#define IF_TYPE_BSC 83")]
    public const int IF_TYPE_BSC = 83;

    [NativeTypeName("#define IF_TYPE_ASYNC 84")]
    public const int IF_TYPE_ASYNC = 84;

    [NativeTypeName("#define IF_TYPE_CNR 85")]
    public const int IF_TYPE_CNR = 85;

    [NativeTypeName("#define IF_TYPE_ISO88025R_DTR 86")]
    public const int IF_TYPE_ISO88025R_DTR = 86;

    [NativeTypeName("#define IF_TYPE_EPLRS 87")]
    public const int IF_TYPE_EPLRS = 87;

    [NativeTypeName("#define IF_TYPE_ARAP 88")]
    public const int IF_TYPE_ARAP = 88;

    [NativeTypeName("#define IF_TYPE_PROP_CNLS 89")]
    public const int IF_TYPE_PROP_CNLS = 89;

    [NativeTypeName("#define IF_TYPE_HOSTPAD 90")]
    public const int IF_TYPE_HOSTPAD = 90;

    [NativeTypeName("#define IF_TYPE_TERMPAD 91")]
    public const int IF_TYPE_TERMPAD = 91;

    [NativeTypeName("#define IF_TYPE_FRAMERELAY_MPI 92")]
    public const int IF_TYPE_FRAMERELAY_MPI = 92;

    [NativeTypeName("#define IF_TYPE_X213 93")]
    public const int IF_TYPE_X213 = 93;

    [NativeTypeName("#define IF_TYPE_ADSL 94")]
    public const int IF_TYPE_ADSL = 94;

    [NativeTypeName("#define IF_TYPE_RADSL 95")]
    public const int IF_TYPE_RADSL = 95;

    [NativeTypeName("#define IF_TYPE_SDSL 96")]
    public const int IF_TYPE_SDSL = 96;

    [NativeTypeName("#define IF_TYPE_VDSL 97")]
    public const int IF_TYPE_VDSL = 97;

    [NativeTypeName("#define IF_TYPE_ISO88025_CRFPRINT 98")]
    public const int IF_TYPE_ISO88025_CRFPRINT = 98;

    [NativeTypeName("#define IF_TYPE_MYRINET 99")]
    public const int IF_TYPE_MYRINET = 99;

    [NativeTypeName("#define IF_TYPE_VOICE_EM 100")]
    public const int IF_TYPE_VOICE_EM = 100;

    [NativeTypeName("#define IF_TYPE_VOICE_FXO 101")]
    public const int IF_TYPE_VOICE_FXO = 101;

    [NativeTypeName("#define IF_TYPE_VOICE_FXS 102")]
    public const int IF_TYPE_VOICE_FXS = 102;

    [NativeTypeName("#define IF_TYPE_VOICE_ENCAP 103")]
    public const int IF_TYPE_VOICE_ENCAP = 103;

    [NativeTypeName("#define IF_TYPE_VOICE_OVERIP 104")]
    public const int IF_TYPE_VOICE_OVERIP = 104;

    [NativeTypeName("#define IF_TYPE_ATM_DXI 105")]
    public const int IF_TYPE_ATM_DXI = 105;

    [NativeTypeName("#define IF_TYPE_ATM_FUNI 106")]
    public const int IF_TYPE_ATM_FUNI = 106;

    [NativeTypeName("#define IF_TYPE_ATM_IMA 107")]
    public const int IF_TYPE_ATM_IMA = 107;

    [NativeTypeName("#define IF_TYPE_PPPMULTILINKBUNDLE 108")]
    public const int IF_TYPE_PPPMULTILINKBUNDLE = 108;

    [NativeTypeName("#define IF_TYPE_IPOVER_CDLC 109")]
    public const int IF_TYPE_IPOVER_CDLC = 109;

    [NativeTypeName("#define IF_TYPE_IPOVER_CLAW 110")]
    public const int IF_TYPE_IPOVER_CLAW = 110;

    [NativeTypeName("#define IF_TYPE_STACKTOSTACK 111")]
    public const int IF_TYPE_STACKTOSTACK = 111;

    [NativeTypeName("#define IF_TYPE_VIRTUALIPADDRESS 112")]
    public const int IF_TYPE_VIRTUALIPADDRESS = 112;

    [NativeTypeName("#define IF_TYPE_MPC 113")]
    public const int IF_TYPE_MPC = 113;

    [NativeTypeName("#define IF_TYPE_IPOVER_ATM 114")]
    public const int IF_TYPE_IPOVER_ATM = 114;

    [NativeTypeName("#define IF_TYPE_ISO88025_FIBER 115")]
    public const int IF_TYPE_ISO88025_FIBER = 115;

    [NativeTypeName("#define IF_TYPE_TDLC 116")]
    public const int IF_TYPE_TDLC = 116;

    [NativeTypeName("#define IF_TYPE_GIGABITETHERNET 117")]
    public const int IF_TYPE_GIGABITETHERNET = 117;

    [NativeTypeName("#define IF_TYPE_HDLC 118")]
    public const int IF_TYPE_HDLC = 118;

    [NativeTypeName("#define IF_TYPE_LAP_F 119")]
    public const int IF_TYPE_LAP_F = 119;

    [NativeTypeName("#define IF_TYPE_V37 120")]
    public const int IF_TYPE_V37 = 120;

    [NativeTypeName("#define IF_TYPE_X25_MLP 121")]
    public const int IF_TYPE_X25_MLP = 121;

    [NativeTypeName("#define IF_TYPE_X25_HUNTGROUP 122")]
    public const int IF_TYPE_X25_HUNTGROUP = 122;

    [NativeTypeName("#define IF_TYPE_TRANSPHDLC 123")]
    public const int IF_TYPE_TRANSPHDLC = 123;

    [NativeTypeName("#define IF_TYPE_INTERLEAVE 124")]
    public const int IF_TYPE_INTERLEAVE = 124;

    [NativeTypeName("#define IF_TYPE_FAST 125")]
    public const int IF_TYPE_FAST = 125;

    [NativeTypeName("#define IF_TYPE_IP 126")]
    public const int IF_TYPE_IP = 126;

    [NativeTypeName("#define IF_TYPE_DOCSCABLE_MACLAYER 127")]
    public const int IF_TYPE_DOCSCABLE_MACLAYER = 127;

    [NativeTypeName("#define IF_TYPE_DOCSCABLE_DOWNSTREAM 128")]
    public const int IF_TYPE_DOCSCABLE_DOWNSTREAM = 128;

    [NativeTypeName("#define IF_TYPE_DOCSCABLE_UPSTREAM 129")]
    public const int IF_TYPE_DOCSCABLE_UPSTREAM = 129;

    [NativeTypeName("#define IF_TYPE_A12MPPSWITCH 130")]
    public const int IF_TYPE_A12MPPSWITCH = 130;

    [NativeTypeName("#define IF_TYPE_TUNNEL 131")]
    public const int IF_TYPE_TUNNEL = 131;

    [NativeTypeName("#define IF_TYPE_COFFEE 132")]
    public const int IF_TYPE_COFFEE = 132;

    [NativeTypeName("#define IF_TYPE_CES 133")]
    public const int IF_TYPE_CES = 133;

    [NativeTypeName("#define IF_TYPE_ATM_SUBINTERFACE 134")]
    public const int IF_TYPE_ATM_SUBINTERFACE = 134;

    [NativeTypeName("#define IF_TYPE_L2_VLAN 135")]
    public const int IF_TYPE_L2_VLAN = 135;

    [NativeTypeName("#define IF_TYPE_L3_IPVLAN 136")]
    public const int IF_TYPE_L3_IPVLAN = 136;

    [NativeTypeName("#define IF_TYPE_L3_IPXVLAN 137")]
    public const int IF_TYPE_L3_IPXVLAN = 137;

    [NativeTypeName("#define IF_TYPE_DIGITALPOWERLINE 138")]
    public const int IF_TYPE_DIGITALPOWERLINE = 138;

    [NativeTypeName("#define IF_TYPE_MEDIAMAILOVERIP 139")]
    public const int IF_TYPE_MEDIAMAILOVERIP = 139;

    [NativeTypeName("#define IF_TYPE_DTM 140")]
    public const int IF_TYPE_DTM = 140;

    [NativeTypeName("#define IF_TYPE_DCN 141")]
    public const int IF_TYPE_DCN = 141;

    [NativeTypeName("#define IF_TYPE_IPFORWARD 142")]
    public const int IF_TYPE_IPFORWARD = 142;

    [NativeTypeName("#define IF_TYPE_MSDSL 143")]
    public const int IF_TYPE_MSDSL = 143;

    [NativeTypeName("#define IF_TYPE_IEEE1394 144")]
    public const int IF_TYPE_IEEE1394 = 144;

    [NativeTypeName("#define IF_TYPE_IF_GSN 145")]
    public const int IF_TYPE_IF_GSN = 145;

    [NativeTypeName("#define IF_TYPE_DVBRCC_MACLAYER 146")]
    public const int IF_TYPE_DVBRCC_MACLAYER = 146;

    [NativeTypeName("#define IF_TYPE_DVBRCC_DOWNSTREAM 147")]
    public const int IF_TYPE_DVBRCC_DOWNSTREAM = 147;

    [NativeTypeName("#define IF_TYPE_DVBRCC_UPSTREAM 148")]
    public const int IF_TYPE_DVBRCC_UPSTREAM = 148;

    [NativeTypeName("#define IF_TYPE_ATM_VIRTUAL 149")]
    public const int IF_TYPE_ATM_VIRTUAL = 149;

    [NativeTypeName("#define IF_TYPE_MPLS_TUNNEL 150")]
    public const int IF_TYPE_MPLS_TUNNEL = 150;

    [NativeTypeName("#define IF_TYPE_SRP 151")]
    public const int IF_TYPE_SRP = 151;

    [NativeTypeName("#define IF_TYPE_VOICEOVERATM 152")]
    public const int IF_TYPE_VOICEOVERATM = 152;

    [NativeTypeName("#define IF_TYPE_VOICEOVERFRAMERELAY 153")]
    public const int IF_TYPE_VOICEOVERFRAMERELAY = 153;

    [NativeTypeName("#define IF_TYPE_IDSL 154")]
    public const int IF_TYPE_IDSL = 154;

    [NativeTypeName("#define IF_TYPE_COMPOSITELINK 155")]
    public const int IF_TYPE_COMPOSITELINK = 155;

    [NativeTypeName("#define IF_TYPE_SS7_SIGLINK 156")]
    public const int IF_TYPE_SS7_SIGLINK = 156;

    [NativeTypeName("#define IF_TYPE_PROP_WIRELESS_P2P 157")]
    public const int IF_TYPE_PROP_WIRELESS_P2P = 157;

    [NativeTypeName("#define IF_TYPE_FR_FORWARD 158")]
    public const int IF_TYPE_FR_FORWARD = 158;

    [NativeTypeName("#define IF_TYPE_RFC1483 159")]
    public const int IF_TYPE_RFC1483 = 159;

    [NativeTypeName("#define IF_TYPE_USB 160")]
    public const int IF_TYPE_USB = 160;

    [NativeTypeName("#define IF_TYPE_IEEE8023AD_LAG 161")]
    public const int IF_TYPE_IEEE8023AD_LAG = 161;

    [NativeTypeName("#define IF_TYPE_BGP_POLICY_ACCOUNTING 162")]
    public const int IF_TYPE_BGP_POLICY_ACCOUNTING = 162;

    [NativeTypeName("#define IF_TYPE_FRF16_MFR_BUNDLE 163")]
    public const int IF_TYPE_FRF16_MFR_BUNDLE = 163;

    [NativeTypeName("#define IF_TYPE_H323_GATEKEEPER 164")]
    public const int IF_TYPE_H323_GATEKEEPER = 164;

    [NativeTypeName("#define IF_TYPE_H323_PROXY 165")]
    public const int IF_TYPE_H323_PROXY = 165;

    [NativeTypeName("#define IF_TYPE_MPLS 166")]
    public const int IF_TYPE_MPLS = 166;

    [NativeTypeName("#define IF_TYPE_MF_SIGLINK 167")]
    public const int IF_TYPE_MF_SIGLINK = 167;

    [NativeTypeName("#define IF_TYPE_HDSL2 168")]
    public const int IF_TYPE_HDSL2 = 168;

    [NativeTypeName("#define IF_TYPE_SHDSL 169")]
    public const int IF_TYPE_SHDSL = 169;

    [NativeTypeName("#define IF_TYPE_DS1_FDL 170")]
    public const int IF_TYPE_DS1_FDL = 170;

    [NativeTypeName("#define IF_TYPE_POS 171")]
    public const int IF_TYPE_POS = 171;

    [NativeTypeName("#define IF_TYPE_DVB_ASI_IN 172")]
    public const int IF_TYPE_DVB_ASI_IN = 172;

    [NativeTypeName("#define IF_TYPE_DVB_ASI_OUT 173")]
    public const int IF_TYPE_DVB_ASI_OUT = 173;

    [NativeTypeName("#define IF_TYPE_PLC 174")]
    public const int IF_TYPE_PLC = 174;

    [NativeTypeName("#define IF_TYPE_NFAS 175")]
    public const int IF_TYPE_NFAS = 175;

    [NativeTypeName("#define IF_TYPE_TR008 176")]
    public const int IF_TYPE_TR008 = 176;

    [NativeTypeName("#define IF_TYPE_GR303_RDT 177")]
    public const int IF_TYPE_GR303_RDT = 177;

    [NativeTypeName("#define IF_TYPE_GR303_IDT 178")]
    public const int IF_TYPE_GR303_IDT = 178;

    [NativeTypeName("#define IF_TYPE_ISUP 179")]
    public const int IF_TYPE_ISUP = 179;

    [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER 180")]
    public const int IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER = 180;

    [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM 181")]
    public const int IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM = 181;

    [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM 182")]
    public const int IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM = 182;

    [NativeTypeName("#define IF_TYPE_HIPERLAN2 183")]
    public const int IF_TYPE_HIPERLAN2 = 183;

    [NativeTypeName("#define IF_TYPE_PROP_BWA_P2MP 184")]
    public const int IF_TYPE_PROP_BWA_P2MP = 184;

    [NativeTypeName("#define IF_TYPE_SONET_OVERHEAD_CHANNEL 185")]
    public const int IF_TYPE_SONET_OVERHEAD_CHANNEL = 185;

    [NativeTypeName("#define IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL 186")]
    public const int IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL = 186;

    [NativeTypeName("#define IF_TYPE_AAL2 187")]
    public const int IF_TYPE_AAL2 = 187;

    [NativeTypeName("#define IF_TYPE_RADIO_MAC 188")]
    public const int IF_TYPE_RADIO_MAC = 188;

    [NativeTypeName("#define IF_TYPE_ATM_RADIO 189")]
    public const int IF_TYPE_ATM_RADIO = 189;

    [NativeTypeName("#define IF_TYPE_IMT 190")]
    public const int IF_TYPE_IMT = 190;

    [NativeTypeName("#define IF_TYPE_MVL 191")]
    public const int IF_TYPE_MVL = 191;

    [NativeTypeName("#define IF_TYPE_REACH_DSL 192")]
    public const int IF_TYPE_REACH_DSL = 192;

    [NativeTypeName("#define IF_TYPE_FR_DLCI_ENDPT 193")]
    public const int IF_TYPE_FR_DLCI_ENDPT = 193;

    [NativeTypeName("#define IF_TYPE_ATM_VCI_ENDPT 194")]
    public const int IF_TYPE_ATM_VCI_ENDPT = 194;

    [NativeTypeName("#define IF_TYPE_OPTICAL_CHANNEL 195")]
    public const int IF_TYPE_OPTICAL_CHANNEL = 195;

    [NativeTypeName("#define IF_TYPE_OPTICAL_TRANSPORT 196")]
    public const int IF_TYPE_OPTICAL_TRANSPORT = 196;

    [NativeTypeName("#define IF_TYPE_IEEE80216_WMAN 237")]
    public const int IF_TYPE_IEEE80216_WMAN = 237;

    [NativeTypeName("#define IF_TYPE_WWANPP 243")]
    public const int IF_TYPE_WWANPP = 243;

    [NativeTypeName("#define IF_TYPE_WWANPP2 244")]
    public const int IF_TYPE_WWANPP2 = 244;

    [NativeTypeName("#define IF_TYPE_IEEE802154 259")]
    public const int IF_TYPE_IEEE802154 = 259;

    [NativeTypeName("#define IF_TYPE_XBOX_WIRELESS 281")]
    public const int IF_TYPE_XBOX_WIRELESS = 281;

    [NativeTypeName("#define IF_CHECK_NONE 0x00")]
    public const int IF_CHECK_NONE = 0x00;

    [NativeTypeName("#define IF_CHECK_MCAST 0x01")]
    public const int IF_CHECK_MCAST = 0x01;

    [NativeTypeName("#define IF_CHECK_SEND 0x02")]
    public const int IF_CHECK_SEND = 0x02;

    [NativeTypeName("#define IF_CONNECTION_DEDICATED 1")]
    public const int IF_CONNECTION_DEDICATED = 1;

    [NativeTypeName("#define IF_CONNECTION_PASSIVE 2")]
    public const int IF_CONNECTION_PASSIVE = 2;

    [NativeTypeName("#define IF_CONNECTION_DEMAND 3")]
    public const int IF_CONNECTION_DEMAND = 3;

    [NativeTypeName("#define IF_ADMIN_STATUS_UP 1")]
    public const int IF_ADMIN_STATUS_UP = 1;

    [NativeTypeName("#define IF_ADMIN_STATUS_DOWN 2")]
    public const int IF_ADMIN_STATUS_DOWN = 2;

    [NativeTypeName("#define IF_ADMIN_STATUS_TESTING 3")]
    public const int IF_ADMIN_STATUS_TESTING = 3;
}
