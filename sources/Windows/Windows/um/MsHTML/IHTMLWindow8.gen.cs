// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8"]/*'/>
[Guid("305107AB-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLWindow8 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLWindow8 : IHTMLWindow8.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLWindow8));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLWindow8*, uint> )(lpVtbl[1]))((IHTMLWindow8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLWindow8*, uint> )(lpVtbl[2]))((IHTMLWindow8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, uint*, int> )(lpVtbl[3]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointerdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_onmspointerdown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[7]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointerdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_onmspointerdown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[8]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointermove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_onmspointermove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[9]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointermove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_onmspointermove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[10]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointerup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_onmspointerup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[11]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointerup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_onmspointerup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[12]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointerover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onmspointerover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[13]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointerover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onmspointerover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[14]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointerout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_onmspointerout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[15]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointerout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_onmspointerout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[16]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointercancel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onmspointercancel(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[17]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointercancel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onmspointercancel(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[18]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmspointerhover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_onmspointerhover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[19]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmspointerhover"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_onmspointerhover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[20]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsgesturestart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_onmsgesturestart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[21]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsgesturestart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_onmsgesturestart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[22]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsgesturechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onmsgesturechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[23]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsgesturechange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onmsgesturechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[24]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsgestureend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onmsgestureend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[25]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsgestureend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onmsgestureend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[26]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsgesturehold"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_onmsgesturehold(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[27]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsgesturehold"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_onmsgesturehold(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[28]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsgesturetap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_onmsgesturetap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[29]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsgesturetap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_onmsgesturetap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[30]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsgesturedoubletap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onmsgesturedoubletap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[31]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsgesturedoubletap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onmsgesturedoubletap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[32]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onmsinertiastart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onmsinertiastart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[33]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onmsinertiastart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onmsinertiastart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[34]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_applicationCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_applicationCache(IHTMLApplicationCache** p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, IHTMLApplicationCache**, int> )(lpVtbl[35]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.put_onpopstate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_onpopstate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT, int> )(lpVtbl[36]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLWindow8.xml' path='doc/member[@name="IHTMLWindow8.get_onpopstate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_onpopstate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLWindow8*, VARIANT*, int> )(lpVtbl[37]))((IHTMLWindow8*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_onmspointerdown(VARIANT v);
        [VtblIndex(8)]
        HRESULT get_onmspointerdown(VARIANT* p);
        [VtblIndex(9)]
        HRESULT put_onmspointermove(VARIANT v);
        [VtblIndex(10)]
        HRESULT get_onmspointermove(VARIANT* p);
        [VtblIndex(11)]
        HRESULT put_onmspointerup(VARIANT v);
        [VtblIndex(12)]
        HRESULT get_onmspointerup(VARIANT* p);
        [VtblIndex(13)]
        HRESULT put_onmspointerover(VARIANT v);
        [VtblIndex(14)]
        HRESULT get_onmspointerover(VARIANT* p);
        [VtblIndex(15)]
        HRESULT put_onmspointerout(VARIANT v);
        [VtblIndex(16)]
        HRESULT get_onmspointerout(VARIANT* p);
        [VtblIndex(17)]
        HRESULT put_onmspointercancel(VARIANT v);
        [VtblIndex(18)]
        HRESULT get_onmspointercancel(VARIANT* p);
        [VtblIndex(19)]
        HRESULT put_onmspointerhover(VARIANT v);
        [VtblIndex(20)]
        HRESULT get_onmspointerhover(VARIANT* p);
        [VtblIndex(21)]
        HRESULT put_onmsgesturestart(VARIANT v);
        [VtblIndex(22)]
        HRESULT get_onmsgesturestart(VARIANT* p);
        [VtblIndex(23)]
        HRESULT put_onmsgesturechange(VARIANT v);
        [VtblIndex(24)]
        HRESULT get_onmsgesturechange(VARIANT* p);
        [VtblIndex(25)]
        HRESULT put_onmsgestureend(VARIANT v);
        [VtblIndex(26)]
        HRESULT get_onmsgestureend(VARIANT* p);
        [VtblIndex(27)]
        HRESULT put_onmsgesturehold(VARIANT v);
        [VtblIndex(28)]
        HRESULT get_onmsgesturehold(VARIANT* p);
        [VtblIndex(29)]
        HRESULT put_onmsgesturetap(VARIANT v);
        [VtblIndex(30)]
        HRESULT get_onmsgesturetap(VARIANT* p);
        [VtblIndex(31)]
        HRESULT put_onmsgesturedoubletap(VARIANT v);
        [VtblIndex(32)]
        HRESULT get_onmsgesturedoubletap(VARIANT* p);
        [VtblIndex(33)]
        HRESULT put_onmsinertiastart(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_onmsinertiastart(VARIANT* p);
        [VtblIndex(35)]
        HRESULT get_applicationCache(IHTMLApplicationCache** p);
        [VtblIndex(36)]
        HRESULT put_onpopstate(VARIANT v);
        [VtblIndex(37)]
        HRESULT get_onpopstate(VARIANT* p);
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
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerdown;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerdown;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointermove;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointermove;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerup;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerup;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerover;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerover;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerout;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerout;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointercancel;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointercancel;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerhover;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerhover;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturestart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturestart;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturechange;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturechange;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgestureend;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgestureend;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturehold;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturehold;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturetap;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturetap;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturedoubletap;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturedoubletap;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsinertiastart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsinertiastart;
        [NativeTypeName("HRESULT (IHTMLApplicationCache **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLApplicationCache**, int> get_applicationCache;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onpopstate;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onpopstate;
    }
}