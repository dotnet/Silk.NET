// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow"]/*' />
[Guid("3050F23C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTableRow : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTableRow : IHTMLTableRow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTableRow));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTableRow*, uint>)(lpVtbl[1]))((IHTMLTableRow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTableRow*, uint>)(lpVtbl[2]))((IHTMLTableRow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, uint*, int>)(lpVtbl[3]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.put_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, ushort*, int>)(lpVtbl[7]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, ushort**, int>)(lpVtbl[8]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.put_vAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, ushort*, int>)(lpVtbl[9]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_vAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, ushort**, int>)(lpVtbl[10]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.put_bgColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[11]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_bgColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[12]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.put_borderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_borderColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[13]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_borderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_borderColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[14]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.put_borderColorLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_borderColorLight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[15]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_borderColorLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_borderColorLight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[16]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.put_borderColorDark"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_borderColorDark(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT, int>)(lpVtbl[17]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_borderColorDark"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_borderColorDark(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, VARIANT*, int>)(lpVtbl[18]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_rowIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_rowIndex([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, int*, int>)(lpVtbl[19]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_sectionRowIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_sectionRowIndex([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, int*, int>)(lpVtbl[20]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.get_cells"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_cells(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, IHTMLElementCollection**, int>)(lpVtbl[21]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.insertCell"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT insertCell([NativeTypeName("long")] int index, IDispatch** row)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, int, IDispatch**, int>)(lpVtbl[22]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), index, row);
    }

    /// <include file='IHTMLTableRow.xml' path='doc/member[@name="IHTMLTableRow.deleteCell"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT deleteCell([NativeTypeName("long")] int index = -1)
    {
        return ((delegate* unmanaged<IHTMLTableRow*, int, int>)(lpVtbl[23]))((IHTMLTableRow*)Unsafe.AsPointer(ref this), index);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_bgColor(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_bgColor(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_borderColor(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_borderColor(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_borderColorLight(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_borderColorLight(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_borderColorDark(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_borderColorDark(VARIANT* p);

        [VtblIndex(19)]
        HRESULT get_rowIndex([NativeTypeName("long *")] int* p);

        [VtblIndex(20)]
        HRESULT get_sectionRowIndex([NativeTypeName("long *")] int* p);

        [VtblIndex(21)]
        HRESULT get_cells(IHTMLElementCollection** p);

        [VtblIndex(22)]
        HRESULT insertCell([NativeTypeName("long")] int index, IDispatch** row);

        [VtblIndex(23)]
        HRESULT deleteCell([NativeTypeName("long")] int index = -1);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_vAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_vAlign;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorLight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorLight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderColorDark;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderColorDark;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_rowIndex;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_sectionRowIndex;

        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_cells;

        [NativeTypeName("HRESULT (long, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IDispatch**, int> insertCell;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> deleteCell;
    }
}
