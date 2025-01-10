// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROPVARIANT
{
    [NativeTypeName("__AnonymousRecord_propidlbase_L303_C3")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ushort vt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.vt; }
    }

    [UnscopedRef]
    public ref ushort wReserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.wReserved1; }
    }

    [UnscopedRef]
    public ref ushort wReserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.wReserved2; }
    }

    [UnscopedRef]
    public ref ushort wReserved3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.wReserved3; }
    }

    [UnscopedRef]
    public ref sbyte cVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cVal; }
    }

    [UnscopedRef]
    public ref byte bVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.bVal; }
    }

    [UnscopedRef]
    public ref short iVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.iVal; }
    }

    [UnscopedRef]
    public ref ushort uiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.uiVal; }
    }

    [UnscopedRef]
    public ref int lVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.lVal; }
    }

    [UnscopedRef]
    public ref uint ulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.ulVal; }
    }

    [UnscopedRef]
    public ref int intVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.intVal; }
    }

    [UnscopedRef]
    public ref uint uintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.uintVal; }
    }

    [UnscopedRef]
    public ref LARGE_INTEGER hVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.hVal; }
    }

    [UnscopedRef]
    public ref ULARGE_INTEGER uhVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.uhVal; }
    }

    [UnscopedRef]
    public ref float fltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.fltVal; }
    }

    [UnscopedRef]
    public ref double dblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.dblVal; }
    }

    [UnscopedRef]
    public ref short boolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.boolVal; }
    }

    [UnscopedRef]
    public ref short __OBSOLETE__VARIANT_BOOL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_BOOL; }
    }

    [UnscopedRef]
    public ref int scode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.scode; }
    }

    [UnscopedRef]
    public ref CY cyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cyVal; }
    }

    [UnscopedRef]
    public ref double date
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.date; }
    }

    [UnscopedRef]
    public ref FILETIME filetime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.filetime; }
    }

    [UnscopedRef]
    public ref Guid* puuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.puuid; }
    }

    [UnscopedRef]
    public ref CLIPDATA* pclipdata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pclipdata; }
    }

    [UnscopedRef]
    public ref ushort* bstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.bstrVal; }
    }

    [UnscopedRef]
    public ref BSTRBLOB bstrblobVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.bstrblobVal; }
    }

    [UnscopedRef]
    public ref BLOB blob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.blob; }
    }

    [UnscopedRef]
    public ref sbyte* pszVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pszVal; }
    }

    [UnscopedRef]
    public ref ushort* pwszVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pwszVal; }
    }

    [UnscopedRef]
    public ref IUnknown punkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.punkVal; }
    }

    [UnscopedRef]
    public ref IDispatch pdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pdispVal; }
    }

    [UnscopedRef]
    public ref IStream pStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pStream; }
    }

    [UnscopedRef]
    public ref IStorage pStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pStorage; }
    }

    [UnscopedRef]
    public ref VERSIONEDSTREAM* pVersionedStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pVersionedStream; }
    }

    [UnscopedRef]
    public ref SAFEARRAY* parray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.parray; }
    }

    [UnscopedRef]
    public ref CAC cac
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cac; }
    }

    [UnscopedRef]
    public ref CAUB caub
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.caub; }
    }

    [UnscopedRef]
    public ref CAI cai
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cai; }
    }

    [UnscopedRef]
    public ref CAUI caui
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.caui; }
    }

    [UnscopedRef]
    public ref CAL cal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cal; }
    }

    [UnscopedRef]
    public ref CAUL caul
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.caul; }
    }

    [UnscopedRef]
    public ref CAH cah
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cah; }
    }

    [UnscopedRef]
    public ref CAUH cauh
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cauh; }
    }

    [UnscopedRef]
    public ref CAFLT caflt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.caflt; }
    }

    [UnscopedRef]
    public ref CADBL cadbl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cadbl; }
    }

    [UnscopedRef]
    public ref CABOOL cabool
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cabool; }
    }

    [UnscopedRef]
    public ref CASCODE cascode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cascode; }
    }

    [UnscopedRef]
    public ref CACY cacy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cacy; }
    }

    [UnscopedRef]
    public ref CADATE cadate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cadate; }
    }

    [UnscopedRef]
    public ref CAFILETIME cafiletime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cafiletime; }
    }

    [UnscopedRef]
    public ref CACLSID cauuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cauuid; }
    }

    [UnscopedRef]
    public ref CACLIPDATA caclipdata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.caclipdata; }
    }

    [UnscopedRef]
    public ref CABSTR cabstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cabstr; }
    }

    [UnscopedRef]
    public ref CABSTRBLOB cabstrblob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cabstrblob; }
    }

    [UnscopedRef]
    public ref CALPSTR calpstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.calpstr; }
    }

    [UnscopedRef]
    public ref CALPWSTR calpwstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.calpwstr; }
    }

    [UnscopedRef]
    public ref CAPROPVARIANT capropvar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.capropvar; }
    }

    [UnscopedRef]
    public ref sbyte* pcVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pcVal; }
    }

    [UnscopedRef]
    public ref byte* pbVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pbVal; }
    }

    [UnscopedRef]
    public ref short* piVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.piVal; }
    }

    [UnscopedRef]
    public ref ushort* puiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.puiVal; }
    }

    [UnscopedRef]
    public ref int* plVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.plVal; }
    }

    [UnscopedRef]
    public ref uint* pulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pulVal; }
    }

    [UnscopedRef]
    public ref int* pintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pintVal; }
    }

    [UnscopedRef]
    public ref uint* puintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.puintVal; }
    }

    [UnscopedRef]
    public ref float* pfltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pfltVal; }
    }

    [UnscopedRef]
    public ref double* pdblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pdblVal; }
    }

    [UnscopedRef]
    public ref short* pboolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pboolVal; }
    }

    [UnscopedRef]
    public ref DECIMAL* pdecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pdecVal; }
    }

    [UnscopedRef]
    public ref int* pscode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pscode; }
    }

    [UnscopedRef]
    public ref CY* pcyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pcyVal; }
    }

    [UnscopedRef]
    public ref double* pdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pdate; }
    }

    [UnscopedRef]
    public ref ushort** pbstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pbstrVal; }
    }

    [UnscopedRef]
    public ref IUnknown* ppunkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.ppunkVal; }
    }

    [UnscopedRef]
    public ref IDispatch* ppdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.ppdispVal; }
    }

    [UnscopedRef]
    public ref SAFEARRAY** pparray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pparray; }
    }

    [UnscopedRef]
    public ref PROPVARIANT* pvarVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pvarVal; }
    }

    [UnscopedRef]
    public ref DECIMAL decVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.decVal; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_propidlbase_L305_C1")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public DECIMAL decVal;

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("VARTYPE")]
            public ushort vt;

            [NativeTypeName("PROPVAR_PAD1")]
            public ushort wReserved1;

            [NativeTypeName("PROPVAR_PAD2")]
            public ushort wReserved2;

            [NativeTypeName("PROPVAR_PAD3")]
            public ushort wReserved3;

            [NativeTypeName("__AnonymousRecord_propidlbase_L311_C43")]
            public _Anonymous_e__Union Anonymous;

            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("CHAR")]
                public sbyte cVal;

                [FieldOffset(0)]
                [NativeTypeName("UCHAR")]
                public byte bVal;

                [FieldOffset(0)]
                public short iVal;

                [FieldOffset(0)]
                public ushort uiVal;

                [FieldOffset(0)]
                [NativeTypeName("LONG")]
                public int lVal;

                [FieldOffset(0)]
                [NativeTypeName("ULONG")]
                public uint ulVal;

                [FieldOffset(0)]
                public int intVal;

                [FieldOffset(0)]
                public uint uintVal;

                [FieldOffset(0)]
                public LARGE_INTEGER hVal;

                [FieldOffset(0)]
                public ULARGE_INTEGER uhVal;

                [FieldOffset(0)]
                public float fltVal;

                [FieldOffset(0)]
                public double dblVal;

                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL")]
                public short boolVal;

                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL")]
                public short __OBSOLETE__VARIANT_BOOL;

                [FieldOffset(0)]
                [NativeTypeName("SCODE")]
                public int scode;

                [FieldOffset(0)]
                public CY cyVal;

                [FieldOffset(0)]
                [NativeTypeName("DATE")]
                public double date;

                [FieldOffset(0)]
                public FILETIME filetime;

                [FieldOffset(0)]
                [NativeTypeName("CLSID *")]
                public Guid* puuid;

                [FieldOffset(0)]
                public CLIPDATA* pclipdata;

                [FieldOffset(0)]
                [NativeTypeName("BSTR")]
                public ushort* bstrVal;

                [FieldOffset(0)]
                public BSTRBLOB bstrblobVal;

                [FieldOffset(0)]
                public BLOB blob;

                [FieldOffset(0)]
                [NativeTypeName("LPSTR")]
                public sbyte* pszVal;

                [FieldOffset(0)]
                [NativeTypeName("LPWSTR")]
                public ushort* pwszVal;

                [FieldOffset(0)]
                public IUnknown punkVal;

                [FieldOffset(0)]
                public IDispatch pdispVal;

                [FieldOffset(0)]
                public IStream pStream;

                [FieldOffset(0)]
                public IStorage pStorage;

                [FieldOffset(0)]
                [NativeTypeName("LPVERSIONEDSTREAM")]
                public VERSIONEDSTREAM* pVersionedStream;

                [FieldOffset(0)]
                [NativeTypeName("LPSAFEARRAY")]
                public SAFEARRAY* parray;

                [FieldOffset(0)]
                public CAC cac;

                [FieldOffset(0)]
                public CAUB caub;

                [FieldOffset(0)]
                public CAI cai;

                [FieldOffset(0)]
                public CAUI caui;

                [FieldOffset(0)]
                public CAL cal;

                [FieldOffset(0)]
                public CAUL caul;

                [FieldOffset(0)]
                public CAH cah;

                [FieldOffset(0)]
                public CAUH cauh;

                [FieldOffset(0)]
                public CAFLT caflt;

                [FieldOffset(0)]
                public CADBL cadbl;

                [FieldOffset(0)]
                public CABOOL cabool;

                [FieldOffset(0)]
                public CASCODE cascode;

                [FieldOffset(0)]
                public CACY cacy;

                [FieldOffset(0)]
                public CADATE cadate;

                [FieldOffset(0)]
                public CAFILETIME cafiletime;

                [FieldOffset(0)]
                public CACLSID cauuid;

                [FieldOffset(0)]
                public CACLIPDATA caclipdata;

                [FieldOffset(0)]
                public CABSTR cabstr;

                [FieldOffset(0)]
                public CABSTRBLOB cabstrblob;

                [FieldOffset(0)]
                public CALPSTR calpstr;

                [FieldOffset(0)]
                public CALPWSTR calpwstr;

                [FieldOffset(0)]
                public CAPROPVARIANT capropvar;

                [FieldOffset(0)]
                [NativeTypeName("CHAR *")]
                public sbyte* pcVal;

                [FieldOffset(0)]
                [NativeTypeName("UCHAR *")]
                public byte* pbVal;

                [FieldOffset(0)]
                public short* piVal;

                [FieldOffset(0)]
                public ushort* puiVal;

                [FieldOffset(0)]
                [NativeTypeName("LONG *")]
                public int* plVal;

                [FieldOffset(0)]
                [NativeTypeName("ULONG *")]
                public uint* pulVal;

                [FieldOffset(0)]
                public int* pintVal;

                [FieldOffset(0)]
                public uint* puintVal;

                [FieldOffset(0)]
                public float* pfltVal;

                [FieldOffset(0)]
                public double* pdblVal;

                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL *")]
                public short* pboolVal;

                [FieldOffset(0)]
                public DECIMAL* pdecVal;

                [FieldOffset(0)]
                [NativeTypeName("SCODE *")]
                public int* pscode;

                [FieldOffset(0)]
                public CY* pcyVal;

                [FieldOffset(0)]
                [NativeTypeName("DATE *")]
                public double* pdate;

                [FieldOffset(0)]
                [NativeTypeName("BSTR *")]
                public ushort** pbstrVal;

                [FieldOffset(0)]
                public IUnknown* ppunkVal;

                [FieldOffset(0)]
                public IDispatch* ppdispVal;

                [FieldOffset(0)]
                [NativeTypeName("LPSAFEARRAY *")]
                public SAFEARRAY** pparray;

                [FieldOffset(0)]
                public PROPVARIANT* pvarVal;
            }
        }
    }
}
