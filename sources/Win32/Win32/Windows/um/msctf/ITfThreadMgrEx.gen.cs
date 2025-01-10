// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3E90ADE3-7594-4CB0-BB58-69628F5F458C")]
[NativeTypeName("struct ITfThreadMgrEx : ITfThreadMgr")]
[NativeInheritance("ITfThreadMgr")]
public unsafe partial struct ITfThreadMgrEx : ITfThreadMgrEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadMgrEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfThreadMgrEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, uint*, int>)((*lpVtbl)[3]))(this, ptid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDocumentMgr(ITfDocumentMgr* ppdim)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, ITfDocumentMgr*, int>)((*lpVtbl)[5]))(
            this,
            ppdim
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs* ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, IEnumTfDocumentMgrs*, int>)((*lpVtbl)[6]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFocus(ITfDocumentMgr* ppdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, ITfDocumentMgr*, int>)((*lpVtbl)[7]))(
            this,
            ppdimFocus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFocus(ITfDocumentMgr pdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, ITfDocumentMgr, int>)((*lpVtbl)[8]))(
            this,
            pdimFocus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr pdimNew, ITfDocumentMgr* ppdimPrev)
    {
        return (
            (delegate* unmanaged<ITfThreadMgrEx, HWND, ITfDocumentMgr, ITfDocumentMgr*, int>)(
                (*lpVtbl)[9]
            )
        )(this, hwnd, pdimNew, ppdimPrev);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, BOOL*, int>)((*lpVtbl)[10]))(
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
            (delegate* unmanaged<ITfThreadMgrEx, Guid*, ITfFunctionProvider*, int>)((*lpVtbl)[11])
        )(this, clsid, ppFuncProv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders* ppEnum)
    {
        return (
            (delegate* unmanaged<ITfThreadMgrEx, IEnumTfFunctionProviders*, int>)((*lpVtbl)[12])
        )(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGlobalCompartment(ITfCompartmentMgr* ppCompMgr)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, ITfCompartmentMgr*, int>)((*lpVtbl)[13]))(
            this,
            ppCompMgr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ActivateEx(
        [NativeTypeName("TfClientId *")] uint* ptid,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, uint*, uint, int>)((*lpVtbl)[14]))(
            this,
            ptid,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx, uint*, int>)((*lpVtbl)[15]))(this, lpdwFlags);
    }

    public interface Interface : ITfThreadMgr.Interface
    {
        [VtblIndex(14)]
        HRESULT ActivateEx(
            [NativeTypeName("TfClientId *")] uint* ptid,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(15)]
        HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags);
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

        [NativeTypeName("HRESULT (TfClientId *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, int> ActivateEx;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetActiveFlags;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfThreadMgrEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfThreadMgrEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfThreadMgr"/> to <see cref = "ITfThreadMgrEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfThreadMgr"/> instance to be converted </param>
    public static explicit operator ITfThreadMgrEx(Silk.NET.Windows.ITfThreadMgr value)
    {
        return new ITfThreadMgrEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfThreadMgrEx"/> to <see cref = "Silk.NET.Windows.ITfThreadMgr"/>.</summary>
    /// <param name = "value">The <see cref = "ITfThreadMgrEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfThreadMgr(ITfThreadMgrEx value)
    {
        return new Silk.NET.Windows.ITfThreadMgr(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfThreadMgrEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfThreadMgrEx(Silk.NET.Windows.IUnknown value)
    {
        return new ITfThreadMgrEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfThreadMgrEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfThreadMgrEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfThreadMgrEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
