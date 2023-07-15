// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class NIIF
{
    [NativeTypeName("#define NIIF_HARDWARE_INTERFACE 0x00000001")]
    public const int NIIF_HARDWARE_INTERFACE = 0x00000001;
    [NativeTypeName("#define NIIF_FILTER_INTERFACE 0x00000002")]
    public const int NIIF_FILTER_INTERFACE = 0x00000002;
    [NativeTypeName("#define NIIF_NDIS_RESERVED1 0x00000004")]
    public const int NIIF_NDIS_RESERVED1 = 0x00000004;
    [NativeTypeName("#define NIIF_NDIS_RESERVED2 0x00000008")]
    public const int NIIF_NDIS_RESERVED2 = 0x00000008;
    [NativeTypeName("#define NIIF_NDIS_RESERVED3 0x00000010")]
    public const int NIIF_NDIS_RESERVED3 = 0x00000010;
    [NativeTypeName("#define NIIF_NDIS_WDM_INTERFACE 0x00000020")]
    public const int NIIF_NDIS_WDM_INTERFACE = 0x00000020;
    [NativeTypeName("#define NIIF_NDIS_ENDPOINT_INTERFACE 0x00000040")]
    public const int NIIF_NDIS_ENDPOINT_INTERFACE = 0x00000040;
    [NativeTypeName("#define NIIF_NDIS_ISCSI_INTERFACE 0x00000080")]
    public const int NIIF_NDIS_ISCSI_INTERFACE = 0x00000080;
    [NativeTypeName("#define NIIF_NDIS_RESERVED4 0x00000100")]
    public const int NIIF_NDIS_RESERVED4 = 0x00000100;
    [NativeTypeName("#define NIIF_WAN_TUNNEL_TYPE_UNKNOWN ((ULONG)(-1))")]
    public const uint NIIF_WAN_TUNNEL_TYPE_UNKNOWN = unchecked((uint)(-1));
    [NativeTypeName("#define NIIF_BUS_NUMBER_UNKNOWN ((ULONG)(-1))")]
    public const uint NIIF_BUS_NUMBER_UNKNOWN = unchecked((uint)(-1));
    [NativeTypeName("#define NIIF_SLOT_NUMBER_UNKNOWN ((ULONG)(-1))")]
    public const uint NIIF_SLOT_NUMBER_UNKNOWN = unchecked((uint)(-1));
    [NativeTypeName("#define NIIF_FUNCTION_NUMBER_UNKNOWN ((ULONG)(-1))")]
    public const uint NIIF_FUNCTION_NUMBER_UNKNOWN = unchecked((uint)(-1));
}