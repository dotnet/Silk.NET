// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E80E-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfThreadMgrEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfThreadMgrEventSink : ITfThreadMgrEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadMgrEventSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnInitDocumentMgr(ITfDocumentMgr pdim)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, ITfDocumentMgr, int>)((*lpVtbl)[3]))(
            this,
            pdim
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnUninitDocumentMgr(ITfDocumentMgr pdim)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, ITfDocumentMgr, int>)((*lpVtbl)[4]))(
            this,
            pdim
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnSetFocus(ITfDocumentMgr pdimFocus, ITfDocumentMgr pdimPrevFocus)
    {
        return (
            (delegate* unmanaged<ITfThreadMgrEventSink, ITfDocumentMgr, ITfDocumentMgr, int>)(
                (*lpVtbl)[5]
            )
        )(this, pdimFocus, pdimPrevFocus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnPushContext(ITfContext pic)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, ITfContext, int>)((*lpVtbl)[6]))(
            this,
            pic
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPopContext(ITfContext pic)
    {
        return ((delegate* unmanaged<ITfThreadMgrEventSink, ITfContext, int>)((*lpVtbl)[7]))(
            this,
            pic
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnInitDocumentMgr(ITfDocumentMgr pdim);

        [VtblIndex(4)]
        HRESULT OnUninitDocumentMgr(ITfDocumentMgr pdim);

        [VtblIndex(5)]
        HRESULT OnSetFocus(ITfDocumentMgr pdimFocus, ITfDocumentMgr pdimPrevFocus);

        [VtblIndex(6)]
        HRESULT OnPushContext(ITfContext pic);

        [VtblIndex(7)]
        HRESULT OnPopContext(ITfContext pic);
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
        public delegate* unmanaged<TSelf*, ITfDocumentMgr, int> OnInitDocumentMgr;

        [NativeTypeName("HRESULT (ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr, int> OnUninitDocumentMgr;

        [NativeTypeName("HRESULT (ITfDocumentMgr *, ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr, ITfDocumentMgr, int> OnSetFocus;

        [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext, int> OnPushContext;

        [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext, int> OnPopContext;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfThreadMgrEventSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfThreadMgrEventSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfThreadMgrEventSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfThreadMgrEventSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfThreadMgrEventSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfThreadMgrEventSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfThreadMgrEventSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfThreadMgrEventSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
