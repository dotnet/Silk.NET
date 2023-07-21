// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl"]/*' />
[Guid("A5170870-0CF8-11D1-8B91-0080C744F389")]
[NativeTypeName("struct IWBScriptControl : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IWBScriptControl : IWBScriptControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWBScriptControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWBScriptControl*, Guid*, void**, int>)(lpVtbl[0]))((IWBScriptControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWBScriptControl*, uint>)(lpVtbl[1]))((IWBScriptControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWBScriptControl*, uint>)(lpVtbl[2]))((IWBScriptControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWBScriptControl*, uint*, int>)(lpVtbl[3]))((IWBScriptControl*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IWBScriptControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWBScriptControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IWBScriptControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWBScriptControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IWBScriptControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWBScriptControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.raiseEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT raiseEvent([NativeTypeName("BSTR")] ushort* name, VARIANT eventData)
    {
        return ((delegate* unmanaged<IWBScriptControl*, ushort*, VARIANT, int>)(lpVtbl[7]))((IWBScriptControl*)Unsafe.AsPointer(ref this), name, eventData);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.bubbleEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT bubbleEvent()
    {
        return ((delegate* unmanaged<IWBScriptControl*, int>)(lpVtbl[8]))((IWBScriptControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.setContextMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT setContextMenu(VARIANT menuItemPairs)
    {
        return ((delegate* unmanaged<IWBScriptControl*, VARIANT, int>)(lpVtbl[9]))((IWBScriptControl*)Unsafe.AsPointer(ref this), menuItemPairs);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.put_selectableContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_selectableContent([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IWBScriptControl*, short, int>)(lpVtbl[10]))((IWBScriptControl*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.get_selectableContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_selectableContent([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[11]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.get_frozen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_frozen([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[12]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.put_scrollbar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_scrollbar([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IWBScriptControl*, short, int>)(lpVtbl[13]))((IWBScriptControl*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.get_scrollbar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_scrollbar([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[14]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.get_version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_version([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IWBScriptControl*, ushort**, int>)(lpVtbl[15]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.get_visibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_visibility([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[16]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.put_onvisibilitychange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onvisibilitychange(VARIANT v)
    {
        return ((delegate* unmanaged<IWBScriptControl*, VARIANT, int>)(lpVtbl[17]))((IWBScriptControl*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IWBScriptControl.xml' path='doc/member[@name="IWBScriptControl.get_onvisibilitychange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onvisibilitychange(VARIANT* p)
    {
        return ((delegate* unmanaged<IWBScriptControl*, VARIANT*, int>)(lpVtbl[18]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT raiseEvent([NativeTypeName("BSTR")] ushort* name, VARIANT eventData);

        [VtblIndex(8)]
        HRESULT bubbleEvent();

        [VtblIndex(9)]
        HRESULT setContextMenu(VARIANT menuItemPairs);

        [VtblIndex(10)]
        HRESULT put_selectableContent([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(11)]
        HRESULT get_selectableContent([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(12)]
        HRESULT get_frozen([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(13)]
        HRESULT put_scrollbar([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(14)]
        HRESULT get_scrollbar([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(15)]
        HRESULT get_version([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(16)]
        HRESULT get_visibility([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(17)]
        HRESULT put_onvisibilitychange(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_onvisibilitychange(VARIANT* p);
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

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> raiseEvent;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> bubbleEvent;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> setContextMenu;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_selectableContent;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_selectableContent;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_frozen;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_scrollbar;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_scrollbar;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_version;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_visibility;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onvisibilitychange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onvisibilitychange;
    }
}
