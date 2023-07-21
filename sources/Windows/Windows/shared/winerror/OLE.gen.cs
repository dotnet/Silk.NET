// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class OLE
{
    [NativeTypeName("#define OLE_E_FIRST ((HRESULT)0x80040000L)")]
    public const int OLE_E_FIRST = unchecked((int)(0x80040000));

    [NativeTypeName("#define OLE_E_LAST ((HRESULT)0x800400FFL)")]
    public const int OLE_E_LAST = unchecked((int)(0x800400FF));

    [NativeTypeName("#define OLE_S_FIRST ((HRESULT)0x00040000L)")]
    public const int OLE_S_FIRST = ((int)(0x00040000));

    [NativeTypeName("#define OLE_S_LAST ((HRESULT)0x000400FFL)")]
    public const int OLE_S_LAST = ((int)(0x000400FF));

    [NativeTypeName("#define OLE_E_OLEVERB _HRESULT_TYPEDEF_(0x80040000L)")]
    public const int OLE_E_OLEVERB = unchecked((int)(0x80040000));

    [NativeTypeName("#define OLE_E_ADVF _HRESULT_TYPEDEF_(0x80040001L)")]
    public const int OLE_E_ADVF = unchecked((int)(0x80040001));

    [NativeTypeName("#define OLE_E_ENUM_NOMORE _HRESULT_TYPEDEF_(0x80040002L)")]
    public const int OLE_E_ENUM_NOMORE = unchecked((int)(0x80040002));

    [NativeTypeName("#define OLE_E_ADVISENOTSUPPORTED _HRESULT_TYPEDEF_(0x80040003L)")]
    public const int OLE_E_ADVISENOTSUPPORTED = unchecked((int)(0x80040003));

    [NativeTypeName("#define OLE_E_NOCONNECTION _HRESULT_TYPEDEF_(0x80040004L)")]
    public const int OLE_E_NOCONNECTION = unchecked((int)(0x80040004));

    [NativeTypeName("#define OLE_E_NOTRUNNING _HRESULT_TYPEDEF_(0x80040005L)")]
    public const int OLE_E_NOTRUNNING = unchecked((int)(0x80040005));

    [NativeTypeName("#define OLE_E_NOCACHE _HRESULT_TYPEDEF_(0x80040006L)")]
    public const int OLE_E_NOCACHE = unchecked((int)(0x80040006));

    [NativeTypeName("#define OLE_E_BLANK _HRESULT_TYPEDEF_(0x80040007L)")]
    public const int OLE_E_BLANK = unchecked((int)(0x80040007));

    [NativeTypeName("#define OLE_E_CLASSDIFF _HRESULT_TYPEDEF_(0x80040008L)")]
    public const int OLE_E_CLASSDIFF = unchecked((int)(0x80040008));

    [NativeTypeName("#define OLE_E_CANT_GETMONIKER _HRESULT_TYPEDEF_(0x80040009L)")]
    public const int OLE_E_CANT_GETMONIKER = unchecked((int)(0x80040009));

    [NativeTypeName("#define OLE_E_CANT_BINDTOSOURCE _HRESULT_TYPEDEF_(0x8004000AL)")]
    public const int OLE_E_CANT_BINDTOSOURCE = unchecked((int)(0x8004000A));

    [NativeTypeName("#define OLE_E_STATIC _HRESULT_TYPEDEF_(0x8004000BL)")]
    public const int OLE_E_STATIC = unchecked((int)(0x8004000B));

    [NativeTypeName("#define OLE_E_PROMPTSAVECANCELLED _HRESULT_TYPEDEF_(0x8004000CL)")]
    public const int OLE_E_PROMPTSAVECANCELLED = unchecked((int)(0x8004000C));

    [NativeTypeName("#define OLE_E_INVALIDRECT _HRESULT_TYPEDEF_(0x8004000DL)")]
    public const int OLE_E_INVALIDRECT = unchecked((int)(0x8004000D));

    [NativeTypeName("#define OLE_E_WRONGCOMPOBJ _HRESULT_TYPEDEF_(0x8004000EL)")]
    public const int OLE_E_WRONGCOMPOBJ = unchecked((int)(0x8004000E));

    [NativeTypeName("#define OLE_E_INVALIDHWND _HRESULT_TYPEDEF_(0x8004000FL)")]
    public const int OLE_E_INVALIDHWND = unchecked((int)(0x8004000F));

    [NativeTypeName("#define OLE_E_NOT_INPLACEACTIVE _HRESULT_TYPEDEF_(0x80040010L)")]
    public const int OLE_E_NOT_INPLACEACTIVE = unchecked((int)(0x80040010));

    [NativeTypeName("#define OLE_E_CANTCONVERT _HRESULT_TYPEDEF_(0x80040011L)")]
    public const int OLE_E_CANTCONVERT = unchecked((int)(0x80040011));

    [NativeTypeName("#define OLE_E_NOSTORAGE _HRESULT_TYPEDEF_(0x80040012L)")]
    public const int OLE_E_NOSTORAGE = unchecked((int)(0x80040012));

    [NativeTypeName("#define OLE_S_USEREG _HRESULT_TYPEDEF_(0x00040000L)")]
    public const int OLE_S_USEREG = ((int)(0x00040000));

    [NativeTypeName("#define OLE_S_STATIC _HRESULT_TYPEDEF_(0x00040001L)")]
    public const int OLE_S_STATIC = ((int)(0x00040001));

    [NativeTypeName("#define OLE_S_MAC_CLIPFORMAT _HRESULT_TYPEDEF_(0x00040002L)")]
    public const int OLE_S_MAC_CLIPFORMAT = ((int)(0x00040002));
}
