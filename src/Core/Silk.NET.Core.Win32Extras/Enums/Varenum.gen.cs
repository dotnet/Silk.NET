// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "VARENUM")]
    public enum Varenum : int
    {
        [Obsolete("Deprecated in favour of \"Empty\"")]
        [NativeName("Name", "VT_EMPTY")]
        VTEmpty = 0x0,
        [Obsolete("Deprecated in favour of \"Null\"")]
        [NativeName("Name", "VT_NULL")]
        VTNull = 0x1,
        [Obsolete("Deprecated in favour of \"I2\"")]
        [NativeName("Name", "VT_I2")]
        VTI2 = 0x2,
        [Obsolete("Deprecated in favour of \"I4\"")]
        [NativeName("Name", "VT_I4")]
        VTI4 = 0x3,
        [Obsolete("Deprecated in favour of \"R4\"")]
        [NativeName("Name", "VT_R4")]
        VTR4 = 0x4,
        [Obsolete("Deprecated in favour of \"R8\"")]
        [NativeName("Name", "VT_R8")]
        VTR8 = 0x5,
        [Obsolete("Deprecated in favour of \"CY\"")]
        [NativeName("Name", "VT_CY")]
        VTCY = 0x6,
        [Obsolete("Deprecated in favour of \"Date\"")]
        [NativeName("Name", "VT_DATE")]
        VTDate = 0x7,
        [Obsolete("Deprecated in favour of \"Bstr\"")]
        [NativeName("Name", "VT_BSTR")]
        VTBstr = 0x8,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "VT_DISPATCH")]
        VTDispatch = 0x9,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "VT_ERROR")]
        VTError = 0xA,
        [Obsolete("Deprecated in favour of \"Bool\"")]
        [NativeName("Name", "VT_BOOL")]
        VTBool = 0xB,
        [Obsolete("Deprecated in favour of \"Variant\"")]
        [NativeName("Name", "VT_VARIANT")]
        VTVariant = 0xC,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "VT_UNKNOWN")]
        VTUnknown = 0xD,
        [Obsolete("Deprecated in favour of \"Decimal\"")]
        [NativeName("Name", "VT_DECIMAL")]
        VTDecimal = 0xE,
        [Obsolete("Deprecated in favour of \"I1\"")]
        [NativeName("Name", "VT_I1")]
        VTI1 = 0x10,
        [Obsolete("Deprecated in favour of \"UI1\"")]
        [NativeName("Name", "VT_UI1")]
        VTUI1 = 0x11,
        [Obsolete("Deprecated in favour of \"UI2\"")]
        [NativeName("Name", "VT_UI2")]
        VTUI2 = 0x12,
        [Obsolete("Deprecated in favour of \"UI4\"")]
        [NativeName("Name", "VT_UI4")]
        VTUI4 = 0x13,
        [Obsolete("Deprecated in favour of \"I8\"")]
        [NativeName("Name", "VT_I8")]
        VTI8 = 0x14,
        [Obsolete("Deprecated in favour of \"UI8\"")]
        [NativeName("Name", "VT_UI8")]
        VTUI8 = 0x15,
        [Obsolete("Deprecated in favour of \"Int\"")]
        [NativeName("Name", "VT_INT")]
        VTInt = 0x16,
        [Obsolete("Deprecated in favour of \"Uint\"")]
        [NativeName("Name", "VT_UINT")]
        VTUint = 0x17,
        [Obsolete("Deprecated in favour of \"Void\"")]
        [NativeName("Name", "VT_VOID")]
        VTVoid = 0x18,
        [Obsolete("Deprecated in favour of \"Hresult\"")]
        [NativeName("Name", "VT_HRESULT")]
        VTHresult = 0x19,
        [Obsolete("Deprecated in favour of \"Ptr\"")]
        [NativeName("Name", "VT_PTR")]
        VTPtr = 0x1A,
        [Obsolete("Deprecated in favour of \"Safearray\"")]
        [NativeName("Name", "VT_SAFEARRAY")]
        VTSafearray = 0x1B,
        [Obsolete("Deprecated in favour of \"Carray\"")]
        [NativeName("Name", "VT_CARRAY")]
        VTCarray = 0x1C,
        [Obsolete("Deprecated in favour of \"Userdefined\"")]
        [NativeName("Name", "VT_USERDEFINED")]
        VTUserdefined = 0x1D,
        [Obsolete("Deprecated in favour of \"Lpstr\"")]
        [NativeName("Name", "VT_LPSTR")]
        VTLpstr = 0x1E,
        [Obsolete("Deprecated in favour of \"Lpwstr\"")]
        [NativeName("Name", "VT_LPWSTR")]
        VTLpwstr = 0x1F,
        [Obsolete("Deprecated in favour of \"Record\"")]
        [NativeName("Name", "VT_RECORD")]
        VTRecord = 0x24,
        [Obsolete("Deprecated in favour of \"IntPtr\"")]
        [NativeName("Name", "VT_INT_PTR")]
        VTIntPtr = 0x25,
        [Obsolete("Deprecated in favour of \"UintPtr\"")]
        [NativeName("Name", "VT_UINT_PTR")]
        VTUintPtr = 0x26,
        [Obsolete("Deprecated in favour of \"Filetime\"")]
        [NativeName("Name", "VT_FILETIME")]
        VTFiletime = 0x40,
        [Obsolete("Deprecated in favour of \"Blob\"")]
        [NativeName("Name", "VT_BLOB")]
        VTBlob = 0x41,
        [Obsolete("Deprecated in favour of \"Stream\"")]
        [NativeName("Name", "VT_STREAM")]
        VTStream = 0x42,
        [Obsolete("Deprecated in favour of \"Storage\"")]
        [NativeName("Name", "VT_STORAGE")]
        VTStorage = 0x43,
        [Obsolete("Deprecated in favour of \"StreamedObject\"")]
        [NativeName("Name", "VT_STREAMED_OBJECT")]
        VTStreamedObject = 0x44,
        [Obsolete("Deprecated in favour of \"StoredObject\"")]
        [NativeName("Name", "VT_STORED_OBJECT")]
        VTStoredObject = 0x45,
        [Obsolete("Deprecated in favour of \"BlobObject\"")]
        [NativeName("Name", "VT_BLOB_OBJECT")]
        VTBlobObject = 0x46,
        [Obsolete("Deprecated in favour of \"CF\"")]
        [NativeName("Name", "VT_CF")]
        VTCF = 0x47,
        [Obsolete("Deprecated in favour of \"Clsid\"")]
        [NativeName("Name", "VT_CLSID")]
        VTClsid = 0x48,
        [Obsolete("Deprecated in favour of \"VersionedStream\"")]
        [NativeName("Name", "VT_VERSIONED_STREAM")]
        VTVersionedStream = 0x49,
        [Obsolete("Deprecated in favour of \"BstrBlob\"")]
        [NativeName("Name", "VT_BSTR_BLOB")]
        VTBstrBlob = 0xFFF,
        [Obsolete("Deprecated in favour of \"Vector\"")]
        [NativeName("Name", "VT_VECTOR")]
        VTVector = 0x1000,
        [Obsolete("Deprecated in favour of \"Array\"")]
        [NativeName("Name", "VT_ARRAY")]
        VTArray = 0x2000,
        [Obsolete("Deprecated in favour of \"Byref\"")]
        [NativeName("Name", "VT_BYREF")]
        VTByref = 0x4000,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "VT_RESERVED")]
        VTReserved = 0x8000,
        [Obsolete("Deprecated in favour of \"Illegal\"")]
        [NativeName("Name", "VT_ILLEGAL")]
        VTIllegal = 0xFFFF,
        [Obsolete("Deprecated in favour of \"Illegalmasked\"")]
        [NativeName("Name", "VT_ILLEGALMASKED")]
        VTIllegalmasked = 0xFFF,
        [Obsolete("Deprecated in favour of \"Typemask\"")]
        [NativeName("Name", "VT_TYPEMASK")]
        VTTypemask = 0xFFF,
        [NativeName("Name", "VT_EMPTY")]
        Empty = 0x0,
        [NativeName("Name", "VT_NULL")]
        Null = 0x1,
        [NativeName("Name", "VT_I2")]
        I2 = 0x2,
        [NativeName("Name", "VT_I4")]
        I4 = 0x3,
        [NativeName("Name", "VT_R4")]
        R4 = 0x4,
        [NativeName("Name", "VT_R8")]
        R8 = 0x5,
        [NativeName("Name", "VT_CY")]
        CY = 0x6,
        [NativeName("Name", "VT_DATE")]
        Date = 0x7,
        [NativeName("Name", "VT_BSTR")]
        Bstr = 0x8,
        [NativeName("Name", "VT_DISPATCH")]
        Dispatch = 0x9,
        [NativeName("Name", "VT_ERROR")]
        Error = 0xA,
        [NativeName("Name", "VT_BOOL")]
        Bool = 0xB,
        [NativeName("Name", "VT_VARIANT")]
        Variant = 0xC,
        [NativeName("Name", "VT_UNKNOWN")]
        Unknown = 0xD,
        [NativeName("Name", "VT_DECIMAL")]
        Decimal = 0xE,
        [NativeName("Name", "VT_I1")]
        I1 = 0x10,
        [NativeName("Name", "VT_UI1")]
        UI1 = 0x11,
        [NativeName("Name", "VT_UI2")]
        UI2 = 0x12,
        [NativeName("Name", "VT_UI4")]
        UI4 = 0x13,
        [NativeName("Name", "VT_I8")]
        I8 = 0x14,
        [NativeName("Name", "VT_UI8")]
        UI8 = 0x15,
        [NativeName("Name", "VT_INT")]
        Int = 0x16,
        [NativeName("Name", "VT_UINT")]
        Uint = 0x17,
        [NativeName("Name", "VT_VOID")]
        Void = 0x18,
        [NativeName("Name", "VT_HRESULT")]
        Hresult = 0x19,
        [NativeName("Name", "VT_PTR")]
        Ptr = 0x1A,
        [NativeName("Name", "VT_SAFEARRAY")]
        Safearray = 0x1B,
        [NativeName("Name", "VT_CARRAY")]
        Carray = 0x1C,
        [NativeName("Name", "VT_USERDEFINED")]
        Userdefined = 0x1D,
        [NativeName("Name", "VT_LPSTR")]
        Lpstr = 0x1E,
        [NativeName("Name", "VT_LPWSTR")]
        Lpwstr = 0x1F,
        [NativeName("Name", "VT_RECORD")]
        Record = 0x24,
        [NativeName("Name", "VT_INT_PTR")]
        IntPtr = 0x25,
        [NativeName("Name", "VT_UINT_PTR")]
        UintPtr = 0x26,
        [NativeName("Name", "VT_FILETIME")]
        Filetime = 0x40,
        [NativeName("Name", "VT_BLOB")]
        Blob = 0x41,
        [NativeName("Name", "VT_STREAM")]
        Stream = 0x42,
        [NativeName("Name", "VT_STORAGE")]
        Storage = 0x43,
        [NativeName("Name", "VT_STREAMED_OBJECT")]
        StreamedObject = 0x44,
        [NativeName("Name", "VT_STORED_OBJECT")]
        StoredObject = 0x45,
        [NativeName("Name", "VT_BLOB_OBJECT")]
        BlobObject = 0x46,
        [NativeName("Name", "VT_CF")]
        CF = 0x47,
        [NativeName("Name", "VT_CLSID")]
        Clsid = 0x48,
        [NativeName("Name", "VT_VERSIONED_STREAM")]
        VersionedStream = 0x49,
        [NativeName("Name", "VT_BSTR_BLOB")]
        BstrBlob = 0xFFF,
        [NativeName("Name", "VT_VECTOR")]
        Vector = 0x1000,
        [NativeName("Name", "VT_ARRAY")]
        Array = 0x2000,
        [NativeName("Name", "VT_BYREF")]
        Byref = 0x4000,
        [NativeName("Name", "VT_RESERVED")]
        Reserved = 0x8000,
        [NativeName("Name", "VT_ILLEGAL")]
        Illegal = 0xFFFF,
        [NativeName("Name", "VT_ILLEGALMASKED")]
        Illegalmasked = 0xFFF,
        [NativeName("Name", "VT_TYPEMASK")]
        Typemask = 0xFFF,
    }
}
