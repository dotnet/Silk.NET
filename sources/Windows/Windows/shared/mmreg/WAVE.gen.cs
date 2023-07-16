// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class WAVE
{
    [NativeTypeName("#define WAVE_FORMAT_UNKNOWN 0x0000")]
    public const int WAVE_FORMAT_UNKNOWN = 0x0000;
    [NativeTypeName("#define WAVE_FORMAT_ADPCM 0x0002")]
    public const int WAVE_FORMAT_ADPCM = 0x0002;
    [NativeTypeName("#define WAVE_FORMAT_IEEE_FLOAT 0x0003")]
    public const int WAVE_FORMAT_IEEE_FLOAT = 0x0003;
    [NativeTypeName("#define WAVE_FORMAT_VSELP 0x0004")]
    public const int WAVE_FORMAT_VSELP = 0x0004;
    [NativeTypeName("#define WAVE_FORMAT_IBM_CVSD 0x0005")]
    public const int WAVE_FORMAT_IBM_CVSD = 0x0005;
    [NativeTypeName("#define WAVE_FORMAT_ALAW 0x0006")]
    public const int WAVE_FORMAT_ALAW = 0x0006;
    [NativeTypeName("#define WAVE_FORMAT_MULAW 0x0007")]
    public const int WAVE_FORMAT_MULAW = 0x0007;
    [NativeTypeName("#define WAVE_FORMAT_DTS 0x0008")]
    public const int WAVE_FORMAT_DTS = 0x0008;
    [NativeTypeName("#define WAVE_FORMAT_DRM 0x0009")]
    public const int WAVE_FORMAT_DRM = 0x0009;
    [NativeTypeName("#define WAVE_FORMAT_WMAVOICE9 0x000A")]
    public const int WAVE_FORMAT_WMAVOICE9 = 0x000A;
    [NativeTypeName("#define WAVE_FORMAT_WMAVOICE10 0x000B")]
    public const int WAVE_FORMAT_WMAVOICE10 = 0x000B;
    [NativeTypeName("#define WAVE_FORMAT_OKI_ADPCM 0x0010")]
    public const int WAVE_FORMAT_OKI_ADPCM = 0x0010;
    [NativeTypeName("#define WAVE_FORMAT_DVI_ADPCM 0x0011")]
    public const int WAVE_FORMAT_DVI_ADPCM = 0x0011;
    [NativeTypeName("#define WAVE_FORMAT_IMA_ADPCM (WAVE_FORMAT_DVI_ADPCM)")]
    public const int WAVE_FORMAT_IMA_ADPCM = (0x0011);
    [NativeTypeName("#define WAVE_FORMAT_MEDIASPACE_ADPCM 0x0012")]
    public const int WAVE_FORMAT_MEDIASPACE_ADPCM = 0x0012;
    [NativeTypeName("#define WAVE_FORMAT_SIERRA_ADPCM 0x0013")]
    public const int WAVE_FORMAT_SIERRA_ADPCM = 0x0013;
    [NativeTypeName("#define WAVE_FORMAT_G723_ADPCM 0x0014")]
    public const int WAVE_FORMAT_G723_ADPCM = 0x0014;
    [NativeTypeName("#define WAVE_FORMAT_DIGISTD 0x0015")]
    public const int WAVE_FORMAT_DIGISTD = 0x0015;
    [NativeTypeName("#define WAVE_FORMAT_DIGIFIX 0x0016")]
    public const int WAVE_FORMAT_DIGIFIX = 0x0016;
    [NativeTypeName("#define WAVE_FORMAT_DIALOGIC_OKI_ADPCM 0x0017")]
    public const int WAVE_FORMAT_DIALOGIC_OKI_ADPCM = 0x0017;
    [NativeTypeName("#define WAVE_FORMAT_MEDIAVISION_ADPCM 0x0018")]
    public const int WAVE_FORMAT_MEDIAVISION_ADPCM = 0x0018;
    [NativeTypeName("#define WAVE_FORMAT_CU_CODEC 0x0019")]
    public const int WAVE_FORMAT_CU_CODEC = 0x0019;
    [NativeTypeName("#define WAVE_FORMAT_HP_DYN_VOICE 0x001A")]
    public const int WAVE_FORMAT_HP_DYN_VOICE = 0x001A;
    [NativeTypeName("#define WAVE_FORMAT_YAMAHA_ADPCM 0x0020")]
    public const int WAVE_FORMAT_YAMAHA_ADPCM = 0x0020;
    [NativeTypeName("#define WAVE_FORMAT_SONARC 0x0021")]
    public const int WAVE_FORMAT_SONARC = 0x0021;
    [NativeTypeName("#define WAVE_FORMAT_DSPGROUP_TRUESPEECH 0x0022")]
    public const int WAVE_FORMAT_DSPGROUP_TRUESPEECH = 0x0022;
    [NativeTypeName("#define WAVE_FORMAT_ECHOSC1 0x0023")]
    public const int WAVE_FORMAT_ECHOSC1 = 0x0023;
    [NativeTypeName("#define WAVE_FORMAT_AUDIOFILE_AF36 0x0024")]
    public const int WAVE_FORMAT_AUDIOFILE_AF36 = 0x0024;
    [NativeTypeName("#define WAVE_FORMAT_APTX 0x0025")]
    public const int WAVE_FORMAT_APTX = 0x0025;
    [NativeTypeName("#define WAVE_FORMAT_AUDIOFILE_AF10 0x0026")]
    public const int WAVE_FORMAT_AUDIOFILE_AF10 = 0x0026;
    [NativeTypeName("#define WAVE_FORMAT_PROSODY_1612 0x0027")]
    public const int WAVE_FORMAT_PROSODY_1612 = 0x0027;
    [NativeTypeName("#define WAVE_FORMAT_LRC 0x0028")]
    public const int WAVE_FORMAT_LRC = 0x0028;
    [NativeTypeName("#define WAVE_FORMAT_DOLBY_AC2 0x0030")]
    public const int WAVE_FORMAT_DOLBY_AC2 = 0x0030;
    [NativeTypeName("#define WAVE_FORMAT_GSM610 0x0031")]
    public const int WAVE_FORMAT_GSM610 = 0x0031;
    [NativeTypeName("#define WAVE_FORMAT_MSNAUDIO 0x0032")]
    public const int WAVE_FORMAT_MSNAUDIO = 0x0032;
    [NativeTypeName("#define WAVE_FORMAT_ANTEX_ADPCME 0x0033")]
    public const int WAVE_FORMAT_ANTEX_ADPCME = 0x0033;
    [NativeTypeName("#define WAVE_FORMAT_CONTROL_RES_VQLPC 0x0034")]
    public const int WAVE_FORMAT_CONTROL_RES_VQLPC = 0x0034;
    [NativeTypeName("#define WAVE_FORMAT_DIGIREAL 0x0035")]
    public const int WAVE_FORMAT_DIGIREAL = 0x0035;
    [NativeTypeName("#define WAVE_FORMAT_DIGIADPCM 0x0036")]
    public const int WAVE_FORMAT_DIGIADPCM = 0x0036;
    [NativeTypeName("#define WAVE_FORMAT_CONTROL_RES_CR10 0x0037")]
    public const int WAVE_FORMAT_CONTROL_RES_CR10 = 0x0037;
    [NativeTypeName("#define WAVE_FORMAT_NMS_VBXADPCM 0x0038")]
    public const int WAVE_FORMAT_NMS_VBXADPCM = 0x0038;
    [NativeTypeName("#define WAVE_FORMAT_CS_IMAADPCM 0x0039")]
    public const int WAVE_FORMAT_CS_IMAADPCM = 0x0039;
    [NativeTypeName("#define WAVE_FORMAT_ECHOSC3 0x003A")]
    public const int WAVE_FORMAT_ECHOSC3 = 0x003A;
    [NativeTypeName("#define WAVE_FORMAT_ROCKWELL_ADPCM 0x003B")]
    public const int WAVE_FORMAT_ROCKWELL_ADPCM = 0x003B;
    [NativeTypeName("#define WAVE_FORMAT_ROCKWELL_DIGITALK 0x003C")]
    public const int WAVE_FORMAT_ROCKWELL_DIGITALK = 0x003C;
    [NativeTypeName("#define WAVE_FORMAT_XEBEC 0x003D")]
    public const int WAVE_FORMAT_XEBEC = 0x003D;
    [NativeTypeName("#define WAVE_FORMAT_G721_ADPCM 0x0040")]
    public const int WAVE_FORMAT_G721_ADPCM = 0x0040;
    [NativeTypeName("#define WAVE_FORMAT_G728_CELP 0x0041")]
    public const int WAVE_FORMAT_G728_CELP = 0x0041;
    [NativeTypeName("#define WAVE_FORMAT_MSG723 0x0042")]
    public const int WAVE_FORMAT_MSG723 = 0x0042;
    [NativeTypeName("#define WAVE_FORMAT_INTEL_G723_1 0x0043")]
    public const int WAVE_FORMAT_INTEL_G723_1 = 0x0043;
    [NativeTypeName("#define WAVE_FORMAT_INTEL_G729 0x0044")]
    public const int WAVE_FORMAT_INTEL_G729 = 0x0044;
    [NativeTypeName("#define WAVE_FORMAT_SHARP_G726 0x0045")]
    public const int WAVE_FORMAT_SHARP_G726 = 0x0045;
    [NativeTypeName("#define WAVE_FORMAT_MPEG 0x0050")]
    public const int WAVE_FORMAT_MPEG = 0x0050;
    [NativeTypeName("#define WAVE_FORMAT_RT24 0x0052")]
    public const int WAVE_FORMAT_RT24 = 0x0052;
    [NativeTypeName("#define WAVE_FORMAT_PAC 0x0053")]
    public const int WAVE_FORMAT_PAC = 0x0053;
    [NativeTypeName("#define WAVE_FORMAT_MPEGLAYER3 0x0055")]
    public const int WAVE_FORMAT_MPEGLAYER3 = 0x0055;
    [NativeTypeName("#define WAVE_FORMAT_LUCENT_G723 0x0059")]
    public const int WAVE_FORMAT_LUCENT_G723 = 0x0059;
    [NativeTypeName("#define WAVE_FORMAT_CIRRUS 0x0060")]
    public const int WAVE_FORMAT_CIRRUS = 0x0060;
    [NativeTypeName("#define WAVE_FORMAT_ESPCM 0x0061")]
    public const int WAVE_FORMAT_ESPCM = 0x0061;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE 0x0062")]
    public const int WAVE_FORMAT_VOXWARE = 0x0062;
    [NativeTypeName("#define WAVE_FORMAT_CANOPUS_ATRAC 0x0063")]
    public const int WAVE_FORMAT_CANOPUS_ATRAC = 0x0063;
    [NativeTypeName("#define WAVE_FORMAT_G726_ADPCM 0x0064")]
    public const int WAVE_FORMAT_G726_ADPCM = 0x0064;
    [NativeTypeName("#define WAVE_FORMAT_G722_ADPCM 0x0065")]
    public const int WAVE_FORMAT_G722_ADPCM = 0x0065;
    [NativeTypeName("#define WAVE_FORMAT_DSAT 0x0066")]
    public const int WAVE_FORMAT_DSAT = 0x0066;
    [NativeTypeName("#define WAVE_FORMAT_DSAT_DISPLAY 0x0067")]
    public const int WAVE_FORMAT_DSAT_DISPLAY = 0x0067;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_BYTE_ALIGNED 0x0069")]
    public const int WAVE_FORMAT_VOXWARE_BYTE_ALIGNED = 0x0069;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_AC8 0x0070")]
    public const int WAVE_FORMAT_VOXWARE_AC8 = 0x0070;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_AC10 0x0071")]
    public const int WAVE_FORMAT_VOXWARE_AC10 = 0x0071;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_AC16 0x0072")]
    public const int WAVE_FORMAT_VOXWARE_AC16 = 0x0072;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_AC20 0x0073")]
    public const int WAVE_FORMAT_VOXWARE_AC20 = 0x0073;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_RT24 0x0074")]
    public const int WAVE_FORMAT_VOXWARE_RT24 = 0x0074;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_RT29 0x0075")]
    public const int WAVE_FORMAT_VOXWARE_RT29 = 0x0075;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_RT29HW 0x0076")]
    public const int WAVE_FORMAT_VOXWARE_RT29HW = 0x0076;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_VR12 0x0077")]
    public const int WAVE_FORMAT_VOXWARE_VR12 = 0x0077;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_VR18 0x0078")]
    public const int WAVE_FORMAT_VOXWARE_VR18 = 0x0078;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_TQ40 0x0079")]
    public const int WAVE_FORMAT_VOXWARE_TQ40 = 0x0079;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_SC3 0x007A")]
    public const int WAVE_FORMAT_VOXWARE_SC3 = 0x007A;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_SC3_1 0x007B")]
    public const int WAVE_FORMAT_VOXWARE_SC3_1 = 0x007B;
    [NativeTypeName("#define WAVE_FORMAT_SOFTSOUND 0x0080")]
    public const int WAVE_FORMAT_SOFTSOUND = 0x0080;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_TQ60 0x0081")]
    public const int WAVE_FORMAT_VOXWARE_TQ60 = 0x0081;
    [NativeTypeName("#define WAVE_FORMAT_MSRT24 0x0082")]
    public const int WAVE_FORMAT_MSRT24 = 0x0082;
    [NativeTypeName("#define WAVE_FORMAT_G729A 0x0083")]
    public const int WAVE_FORMAT_G729A = 0x0083;
    [NativeTypeName("#define WAVE_FORMAT_MVI_MVI2 0x0084")]
    public const int WAVE_FORMAT_MVI_MVI2 = 0x0084;
    [NativeTypeName("#define WAVE_FORMAT_DF_G726 0x0085")]
    public const int WAVE_FORMAT_DF_G726 = 0x0085;
    [NativeTypeName("#define WAVE_FORMAT_DF_GSM610 0x0086")]
    public const int WAVE_FORMAT_DF_GSM610 = 0x0086;
    [NativeTypeName("#define WAVE_FORMAT_ISIAUDIO 0x0088")]
    public const int WAVE_FORMAT_ISIAUDIO = 0x0088;
    [NativeTypeName("#define WAVE_FORMAT_ONLIVE 0x0089")]
    public const int WAVE_FORMAT_ONLIVE = 0x0089;
    [NativeTypeName("#define WAVE_FORMAT_MULTITUDE_FT_SX20 0x008A")]
    public const int WAVE_FORMAT_MULTITUDE_FT_SX20 = 0x008A;
    [NativeTypeName("#define WAVE_FORMAT_INFOCOM_ITS_G721_ADPCM 0x008B")]
    public const int WAVE_FORMAT_INFOCOM_ITS_G721_ADPCM = 0x008B;
    [NativeTypeName("#define WAVE_FORMAT_CONVEDIA_G729 0x008C")]
    public const int WAVE_FORMAT_CONVEDIA_G729 = 0x008C;
    [NativeTypeName("#define WAVE_FORMAT_CONGRUENCY 0x008D")]
    public const int WAVE_FORMAT_CONGRUENCY = 0x008D;
    [NativeTypeName("#define WAVE_FORMAT_SBC24 0x0091")]
    public const int WAVE_FORMAT_SBC24 = 0x0091;
    [NativeTypeName("#define WAVE_FORMAT_DOLBY_AC3_SPDIF 0x0092")]
    public const int WAVE_FORMAT_DOLBY_AC3_SPDIF = 0x0092;
    [NativeTypeName("#define WAVE_FORMAT_MEDIASONIC_G723 0x0093")]
    public const int WAVE_FORMAT_MEDIASONIC_G723 = 0x0093;
    [NativeTypeName("#define WAVE_FORMAT_PROSODY_8KBPS 0x0094")]
    public const int WAVE_FORMAT_PROSODY_8KBPS = 0x0094;
    [NativeTypeName("#define WAVE_FORMAT_ZYXEL_ADPCM 0x0097")]
    public const int WAVE_FORMAT_ZYXEL_ADPCM = 0x0097;
    [NativeTypeName("#define WAVE_FORMAT_PHILIPS_LPCBB 0x0098")]
    public const int WAVE_FORMAT_PHILIPS_LPCBB = 0x0098;
    [NativeTypeName("#define WAVE_FORMAT_PACKED 0x0099")]
    public const int WAVE_FORMAT_PACKED = 0x0099;
    [NativeTypeName("#define WAVE_FORMAT_MALDEN_PHONYTALK 0x00A0")]
    public const int WAVE_FORMAT_MALDEN_PHONYTALK = 0x00A0;
    [NativeTypeName("#define WAVE_FORMAT_RACAL_RECORDER_GSM 0x00A1")]
    public const int WAVE_FORMAT_RACAL_RECORDER_GSM = 0x00A1;
    [NativeTypeName("#define WAVE_FORMAT_RACAL_RECORDER_G720_A 0x00A2")]
    public const int WAVE_FORMAT_RACAL_RECORDER_G720_A = 0x00A2;
    [NativeTypeName("#define WAVE_FORMAT_RACAL_RECORDER_G723_1 0x00A3")]
    public const int WAVE_FORMAT_RACAL_RECORDER_G723_1 = 0x00A3;
    [NativeTypeName("#define WAVE_FORMAT_RACAL_RECORDER_TETRA_ACELP 0x00A4")]
    public const int WAVE_FORMAT_RACAL_RECORDER_TETRA_ACELP = 0x00A4;
    [NativeTypeName("#define WAVE_FORMAT_NEC_AAC 0x00B0")]
    public const int WAVE_FORMAT_NEC_AAC = 0x00B0;
    [NativeTypeName("#define WAVE_FORMAT_RAW_AAC1 0x00FF")]
    public const int WAVE_FORMAT_RAW_AAC1 = 0x00FF;
    [NativeTypeName("#define WAVE_FORMAT_RHETOREX_ADPCM 0x0100")]
    public const int WAVE_FORMAT_RHETOREX_ADPCM = 0x0100;
    [NativeTypeName("#define WAVE_FORMAT_IRAT 0x0101")]
    public const int WAVE_FORMAT_IRAT = 0x0101;
    [NativeTypeName("#define WAVE_FORMAT_VIVO_G723 0x0111")]
    public const int WAVE_FORMAT_VIVO_G723 = 0x0111;
    [NativeTypeName("#define WAVE_FORMAT_VIVO_SIREN 0x0112")]
    public const int WAVE_FORMAT_VIVO_SIREN = 0x0112;
    [NativeTypeName("#define WAVE_FORMAT_PHILIPS_CELP 0x0120")]
    public const int WAVE_FORMAT_PHILIPS_CELP = 0x0120;
    [NativeTypeName("#define WAVE_FORMAT_PHILIPS_GRUNDIG 0x0121")]
    public const int WAVE_FORMAT_PHILIPS_GRUNDIG = 0x0121;
    [NativeTypeName("#define WAVE_FORMAT_DIGITAL_G723 0x0123")]
    public const int WAVE_FORMAT_DIGITAL_G723 = 0x0123;
    [NativeTypeName("#define WAVE_FORMAT_SANYO_LD_ADPCM 0x0125")]
    public const int WAVE_FORMAT_SANYO_LD_ADPCM = 0x0125;
    [NativeTypeName("#define WAVE_FORMAT_SIPROLAB_ACEPLNET 0x0130")]
    public const int WAVE_FORMAT_SIPROLAB_ACEPLNET = 0x0130;
    [NativeTypeName("#define WAVE_FORMAT_SIPROLAB_ACELP4800 0x0131")]
    public const int WAVE_FORMAT_SIPROLAB_ACELP4800 = 0x0131;
    [NativeTypeName("#define WAVE_FORMAT_SIPROLAB_ACELP8V3 0x0132")]
    public const int WAVE_FORMAT_SIPROLAB_ACELP8V3 = 0x0132;
    [NativeTypeName("#define WAVE_FORMAT_SIPROLAB_G729 0x0133")]
    public const int WAVE_FORMAT_SIPROLAB_G729 = 0x0133;
    [NativeTypeName("#define WAVE_FORMAT_SIPROLAB_G729A 0x0134")]
    public const int WAVE_FORMAT_SIPROLAB_G729A = 0x0134;
    [NativeTypeName("#define WAVE_FORMAT_SIPROLAB_KELVIN 0x0135")]
    public const int WAVE_FORMAT_SIPROLAB_KELVIN = 0x0135;
    [NativeTypeName("#define WAVE_FORMAT_VOICEAGE_AMR 0x0136")]
    public const int WAVE_FORMAT_VOICEAGE_AMR = 0x0136;
    [NativeTypeName("#define WAVE_FORMAT_G726ADPCM 0x0140")]
    public const int WAVE_FORMAT_G726ADPCM = 0x0140;
    [NativeTypeName("#define WAVE_FORMAT_DICTAPHONE_CELP68 0x0141")]
    public const int WAVE_FORMAT_DICTAPHONE_CELP68 = 0x0141;
    [NativeTypeName("#define WAVE_FORMAT_DICTAPHONE_CELP54 0x0142")]
    public const int WAVE_FORMAT_DICTAPHONE_CELP54 = 0x0142;
    [NativeTypeName("#define WAVE_FORMAT_QUALCOMM_PUREVOICE 0x0150")]
    public const int WAVE_FORMAT_QUALCOMM_PUREVOICE = 0x0150;
    [NativeTypeName("#define WAVE_FORMAT_QUALCOMM_HALFRATE 0x0151")]
    public const int WAVE_FORMAT_QUALCOMM_HALFRATE = 0x0151;
    [NativeTypeName("#define WAVE_FORMAT_TUBGSM 0x0155")]
    public const int WAVE_FORMAT_TUBGSM = 0x0155;
    [NativeTypeName("#define WAVE_FORMAT_MSAUDIO1 0x0160")]
    public const int WAVE_FORMAT_MSAUDIO1 = 0x0160;
    [NativeTypeName("#define WAVE_FORMAT_WMAUDIO2 0x0161")]
    public const int WAVE_FORMAT_WMAUDIO2 = 0x0161;
    [NativeTypeName("#define WAVE_FORMAT_WMAUDIO3 0x0162")]
    public const int WAVE_FORMAT_WMAUDIO3 = 0x0162;
    [NativeTypeName("#define WAVE_FORMAT_WMAUDIO_LOSSLESS 0x0163")]
    public const int WAVE_FORMAT_WMAUDIO_LOSSLESS = 0x0163;
    [NativeTypeName("#define WAVE_FORMAT_WMASPDIF 0x0164")]
    public const int WAVE_FORMAT_WMASPDIF = 0x0164;
    [NativeTypeName("#define WAVE_FORMAT_UNISYS_NAP_ADPCM 0x0170")]
    public const int WAVE_FORMAT_UNISYS_NAP_ADPCM = 0x0170;
    [NativeTypeName("#define WAVE_FORMAT_UNISYS_NAP_ULAW 0x0171")]
    public const int WAVE_FORMAT_UNISYS_NAP_ULAW = 0x0171;
    [NativeTypeName("#define WAVE_FORMAT_UNISYS_NAP_ALAW 0x0172")]
    public const int WAVE_FORMAT_UNISYS_NAP_ALAW = 0x0172;
    [NativeTypeName("#define WAVE_FORMAT_UNISYS_NAP_16K 0x0173")]
    public const int WAVE_FORMAT_UNISYS_NAP_16K = 0x0173;
    [NativeTypeName("#define WAVE_FORMAT_SYCOM_ACM_SYC008 0x0174")]
    public const int WAVE_FORMAT_SYCOM_ACM_SYC008 = 0x0174;
    [NativeTypeName("#define WAVE_FORMAT_SYCOM_ACM_SYC701_G726L 0x0175")]
    public const int WAVE_FORMAT_SYCOM_ACM_SYC701_G726L = 0x0175;
    [NativeTypeName("#define WAVE_FORMAT_SYCOM_ACM_SYC701_CELP54 0x0176")]
    public const int WAVE_FORMAT_SYCOM_ACM_SYC701_CELP54 = 0x0176;
    [NativeTypeName("#define WAVE_FORMAT_SYCOM_ACM_SYC701_CELP68 0x0177")]
    public const int WAVE_FORMAT_SYCOM_ACM_SYC701_CELP68 = 0x0177;
    [NativeTypeName("#define WAVE_FORMAT_KNOWLEDGE_ADVENTURE_ADPCM 0x0178")]
    public const int WAVE_FORMAT_KNOWLEDGE_ADVENTURE_ADPCM = 0x0178;
    [NativeTypeName("#define WAVE_FORMAT_FRAUNHOFER_IIS_MPEG2_AAC 0x0180")]
    public const int WAVE_FORMAT_FRAUNHOFER_IIS_MPEG2_AAC = 0x0180;
    [NativeTypeName("#define WAVE_FORMAT_DTS_DS 0x0190")]
    public const int WAVE_FORMAT_DTS_DS = 0x0190;
    [NativeTypeName("#define WAVE_FORMAT_CREATIVE_ADPCM 0x0200")]
    public const int WAVE_FORMAT_CREATIVE_ADPCM = 0x0200;
    [NativeTypeName("#define WAVE_FORMAT_CREATIVE_FASTSPEECH8 0x0202")]
    public const int WAVE_FORMAT_CREATIVE_FASTSPEECH8 = 0x0202;
    [NativeTypeName("#define WAVE_FORMAT_CREATIVE_FASTSPEECH10 0x0203")]
    public const int WAVE_FORMAT_CREATIVE_FASTSPEECH10 = 0x0203;
    [NativeTypeName("#define WAVE_FORMAT_UHER_ADPCM 0x0210")]
    public const int WAVE_FORMAT_UHER_ADPCM = 0x0210;
    [NativeTypeName("#define WAVE_FORMAT_ULEAD_DV_AUDIO 0x0215")]
    public const int WAVE_FORMAT_ULEAD_DV_AUDIO = 0x0215;
    [NativeTypeName("#define WAVE_FORMAT_ULEAD_DV_AUDIO_1 0x0216")]
    public const int WAVE_FORMAT_ULEAD_DV_AUDIO_1 = 0x0216;
    [NativeTypeName("#define WAVE_FORMAT_QUARTERDECK 0x0220")]
    public const int WAVE_FORMAT_QUARTERDECK = 0x0220;
    [NativeTypeName("#define WAVE_FORMAT_ILINK_VC 0x0230")]
    public const int WAVE_FORMAT_ILINK_VC = 0x0230;
    [NativeTypeName("#define WAVE_FORMAT_RAW_SPORT 0x0240")]
    public const int WAVE_FORMAT_RAW_SPORT = 0x0240;
    [NativeTypeName("#define WAVE_FORMAT_ESST_AC3 0x0241")]
    public const int WAVE_FORMAT_ESST_AC3 = 0x0241;
    [NativeTypeName("#define WAVE_FORMAT_GENERIC_PASSTHRU 0x0249")]
    public const int WAVE_FORMAT_GENERIC_PASSTHRU = 0x0249;
    [NativeTypeName("#define WAVE_FORMAT_IPI_HSX 0x0250")]
    public const int WAVE_FORMAT_IPI_HSX = 0x0250;
    [NativeTypeName("#define WAVE_FORMAT_IPI_RPELP 0x0251")]
    public const int WAVE_FORMAT_IPI_RPELP = 0x0251;
    [NativeTypeName("#define WAVE_FORMAT_CS2 0x0260")]
    public const int WAVE_FORMAT_CS2 = 0x0260;
    [NativeTypeName("#define WAVE_FORMAT_SONY_SCX 0x0270")]
    public const int WAVE_FORMAT_SONY_SCX = 0x0270;
    [NativeTypeName("#define WAVE_FORMAT_SONY_SCY 0x0271")]
    public const int WAVE_FORMAT_SONY_SCY = 0x0271;
    [NativeTypeName("#define WAVE_FORMAT_SONY_ATRAC3 0x0272")]
    public const int WAVE_FORMAT_SONY_ATRAC3 = 0x0272;
    [NativeTypeName("#define WAVE_FORMAT_SONY_SPC 0x0273")]
    public const int WAVE_FORMAT_SONY_SPC = 0x0273;
    [NativeTypeName("#define WAVE_FORMAT_TELUM_AUDIO 0x0280")]
    public const int WAVE_FORMAT_TELUM_AUDIO = 0x0280;
    [NativeTypeName("#define WAVE_FORMAT_TELUM_IA_AUDIO 0x0281")]
    public const int WAVE_FORMAT_TELUM_IA_AUDIO = 0x0281;
    [NativeTypeName("#define WAVE_FORMAT_NORCOM_VOICE_SYSTEMS_ADPCM 0x0285")]
    public const int WAVE_FORMAT_NORCOM_VOICE_SYSTEMS_ADPCM = 0x0285;
    [NativeTypeName("#define WAVE_FORMAT_FM_TOWNS_SND 0x0300")]
    public const int WAVE_FORMAT_FM_TOWNS_SND = 0x0300;
    [NativeTypeName("#define WAVE_FORMAT_MICRONAS 0x0350")]
    public const int WAVE_FORMAT_MICRONAS = 0x0350;
    [NativeTypeName("#define WAVE_FORMAT_MICRONAS_CELP833 0x0351")]
    public const int WAVE_FORMAT_MICRONAS_CELP833 = 0x0351;
    [NativeTypeName("#define WAVE_FORMAT_BTV_DIGITAL 0x0400")]
    public const int WAVE_FORMAT_BTV_DIGITAL = 0x0400;
    [NativeTypeName("#define WAVE_FORMAT_INTEL_MUSIC_CODER 0x0401")]
    public const int WAVE_FORMAT_INTEL_MUSIC_CODER = 0x0401;
    [NativeTypeName("#define WAVE_FORMAT_INDEO_AUDIO 0x0402")]
    public const int WAVE_FORMAT_INDEO_AUDIO = 0x0402;
    [NativeTypeName("#define WAVE_FORMAT_QDESIGN_MUSIC 0x0450")]
    public const int WAVE_FORMAT_QDESIGN_MUSIC = 0x0450;
    [NativeTypeName("#define WAVE_FORMAT_ON2_VP7_AUDIO 0x0500")]
    public const int WAVE_FORMAT_ON2_VP7_AUDIO = 0x0500;
    [NativeTypeName("#define WAVE_FORMAT_ON2_VP6_AUDIO 0x0501")]
    public const int WAVE_FORMAT_ON2_VP6_AUDIO = 0x0501;
    [NativeTypeName("#define WAVE_FORMAT_VME_VMPCM 0x0680")]
    public const int WAVE_FORMAT_VME_VMPCM = 0x0680;
    [NativeTypeName("#define WAVE_FORMAT_TPC 0x0681")]
    public const int WAVE_FORMAT_TPC = 0x0681;
    [NativeTypeName("#define WAVE_FORMAT_LIGHTWAVE_LOSSLESS 0x08AE")]
    public const int WAVE_FORMAT_LIGHTWAVE_LOSSLESS = 0x08AE;
    [NativeTypeName("#define WAVE_FORMAT_OLIGSM 0x1000")]
    public const int WAVE_FORMAT_OLIGSM = 0x1000;
    [NativeTypeName("#define WAVE_FORMAT_OLIADPCM 0x1001")]
    public const int WAVE_FORMAT_OLIADPCM = 0x1001;
    [NativeTypeName("#define WAVE_FORMAT_OLICELP 0x1002")]
    public const int WAVE_FORMAT_OLICELP = 0x1002;
    [NativeTypeName("#define WAVE_FORMAT_OLISBC 0x1003")]
    public const int WAVE_FORMAT_OLISBC = 0x1003;
    [NativeTypeName("#define WAVE_FORMAT_OLIOPR 0x1004")]
    public const int WAVE_FORMAT_OLIOPR = 0x1004;
    [NativeTypeName("#define WAVE_FORMAT_LH_CODEC 0x1100")]
    public const int WAVE_FORMAT_LH_CODEC = 0x1100;
    [NativeTypeName("#define WAVE_FORMAT_LH_CODEC_CELP 0x1101")]
    public const int WAVE_FORMAT_LH_CODEC_CELP = 0x1101;
    [NativeTypeName("#define WAVE_FORMAT_LH_CODEC_SBC8 0x1102")]
    public const int WAVE_FORMAT_LH_CODEC_SBC8 = 0x1102;
    [NativeTypeName("#define WAVE_FORMAT_LH_CODEC_SBC12 0x1103")]
    public const int WAVE_FORMAT_LH_CODEC_SBC12 = 0x1103;
    [NativeTypeName("#define WAVE_FORMAT_LH_CODEC_SBC16 0x1104")]
    public const int WAVE_FORMAT_LH_CODEC_SBC16 = 0x1104;
    [NativeTypeName("#define WAVE_FORMAT_NORRIS 0x1400")]
    public const int WAVE_FORMAT_NORRIS = 0x1400;
    [NativeTypeName("#define WAVE_FORMAT_ISIAUDIO_2 0x1401")]
    public const int WAVE_FORMAT_ISIAUDIO_2 = 0x1401;
    [NativeTypeName("#define WAVE_FORMAT_SOUNDSPACE_MUSICOMPRESS 0x1500")]
    public const int WAVE_FORMAT_SOUNDSPACE_MUSICOMPRESS = 0x1500;
    [NativeTypeName("#define WAVE_FORMAT_MPEG_ADTS_AAC 0x1600")]
    public const int WAVE_FORMAT_MPEG_ADTS_AAC = 0x1600;
    [NativeTypeName("#define WAVE_FORMAT_MPEG_RAW_AAC 0x1601")]
    public const int WAVE_FORMAT_MPEG_RAW_AAC = 0x1601;
    [NativeTypeName("#define WAVE_FORMAT_MPEG_LOAS 0x1602")]
    public const int WAVE_FORMAT_MPEG_LOAS = 0x1602;
    [NativeTypeName("#define WAVE_FORMAT_NOKIA_MPEG_ADTS_AAC 0x1608")]
    public const int WAVE_FORMAT_NOKIA_MPEG_ADTS_AAC = 0x1608;
    [NativeTypeName("#define WAVE_FORMAT_NOKIA_MPEG_RAW_AAC 0x1609")]
    public const int WAVE_FORMAT_NOKIA_MPEG_RAW_AAC = 0x1609;
    [NativeTypeName("#define WAVE_FORMAT_VODAFONE_MPEG_ADTS_AAC 0x160A")]
    public const int WAVE_FORMAT_VODAFONE_MPEG_ADTS_AAC = 0x160A;
    [NativeTypeName("#define WAVE_FORMAT_VODAFONE_MPEG_RAW_AAC 0x160B")]
    public const int WAVE_FORMAT_VODAFONE_MPEG_RAW_AAC = 0x160B;
    [NativeTypeName("#define WAVE_FORMAT_MPEG_HEAAC 0x1610")]
    public const int WAVE_FORMAT_MPEG_HEAAC = 0x1610;
    [NativeTypeName("#define WAVE_FORMAT_VOXWARE_RT24_SPEECH 0x181C")]
    public const int WAVE_FORMAT_VOXWARE_RT24_SPEECH = 0x181C;
    [NativeTypeName("#define WAVE_FORMAT_SONICFOUNDRY_LOSSLESS 0x1971")]
    public const int WAVE_FORMAT_SONICFOUNDRY_LOSSLESS = 0x1971;
    [NativeTypeName("#define WAVE_FORMAT_INNINGS_TELECOM_ADPCM 0x1979")]
    public const int WAVE_FORMAT_INNINGS_TELECOM_ADPCM = 0x1979;
    [NativeTypeName("#define WAVE_FORMAT_LUCENT_SX8300P 0x1C07")]
    public const int WAVE_FORMAT_LUCENT_SX8300P = 0x1C07;
    [NativeTypeName("#define WAVE_FORMAT_LUCENT_SX5363S 0x1C0C")]
    public const int WAVE_FORMAT_LUCENT_SX5363S = 0x1C0C;
    [NativeTypeName("#define WAVE_FORMAT_CUSEEME 0x1F03")]
    public const int WAVE_FORMAT_CUSEEME = 0x1F03;
    [NativeTypeName("#define WAVE_FORMAT_NTCSOFT_ALF2CM_ACM 0x1FC4")]
    public const int WAVE_FORMAT_NTCSOFT_ALF2CM_ACM = 0x1FC4;
    [NativeTypeName("#define WAVE_FORMAT_DVM 0x2000")]
    public const int WAVE_FORMAT_DVM = 0x2000;
    [NativeTypeName("#define WAVE_FORMAT_DTS2 0x2001")]
    public const int WAVE_FORMAT_DTS2 = 0x2001;
    [NativeTypeName("#define WAVE_FORMAT_MAKEAVIS 0x3313")]
    public const int WAVE_FORMAT_MAKEAVIS = 0x3313;
    [NativeTypeName("#define WAVE_FORMAT_DIVIO_MPEG4_AAC 0x4143")]
    public const int WAVE_FORMAT_DIVIO_MPEG4_AAC = 0x4143;
    [NativeTypeName("#define WAVE_FORMAT_NOKIA_ADAPTIVE_MULTIRATE 0x4201")]
    public const int WAVE_FORMAT_NOKIA_ADAPTIVE_MULTIRATE = 0x4201;
    [NativeTypeName("#define WAVE_FORMAT_DIVIO_G726 0x4243")]
    public const int WAVE_FORMAT_DIVIO_G726 = 0x4243;
    [NativeTypeName("#define WAVE_FORMAT_LEAD_SPEECH 0x434C")]
    public const int WAVE_FORMAT_LEAD_SPEECH = 0x434C;
    [NativeTypeName("#define WAVE_FORMAT_LEAD_VORBIS 0x564C")]
    public const int WAVE_FORMAT_LEAD_VORBIS = 0x564C;
    [NativeTypeName("#define WAVE_FORMAT_WAVPACK_AUDIO 0x5756")]
    public const int WAVE_FORMAT_WAVPACK_AUDIO = 0x5756;
    [NativeTypeName("#define WAVE_FORMAT_ALAC 0x6C61")]
    public const int WAVE_FORMAT_ALAC = 0x6C61;
    [NativeTypeName("#define WAVE_FORMAT_OGG_VORBIS_MODE_1 0x674F")]
    public const int WAVE_FORMAT_OGG_VORBIS_MODE_1 = 0x674F;
    [NativeTypeName("#define WAVE_FORMAT_OGG_VORBIS_MODE_2 0x6750")]
    public const int WAVE_FORMAT_OGG_VORBIS_MODE_2 = 0x6750;
    [NativeTypeName("#define WAVE_FORMAT_OGG_VORBIS_MODE_3 0x6751")]
    public const int WAVE_FORMAT_OGG_VORBIS_MODE_3 = 0x6751;
    [NativeTypeName("#define WAVE_FORMAT_OGG_VORBIS_MODE_1_PLUS 0x676F")]
    public const int WAVE_FORMAT_OGG_VORBIS_MODE_1_PLUS = 0x676F;
    [NativeTypeName("#define WAVE_FORMAT_OGG_VORBIS_MODE_2_PLUS 0x6770")]
    public const int WAVE_FORMAT_OGG_VORBIS_MODE_2_PLUS = 0x6770;
    [NativeTypeName("#define WAVE_FORMAT_OGG_VORBIS_MODE_3_PLUS 0x6771")]
    public const int WAVE_FORMAT_OGG_VORBIS_MODE_3_PLUS = 0x6771;
    [NativeTypeName("#define WAVE_FORMAT_3COM_NBX 0x7000")]
    public const int WAVE_FORMAT_3COM_NBX = 0x7000;
    [NativeTypeName("#define WAVE_FORMAT_OPUS 0x704F")]
    public const int WAVE_FORMAT_OPUS = 0x704F;
    [NativeTypeName("#define WAVE_FORMAT_FAAD_AAC 0x706D")]
    public const int WAVE_FORMAT_FAAD_AAC = 0x706D;
    [NativeTypeName("#define WAVE_FORMAT_AMR_NB 0x7361")]
    public const int WAVE_FORMAT_AMR_NB = 0x7361;
    [NativeTypeName("#define WAVE_FORMAT_AMR_WB 0x7362")]
    public const int WAVE_FORMAT_AMR_WB = 0x7362;
    [NativeTypeName("#define WAVE_FORMAT_AMR_WP 0x7363")]
    public const int WAVE_FORMAT_AMR_WP = 0x7363;
    [NativeTypeName("#define WAVE_FORMAT_GSM_AMR_CBR 0x7A21")]
    public const int WAVE_FORMAT_GSM_AMR_CBR = 0x7A21;
    [NativeTypeName("#define WAVE_FORMAT_GSM_AMR_VBR_SID 0x7A22")]
    public const int WAVE_FORMAT_GSM_AMR_VBR_SID = 0x7A22;
    [NativeTypeName("#define WAVE_FORMAT_COMVERSE_INFOSYS_G723_1 0xA100")]
    public const int WAVE_FORMAT_COMVERSE_INFOSYS_G723_1 = 0xA100;
    [NativeTypeName("#define WAVE_FORMAT_COMVERSE_INFOSYS_AVQSBC 0xA101")]
    public const int WAVE_FORMAT_COMVERSE_INFOSYS_AVQSBC = 0xA101;
    [NativeTypeName("#define WAVE_FORMAT_COMVERSE_INFOSYS_SBC 0xA102")]
    public const int WAVE_FORMAT_COMVERSE_INFOSYS_SBC = 0xA102;
    [NativeTypeName("#define WAVE_FORMAT_SYMBOL_G729_A 0xA103")]
    public const int WAVE_FORMAT_SYMBOL_G729_A = 0xA103;
    [NativeTypeName("#define WAVE_FORMAT_VOICEAGE_AMR_WB 0xA104")]
    public const int WAVE_FORMAT_VOICEAGE_AMR_WB = 0xA104;
    [NativeTypeName("#define WAVE_FORMAT_INGENIENT_G726 0xA105")]
    public const int WAVE_FORMAT_INGENIENT_G726 = 0xA105;
    [NativeTypeName("#define WAVE_FORMAT_MPEG4_AAC 0xA106")]
    public const int WAVE_FORMAT_MPEG4_AAC = 0xA106;
    [NativeTypeName("#define WAVE_FORMAT_ENCORE_G726 0xA107")]
    public const int WAVE_FORMAT_ENCORE_G726 = 0xA107;
    [NativeTypeName("#define WAVE_FORMAT_ZOLL_ASAO 0xA108")]
    public const int WAVE_FORMAT_ZOLL_ASAO = 0xA108;
    [NativeTypeName("#define WAVE_FORMAT_SPEEX_VOICE 0xA109")]
    public const int WAVE_FORMAT_SPEEX_VOICE = 0xA109;
    [NativeTypeName("#define WAVE_FORMAT_VIANIX_MASC 0xA10A")]
    public const int WAVE_FORMAT_VIANIX_MASC = 0xA10A;
    [NativeTypeName("#define WAVE_FORMAT_WM9_SPECTRUM_ANALYZER 0xA10B")]
    public const int WAVE_FORMAT_WM9_SPECTRUM_ANALYZER = 0xA10B;
    [NativeTypeName("#define WAVE_FORMAT_WMF_SPECTRUM_ANAYZER 0xA10C")]
    public const int WAVE_FORMAT_WMF_SPECTRUM_ANAYZER = 0xA10C;
    [NativeTypeName("#define WAVE_FORMAT_GSM_610 0xA10D")]
    public const int WAVE_FORMAT_GSM_610 = 0xA10D;
    [NativeTypeName("#define WAVE_FORMAT_GSM_620 0xA10E")]
    public const int WAVE_FORMAT_GSM_620 = 0xA10E;
    [NativeTypeName("#define WAVE_FORMAT_GSM_660 0xA10F")]
    public const int WAVE_FORMAT_GSM_660 = 0xA10F;
    [NativeTypeName("#define WAVE_FORMAT_GSM_690 0xA110")]
    public const int WAVE_FORMAT_GSM_690 = 0xA110;
    [NativeTypeName("#define WAVE_FORMAT_GSM_ADAPTIVE_MULTIRATE_WB 0xA111")]
    public const int WAVE_FORMAT_GSM_ADAPTIVE_MULTIRATE_WB = 0xA111;
    [NativeTypeName("#define WAVE_FORMAT_POLYCOM_G722 0xA112")]
    public const int WAVE_FORMAT_POLYCOM_G722 = 0xA112;
    [NativeTypeName("#define WAVE_FORMAT_POLYCOM_G728 0xA113")]
    public const int WAVE_FORMAT_POLYCOM_G728 = 0xA113;
    [NativeTypeName("#define WAVE_FORMAT_POLYCOM_G729_A 0xA114")]
    public const int WAVE_FORMAT_POLYCOM_G729_A = 0xA114;
    [NativeTypeName("#define WAVE_FORMAT_POLYCOM_SIREN 0xA115")]
    public const int WAVE_FORMAT_POLYCOM_SIREN = 0xA115;
    [NativeTypeName("#define WAVE_FORMAT_GLOBAL_IP_ILBC 0xA116")]
    public const int WAVE_FORMAT_GLOBAL_IP_ILBC = 0xA116;
    [NativeTypeName("#define WAVE_FORMAT_RADIOTIME_TIME_SHIFT_RADIO 0xA117")]
    public const int WAVE_FORMAT_RADIOTIME_TIME_SHIFT_RADIO = 0xA117;
    [NativeTypeName("#define WAVE_FORMAT_NICE_ACA 0xA118")]
    public const int WAVE_FORMAT_NICE_ACA = 0xA118;
    [NativeTypeName("#define WAVE_FORMAT_NICE_ADPCM 0xA119")]
    public const int WAVE_FORMAT_NICE_ADPCM = 0xA119;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G721 0xA11A")]
    public const int WAVE_FORMAT_VOCORD_G721 = 0xA11A;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G726 0xA11B")]
    public const int WAVE_FORMAT_VOCORD_G726 = 0xA11B;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G722_1 0xA11C")]
    public const int WAVE_FORMAT_VOCORD_G722_1 = 0xA11C;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G728 0xA11D")]
    public const int WAVE_FORMAT_VOCORD_G728 = 0xA11D;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G729 0xA11E")]
    public const int WAVE_FORMAT_VOCORD_G729 = 0xA11E;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G729_A 0xA11F")]
    public const int WAVE_FORMAT_VOCORD_G729_A = 0xA11F;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_G723_1 0xA120")]
    public const int WAVE_FORMAT_VOCORD_G723_1 = 0xA120;
    [NativeTypeName("#define WAVE_FORMAT_VOCORD_LBC 0xA121")]
    public const int WAVE_FORMAT_VOCORD_LBC = 0xA121;
    [NativeTypeName("#define WAVE_FORMAT_NICE_G728 0xA122")]
    public const int WAVE_FORMAT_NICE_G728 = 0xA122;
    [NativeTypeName("#define WAVE_FORMAT_FRACE_TELECOM_G729 0xA123")]
    public const int WAVE_FORMAT_FRACE_TELECOM_G729 = 0xA123;
    [NativeTypeName("#define WAVE_FORMAT_CODIAN 0xA124")]
    public const int WAVE_FORMAT_CODIAN = 0xA124;
    [NativeTypeName("#define WAVE_FORMAT_DOLBY_AC4 0xAC40")]
    public const int WAVE_FORMAT_DOLBY_AC4 = 0xAC40;
    [NativeTypeName("#define WAVE_FORMAT_FLAC 0xF1AC")]
    public const int WAVE_FORMAT_FLAC = 0xF1AC;
    [NativeTypeName("#define WAVE_FORMAT_EXTENSIBLE 0xFFFE")]
    public const int WAVE_FORMAT_EXTENSIBLE = 0xFFFE;
    [NativeTypeName("#define WAVE_FORMAT_DEVELOPMENT (0xFFFF)")]
    public const int WAVE_FORMAT_DEVELOPMENT = (0xFFFF);
    [NativeTypeName("#define WAVE_FILTER_UNKNOWN 0x0000")]
    public const int WAVE_FILTER_UNKNOWN = 0x0000;
    [NativeTypeName("#define WAVE_FILTER_DEVELOPMENT (0xFFFF)")]
    public const int WAVE_FILTER_DEVELOPMENT = (0xFFFF);
    [NativeTypeName("#define WAVE_FILTER_VOLUME 0x0001")]
    public const int WAVE_FILTER_VOLUME = 0x0001;
    [NativeTypeName("#define WAVE_FILTER_ECHO 0x0002")]
    public const int WAVE_FILTER_ECHO = 0x0002;
}