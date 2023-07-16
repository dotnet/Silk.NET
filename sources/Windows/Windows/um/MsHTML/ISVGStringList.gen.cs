// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList"]/*'/>
[Guid("305104C8-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGStringList : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGStringList : ISVGStringList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGStringList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGStringList*, Guid*, void**, int> )(lpVtbl[0]))((ISVGStringList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGStringList*, uint> )(lpVtbl[1]))((ISVGStringList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGStringList*, uint> )(lpVtbl[2]))((ISVGStringList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGStringList*, uint*, int> )(lpVtbl[3]))((ISVGStringList*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGStringList*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGStringList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGStringList*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGStringList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGStringList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGStringList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.put_numberOfItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_numberOfItems([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<ISVGStringList*, int, int> )(lpVtbl[7]))((ISVGStringList*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.get_numberOfItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_numberOfItems([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ISVGStringList*, int*, int> )(lpVtbl[8]))((ISVGStringList*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.clear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT clear()
    {
        return ((delegate* unmanaged<ISVGStringList*, int> )(lpVtbl[9]))((ISVGStringList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT initialize([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("BSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<ISVGStringList*, ushort*, ushort**, int> )(lpVtbl[10]))((ISVGStringList*)Unsafe.AsPointer(ref this), newItem, ppResult);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.getItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT getItem([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<ISVGStringList*, int, ushort**, int> )(lpVtbl[11]))((ISVGStringList*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.insertItemBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT insertItemBefore([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<ISVGStringList*, ushort*, int, ushort**, int> )(lpVtbl[12]))((ISVGStringList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.replaceItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT replaceItem([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<ISVGStringList*, ushort*, int, ushort**, int> )(lpVtbl[13]))((ISVGStringList*)Unsafe.AsPointer(ref this), newItem, index, ppResult);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.removeItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT removeItem([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<ISVGStringList*, int, ushort**, int> )(lpVtbl[14]))((ISVGStringList*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <include file='ISVGStringList.xml' path='doc/member[@name="ISVGStringList.appendItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT appendItem([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("BSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<ISVGStringList*, ushort*, ushort**, int> )(lpVtbl[15]))((ISVGStringList*)Unsafe.AsPointer(ref this), newItem, ppResult);
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
        HRESULT initialize([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("BSTR *")] ushort** ppResult);
        [VtblIndex(11)]
        HRESULT getItem([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult);
        [VtblIndex(12)]
        HRESULT insertItemBefore([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult);
        [VtblIndex(13)]
        HRESULT replaceItem([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult);
        [VtblIndex(14)]
        HRESULT removeItem([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** ppResult);
        [VtblIndex(15)]
        HRESULT appendItem([NativeTypeName("BSTR")] ushort* newItem, [NativeTypeName("BSTR *")] ushort** ppResult);
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
        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> initialize;
        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> getItem;
        [NativeTypeName("HRESULT (BSTR, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, ushort**, int> insertItemBefore;
        [NativeTypeName("HRESULT (BSTR, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, ushort**, int> replaceItem;
        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> removeItem;
        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> appendItem;
    }
}