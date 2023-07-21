// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent"]/*' />
[Guid("305104BA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMEvent : IDOMEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMEvent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMEvent*, uint>)(lpVtbl[1]))((IDOMEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMEvent*, uint>)(lpVtbl[2]))((IDOMEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMEvent*, uint*, int>)(lpVtbl[3]))((IDOMEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_bubbles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_bubbles([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, short*, int>)(lpVtbl[7]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_cancelable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_cancelable([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, short*, int>)(lpVtbl[8]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_currentTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_currentTarget(IEventTarget** p)
    {
        return ((delegate* unmanaged<IDOMEvent*, IEventTarget**, int>)(lpVtbl[9]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_defaultPrevented"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_defaultPrevented([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, short*, int>)(lpVtbl[10]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_eventPhase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_eventPhase(ushort* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, ushort*, int>)(lpVtbl[11]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_target"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_target(IEventTarget** p)
    {
        return ((delegate* unmanaged<IDOMEvent*, IEventTarget**, int>)(lpVtbl[12]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_timeStamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_timeStamp([NativeTypeName("ULONGLONG *")] ulong* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, ulong*, int>)(lpVtbl[13]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMEvent*, ushort**, int>)(lpVtbl[14]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.initEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT initEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable)
    {
        return ((delegate* unmanaged<IDOMEvent*, ushort*, short, short, int>)(lpVtbl[15]))((IDOMEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.preventDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT preventDefault()
    {
        return ((delegate* unmanaged<IDOMEvent*, int>)(lpVtbl[16]))((IDOMEvent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.stopPropagation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT stopPropagation()
    {
        return ((delegate* unmanaged<IDOMEvent*, int>)(lpVtbl[17]))((IDOMEvent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.stopImmediatePropagation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT stopImmediatePropagation()
    {
        return ((delegate* unmanaged<IDOMEvent*, int>)(lpVtbl[18]))((IDOMEvent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_isTrusted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_isTrusted([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, short*, int>)(lpVtbl[19]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.put_cancelBubble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IDOMEvent*, short, int>)(lpVtbl[20]))((IDOMEvent*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_cancelBubble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IDOMEvent*, short*, int>)(lpVtbl[21]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMEvent.xml' path='doc/member[@name="IDOMEvent.get_srcElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_srcElement(IHTMLElement** p)
    {
        return ((delegate* unmanaged<IDOMEvent*, IHTMLElement**, int>)(lpVtbl[22]))((IDOMEvent*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_bubbles([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(8)]
        HRESULT get_cancelable([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(9)]
        HRESULT get_currentTarget(IEventTarget** p);

        [VtblIndex(10)]
        HRESULT get_defaultPrevented([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(11)]
        HRESULT get_eventPhase(ushort* p);

        [VtblIndex(12)]
        HRESULT get_target(IEventTarget** p);

        [VtblIndex(13)]
        HRESULT get_timeStamp([NativeTypeName("ULONGLONG *")] ulong* p);

        [VtblIndex(14)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(15)]
        HRESULT initEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable);

        [VtblIndex(16)]
        HRESULT preventDefault();

        [VtblIndex(17)]
        HRESULT stopPropagation();

        [VtblIndex(18)]
        HRESULT stopImmediatePropagation();

        [VtblIndex(19)]
        HRESULT get_isTrusted([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(20)]
        HRESULT put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(21)]
        HRESULT get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(22)]
        HRESULT get_srcElement(IHTMLElement** p);
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

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_bubbles;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_cancelable;

        [NativeTypeName("HRESULT (IEventTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEventTarget**, int> get_currentTarget;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_defaultPrevented;

        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_eventPhase;

        [NativeTypeName("HRESULT (IEventTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEventTarget**, int> get_target;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_timeStamp;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, int> initEvent;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> preventDefault;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> stopPropagation;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> stopImmediatePropagation;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isTrusted;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_cancelBubble;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_cancelBubble;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement**, int> get_srcElement;
    }
}
