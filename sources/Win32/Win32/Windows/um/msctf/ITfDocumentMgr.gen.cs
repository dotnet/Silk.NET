// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E7F4-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfDocumentMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfDocumentMgr : ITfDocumentMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfDocumentMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfDocumentMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfDocumentMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfDocumentMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateContext(
        [NativeTypeName("TfClientId")] uint tidOwner,
        [NativeTypeName("DWORD")] uint dwFlags,
        IUnknown punk,
        ITfContext* ppic,
        [NativeTypeName("TfEditCookie *")] uint* pecTextStore
    )
    {
        return (
            (delegate* unmanaged<ITfDocumentMgr, uint, uint, IUnknown, ITfContext*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, tidOwner, dwFlags, punk, ppic, pecTextStore);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Push(ITfContext pic)
    {
        return ((delegate* unmanaged<ITfDocumentMgr, ITfContext, int>)((*lpVtbl)[4]))(this, pic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pop([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfDocumentMgr, uint, int>)((*lpVtbl)[5]))(this, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTop(ITfContext* ppic)
    {
        return ((delegate* unmanaged<ITfDocumentMgr, ITfContext*, int>)((*lpVtbl)[6]))(this, ppic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBase(ITfContext* ppic)
    {
        return ((delegate* unmanaged<ITfDocumentMgr, ITfContext*, int>)((*lpVtbl)[7]))(this, ppic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumContexts(IEnumTfContexts* ppEnum)
    {
        return ((delegate* unmanaged<ITfDocumentMgr, IEnumTfContexts*, int>)((*lpVtbl)[8]))(
            this,
            ppEnum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateContext(
            [NativeTypeName("TfClientId")] uint tidOwner,
            [NativeTypeName("DWORD")] uint dwFlags,
            IUnknown punk,
            ITfContext* ppic,
            [NativeTypeName("TfEditCookie *")] uint* pecTextStore
        );

        [VtblIndex(4)]
        HRESULT Push(ITfContext pic);

        [VtblIndex(5)]
        HRESULT Pop([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(6)]
        HRESULT GetTop(ITfContext* ppic);

        [VtblIndex(7)]
        HRESULT GetBase(ITfContext* ppic);

        [VtblIndex(8)]
        HRESULT EnumContexts(IEnumTfContexts* ppEnum);
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

        [NativeTypeName(
            "HRESULT (TfClientId, DWORD, IUnknown *, ITfContext **, TfEditCookie *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            IUnknown,
            ITfContext*,
            uint*,
            int> CreateContext;

        [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext, int> Push;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Pop;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, int> GetTop;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, int> GetBase;

        [NativeTypeName("HRESULT (IEnumTfContexts **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfContexts*, int> EnumContexts;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfDocumentMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfDocumentMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfDocumentMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfDocumentMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfDocumentMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfDocumentMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfDocumentMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfDocumentMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
