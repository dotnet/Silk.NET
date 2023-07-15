// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfThreadMgrEventSink.xml' path='doc/member[@name="ITfThreadMgrEventSink"]/*'/>
[Guid("AA80E80E-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfThreadMgrEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfThreadMgrEventSink : ITfThreadMgrEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadMgrEventSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, uint> )(lpVtbl[1]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, uint> )(lpVtbl[2]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfThreadMgrEventSink.xml' path='doc/member[@name="ITfThreadMgrEventSink.OnInitDocumentMgr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnInitDocumentMgr(ITfDocumentMgr* pdim)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, int> )(lpVtbl[3]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdim);
    }

    /// <include file='ITfThreadMgrEventSink.xml' path='doc/member[@name="ITfThreadMgrEventSink.OnUninitDocumentMgr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnUninitDocumentMgr(ITfDocumentMgr* pdim)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, int> )(lpVtbl[4]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdim);
    }

    /// <include file='ITfThreadMgrEventSink.xml' path='doc/member[@name="ITfThreadMgrEventSink.OnSetFocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnSetFocus(ITfDocumentMgr* pdimFocus, ITfDocumentMgr* pdimPrevFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, ITfDocumentMgr*, int> )(lpVtbl[5]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdimFocus, pdimPrevFocus);
    }

    /// <include file='ITfThreadMgrEventSink.xml' path='doc/member[@name="ITfThreadMgrEventSink.OnPushContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnPushContext(ITfContext* pic)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfContext*, int> )(lpVtbl[6]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pic);
    }

    /// <include file='ITfThreadMgrEventSink.xml' path='doc/member[@name="ITfThreadMgrEventSink.OnPopContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPopContext(ITfContext* pic)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfContext*, int> )(lpVtbl[7]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pic);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnInitDocumentMgr(ITfDocumentMgr* pdim);
        [VtblIndex(4)]
        HRESULT OnUninitDocumentMgr(ITfDocumentMgr* pdim);
        [VtblIndex(5)]
        HRESULT OnSetFocus(ITfDocumentMgr* pdimFocus, ITfDocumentMgr* pdimPrevFocus);
        [VtblIndex(6)]
        HRESULT OnPushContext(ITfContext* pic);
        [VtblIndex(7)]
        HRESULT OnPopContext(ITfContext* pic);
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
        [NativeTypeName("HRESULT (ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> OnInitDocumentMgr;
        [NativeTypeName("HRESULT (ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> OnUninitDocumentMgr;
        [NativeTypeName("HRESULT (ITfDocumentMgr *, ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, ITfDocumentMgr*, int> OnSetFocus;
        [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, int> OnPushContext;
        [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, int> OnPopContext;
    }
}