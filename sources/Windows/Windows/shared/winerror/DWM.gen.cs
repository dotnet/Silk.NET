// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DWM
{
    [NativeTypeName("#define DWM_E_COMPOSITIONDISABLED _HRESULT_TYPEDEF_(0x80263001L)")]
    public const int DWM_E_COMPOSITIONDISABLED = unchecked((int)(0x80263001));
    [NativeTypeName("#define DWM_E_REMOTING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80263002L)")]
    public const int DWM_E_REMOTING_NOT_SUPPORTED = unchecked((int)(0x80263002));
    [NativeTypeName("#define DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE _HRESULT_TYPEDEF_(0x80263003L)")]
    public const int DWM_E_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)(0x80263003));
    [NativeTypeName("#define DWM_E_NOT_QUEUING_PRESENTS _HRESULT_TYPEDEF_(0x80263004L)")]
    public const int DWM_E_NOT_QUEUING_PRESENTS = unchecked((int)(0x80263004));
    [NativeTypeName("#define DWM_E_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x80263005L)")]
    public const int DWM_E_ADAPTER_NOT_FOUND = unchecked((int)(0x80263005));
    [NativeTypeName("#define DWM_S_GDI_REDIRECTION_SURFACE _HRESULT_TYPEDEF_(0x00263005L)")]
    public const int DWM_S_GDI_REDIRECTION_SURFACE = ((int)(0x00263005));
    [NativeTypeName("#define DWM_E_TEXTURE_TOO_LARGE _HRESULT_TYPEDEF_(0x80263007L)")]
    public const int DWM_E_TEXTURE_TOO_LARGE = unchecked((int)(0x80263007));
    [NativeTypeName("#define DWM_S_GDI_REDIRECTION_SURFACE_BLT_VIA_GDI _HRESULT_TYPEDEF_(0x00263008L)")]
    public const int DWM_S_GDI_REDIRECTION_SURFACE_BLT_VIA_GDI = ((int)(0x00263008));
}