// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfThreadMgrEx.xml' path='doc/member[@name="ITfThreadMgrEx"]/*' />
[Guid("3E90ADE3-7594-4CB0-BB58-69628F5F458C")]
[NativeTypeName("struct ITfThreadMgrEx : ITfThreadMgr")]
[NativeInheritance("ITfThreadMgr")]
public unsafe partial struct ITfThreadMgrEx : ITfThreadMgrEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadMgrEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, uint>)(lpVtbl[1]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, uint>)(lpVtbl[2]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfThreadMgr.Activate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, int>)(lpVtbl[3]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ptid);
    }

    /// <inheritdoc cref="ITfThreadMgr.Deactivate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, int>)(lpVtbl[4]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfThreadMgr.CreateDocumentMgr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppdim);
    }

    /// <inheritdoc cref="ITfThreadMgr.EnumDocumentMgrs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <inheritdoc cref="ITfThreadMgr.GetFocus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFocus(ITfDocumentMgr** ppdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppdimFocus);
    }

    /// <inheritdoc cref="ITfThreadMgr.SetFocus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFocus(ITfDocumentMgr* pdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), pdimFocus);
    }

    /// <inheritdoc cref="ITfThreadMgr.AssociateFocus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr* pdimNew, ITfDocumentMgr** ppdimPrev)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, HWND, ITfDocumentMgr*, ITfDocumentMgr**, int>)(lpVtbl[9]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), hwnd, pdimNew, ppdimPrev);
    }

    /// <inheritdoc cref="ITfThreadMgr.IsThreadFocus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, BOOL*, int>)(lpVtbl[10]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), pfThreadFocus);
    }

    /// <inheritdoc cref="ITfThreadMgr.GetFunctionProvider" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[11]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
    }

    /// <inheritdoc cref="ITfThreadMgr.EnumFunctionProviders" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, IEnumTfFunctionProviders**, int>)(lpVtbl[12]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <inheritdoc cref="ITfThreadMgr.GetGlobalCompartment" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, ITfCompartmentMgr**, int>)(lpVtbl[13]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppCompMgr);
    }

    /// <include file='ITfThreadMgrEx.xml' path='doc/member[@name="ITfThreadMgrEx.ActivateEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, uint, int>)(lpVtbl[14]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ptid, dwFlags);
    }

    /// <include file='ITfThreadMgrEx.xml' path='doc/member[@name="ITfThreadMgrEx.GetActiveFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags)
    {
        return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, int>)(lpVtbl[15]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), lpdwFlags);
    }

    public interface Interface : ITfThreadMgr.Interface
    {
        [VtblIndex(14)]
        HRESULT ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags);

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
        public delegate* unmanaged<TSelf*, ITfDocumentMgr**, int> CreateDocumentMgr;

        [NativeTypeName("HRESULT (IEnumTfDocumentMgrs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfDocumentMgrs**, int> EnumDocumentMgrs;

        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr**, int> GetFocus;

        [NativeTypeName("HRESULT (ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfDocumentMgr*, int> SetFocus;

        [NativeTypeName("HRESULT (HWND, ITfDocumentMgr *, ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ITfDocumentMgr*, ITfDocumentMgr**, int> AssociateFocus;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsThreadFocus;

        [NativeTypeName("HRESULT (const IID &, ITfFunctionProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfFunctionProvider**, int> GetFunctionProvider;

        [NativeTypeName("HRESULT (IEnumTfFunctionProviders **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfFunctionProviders**, int> EnumFunctionProviders;

        [NativeTypeName("HRESULT (ITfCompartmentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompartmentMgr**, int> GetGlobalCompartment;

        [NativeTypeName("HRESULT (TfClientId *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, int> ActivateEx;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetActiveFlags;
    }
}
