// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VARENUM.xml' path='doc/member[@name="VARENUM"]/*'/>
public enum VARENUM
{
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_EMPTY"]/*'/>
    VT_EMPTY = 0,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_NULL"]/*'/>
    VT_NULL = 1,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_I2"]/*'/>
    VT_I2 = 2,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_I4"]/*'/>
    VT_I4 = 3,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_R4"]/*'/>
    VT_R4 = 4,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_R8"]/*'/>
    VT_R8 = 5,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_CY"]/*'/>
    VT_CY = 6,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_DATE"]/*'/>
    VT_DATE = 7,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_BSTR"]/*'/>
    VT_BSTR = 8,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_DISPATCH"]/*'/>
    VT_DISPATCH = 9,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_ERROR"]/*'/>
    VT_ERROR = 10,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_BOOL"]/*'/>
    VT_BOOL = 11,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_VARIANT"]/*'/>
    VT_VARIANT = 12,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UNKNOWN"]/*'/>
    VT_UNKNOWN = 13,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_DECIMAL"]/*'/>
    VT_DECIMAL = 14,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_I1"]/*'/>
    VT_I1 = 16,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UI1"]/*'/>
    VT_UI1 = 17,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UI2"]/*'/>
    VT_UI2 = 18,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UI4"]/*'/>
    VT_UI4 = 19,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_I8"]/*'/>
    VT_I8 = 20,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UI8"]/*'/>
    VT_UI8 = 21,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_INT"]/*'/>
    VT_INT = 22,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UINT"]/*'/>
    VT_UINT = 23,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_VOID"]/*'/>
    VT_VOID = 24,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_HRESULT"]/*'/>
    VT_HRESULT = 25,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_PTR"]/*'/>
    VT_PTR = 26,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_SAFEARRAY"]/*'/>
    VT_SAFEARRAY = 27,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_CARRAY"]/*'/>
    VT_CARRAY = 28,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_USERDEFINED"]/*'/>
    VT_USERDEFINED = 29,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_LPSTR"]/*'/>
    VT_LPSTR = 30,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_LPWSTR"]/*'/>
    VT_LPWSTR = 31,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_RECORD"]/*'/>
    VT_RECORD = 36,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_INT_PTR"]/*'/>
    VT_INT_PTR = 37,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_UINT_PTR"]/*'/>
    VT_UINT_PTR = 38,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_FILETIME"]/*'/>
    VT_FILETIME = 64,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_BLOB"]/*'/>
    VT_BLOB = 65,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_STREAM"]/*'/>
    VT_STREAM = 66,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_STORAGE"]/*'/>
    VT_STORAGE = 67,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_STREAMED_OBJECT"]/*'/>
    VT_STREAMED_OBJECT = 68,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_STORED_OBJECT"]/*'/>
    VT_STORED_OBJECT = 69,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_BLOB_OBJECT"]/*'/>
    VT_BLOB_OBJECT = 70,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_CF"]/*'/>
    VT_CF = 71,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_CLSID"]/*'/>
    VT_CLSID = 72,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_VERSIONED_STREAM"]/*'/>
    VT_VERSIONED_STREAM = 73,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_BSTR_BLOB"]/*'/>
    VT_BSTR_BLOB = 0xfff,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_VECTOR"]/*'/>
    VT_VECTOR = 0x1000,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_ARRAY"]/*'/>
    VT_ARRAY = 0x2000,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_BYREF"]/*'/>
    VT_BYREF = 0x4000,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_RESERVED"]/*'/>
    VT_RESERVED = 0x8000,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_ILLEGAL"]/*'/>
    VT_ILLEGAL = 0xffff,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_ILLEGALMASKED"]/*'/>
    VT_ILLEGALMASKED = 0xfff,
    /// <include file='VARENUM.xml' path='doc/member[@name="VARENUM.VT_TYPEMASK"]/*'/>
    VT_TYPEMASK = 0xfff,
}