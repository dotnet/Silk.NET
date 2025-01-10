// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct _wireVARIANT
{
    [NativeTypeName("DWORD")]
    public uint clSize;

    [NativeTypeName("DWORD")]
    public uint rpcReserved;
    public ushort vt;
    public ushort wReserved1;
    public ushort wReserved2;
    public ushort wReserved3;

    [NativeTypeName("__AnonymousRecord_oaidl_L581_C36")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref long llVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.llVal; }
    }

    [UnscopedRef]
    public ref int lVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lVal; }
    }

    [UnscopedRef]
    public ref byte bVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.bVal; }
    }

    [UnscopedRef]
    public ref short iVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.iVal; }
    }

    [UnscopedRef]
    public ref float fltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.fltVal; }
    }

    [UnscopedRef]
    public ref double dblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dblVal; }
    }

    [UnscopedRef]
    public ref short boolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.boolVal; }
    }

    [UnscopedRef]
    public ref int scode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.scode; }
    }

    [UnscopedRef]
    public ref CY cyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cyVal; }
    }

    [UnscopedRef]
    public ref double date
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.date; }
    }

    [UnscopedRef]
    public ref FLAGGED_WORD_BLOB* bstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.bstrVal; }
    }

    [UnscopedRef]
    public ref IUnknown punkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.punkVal; }
    }

    [UnscopedRef]
    public ref IDispatch pdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pdispVal; }
    }

    [UnscopedRef]
    public ref _wireSAFEARRAY** parray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.parray; }
    }

    [UnscopedRef]
    public ref _wireBRECORD* brecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.brecVal; }
    }

    [UnscopedRef]
    public ref byte* pbVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pbVal; }
    }

    [UnscopedRef]
    public ref short* piVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.piVal; }
    }

    [UnscopedRef]
    public ref int* plVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.plVal; }
    }

    [UnscopedRef]
    public ref long* pllVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pllVal; }
    }

    [UnscopedRef]
    public ref float* pfltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pfltVal; }
    }

    [UnscopedRef]
    public ref double* pdblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pdblVal; }
    }

    [UnscopedRef]
    public ref short* pboolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pboolVal; }
    }

    [UnscopedRef]
    public ref int* pscode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pscode; }
    }

    [UnscopedRef]
    public ref CY* pcyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pcyVal; }
    }

    [UnscopedRef]
    public ref double* pdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pdate; }
    }

    [UnscopedRef]
    public ref FLAGGED_WORD_BLOB** pbstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pbstrVal; }
    }

    [UnscopedRef]
    public ref IUnknown* ppunkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ppunkVal; }
    }

    [UnscopedRef]
    public ref IDispatch* ppdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ppdispVal; }
    }

    [UnscopedRef]
    public ref _wireSAFEARRAY*** pparray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pparray; }
    }

    [UnscopedRef]
    public ref _wireVARIANT** pvarVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pvarVal; }
    }

    [UnscopedRef]
    public ref sbyte cVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cVal; }
    }

    [UnscopedRef]
    public ref ushort uiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.uiVal; }
    }

    [UnscopedRef]
    public ref uint ulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ulVal; }
    }

    [UnscopedRef]
    public ref ulong ullVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ullVal; }
    }

    [UnscopedRef]
    public ref int intVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.intVal; }
    }

    [UnscopedRef]
    public ref uint uintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.uintVal; }
    }

    [UnscopedRef]
    public ref DECIMAL decVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.decVal; }
    }

    [UnscopedRef]
    public ref DECIMAL* pdecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pdecVal; }
    }

    [UnscopedRef]
    public ref sbyte* pcVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pcVal; }
    }

    [UnscopedRef]
    public ref ushort* puiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.puiVal; }
    }

    [UnscopedRef]
    public ref uint* pulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pulVal; }
    }

    [UnscopedRef]
    public ref ulong* pullVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pullVal; }
    }

    [UnscopedRef]
    public ref int* pintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pintVal; }
    }

    [UnscopedRef]
    public ref uint* puintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.puintVal; }
    }

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
        [NativeTypeName("SCODE")]
        public int scode;

        [FieldOffset(0)]
        public CY cyVal;

        [FieldOffset(0)]
        [NativeTypeName("DATE")]
        public double date;

        [FieldOffset(0)]
        [NativeTypeName("wireBSTR")]
        public FLAGGED_WORD_BLOB* bstrVal;

        [FieldOffset(0)]
        public IUnknown punkVal;

        [FieldOffset(0)]
        public IDispatch pdispVal;

        [FieldOffset(0)]
        [NativeTypeName("wirePSAFEARRAY")]
        public _wireSAFEARRAY** parray;

        [FieldOffset(0)]
        [NativeTypeName("wireBRECORD")]
        public _wireBRECORD* brecVal;

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
        [NativeTypeName("SCODE *")]
        public int* pscode;

        [FieldOffset(0)]
        public CY* pcyVal;

        [FieldOffset(0)]
        [NativeTypeName("DATE *")]
        public double* pdate;

        [FieldOffset(0)]
        [NativeTypeName("wireBSTR *")]
        public FLAGGED_WORD_BLOB** pbstrVal;

        [FieldOffset(0)]
        public IUnknown* ppunkVal;

        [FieldOffset(0)]
        public IDispatch* ppdispVal;

        [FieldOffset(0)]
        [NativeTypeName("wirePSAFEARRAY *")]
        public _wireSAFEARRAY*** pparray;

        [FieldOffset(0)]
        [NativeTypeName("wireVARIANT *")]
        public _wireVARIANT** pvarVal;

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
        public DECIMAL decVal;

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
    }
}
