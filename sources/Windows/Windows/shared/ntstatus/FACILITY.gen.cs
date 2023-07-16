// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FACILITY
{
    [NativeTypeName("#define FACILITY_DEBUGGER 0x1")]
    public const int FACILITY_DEBUGGER = 0x1;
    [NativeTypeName("#define FACILITY_RPC_RUNTIME 0x2")]
    public const int FACILITY_RPC_RUNTIME = 0x2;
    [NativeTypeName("#define FACILITY_RPC_STUBS 0x3")]
    public const int FACILITY_RPC_STUBS = 0x3;
    [NativeTypeName("#define FACILITY_IO_ERROR_CODE 0x4")]
    public const int FACILITY_IO_ERROR_CODE = 0x4;
    [NativeTypeName("#define FACILITY_CODCLASS_ERROR_CODE 0x6")]
    public const int FACILITY_CODCLASS_ERROR_CODE = 0x6;
    [NativeTypeName("#define FACILITY_NTWIN32 0x7")]
    public const int FACILITY_NTWIN32 = 0x7;
    [NativeTypeName("#define FACILITY_NTCERT 0x8")]
    public const int FACILITY_NTCERT = 0x8;
    [NativeTypeName("#define FACILITY_NTSSPI 0x9")]
    public const int FACILITY_NTSSPI = 0x9;
    [NativeTypeName("#define FACILITY_TERMINAL_SERVER 0xA")]
    public const int FACILITY_TERMINAL_SERVER = 0xA;
    [NativeTypeName("#define FACILITY_USB_ERROR_CODE 0x10")]
    public const int FACILITY_USB_ERROR_CODE = 0x10;
    [NativeTypeName("#define FACILITY_HID_ERROR_CODE 0x11")]
    public const int FACILITY_HID_ERROR_CODE = 0x11;
    [NativeTypeName("#define FACILITY_FIREWIRE_ERROR_CODE 0x12")]
    public const int FACILITY_FIREWIRE_ERROR_CODE = 0x12;
    [NativeTypeName("#define FACILITY_CLUSTER_ERROR_CODE 0x13")]
    public const int FACILITY_CLUSTER_ERROR_CODE = 0x13;
    [NativeTypeName("#define FACILITY_ACPI_ERROR_CODE 0x14")]
    public const int FACILITY_ACPI_ERROR_CODE = 0x14;
    [NativeTypeName("#define FACILITY_SXS_ERROR_CODE 0x15")]
    public const int FACILITY_SXS_ERROR_CODE = 0x15;
    [NativeTypeName("#define FACILITY_TRANSACTION 0x19")]
    public const int FACILITY_TRANSACTION = 0x19;
    [NativeTypeName("#define FACILITY_COMMONLOG 0x1A")]
    public const int FACILITY_COMMONLOG = 0x1A;
    [NativeTypeName("#define FACILITY_VIDEO 0x1B")]
    public const int FACILITY_VIDEO = 0x1B;
    [NativeTypeName("#define FACILITY_FILTER_MANAGER 0x1C")]
    public const int FACILITY_FILTER_MANAGER = 0x1C;
    [NativeTypeName("#define FACILITY_MONITOR 0x1D")]
    public const int FACILITY_MONITOR = 0x1D;
    [NativeTypeName("#define FACILITY_GRAPHICS_KERNEL 0x1E")]
    public const int FACILITY_GRAPHICS_KERNEL = 0x1E;
    [NativeTypeName("#define FACILITY_DRIVER_FRAMEWORK 0x20")]
    public const int FACILITY_DRIVER_FRAMEWORK = 0x20;
    [NativeTypeName("#define FACILITY_FVE_ERROR_CODE 0x21")]
    public const int FACILITY_FVE_ERROR_CODE = 0x21;
    [NativeTypeName("#define FACILITY_FWP_ERROR_CODE 0x22")]
    public const int FACILITY_FWP_ERROR_CODE = 0x22;
    [NativeTypeName("#define FACILITY_NDIS_ERROR_CODE 0x23")]
    public const int FACILITY_NDIS_ERROR_CODE = 0x23;
    [NativeTypeName("#define FACILITY_QUIC_ERROR_CODE 0x24")]
    public const int FACILITY_QUIC_ERROR_CODE = 0x24;
    [NativeTypeName("#define FACILITY_TPM 0x29")]
    public const int FACILITY_TPM = 0x29;
    [NativeTypeName("#define FACILITY_RTPM 0x2A")]
    public const int FACILITY_RTPM = 0x2A;
    [NativeTypeName("#define FACILITY_HYPERVISOR 0x35")]
    public const int FACILITY_HYPERVISOR = 0x35;
    [NativeTypeName("#define FACILITY_IPSEC 0x36")]
    public const int FACILITY_IPSEC = 0x36;
    [NativeTypeName("#define FACILITY_VIRTUALIZATION 0x37")]
    public const int FACILITY_VIRTUALIZATION = 0x37;
    [NativeTypeName("#define FACILITY_VOLMGR 0x38")]
    public const int FACILITY_VOLMGR = 0x38;
    [NativeTypeName("#define FACILITY_BCD_ERROR_CODE 0x39")]
    public const int FACILITY_BCD_ERROR_CODE = 0x39;
    [NativeTypeName("#define FACILITY_WIN32K_NTUSER 0x3E")]
    public const int FACILITY_WIN32K_NTUSER = 0x3E;
    [NativeTypeName("#define FACILITY_WIN32K_NTGDI 0x3F")]
    public const int FACILITY_WIN32K_NTGDI = 0x3F;
    [NativeTypeName("#define FACILITY_RESUME_KEY_FILTER 0x40")]
    public const int FACILITY_RESUME_KEY_FILTER = 0x40;
    [NativeTypeName("#define FACILITY_RDBSS 0x41")]
    public const int FACILITY_RDBSS = 0x41;
    [NativeTypeName("#define FACILITY_BTH_ATT 0x42")]
    public const int FACILITY_BTH_ATT = 0x42;
    [NativeTypeName("#define FACILITY_SECUREBOOT 0x43")]
    public const int FACILITY_SECUREBOOT = 0x43;
    [NativeTypeName("#define FACILITY_AUDIO_KERNEL 0x44")]
    public const int FACILITY_AUDIO_KERNEL = 0x44;
    [NativeTypeName("#define FACILITY_VSM 0x45")]
    public const int FACILITY_VSM = 0x45;
    [NativeTypeName("#define FACILITY_NT_IORING 0x46")]
    public const int FACILITY_NT_IORING = 0x46;
    [NativeTypeName("#define FACILITY_VOLSNAP 0x50")]
    public const int FACILITY_VOLSNAP = 0x50;
    [NativeTypeName("#define FACILITY_SDBUS 0x51")]
    public const int FACILITY_SDBUS = 0x51;
    [NativeTypeName("#define FACILITY_SHARED_VHDX 0x5C")]
    public const int FACILITY_SHARED_VHDX = 0x5C;
    [NativeTypeName("#define FACILITY_SMB 0x5D")]
    public const int FACILITY_SMB = 0x5D;
    [NativeTypeName("#define FACILITY_XVS 0x5E")]
    public const int FACILITY_XVS = 0x5E;
    [NativeTypeName("#define FACILITY_INTERIX 0x99")]
    public const int FACILITY_INTERIX = 0x99;
    [NativeTypeName("#define FACILITY_SPACES 0xE7")]
    public const int FACILITY_SPACES = 0xE7;
    [NativeTypeName("#define FACILITY_SECURITY_CORE 0xE8")]
    public const int FACILITY_SECURITY_CORE = 0xE8;
    [NativeTypeName("#define FACILITY_SYSTEM_INTEGRITY 0xE9")]
    public const int FACILITY_SYSTEM_INTEGRITY = 0xE9;
    [NativeTypeName("#define FACILITY_LICENSING 0xEA")]
    public const int FACILITY_LICENSING = 0xEA;
    [NativeTypeName("#define FACILITY_PLATFORM_MANIFEST 0xEB")]
    public const int FACILITY_PLATFORM_MANIFEST = 0xEB;
    [NativeTypeName("#define FACILITY_APP_EXEC 0xEC")]
    public const int FACILITY_APP_EXEC = 0xEC;
    [NativeTypeName("#define FACILITY_MAXIMUM_VALUE 0xED")]
    public const int FACILITY_MAXIMUM_VALUE = 0xED;
}