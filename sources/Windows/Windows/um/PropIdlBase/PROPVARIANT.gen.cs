// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='PROPVARIANT.xml' path='doc/member[@name="PROPVARIANT"]/*' />
public unsafe partial struct PROPVARIANT
{
    /// <include file='PROPVARIANT.xml' path='doc/member[@name="PROPVARIANT.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_PropIdlBase_L303_C3")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.vt"]/*' />
    [UnscopedRef]
    public ref ushort vt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.vt;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved1"]/*' />
    [UnscopedRef]
    public ref ushort wReserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.wReserved1;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved2"]/*' />
    [UnscopedRef]
    public ref ushort wReserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.wReserved2;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved3"]/*' />
    [UnscopedRef]
    public ref ushort wReserved3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.wReserved3;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cVal"]/*' />
    [UnscopedRef]
    public ref sbyte cVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bVal"]/*' />
    [UnscopedRef]
    public ref byte bVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.bVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iVal"]/*' />
    [UnscopedRef]
    public ref short iVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.iVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uiVal"]/*' />
    [UnscopedRef]
    public ref ushort uiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.uiVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lVal"]/*' />
    [UnscopedRef]
    public ref int lVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.lVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulVal"]/*' />
    [UnscopedRef]
    public ref uint ulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.ulVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.intVal"]/*' />
    [UnscopedRef]
    public ref int intVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.intVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uintVal"]/*' />
    [UnscopedRef]
    public ref uint uintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.uintVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hVal"]/*' />
    [UnscopedRef]
    public ref LARGE_INTEGER hVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.hVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uhVal"]/*' />
    [UnscopedRef]
    public ref ULARGE_INTEGER uhVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.uhVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.fltVal"]/*' />
    [UnscopedRef]
    public ref float fltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.fltVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dblVal"]/*' />
    [UnscopedRef]
    public ref double dblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.dblVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.boolVal"]/*' />
    [UnscopedRef]
    public ref short boolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.boolVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.__OBSOLETE__VARIANT_BOOL"]/*' />
    [UnscopedRef]
    public ref short __OBSOLETE__VARIANT_BOOL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_BOOL;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.scode"]/*' />
    [UnscopedRef]
    public ref int scode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.scode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cyVal"]/*' />
    [UnscopedRef]
    public ref CY cyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cyVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.date"]/*' />
    [UnscopedRef]
    public ref double date
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.date;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.filetime"]/*' />
    [UnscopedRef]
    public ref FILETIME filetime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.filetime;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puuid"]/*' />
    [UnscopedRef]
    public ref Guid* puuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.puuid;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pclipdata"]/*' />
    [UnscopedRef]
    public ref CLIPDATA* pclipdata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pclipdata;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrVal"]/*' />
    [UnscopedRef]
    public ref ushort* bstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.bstrVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrblobVal"]/*' />
    [UnscopedRef]
    public ref BSTRBLOB bstrblobVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.bstrblobVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.blob"]/*' />
    [UnscopedRef]
    public ref BLOB blob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.blob;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszVal"]/*' />
    [UnscopedRef]
    public ref sbyte* pszVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pszVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszVal"]/*' />
    [UnscopedRef]
    public ref ushort* pwszVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pwszVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.punkVal"]/*' />
    [UnscopedRef]
    public ref IUnknown* punkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.punkVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdispVal"]/*' />
    [UnscopedRef]
    public ref IDispatch* pdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pdispVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStream"]/*' />
    [UnscopedRef]
    public ref IStream* pStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pStream;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStorage"]/*' />
    [UnscopedRef]
    public ref IStorage* pStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pStorage;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pVersionedStream"]/*' />
    [UnscopedRef]
    public ref VERSIONEDSTREAM* pVersionedStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pVersionedStream;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.parray"]/*' />
    [UnscopedRef]
    public ref SAFEARRAY* parray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.parray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cac"]/*' />
    [UnscopedRef]
    public ref CAC cac
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cac;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caub"]/*' />
    [UnscopedRef]
    public ref CAUB caub
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.caub;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cai"]/*' />
    [UnscopedRef]
    public ref CAI cai
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cai;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caui"]/*' />
    [UnscopedRef]
    public ref CAUI caui
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.caui;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cal"]/*' />
    [UnscopedRef]
    public ref CAL cal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caul"]/*' />
    [UnscopedRef]
    public ref CAUL caul
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.caul;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cah"]/*' />
    [UnscopedRef]
    public ref CAH cah
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cah;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauh"]/*' />
    [UnscopedRef]
    public ref CAUH cauh
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cauh;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caflt"]/*' />
    [UnscopedRef]
    public ref CAFLT caflt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.caflt;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadbl"]/*' />
    [UnscopedRef]
    public ref CADBL cadbl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cadbl;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabool"]/*' />
    [UnscopedRef]
    public ref CABOOL cabool
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cabool;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cascode"]/*' />
    [UnscopedRef]
    public ref CASCODE cascode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cascode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cacy"]/*' />
    [UnscopedRef]
    public ref CACY cacy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cacy;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadate"]/*' />
    [UnscopedRef]
    public ref CADATE cadate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cadate;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cafiletime"]/*' />
    [UnscopedRef]
    public ref CAFILETIME cafiletime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cafiletime;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauuid"]/*' />
    [UnscopedRef]
    public ref CACLSID cauuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cauuid;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caclipdata"]/*' />
    [UnscopedRef]
    public ref CACLIPDATA caclipdata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.caclipdata;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstr"]/*' />
    [UnscopedRef]
    public ref CABSTR cabstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cabstr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstrblob"]/*' />
    [UnscopedRef]
    public ref CABSTRBLOB cabstrblob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.cabstrblob;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpstr"]/*' />
    [UnscopedRef]
    public ref CALPSTR calpstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.calpstr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpwstr"]/*' />
    [UnscopedRef]
    public ref CALPWSTR calpwstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.calpwstr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.capropvar"]/*' />
    [UnscopedRef]
    public ref CAPROPVARIANT capropvar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.capropvar;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcVal"]/*' />
    [UnscopedRef]
    public ref sbyte* pcVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pcVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbVal"]/*' />
    [UnscopedRef]
    public ref byte* pbVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pbVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.piVal"]/*' />
    [UnscopedRef]
    public ref short* piVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.piVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puiVal"]/*' />
    [UnscopedRef]
    public ref ushort* puiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.puiVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.plVal"]/*' />
    [UnscopedRef]
    public ref int* plVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.plVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pulVal"]/*' />
    [UnscopedRef]
    public ref uint* pulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pulVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pintVal"]/*' />
    [UnscopedRef]
    public ref int* pintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pintVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puintVal"]/*' />
    [UnscopedRef]
    public ref uint* puintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.puintVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pfltVal"]/*' />
    [UnscopedRef]
    public ref float* pfltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pfltVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdblVal"]/*' />
    [UnscopedRef]
    public ref double* pdblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pdblVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pboolVal"]/*' />
    [UnscopedRef]
    public ref short* pboolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pboolVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdecVal"]/*' />
    [UnscopedRef]
    public ref DECIMAL* pdecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pdecVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pscode"]/*' />
    [UnscopedRef]
    public ref int* pscode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pscode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcyVal"]/*' />
    [UnscopedRef]
    public ref CY* pcyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pcyVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdate"]/*' />
    [UnscopedRef]
    public ref double* pdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pdate;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbstrVal"]/*' />
    [UnscopedRef]
    public ref ushort** pbstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pbstrVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppunkVal"]/*' />
    [UnscopedRef]
    public ref IUnknown** ppunkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.ppunkVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppdispVal"]/*' />
    [UnscopedRef]
    public ref IDispatch** ppdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.ppdispVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pparray"]/*' />
    [UnscopedRef]
    public ref SAFEARRAY** pparray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pparray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvarVal"]/*' />
    [UnscopedRef]
    public ref PROPVARIANT* pvarVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Anonymous.pvarVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.decVal"]/*' />
    [UnscopedRef]
    public ref DECIMAL decVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.decVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_PropIdlBase_L305_C1")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.decVal"]/*' />
        [FieldOffset(0)]
        public DECIMAL decVal;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public unsafe partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.vt"]/*' />
            [NativeTypeName("VARTYPE")]
            public ushort vt;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved1"]/*' />
            [NativeTypeName("PROPVAR_PAD1")]
            public ushort wReserved1;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved2"]/*' />
            [NativeTypeName("PROPVAR_PAD2")]
            public ushort wReserved2;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved3"]/*' />
            [NativeTypeName("PROPVAR_PAD3")]
            public ushort wReserved3;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Anonymous"]/*' />
            [NativeTypeName("__AnonymousRecord_PropIdlBase_L311_C43")]
            public _Anonymous_e__Union Anonymous;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _Anonymous_e__Union
            {
                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CHAR")]
                public sbyte cVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("UCHAR")]
                public byte bVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iVal"]/*' />
                [FieldOffset(0)]
                public short iVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uiVal"]/*' />
                [FieldOffset(0)]
                public ushort uiVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONG")]
                public int lVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONG")]
                public uint ulVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.intVal"]/*' />
                [FieldOffset(0)]
                public int intVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uintVal"]/*' />
                [FieldOffset(0)]
                public uint uintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hVal"]/*' />
                [FieldOffset(0)]
                public LARGE_INTEGER hVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uhVal"]/*' />
                [FieldOffset(0)]
                public ULARGE_INTEGER uhVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.fltVal"]/*' />
                [FieldOffset(0)]
                public float fltVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dblVal"]/*' />
                [FieldOffset(0)]
                public double dblVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.boolVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL")]
                public short boolVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.__OBSOLETE__VARIANT_BOOL"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL")]
                public short __OBSOLETE__VARIANT_BOOL;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.scode"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("SCODE")]
                public int scode;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cyVal"]/*' />
                [FieldOffset(0)]
                public CY cyVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.date"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("DATE")]
                public double date;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.filetime"]/*' />
                [FieldOffset(0)]
                public FILETIME filetime;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puuid"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CLSID *")]
                public Guid* puuid;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pclipdata"]/*' />
                [FieldOffset(0)]
                public CLIPDATA* pclipdata;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("BSTR")]
                public ushort* bstrVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrblobVal"]/*' />
                [FieldOffset(0)]
                public BSTRBLOB bstrblobVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.blob"]/*' />
                [FieldOffset(0)]
                public BLOB blob;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPSTR")]
                public sbyte* pszVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPWSTR")]
                public ushort* pwszVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.punkVal"]/*' />
                [FieldOffset(0)]
                public IUnknown* punkVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdispVal"]/*' />
                [FieldOffset(0)]
                public IDispatch* pdispVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStream"]/*' />
                [FieldOffset(0)]
                public IStream* pStream;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStorage"]/*' />
                [FieldOffset(0)]
                public IStorage* pStorage;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pVersionedStream"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPVERSIONEDSTREAM")]
                public VERSIONEDSTREAM* pVersionedStream;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.parray"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPSAFEARRAY")]
                public SAFEARRAY* parray;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cac"]/*' />
                [FieldOffset(0)]
                public CAC cac;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caub"]/*' />
                [FieldOffset(0)]
                public CAUB caub;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cai"]/*' />
                [FieldOffset(0)]
                public CAI cai;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caui"]/*' />
                [FieldOffset(0)]
                public CAUI caui;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cal"]/*' />
                [FieldOffset(0)]
                public CAL cal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caul"]/*' />
                [FieldOffset(0)]
                public CAUL caul;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cah"]/*' />
                [FieldOffset(0)]
                public CAH cah;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauh"]/*' />
                [FieldOffset(0)]
                public CAUH cauh;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caflt"]/*' />
                [FieldOffset(0)]
                public CAFLT caflt;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadbl"]/*' />
                [FieldOffset(0)]
                public CADBL cadbl;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabool"]/*' />
                [FieldOffset(0)]
                public CABOOL cabool;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cascode"]/*' />
                [FieldOffset(0)]
                public CASCODE cascode;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cacy"]/*' />
                [FieldOffset(0)]
                public CACY cacy;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadate"]/*' />
                [FieldOffset(0)]
                public CADATE cadate;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cafiletime"]/*' />
                [FieldOffset(0)]
                public CAFILETIME cafiletime;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauuid"]/*' />
                [FieldOffset(0)]
                public CACLSID cauuid;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caclipdata"]/*' />
                [FieldOffset(0)]
                public CACLIPDATA caclipdata;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstr"]/*' />
                [FieldOffset(0)]
                public CABSTR cabstr;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstrblob"]/*' />
                [FieldOffset(0)]
                public CABSTRBLOB cabstrblob;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpstr"]/*' />
                [FieldOffset(0)]
                public CALPSTR calpstr;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpwstr"]/*' />
                [FieldOffset(0)]
                public CALPWSTR calpwstr;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.capropvar"]/*' />
                [FieldOffset(0)]
                public CAPROPVARIANT capropvar;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CHAR *")]
                public sbyte* pcVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("UCHAR *")]
                public byte* pbVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.piVal"]/*' />
                [FieldOffset(0)]
                public short* piVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puiVal"]/*' />
                [FieldOffset(0)]
                public ushort* puiVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.plVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONG *")]
                public int* plVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pulVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONG *")]
                public uint* pulVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pintVal"]/*' />
                [FieldOffset(0)]
                public int* pintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puintVal"]/*' />
                [FieldOffset(0)]
                public uint* puintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pfltVal"]/*' />
                [FieldOffset(0)]
                public float* pfltVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdblVal"]/*' />
                [FieldOffset(0)]
                public double* pdblVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pboolVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL *")]
                public short* pboolVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdecVal"]/*' />
                [FieldOffset(0)]
                public DECIMAL* pdecVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pscode"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("SCODE *")]
                public int* pscode;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcyVal"]/*' />
                [FieldOffset(0)]
                public CY* pcyVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdate"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("DATE *")]
                public double* pdate;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbstrVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("BSTR *")]
                public ushort** pbstrVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppunkVal"]/*' />
                [FieldOffset(0)]
                public IUnknown** ppunkVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppdispVal"]/*' />
                [FieldOffset(0)]
                public IDispatch** ppdispVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pparray"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPSAFEARRAY *")]
                public SAFEARRAY** pparray;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvarVal"]/*' />
                [FieldOffset(0)]
                public PROPVARIANT* pvarVal;
            }
        }
    }
}
