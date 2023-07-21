// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITextStoreACPSinkEx.xml' path='doc/member[@name="ITextStoreACPSinkEx"]/*' />
[Guid("2BDF9464-41E2-43E3-950C-A6865BA25CD4")]
[NativeTypeName("struct ITextStoreACPSinkEx : ITextStoreACPSink")]
[NativeInheritance("ITextStoreACPSink")]
public unsafe partial struct ITextStoreACPSinkEx : ITextStoreACPSinkEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextStoreACPSinkEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint>)(lpVtbl[1]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint>)(lpVtbl[2]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnTextChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnTextChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint, TS_TEXTCHANGE*, int>)(lpVtbl[3]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), dwFlags, pChange);
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnSelectionChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnSelectionChange()
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[4]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnLayoutChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView)
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, TsLayoutCode, uint, int>)(lpVtbl[5]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), lcode, vcView);
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnStatusChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint, int>)(lpVtbl[6]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnAttrsChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnAttrsChange([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("ULONG")] uint cAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs)
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, int, int, uint, Guid*, int>)(lpVtbl[7]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), acpStart, acpEnd, cAttrs, paAttrs);
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnLockGranted" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags)
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint, int>)(lpVtbl[8]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), dwLockFlags);
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnStartEditTransaction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnStartEditTransaction()
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[9]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITextStoreACPSink.OnEndEditTransaction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnEndEditTransaction()
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[10]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextStoreACPSinkEx.xml' path='doc/member[@name="ITextStoreACPSinkEx.OnDisconnect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnDisconnect()
    {
        return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[11]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ITextStoreACPSink.Interface
    {
        [VtblIndex(11)]
        HRESULT OnDisconnect();
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

        [NativeTypeName("HRESULT (DWORD, const TS_TEXTCHANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TS_TEXTCHANGE*, int> OnTextChange;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnSelectionChange;

        [NativeTypeName("HRESULT (TsLayoutCode, TsViewCookie) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TsLayoutCode, uint, int> OnLayoutChange;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnStatusChange;

        [NativeTypeName("HRESULT (LONG, LONG, ULONG, const TS_ATTRID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, uint, Guid*, int> OnAttrsChange;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnLockGranted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnStartEditTransaction;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnEndEditTransaction;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnDisconnect;
    }
}
