// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SDIAG
{
    [NativeTypeName("#define SDIAG_E_CANCELLED _NDIS_ERROR_TYPEDEF_(0x803C0100L)")]
    public const uint SDIAG_E_CANCELLED = (uint)(0x803C0100);

    [NativeTypeName("#define SDIAG_E_SCRIPT _NDIS_ERROR_TYPEDEF_(0x803C0101L)")]
    public const uint SDIAG_E_SCRIPT = (uint)(0x803C0101);

    [NativeTypeName("#define SDIAG_E_POWERSHELL _NDIS_ERROR_TYPEDEF_(0x803C0102L)")]
    public const uint SDIAG_E_POWERSHELL = (uint)(0x803C0102);

    [NativeTypeName("#define SDIAG_E_MANAGEDHOST _NDIS_ERROR_TYPEDEF_(0x803C0103L)")]
    public const uint SDIAG_E_MANAGEDHOST = (uint)(0x803C0103);

    [NativeTypeName("#define SDIAG_E_NOVERIFIER _NDIS_ERROR_TYPEDEF_(0x803C0104L)")]
    public const uint SDIAG_E_NOVERIFIER = (uint)(0x803C0104);

    [NativeTypeName("#define SDIAG_S_CANNOTRUN _NDIS_ERROR_TYPEDEF_(0x003C0105L)")]
    public const uint SDIAG_S_CANNOTRUN = (uint)(0x003C0105);

    [NativeTypeName("#define SDIAG_E_DISABLED _NDIS_ERROR_TYPEDEF_(0x803C0106L)")]
    public const uint SDIAG_E_DISABLED = (uint)(0x803C0106);

    [NativeTypeName("#define SDIAG_E_TRUST _NDIS_ERROR_TYPEDEF_(0x803C0107L)")]
    public const uint SDIAG_E_TRUST = (uint)(0x803C0107);

    [NativeTypeName("#define SDIAG_E_CANNOTRUN _NDIS_ERROR_TYPEDEF_(0x803C0108L)")]
    public const uint SDIAG_E_CANNOTRUN = (uint)(0x803C0108);

    [NativeTypeName("#define SDIAG_E_VERSION _NDIS_ERROR_TYPEDEF_(0x803C0109L)")]
    public const uint SDIAG_E_VERSION = (uint)(0x803C0109);

    [NativeTypeName("#define SDIAG_E_RESOURCE _NDIS_ERROR_TYPEDEF_(0x803C010AL)")]
    public const uint SDIAG_E_RESOURCE = (uint)(0x803C010A);

    [NativeTypeName("#define SDIAG_E_ROOTCAUSE _NDIS_ERROR_TYPEDEF_(0x803C010BL)")]
    public const uint SDIAG_E_ROOTCAUSE = (uint)(0x803C010B);
}
