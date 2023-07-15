// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDOMDragEvent.xml' path='doc/member[@name="IDOMDragEvent"]/*'/>
[Guid("30510761-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMDragEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMDragEvent : IDOMDragEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMDragEvent));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, Guid*, void**, int> )(lpVtbl[0]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMDragEvent*, uint> )(lpVtbl[1]))((IDOMDragEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMDragEvent*, uint> )(lpVtbl[2]))((IDOMDragEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, uint*, int> )(lpVtbl[3]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMDragEvent.xml' path='doc/member[@name="IDOMDragEvent.get_dataTransfer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_dataTransfer(IHTMLDataTransfer** p)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, IHTMLDataTransfer**, int> )(lpVtbl[7]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMDragEvent.xml' path='doc/member[@name="IDOMDragEvent.initDragEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT initDragEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, [NativeTypeName("VARIANT_BOOL")] short ctrlKeyArg, [NativeTypeName("VARIANT_BOOL")] short altKeyArg, [NativeTypeName("VARIANT_BOOL")] short shiftKeyArg, [NativeTypeName("VARIANT_BOOL")] short metaKeyArg, ushort buttonArg, IEventTarget* relatedTargetArg, IHTMLDataTransfer* dataTransferArg)
    {
        return ((delegate* unmanaged<IDOMDragEvent*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, short, short, short, short, ushort, IEventTarget*, IHTMLDataTransfer*, int> )(lpVtbl[8]))((IDOMDragEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, dataTransferArg);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_dataTransfer(IHTMLDataTransfer** p);
        [VtblIndex(8)]
        HRESULT initDragEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, [NativeTypeName("VARIANT_BOOL")] short ctrlKeyArg, [NativeTypeName("VARIANT_BOOL")] short altKeyArg, [NativeTypeName("VARIANT_BOOL")] short shiftKeyArg, [NativeTypeName("VARIANT_BOOL")] short metaKeyArg, ushort buttonArg, IEventTarget* relatedTargetArg, IHTMLDataTransfer* dataTransferArg);
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
        [NativeTypeName("HRESULT (IHTMLDataTransfer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDataTransfer**, int> get_dataTransfer;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, IHTMLWindow2 *, long, long, long, long, long, VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL, USHORT, IEventTarget *, IHTMLDataTransfer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, short, short, short, short, ushort, IEventTarget*, IHTMLDataTransfer*, int> initDragEvent;
    }
}