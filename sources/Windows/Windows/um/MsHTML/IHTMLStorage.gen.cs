// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage"]/*'/>
[Guid("30510474-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStorage : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStorage : IHTMLStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStorage));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStorage*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStorage*, uint> )(lpVtbl[1]))((IHTMLStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStorage*, uint> )(lpVtbl[2]))((IHTMLStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStorage*, uint*, int> )(lpVtbl[3]))((IHTMLStorage*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStorage*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLStorage*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStorage*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLStorage*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStorage*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLStorage*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.get_length"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStorage*, int*, int> )(lpVtbl[7]))((IHTMLStorage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.get_remainingSpace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_remainingSpace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStorage*, int*, int> )(lpVtbl[8]))((IHTMLStorage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.key"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT key([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLStorage0000)
    {
        return ((delegate* unmanaged<IHTMLStorage*, int, ushort**, int> )(lpVtbl[9]))((IHTMLStorage*)Unsafe.AsPointer(ref this), lIndex, __MIDL__IHTMLStorage0000);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.getItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getItem([NativeTypeName("BSTR")] ushort* bstrKey, VARIANT* __MIDL__IHTMLStorage0001)
    {
        return ((delegate* unmanaged<IHTMLStorage*, ushort*, VARIANT*, int> )(lpVtbl[10]))((IHTMLStorage*)Unsafe.AsPointer(ref this), bstrKey, __MIDL__IHTMLStorage0001);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.setItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT setItem([NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("BSTR")] ushort* bstrValue)
    {
        return ((delegate* unmanaged<IHTMLStorage*, ushort*, ushort*, int> )(lpVtbl[11]))((IHTMLStorage*)Unsafe.AsPointer(ref this), bstrKey, bstrValue);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.removeItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT removeItem([NativeTypeName("BSTR")] ushort* bstrKey)
    {
        return ((delegate* unmanaged<IHTMLStorage*, ushort*, int> )(lpVtbl[12]))((IHTMLStorage*)Unsafe.AsPointer(ref this), bstrKey);
    }

    /// <include file='IHTMLStorage.xml' path='doc/member[@name="IHTMLStorage.clear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT clear()
    {
        return ((delegate* unmanaged<IHTMLStorage*, int> )(lpVtbl[13]))((IHTMLStorage*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_length([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT get_remainingSpace([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT key([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLStorage0000);
        [VtblIndex(10)]
        HRESULT getItem([NativeTypeName("BSTR")] ushort* bstrKey, VARIANT* __MIDL__IHTMLStorage0001);
        [VtblIndex(11)]
        HRESULT setItem([NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("BSTR")] ushort* bstrValue);
        [VtblIndex(12)]
        HRESULT removeItem([NativeTypeName("BSTR")] ushort* bstrKey);
        [VtblIndex(13)]
        HRESULT clear();
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
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_remainingSpace;
        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> key;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getItem;
        [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> setItem;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> removeItem;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clear;
    }
}