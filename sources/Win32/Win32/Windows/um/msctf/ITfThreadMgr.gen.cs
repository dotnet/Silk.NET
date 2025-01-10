// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E801-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfThreadMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfThreadMgr : ITfThreadMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfThreadMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
    {
        return ((delegate* unmanaged<ITfThreadMgr, uint*, int>)((*lpVtbl)[3]))(this, ptid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<ITfThreadMgr, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDocumentMgr(ITfDocumentMgr* ppdim)
    {
        return ((delegate* unmanaged<ITfThreadMgr, ITfDocumentMgr*, int>)((*lpVtbl)[5]))(
            this,
            ppdim
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs* ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgr, IEnumTfDocumentMgrs*, int>)((*lpVtbl)[6]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFocus(ITfDocumentMgr* ppdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr, ITfDocumentMgr*, int>)((*lpVtbl)[7]))(
            this,
            ppdimFocus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFocus(ITfDocumentMgr pdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr, ITfDocumentMgr, int>)((*lpVtbl)[8]))(
            this,
            pdimFocus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr pdimNew, ITfDocumentMgr* ppdimPrev)
    {
        return (
            (delegate* unmanaged<ITfThreadMgr, HWND, ITfDocumentMgr, ITfDocumentMgr*, int>)(
                (*lpVtbl)[9]
            )
        )(this, hwnd, pdimNew, ppdimPrev);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr, BOOL*, int>)((*lpVtbl)[10]))(
            this,
            pfThreadFocus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFunctionProvider(
        [NativeTypeName("const IID &")] Guid* clsid,
        ITfFunctionProvider* ppFuncProv
    )
    {
        return (
            (delegate* unmanaged<ITfThreadMgr, Guid*, ITfFunctionProvider*, int>)((*lpVtbl)[11])
        )(this, clsid, ppFuncProv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders* ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgr, IEnumTfFunctionProviders*, int>)((*lpVtbl)[12]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGlobalCompartment(ITfCompartmentMgr* ppCompMgr)
    {
        return ((delegate* unmanaged<ITfThreadMgr, ITfCompartmentMgr*, int>)((*lpVtbl)[13]))(
            this,
            ppCompMgr
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid);

        [VtblIndex(4)]
        HRESULT Deactivate();

        [VtblIndex(5)]
        HRESULT CreateDocumentMgr(ITfDocumentMgr* ppdim);

        [VtblIndex(6)]
        HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs* ppEnum);

        [VtblIndex(7)]
        HRESULT GetFocus(ITfDocumentMgr* ppdimFocus);

        [VtblIndex(8)]
        HRESULT SetFocus(ITfDocumentMgr pdimFocus);

        [VtblIndex(9)]
        HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr pdimNew, ITfDocumentMgr* ppdimPrev);

        [VtblIndex(10)]
        HRESULT IsThreadFocus(BOOL* pfThreadFocus);

        [VtblIndex(11)]
        HRESULT GetFunctionProvider(
            [NativeTypeName("const IID &")] Guid* clsid,
            ITfFunctionProvider* ppFuncProv
        );

        [VtblIndex(12)]
        HRESULT EnumFunctionProviders(IEnumTfFunctionProviders* ppEnum);

        [VtblIndex(13)]
        HRESULT GetGlobalCompartment(ITfCompartmentMgr* ppCompMgr);
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

        [NativeTypeName("HRESULT (TfClientId *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> Activate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Deactivate;

        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> CreateDocumentMgr;

        [NativeTypeName("HRESULT (IEnumTfDocumentMgrs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfDocumentMgrs*, int> EnumDocumentMgrs;

        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> GetFocus;

        [NativeTypeName("HRESULT (ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr, int> SetFocus;

        [NativeTypeName(
            "HRESULT (HWND, ITfDocumentMgr *, ITfDocumentMgr **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            ITfDocumentMgr,
            ITfDocumentMgr*,
            int> AssociateFocus;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsThreadFocus;

        [NativeTypeName("HRESULT (const IID &, ITfFunctionProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfFunctionProvider*, int> GetFunctionProvider;

        [NativeTypeName("HRESULT (IEnumTfFunctionProviders **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfFunctionProviders*, int> EnumFunctionProviders;

        [NativeTypeName("HRESULT (ITfCompartmentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompartmentMgr*, int> GetGlobalCompartment;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfThreadMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfThreadMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfThreadMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfThreadMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfThreadMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfThreadMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfThreadMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfThreadMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
