// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DV
{
    [NativeTypeName("#define DV_E_FORMATETC _HRESULT_TYPEDEF_(0x80040064L)")]
    public const int DV_E_FORMATETC = unchecked((int)(0x80040064));

    [NativeTypeName("#define DV_E_DVTARGETDEVICE _HRESULT_TYPEDEF_(0x80040065L)")]
    public const int DV_E_DVTARGETDEVICE = unchecked((int)(0x80040065));

    [NativeTypeName("#define DV_E_STGMEDIUM _HRESULT_TYPEDEF_(0x80040066L)")]
    public const int DV_E_STGMEDIUM = unchecked((int)(0x80040066));

    [NativeTypeName("#define DV_E_STATDATA _HRESULT_TYPEDEF_(0x80040067L)")]
    public const int DV_E_STATDATA = unchecked((int)(0x80040067));

    [NativeTypeName("#define DV_E_LINDEX _HRESULT_TYPEDEF_(0x80040068L)")]
    public const int DV_E_LINDEX = unchecked((int)(0x80040068));

    [NativeTypeName("#define DV_E_TYMED _HRESULT_TYPEDEF_(0x80040069L)")]
    public const int DV_E_TYMED = unchecked((int)(0x80040069));

    [NativeTypeName("#define DV_E_CLIPFORMAT _HRESULT_TYPEDEF_(0x8004006AL)")]
    public const int DV_E_CLIPFORMAT = unchecked((int)(0x8004006A));

    [NativeTypeName("#define DV_E_DVASPECT _HRESULT_TYPEDEF_(0x8004006BL)")]
    public const int DV_E_DVASPECT = unchecked((int)(0x8004006B));

    [NativeTypeName("#define DV_E_DVTARGETDEVICE_SIZE _HRESULT_TYPEDEF_(0x8004006CL)")]
    public const int DV_E_DVTARGETDEVICE_SIZE = unchecked((int)(0x8004006C));

    [NativeTypeName("#define DV_E_NOIVIEWOBJECT _HRESULT_TYPEDEF_(0x8004006DL)")]
    public const int DV_E_NOIVIEWOBJECT = unchecked((int)(0x8004006D));
}
