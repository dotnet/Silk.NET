// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDOMWheelEvent.xml' path='doc/member[@name="IDOMWheelEvent"]/*' />
[Guid("305106D2-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMWheelEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMWheelEvent : IDOMWheelEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMWheelEvent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, uint>)(lpVtbl[1]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, uint>)(lpVtbl[2]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, uint*, int>)(lpVtbl[3]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMWheelEvent.xml' path='doc/member[@name="IDOMWheelEvent.get_deltaX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_deltaX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, int*, int>)(lpVtbl[7]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMWheelEvent.xml' path='doc/member[@name="IDOMWheelEvent.get_deltaY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_deltaY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, int*, int>)(lpVtbl[8]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMWheelEvent.xml' path='doc/member[@name="IDOMWheelEvent.get_deltaZ"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_deltaZ([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, int*, int>)(lpVtbl[9]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMWheelEvent.xml' path='doc/member[@name="IDOMWheelEvent.get_deltaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_deltaMode([NativeTypeName("ULONG *")] uint* p)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, uint*, int>)(lpVtbl[10]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMWheelEvent.xml' path='doc/member[@name="IDOMWheelEvent.initWheelEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT initWheelEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, ushort buttonArg, IEventTarget* relatedTargetArg, [NativeTypeName("BSTR")] ushort* modifiersListArg, [NativeTypeName("long")] int deltaX, [NativeTypeName("long")] int deltaY, [NativeTypeName("long")] int deltaZ, [NativeTypeName("ULONG")] uint deltaMode)
    {
        return ((delegate* unmanaged<IDOMWheelEvent*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, ushort, IEventTarget*, ushort*, int, int, int, uint, int>)(lpVtbl[11]))((IDOMWheelEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, buttonArg, relatedTargetArg, modifiersListArg, deltaX, deltaY, deltaZ, deltaMode);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_deltaX([NativeTypeName("long *")] int* p);

        [VtblIndex(8)]
        HRESULT get_deltaY([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT get_deltaZ([NativeTypeName("long *")] int* p);

        [VtblIndex(10)]
        HRESULT get_deltaMode([NativeTypeName("ULONG *")] uint* p);

        [VtblIndex(11)]
        HRESULT initWheelEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, ushort buttonArg, IEventTarget* relatedTargetArg, [NativeTypeName("BSTR")] ushort* modifiersListArg, [NativeTypeName("long")] int deltaX, [NativeTypeName("long")] int deltaY, [NativeTypeName("long")] int deltaZ, [NativeTypeName("ULONG")] uint deltaMode);
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
        public delegate* unmanaged<TSelf*, int*, int> get_deltaX;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_deltaY;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_deltaZ;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_deltaMode;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, IHTMLWindow2 *, long, long, long, long, long, USHORT, IEventTarget *, BSTR, long, long, long, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, ushort, IEventTarget*, ushort*, int, int, int, uint, int> initWheelEvent;
    }
}
