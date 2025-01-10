// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FACILITY
{
    [NativeTypeName("#define FACILITY_NULL 0")]
    public const int FACILITY_NULL = 0;

    [NativeTypeName("#define FACILITY_RPC 1")]
    public const int FACILITY_RPC = 1;

    [NativeTypeName("#define FACILITY_DISPATCH 2")]
    public const int FACILITY_DISPATCH = 2;

    [NativeTypeName("#define FACILITY_STORAGE 3")]
    public const int FACILITY_STORAGE = 3;

    [NativeTypeName("#define FACILITY_ITF 4")]
    public const int FACILITY_ITF = 4;

    [NativeTypeName("#define FACILITY_WIN32 7")]
    public const int FACILITY_WIN32 = 7;

    [NativeTypeName("#define FACILITY_WINDOWS 8")]
    public const int FACILITY_WINDOWS = 8;

    [NativeTypeName("#define FACILITY_SSPI 9")]
    public const int FACILITY_SSPI = 9;

    [NativeTypeName("#define FACILITY_SECURITY 9")]
    public const int FACILITY_SECURITY = 9;

    [NativeTypeName("#define FACILITY_CONTROL 10")]
    public const int FACILITY_CONTROL = 10;

    [NativeTypeName("#define FACILITY_CERT 11")]
    public const int FACILITY_CERT = 11;

    [NativeTypeName("#define FACILITY_INTERNET 12")]
    public const int FACILITY_INTERNET = 12;

    [NativeTypeName("#define FACILITY_MEDIASERVER 13")]
    public const int FACILITY_MEDIASERVER = 13;

    [NativeTypeName("#define FACILITY_MSMQ 14")]
    public const int FACILITY_MSMQ = 14;

    [NativeTypeName("#define FACILITY_SETUPAPI 15")]
    public const int FACILITY_SETUPAPI = 15;

    [NativeTypeName("#define FACILITY_SCARD 16")]
    public const int FACILITY_SCARD = 16;

    [NativeTypeName("#define FACILITY_COMPLUS 17")]
    public const int FACILITY_COMPLUS = 17;

    [NativeTypeName("#define FACILITY_AAF 18")]
    public const int FACILITY_AAF = 18;

    [NativeTypeName("#define FACILITY_URT 19")]
    public const int FACILITY_URT = 19;

    [NativeTypeName("#define FACILITY_ACS 20")]
    public const int FACILITY_ACS = 20;

    [NativeTypeName("#define FACILITY_DPLAY 21")]
    public const int FACILITY_DPLAY = 21;

    [NativeTypeName("#define FACILITY_UMI 22")]
    public const int FACILITY_UMI = 22;

    [NativeTypeName("#define FACILITY_SXS 23")]
    public const int FACILITY_SXS = 23;

    [NativeTypeName("#define FACILITY_WINDOWS_CE 24")]
    public const int FACILITY_WINDOWS_CE = 24;

    [NativeTypeName("#define FACILITY_HTTP 25")]
    public const int FACILITY_HTTP = 25;

    [NativeTypeName("#define FACILITY_USERMODE_COMMONLOG 26")]
    public const int FACILITY_USERMODE_COMMONLOG = 26;

    [NativeTypeName("#define FACILITY_WER 27")]
    public const int FACILITY_WER = 27;

    [NativeTypeName("#define FACILITY_USERMODE_FILTER_MANAGER 31")]
    public const int FACILITY_USERMODE_FILTER_MANAGER = 31;

    [NativeTypeName("#define FACILITY_BACKGROUNDCOPY 32")]
    public const int FACILITY_BACKGROUNDCOPY = 32;

    [NativeTypeName("#define FACILITY_CONFIGURATION 33")]
    public const int FACILITY_CONFIGURATION = 33;

    [NativeTypeName("#define FACILITY_WIA 33")]
    public const int FACILITY_WIA = 33;

    [NativeTypeName("#define FACILITY_STATE_MANAGEMENT 34")]
    public const int FACILITY_STATE_MANAGEMENT = 34;

    [NativeTypeName("#define FACILITY_METADIRECTORY 35")]
    public const int FACILITY_METADIRECTORY = 35;

    [NativeTypeName("#define FACILITY_WINDOWSUPDATE 36")]
    public const int FACILITY_WINDOWSUPDATE = 36;

    [NativeTypeName("#define FACILITY_DIRECTORYSERVICE 37")]
    public const int FACILITY_DIRECTORYSERVICE = 37;

    [NativeTypeName("#define FACILITY_GRAPHICS 38")]
    public const int FACILITY_GRAPHICS = 38;

    [NativeTypeName("#define FACILITY_SHELL 39")]
    public const int FACILITY_SHELL = 39;

    [NativeTypeName("#define FACILITY_NAP 39")]
    public const int FACILITY_NAP = 39;

    [NativeTypeName("#define FACILITY_TPM_SERVICES 40")]
    public const int FACILITY_TPM_SERVICES = 40;

    [NativeTypeName("#define FACILITY_TPM_SOFTWARE 41")]
    public const int FACILITY_TPM_SOFTWARE = 41;

    [NativeTypeName("#define FACILITY_UI 42")]
    public const int FACILITY_UI = 42;

    [NativeTypeName("#define FACILITY_XAML 43")]
    public const int FACILITY_XAML = 43;

    [NativeTypeName("#define FACILITY_ACTION_QUEUE 44")]
    public const int FACILITY_ACTION_QUEUE = 44;

    [NativeTypeName("#define FACILITY_PLA 48")]
    public const int FACILITY_PLA = 48;

    [NativeTypeName("#define FACILITY_WINDOWS_SETUP 48")]
    public const int FACILITY_WINDOWS_SETUP = 48;

    [NativeTypeName("#define FACILITY_FVE 49")]
    public const int FACILITY_FVE = 49;

    [NativeTypeName("#define FACILITY_FWP 50")]
    public const int FACILITY_FWP = 50;

    [NativeTypeName("#define FACILITY_WINRM 51")]
    public const int FACILITY_WINRM = 51;

    [NativeTypeName("#define FACILITY_NDIS 52")]
    public const int FACILITY_NDIS = 52;

    [NativeTypeName("#define FACILITY_USERMODE_HYPERVISOR 53")]
    public const int FACILITY_USERMODE_HYPERVISOR = 53;

    [NativeTypeName("#define FACILITY_CMI 54")]
    public const int FACILITY_CMI = 54;

    [NativeTypeName("#define FACILITY_USERMODE_VIRTUALIZATION 55")]
    public const int FACILITY_USERMODE_VIRTUALIZATION = 55;

    [NativeTypeName("#define FACILITY_USERMODE_VOLMGR 56")]
    public const int FACILITY_USERMODE_VOLMGR = 56;

    [NativeTypeName("#define FACILITY_BCD 57")]
    public const int FACILITY_BCD = 57;

    [NativeTypeName("#define FACILITY_USERMODE_VHD 58")]
    public const int FACILITY_USERMODE_VHD = 58;

    [NativeTypeName("#define FACILITY_USERMODE_HNS 59")]
    public const int FACILITY_USERMODE_HNS = 59;

    [NativeTypeName("#define FACILITY_SDIAG 60")]
    public const int FACILITY_SDIAG = 60;

    [NativeTypeName("#define FACILITY_WEBSERVICES 61")]
    public const int FACILITY_WEBSERVICES = 61;

    [NativeTypeName("#define FACILITY_WINPE 61")]
    public const int FACILITY_WINPE = 61;

    [NativeTypeName("#define FACILITY_WPN 62")]
    public const int FACILITY_WPN = 62;

    [NativeTypeName("#define FACILITY_WINDOWS_STORE 63")]
    public const int FACILITY_WINDOWS_STORE = 63;

    [NativeTypeName("#define FACILITY_INPUT 64")]
    public const int FACILITY_INPUT = 64;

    [NativeTypeName("#define FACILITY_QUIC 65")]
    public const int FACILITY_QUIC = 65;

    [NativeTypeName("#define FACILITY_EAP 66")]
    public const int FACILITY_EAP = 66;

    [NativeTypeName("#define FACILITY_IORING 70")]
    public const int FACILITY_IORING = 70;

    [NativeTypeName("#define FACILITY_WINDOWS_DEFENDER 80")]
    public const int FACILITY_WINDOWS_DEFENDER = 80;

    [NativeTypeName("#define FACILITY_OPC 81")]
    public const int FACILITY_OPC = 81;

    [NativeTypeName("#define FACILITY_XPS 82")]
    public const int FACILITY_XPS = 82;

    [NativeTypeName("#define FACILITY_MBN 84")]
    public const int FACILITY_MBN = 84;

    [NativeTypeName("#define FACILITY_POWERSHELL 84")]
    public const int FACILITY_POWERSHELL = 84;

    [NativeTypeName("#define FACILITY_RAS 83")]
    public const int FACILITY_RAS = 83;

    [NativeTypeName("#define FACILITY_P2P_INT 98")]
    public const int FACILITY_P2P_INT = 98;

    [NativeTypeName("#define FACILITY_P2P 99")]
    public const int FACILITY_P2P = 99;

    [NativeTypeName("#define FACILITY_DAF 100")]
    public const int FACILITY_DAF = 100;

    [NativeTypeName("#define FACILITY_BLUETOOTH_ATT 101")]
    public const int FACILITY_BLUETOOTH_ATT = 101;

    [NativeTypeName("#define FACILITY_AUDIO 102")]
    public const int FACILITY_AUDIO = 102;

    [NativeTypeName("#define FACILITY_STATEREPOSITORY 103")]
    public const int FACILITY_STATEREPOSITORY = 103;

    [NativeTypeName("#define FACILITY_VISUALCPP 109")]
    public const int FACILITY_VISUALCPP = 109;

    [NativeTypeName("#define FACILITY_SCRIPT 112")]
    public const int FACILITY_SCRIPT = 112;

    [NativeTypeName("#define FACILITY_PARSE 113")]
    public const int FACILITY_PARSE = 113;

    [NativeTypeName("#define FACILITY_BLB 120")]
    public const int FACILITY_BLB = 120;

    [NativeTypeName("#define FACILITY_BLB_CLI 121")]
    public const int FACILITY_BLB_CLI = 121;

    [NativeTypeName("#define FACILITY_WSBAPP 122")]
    public const int FACILITY_WSBAPP = 122;

    [NativeTypeName("#define FACILITY_BLBUI 128")]
    public const int FACILITY_BLBUI = 128;

    [NativeTypeName("#define FACILITY_USN 129")]
    public const int FACILITY_USN = 129;

    [NativeTypeName("#define FACILITY_USERMODE_VOLSNAP 130")]
    public const int FACILITY_USERMODE_VOLSNAP = 130;

    [NativeTypeName("#define FACILITY_TIERING 131")]
    public const int FACILITY_TIERING = 131;

    [NativeTypeName("#define FACILITY_WSB_ONLINE 133")]
    public const int FACILITY_WSB_ONLINE = 133;

    [NativeTypeName("#define FACILITY_ONLINE_ID 134")]
    public const int FACILITY_ONLINE_ID = 134;

    [NativeTypeName("#define FACILITY_DEVICE_UPDATE_AGENT 135")]
    public const int FACILITY_DEVICE_UPDATE_AGENT = 135;

    [NativeTypeName("#define FACILITY_DRVSERVICING 136")]
    public const int FACILITY_DRVSERVICING = 136;

    [NativeTypeName("#define FACILITY_DLS 153")]
    public const int FACILITY_DLS = 153;

    [NativeTypeName("#define FACILITY_DELIVERY_OPTIMIZATION 208")]
    public const int FACILITY_DELIVERY_OPTIMIZATION = 208;

    [NativeTypeName("#define FACILITY_USERMODE_SPACES 231")]
    public const int FACILITY_USERMODE_SPACES = 231;

    [NativeTypeName("#define FACILITY_USER_MODE_SECURITY_CORE 232")]
    public const int FACILITY_USER_MODE_SECURITY_CORE = 232;

    [NativeTypeName("#define FACILITY_USERMODE_LICENSING 234")]
    public const int FACILITY_USERMODE_LICENSING = 234;

    [NativeTypeName("#define FACILITY_SOS 160")]
    public const int FACILITY_SOS = 160;

    [NativeTypeName("#define FACILITY_OCP_UPDATE_AGENT 173")]
    public const int FACILITY_OCP_UPDATE_AGENT = 173;

    [NativeTypeName("#define FACILITY_DEBUGGERS 176")]
    public const int FACILITY_DEBUGGERS = 176;

    [NativeTypeName("#define FACILITY_SPP 256")]
    public const int FACILITY_SPP = 256;

    [NativeTypeName("#define FACILITY_RESTORE 256")]
    public const int FACILITY_RESTORE = 256;

    [NativeTypeName("#define FACILITY_DMSERVER 256")]
    public const int FACILITY_DMSERVER = 256;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_SERVER 257")]
    public const int FACILITY_DEPLOYMENT_SERVICES_SERVER = 257;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_IMAGING 258")]
    public const int FACILITY_DEPLOYMENT_SERVICES_IMAGING = 258;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT 259")]
    public const int FACILITY_DEPLOYMENT_SERVICES_MANAGEMENT = 259;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_UTIL 260")]
    public const int FACILITY_DEPLOYMENT_SERVICES_UTIL = 260;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_BINLSVC 261")]
    public const int FACILITY_DEPLOYMENT_SERVICES_BINLSVC = 261;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_PXE 263")]
    public const int FACILITY_DEPLOYMENT_SERVICES_PXE = 263;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_TFTP 264")]
    public const int FACILITY_DEPLOYMENT_SERVICES_TFTP = 264;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT 272")]
    public const int FACILITY_DEPLOYMENT_SERVICES_TRANSPORT_MANAGEMENT = 272;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING 278")]
    public const int FACILITY_DEPLOYMENT_SERVICES_DRIVER_PROVISIONING = 278;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER 289")]
    public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_SERVER = 289;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT 290")]
    public const int FACILITY_DEPLOYMENT_SERVICES_MULTICAST_CLIENT = 290;

    [NativeTypeName("#define FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER 293")]
    public const int FACILITY_DEPLOYMENT_SERVICES_CONTENT_PROVIDER = 293;

    [NativeTypeName("#define FACILITY_HSP_SERVICES 296")]
    public const int FACILITY_HSP_SERVICES = 296;

    [NativeTypeName("#define FACILITY_HSP_SOFTWARE 297")]
    public const int FACILITY_HSP_SOFTWARE = 297;

    [NativeTypeName("#define FACILITY_LINGUISTIC_SERVICES 305")]
    public const int FACILITY_LINGUISTIC_SERVICES = 305;

    [NativeTypeName("#define FACILITY_AUDIOSTREAMING 1094")]
    public const int FACILITY_AUDIOSTREAMING = 1094;

    [NativeTypeName("#define FACILITY_TTD 1490")]
    public const int FACILITY_TTD = 1490;

    [NativeTypeName("#define FACILITY_ACCELERATOR 1536")]
    public const int FACILITY_ACCELERATOR = 1536;

    [NativeTypeName("#define FACILITY_WMAAECMA 1996")]
    public const int FACILITY_WMAAECMA = 1996;

    [NativeTypeName("#define FACILITY_DIRECTMUSIC 2168")]
    public const int FACILITY_DIRECTMUSIC = 2168;

    [NativeTypeName("#define FACILITY_DIRECT3D10 2169")]
    public const int FACILITY_DIRECT3D10 = 2169;

    [NativeTypeName("#define FACILITY_DXGI 2170")]
    public const int FACILITY_DXGI = 2170;

    [NativeTypeName("#define FACILITY_DXGI_DDI 2171")]
    public const int FACILITY_DXGI_DDI = 2171;

    [NativeTypeName("#define FACILITY_DIRECT3D11 2172")]
    public const int FACILITY_DIRECT3D11 = 2172;

    [NativeTypeName("#define FACILITY_DIRECT3D11_DEBUG 2173")]
    public const int FACILITY_DIRECT3D11_DEBUG = 2173;

    [NativeTypeName("#define FACILITY_DIRECT3D12 2174")]
    public const int FACILITY_DIRECT3D12 = 2174;

    [NativeTypeName("#define FACILITY_DIRECT3D12_DEBUG 2175")]
    public const int FACILITY_DIRECT3D12_DEBUG = 2175;

    [NativeTypeName("#define FACILITY_DXCORE 2176")]
    public const int FACILITY_DXCORE = 2176;

    [NativeTypeName("#define FACILITY_PRESENTATION 2177")]
    public const int FACILITY_PRESENTATION = 2177;

    [NativeTypeName("#define FACILITY_LEAP 2184")]
    public const int FACILITY_LEAP = 2184;

    [NativeTypeName("#define FACILITY_AUDCLNT 2185")]
    public const int FACILITY_AUDCLNT = 2185;

    [NativeTypeName("#define FACILITY_WINCODEC_DWRITE_DWM 2200")]
    public const int FACILITY_WINCODEC_DWRITE_DWM = 2200;

    [NativeTypeName("#define FACILITY_WINML 2192")]
    public const int FACILITY_WINML = 2192;

    [NativeTypeName("#define FACILITY_DIRECT2D 2201")]
    public const int FACILITY_DIRECT2D = 2201;

    [NativeTypeName("#define FACILITY_DEFRAG 2304")]
    public const int FACILITY_DEFRAG = 2304;

    [NativeTypeName("#define FACILITY_USERMODE_SDBUS 2305")]
    public const int FACILITY_USERMODE_SDBUS = 2305;

    [NativeTypeName("#define FACILITY_JSCRIPT 2306")]
    public const int FACILITY_JSCRIPT = 2306;

    [NativeTypeName("#define FACILITY_PIDGENX 2561")]
    public const int FACILITY_PIDGENX = 2561;

    [NativeTypeName("#define FACILITY_EAS 85")]
    public const int FACILITY_EAS = 85;

    [NativeTypeName("#define FACILITY_WEB 885")]
    public const int FACILITY_WEB = 885;

    [NativeTypeName("#define FACILITY_WEB_SOCKET 886")]
    public const int FACILITY_WEB_SOCKET = 886;

    [NativeTypeName("#define FACILITY_MOBILE 1793")]
    public const int FACILITY_MOBILE = 1793;

    [NativeTypeName("#define FACILITY_SQLITE 1967")]
    public const int FACILITY_SQLITE = 1967;

    [NativeTypeName("#define FACILITY_SERVICE_FABRIC 1968")]
    public const int FACILITY_SERVICE_FABRIC = 1968;

    [NativeTypeName("#define FACILITY_UTC 1989")]
    public const int FACILITY_UTC = 1989;

    [NativeTypeName("#define FACILITY_WEP 2049")]
    public const int FACILITY_WEP = 2049;

    [NativeTypeName("#define FACILITY_SYNCENGINE 2050")]
    public const int FACILITY_SYNCENGINE = 2050;

    [NativeTypeName("#define FACILITY_XBOX 2339")]
    public const int FACILITY_XBOX = 2339;

    [NativeTypeName("#define FACILITY_GAME 2340")]
    public const int FACILITY_GAME = 2340;

    [NativeTypeName("#define FACILITY_USERMODE_UNIONFS 2341")]
    public const int FACILITY_USERMODE_UNIONFS = 2341;

    [NativeTypeName("#define FACILITY_USERMODE_PRM 2342")]
    public const int FACILITY_USERMODE_PRM = 2342;

    [NativeTypeName("#define FACILITY_USERMODE_WIN_ACCEL 2343")]
    public const int FACILITY_USERMODE_WIN_ACCEL = 2343;

    [NativeTypeName("#define FACILITY_PIX 2748")]
    public const int FACILITY_PIX = 2748;

    [NativeTypeName("#define FACILITY_NT_BIT 0x10000000")]
    public const int FACILITY_NT_BIT = 0x10000000;
}
