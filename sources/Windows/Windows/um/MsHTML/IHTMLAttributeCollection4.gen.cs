// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4"]/*'/>
[Guid("305106FA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAttributeCollection4 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAttributeCollection4 : IHTMLAttributeCollection4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAttributeCollection4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint> )(lpVtbl[1]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint> )(lpVtbl[2]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint*, int> )(lpVtbl[3]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.getNamedItemNS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getNamedItemNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int> )(lpVtbl[7]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pvarNS, bstrName, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.setNamedItemNS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setNamedItemNS(IHTMLDOMAttribute2* pNodeIn, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> )(lpVtbl[8]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pNodeIn, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.removeNamedItemNS"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeNamedItemNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int> )(lpVtbl[9]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pvarNS, bstrName, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.getNamedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, ushort*, IHTMLDOMAttribute2**, int> )(lpVtbl[10]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), bstrName, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.setNamedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT setNamedItem(IHTMLDOMAttribute2* pNodeIn, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> )(lpVtbl[11]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), pNodeIn, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.removeNamedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, ushort*, IHTMLDOMAttribute2**, int> )(lpVtbl[12]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), bstrName, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.item"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT item([NativeTypeName("long")] int index, IHTMLDOMAttribute2** ppNodeOut)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, int, IHTMLDOMAttribute2**, int> )(lpVtbl[13]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), index, ppNodeOut);
    }

    /// <include file='IHTMLAttributeCollection4.xml' path='doc/member[@name="IHTMLAttributeCollection4.get_length"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLAttributeCollection4*, int*, int> )(lpVtbl[14]))((IHTMLAttributeCollection4*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getNamedItemNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(8)]
        HRESULT setNamedItemNS(IHTMLDOMAttribute2* pNodeIn, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(9)]
        HRESULT removeNamedItemNS(VARIANT* pvarNS, [NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(10)]
        HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(11)]
        HRESULT setNamedItem(IHTMLDOMAttribute2* pNodeIn, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(12)]
        HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(13)]
        HRESULT item([NativeTypeName("long")] int index, IHTMLDOMAttribute2** ppNodeOut);
        [VtblIndex(14)]
        HRESULT get_length([NativeTypeName("long *")] int* p);
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
        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int> getNamedItemNS;
        [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> setNamedItemNS;
        [NativeTypeName("HRESULT (VARIANT *, BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, ushort*, IHTMLDOMAttribute2**, int> removeNamedItemNS;
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute2**, int> getNamedItem;
        [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> setNamedItem;
        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute2**, int> removeNamedItem;
        [NativeTypeName("HRESULT (long, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IHTMLDOMAttribute2**, int> item;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;
    }
}