// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct VARIANT
{
    [NativeTypeName("__AnonymousRecord_oaidl_L478_C5")]
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
    public ref long llVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.llVal; }
    }

    [UnscopedRef]
    public ref int lVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.lVal; }
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
    public ref ushort* bstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.bstrVal; }
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
    public ref SAFEARRAY* parray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.parray; }
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
    public ref int* plVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.plVal; }
    }

    [UnscopedRef]
    public ref long* pllVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pllVal; }
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
    public ref short* __OBSOLETE__VARIANT_PBOOL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_PBOOL; }
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
    public ref VARIANT* pvarVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pvarVal; }
    }

    [UnscopedRef]
    public ref void* byref
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.byref; }
    }

    [UnscopedRef]
    public ref sbyte cVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.cVal; }
    }

    [UnscopedRef]
    public ref ushort uiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.uiVal; }
    }

    [UnscopedRef]
    public ref uint ulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.ulVal; }
    }

    [UnscopedRef]
    public ref ulong ullVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.ullVal; }
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
    public ref DECIMAL* pdecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pdecVal; }
    }

    [UnscopedRef]
    public ref sbyte* pcVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pcVal; }
    }

    [UnscopedRef]
    public ref ushort* puiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.puiVal; }
    }

    [UnscopedRef]
    public ref uint* pulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pulVal; }
    }

    [UnscopedRef]
    public ref ulong* pullVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.pullVal; }
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
    public ref void* pvRecord
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.Anonymous.pvRecord; }
    }

    [UnscopedRef]
    public ref IRecordInfo pRecInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.Anonymous.pRecInfo; }
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
        [NativeTypeName("__AnonymousRecord_oaidl_L480_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public DECIMAL decVal;

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("VARTYPE")]
            public ushort vt;

            [NativeTypeName("WORD")]
            public ushort wReserved1;

            [NativeTypeName("WORD")]
            public ushort wReserved2;

            [NativeTypeName("WORD")]
            public ushort wReserved3;

            [NativeTypeName("__AnonymousRecord_oaidl_L486_C13")]
            public _Anonymous_e__Union Anonymous;

            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _Anonymous_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("LONGLONG")]
                public long llVal;

                [FieldOffset(0)]
                [NativeTypeName("LONG")]
                public int lVal;

                [FieldOffset(0)]
                public byte bVal;

                [FieldOffset(0)]
                public short iVal;

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
                [NativeTypeName("BSTR")]
                public ushort* bstrVal;

                [FieldOffset(0)]
                public IUnknown punkVal;

                [FieldOffset(0)]
                public IDispatch pdispVal;

                [FieldOffset(0)]
                public SAFEARRAY* parray;

                [FieldOffset(0)]
                public byte* pbVal;

                [FieldOffset(0)]
                public short* piVal;

                [FieldOffset(0)]
                [NativeTypeName("LONG *")]
                public int* plVal;

                [FieldOffset(0)]
                [NativeTypeName("LONGLONG *")]
                public long* pllVal;

                [FieldOffset(0)]
                public float* pfltVal;

                [FieldOffset(0)]
                public double* pdblVal;

                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL *")]
                public short* pboolVal;

                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL *")]
                public short* __OBSOLETE__VARIANT_PBOOL;

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
                public SAFEARRAY** pparray;

                [FieldOffset(0)]
                public VARIANT* pvarVal;

                [FieldOffset(0)]
                [NativeTypeName("PVOID")]
                public void* byref;

                [FieldOffset(0)]
                [NativeTypeName("CHAR")]
                public sbyte cVal;

                [FieldOffset(0)]
                public ushort uiVal;

                [FieldOffset(0)]
                [NativeTypeName("ULONG")]
                public uint ulVal;

                [FieldOffset(0)]
                [NativeTypeName("ULONGLONG")]
                public ulong ullVal;

                [FieldOffset(0)]
                public int intVal;

                [FieldOffset(0)]
                public uint uintVal;

                [FieldOffset(0)]
                public DECIMAL* pdecVal;

                [FieldOffset(0)]
                [NativeTypeName("CHAR *")]
                public sbyte* pcVal;

                [FieldOffset(0)]
                public ushort* puiVal;

                [FieldOffset(0)]
                [NativeTypeName("ULONG *")]
                public uint* pulVal;

                [FieldOffset(0)]
                [NativeTypeName("ULONGLONG *")]
                public ulong* pullVal;

                [FieldOffset(0)]
                public int* pintVal;

                [FieldOffset(0)]
                public uint* puintVal;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_oaidl_L533_C17")]
                public _Anonymous_e__Struct Anonymous;

                public unsafe partial struct _Anonymous_e__Struct
                {
                    [NativeTypeName("PVOID")]
                    public void* pvRecord;
                    public IRecordInfo pRecInfo;
                }
            }
        }
    }
}
