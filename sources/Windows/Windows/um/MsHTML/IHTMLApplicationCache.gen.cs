// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache"]/*'/>
[Guid("30510828-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLApplicationCache : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLApplicationCache : IHTMLApplicationCache.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLApplicationCache));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, uint> )(lpVtbl[1]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, uint> )(lpVtbl[2]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, uint*, int> )(lpVtbl[3]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_status"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_status([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, int*, int> )(lpVtbl[7]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_onchecking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_onchecking(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[8]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_onchecking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_onchecking(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[9]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[10]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[11]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_onnoupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_onnoupdate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[12]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_onnoupdate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_onnoupdate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[13]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_ondownloading"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ondownloading(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[14]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_ondownloading"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ondownloading(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[15]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_onprogress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_onprogress(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[16]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_onprogress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_onprogress(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[17]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_onupdateready"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_onupdateready(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[18]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_onupdateready"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_onupdateready(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[19]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_oncached"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_oncached(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[20]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_oncached"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_oncached(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[21]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.put_onobsolete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_onobsolete(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int> )(lpVtbl[22]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.get_onobsolete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_onobsolete(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int> )(lpVtbl[23]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.update"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT update()
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, int> )(lpVtbl[24]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.swapCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT swapCache()
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, int> )(lpVtbl[25]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLApplicationCache.xml' path='doc/member[@name="IHTMLApplicationCache.abort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT abort()
    {
        return ((delegate* unmanaged<IHTMLApplicationCache*, int> )(lpVtbl[26]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_status([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT put_onchecking(VARIANT v);
        [VtblIndex(9)]
        HRESULT get_onchecking(VARIANT* p);
        [VtblIndex(10)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(11)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(12)]
        HRESULT put_onnoupdate(VARIANT v);
        [VtblIndex(13)]
        HRESULT get_onnoupdate(VARIANT* p);
        [VtblIndex(14)]
        HRESULT put_ondownloading(VARIANT v);
        [VtblIndex(15)]
        HRESULT get_ondownloading(VARIANT* p);
        [VtblIndex(16)]
        HRESULT put_onprogress(VARIANT v);
        [VtblIndex(17)]
        HRESULT get_onprogress(VARIANT* p);
        [VtblIndex(18)]
        HRESULT put_onupdateready(VARIANT v);
        [VtblIndex(19)]
        HRESULT get_onupdateready(VARIANT* p);
        [VtblIndex(20)]
        HRESULT put_oncached(VARIANT v);
        [VtblIndex(21)]
        HRESULT get_oncached(VARIANT* p);
        [VtblIndex(22)]
        HRESULT put_onobsolete(VARIANT v);
        [VtblIndex(23)]
        HRESULT get_onobsolete(VARIANT* p);
        [VtblIndex(24)]
        HRESULT update();
        [VtblIndex(25)]
        HRESULT swapCache();
        [VtblIndex(26)]
        HRESULT abort();
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
        public delegate* unmanaged<TSelf*, int*, int> get_status;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onchecking;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onchecking;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onnoupdate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onnoupdate;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondownloading;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondownloading;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onprogress;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onprogress;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onupdateready;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onupdateready;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_oncached;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_oncached;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onobsolete;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onobsolete;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> update;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> swapCache;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> abort;
    }
}