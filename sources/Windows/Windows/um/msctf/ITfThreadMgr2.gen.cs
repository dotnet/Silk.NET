// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2"]/*' />
[Guid("0AB198EF-6477-4EE8-8812-6780EDB82D5E")]
[NativeTypeName("struct ITfThreadMgr2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITfThreadMgr2 : ITfThreadMgr2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadMgr2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, uint>)(lpVtbl[1]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, uint>)(lpVtbl[2]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.Activate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, uint*, int>)(lpVtbl[3]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ptid);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.Deactivate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, int>)(lpVtbl[4]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.CreateDocumentMgr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppdim);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.EnumDocumentMgrs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.GetFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFocus(ITfDocumentMgr** ppdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppdimFocus);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.SetFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFocus(ITfDocumentMgr* pdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), pdimFocus);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.IsThreadFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, BOOL*, int>)(lpVtbl[9]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), pfThreadFocus);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.GetFunctionProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[10]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.EnumFunctionProviders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, IEnumTfFunctionProviders**, int>)(lpVtbl[11]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.GetGlobalCompartment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, ITfCompartmentMgr**, int>)(lpVtbl[12]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppCompMgr);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.ActivateEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, uint*, uint, int>)(lpVtbl[13]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ptid, dwFlags);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.GetActiveFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags)
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, uint*, int>)(lpVtbl[14]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), lpdwFlags);
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.SuspendKeystrokeHandling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SuspendKeystrokeHandling()
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, int>)(lpVtbl[15]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfThreadMgr2.xml' path='doc/member[@name="ITfThreadMgr2.ResumeKeystrokeHandling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ResumeKeystrokeHandling()
    {
        return ((delegate* unmanaged<ITfThreadMgr2*, int>)(lpVtbl[16]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid);

        [VtblIndex(4)]
        HRESULT Deactivate();

        [VtblIndex(5)]
        HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim);

        [VtblIndex(6)]
        HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum);

        [VtblIndex(7)]
        HRESULT GetFocus(ITfDocumentMgr** ppdimFocus);

        [VtblIndex(8)]
        HRESULT SetFocus(ITfDocumentMgr* pdimFocus);

        [VtblIndex(9)]
        HRESULT IsThreadFocus(BOOL* pfThreadFocus);

        [VtblIndex(10)]
        HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv);

        [VtblIndex(11)]
        HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum);

        [VtblIndex(12)]
        HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr);

        [VtblIndex(13)]
        HRESULT ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(14)]
        HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags);

        [VtblIndex(15)]
        HRESULT SuspendKeystrokeHandling();

        [VtblIndex(16)]
        HRESULT ResumeKeystrokeHandling();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SuspendKeystrokeHandling;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeKeystrokeHandling;
    }
}
