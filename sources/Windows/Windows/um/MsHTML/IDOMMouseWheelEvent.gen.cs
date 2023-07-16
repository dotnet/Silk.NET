// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDOMMouseWheelEvent.xml' path='doc/member[@name="IDOMMouseWheelEvent"]/*'/>
[Guid("305106D0-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMMouseWheelEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMMouseWheelEvent : IDOMMouseWheelEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMMouseWheelEvent));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, Guid*, void**, int> )(lpVtbl[0]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, uint> )(lpVtbl[1]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, uint> )(lpVtbl[2]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, uint*, int> )(lpVtbl[3]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMMouseWheelEvent.xml' path='doc/member[@name="IDOMMouseWheelEvent.get_wheelDelta"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_wheelDelta([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, int*, int> )(lpVtbl[7]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMouseWheelEvent.xml' path='doc/member[@name="IDOMMouseWheelEvent.initMouseWheelEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT initMouseWheelEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, ushort buttonArg, IEventTarget* relatedTargetArg, [NativeTypeName("BSTR")] ushort* modifiersListArg, [NativeTypeName("long")] int wheelDeltaArg)
    {
        return ((delegate* unmanaged<IDOMMouseWheelEvent*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, ushort, IEventTarget*, ushort*, int, int> )(lpVtbl[8]))((IDOMMouseWheelEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, buttonArg, relatedTargetArg, modifiersListArg, wheelDeltaArg);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_wheelDelta([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT initMouseWheelEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, ushort buttonArg, IEventTarget* relatedTargetArg, [NativeTypeName("BSTR")] ushort* modifiersListArg, [NativeTypeName("long")] int wheelDeltaArg);
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
        public delegate* unmanaged<TSelf*, int*, int> get_wheelDelta;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, IHTMLWindow2 *, long, long, long, long, long, USHORT, IEventTarget *, BSTR, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, ushort, IEventTarget*, ushort*, int, int> initMouseWheelEvent;
    }
}