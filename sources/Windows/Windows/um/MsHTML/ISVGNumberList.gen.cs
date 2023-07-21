// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList"]/*' />
[Guid("305104CD-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGNumberList : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGNumberList : ISVGNumberList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGNumberList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGNumberList*, Guid*, void**, int>)(lpVtbl[0]))((ISVGNumberList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGNumberList*, uint>)(lpVtbl[1]))((ISVGNumberList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGNumberList*, uint>)(lpVtbl[2]))((ISVGNumberList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGNumberList*, uint*, int>)(lpVtbl[3]))((ISVGNumberList*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGNumberList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGNumberList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGNumberList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGNumberList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGNumberList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGNumberList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.put_numberOfItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_numberOfItems([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ISVGNumberList*, int, int>)(lpVtbl[7]))((ISVGNumberList*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.get_numberOfItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_numberOfItems([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ISVGNumberList*, int*, int>)(lpVtbl[8]))((ISVGNumberList*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT clear()
    {
        return ((delegate* unmanaged<ISVGNumberList*, int>)(lpVtbl[9]))((ISVGNumberList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT initialize(ISVGNumber* newItem, ISVGNumber** ppResult)
    {
        return ((delegate* unmanaged<ISVGNumberList*, ISVGNumber*, ISVGNumber**, int>)(lpVtbl[10]))((ISVGNumberList*)Unsafe.AsPointer(ref this), newItem, ppResult);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.getItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getItem([NativeTypeName("long")] int index, ISVGNumber** ppResult)
    {
        return ((delegate* unmanaged<ISVGNumberList*, int, ISVGNumber**, int>)(lpVtbl[11]))((ISVGNumberList*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.insertItemBefore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT insertItemBefore(ISVGNumber* newItem, [NativeTypeName("long")] int index, ISVGNumber** ppResult)
    {
        return ((delegate* unmanaged<ISVGNumberList*, ISVGNumber*, int, ISVGNumber**, int>)(lpVtbl[12]))((ISVGNumberList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.replaceItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT replaceItem(ISVGNumber* newItem, [NativeTypeName("long")] int index, ISVGNumber** ppResult)
    {
        return ((delegate* unmanaged<ISVGNumberList*, ISVGNumber*, int, ISVGNumber**, int>)(lpVtbl[13]))((ISVGNumberList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.removeItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT removeItem([NativeTypeName("long")] int index, ISVGNumber** ppResult)
    {
        return ((delegate* unmanaged<ISVGNumberList*, int, ISVGNumber**, int>)(lpVtbl[14]))((ISVGNumberList*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <include file='ISVGNumberList.xml' path='doc/member[@name="ISVGNumberList.appendItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT appendItem(ISVGNumber* newItem, ISVGNumber** ppResult)
    {
        return ((delegate* unmanaged<ISVGNumberList*, ISVGNumber*, ISVGNumber**, int>)(lpVtbl[15]))((ISVGNumberList*)Unsafe.AsPointer(ref this), newItem, ppResult);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_numberOfItems([NativeTypeName("long")] int v);

        [VtblIndex(8)]
        HRESULT get_numberOfItems([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT clear();

        [VtblIndex(10)]
        HRESULT initialize(ISVGNumber* newItem, ISVGNumber** ppResult);

        [VtblIndex(11)]
        HRESULT getItem([NativeTypeName("long")] int index, ISVGNumber** ppResult);

        [VtblIndex(12)]
        HRESULT insertItemBefore(ISVGNumber* newItem, [NativeTypeName("long")] int index, ISVGNumber** ppResult);

        [VtblIndex(13)]
        HRESULT replaceItem(ISVGNumber* newItem, [NativeTypeName("long")] int index, ISVGNumber** ppResult);

        [VtblIndex(14)]
        HRESULT removeItem([NativeTypeName("long")] int index, ISVGNumber** ppResult);

        [VtblIndex(15)]
        HRESULT appendItem(ISVGNumber* newItem, ISVGNumber** ppResult);
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

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_numberOfItems;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_numberOfItems;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clear;

        [NativeTypeName("HRESULT (ISVGNumber *, ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGNumber*, ISVGNumber**, int> initialize;

        [NativeTypeName("HRESULT (long, ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGNumber**, int> getItem;

        [NativeTypeName("HRESULT (ISVGNumber *, long, ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGNumber*, int, ISVGNumber**, int> insertItemBefore;

        [NativeTypeName("HRESULT (ISVGNumber *, long, ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGNumber*, int, ISVGNumber**, int> replaceItem;

        [NativeTypeName("HRESULT (long, ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISVGNumber**, int> removeItem;

        [NativeTypeName("HRESULT (ISVGNumber *, ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGNumber*, ISVGNumber**, int> appendItem;
    }
}
